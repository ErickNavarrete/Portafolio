Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Imports System.Globalization

Public Class scrUsuarios

    Private Sub tbUsuario_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles tbUsuario.LostFocus

        Dim nombre As String = CultureInfo.CurrentCulture.TextInfo.ToTitleCase(tbUsuario.Text)
        tbUsuario.Text = nombre

    End Sub

    Private Sub tsbGyN_Click(sender As Object, e As EventArgs) Handles tsbGyN.Click

        Dim conexion As New Class_insert
        Dim datos As New Class_datos
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim bandera As Boolean = False
        dgvEmpresas.Enabled = False
        dgvEmpresas.Enabled = True

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name = '" & tbUsuario.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                bandera = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

#Region "Condiciones de guardado"

        If tbUsuario.Text = "" Then
            MessageBox.Show("Error. Ingresa un nombre de usuario", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsuario.Focus()
            Return
        End If

        If tbPass.Text = "" Then
            MessageBox.Show("Error. Ingresa una contraseña", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPass.Focus()
            Return
        End If

        If tbConfirPass.Text = "" Then
            MessageBox.Show("Error. Confirme la contraseña antes de continuar", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbConfirPass.Focus()
            Return
        End If

        If tbPass.Text <> tbConfirPass.Text Then
            MessageBox.Show("Error. Las contraseñas no coinciden", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbConfirPass.Focus()
            Return
        End If

        If bandera = True Then
            MessageBox.Show("Error. Ya existe un usuario con el mismo nombre", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim con As Integer = 0

        For Each row As DataGridViewRow In Me.dgvEmpresas.Rows
            If row.Cells(2).Value = True Then
                con += 1
            End If
        Next

        If con = 0 Then
            MessageBox.Show("No se puede guardar sin seleccionar una empresa de la lista", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpresas.Enabled = True
            Return
        End If
#End Region

        datos.user = tbUsuario.Text
        datos.pass = tbPass.Text

        If conexion.insertarUsuario(datos) Then

            Dim id_user As String
            Dim id_base As String

            For Each row As DataGridViewRow In dgvEmpresas.Rows
                If row.Cells(2).Value = True Then

                    Try
                        Conexion_Global()
                        _conexion.Open()
                        comandoSql = New MySqlCommand("select max(id_user) from config_auto_conta.users", _conexion)
                        resultado = comandoSql.ExecuteReader
                        While resultado.Read
                            id_user = resultado.GetString("max(id_user)")
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrar()
                    End Try
                    _conexion.Close()

                    Try
                        Conexion_Global()
                        _conexion.Open()
                        comandoSql = New MySqlCommand("select id_base from config_auto_conta.bases where base = '" & row.Cells(1).Value.ToString() & "'", _conexion)
                        resultado = comandoSql.ExecuteReader
                        While resultado.Read

                            id_base = resultado.GetString("id_base")
                            datos.id_usuario = id_user
                            datos.id_base = id_base

                            If conexion.insertaruser_Base(datos) Then

                            End If

                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrar()
                    End Try
                    _conexion.Close()

                End If
            Next

#Region "Limpia"

            tbUsuario.Text = ""
            tbPass.Text = ""
            tbConfirPass.Text = ""
            rbtnList.Checked = True

            For Each row As DataGridViewRow In dgvEmpresas.Rows
                row.Cells(2).Value = False
            Next

#End Region

#Region "DGV usuarios"
            scrUsuariosEmpresas.dgvUsuarios.Rows.Clear()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name <> 'root' order by user_name asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuariosEmpresas.dgvUsuarios.Rows.Add(resultado.GetInt64("id_user"), resultado.GetString("user_name"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
#End Region

            MessageBox.Show("Usuario creado exitosamente", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub tsbGyC_Click(sender As Object, e As EventArgs) Handles tsbGyC.Click

        Dim conexion As New Class_insert
        Dim datos As New Class_datos
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim bandera As Boolean = False
        dgvEmpresas.Enabled = False
        dgvEmpresas.Enabled = True

        MsgBox(var_globales.ip)

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name = '" & tbUsuario.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                bandera = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

#Region "Condiciones de guardado"

        If tbUsuario.Text = "" Then
            MessageBox.Show("Error. Ingresa un nombre de usuario", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsuario.Focus()
            Return
        End If

        If tbPass.Text = "" Then
            MessageBox.Show("Error. Ingresa una contraseña", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPass.Focus()
            Return
        End If

        If tbConfirPass.Text = "" Then
            MessageBox.Show("Error. Confirme la contraseña antes de continuar", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbConfirPass.Focus()
            Return
        End If

        If tbPass.Text <> tbConfirPass.Text Then
            MessageBox.Show("Error. Las contraseñas no coinciden", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbConfirPass.Focus()
            Return
        End If

        If bandera = True Then
            MessageBox.Show("Error. Ya existe un usuario con el mismo nombre", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim con As Integer = 0

        For Each row As DataGridViewRow In Me.dgvEmpresas.Rows

            If row.Cells(2).Value = True Then

                con += 1

            End If
        Next

        If con = 0 Then
            MessageBox.Show("No se puede guardar sin seleccionar una empresa de la lista", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpresas.Enabled = True
            Return
        End If
#End Region

        datos.user = tbUsuario.Text
        datos.pass = tbPass.Text

        'guarda_permisos()

        If conexion.insertarUsuario(datos) Then

            Dim id_user As String
            Dim id_base As String

            For Each row As DataGridViewRow In dgvEmpresas.Rows

                If row.Cells(2).Value = True Then

                    Try
                        Conexion_Global()
                        _conexion.Open()
                        comandoSql = New MySqlCommand("select max(id_user) from config_auto_conta.users", _conexion)
                        resultado = comandoSql.ExecuteReader
                        While resultado.Read

                            id_user = resultado.GetString("max(id_user)")

                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrar()
                    End Try
                    _conexion.Close()

                    Try
                        Conexion_Global()
                        _conexion.Open()
                        comandoSql = New MySqlCommand("select id_base from config_auto_conta.bases where base = '" & row.Cells(1).Value.ToString() & "'", _conexion)
                        resultado = comandoSql.ExecuteReader
                        While resultado.Read

                            id_base = resultado.GetString("id_base")
                            datos.id_usuario = id_user
                            datos.id_base = id_base

                            If conexion.insertaruser_Base(datos) Then

                            End If

                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrar()
                    End Try
                    _conexion.Close()

                End If

            Next

#Region "Limpia"

            tbUsuario.Text = ""
            tbPass.Text = ""
            tbConfirPass.Text = ""
            rbtnList.Checked = True

            For Each row As DataGridViewRow In dgvEmpresas.Rows

                row.Cells(2).Value = False

            Next

#End Region

#Region "DGV usuarios"

            scrUsuariosEmpresas.dgvUsuarios.Rows.Clear()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name <> 'root' order by user_name asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuariosEmpresas.dgvUsuarios.Rows.Add(resultado.GetInt64("id_user"), resultado.GetString("user_name"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

#End Region

            MessageBox.Show("Usuario creado exitosamente", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

        Me.Close()

    End Sub

    Private Sub tsbGC_Click(sender As Object, e As EventArgs) Handles tsbGC.Click

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim datos As New Class_datos
        Dim conexion As New Class_update
        Dim conexionE As New Class_delete
        Dim conexionI As New Class_insert
        Dim nombre As String
        Dim bandera As Boolean = False
        dgvEmpresas.Enabled = False
        dgvEmpresas.Enabled = True

#Region "Condiciones de guardado"

        If tbUsuario.Text = "" Then
            MessageBox.Show("Error. Ingresa un nombre de usuario", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbUsuario.Focus()
            Return
        End If

        If tbPass.Text = "" Then
            MessageBox.Show("Error. Ingresa una contraseña", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbPass.Focus()
            Return
        End If

        If tbConfirPass.Text = "" Then
            MessageBox.Show("Error. Confirme la contraseña antes de continuar", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbConfirPass.Focus()
            Return
        End If

        If tbPass.Text <> tbConfirPass.Text Then
            MessageBox.Show("Error. Las contraseñas no coinciden", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbConfirPass.Focus()
            Return
        End If

        Dim con As Integer

        For Each row As DataGridViewRow In dgvEmpresas.Rows

            If row.Cells(2).Value = True Then

                con += 1

            End If

        Next

        If con = 0 Then
            MessageBox.Show("No se puede guardar sin seleccionar una empresa de la lista", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            dgvEmpresas.Enabled = True
            Return
        End If

#End Region

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.users where id_user = '" & lblIdUser.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                nombre = resultado.GetString("user_name")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If nombre = tbUsuario.Text Then

        Else

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name = '" & tbUsuario.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    bandera = True
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If bandera = True Then

                MessageBox.Show("Error. Ya existe un usuario con el mismo nombre", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return

            Else

                datos.id_usuario = lblIdUser.Text
                datos.Usuario = tbUsuario.Text

                If conexion.actualizarUsuario(datos) Then


                End If

            End If

        End If

        If tbPass.Text = "contraseña" Then

        Else

            datos.contrasenia = tbPass.Text
            datos.id_usuario = lblIdUser.Text

            If conexion.actualizarUsuarioContra(datos) Then


            End If

        End If

        datos.id_usuario = lblIdUser.Text

        If conexionE.borrarusuariobases(datos) Then

            'Dim id_usuario As String
            Dim id_base As String

            If rbtnEmp.Checked = True Then

                For Each row As DataGridViewRow In dgvEmpresas.Rows

                    If row.Cells(2).Value = True Then

                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand("select id_base from config_auto_conta.bases where base = '" & row.Cells(1).Value.ToString() & "'", _conexion)
                            resultado = comandoSql.ExecuteReader
                            'Dentro de un ciclo leemos los resultados
                            While resultado.Read

                                id_base = resultado.GetString("id_base")
                                datos.id_usuario = lblIdUser.Text
                                datos.id_base = id_base

                                If conexionI.insertaruser_Base(datos) Then

                                End If

                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()

                    End If

                Next

                MessageBox.Show("Usuario actualizado correctamente", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Else

                For Each row As DataGridViewRow In dgvEmpresas.Rows

                    If row.Cells(2).Value = True Then

                        'id_usuario = lblIdUser.Text

                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand("select id_base from bases where base = '" & row.Cells(1).Value.ToString() & "'", _conexion)
                            resultado = comandoSql.ExecuteReader
                            'Dentro de un ciclo leemos los resultados
                            While resultado.Read

                                id_base = resultado.GetString("id_base")
                                datos.id_usuario = lblIdUser.Text
                                datos.id_base = id_base

                                If conexionI.insertaruser_Base(datos) Then

                                End If

                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()

                    End If

                Next

                MessageBox.Show("Usuario actualizado correctamente", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

            End If

        End If

        'guarda_permisos()

        scrUsuariosEmpresas.dgvUsuarios.Rows.Clear()
        Dim banUs As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.users", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                banUs = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If banUs = True Then

            scrUsuariosEmpresas.dgvUsuarios.Rows.Clear()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name <> 'root' order by user_name asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuariosEmpresas.dgvUsuarios.Rows.Add(resultado.GetInt64("id_user"), resultado.GetString("user_name"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        End If

        Me.Close()

    End Sub

    Private Sub rbtnEmp_CheckedChanged(sender As Object, e As EventArgs) Handles rbtnEmp.CheckedChanged

        dgvEmpresas.Enabled = False
        dgvEmpresas.Enabled = True

        For Each row As DataGridViewRow In dgvEmpresas.Rows

            row.Cells(2).Value = True

        Next

    End Sub

    Private Sub dgvEmpresas_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEmpresas.CellContentClick

        dgvEmpresas.Enabled = False
        dgvEmpresas.Enabled = True
        Dim indice As Integer
        indice = dgvEmpresas.CurrentRow.Index.ToString

        If dgvEmpresas.Rows(indice).Cells(2).Value = False Then

            dgvEmpresas.Rows(indice).Cells(2).Value = False
            rbtnList.Checked = True

        End If


    End Sub

End Class