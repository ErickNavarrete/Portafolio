Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class class_delete_datos
    Private _adaptador As New MySqlDataAdapter

    Public Function delete_proceso(ByVal datoscc As class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            conexion_GlobalSI()
            _adaptador.InsertCommand = New MySqlCommand("update proceso set estado = @estado , id_usuario_m = @id_usuario, fecha_modificacion = @fecha where id_proceso = @id_proceso ", _conexionSI)
            _adaptador.InsertCommand.Parameters.Add("@id_usuario", MySqlDbType.Decimal).Value = datoscc.total
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.DateTime).Value = datoscc.fecha
            _adaptador.InsertCommand.Parameters.Add("@id_proceso", MySqlDbType.Decimal).Value = datoscc.total_abono
            _adaptador.InsertCommand.Parameters.Add("@estado", MySqlDbType.String).Value = "0"

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
