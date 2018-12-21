Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Data.OleDb

Public Class scrAltaCatalogo

    Dim id_cuenta As Integer = 0

#Region "Funciones"
    Public Sub cargadata()

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False

        dgvCatalogo.Rows.Clear()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read

                b = True

            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If b = True Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select cc.id_cuenta, cc.numero_cuenta, cc.nombre_cuenta, ccs.numero_cuenta sat1, ccs.nombre_cuenta sat2 from catalogo_contable cc join (catalogo_cuentas_sat ccs) on (cc.cuenta_sat = ccs.id) ", _conexion)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read

                    dgvCatalogo.Rows.Add(resultado.GetString("id_cuenta"), resultado.GetString("numero_cuenta"), resultado.GetString("nombre_cuenta"), resultado.GetString("sat1"), resultado.GetString("sat2"))

                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

    End Sub

    Public Function importarExcelNominarfc(ByVal tabla As DataGridView) As Boolean
        Dim myFileDialog As New OpenFileDialog()
        'Dim xSheet As String = ""

        'Activamos los filtros y mostramos el cuadro de abrir archivo
        With myFileDialog
            .Filter = "Excel 2007|*.xlsx"
            .Title = "Open File"
            .InitialDirectory = "C:\Documentos"
        End With
        'Dentro de un IF comprobamos que exista una ruta al archivo

        Dim result As DialogResult = myFileDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            If myFileDialog.FileName.ToString <> "" Then
                Dim ExcelFile As String = myFileDialog.FileName.ToString
                Dim dataset As New DataSet
                Dim datadapter As OleDbDataAdapter
                Dim datatable As DataTable
                Dim conn As OleDbConnection

                'Generamos el objeto de la conexión para abrir el archivo
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFile + ";Extended Properties=Excel 12.0;")

                'Dentro de un TRY abrimos el archivo para manejar las excepciones
                Try
                    datadapter = New OleDbDataAdapter("SELECT * FROM [Hoja1$]", conn)
                    conn.Open()
                    datadapter.Fill(dataset, "MyData")
                    datatable = dataset.Tables("MyData")
                    tabla.DataSource = dataset
                    tabla.DataMember = "MyData"
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

                Return True
            End If
            Return False
        Else
            Return False
        End If
        ' MsgBox("Información Actualizada", MsgBoxStyle.Information, "Importación Finalizada")
    End Function

    Public Sub get_padre_naturaleza(ByRef padre As String, ByRef naturaleza As String, ByVal id As Integer)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where id_cuenta = '" & id & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                padre = resultado.GetString("id_cuenta_padre")
                naturaleza = resultado.GetString("naturaleza")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where id_cuenta = '" & padre & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                padre = resultado.GetString("numero_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub
