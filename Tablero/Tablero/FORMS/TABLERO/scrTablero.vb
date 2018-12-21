Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrTablero
#Region "VARIABLES GLOBALES"
    Dim contador As Integer = 0
    Public id_ot As Integer = 3
#End Region

#Region "FUNCIONES"
#Region "FUNCIONES VIEJAS"
    Public Sub init_tablero()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0
        Dim resul As Integer = 0

        'DEFINE EL NÚMERO DE COLUMNAS
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo_det where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                resul = define_columnas(resultado.GetString("mro"))
                If num_col < resul Then
                    num_col = resul
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'CREA LAS COLUMNAS
        crea_columnas(num_col)

        num_col = 0

        'LLENA DATAGRID
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct(po.mro), ot.tratamiento, ot.cantidad from proceso_ot po 
                                            join (orden_trabajo_det ot) on (ot.mro = po.mro) 
                                            where po.id_ot =  '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("mro"),
                                    resultado.GetString("tratamiento"),
                                    resultado.GetString("cantidad"))
                encuentra_mro(resultado.GetString("mro"), num_col)
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

    Public Sub encuentra_mro(ByVal mro As String, ByVal num_col As Integer)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim cont As Integer = 3

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select p.clave from proceso_ot po join (proceso p) on (po.id_proceso = p.id_proceso) where po.id_ot = '" & id_ot & "' and po.mro = '" & mro & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells(cont).Value = resultado.GetString("clave")
                cont = cont + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Function define_columnas(ByVal mro As String) As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim col As Integer = 0

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select count(mro) from proceso_ot po join (proceso p) on (po.id_proceso = p.id_proceso) where po.id_ot = '" & id_ot & "' and po.mro = '" & mro & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                col = resultado.GetDecimal("count(mro)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Return col
    End Function

    Public Sub crea_columnas(ByVal numero As Integer)
        Dim i As Integer = 0

        'LIMPIA COLUMNAS
        dgvTablero.Columns.Clear()

        'CREA LAS COLUMNAS
        Dim nombre_1 As New DataGridViewTextBoxColumn
        nombre_1.Name = "MRO"
        nombre_1.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_1.Width = 150
        dgvTablero.Columns.Add(nombre_1)

        Dim nombre_2 As New DataGridViewTextBoxColumn
        nombre_2.Name = "TRATAMIENTO"
        nombre_2.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_2.Width = 150
        dgvTablero.Columns.Add(nombre_2)

        Dim nombre_3 As New DataGridViewTextBoxColumn
        nombre_3.Name = "CANTIDAD"
        nombre_3.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        nombre_3.Width = 150
        dgvTablero.Columns.Add(nombre_3)

        For i = 0 To numero - 1
            Dim col As New DataGridViewTextBoxColumn
            col.Name = "PROCESO " & i + 1
            col.AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
            col.Width = 300
            dgvTablero.Columns.Add(col)
        Next

    End Sub
