Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrEmpresas

    Private Sub tbNomEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbNomEmp.KeyPress
        If Char.IsLower(e.KeyChar) Then
            tbNomEmp.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub tbRFCEmp_KeyPress(sender As Object, e As KeyPressEventArgs) Handles tbRFCEmp.KeyPress
        If Char.IsLower(e.KeyChar) Then
            tbRFCEmp.SelectedText = Char.ToUpper(e.KeyChar)
            e.Handled = True
        End If
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Dim conexion As New Class_insert
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim datos As New Class_datos
        Dim banEm As Boolean = False
        Dim base As String

        base = tbNombreBaese.Text.Replace(" ", "_")

#Region "Condiciones"

        If tbNomEmp.Text = "" Then

            MessageBox.Show("Error, ingresa un nombre a la Nueva Empresa", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbNomEmp.Focus()
            Return

        End If

        If tbRFCEmp.Text = "" Then

            MessageBox.Show("Error, ingresa un RFC a la Nueva Empresa", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            tbRFCEmp.Focus()
            Return

        End If

        If cbRegFis.Text = "-Selecciona un Regimen-" Or cbRegFis.Text = "" Then

            MessageBox.Show("Error, selecciona un regimen para la Nueva Empresa", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbRegFis.Focus()
            Return

        End If

#End Region

        For Each row As DataGridViewRow In scrUsuariosEmpresas.dgvEmpresas.Rows
            If tbNomEmp.Text = row.Cells(1).Value Then
                MessageBox.Show("Error, esta empresa ya existe", "Auto-Conta 1.0 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        If MessageBox.Show("¿Está seguro que la nueva empresa tenga el nombre de '" & tbNomEmp.Text & "' ? Esta acción no puede ser revertida", "Auto-Conta 1.0 2018", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then
            datos.base = base
            datos.nombre_emp = tbNomEmp.Text
            datos.rfc_emp = tbRFCEmp.Text
            datos.regimen_emp = cbRegFis.Text

            If conexion.inserta_Base(datos) Then

            End If

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

                scrUsuariosEmpresas.dgvEmpresas.Rows.Clear()

                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from config_auto_conta.bases order by base asc", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        scrUsuariosEmpresas.dgvEmpresas.Rows.Add(resultado.GetInt64("id_base"), resultado.GetString("nombre_emp"), resultado.GetString("rfc_emp"), resultado.GetString("base"))
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

        Me.Close()

    End Sub

    Private Sub scrEmpresas_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbRegFis.Items.Clear()
        cbRegFis.Items.Add("-Selecciona un Regimen-")
        cbRegFis.SelectedIndex = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.regimen_fiscal order by descripcion asc", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cbRegFis.Items.Add(resultado.GetString("descripcion"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

    End Sub

End Class