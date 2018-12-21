Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_insert_datos

    Private _adaptador As New MySqlDataAdapter

    Public Function insert_proceso(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("insert into proceso (clave, descripcion, id_usuario_c, estado) values (@clave, @descripcion, @id_usuario_c, @estado)", _conexionSI)
            _adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datoscc.unidadr
            _adaptador.InsertCommand.Parameters.Add("@descripcion", MySqlDbType.String).Value = datoscc.uuid
            _adaptador.InsertCommand.Parameters.Add("@id_usuario_c", MySqlDbType.Decimal).Value = datoscc.total
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.Decimal).Value = "1"

            _conexionSI.Open()
            _adaptador.InsertCommand.Connection = _conexionSI
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrarSI()
        End Try
        Return estado
    End Function

    Public Function insert_orden_trabajo(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("insert into orden_trabajo (cliente,proyecto,usuario,serie,folio,numero_cotizacion,fecha_elab,fecha_entrega,id_usuario_c,usuario_c,orden_compra,notas,inf_cnc) 
                                                                            values (@cliente,@proyecto,@usuario,@serie,@folio,@numero,@fecha1,@fecha2,@usuario2,@usuario_c,@orden_compra,@notas,@inf_cnc)", _conexionSI)
            _adaptador.InsertCommand.Parameters.Add("@cliente", MySqlDbType.String).Value = datoscc.unidadr
            _adaptador.InsertCommand.Parameters.Add("@proyecto", MySqlDbType.String).Value = datoscc.uuid
            _adaptador.InsertCommand.Parameters.Add("@usuario", MySqlDbType.String).Value = datoscc.calle
            _adaptador.InsertCommand.Parameters.Add("@serie", MySqlDbType.String).Value = datoscc.cel
            _adaptador.InsertCommand.Parameters.Add("@folio", MySqlDbType.String).Value = datoscc.ciudad
            _adaptador.InsertCommand.Parameters.Add("@numero", MySqlDbType.String).Value = datoscc.clave
            _adaptador.InsertCommand.Parameters.Add("@usuario_c", MySqlDbType.String).Value = datoscc.nombre
            _adaptador.InsertCommand.Parameters.Add("@orden_compra", MySqlDbType.String).Value = datoscc.colonia
            _adaptador.InsertCommand.Parameters.Add("@notas", MySqlDbType.String).Value = datoscc.contrato
            _adaptador.InsertCommand.Parameters.Add("@inf_cnc", MySqlDbType.String).Value = datoscc.correo

            _adaptador.InsertCommand.Parameters.Add("@fecha1", MySqlDbType.Date).Value = datoscc.fecha
            _adaptador.InsertCommand.Parameters.Add("@fecha2", MySqlDbType.Date).Value = datoscc.fecha2

            _adaptador.InsertCommand.Parameters.Add("@usuario2", MySqlDbType.Decimal).Value = datoscc.id

            _conexionSI.Open()
            _adaptador.InsertCommand.Connection = _conexionSI
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrarSI()
        End Try
        Return estado
    End Function

    Public Function insert_proceso_ot(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("insert into proceso_ot (id_ot, id_proceso, mro, fecha_interna, fecha_cliente, observaciones, num_proc, estado, id_estacion, horas) 
                                                                         values (@id_ot, @id_proceso, @mro, @fecha1, @fecha2, @observa, @num_proc, @estado, @id_estacion, @horas)", _conexionSI)

            _adaptador.InsertCommand.Parameters.Add("@id_ot", MySqlDbType.Int64).Value = datoscc.id
            _adaptador.InsertCommand.Parameters.Add("@id_proceso", MySqlDbType.Int64).Value = datoscc.id_polizas
            _adaptador.InsertCommand.Parameters.Add("@mro", MySqlDbType.String).Value = datoscc.calle
            _adaptador.InsertCommand.Parameters.Add("@fecha1", MySqlDbType.DateTime).Value = datoscc.fecha
            _adaptador.InsertCommand.Parameters.Add("@fecha2", MySqlDbType.DateTime).Value = datoscc.fecha2
            _adaptador.InsertCommand.Parameters.Add("@observa", MySqlDbType.String).Value = datoscc.cel
            _adaptador.InsertCommand.Parameters.Add("@num_proc", MySqlDbType.String).Value = datoscc.ciudad
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.String).Value = datoscc.clave
            _adaptador.InsertCommand.Parameters.Add("@id_estacion", MySqlDbType.Int64).Value = datoscc.total
            _adaptador.InsertCommand.Parameters.Add("@horas", MySqlDbType.String).Value = datoscc.colonia

            _conexionSI.Open()
            _adaptador.InsertCommand.Connection = _conexionSI
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrarSI()
        End Try
        Return estado
    End Function

    Public Function insert_historial(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("insert into historial (id_detalle, id_proceso, id_usuario, estado, fecha) 
                                                                         values (@id_ot, @id_proceso, @id_usuario, @estado, @fecha1)", _conexionSI)

            _adaptador.InsertCommand.Parameters.Add("@id_ot", MySqlDbType.Int64).Value = datoscc.id
            _adaptador.InsertCommand.Parameters.Add("@id_proceso", MySqlDbType.Int64).Value = datoscc.id_polizas
            _adaptador.InsertCommand.Parameters.Add("@id_usuario", MySqlDbType.Int64).Value = datoscc.N_poliza
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.String).Value = datoscc.estado
            _adaptador.InsertCommand.Parameters.Add("@fecha1", MySqlDbType.DateTime).Value = datoscc.fecha

            _conexionSI.Open()
            _adaptador.InsertCommand.Connection = _conexionSI
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrarSI()
        End Try
        Return estado
    End Function

    Public Function insert_proceso_ot2(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("insert into proceso_ot (id_detalle, id_proceso, id_estacion, fecha_interna, observaciones, num_proc, estado, tiempo) 
                                                                         values (@id_detalle, @id_proceso, @id_estacion, @fecha1, @observa, @num_proc, @estado, @tiempo)", _conexionSI)

            _adaptador.InsertCommand.Parameters.Add("@id_detalle", MySqlDbType.Int64).Value = datoscc.id
            _adaptador.InsertCommand.Parameters.Add("@id_proceso", MySqlDbType.Int64).Value = datoscc.id_polizas
            _adaptador.InsertCommand.Parameters.Add("@id_estacion", MySqlDbType.Int64).Value = datoscc.total
            _adaptador.InsertCommand.Parameters.Add("@fecha1", MySqlDbType.DateTime).Value = datoscc.fecha
            _adaptador.InsertCommand.Parameters.Add("@observa", MySqlDbType.String).Value = datoscc.cel
            _adaptador.InsertCommand.Parameters.Add("@num_proc", MySqlDbType.String).Value = datoscc.ciudad
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.String).Value = datoscc.clave
            _adaptador.InsertCommand.Parameters.Add("@tiempo", MySqlDbType.String).Value = datoscc.colonia

            _conexionSI.Open()
            _adaptador.InsertCommand.Connection = _conexionSI
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrarSI()
        End Try
        Return estado
    End Function
End Class
