Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrTablero3
#Region "VARIABLES GLOBALES"
    Dim tipo_tablero As String = "1"
#End Region

#Region "TABLERO 1"
    Public Sub create_tablero1()
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
            comandoSql = New MySqlCommand(" select d.id_detalle, ot.serie, ot.folio, u.clave, d.mro from orden_trabajo ot join (unidad u, detalle d) on (u.id_ot = ot.id_ot and d.id_unidad = u.id_unidad) where ot.estado = 1 ", _conexionSI)
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
            comandoSql = New MySqlCommand(" select h.fecha from historial h where h.id_detalle = '" & id_detalle & "' and
                                            h.estado = 'EN CURSO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                bandera = True

                dgvTablero.Rows(num_col).Cells("ESTADO").Value = "EN CURSO"
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

        If bandera = False Then
            dgvTablero.Rows(num_col).Cells("ESTADO").Value = "SIN TRABAJAR"
        End If

    End Sub
#End Region

#Region "TABLERO_3 PROYECTO INDIVIDUAL"
    Public Sub create_tablero3()
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

        Dim nombre_5 As New DataGridViewTextBoxColumn
        nombre_5.Name = "FECHA COMIENZO"
        nombre_5.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_5.Width = 200
        dgvTablero.Columns.Add(nombre_5)

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
            comandoSql = New MySqlCommand(" select * from orden_trabajo ot join (unidad u, detalle d) on (ot.id_ot = u.id_ot and u.id_unidad = d.id_unidad) where ot.estado = 1 and ot.proyecto = '" & cbBusq2.Text & "' ", _conexionSI)
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

    End Sub
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
            comandoSql = New MySqlCommand(" select d.id_detalle, ot.serie, ot.folio, u.clave, d.mro from orden_trabajo ot join (unidad u, detalle d) on (u.id_ot = ot.id_ot and d.id_unidad = u.id_unidad) where ot.estado = 1 and ot.id_ot = '" & id_ot & "' ", _conexionSI)
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
            comandoSql = New MySqlCommand(" select d.id_detalle, ot.serie, ot.folio, u.clave, d.mro from orden_trabajo ot join (unidad u, detalle d) on (u.id_ot = ot.id_ot and d.id_unidad = u.id_unidad) where ot.estado = 1 and ot.id_ot = '" & id_ot & "' and u.id_unidad = '" & id_unidad & "' ", _conexionSI)
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
            Case "3"
                get_tablero3()
            Case "5"
                get_tablero5()
            Case "6"
                get_tablero6()
        End Select

    End Sub

    Private Sub scrTablero3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
                    Case Else
                        tipo_tablero = "3"
                        create_tablero3()
                        get_tablero3()
                End Select
        End Select
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        scrTipoReporte.Show()
        scrTipoReporte.BringToFront()
    End Sub
End Class