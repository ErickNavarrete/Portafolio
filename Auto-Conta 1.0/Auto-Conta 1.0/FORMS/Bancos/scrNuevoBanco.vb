Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class scrNuevoBanco

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim conexion As New Class_insert
        Dim datos As New Class_datos


        Dim b As Boolean = False
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from bancos where banco = '" & tbBanco.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()


        If b = True Then
            MessageBox.Show("Error Banco ya existente.", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbBanco.Text = "" Then
            MessageBox.Show("El campo del banco no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        datos.banco = tbBanco.Text

        If conexion.insertarbanco(datos) Then
            MessageBox.Show("Banco Guardado Correctamente", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            tbBanco.Text = ""
            carga()

        Else
            MessageBox.Show("Error al insertar el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


    End Sub

    Private Sub scrNuevoBanco_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga()
    End Sub

    Private Sub carga()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        dgvBancos.Rows.Clear()
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from bancos", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvBancos.Rows.Add(resultado.GetString("banco"))
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