#End Region

    Private Sub scrAltaCatalogo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbNaturaleza.Items.Add("-Selecciona Naturaleza-")
        cbNaturaleza.Items.Add("A")
        cbNaturaleza.Items.Add("D")
        cbNaturaleza.SelectedIndex = 0
        cbNaturaleza.DropDownStyle = ComboBoxStyle.DropDownList
        cargadata()

        cbCuentaSAT.Items.Clear()
        cbNombreSAT.Items.Clear()

        'CARGAMOS CATÁLOGO DE CUENTAS SAT
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_cuentas_sat where tipo = 'R' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cbCuentaSAT.Items.Add(resultado.GetString("numero_cuenta"))
                cbNombreSAT.Items.Add(resultado.GetString("nombre_cuenta"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        Dim conexion As New Class_insert
        Dim conexionU As New Class_update
        Dim datos As New Class_datos

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim cuentahijo As String = ""
        Dim conta As Integer = 0
        Dim b As Boolean = False
        Dim id_cuenta_sat As Integer = 0

#Region "Condiciones"
        If lblCuentaPadre.Text = tbNumerocuenta.Text Then
            MessageBox.Show("Error al guardar, El numero de la cuenta no puede ser igual al numero de cuenta padre", "Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbNombrecuenta.Text = "" Then
            MessageBox.Show("Error al guardar, El nombre de la cuenta no puede estar vacio", "Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNombrecuenta.Focus()
            Return
        End If

        If tbNumerocuenta.Text = "" Then
            MessageBox.Show("Error al guardar, El numero de la cuenta no puede estar vacio", "Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNumerocuenta.Focus()
            Return
        End If

        If tbNumerocuenta.Text.ToString.IndexOf(".") <> -1 Then
            If lblCuentaPadre.Text = "XXXX" Then
                MessageBox.Show("La cuenta padre no ha sido dada de alta, debe dar de alta la cuenta padre antes de continuar", "Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        End If
#End Region

        'COMPROBAMOS SI LA CUENTA YA FUE DADA DE ALTA ANTERIORMENTE 
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & tbNumerocuenta.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                MessageBox.Show("error al guardar la cuenta contable, Esta cuenta contable ya fue dada de alta con anterioridad", "Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                tbNumerocuenta.Focus()
                Return
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'OBTENEMOS ID DE LA CUENTA DEL SAT
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_cuentas_sat where numero_cuenta = '" & cbCuentaSAT.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_cuenta_sat = resultado.GetString("id")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If lblCuentaPadre.Text = "XXXX" Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable", _conexion)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    b = True
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If b = True Then
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from catalogo_contable", _conexion)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        Dim cuentapadreid As String
                        cuentapadreid = resultado.GetString("id_cuenta")
                        datos.id_cuenta_padre = cuentapadreid + 1
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Else
                datos.id_cuenta_padre = 1
            End If

            Completa_cuenta(tbNumerocuenta.Text)
            datos.numero_cuenta_unico = var_globales.ccontableunica

            If cbNaturaleza.Text = "A" Then
                datos.naturaleza = "A"
            Else
                datos.naturaleza = "D"
            End If

        Else
            Dim Nat As Char
            Dim cuenta As String
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & lblCuentaPadre.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_cuenta_padre = resultado.GetString("id_cuenta_padre")
                    cuenta = resultado.GetString("numero_cuenta_unico")
                    Nat = resultado.GetChar("naturaleza")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            Dim tam As Integer
            Dim tam1 As Integer

            tam = Len(lblCuentaPadre.Text)
            tam1 = Len(tbNumerocuenta.Text)

            tbNumerocuenta.Text.Substring(tam + 1, tam1 - (tam + 1))

            Completa_cuenta(tbNumerocuenta.Text.Substring(tam + 1, tam1 - (tam + 1)))

            datos.numero_cuenta_unico = cuenta & "." & var_globales.ccontableunica
            datos.naturaleza = Nat

        End If

        datos.numero_cuenta = tbNumerocuenta.Text
        datos.nombre_cuenta = tbNombrecuenta.Text
        datos.tipo = "R"
        datos.cuenta_sat = id_cuenta_sat

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_contabilidad.users where user_name = '" & scrPrincipal2.lblNUsuario.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                datos.id_usuario = resultado.GetString("id_user")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If conexion.insertarcatalogo(datos) Then
            If lblCuentaPadre.Text = "XXXX" Then
                dgvCatalogo.Rows.Clear()
                cargadata()

                MessageBox.Show("Cuenta contable creada correctamente", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

                cbNaturaleza.Text = ""
                tbNombrecuenta.Text = ""
                tbNumerocuenta.Text = ""
                lblCuentaPadre.Text = "XXXX"
                lblNaturaleza.Visible = True
                cbNaturaleza.Visible = True

            Else
                'sacamos el id de la cuenta padre
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & lblCuentaPadre.Text & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        datos.id_cuenta_padre = resultado.GetString("id_cuenta")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                If conexionU.actualizarcuentaPadre(datos) Then

                    dgvCatalogo.Rows.Clear()
                    cargadata()

                    MessageBox.Show("Cuenta contable creada correctamente", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    cbNaturaleza.Text = ""
                    tbNombrecuenta.Text = ""
                    tbNumerocuenta.Text = ""
                    lblCuentaPadre.Text = "XXXX"
                    lblNaturaleza.Visible = True
                    cbNaturaleza.Visible = True

                Else
                    MessageBox.Show("Error al crear la cuenta contable", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End If
            End If
        Else
            MessageBox.Show("Error al crear la cuenta contable", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub tbNumerocuenta_KeyPress(sender As Object, e As KeyPressEventArgs)

        If Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf e.KeyChar = "." Then
            e.Handled = False
        Else
            e.Handled = True
        End If

    End Sub

    Private Sub tbNumerocuenta_KeyDown(sender As Object, e As KeyEventArgs)

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim conta As Integer
        Dim bandera As Boolean = False
        Dim c2 As Integer = 0
        Dim bandera2 As Boolean = False
        Dim idsat As String = ""
        Dim conta1 As Integer = 0
        Dim banderaen As Boolean = False
        Dim csat As String = ""


        Select Case e.KeyData

            Case Keys.Enter

            Case Keys.Decimal

                For Each c As Char In tbNumerocuenta.Text
                    conta += 1
                Next

                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & tbNumerocuenta.Text.Substring(0, conta) & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        lblCuentaPadre.Text = tbNumerocuenta.Text.Substring(0, conta)
                        bandera = True
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                If bandera = False Then
                    lblCuentaPadre.Text = "La cuenta padre no existe en contabilidad"
                End If

            Case Keys.Back

                conta = 0

                For Each c As Char In tbNumerocuenta.Text
                    If c = "." Then
                        conta += 1
                    End If
                Next

                If conta = 0 Then
                    lblCuentaPadre.Text = "XXXX"
                End If

        End Select

        If lblCuentaPadre.Text = "XXXX" Then

            lblNaturaleza.Visible = True
            cbNaturaleza.Visible = True
            'lblNumero.Location = New Point(12, 180)
            'tbNumerocuenta.Location = New Point(309, 177)
            'lblNombre.Location = New Point(12, 212)
            'tbNombrecuenta.Location = New Point(174, 209)

        Else

            If lblCuentaPadre.Text = "La cuenta padre no existe en contabilidad" Then


            Else
                lblNaturaleza.Visible = False
                cbNaturaleza.Visible = False
                'lblNumero.Location = New Point(12, 140)
                'tbNumerocuenta.Location = New Point(309, 137)
                'lblNombre.Location = New Point(12, 176)
                'tbNombrecuenta.Location = New Point(174, 173)

            End If

        End If

    End Sub

    Private Sub tbNumerocuenta_TextChanged(sender As Object, e As EventArgs)

        Dim conta As Integer

        For Each c As Char In tbNumerocuenta.Text
            If c = "." Then
                conta += 0
            End If
        Next

    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim indice As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim conexionD As New Class_delete
        Dim datos As New Class_datos
        Dim cuenta As String
        Dim b As Boolean = False

        indice = dgvCatalogo.CurrentRow.Index.ToString
        cuenta = dgvCatalogo.Rows(indice).Cells(1).Value.ToString()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cuenta & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read

                If resultado.GetString("tipo") = "A" Then
                    MessageBox.Show("No se puede eliminar una cuenta que no sea de registro", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("SELECT * FROM polizas_det pol join catalogo_contable cat on pol.id_cuenta = cat.id_cuenta where cat.numero_cuenta =  '" & cuenta & "' and pol.estado <> 'cancelado'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If b = True Then
            MessageBox.Show("No se puede eliminar una cuenta que se este utilizando en polizas", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        datos.id_cuenta_padre = dgvCatalogo.Rows(indice).Cells(0).Value.ToString()

        If conexionD.borrarcuenta(datos) Then

            cargadata()
            MessageBox.Show("Cuenta borrada correctamente", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub EditarToolStripMenuItem_Click(sender As Object, e As EventArgs)

        Dim indice As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        ' Dim conexionD As New Class_delete
        Dim datos As New Class_datos
        Dim CUENTA As String
        Dim id As String
        Dim id_cp As String
        Dim cuentaunica As String

        indice = dgvCatalogo.CurrentRow.Index.ToString
        CUENTA = dgvCatalogo.Rows(indice).Cells(1).Value.ToString()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & CUENTA & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read

                id = resultado.GetString("id_cuenta")
                id_cp = resultado.GetString("id_cuenta_padre")

                If id = id_cp Then
                    lblCuentaPadre.Text = "XXXX"
                End If

                cuentaunica = resultado.GetString("numero_cuenta_unico")
                tbNumerocuenta.Text = resultado.GetString("numero_cuenta")
                tbNombrecuenta.Text = resultado.GetString("nombre_cuenta")
                lblIdCuenta.Text = id

            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

    End Sub

    Private Sub btnCargaCat_Click(sender As Object, e As EventArgs) Handles btnCargaCat.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        importarExcelNominarfc(dgvCatalogo2)

        Dim id_padre As Integer = 0

        For Each row As DataGridViewRow In dgvCatalogo2.Rows
            Dim aux() As String = row.Cells(0).Value.ToString.Split(".")

            If row.Cells(0).Value.ToString.IndexOf(".") = -1 Then
                'INSERTA EN EL CATÁLOGO
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("insert into catalogo_cuentas_sat (numero_cuenta,nombre_cuenta,tipo,naturaleza) values ('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','A','" & row.Cells(2).Value & "')", _conexion)
                    resultado = comandoSql.ExecuteReader
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
                'CONSULTA EL PADRE
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from catalogo_cuentas_sat where numero_cuenta = '" & row.Cells(0).Value & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_padre = resultado.GetInt64("id")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
                'ACTUALIZA
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" update catalogo_cuentas_sat set id_cuenta_padre_sat = '" & id_padre & "' where numero_cuenta = '" & row.Cells(0).Value & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Else
                'INSERTA EN EL CATÁLOGO
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("insert into catalogo_cuentas_sat (numero_cuenta,nombre_cuenta,tipo,naturaleza) values ('" & row.Cells(0).Value & "','" & row.Cells(1).Value & "','R','" & row.Cells(2).Value & "')", _conexion)
                    resultado = comandoSql.ExecuteReader
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
                'CONSULTA EL PADRE
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from catalogo_cuentas_sat where numero_cuenta = '" & aux(0) & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_padre = resultado.GetInt64("id")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
                'ACTUALIZA
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" update catalogo_cuentas_sat set id_cuenta_padre_sat = '" & id_padre & "' where numero_cuenta = '" & row.Cells(0).Value & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            End If
        Next

        MsgBox("Listo")
    End Sub

    Private Sub cbCuentaSAT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCuentaSAT.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_cuentas_sat where numero_cuenta = '" & cbCuentaSAT.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cbNombreSAT.Text = resultado.GetString("nombre_cuenta")
                cbNaturaleza.Text = resultado.GetString("naturaleza")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

    End Sub

    Private Sub tbNumerocuenta_Click(sender As Object, e As EventArgs) Handles tbNumerocuenta.LostFocus
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim aux() As String = tbNumerocuenta.Text.ToString.Split(".")

        lblCuentaPadre.Text = "XXXX"

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & aux(0) & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                lblCuentaPadre.Text = resultado.GetString("numero_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub btnNCuenta_Click(sender As Object, e As EventArgs) Handles btnNCuenta.Click
        btnNCuenta.Visible = False
        btnCancelaEdit.Visible = True
        btnElimina.Visible = False
        btnEditar.Visible = False
        btnGuarda.Visible = True
        btnActualiza.Visible = False

        lblCuentaPadre.Text = "XXXX"
        cbNaturaleza.Text = ""
        tbNumerocuenta.Text = ""
        tbNombrecuenta.Text = ""
        cbCuentaSAT.Text = ""
        cbNombreSAT.Text = ""

        cbNaturaleza.Enabled = True
        tbNumerocuenta.Enabled = True
        tbNombrecuenta.Enabled = True
        cbCuentaSAT.Enabled = True
        cbNombreSAT.Enabled = True
    End Sub

    Private Sub btnCancelaEdit_Click(sender As Object, e As EventArgs) Handles btnCancelaEdit.Click
        btnNCuenta.Visible = True
        btnCancelaEdit.Visible = False
        btnElimina.Visible = False
        btnEditar.Visible = False
        btnGuarda.Visible = False
        btnActualiza.Visible = False

        lblCuentaPadre.Text = "XXXX"
        cbNaturaleza.Text = ""
        tbNumerocuenta.Text = ""
        tbNombrecuenta.Text = ""
        cbCuentaSAT.Text = ""
        cbNombreSAT.Text = ""

        cbNaturaleza.Enabled = False
        tbNumerocuenta.Enabled = False
        tbNombrecuenta.Enabled = False
        cbCuentaSAT.Enabled = False
        cbNombreSAT.Enabled = False
    End Sub

    Private Sub dgvCatalogo_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvCatalogo.CellDoubleClick
        Dim indice As Integer = dgvCatalogo.CurrentRow.Index.ToString
        Dim naturaleza As String = ""
        Dim cuenta_padre As String = ""

        btnNCuenta.Visible = False
        btnCancelaEdit.Visible = True
        btnElimina.Visible = True
        btnEditar.Visible = True
        btnGuarda.Visible = False
        btnActualiza.Visible = False

        get_padre_naturaleza(cuenta_padre, naturaleza, dgvCatalogo.Rows(indice).Cells(0).Value)
        id_cuenta = dgvCatalogo.Rows(indice).Cells(0).Value

        lblCuentaPadre.Text = cuenta_padre
        cbNaturaleza.Text = naturaleza
        tbNumerocuenta.Text = dgvCatalogo.Rows(indice).Cells(1).Value
        tbNombrecuenta.Text = dgvCatalogo.Rows(indice).Cells(2).Value
        cbCuentaSAT.Text = dgvCatalogo.Rows(indice).Cells(3).Value
        cbNombreSAT.Text = dgvCatalogo.Rows(indice).Cells(4).Value

        cbNaturaleza.Enabled = False
        tbNumerocuenta.Enabled = False
        tbNombrecuenta.Enabled = False
        cbCuentaSAT.Enabled = False
        cbNombreSAT.Enabled = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnNCuenta.Visible = False
        btnCancelaEdit.Visible = True
        btnElimina.Visible = False
        btnEditar.Visible = False
        btnGuarda.Visible = False
        btnActualiza.Visible = True

        cbNaturaleza.Enabled = True
        tbNumerocuenta.Enabled = True
        tbNombrecuenta.Enabled = True
        cbCuentaSAT.Enabled = True
        cbNombreSAT.Enabled = True
    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim numero_cuenta_unico As String = ""
        Dim id_cuenta_sat As Integer = 0
        Dim id_cuenta_p As Integer = 0

        Completa_cuenta(tbNumerocuenta.Text)
        numero_cuenta_unico = var_globales.ccontableunica

        'OBTENEMOS ID CUENTA DEL SAT
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_cuentas_sat where numero_cuenta = '" & cbCuentaSAT.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_cuenta_sat = resultado.GetInt64("id")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If lblCuentaPadre.Text = "XXXX" Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" update catalogo_contable set numero_cuenta_unico = '" & numero_cuenta_unico & "', numero_cuenta = '" & tbNumerocuenta.Text & "', nombre_cuenta = '" & tbNombrecuenta.Text & "', tipo = 'A', 
                                                naturaleza = '" & cbNaturaleza.Text & "', cuenta_sat = '" & id_cuenta_sat & "' where id_cuenta = '" & id_cuenta & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & tbNumerocuenta.Text & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_cuenta_p = resultado.GetInt64("id_cuenta")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" update catalogo_contable set id_cuenta_padre = '" & id_cuenta_p & "' where id_cuenta = '" & id_cuenta & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" update catalogo_contable set numero_cuenta_unico = '" & numero_cuenta_unico & "', numero_cuenta = '" & tbNumerocuenta.Text & "', nombre_cuenta = '" & tbNombrecuenta.Text & "', tipo = 'A', 
                                                naturaleza = '" & cbNaturaleza.Text & "', cuenta_sat = '" & id_cuenta_sat & "' where id_cuenta = '" & id_cuenta & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & lblCuentaPadre.Text & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_cuenta_p = resultado.GetInt64("id_cuenta")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" update catalogo_contable set id_cuenta_padre = '" & id_cuenta_p & "' where id_cuenta = '" & id_cuenta & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

        btnNCuenta.Visible = False
        btnCancelaEdit.Visible = True
        btnElimina.Visible = False
        btnEditar.Visible = False
        btnGuarda.Visible = True
        btnActualiza.Visible = False

        lblCuentaPadre.Text = "XXXX"
        cbNaturaleza.Text = ""
        tbNumerocuenta.Text = ""
        tbNombrecuenta.Text = ""
        cbCuentaSAT.Text = ""
        cbNombreSAT.Text = ""

        cbNaturaleza.Enabled = True
        tbNumerocuenta.Enabled = True
        tbNombrecuenta.Enabled = True
        cbCuentaSAT.Enabled = True
        cbNombreSAT.Enabled = True

        MessageBox.Show("Cuenta contable modificada con éxito", "Contago Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Dim indice As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim conexionD As New Class_delete
        Dim datos As New Class_datos
        Dim cuenta As String
        Dim b As Boolean = False

        indice = dgvCatalogo.CurrentRow.Index.ToString
        cuenta = dgvCatalogo.Rows(indice).Cells(1).Value.ToString()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cuenta & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read

                If resultado.GetString("tipo") = "A" Then
                    MessageBox.Show("No se puede eliminar una cuenta que no sea de registro", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("SELECT * FROM polizas_det pol join catalogo_contable cat on pol.id_cuenta = cat.id_cuenta where cat.numero_cuenta =  '" & cuenta & "' and pol.estado <> 'cancelado'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If b = True Then
            MessageBox.Show("No se puede eliminar una cuenta que se este utilizando en polizas", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        datos.id_cuenta_padre = dgvCatalogo.Rows(indice).Cells(0).Value.ToString()

        If conexionD.borrarcuenta(datos) Then

            cargadata()
            MessageBox.Show("Cuenta borrada correctamente", "Contago contabilidad 2.0", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub
End Class