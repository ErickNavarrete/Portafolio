Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Class_delete

    Private _adaptador As New MySqlDataAdapter

    'Elimina de la tabla Catalogo Contable
    Public Function borrarcuenta(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("delete from catalogo_contable where id_cuenta = @id_cuenta", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_cuenta", MySqlDbType.String).Value = datos.id_cuenta_padre
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    'Elimina de la base config_auto_conta de la tabla de usuarios
    Public Function borrarusuario(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("delete from config_auto_conta.users where id_user = @user_name", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@user_name", MySqlDbType.Int64).Value = datos.id_usuario
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    'Elimina de la base config_auto_conta de la tabla de usuarios_base
    Public Function borrarusuariobases(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("delete from config_contabilidad.user_bases where id_user = @id_user", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_user", MySqlDbType.Int64).Value = datos.id_usuario
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    'Elimina de la tabla bases la empresa
    Public Function eliminaEmpresas(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("delete from bases where id_base = @id_base", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_base", MySqlDbType.String).Value = datos.id_base
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    'Elimina configuración rfc
    Public Function delete_rfc_config(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("delete from rfc_config where id_rfc = @id_rfc", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_rfc", MySqlDbType.String).Value = datos.id_cuenta
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    'Elimina configuración impuestos
    Public Function delete_impuesto_config(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("delete from impuesto_config where id_impuesto = @id_impuesto", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_impuesto", MySqlDbType.String).Value = datos.id_cuenta
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
            '  MsgBox("inserto datos emi")
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

End Class