#End Region

    Public Sub init_tablero2()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

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

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo ot join (orden_trabajo_det od) on (ot.id_ot = od.id_ot) where ot.estado = 1 ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_ot"), resultado.GetString("serie") & " - " & resultado.GetString("folio"))
                busca_estado(resultado.GetString("id_ot"), resultado.GetString("mro"), num_col, resultado.GetString("serie") & " - " & resultado.GetString("folio"))
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

    Public Sub tablero_proyecto()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

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

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo ot join (orden_trabajo_det od) on (ot.id_ot = od.id_ot) where ot.estado = 1 and ot.proyecto = '" & cbOpcion.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_ot"), resultado.GetString("serie") & " - " & resultado.GetString("folio"))
                busca_estado_2(resultado.GetString("id_ot"), resultado.GetString("mro"), num_col, resultado.GetString("serie") & " - " & resultado.GetString("folio"))
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

    Public Sub busca_estado(ByVal id_ott As Integer, ByVal mro As String, ByVal num_col As Integer, ByVal serie As String)
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

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select h.fecha, po.fecha_interna, p.clave from historial h 
                                            join (proceso_ot po, proceso p) on (h.id_ot = po.id_ot and p.id_proceso = po.id_proceso and h.id_proceso = p.id_proceso) 
                                            where h.id_ot = '" & id_ott & "' and h.estado = 'EN CURSO' and po.estado <> 'TERMINADO' order by po.num_proc desc ", _conexionSI)
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
            comandoSql = New MySqlCommand(" select * from orden_trabajo where id_ot = '" & id_ott & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                If resultado.GetString("momento") = "TERMINADO" Then
                    dgvTablero.Rows(num_col).Cells("ESTADO").Value = "TERMINADO"
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub busca_estado_2(ByVal id_ott As Integer, ByVal mro As String, ByVal num_col As Integer, ByVal serie As String)
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
            comandoSql = New MySqlCommand(" select h.fecha, po.fecha_interna, p.clave from historial h 
                                            join (proceso_ot po, proceso p) on (h.id_ot = po.id_ot and p.id_proceso = po.id_proceso and h.id_proceso = p.id_proceso) 
                                            where h.id_ot = '" & id_ott & "' and h.estado = 'EN CURSO' and po.estado <> 'TERMINADO' order by po.num_proc desc ", _conexionSI)
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
            comandoSql = New MySqlCommand(" select * from historial where id_ot = '" & id_ott & "' order by id_hist desc ", _conexionSI)
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
            comandoSql = New MySqlCommand(" select * from proceso_ot where id_ot = '" & id_ott & "' ", _conexionSI)
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
            comandoSql = New MySqlCommand(" select count(id_ot) from proceso_ot where id_ot = '" & id_ott & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                num_proc = resultado.GetDecimal("count(id_ot)")
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
            comandoSql = New MySqlCommand(" select * from proceso_ot where id_ot = '" & id_ott & "' ", _conexionSI)
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

    Public Sub tipo_seleccionado()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbOpcion.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select distinct proyecto from orden_trabajo order by proyecto ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbOpcion.Items.Add(resultado.GetString("proyecto"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        cbOpcion.Items.Add("TODOS")
    End Sub

    Public Sub init_estacion()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbOpcion.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso order by clave", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbOpcion.Items.Add(resultado.GetString("clave"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub tablero_estacion()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

        'LIMPIA COLUMNAS
        dgvTablero.Columns.Clear()

        'CREA LAS COLUMNAS
        Dim nombre_0 As New DataGridViewTextBoxColumn
        nombre_0.Name = "id_estacion"
        nombre_0.Visible = False
        dgvTablero.Columns.Add(nombre_0)

        Dim nombre_7 As New DataGridViewTextBoxColumn
        nombre_7.Name = "id_ot"
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

        'LLENA TABLA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from estacion e join (proceso p) on (e.id_proceso = p.id_proceso) where p.clave = '" & cbOpcion.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows.Add(resultado.GetString("id_estacion"), 0, resultado.GetString("nombre"))
                busca_estado_3(resultado.GetString("id_estacion"), num_col)
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

    Public Sub busca_estado_3(ByVal id_estacion As Integer, ByVal num_col As Integer)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_odt As Integer = 0
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
            comandoSql = New MySqlCommand(" select ot.serie, ot.folio, po.horas,p.id_proceso, po.id_ot, po.fecha_interna from proceso_ot po 
                                            join (proceso p, orden_trabajo ot) on (p.id_proceso = po.id_proceso and po.id_ot = ot.id_ot) 
                                            where po.id_estacion = '" & id_estacion & "' and po.estado = 'EN CURSO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvTablero.Rows(num_col).Cells("ESTADO").Value = "OCUPADO"
                dgvTablero.Rows(num_col).Cells("FECHA ENTREGA INTERNA").Value = resultado.GetString("fecha_interna")
                dgvTablero.Rows(num_col).Cells("HORAS ESTIMADAS").Value = resultado.GetString("horas")
                dgvTablero.Rows(num_col).Cells("ORDEN DE TRABAJO").Value = resultado.GetString("serie") & " - " & resultado.GetString("folio")
                id_odt = resultado.GetString("id_ot")
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
            comandoSql = New MySqlCommand(" select h.fecha from historial h join (proceso_ot po) on (h.id_ot = po.id_ot) where h.id_ot = '" & id_odt & "' and h.id_proceso = '" & id_proc & "' and po.estado = 'EN CURSO' ", _conexionSI)
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

    Public Sub tablero_proyecto_t()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim num_col As Integer = 0

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
            comandoSql = New MySqlCommand(" select count(pt.estado) from proceso_ot pt join (orden_trabajo ot) on (ot.id_ot = pt.id_ot) where ot.proyecto = '" & nombre_proyecto & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tot_tar = resultado.GetUInt64("count(pt.estado)")
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
            comandoSql = New MySqlCommand(" select count(pt.estado) from proceso_ot pt join (orden_trabajo ot) on (ot.id_ot = pt.id_ot) where ot.proyecto = '" & nombre_proyecto & "' and pt.estado = 'TERMINADO' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tot_tar_f = resultado.GetUInt64("count(pt.estado)")
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
                                            from orden_trabajo ot join (proceso p, proceso_ot po, estacion e) on (po.id_ot = ot.id_ot and po.id_proceso = p.id_proceso and e.id_estacion = po.id_estacion) 
                                            where ot.proyecto = '" & nombre_proyecto & "' and po.estado = 'EN CURSO' and p.clave = '" & proceso & "'", _conexionSI)
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

    Private Sub tFecha_Tick(sender As Object, e As EventArgs) Handles tFecha.Tick
        lbFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy hh:mm:ss")
        init_tablero2()
    End Sub

    Private Sub tFecha2_Tick(sender As Object, e As EventArgs) Handles tFecha2.Tick
        lbFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy hh:mm:ss")
        tablero_proyecto()
    End Sub

    Private Sub tEstacion_Tick(sender As Object, e As EventArgs) Handles tEstacion.Tick
        lbFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy hh:mm:ss")
        tablero_estacion()
    End Sub

    Private Sub tProyecto_t_Tick(sender As Object, e As EventArgs) Handles tProyecto_t.Tick
        lbFecha.Text = DateTime.Now.ToString("dd/MMMM/yyyy hh:mm:ss")
        tablero_proyecto_t()
    End Sub

    Private Sub scrTablero_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_tablero2()
    End Sub

    Private Sub btnTareas_Click(sender As Object, e As EventArgs) Handles btnTareas.Click
        scrTarea.Show()
        scrTarea.BringToFront()
    End Sub

    Private Sub cbTipo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbTipo.SelectedIndexChanged
        Select Case cbTipo.Text
            Case "PROYECTO"
                cbOpcion.Text = ""
                tipo_seleccionado()
            Case "ESTACIÓN"
                cbOpcion.Text = ""
                init_estacion()
            Case "TODOS"
                cbOpcion.Text = ""
                cbOpcion.Items.Clear()
        End Select
    End Sub

    Private Sub btnBuscqueda_Click(sender As Object, e As EventArgs) Handles btnBuscqueda.Click
        Select Case cbTipo.Text
            Case "PROYECTO"
                Select Case cbOpcion.Text
                    Case "TODOS"
                        tablero_proyecto_t()

                        tProyecto_t.Enabled = True
                        tEstacion.Enabled = False
                        tFecha2.Enabled = False
                        tFecha.Enabled = False
                    Case Else
                        tablero_proyecto()

                        tProyecto_t.Enabled = False
                        tEstacion.Enabled = False
                        tFecha2.Enabled = True
                        tFecha.Enabled = False
                End Select
            Case "ESTACIÓN"
                tablero_estacion()

                tProyecto_t.Enabled = False
                tEstacion.Enabled = True
                tFecha2.Enabled = False
                tFecha.Enabled = False
            Case "TODOS"
                init_tablero2()

                tProyecto_t.Enabled = False
                tEstacion.Enabled = False
                tFecha2.Enabled = False
                tFecha.Enabled = True
        End Select
    End Sub

End Class