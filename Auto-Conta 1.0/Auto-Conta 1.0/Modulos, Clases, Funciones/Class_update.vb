Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Class_update

    Private _adaptador As New MySqlDataAdapter

    'Actualiza el catalogo contable
    Public Function actualizarcat(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update catalogo_contable set tipo = @tipo where numero_cuenta_unico = @numero_cuenta_unico", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@numero_cuenta_unico", MySqlDbType.String).Value = datos.numero_cuenta_unico
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

    'Actualiza el catalogo contable
    Public Function actualizarcuentaPadre(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update catalogo_contable set tipo = 'A' where id_cuenta = @id_cuenta", _conexion)
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

    'Actualiza la base config_auto_conta la tabla de usuarios
    Public Function actualizarUsuario(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update config_auto_conta.users set user_name = @user_name where id_user = @id_user", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@user_name", MySqlDbType.String).Value = datos.Usuario
            _adaptador.InsertCommand.Parameters.Add("@id_user", MySqlDbType.String).Value = datos.id_usuario
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

    'Actualiza la base config_auto_conta la tabla de usuarios (contraseña)
    Public Function actualizarUsuarioContra(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update config_auto_conta.users set pass = SHA(@pass) where id_user = @id_user", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@pass", MySqlDbType.String).Value = datos.contrasenia
            _adaptador.InsertCommand.Parameters.Add("@id_user", MySqlDbType.String).Value = datos.id_usuario
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

    Public Function update_cancel_polizas_factura(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update polizas set estado = 'cancelado' where id_factura = @id_factura ", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.String).Value = datos.id_factura
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

    Public Function update_cancel_factura(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update factura set estatus = 'cancelado' where id_timbrados = @id_factura ", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.String).Value = datos.id_factura
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

    Public Function update_delete_polizas(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("update polizas set estado = 'eliminado' where id_poliza = @id_poliza ", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_poliza", MySqlDbType.String).Value = datos.id_poliza
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
