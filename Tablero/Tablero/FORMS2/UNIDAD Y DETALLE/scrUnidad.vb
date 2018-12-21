Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrUnidad
#Region "VARIABLES GLOBALES"
    Public id_ot As Integer = 0
    Public id_unidad_g As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Sub init_unidad()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvUnidad.Rows.Clear()
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from unidad where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvUnidad.Rows.Add(resultado.GetString("id_unidad"), resultado.GetString("clave"), resultado.GetString("descripcion"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub
#End Region

    Private Sub btnNuevaU_Click(sender As Object, e As EventArgs) Handles btnNuevaU.Click
        'UNIDAD
        tbClave.Enabled = True
        rtbDescripcion.Enabled = True

        tbClave.Text = ""
        tbClave.Focus()
        rtbDescripcion.Text = ""

        'BOTONES
        btnNuevaU.Visible = False
        btnGuardaA.Visible = False
        btnGuardar.Visible = True
        btnEditar.Visible = False
        btnCancelaEdit.Visible = True
    End Sub

    Private Sub btnCancelaEdit_Click(sender As Object, e As EventArgs) Handles btnCancelaEdit.Click
        'UNIDAD
        tbClave.Enabled = False
        rtbDescripcion.Enabled = False

        tbClave.Text = ""
        rtbDescripcion.Text = ""

        'BOTONES
        btnNuevaU.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_unidad As Integer = 0

        If tbClave.Text = "" Then
            MessageBox.Show("Clave obligatoria", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rtbDescripcion.Text = "" Then
            MessageBox.Show("Descripción obligatoria", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" insert into unidad (clave, descripcion) values ('" & tbClave.Text & "', '" & rtbDescripcion.Text & "') ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'OBTENEMOS ID DE LA UNIDAD
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select MAX(id_unidad) from unidad ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_unidad = resultado.GetInt64("MAX(id_unidad)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        scrOT_2.dgvPiezas.Rows.Add(id_unidad, tbClave.Text, rtbDescripcion.Text)

        init_unidad()
        MessageBox.Show("Unidad creada con éxito", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

        'UNIDAD
        tbClave.Enabled = False
        rtbDescripcion.Enabled = False

        tbClave.Text = ""
        rtbDescripcion.Text = ""

        'BOTONES
        btnNuevaU.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = False

    End Sub

    Private Sub dgvUnidad_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvUnidad.CellClick
        Dim indice As Integer = dgvUnidad.CurrentRow.Index
        id_unidad_g = dgvUnidad.Rows(indice).Cells(0).Value

        tbClave.Text = dgvUnidad.Rows(indice).Cells(1).Value
        rtbDescripcion.Text = dgvUnidad.Rows(indice).Cells(2).Value

        'BOTOTNES
        btnNuevaU.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = True
        btnCancelaEdit.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'UNIDAD
        tbClave.Enabled = True
        rtbDescripcion.Enabled = True

        'BOTOTNES
        btnNuevaU.Visible = False
        btnGuardaA.Visible = True
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = True
    End Sub

    Private Sub btnGuardaA_Click(sender As Object, e As EventArgs) Handles btnGuardaA.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If tbClave.Text = "" Then
            MessageBox.Show("Clave obligatoria", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If rtbDescripcion.Text = "" Then
            MessageBox.Show("Descripción obligatoria", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update unidad set clave = '" & tbClave.Text & "', descripcion = '" & rtbDescripcion.Text & "' where id_unidad = '" & id_unidad_g & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        MessageBox.Show("Unidad actualizada con éxito", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class