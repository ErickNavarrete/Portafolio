Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_update_datos
    Private _adaptador As New MySqlDataAdapter

    Public Function update_proceso(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("update proceso set clave = @clave , descripcion = @descripcion, id_usuario_m = @id_usuario, fecha_modificacion = @fecha where id_proceso = @id_proceso ", _conexionSI)
            _adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datoscc.unidadr
            _adaptador.InsertCommand.Parameters.Add("@descripcion", MySqlDbType.String).Value = datoscc.uuid
            _adaptador.InsertCommand.Parameters.Add("@id_usuario", MySqlDbType.Decimal).Value = datoscc.total
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = datoscc.fecha
            _adaptador.InsertCommand.Parameters.Add("@id_proceso", MySqlDbType.Decimal).Value = datoscc.total_abono

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

    Public Function update_historial(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("update historial set fecha_t = @fecha, estado = @estado where id_detalle = @id_ot and id_proceso = @id_proceso and estado = 'EN CURSO' ", _conexionSI)
            _adaptador.InsertCommand.Parameters.Add("@id_ot", MySqlDbType.Int64).Value = datoscc.id
            _adaptador.InsertCommand.Parameters.Add("@id_proceso", MySqlDbType.Int64).Value = datoscc.id_polizas
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.String).Value = datoscc.estado
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = datoscc.fecha

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

    Public Function update_orden_trabajo(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("update orden_trabajo set cliente = @cliente, proyecto = @proyecto ,usuario = @usuario,fecha_elab = @fecha1 ,fecha_entrega = @fecha2, orden_compra = @orden_compra, notas = @notas, inf_cnc = @inf_cnc where id_ot = @id_ot", _conexionSI)
            _adaptador.InsertCommand.Parameters.Add("@id_ot", MySqlDbType.Int64).Value = datoscc.id
            _adaptador.InsertCommand.Parameters.Add("@cliente", MySqlDbType.String).Value = datoscc.unidadr
            _adaptador.InsertCommand.Parameters.Add("@proyecto", MySqlDbType.String).Value = datoscc.uuid
            _adaptador.InsertCommand.Parameters.Add("@usuario", MySqlDbType.String).Value = datoscc.calle
            _adaptador.InsertCommand.Parameters.Add("@orden_compra", MySqlDbType.String).Value = datoscc.colonia
            _adaptador.InsertCommand.Parameters.Add("@notas", MySqlDbType.String).Value = datoscc.contrato
            _adaptador.InsertCommand.Parameters.Add("@inf_cnc", MySqlDbType.String).Value = datoscc.correo

            _adaptador.InsertCommand.Parameters.Add("@fecha1", MySqlDbType.Date).Value = datoscc.fecha
            _adaptador.InsertCommand.Parameters.Add("@fecha2", MySqlDbType.Date).Value = datoscc.fecha2

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
End Class
