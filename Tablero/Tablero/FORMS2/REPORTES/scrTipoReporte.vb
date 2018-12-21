Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrTipoReporte
    Dim proyecto As String = ""
    Dim id_detalle As String = ""

    Private Sub btnGeneraPDF_Click(sender As Object, e As EventArgs) Handles btnGeneraPDF.Click
        If cbOT.Text = "" Then
            MessageBox.Show("", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbOT.Focus()
            Return
        End If

        Dim ds As New dsReporte
        Dim cr As New crReporte
        Dim r As New scrVistaPrevia

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_detalle As String = ""

        Dim dias As String = ""
        Dim horas As String = ""
        Dim horas2 As String = ""
        Dim minutos As String = ""
        Dim minutos2 As String = ""
        Dim segundos As String = ""

        Dim tiempo_total As String = ""

        ds.dtGeneral.AdddtGeneralRow(proyecto, cbOT.Text, cbUnidad.Text, cbDetalle.Text)

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from control_dmm.historial h join (cotizaciones.requisitantes r, control_dmm.detalle d) on (r.id_rec = h.id_usuario and d.id_detalle = h.id_detalle) where d.mro = '" & cbDetalle.Text & "' and h.estado = 'COMPLETADO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dias = DateDiff(DateInterval.Day, resultado.GetDateTime("fecha"), resultado.GetDateTime("fecha_t"))
                horas = DateDiff(DateInterval.Hour, resultado.GetDateTime("fecha"), resultado.GetDateTime("fecha_t"))
                minutos = DateDiff(DateInterval.Minute, resultado.GetDateTime("fecha"), resultado.GetDateTime("fecha_t"))
                segundos = DateDiff(DateInterval.Second, resultado.GetDateTime("fecha"), resultado.GetDateTime("fecha_t"))

                horas2 = horas - (dias * 24)
                minutos2 = minutos - (horas * 60)
                segundos = segundos - (minutos * 60)

                If segundos.ToString.Length() = 1 Then
                    segundos = "0" & segundos
                End If

                If horas2.ToString.Length() = 1 Then
                    horas2 = "0" & horas2
                End If

                If minutos2.ToString.Length() = 1 Then
                    minutos2 = "0" & minutos2
                End If

                If dias.ToString.Length() = 1 Then
                    dias = "0" & dias
                End If

                tiempo_total = "Días:" & dias & "   " & horas2 & ":" & minutos2 & ":" & segundos

                ds.dtDetalle.AdddtDetalleRow(resultado.GetString("nombre"), resultado.GetString("departamento"), resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy hh:mm:ss tt"), resultado.GetDateTime("fecha_t").ToString("dd/MMMM/yyyy hh:mm:ss tt"), tiempo_total)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from control_dmm.historial h join (cotizaciones.requisitantes r, control_dmm.detalle d) on (r.id_rec = h.id_usuario and d.id_detalle = h.id_detalle) where d.mro = '" & cbDetalle.Text & "' and h.estado = 'EN CURSO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                ds.dtDetalle.AdddtDetalleRow(resultado.GetString("nombre"), resultado.GetString("departamento"), resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy hh:mm:ss tt"), "---", "---")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        cr.SetDataSource(ds)
        r.crv1.ReportSource = cr
        r.ShowDialog()
        cr.Close()
        ds.Clear()
    End Sub

    Private Sub scrTipoReporte_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbOT.Items.Add(resultado.GetString("serie") & " " & resultado.GetString("folio"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Private Sub cbOT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOT.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim aux() As String = cbOT.Text.ToString.Split(" ")
        cbUnidad.Text = ""
        cbUnidad.Items.Clear()
        cbDetalle.Text = ""
        cbDetalle.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select u.clave, ot.proyecto from orden_trabajo ot join (unidad u) on (u.id_ot = ot.id_ot) where ot.folio  = '" & aux(1) & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                proyecto = resultado.GetString("proyecto")
                cbUnidad.Items.Add(resultado.GetString("clave"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Private Sub cbUnidad_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbUnidad.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbDetalle.Text = ""
        cbDetalle.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from detalle d join (unidad u) on (u.id_unidad = d.id_unidad) where u.clave = '" & cbUnidad.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbDetalle.Items.Add(resultado.GetString("mro"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub
End Class