Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class scrTarea
#Region "VARIABLES GLOBALES"
    Dim id_ot As Integer = 0
    Dim num_proceso As Integer = 0
    Dim id_proceso_com As Integer = 0
    Dim id_estacion As Integer = 0
    Dim indice_cambios As Integer = 0
#End Region

#Region "FUNCIONES"

    Public Sub orden_trabajo_seleccionado()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvProcesos.Rows.Clear()
        dgvObserva.Rows.Clear()
        dgvCambios.Rows.Clear()
        dgvAux.Rows.Clear()

        Dim num_col As Integer = 0
        Dim cont As Integer = 0
        Dim cadena As String()
        Dim folio As String = ""
        Dim bandera As Boolean = False
        Dim momento As String = ""

        lbProceso.Text = "SIN TRABAJAR"
        lbProceso2.Text = "SIN TRABAJAR"
        lbEstado.Text = "ESTADO"

        cadena = cbOT.Text.Split("-")
        folio = cadena(1) & "-" & cadena(2) & "-" & cadena(3)

        'OBTENEMOS ID DE LA ORDEN DE TRABAJO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo where serie = '" & cadena(0) & "' and folio = '" & folio & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_ot = resultado.GetString("id_ot")
                momento = resultado.GetString("momento")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'OBTENEMOS EL DETALLE DE LA PIEZA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo_det where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tbMro.Text = resultado.GetString("mro")
                tbTratamiento.Text = resultado.GetString("tratamiento")
                tbCantidad.Text = resultado.GetString("cantidad")
                rtbObservaGen.Text = resultado.GetString("observaciones")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'OBTENEMOS EL PDF DE LA ORDEN DE TRABAJO
        Dim bytes() As Byte
        Dim directorioArchivo As String
        directorioArchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "Ejemplo.pdf"

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo_det otd join (pdf p) on (otd.id_pdf = p.id_pdf) where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                bytes = resultado("pdf")
                BytesAArchivo(bytes, directorioArchivo)
                AxAcroPDF1.src = directorioArchivo
                My.Computer.FileSystem.DeleteFile(directorioArchivo)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'COMPROBAMOS SI LA ORDEN DE TRABAJO YA ESTA TERMINADA
        If momento = "TERMINADO" Then
            lbEstado.Text = "TERMINADO"
            btnComen.Visible = False
            btnEntrega.Visible = False
            Return
        End If

        'LLENAMOS DATAGRID DE SUS PROCESOS
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso_ot po join (proceso p, estacion e) on (po.id_proceso = p.id_proceso and e.id_estacion = po.id_estacion) where po.id_ot = '" & id_ot & "' order by num_proc ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvProcesos.Rows.Add(resultado.GetString("id_proceso"),
                                     resultado.GetString("num_proc"),
                                     resultado.GetString("clave"),
                                     resultado.GetDateTime("fecha_interna").ToString("dd/MMMM/yyyy hh:mm:ss"), 0, "PENDIENTE", resultado.GetString("observaciones"), resultado.GetString("nombre"), resultado.GetString("id_estacion"))

                'MARCAMOS Si YA FUERON COMPLETADOS
                consulta_completado(num_col, resultado.GetString("id_proceso"), resultado.GetString("num_proc"))
                num_col = num_col + 1

                'LLENAMOS DATAGRID DE OBSERVACIONES
                dgvObserva.Rows.Add(resultado.GetString("num_proc"), resultado.GetString("clave"))

                'LLENAMOS DATAGRID DE MODIFICACIONES
                dgvCambios.Rows.Add(resultado.GetString("id_proceso"),
                                         resultado.GetString("num_proc"),
                                         resultado.GetString("clave"),
                                         resultado.GetDateTime("fecha_interna").ToString("dd/MM/yyyy hh:mm:ss"),
                                         resultado.GetDateTime("fecha_cliente").ToString("dd/MM/yyyy hh:mm:ss"),
                                         resultado.GetString("observaciones"),
                                         resultado.GetString("estado"), resultado.GetString("id_estacion"), resultado.GetString("nombre"), resultado.GetString("horas"))

                'LLENAMOS DATAGRID AUXILIAR
                dgvAux.Rows.Add(resultado.GetString("id_proceso"),
                                        resultado.GetString("num_proc"),
                                        resultado.GetString("clave"),
                                        resultado.GetDateTime("fecha_interna").ToString("dd/MM/yyyy hh:mm:ss"),
                                        resultado.GetDateTime("fecha_cliente").ToString("dd/MM/yyyy hh:mm:ss"),
                                        resultado.GetString("observaciones"),
                                        resultado.GetString("estado"), resultado.GetString("id_estacion"), resultado.GetString("nombre"), resultado.GetString("horas"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If lbEstado.Text = "ESTADO" Then
            btnEntrega.Visible = False
            btnComen.Visible = True
        Else
            btnEntrega.Visible = True
            btnComen.Visible = False
        End If

        'PROCESO SIGUIENTE
        For Each row As DataGridViewRow In dgvProcesos.Rows
            cont = cont + 1
            If row.Cells(4).Value = 0 Then
                lbProceso.Text = row.Cells(2).Value
                lbEstacion.Text = row.Cells(7).Value
                id_estacion = row.Cells(8).Value
                num_proceso = row.Cells(1).Value
                rtbObserva.Text = row.Cells(6).Value
                Try
                    lbProceso2.Text = dgvProcesos.Rows(cont).Cells(2).Value
                Catch ex As Exception
                    lbProceso2.Text = "TERMINADO"
                End Try
                Exit For
            End If
        Next

    End Sub

    Public Sub llena_orden_trabajo()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbOT.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from orden_trabajo", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbOT.Items.Add(resultado.GetString("serie") & "-" & resultado.GetString("folio"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub consulta_completado(ByVal num_col As Integer, ByVal id_proceso As Integer, ByVal num_proc As Integer)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select h.estado, po.estado es from historial h join (proceso_ot po) on (h.id_ot = po.id_ot and h.id_proceso = po.id_proceso) 
                                            where (po.id_proceso = '" & id_proceso & "' and po.id_ot = '" & id_ot & "' and po.num_proc = '" & num_proc & "') and (po.estado = 'TERMINADO' or po.estado = 'EN CURSO') ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los  
            While resultado.Read
                If resultado.GetString("estado") = "COMPLETADO" And resultado.GetString("es") = "TERMINADO" Then
                    dgvProcesos.Rows(num_col).Cells(4).Value = 1
                    dgvProcesos.Rows(num_col).Cells(5).Value = "TERMINADO"
                ElseIf resultado.GetString("estado") = "EN CURSO" And resultado.GetString("es") = "EN CURSO" Then
                    calcula_tiempo()
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

    Public Sub calcula_tiempo()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim dias As String = ""
        Dim horas As String = ""
        Dim horas2 As String = ""
        Dim minutos As String = ""
        Dim minutos2 As String = ""
        Dim segundos As String = ""
        Dim result As Integer = 0

        lbTiempo.Text = "Días:00   00:00:00"

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select h.fecha, po.fecha_interna, p.clave from historial h 
                                            join (proceso_ot po, proceso p) on (h.id_ot = po.id_ot and p.id_proceso = po.id_proceso and h.id_proceso = p.id_proceso) 
                                            where h.id_ot = '" & id_ot & "' and h.estado = 'EN CURSO' and po.estado <> 'TERMINADO' order by po.num_proc desc ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read

                result = Date.Compare(DateTime.Now, resultado.GetDateTime("fecha_interna"))
                If result > 0 Then
                    lbEstado.Text = "RETRASO"
                Else
                    lbEstado.Text = "EN CURSO"
                End If

                If lbEstado.Text = "ESTADO" Then
                    btnEntrega.Visible = False
                    btnComen.Visible = True
                Else
                    btnEntrega.Visible = True
                    btnComen.Visible = False
                End If


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

                lbTiempo.Text = "Días:" & dias & "   " & horas2 & ":" & minutos2 & ":" & segundos
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub

    Public Sub comienza_proceso()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim id_proceso As Integer = 0

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso where clave = '" & lbProceso.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_proceso = resultado.GetString("id_proceso")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'CONSULTAMOS SI LA ESTACION ESTA LIBRE PARA COMENZAR EL PROCESO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from estacion where id_estacion = '" & id_estacion & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                If resultado.GetString("estado") = "OCUPADO" Then
                    MessageBox.Show(" Estación en uso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()


        datos.id = id_ot                    'ID ORDEN DE TRABAJO    
        datos.id_polizas = id_proceso       'ID PROCESO
        datos.N_poliza = 0                 'ID USUSARIO
        datos.fecha = DateTime.Now          'FECHA
        datos.estado = "EN CURSO"           'ESTADO

        conexion.insert_historial(datos)

        'ACTUALIZA PORCESO_OT
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update proceso_ot set estado = 'EN CURSO' where id_ot = '" & id_ot & "' and id_proceso = '" & id_proceso & "' and num_proc = '" & num_proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'ACTUALIZA ESTADO DE LA ESTACION
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update estacion set estado = 'OCUPADO' where id_estacion = '" & id_estacion & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub

    Public Sub termina_proceso()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_update_datos

        Dim bandera_t As Boolean = True
        Dim id_proceso As Integer = 0

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso where clave = '" & lbProceso.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_proceso = resultado.GetString("id_proceso")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        datos.id = id_ot                    'ID ORDEN DE TRABAJO    
        datos.id_polizas = id_proceso       'ID PROCESO
        datos.fecha = DateTime.Now          'FECHA
        datos.estado = "COMPLETADO"         'TERMINADO

        conexion.update_historial(datos)

        'ACTUALIZA PROCESO_OT
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update proceso_ot set estado = 'TERMINADO' where id_ot = '" & id_ot & "' and id_proceso = '" & id_proceso & "' and num_proc = '" & num_proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'VERIFICAMOS SI LA ORDEN DE TRABAJO YA FUE COMPLETADA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso_ot where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                If resultado.GetString("estado") <> "TERMINADO" Then
                    bandera_t = False
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'ACTUALIZA ESTADO DE LA ESTACION
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update estacion set estado = 'LIBRE' where id_estacion = '" & id_estacion & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If bandera_t Then
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" update orden_trabajo set momento = 'TERMINADO' where id_ot = '" & id_ot & "' ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()
        End If
    End Sub

    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub

    Public Sub proceso_seleccionado()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim indice As Integer = dgvObserva.CurrentRow.Index.ToString

        'BUSCAMOS ID DEL PROCESO SELECCIONADO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso where clave = '" & dgvObserva.Rows(indice).Cells(1).Value & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_proceso_com = resultado.GetString("id_proceso")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        rtbComen.Text = "NINGUNA"

        'BUSCAMOS SI TIENE COMENTARIOS EN LA TABLA DE HISTORIAL
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from historial where id_ot = '" & id_ot & "' and id_proceso = '" & id_proceso_com & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Try
                    rtbComen.Text = resultado.GetString("observaciones")
                Catch ex As Exception
                    rtbComen.Text = "NINGUNA"
                End Try
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub

    Public Sub realizar_comentario()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" update historial set observaciones = '" & rtbComen.Text & "' where id_ot = '" & id_ot & "' and id_proceso = '" & id_proceso_com & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        MessageBox.Show(" Comentario realizado con éxito ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        rtbComen.Clear()
    End Sub

    Public Sub agrega_nuevo_proceso()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_proc As Integer = 0
        Dim estacion As String = ""
        Dim id_estacion As Integer = 0

        dgvCambios.Rows.Clear()

        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(2).Value = True Then
                estacion = row.Cells(1).Value
                id_estacion = row.Cells(0).Value
            End If
        Next

        'CONDICIONES PARA AGREAGAR UN NUEVO PROCESO
        For Each row As DataGridViewRow In dgvAux.Rows
            If row.Cells(1).Value = tbNumProc.Text Then
                If row.Cells(6).Value = "TERMINADO" Or row.Cells(6).Value = "EN CURSO" Then
                    MessageBox.Show(" No se puede agregar este proceso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
        Next

        'AGREGAMOS EL NUEVO PROCESO EN EL LUGAR CORRESPONDIENTE
        For Each row As DataGridViewRow In dgvAux.Rows
            If row.Cells(1).Value < tbNumProc.Text Then
                dgvCambios.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)

            ElseIf row.Cells(1).Value = tbNumProc.Text Then

                'OBTENEMOS ID DEL PROCESO
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select * from proceso where clave = '" & cbProc.Text & "' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        id_proc = resultado.GetString("id_proceso")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()

                dgvCambios.Rows.Add(id_proc, tbNumProc.Text, cbProc.Text, dtpF_Interna.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), dtpFecha_Cliente.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), tbObs.Text, "", id_estacion, estacion, tbHoras.Text)
                dgvCambios.Rows.Add(row.Cells(0).Value, row.Cells(1).Value + 1, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)

            ElseIf row.Cells(1).Value > tbNumProc.Text Then
                dgvCambios.Rows.Add(row.Cells(0).Value, row.Cells(1).Value + 1, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
            End If
        Next

        'CASO ESPECIAL
        Try
            If dgvCambios.Rows(dgvCambios.Rows.Count - 1).Cells(1).Value < tbNumProc.Text Then
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select * from proceso where clave = '" & cbProc.Text & "' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        id_proc = resultado.GetString("id_proceso")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()

                dgvCambios.Rows.Add(id_proc, tbNumProc.Text, cbProc.Text, dtpF_Interna.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), dtpFecha_Cliente.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), tbObs.Text, "", id_estacion, estacion, tbHoras.Text)
            End If
        Catch ex As Exception

        End Try

        'LIMPIAMOS LOS CAMPOS
        cbProc.Text = ""
        tbNumProc.Clear()
        dgvEstacion.Rows.Clear()
        tbObs.Clear()
    End Sub

    Public Sub obtiene_procesos()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        cbProc.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbProc.Items.Add(resultado.GetString("clave"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub

    Public Sub actualiza_proceso_ot()
        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If btnCambio.Visible Then
            For Each row As DataGridViewRow In dgvCambios.Rows
                'ACTUALIZAMOS LAS ESTACIONES
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" update proceso_ot set id_estacion = '" & row.Cells(7).Value & "' where id_ot = '" & id_ot & "' and id_proceso = '" & row.Cells(0).Value & "' and num_proc = '" & row.Cells(1).Value & "' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Next
        Else
            'BORRAMOS LOS REGISTROS DE LA TABLA
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" delete from proceso_ot where id_ot = '" & id_ot & "'; ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            'AGREGAMOS LAS MODIFICACIONES
            For Each row As DataGridViewRow In dgvCambios.Rows
                datos.id = id_ot                        'ID_ORDEN_TRABAJO
                datos.id_polizas = row.Cells(0).Value   'ID_PROCESO
                datos.calle = tbMro.Text                'MRO
                datos.fecha = row.Cells(3).Value        'FECHA_INTERNA
                datos.fecha2 = row.Cells(4).Value       'FECHA_CLIENTE
                datos.cel = row.Cells(5).Value          'OBSERVACIONES
                datos.ciudad = row.Cells(1).Value       'NÚMERO PROCESO
                datos.clave = row.Cells(6).Value        'ESTADO
                datos.total = row.Cells(7).Value        'ID_ESTACIÓN
                datos.colonia = row.Cells(9).Value      'HORAS

                conexion.insert_proceso_ot(datos)
            Next
        End If

        MessageBox.Show("Tareas actualizadas con éxito", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Public Sub obtiene_estaciones()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvEstacion.Rows.Clear()

        Dim id_proceso As Integer = 0

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso where clave = '" & cbProc.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_proceso = resultado.GetString("id_proceso")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'LLENAMOS DATAGRID
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from estacion where id_proceso = '" & id_proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvEstacion.Rows.Add(resultado.GetString("id_estacion"), resultado.GetString("nombre"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub cambio_estacion()
        Dim indice As Integer = dgvCambios.CurrentRow.Index.ToString
        indice_cambios = indice

        'VERIFICAMOS EL ESTADO DEL PROCESO
        If dgvCambios.Rows(indice).Cells(6).Value = "TERMINADO" Or dgvCambios.Rows(indice).Cells(6).Value = "EN CURSO" Then
            MessageBox.Show(" No se puede modificar el proceso si ya esta terminado o en curso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If
        obtiene_procesos()

        cbProc.Text = dgvCambios.Rows(indice).Cells(2).Value
        obtiene_estaciones()
        tbNumProc.Text = dgvCambios.Rows(indice).Cells(1).Value
        dtpF_Interna.Value = dgvCambios.Rows(indice).Cells(3).Value
        dtpFecha_Cliente.Value = dgvCambios.Rows(indice).Cells(4).Value
        tbObs.Text = dgvCambios.Rows(indice).Cells(5).Value
        tbHoras.Text = dgvCambios.Rows(indice).Cells(9).Value

        btnCambio.Visible = True
        btnAgrega.Visible = False
        cbProc.Enabled = False
        tbNumProc.Enabled = False
        dtpFecha_Cliente.Enabled = False
        dtpF_Interna.Enabled = False
        tbObs.Enabled = False
        tbHoras.Enabled = False

        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(0).Value = dgvCambios.Rows(indice).Cells(7).Value Then
                row.Cells(2).Value = True
            End If
        Next
    End Sub

    Public Sub cancela_edicion()
        'LIMPIAMOS LOS CAMPOS
        cbProc.Text = ""
        tbNumProc.Clear()
        dgvEstacion.Rows.Clear()
        tbObs.Clear()

        btnCambio.Visible = False
        btnAgrega.Visible = True
        cbProc.Enabled = True
        tbNumProc.Enabled = True
        dtpFecha_Cliente.Enabled = True
        dtpF_Interna.Enabled = True
        tbObs.Enabled = True
        tbHoras.Enabled = True
    End Sub

    Public Sub actualiza_estacion()
        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(2).Value = True Then
                dgvCambios.Rows(indice_cambios).Cells(7).Value = row.Cells(0).Value
                dgvCambios.Rows(indice_cambios).Cells(8).Value = row.Cells(1).Value
                Return
            End If
        Next
    End Sub

    Public Sub elimina_proceso()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim indice As Integer = dgvCambios.CurrentRow.Index.ToString()
        Dim numero_prc As String = dgvCambios.Rows(indice).Cells(1).Value
        Dim id_prc As String = dgvCambios.Rows(indice).Cells(0).Value
        Dim cont As Integer = 1
        Dim result As Integer = 0

        'CONDICIONES PARA ELIMINAR
        result = MessageBox.Show("¿Desea eliminar este proceso?", "Control DMM(C) 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.No Then
            Return
        End If

        If dgvCambios.Rows(indice).Cells(6).Value = "TERMINADO" Or dgvCambios.Rows(indice).Cells(6).Value = "EN CURSO" Then
            MessageBox.Show(" No se puede modificar el proceso si ya esta terminado o en curso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'ELIMINAMOS LA FILA
        dgvCambios.Rows.Remove(dgvCambios.CurrentRow)

        'ELIMINAMOS DE LA BASE
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" delete from proceso_ot where id_ot = '" & id_ot & "' and id_proceso = '" & id_prc & "' and num_proc = '" & numero_prc & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'REORDENAMOS LA TABLA y ACTUALIZAMOS LA BASE
        For Each row As DataGridViewRow In dgvCambios.Rows
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" update proceso_ot set num_proc = '" & cont & "' where id_ot = '" & id_ot & "' and id_proceso = '" & row.Cells(0).Value & "' and num_proc = '" & row.Cells(1).Value & "'  ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            row.Cells(1).Value = cont
            cont = cont + 1
        Next

    End Sub
#End Region

    Private Sub tFecha_Tick(sender As Object, e As EventArgs) Handles tFecha.Tick
        calcula_tiempo()
    End Sub

    Private Sub cbOT_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOT.SelectedIndexChanged
        orden_trabajo_seleccionado()
    End Sub

    Private Sub cbOT_Click(sender As Object, e As EventArgs) Handles cbOT.Click
        llena_orden_trabajo()
    End Sub

    Private Sub btnComen_Click(sender As Object, e As EventArgs) Handles btnComen.Click
        comienza_proceso()
        orden_trabajo_seleccionado()
    End Sub

    Private Sub btnEntrega_Click(sender As Object, e As EventArgs) Handles btnEntrega.Click
        termina_proceso()
        orden_trabajo_seleccionado()
    End Sub

    Private Sub dgvObserva_DoubleClick(sender As Object, e As EventArgs) Handles dgvObserva.DoubleClick
        proceso_seleccionado()
    End Sub

    Private Sub btnRegCom_Click(sender As Object, e As EventArgs) Handles btnRegCom.Click
        realizar_comentario()
    End Sub

    Private Sub btnAgrega_Click(sender As Object, e As EventArgs) Handles btnAgrega.Click
        agrega_nuevo_proceso()
    End Sub

    Private Sub cbProc_Click(sender As Object, e As EventArgs) Handles cbProc.Click
        obtiene_procesos()
    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        actualiza_proceso_ot()
        orden_trabajo_seleccionado()
    End Sub

    Private Sub cbProc_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbProc.SelectedIndexChanged
        obtiene_estaciones()
    End Sub

    Private Sub dgvEstacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstacion.CellContentClick
        Dim indice As Integer = dgvEstacion.CurrentRow.Index.ToString

        For Each row As DataGridViewRow In dgvEstacion.Rows
            row.Cells(2).Value = False
        Next

        dgvEstacion.Rows(indice).Cells(2).Value = True
    End Sub

    Private Sub CAMBIARESTACIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAMBIARESTACIÓNToolStripMenuItem.Click
        cambio_estacion()
    End Sub

    Private Sub CANCELAREDICIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANCELAREDICIÓNToolStripMenuItem.Click
        cancela_edicion()
    End Sub

    Private Sub btnCambio_Click(sender As Object, e As EventArgs) Handles btnCambio.Click
        actualiza_estacion()
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        elimina_proceso()
        orden_trabajo_seleccionado()
    End Sub
End Class