Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrDetalle
#Region "VARIABLES GLOBALES"
    Public id_unidad As Integer = 0
    Dim id_detalle_g As Integer = 0
    Public id_detalle_c As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Sub init_detalle()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvDetalle.Rows.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from detalle where id_unidad = '" & id_unidad & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvDetalle.Rows.Add(resultado.GetString("id_detalle"),
                                    resultado.GetString("mro"),
                                    resultado.GetString("tratamiento"),
                                    resultado.GetString("cantidad"),
                                    resultado.GetString("observaciones"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub detalle_c(ByVal id_detalle As Integer)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from detalle where id_detalle = '" & id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                tbMRO.Text = resultado.GetString("mro")
                rtbTratamiento.Text = resultado.GetString("tratamiento")
                tbCantidad.Text = resultado.GetString("cantidad")
                rtbObservacion.Text = resultado.GetString("observaciones")
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
        'DETALLE
        tbMRO.Enabled = True
        tbCantidad.Enabled = True
        rtbTratamiento.Enabled = True
        rtbObservacion.Enabled = True

        tbMRO.Text = ""
        tbCantidad.Text = ""
        rtbTratamiento.Text = ""
        rtbObservacion.Text = ""

        'BOTONES
        btnNuevaU.Visible = False
        btnUDE.Visible = False
        btnGuardaA.Visible = False
        btnGuardar.Visible = True
        btnEditar.Visible = False
        btnCancelaEdit.Visible = True
    End Sub

    Private Sub dgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellClick
        Dim indice As Integer = dgvDetalle.CurrentRow.Index
        id_detalle_g = dgvDetalle.Rows(indice).Cells(0).Value

        tbMRO.Text = dgvDetalle.Rows(indice).Cells(1).Value
        rtbTratamiento.Text = dgvDetalle.Rows(indice).Cells(2).Value
        tbCantidad.Text = dgvDetalle.Rows(indice).Cells(3).Value
        rtbObservacion.Text = dgvDetalle.Rows(indice).Cells(4).Value

        'BOTOTNES
        btnNuevaU.Visible = True
        btnUDE.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = True
        btnCancelaEdit.Visible = False
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        'BOTOTNES
        btnNuevaU.Visible = False
        btnUDE.Visible = False
        btnGuardaA.Visible = True
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = True

        'CAMPOS
        tbMRO.Enabled = True
        tbCantidad.Enabled = True
        rtbTratamiento.Enabled = True
        rtbObservacion.Enabled = True
    End Sub

    Private Sub btnCancelaEdit_Click(sender As Object, e As EventArgs) Handles btnCancelaEdit.Click
        'DETALLE
        tbMRO.Enabled = False
        tbCantidad.Enabled = False
        rtbTratamiento.Enabled = False
        rtbObservacion.Enabled = False

        tbMRO.Text = ""
        tbCantidad.Text = ""
        rtbTratamiento.Text = ""
        rtbObservacion.Text = ""

        'BOTONES
        btnNuevaU.Visible = True
        btnUDE.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = False
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_detalle As Integer = 0
        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        'GUARDAMOS LOS DETALLES
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("insert into detalle (id_unidad,mro,tratamiento,cantidad,observaciones) values ('" & id_unidad & "','" & tbMRO.Text & "','" & rtbTratamiento.Text & "','" & tbCantidad.Text & "','" & rtbObservacion.Text & "')", _conexionSI)
            resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
        _conexionSI.Close()

        'CONSULTAMOS ID DEL DETALLE
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select id_detalle from detalle ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_detalle = resultado.GetString("id_detalle")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If id_detalle_c <> 0 Then
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_detalle_c & "' ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id = id_detalle                                       'ID_ORDEN_TRABAJO
                    datos.id_polizas = resultado.GetString("id_proceso")        'ID_PROCESO
                    datos.total = resultado.GetString("id_estacion")            'ID_ESTACION
                    datos.fecha = resultado.GetDateTime("fecha_interna")        'FECHA_INTERNA
                    datos.cel = resultado.GetString("observaciones")            'OBSERVACIONES
                    datos.ciudad = resultado.GetString("num_proc")              'NÚMERO PROCESO
                    datos.clave = ""                                            'ESTADO
                    datos.colonia = resultado.GetString("tiempo")               'HORAS DE TRABAJO

                    conexion.insert_proceso_ot2(datos)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()
        End If

        MessageBox.Show("Detalle creado con éxito", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

        init_detalle()

        'DETALLE
        tbMRO.Enabled = False
        tbCantidad.Enabled = False
        rtbTratamiento.Enabled = False
        rtbObservacion.Enabled = False

        tbMRO.Text = ""
        tbCantidad.Text = ""
        rtbTratamiento.Text = ""
        rtbObservacion.Text = ""

        'BOTONES
        btnNuevaU.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = False

        id_detalle_c = 0
    End Sub

    Private Sub btnGuardaA_Click(sender As Object, e As EventArgs) Handles btnGuardaA.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update detalle set mro = '" & tbMRO.Text & "', tratamiento = '" & rtbTratamiento.Text & "', cantidad = '" & tbCantidad.Text & "', observaciones = '" & rtbObservacion.Text & "' where id_detalle = '" & id_detalle_g & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        MessageBox.Show("Detalle actualizado con éxito", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

        init_detalle()

        'DETALLE
        tbMRO.Enabled = False
        tbCantidad.Enabled = False
        rtbTratamiento.Enabled = False
        rtbObservacion.Enabled = False

        tbMRO.Text = ""
        tbCantidad.Text = ""
        rtbTratamiento.Text = ""
        rtbObservacion.Text = ""

        'BOTONES
        btnNuevaU.Visible = True
        btnGuardaA.Visible = False
        btnGuardar.Visible = False
        btnEditar.Visible = False
        btnCancelaEdit.Visible = False
    End Sub

    Private Sub btnUDE_Click(sender As Object, e As EventArgs) Handles btnUDE.Click
        scrMuestraDetalles.Show()
        scrMuestraDetalles.BringToFront()
    End Sub
End Class