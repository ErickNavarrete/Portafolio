Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Imports System.IO
Imports IWshRuntimeLibrary

Public Class scrUsuariosEmpresas

    Private Sub tsbNuevUs_Click(sender As Object, e As EventArgs) Handles tsbNuevUs.Click

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim banEm As Boolean = False

        scrUsuarios.Text = "Nuevo Usuario"
        scrUsuarios.Show()
        scrUsuarios.StartPosition = FormStartPosition.CenterScreen
        scrUsuarios.rbtnList.Checked = True

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.bases", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                banEm = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If banEm = True Then

            scrUsuarios.dgvEmpresas.Rows.Clear()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.bases order by base asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuarios.dgvEmpresas.Rows.Add(resultado.GetInt64("id_base"), resultado.GetString("base"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        End If

    End Sub

    Private Sub tsbElimUs_Click(sender As Object, e As EventArgs) Handles tsbElimUs.Click

        Dim conexion As New Class_insert
        Dim conexionE As New Class_delete
        Dim datos As New Class_datos
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim indice As Integer

        indice = dgvUsuarios.CurrentRow.Index.ToString

        If dgvUsuarios.Rows(indice).Cells(1).Value.ToString = scrPrincipal2.lblNUsuario.Text Or dgvUsuarios.Rows(indice).Cells(1).Value.ToString = "Administrador" Then
            MessageBox.Show("No se puede eliminar el usuario que esta en uso o el Administrador", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If MessageBox.Show("¿Está seguro que desea eliminar el usuario " & dgvUsuarios.Rows(indice).Cells(1).Value.ToString & " ? Esta acción no puede ser revertida", "Auto-Conta 1.0 2018", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            datos.id_usuario = dgvUsuarios.Rows(indice).Cells(0).Value.ToString

            'BORRAR USUARIO
            If conexionE.borrarusuario(datos) Then
                datos.id_usuario = dgvUsuarios.Rows(indice).Cells(0).Value.ToString

                'BORRAMOS LA RELACIÓN ENTRE USUARIO Y BASES
                If conexionE.borrarusuariobases(datos) Then

                End If

                dgvUsuarios.Rows.Clear()
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
                    dgvUsuarios.Rows.Clear()
                    Try
                        Conexion_Global()
                        _conexion.Open()
                        comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name <> 'root' order by user_name asc", _conexion)
                        resultado = comandoSql.ExecuteReader
                        While resultado.Read
                            dgvUsuarios.Rows.Add(resultado.GetInt64("id_user"), resultado.GetString("user_name"))
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrar()
                    End Try
                    _conexion.Close()
                End If

            End If
            MessageBox.Show("Usuario elimimnado correctamente", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

    End Sub

    Private Sub dgvUsuarios_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUsuarios.CellContentDoubleClick


        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim indice As Integer
        indice = dgvUsuarios.CurrentRow.Index.ToString
        Dim total_bases As Integer
        Dim total_bases_l As Integer
        dgvEmpresas.Enabled = False
        dgvEmpresas.Enabled = True

#Region "Empresas"

        Dim banEm As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.bases", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                banEm = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If banEm = True Then

            scrUsuarios.dgvEmpresas.Rows.Clear()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.bases order by base asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuarios.dgvEmpresas.Rows.Add(resultado.GetInt64("id_base"), resultado.GetString("base"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        End If

#End Region

        scrUsuarios.tsbGyN.Visible = False
        scrUsuarios.tsbGyC.Visible = False
        scrUsuarios.tsbGC.Visible = True
        scrUsuarios.lblIdUser.Text = dgvUsuarios.Rows(indice).Cells(0).Value.ToString
        scrUsuarios.tbUsuario.Text = dgvUsuarios.Rows(indice).Cells(1).Value.ToString
        scrUsuarios.tbPass.Text = "contraseña"
        scrUsuarios.tbConfirPass.Text = "contraseña"
        scrUsuarios.Text = "Editando usuario '" & dgvUsuarios.Rows(indice).Cells(1).Value.ToString & "'"
        scrUsuarios.Show()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select count(id_base) from config_auto_conta.bases", _conexion)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read

                total_bases = resultado.GetInt64("count(id_base)")

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
            comandoSql = New MySqlCommand("select count(id_base) from config_auto_conta.user_bases where id_user = '" & dgvUsuarios.Rows(indice).Cells(0).Value.ToString & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read

                total_bases_l = resultado.GetInt64("count(id_base)")

            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If total_bases = total_bases_l Then

            scrUsuarios.rbtnEmp.Checked = True

            For Each row As DataGridViewRow In scrUsuarios.dgvEmpresas.Rows

                row.Cells(2).Value = True

            Next

        Else

            scrUsuarios.rbtnList.Checked = True

            For Each row As DataGridViewRow In scrUsuarios.dgvEmpresas.Rows

                Dim bandera As Boolean = False

                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from config_auto_conta.user_bases ub join config_contabilidad.bases ba on ub.id_base = ba.id_base where ub.id_user = '" & dgvUsuarios.Rows(indice).Cells(0).Value.ToString & "' and ba.id_base = '" & row.Cells(0).Value.ToString() & "'", _conexion)
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
                    row.Cells(2).Value = True
                End If

            Next

        End If

    End Sub

    Private Sub tsbNuevEmp_Click(sender As Object, e As EventArgs) Handles tsbNuevEmp.Click
        scrEmpresas.Show()
        scrEmpresas.BringToFront()
    End Sub

    Private Sub tsbElimEmp_Click(sender As Object, e As EventArgs) Handles tsbElimEmp.Click


        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim datos As New Class_datos
        Dim conexion As New Class_delete
        Dim indice As Integer
        Dim banEm As Boolean = False

        indice = dgvEmpresas.CurrentRow.Index.ToString
    End Sub

End Class