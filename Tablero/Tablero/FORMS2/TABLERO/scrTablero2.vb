Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrTablero2
#Region "VARIABLES GLOBALES"
    Dim tipo_tablero As String = "1"
#End Region

#Region "TABLERO_1"
    Public Sub create_tablero1()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'LIMPIA COLUMNAS
        dgvTablero.Columns.Clear()

        'CREA LAS COLUMNAS
        Dim nombre_0 As New DataGridViewTextBoxColumn
        nombre_0.Name = "id_ot"
        nombre_0.Visible = False
        dgvTablero.Columns.Add(nombre_0)

        Dim nombre_1 As New DataGridViewTextBoxColumn
        nombre_1.Name = "ORDEN DE TRABAJO"
        nombre_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_1.Width = 100
        dgvTablero.Columns.Add(nombre_1)

        Dim nombre_6 As New DataGridViewTextBoxColumn
        nombre_6.Name = "UNIDAD"
        nombre_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_6.Width = 100
        dgvTablero.Columns.Add(nombre_6)

        Dim nombre_7 As New DataGridViewTextBoxColumn
        nombre_7.Name = "DETALLE"
        nombre_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_7.Width = 100
        dgvTablero.Columns.Add(nombre_7)

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso order by clave ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim col As New DataGridViewTextBoxColumn
                col.Name = resultado.GetString("clave")
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                col.Width = 100
                dgvTablero.Columns.Add(col)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Dim nombre_2 As New DataGridViewTextBoxColumn
        nombre_2.Name = "ESTADO"
        nombre_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_2.Width = 200
        dgvTablero.Columns.Add(nombre_2)

        Dim nombre_5 As New DataGridViewTextBoxColumn
        nombre_5.Name = "FECHA COMIENZO"
        nombre_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_5.Width = 200
        dgvTablero.Columns.Add(nombre_5)

        Dim nombre_3 As New DataGridViewTextBoxColumn
        nombre_3.Name = "FECHA ENTREGA INTERNA"
        nombre_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_3.Width = 200
        dgvTablero.Columns.Add(nombre_3)

        Dim nombre_4 As New DataGridViewTextBoxColumn
        nombre_4.Name = "TIEMPO TRANSCURRIDO"
        nombre_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_4.Width = 300
        dgvTablero.Columns.Add(nombre_4)

    End Sub

    Public Sub get_tablero1()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

        dgvTablero.Rows.Clear()

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct(d.id_detalle), ot.serie, ot.folio, u.clave, d.mro from orden_trabajo ot join (unidad u, detalle d, historial h) on (u.id_ot = ot.id_ot and d.id_unidad = u.id_unidad and d.id_detalle = h.id_detalle) 
                                            where ot.estado = 1 and h.id_proceso <> 0", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_detalle"), resultado.GetString("serie") & " - " & resultado.GetString("folio"), resultado.GetString("clave"), resultado.GetString("mro"))
                busca_estado(resultado.GetString("id_detalle"), num_col, resultado.GetString("serie") & " - " & resultado.GetString("folio"))
                num_col = num_col + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub busca_estado(ByVal id_detalle As Integer, ByVal num_col As Integer, ByVal serie As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bandera As Boolean = False
        Dim bandera2 As Boolean = True
        Dim result As Integer = 0

        Dim dias As String = ""
        Dim horas As String = ""
        Dim horas2 As String = ""
        Dim minutos As String = ""
        Dim minutos2 As String = ""
        Dim segundos As String = ""

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select h.fecha, po.fecha_interna, p.clave from historial h 
                                            join (proceso_ot po, proceso p) on (h.id_detalle = po.id_detalle and p.id_proceso = po.id_proceso and h.id_proceso = p.id_proceso) where h.id_detalle = '" & id_detalle & "' and
                                            h.estado = 'EN CURSO' and po.estado <> 'TERMINADO' order by po.num_proc desc ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                bandera = True
                dgvTablero.Rows(num_col).Cells(resultado.GetString("clave")).Value = serie
                result = DateTime.Compare(DateTime.Now, resultado.GetDateTime("fecha_interna"))

                If result > 0 Then
                    dgvTablero.Rows(num_col).Cells("ESTADO").Value = "RETRASO"
                Else
                    dgvTablero.Rows(num_col).Cells("ESTADO").Value = "EN CURSO"
                End If
                dgvTablero.Rows(num_col).Cells("FECHA COMIENZO").Value = resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy  hh:mm:ss")
                dgvTablero.Rows(num_col).Cells("FECHA ENTREGA INTERNA").Value = resultado.GetDateTime("fecha_interna").ToString("dd/MMMM/yyyy  hh:mm:ss")

                dias = DateDiff(DateInterval.Day, resultado.GetDateTime("fecha"), DateTime.Now)
                horas = DateDiff(DateInterval.Hour, resultado.GetDateTime("fecha"), DateTime.Now)
                minutos = DateDiff(DateInterval.Minute, resultado.GetDateTime("fecha"), DateTime.Now)
                segundos = DateDiff(DateInterval.Second, resultado.GetDateTime("fecha"), DateTime.Now)

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

                dgvTablero.Rows(num_col).Cells("TIEMPO TRANSCURRIDO").Value = "Días:" & dias & "   " & horas2 & ":" & minutos2 & ":" & segundos
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If bandera = False Then
            dgvTablero.Rows(num_col).Cells("ESTADO").Value = "SIN TRABAJAR"
        End If

        'CONSULTAMOS SI LA ORDEN DE TRABAJO YA FUE CONCLUIDA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                If resultado.GetString("estado") <> "TERMINADO" Then
                    bandera2 = False
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If bandera2 Then
            dgvTablero.Rows(num_col).Cells("ESTADO").Value = "TERMINADO"
        End If

    End Sub
#End Region

#Region "TABLERO_2"
    Public Sub create_tablero2()
        'LIMPIA COLUMNAS
        dgvTablero.Columns.Clear()

        'CREA LAS COLUMNAS
        Dim nombre_0 As New DataGridViewTextBoxColumn
        nombre_0.Name = "id_estacion"
        nombre_0.Visible = False
        dgvTablero.Columns.Add(nombre_0)

        Dim nombre_7 As New DataGridViewTextBoxColumn
        nombre_7.Name = "id_detalle"
        nombre_7.Visible = False
        dgvTablero.Columns.Add(nombre_7)

        Dim nombre_1 As New DataGridViewTextBoxColumn
        nombre_1.Name = "NOMBRE ESTACIÓN"
        nombre_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_1.Width = 300
        dgvTablero.Columns.Add(nombre_1)

        Dim nombre_2 As New DataGridViewTextBoxColumn
        nombre_2.Name = "ESTADO"
        nombre_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_2.Width = 100
        dgvTablero.Columns.Add(nombre_2)

        Dim nombre_3 As New DataGridViewTextBoxColumn
        nombre_3.Name = "ORDEN DE TRABAJO"
        nombre_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_3.Width = 100
        dgvTablero.Columns.Add(nombre_3)

        Dim nombre_10 As New DataGridViewTextBoxColumn
        nombre_10.Name = "UNIDAD"
        nombre_10.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_10.Width = 100
        dgvTablero.Columns.Add(nombre_10)

        Dim nombre_9 As New DataGridViewTextBoxColumn
        nombre_9.Name = "MRO"
        nombre_9.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_9.Width = 100
        dgvTablero.Columns.Add(nombre_9)

        Dim nombre_4 As New DataGridViewTextBoxColumn
        nombre_4.Name = "FECHA COMIENZO"
        nombre_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_4.Width = 200
        dgvTablero.Columns.Add(nombre_4)

        Dim nombre_8 As New DataGridViewTextBoxColumn
        nombre_8.Name = "FECHA ENTREGA INTERNA"
        nombre_8.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_8.Width = 200
        dgvTablero.Columns.Add(nombre_8)

        Dim nombre_5 As New DataGridViewTextBoxColumn
        nombre_5.Name = "TIEMPO TRANSCURRIDO"
        nombre_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_5.Width = 100
        dgvTablero.Columns.Add(nombre_5)

        Dim nombre_6 As New DataGridViewTextBoxColumn
        nombre_6.Name = "HORAS ESTIMADAS"
        nombre_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_6.Width = 100
        dgvTablero.Columns.Add(nombre_6)
    End Sub

    Public Sub get_tablero2()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

        dgvTablero.Rows.Clear()

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from estacion e join (proceso p) on (e.id_proceso = p.id_proceso) where p.clave = '" & cbBusq2.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_estacion"), 0, resultado.GetString("nombre"))
                busca_estado_2(resultado.GetString("id_estacion"), num_col)
                num_col = num_col + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub busca_estado_2(ByVal id_estacion As Integer, ByVal num_col As Integer)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_detalle As Integer = 0
        Dim id_proc As Integer = 0

        Dim dias As String = ""
        Dim horas As String = ""
        Dim horas2 As String = ""
        Dim minutos As String = ""
        Dim minutos2 As String = ""
        Dim segundos As String = ""

        dgvTablero.Rows(num_col).Cells("ESTADO").Value = "LIBRE"

        'BUSCAMOS EL ESTADO DE LA ESTACIÓN
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select ot.serie, ot.folio, po.tiempo,po.id_proceso, po.id_detalle, po.fecha_interna, u.clave, d.mro from proceso_ot po 
                                            join (detalle d, unidad u, orden_trabajo ot) on (d.id_detalle = po.id_detalle and d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) 
                                            where po.id_estacion = '" & id_estacion & "' and po.estado = 'EN CURSO'; ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells("ESTADO").Value = "OCUPADO"
                dgvTablero.Rows(num_col).Cells("FECHA ENTREGA INTERNA").Value = resultado.GetString("fecha_interna")
                dgvTablero.Rows(num_col).Cells("HORAS ESTIMADAS").Value = resultado.GetString("tiempo")
                dgvTablero.Rows(num_col).Cells("ORDEN DE TRABAJO").Value = resultado.GetString("serie") & " - " & resultado.GetString("folio")
                dgvTablero.Rows(num_col).Cells("UNIDAD").Value = resultado.GetString("clave")
                dgvTablero.Rows(num_col).Cells("MRO").Value = resultado.GetString("mro")
                id_detalle = resultado.GetString("id_detalle")
                id_proc = resultado.GetString("id_proceso")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'CONSULTAMOS LA FECHA DE INICIO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select h.fecha from historial h join (proceso_ot po) on (h.id_detalle = po.id_detalle) where h.id_detalle = '" & id_detalle & "' and h.id_proceso = '" & id_proc & "' and po.estado = 'EN CURSO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells("FECHA COMIENZO").Value = resultado.GetDateTime("fecha")

                dias = DateDiff(DateInterval.Day, resultado.GetDateTime("fecha"), DateTime.Now)
                horas = DateDiff(DateInterval.Hour, resultado.GetDateTime("fecha"), DateTime.Now)
                minutos = DateDiff(DateInterval.Minute, resultado.GetDateTime("fecha"), DateTime.Now)
                segundos = DateDiff(DateInterval.Second, resultado.GetDateTime("fecha"), DateTime.Now)

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

                dgvTablero.Rows(num_col).Cells("TIEMPO TRANSCURRIDO").Value = "Días:" & dias & "   " & horas2 & ":" & minutos2 & ":" & segundos
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub
#End Region

#Region "TABLERO_3 PROYECTO INDIVIDUAL"
    Public Sub create_tablero3()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'LIMPIA COLUMNAS
        dgvTablero.Columns.Clear()

        'CREA LAS COLUMNAS
        Dim nombre_0 As New DataGridViewTextBoxColumn
        nombre_0.Name = "id_detalle"
        nombre_0.Visible = False
        dgvTablero.Columns.Add(nombre_0)

        Dim nombre_1 As New DataGridViewTextBoxColumn
        nombre_1.Name = "ORDEN DE TRABAJO"
        nombre_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_1.Width = 100
        dgvTablero.Columns.Add(nombre_1)

        Dim nombre_6 As New DataGridViewTextBoxColumn
        nombre_6.Name = "UNIDAD"
        nombre_6.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_6.Width = 100
        dgvTablero.Columns.Add(nombre_6)

        Dim nombre_7 As New DataGridViewTextBoxColumn
        nombre_7.Name = "DETALLE"
        nombre_7.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_7.Width = 100
        dgvTablero.Columns.Add(nombre_7)

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso order by clave ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim col As New DataGridViewTextBoxColumn
                col.Name = resultado.GetString("clave")
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                col.Width = 100
                dgvTablero.Columns.Add(col)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Dim nombre_5 As New DataGridViewTextBoxColumn
        nombre_5.Name = "FECHA COMIENZO"
        nombre_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_5.Width = 200
        dgvTablero.Columns.Add(nombre_5)

        Dim nombre_3 As New DataGridViewTextBoxColumn
        nombre_3.Name = "FECHA ENTREGA TOTAL INTERNA"
        nombre_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_3.Width = 200
        dgvTablero.Columns.Add(nombre_3)

        Dim nombre_4 As New DataGridViewTextBoxColumn
        nombre_4.Name = "TIEMPO TRANSCURRIDO"
        nombre_4.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_4.Width = 300
        dgvTablero.Columns.Add(nombre_4)

        Dim nombre_2 As New DataGridViewTextBoxColumn
        nombre_2.Name = "COMPLETO"
        nombre_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_2.Width = 200
        dgvTablero.Columns.Add(nombre_2)
    End Sub

    Public Sub get_tablero3()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

        dgvTablero.Rows.Clear()

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct(d.id_detalle),serie,folio,mro,clave from orden_trabajo ot join (unidad u, detalle d, historial h) on (ot.id_ot = u.id_ot and u.id_unidad = d.id_unidad and h.id_detalle = d.id_detalle) where ot.estado = 1 and ot.proyecto = '" & cbBusq2.Text & "' and  h.id_proceso <> 0 ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_detalle"), resultado.GetString("serie") & " - " & resultado.GetString("folio"), resultado.GetString("clave"), resultado.GetString("mro"))
                busca_estado_3(resultado.GetString("id_detalle"), num_col, resultado.GetString("serie") & " - " & resultado.GetString("folio"))
                num_col = num_col + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub busca_estado_3(ByVal id_det As Integer, ByVal num_col As Integer, ByVal serie As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bandera As Boolean = False
        Dim result As Integer = 0

        Dim dias As String = ""
        Dim horas As String = ""
        Dim horas2 As String = ""
        Dim minutos As String = ""
        Dim minutos2 As String = ""
        Dim segundos As String = ""

        Dim num_proc As Decimal = 0
        Dim proc_ter As Decimal = 0
        Dim porcentaje As Decimal = 0

        'EN QUE PROCESO SE ENCUENTRA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso_ot po join (proceso p) on (po.id_proceso = p.id_proceso) where po.id_detalle = '" & id_det & "' and po.estado = 'EN CURSO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells(resultado.GetString("clave")).Value = serie
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'FECHA DE INICIO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from historial where id_detalle = '" & id_det & "' order by id_hist desc ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells("FECHA COMIENZO").Value = resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy  hh:mm:ss")

                dias = DateDiff(DateInterval.Day, resultado.GetDateTime("fecha"), DateTime.Now)
                horas = DateDiff(DateInterval.Hour, resultado.GetDateTime("fecha"), DateTime.Now)
                minutos = DateDiff(DateInterval.Minute, resultado.GetDateTime("fecha"), DateTime.Now)
                segundos = DateDiff(DateInterval.Second, resultado.GetDateTime("fecha"), DateTime.Now)

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

                dgvTablero.Rows(num_col).Cells("TIEMPO TRANSCURRIDO").Value = "Días:" & dias & "   " & horas2 & ":" & minutos2 & ":" & segundos
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'FECHA FINAL
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_det & "' order by num_proc ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells("FECHA ENTREGA TOTAL INTERNA").Value = resultado.GetDateTime("fecha_interna").ToString("dd/MMMM/yyyy  hh:mm:ss")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'CALCULAMOS EL PORCENTAJE
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select count(id_detalle) from proceso_ot where id_detalle = '" & id_det & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                num_proc = resultado.GetDecimal("count(id_detalle)")
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
            comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_det & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                If resultado.GetString("estado") = "TERMINADO" Then
                    proc_ter = proc_ter + 1
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Try
            porcentaje = (proc_ter * 100) / num_proc
        Catch ex As Exception
            porcentaje = 0
        End Try

        dgvTablero.Rows(num_col).Cells("COMPLETO").Value = porcentaje & "%"

        If porcentaje = 100 Then
            dgvTablero.Rows(num_col).Cells("TIEMPO TRANSCURRIDO").Value = ""
        End If
    End Sub
#End Region

#Region "TABLERO_4 PROYECTO TODOS"
    Public Sub create_tablero4()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'LIMPIA COLUMNAS
        dgvTablero.Columns.Clear()

        'CREA LAS COLUMNAS
        Dim nombre_1 As New DataGridViewTextBoxColumn
        nombre_1.Name = "PROYECTO"
        nombre_1.Visible = True
        nombre_1.Width = 300
        dgvTablero.Columns.Add(nombre_1)

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso order by clave ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim col As New DataGridViewTextBoxColumn
                col.Name = resultado.GetString("clave")
                col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
                col.Width = 100
                dgvTablero.Columns.Add(col)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Dim nombre_2 As New DataGridViewTextBoxColumn
        nombre_2.Name = "COMPLETO"
        nombre_2.Visible = True
        nombre_2.Width = 200
        dgvTablero.Columns.Add(nombre_2)
    End Sub

    Public Sub get_tablero4()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

        dgvTablero.Rows.Clear()

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct(proyecto) from orden_trabajo order by proyecto  ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("proyecto"))
                busca_estado_4(num_col, resultado.GetString("proyecto"))
                num_col = num_col + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub busca_estado_4(ByVal num_col As Integer, ByVal nombre_proyecto As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim tot_tar As Integer = 0
        Dim tot_tar_f As Integer = 0
        Dim por As Integer = 0

        'BUSCAMOS EL PORCENTAJE POR PROCESO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso order by clave ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells(resultado.GetString("clave")).Value = obtiene_porcentaje(nombre_proyecto, resultado.GetString("clave")) & " %"
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'OBTENEMOS PORCENTAJE DEL PROYECTO COMPLETO

        'OBTENEMOS EL TOTAL DE TAREAS POR PORYECTO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select count(po.estado) from orden_trabajo ot join (unidad u, detalle d , proceso_ot po) on (ot.id_ot = u.id_ot and u.id_unidad = d.id_unidad and d.id_detalle = po.id_detalle) where ot.proyecto = '" & nombre_proyecto & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tot_tar = resultado.GetUInt64("count(po.estado)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'OBTENEMOS EL TOTAL DE TAREAS POR PROYECTO TERMINADAS
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select count(po.estado) from orden_trabajo ot join (unidad u, detalle d , proceso_ot po) on (ot.id_ot = u.id_ot and u.id_unidad = d.id_unidad and d.id_detalle = po.id_detalle) where ot.proyecto = '" & nombre_proyecto & "' and po.estado = 'TERMINADO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tot_tar_f = resultado.GetUInt64("count(po.estado)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Try
            por = (tot_tar_f * 100) / tot_tar
        Catch ex As Exception
            por = 0
        End Try

        dgvTablero.Rows(num_col).Cells("COMPLETO").Value = por & " %"
    End Sub

    Public Function obtiene_porcentaje(ByVal nombre_proyecto As String, ByVal proceso As String) As String
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_p As Integer = 0
        Dim num_e As Integer = 0
        Dim porc As Integer = 0

        'NUMERO DE ESTACIONES UTILIZADAS EN EL MOMENTO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select count(p.clave)
                                            from orden_trabajo ot join (proceso p, proceso_ot po, unidad u, detalle d) 
                                            on (ot.id_ot = u.id_ot and u.id_unidad = d.id_unidad and d.id_detalle = po.id_detalle and po.id_proceso = p.id_proceso) 
                                            where ot.proyecto = '" & nombre_proyecto & "' and po.estado = 'EN CURSO' and p.clave = '" & proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                num_p = resultado.GetString("count(p.clave)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'NUMERO DE ESTACIONES EXISTENTES
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select count(e.id_proceso)  from estacion e join (proceso p) on (p.id_proceso = e.id_proceso) where p.clave = '" & proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                num_e = resultado.GetString("count(e.id_proceso)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Try
            porc = (num_p * 100) / num_e
        Catch ex As Exception
            porc = 0
        End Try

        Return porc
    End Function
#End Region

#Region "TABLERO_5 OT TODOS"
    Public Sub get_tablero5()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0
        Dim serie As String = ""
        Dim folio As String = ""
        dgvTablero.Rows.Clear()

        'OBTIENE SERIE Y FOLIO OT
        Dim aux() As String
        Dim id_ot As Integer = 0

        aux = cbBusq2.Text.ToString.Split("-")
        Try
            serie = aux(0)
            folio = aux(1) & "-" & aux(2) & "-" & aux(3)
        Catch ex As Exception
            serie = ""
            folio = ""
        End Try
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo where serie = '" & serie & "' and folio = '" & folio & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_ot = resultado.GetInt64("id_ot")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct(d.id_detalle), ot.serie, ot.folio, u.clave, d.mro from orden_trabajo ot join (unidad u, detalle d, historial h) on (u.id_ot = ot.id_ot and d.id_unidad = u.id_unidad and h.id_detalle = d.id_detalle) where ot.estado = 1 and ot.id_ot = '" & id_ot & "' and  h.id_proceso <> 0 ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_detalle"), resultado.GetString("serie") & " - " & resultado.GetString("folio"), resultado.GetString("clave"), resultado.GetString("mro"))
                busca_estado(resultado.GetString("id_detalle"), num_col, resultado.GetString("serie") & " - " & resultado.GetString("folio"))
                num_col = num_col + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub
#End Region

#Region "TABLERO_6 OT UNIDAD"
    Public Sub get_tablero6()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0
        Dim serie As String = ""
        Dim folio As String = ""
        dgvTablero.Rows.Clear()

        'OBTIENE SERIE Y FOLIO OT
        Dim aux() As String
        Dim id_ot As Integer = 0
        Dim id_unidad As Integer

        aux = cbBusq2.Text.ToString.Split("-")
        Try
            serie = aux(0)
            folio = aux(1) & "-" & aux(2) & "-" & aux(3)
        Catch ex As Exception
            serie = ""
            folio = ""
        End Try
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo where serie = '" & serie & "' and folio = '" & folio & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_ot = resultado.GetInt64("id_ot")
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
            comandoSql = New MySqlCommand(" select * from unidad where id_ot = '" & id_ot & "' and clave = '" & cbBusq3.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_unidad = resultado.GetInt64("id_unidad")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct(d.id_detalle), ot.serie, ot.folio, u.clave, d.mro from orden_trabajo ot join (unidad u, detalle d, historial h) on (u.id_ot = ot.id_ot and d.id_unidad = u.id_unidad and h.id_detalle = d.id_detalle) where ot.estado = 1 and ot.id_ot = '" & id_ot & "' and u.id_unidad = '" & id_unidad & "' and  h.id_proceso <> 0 ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_detalle"), resultado.GetString("serie") & " - " & resultado.GetString("folio"), resultado.GetString("clave"), resultado.GetString("mro"))
                busca_estado(resultado.GetString("id_detalle"), num_col, resultado.GetString("serie") & " - " & resultado.GetString("folio"))
                num_col = num_col + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub
#End Region

    Private Sub tFecha_Tick(sender As Object, e As EventArgs) Handles tFecha.Tick
        lbFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy hh:mm:ss")
        Select Case tipo_tablero
            Case "1"
                get_tablero1()
            Case "2"
                get_tablero2()
            Case "3"
                get_tablero3()
            Case "4"
                get_tablero4()
            Case "5"
                get_tablero5()
            Case "6"
                get_tablero6()
        End Select
    End Sub

    Private Sub scrTablero2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        create_tablero1()
    End Sub

    Private Sub cbBusq1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBusq1.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbBusq2.Items.Clear()
        cbBusq3.Items.Clear()

        cbBusq2.Text = ""
        cbBusq3.Text = ""

        Select Case cbBusq1.Text
            Case "Estación"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select * from proceso", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        cbBusq2.Items.Add(resultado.GetString("clave"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()

            Case "Orden de Trabajo"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select * from orden_trabajo where estado = 1 ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        cbBusq2.Items.Add(resultado.GetString("serie") & "-" & resultado.GetString("folio"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
                cbBusq2.Items.Add("Todos")

            Case "Proyecto"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select distinct proyecto from orden_trabajo where estado = 1 ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        cbBusq2.Items.Add(resultado.GetString("proyecto"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
                cbBusq2.Items.Add("Todos")
        End Select
    End Sub

    Private Sub cbBusq2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBusq2.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbBusq3.Items.Clear()
        cbBusq3.Text = ""

        Dim aux() As String
        Dim id_ot As Integer = 0

        Select Case cbBusq1.Text
            Case "Orden de Trabajo"
                Select Case cbBusq2.Text
                    Case "Todos"
                    Case Else
                        'OBTENEMOS ID DE LA OT
                        aux = cbBusq2.Text.ToString.Split("-")
                        Try
                            conexion_GlobalSI()
                            _conexionSI.Open()
                            comandoSql = New MySqlCommand(" select * from orden_trabajo where serie = '" & aux(0) & "' and folio = '" & aux(1) & "-" & aux(2) & "-" & aux(3) & "' ", _conexionSI)
                            resultado = comandoSql.ExecuteReader
                            'Dentro de un ciclo leemos los resultados
                            While resultado.Read
                                id_ot = resultado.GetInt64("id_ot")
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
                            comandoSql = New MySqlCommand(" select * from unidad where id_ot = '" & id_ot & "' ", _conexionSI)
                            resultado = comandoSql.ExecuteReader
                            'Dentro de un ciclo leemos los resultados
                            While resultado.Read
                                cbBusq3.Items.Add(resultado.GetString("clave"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrarSI()
                        End Try
                        _conexionSI.Close()

                        cbBusq3.Items.Add("Todos")
                End Select
        End Select
    End Sub

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        Select Case cbBusq1.Text
            Case "Estación"
                tipo_tablero = "2"
                create_tablero2()
                get_tablero2()
            Case "Orden de Trabajo"
                Select Case cbBusq2.Text
                    Case "Todos"
                        tipo_tablero = "1"
                        create_tablero1()
                        get_tablero1()
                    Case Else
                        Select Case cbBusq3.Text
                            Case "Todos"
                                tipo_tablero = "5"
                                create_tablero1()
                                get_tablero5()
                            Case Else
                                tipo_tablero = "6"
                                create_tablero1()
                                get_tablero6()
                        End Select
                End Select
            Case "Proyecto"
                Select Case cbBusq2.Text
                    Case "Todos"
                        tipo_tablero = "4"
                        create_tablero4()
                        get_tablero4()
                    Case Else
                        tipo_tablero = "3"
                        create_tablero3()
                        get_tablero3()
                End Select
        End Select
    End Sub
End Class