Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports MaterialSkin
Imports System
Imports System.IO
Imports System.Text


Public Class scrIniciarsesion

    Dim base As String
    Dim contra As String

    Private Sub scrInicio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    'carga_iniciales()

        '    Dim SkinManager As MaterialSkinManager = MaterialSkinManager.Instance
        '    SkinManager.AddFormToManage(Me)
        '    SkinManager.Theme = MaterialSkinManager.Themes.LIGHT
        '    'SkinManager.ColorScheme = New ColorScheme(Primary.Blue900, Primary.Blue800, Primary.Blue800, Accent.Blue700, TextShade.WHITE)   'CCCM
        '    SkinManager.ColorScheme = New ColorScheme(Primary.Red900, Primary.Red800, Primary.Red800, Accent.Red700, TextShade.WHITE)   'CCCM
        archivo_texto()
    End Sub

    Public Sub busca_empresas()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select ba.nombre_emp from users us join user_bases usba on us.id_user = usba.id_user join bases ba on usba.id_base = ba.id_base where us.user_name = '" & cbUsuarios.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cbEmpresa.Items.Add(resultado.GetString("nombre_emp"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "ContaGo ERP (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub btnIniciar_Click(sender As Object, e As EventArgs) Handles btnIniciar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbEmpresa.Text = "" Then
            MessageBox.Show("Seleccione una empresa", "ContaGo ERP (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbEmpresa.Focus()
            Return
        End If

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select base from bases where nombre_emp = '" & cbEmpresa.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                var_globales.base = resultado.GetString("base")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "ContaGo ERP (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        escribe_archivo()

        scrPrincipal2.lblNUsuario.Text = cbUsuarios.Text
        scrPrincipal2.Text = cbEmpresa.Text
        Me.Close()
    End Sub

    Private Sub btnVerifica_Click(sender As Object, e As EventArgs) Handles btnVerifica.Click
        verifica_usuario()
    End Sub

    Public Sub verifica_usuario()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        var_globales.ip = cbConexion.Text
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from users where user_name = '" & cbUsuarios.Text & "' and pass = SHA('" & tbContra.Text & "')", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            'MessageBox.Show(ex.Message, "ContaGo ERP (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If b = True Then
            MessageBox.Show("Bienvenido", "Auto-Conta 1.0 (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

            cbEmpresa.Enabled = True
            busca_empresas()
            cbConexion.Enabled = False
            cbUsuarios.Enabled = False
            tbContra.Enabled = False
        Else
            MessageBox.Show("Contraseña Incorrecta", "Auto-Conta 1.0 (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbContra.Text = ""
            tbContra.Focus()
            Return
        End If

    End Sub

    Public Sub archivo_texto()
        Dim path As String = "c:\sesion\conexion.txt"
        Dim texto As String = ""
        Dim conexion As String = ""
        Dim usuario As String = ""

        Dim guion As Boolean = False

        If File.Exists(path) = False Then
            Directory.CreateDirectory("C:\sesion")
            File.Create(path)
        Else
            texto = My.Computer.FileSystem.ReadAllText(path)
            For i = 0 To Len(texto) - 1
                If texto(i) = "_" Then
                    guion = True
                End If

                If texto(i) <> "_" Then
                    If guion Then
                        usuario = usuario & texto(i)
                    Else
                        conexion = conexion & texto(i)
                    End If
                End If

            Next
            cbConexion.Text = conexion
            cbUsuarios.Text = usuario

        End If
    End Sub

    Public Sub escribe_archivo()
        Dim path As String = "c:\sesion\conexion.txt"
        Dim texto As String = cbConexion.Text & "_" & cbUsuarios.Text

        File.WriteAllText(path, texto)

    End Sub

#Region "KEYDOWN"
    Private Sub cbConexion_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case Keys.Enter
                cbUsuarios.Focus()
        End Select
    End Sub

    Private Sub cbEmpresa_KeyDown(sender As Object, e As KeyEventArgs) Handles cbEmpresa.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnIniciar.Focus()
        End Select
    End Sub

    Private Sub cbUsuarios_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case Keys.Enter
                tbContra.Focus()
        End Select
    End Sub

    Private Sub tbContra_KeyDown(sender As Object, e As KeyEventArgs)
        Select Case e.KeyData
            Case Keys.Enter
                btnVerifica.Focus()
        End Select
    End Sub

    'Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
    '    scrUsuarios.Show()
    'End Sub

    Private Sub tbContra_KeyDown_1(sender As Object, e As KeyEventArgs) Handles tbContra.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                btnVerifica.Focus()
        End Select
    End Sub

#End Region

End Class