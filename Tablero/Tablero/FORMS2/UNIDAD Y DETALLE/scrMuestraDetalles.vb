Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Public Class scrMuestraDetalles
    Private Sub scrMuestraDetalles_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvDetalles.Rows.Clear()
        dgvTareas.Rows.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select d.id_detalle,d.mro, u.clave, ot.serie, ot.folio from detalle d join (unidad u , orden_trabajo ot) on (d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvDetalles.Rows.Add(resultado.GetString("id_detalle"),
                                    resultado.GetString("mro"),
                                    resultado.GetString("clave"),
                                    resultado.GetString("serie") & " " & resultado.GetString("folio"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Private Sub dgvDetalles_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalles.CellClick
        Dim indice As Integer = dgvDetalles.CurrentRow.Index
        Dim id_detalle As Integer = dgvDetalles.Rows(indice).Cells(0).Value

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvTareas.Rows.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select p.clave, e.nombre from proceso_ot pt join (estacion e, proceso p) on (e.id_estacion = pt.id_estacion and p.id_proceso = pt.id_proceso) where pt.id_detalle = '" & id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvTareas.Rows.Add(resultado.GetString("clave"),
                                     resultado.GetString("nombre"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbOpcion.Text = "" Then
            MessageBox.Show("Indique una opción", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbOpcion.Focus()
            Return
        End If

        dgvDetalles.Rows.Clear()
        dgvTareas.Rows.Clear()

        Select Case cbOpcion.Text
            Case "TODOS"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select d.id_detalle,d.mro, u.clave, ot.serie, ot.folio from detalle d join (unidad u , orden_trabajo ot) on (d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvDetalles.Rows.Add(resultado.GetString("id_detalle"),
                                            resultado.GetString("mro"),
                                            resultado.GetString("clave"),
                                            resultado.GetString("serie") & " " & resultado.GetString("folio"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Case "UNIDAD"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select d.id_detalle,d.mro, u.clave, ot.serie, ot.folio from detalle d join (unidad u , orden_trabajo ot) on (d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) where u.clave like '%" & tbOpcion.Text & "%' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvDetalles.Rows.Add(resultado.GetString("id_detalle"),
                                            resultado.GetString("mro"),
                                            resultado.GetString("clave"),
                                            resultado.GetString("serie") & " " & resultado.GetString("folio"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Case "OT"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select d.id_detalle,d.mro, u.clave, ot.serie, ot.folio from detalle d join (unidad u , orden_trabajo ot) on (d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) where ot.folio like '%" & tbOpcion.Text & "%' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvDetalles.Rows.Add(resultado.GetString("id_detalle"),
                                            resultado.GetString("mro"),
                                            resultado.GetString("clave"),
                                            resultado.GetString("serie") & " " & resultado.GetString("folio"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
        End Select
    End Sub

    Private Sub COPIARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles COPIARToolStripMenuItem.Click
        Dim indice As Integer = dgvDetalles.CurrentRow.Index.ToString
        Dim id_det As Integer = dgvDetalles.Rows(indice).Cells(0).Value

        'DETALLE
        scrDetalle.tbMRO.Enabled = True
        scrDetalle.tbCantidad.Enabled = True
        scrDetalle.rtbTratamiento.Enabled = True
        scrDetalle.rtbObservacion.Enabled = True

        'BOTONES
        scrDetalle.btnNuevaU.Visible = False
        scrDetalle.btnUDE.Visible = False
        scrDetalle.btnGuardaA.Visible = False
        scrDetalle.btnGuardar.Visible = True
        scrDetalle.btnEditar.Visible = False
        scrDetalle.btnCancelaEdit.Visible = True

        scrDetalle.id_detalle_c = id_det
        scrDetalle.detalle_c(id_det)

        scrDetalle.BringToFront()
        Me.Close()
    End Sub
End Class