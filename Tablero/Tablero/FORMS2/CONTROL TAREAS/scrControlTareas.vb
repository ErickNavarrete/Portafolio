Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Imports System.IO
Imports System.Xml

Public Class scrControlTareas
#Region "VARIABLES GLOBALES"
    Dim id_usuario As Integer = 0
    Dim id_detalle As Integer = 0
    Dim id_ot As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Sub get_event(ByVal dato As String)
        Dim aux() As String
        Dim origen As String = ""
        aux = dato.Split(".")

        If dato.Substring(0, 4) = "000." Then
            'OBTENEMOS ID DEL USUARIO
            id_usuario = aux(1)
            origen = "usuario"
        Else
            'OBTENEMOS ID DEL DETALLE
            id_detalle = aux(2)
            id_ot = aux(0)
            origen = "detalle"
        End If

        set_tarea(origen)
    End Sub

    Public Sub set_tarea(ByVal origen As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_insert_datos
        Dim conexion2 As New class_update_datos

        Dim estado As String = ""
        Dim id_proceso As Integer = 0
        Dim id_estacion As Integer = 0
        Dim num_proceso As String = ""
        Dim bandera_t As Boolean = True
        Dim bandera_a As Boolean = False

        Select Case origen
            Case "usuario"

            Case "detalle"
                'CONSULTAMOS EN QUE MOMENTO VA NUESTRO DETALLE
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_detalle & "' and estado = 'EN CURSO' order by num_proc ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_proceso = resultado.GetInt64("id_proceso")
                        id_estacion = resultado.GetInt64("id_estacion")
                        estado = resultado.GetString("estado")
                        num_proceso = resultado.GetString("num_proc")
                        bandera_a = True
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()

                If bandera_a = False Then
                    Try
                        conexion_GlobalSI()
                        _conexionSI.Open()
                        comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_detalle & "' and estado <> 'EN CURSO' and estado <> 'TERMINADO' order by num_proc ", _conexionSI)
                        resultado = comandoSql.ExecuteReader
                        While resultado.Read
                            id_proceso = resultado.GetInt64("id_proceso")
                            id_estacion = resultado.GetInt64("id_estacion")
                            estado = resultado.GetString("estado")
                            num_proceso = resultado.GetString("num_proc")
                            Exit While
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrarSI()
                    End Try
                    _conexionSI.Close()
                End If


                Select Case estado
                    Case "EN CURSO"
                        'ACTUALIZAMOS ESTADO DEL HISTORIAL
                        datos.id = id_detalle               'ID ORDEN DE TRABAJO    
                        datos.id_polizas = id_proceso       'ID PROCESO
                        datos.fecha = DateTime.Now          'FECHA
                        datos.estado = "COMPLETADO"         'TERMINADO

                        conexion2.update_historial(datos)

                        'ACTUALIZA PORCESO_OT
                        Try
                            conexion_GlobalSI()
                            _conexionSI.Open()
                            comandoSql = New MySqlCommand(" update proceso_ot set estado = 'TERMINADO' where id_detalle = '" & id_detalle & "' and id_proceso = '" & id_proceso & "' and num_proc = '" & num_proceso & "' ", _conexionSI)
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
                            comandoSql = New MySqlCommand(" update estacion set estado = 'LIBRE' where id_estacion = '" & id_estacion & "' ", _conexionSI)
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
                            comandoSql = New MySqlCommand(" select * from proceso_ot where id_detalle = '" & id_detalle & "' ", _conexionSI)
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
                    Case Else
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

                        datos.id = id_detalle               'ID DETALLE    
                        datos.id_polizas = id_proceso       'ID PROCESO
                        datos.N_poliza = id_usuario         'ID USUSARIO
                        datos.fecha = DateTime.Now          'FECHA
                        datos.estado = "EN CURSO"           'ESTADO

                        conexion.insert_historial(datos)

                        'ACTUALIZA PORCESO_OT
                        Try
                            conexion_GlobalSI()
                            _conexionSI.Open()
                            comandoSql = New MySqlCommand(" update proceso_ot set estado = 'EN CURSO' where id_detalle = '" & id_detalle & "' and id_proceso = '" & id_proceso & "' and num_proc = '" & num_proceso & "' ", _conexionSI)
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
                End Select
        End Select

        tbControl.Text = ""
        bandera_t = True
    End Sub
#End Region

    Private Sub tbControl_KeyDown(sender As Object, e As KeyEventArgs) Handles tbControl.KeyDown
        Select Case e.KeyData
            Case Keys.Enter
                get_event(tbControl.Text)
        End Select
    End Sub
End Class