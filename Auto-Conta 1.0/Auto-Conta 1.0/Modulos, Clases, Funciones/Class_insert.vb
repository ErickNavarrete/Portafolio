Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class Class_insert

    Private _adaptador As New MySqlDataAdapter

    'Inserta en la tabla de catalogo_contable
    Public Function insertarcatalogo(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into catalogo_contable (id_cuenta_padre, numero_cuenta_unico, numero_cuenta, nombre_cuenta, tipo, naturaleza, cuenta_sat, usuario_creador) values (@id_cuenta_padre, @numero_cuenta_unico, @numero_cuenta, @nombre_cuenta, @tipo, @naturaleza, @cuenta_sat, @usuario_creador)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_cuenta_padre", MySqlDbType.Int64).Value = datos.id_cuenta_padre
            _adaptador.InsertCommand.Parameters.Add("@numero_cuenta_unico", MySqlDbType.String).Value = datos.numero_cuenta_unico
            _adaptador.InsertCommand.Parameters.Add("@numero_cuenta", MySqlDbType.String).Value = datos.numero_cuenta
            _adaptador.InsertCommand.Parameters.Add("@nombre_cuenta", MySqlDbType.String).Value = datos.nombre_cuenta
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@naturaleza", MySqlDbType.String).Value = datos.naturaleza
            _adaptador.InsertCommand.Parameters.Add("@cuenta_sat", MySqlDbType.String).Value = datos.cuenta_sat
            _adaptador.InsertCommand.Parameters.Add("@usuario_creador", MySqlDbType.String).Value = datos.id_usuario
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

    Public Function inserta_Base(ByVal datos As Class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "emitidos"
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into config_auto_conta.bases(base, nombre_emp, rfc_emp, regimen_emp) values (@base, @nombre_emp, @rfc_emp, @regimen_emp)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@base", MySqlDbType.String).Value = datos.base
            _adaptador.InsertCommand.Parameters.Add("@nombre_emp", MySqlDbType.String).Value = datos.nombre_emp
            _adaptador.InsertCommand.Parameters.Add("@rfc_emp", MySqlDbType.String).Value = datos.rfc_emp
            _adaptador.InsertCommand.Parameters.Add("@regimen_emp", MySqlDbType.String).Value = datos.regimen_emp
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

    'Inserta en la tabla de Users
    Public Function insertarUsuario(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into config_auto_conta.users (user_name, pass) values (@user_name, SHA(@pass))", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@user_name", MySqlDbType.String).Value = datos.user
            _adaptador.InsertCommand.Parameters.Add("@pass", MySqlDbType.String).Value = datos.pass
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

    'Inserta en la base config_auto_conta en la tabla user_bases
    Public Function insertaruser_Base(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into config_auto_conta.user_bases(id_user, id_base) values (@id_user, @id_base)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_user", MySqlDbType.String).Value = datos.id_usuario
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

    Public Function insertarrfc(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into rfc_config(rfc ,nombre, tipo, id_cuenta_cargo, id_cuenta_abono, usuario_creador, id_cuentaB) values (@rfc, @nombre, @tipo, @id_cuenta_cargo, @id_cuenta_abono, @usuario_creador, @id_cuentaB)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@rfc", MySqlDbType.String).Value = datos.rfc_emp
            _adaptador.InsertCommand.Parameters.Add("@nombre", MySqlDbType.String).Value = datos.nombre_emp
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@id_cuenta_cargo", MySqlDbType.Int64).Value = datos.id_cargo
            _adaptador.InsertCommand.Parameters.Add("@id_cuenta_abono", MySqlDbType.Int64).Value = datos.id_abono
            _adaptador.InsertCommand.Parameters.Add("@usuario_creador", MySqlDbType.String).Value = datos.Usuario
            _adaptador.InsertCommand.Parameters.Add("@id_cuentaB", MySqlDbType.Int64).Value = datos.id_cuenta
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado

    End Function

    Public Function insertarbanco(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into bancos(banco) values (@banco)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@banco", MySqlDbType.String).Value = datos.banco
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

    Public Function insertarcuentaB(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into cuentas_bancos(id_banco, cuenta, ccontable) values (@id_banco, @cuenta, @ccontable)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_banco", MySqlDbType.Int64).Value = datos.id_banco
            _adaptador.InsertCommand.Parameters.Add("@cuenta", MySqlDbType.String).Value = datos.Cuentab
            _adaptador.InsertCommand.Parameters.Add("@ccontable", MySqlDbType.Int64).Value = datos.id_cuenta_padre
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

    Public Function insertartransferencia(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into transferenciabancos(id_bancoE, id_bancoR, fecha, cantidad, usuariocreador, notas) values (@id_bancoE, @id_bancoR, @fecha, @cantidad, @usuariocreador, @notas)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_bancoE", MySqlDbType.Int64).Value = datos.id_cuentaemi
            _adaptador.InsertCommand.Parameters.Add("@id_bancor", MySqlDbType.Int64).Value = datos.id_cuentarec
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.String).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@cantidad", MySqlDbType.Decimal).Value = datos.total
            _adaptador.InsertCommand.Parameters.Add("@usuariocreador", MySqlDbType.String).Value = datos.user
            _adaptador.InsertCommand.Parameters.Add("@notas", MySqlDbType.String).Value = datos.notas
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

    Public Function insertarmovbancos(ByVal datos As Class_datos) As Boolean

        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into movimientos_bancos (id_cuentab, deposito, retiro, fecha, usuariocreador) values (@id_cuentab, @deposito, @retiro, @fecha, @usuariocreador)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_cuentab", MySqlDbType.Int64).Value = datos.id_banco
            _adaptador.InsertCommand.Parameters.Add("@deposito", MySqlDbType.Decimal).Value = datos.deposito
            _adaptador.InsertCommand.Parameters.Add("@retiro", MySqlDbType.Decimal).Value = datos.retiro
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.String).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@usuariocreador", MySqlDbType.String).Value = datos.user
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

    Public Function insert_factura(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand(" insert into factura(serie_t,folio_t,fecha_t ,rfc_r,nombre_r,rfc_e,nombre_e,tipo_cambio,moneda,uso_cfdi,sub_t,total_t,descuento_g,uuid,cert,certsat,fechacert,cfdi,sellosat,cadena,estatus,condicion,forma,decimales,tipo,version) values
                                                        (@serie_t,@folio_t,@fecha_t ,@rfc_r,@nombre_r,@rfc_e,@nombre_e,@tipo_cambio,@moneda,@uso_cfdi,@sub_t,@total_t,@descuento_g,@uuid,@cert,@certsat,@fechacert,@cfdi,@sellosat,@cadena,@estatus,@condicion,@forma,@decimales,@tipo,@version)")

            _adaptador.InsertCommand.Parameters.Add("@serie_t", MySqlDbType.String).Value = datos.serie_t
            _adaptador.InsertCommand.Parameters.Add("@folio_t", MySqlDbType.String).Value = datos.folio_t
            _adaptador.InsertCommand.Parameters.Add("@fecha_t", MySqlDbType.String).Value = datos.fecha
            _adaptador.InsertCommand.Parameters.Add("@rfc_r", MySqlDbType.String).Value = datos.rfc_r
            _adaptador.InsertCommand.Parameters.Add("@nombre_r", MySqlDbType.String).Value = datos.nombre_r
            _adaptador.InsertCommand.Parameters.Add("@rfc_e", MySqlDbType.String).Value = datos.rfc_e
            _adaptador.InsertCommand.Parameters.Add("@nombre_e", MySqlDbType.String).Value = datos.nombre_e
            _adaptador.InsertCommand.Parameters.Add("@tipo_cambio", MySqlDbType.Decimal).Value = datos.tipo_cambio
            _adaptador.InsertCommand.Parameters.Add("@moneda", MySqlDbType.String).Value = datos.moneda
            _adaptador.InsertCommand.Parameters.Add("@uso_cfdi", MySqlDbType.String).Value = datos.uso_cfdi
            _adaptador.InsertCommand.Parameters.Add("@sub_t", MySqlDbType.Decimal).Value = datos.sub_t
            _adaptador.InsertCommand.Parameters.Add("@total_t", MySqlDbType.Decimal).Value = datos.total_t
            _adaptador.InsertCommand.Parameters.Add("@descuento_g", MySqlDbType.Decimal).Value = datos.descuento_g
            _adaptador.InsertCommand.Parameters.Add("@uuid", MySqlDbType.String).Value = datos.uuid
            _adaptador.InsertCommand.Parameters.Add("@cert", MySqlDbType.String).Value = datos.cert
            _adaptador.InsertCommand.Parameters.Add("@certsat", MySqlDbType.String).Value = datos.certsat
            _adaptador.InsertCommand.Parameters.Add("@fechacert", MySqlDbType.String).Value = datos.fechacert
            _adaptador.InsertCommand.Parameters.Add("@cfdi", MySqlDbType.String).Value = datos.cfdi
            _adaptador.InsertCommand.Parameters.Add("@sellosat", MySqlDbType.String).Value = datos.sellosat
            _adaptador.InsertCommand.Parameters.Add("@cadena", MySqlDbType.String).Value = datos.cadena
            _adaptador.InsertCommand.Parameters.Add("@estatus", MySqlDbType.String).Value = datos.estatus
            _adaptador.InsertCommand.Parameters.Add("@condicion", MySqlDbType.String).Value = datos.condicion
            _adaptador.InsertCommand.Parameters.Add("@forma", MySqlDbType.String).Value = datos.forma
            _adaptador.InsertCommand.Parameters.Add("@decimales", MySqlDbType.Decimal).Value = datos.decimales
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@version", MySqlDbType.String).Value = datos.version

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insertaPolizas(ByVal datos As Class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "polizas"
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into polizas (tipo_poliza, numero_poliza, fecha, descripcion, total, mes, anio, usuariocreador, usuariomodificador, origen, id_factura) values (@tipo_poliza, @numero_poliza, @fecha, @descripcion, @total, @mes, @anio, @usuariocreador, @usuariomodificador, @origen, @id_factura)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@tipo_poliza", MySqlDbType.String).Value = datos.tipo_poliza
            _adaptador.InsertCommand.Parameters.Add("@numero_poliza", MySqlDbType.Int64).Value = datos.numero_poliza
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.String).Value = datos.fechat
            _adaptador.InsertCommand.Parameters.Add("@descripcion", MySqlDbType.String).Value = datos.descripcion
            _adaptador.InsertCommand.Parameters.Add("@total", MySqlDbType.Decimal).Value = datos.total
            _adaptador.InsertCommand.Parameters.Add("@mes", MySqlDbType.String).Value = datos.mes
            _adaptador.InsertCommand.Parameters.Add("@anio", MySqlDbType.String).Value = datos.anio
            _adaptador.InsertCommand.Parameters.Add("@usuariocreador", MySqlDbType.String).Value = datos.user
            _adaptador.InsertCommand.Parameters.Add("@usuariomodificador", MySqlDbType.String).Value = datos.usuariomodificador
            _adaptador.InsertCommand.Parameters.Add("@origen", MySqlDbType.String).Value = datos.origen
            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
        End Try
        Return estado
    End Function

    Public Function insertaPolDet(ByVal datos As Class_datos) As Boolean
        'Esta función inserta los datos en la tabla MySql "polizas_det"
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into polizas_det (id_poliza, fecha, id_cuenta, cargo, abono, desc_asiento) values (@id_poliza, @fecha, @id_cuenta, @cargo, @abono, @desc_asiento)", _conexion)
            _adaptador.InsertCommand.Parameters.Add("@id_poliza", MySqlDbType.String).Value = datos.id_poliza
            _adaptador.InsertCommand.Parameters.Add("@fecha", MySqlDbType.String).Value = datos.fechat
            _adaptador.InsertCommand.Parameters.Add("@id_cuenta", MySqlDbType.String).Value = datos.id_cuenta
            _adaptador.InsertCommand.Parameters.Add("@cargo", MySqlDbType.String).Value = datos.cargo
            _adaptador.InsertCommand.Parameters.Add("@abono", MySqlDbType.String).Value = datos.abono
            _adaptador.InsertCommand.Parameters.Add("@desc_asiento", MySqlDbType.String).Value = datos.desc_asiento
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

    Public Function insert_articulos(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand(" insert into articulos (clave,clave_sat,descripcion,u_med_sat,descripcion_sat) 
                                                          values (@clave,@clave_sat,@descripcion,@u_med_sat,@descripcion_sat);")

            _adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@clave_sat", MySqlDbType.String).Value = datos.clave_sat
            _adaptador.InsertCommand.Parameters.Add("@descripcion", MySqlDbType.String).Value = datos.descripcion
            _adaptador.InsertCommand.Parameters.Add("@u_med_sat", MySqlDbType.String).Value = datos.u_med_sat
            _adaptador.InsertCommand.Parameters.Add("@descripcion_sat", MySqlDbType.String).Value = datos.descripcion_sat

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_factura_det(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand(" insert into factura_det  (id_factura,id_art,cantidad,importe_unit,precio_unit,importe_tot,precio_tot,iva,impuesto_iva,tasa_iva,tipo_iva,ieps,impuesto_ieps,tipo_ieps,tasa_ieps,isr,impuesto_isr,tipo_isr,tasa_isr,iva_ret,impuesto_iva_ret,tipo_iva_ret,tasa_iva_ret,descuento,importe_ieps) values 
                                                                                   (@id_factura,@id_art,@cantidad,@importe_unit,@precio_unit,@importe_tot,@precio_tot,@iva,@impuesto_iva,@tasa_iva,@tipo_iva,@ieps,@impuesto_ieps,@tipo_ieps,@tasa_ieps,@isr,@impuesto_isr,@tipo_isr,@tasa_isr,@iva_ret,@impuesto_iva_ret,@tipo_iva_ret,@tasa_iva_ret,@descuento,@importe_ieps); ")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@id_art", MySqlDbType.Decimal).Value = datos.id_art
            _adaptador.InsertCommand.Parameters.Add("@cantidad", MySqlDbType.Decimal).Value = datos.cantidad
            _adaptador.InsertCommand.Parameters.Add("@importe_unit", MySqlDbType.Decimal).Value = datos.importe_unit
            _adaptador.InsertCommand.Parameters.Add("@precio_unit", MySqlDbType.Decimal).Value = datos.precio_unit
            _adaptador.InsertCommand.Parameters.Add("@importe_tot", MySqlDbType.Decimal).Value = datos.importe_tot
            _adaptador.InsertCommand.Parameters.Add("@precio_tot", MySqlDbType.Decimal).Value = datos.precio_tot
            _adaptador.InsertCommand.Parameters.Add("@iva", MySqlDbType.String).Value = datos.iva
            _adaptador.InsertCommand.Parameters.Add("@impuesto_iva", MySqlDbType.String).Value = datos.impuesto_iva
            _adaptador.InsertCommand.Parameters.Add("@tasa_iva", MySqlDbType.String).Value = datos.tasa_iva
            _adaptador.InsertCommand.Parameters.Add("@tipo_iva", MySqlDbType.String).Value = datos.tipo_iva
            _adaptador.InsertCommand.Parameters.Add("@ieps", MySqlDbType.String).Value = datos.ieps
            _adaptador.InsertCommand.Parameters.Add("@impuesto_ieps", MySqlDbType.String).Value = datos.impuesto_ieps
            _adaptador.InsertCommand.Parameters.Add("@tipo_ieps", MySqlDbType.String).Value = datos.tipo_ieps
            _adaptador.InsertCommand.Parameters.Add("@tasa_ieps", MySqlDbType.String).Value = datos.tasa_ieps
            _adaptador.InsertCommand.Parameters.Add("@isr", MySqlDbType.String).Value = datos.isr
            _adaptador.InsertCommand.Parameters.Add("@impuesto_isr", MySqlDbType.String).Value = datos.impuesto_isr
            _adaptador.InsertCommand.Parameters.Add("@tipo_isr", MySqlDbType.String).Value = datos.tipo_isr
            _adaptador.InsertCommand.Parameters.Add("@tasa_isr", MySqlDbType.String).Value = datos.tasa_isr
            _adaptador.InsertCommand.Parameters.Add("@iva_ret", MySqlDbType.String).Value = datos.iva_ret
            _adaptador.InsertCommand.Parameters.Add("@impuesto_iva_ret", MySqlDbType.String).Value = datos.impuesto_iva_ret
            _adaptador.InsertCommand.Parameters.Add("@tipo_iva_ret", MySqlDbType.String).Value = datos.tipo_iva_ret
            _adaptador.InsertCommand.Parameters.Add("@tasa_iva_ret", MySqlDbType.String).Value = datos.tasa_iva_ret
            _adaptador.InsertCommand.Parameters.Add("@descuento", MySqlDbType.Decimal).Value = datos.descuento
            _adaptador.InsertCommand.Parameters.Add("@importe_ieps", MySqlDbType.Decimal).Value = datos.importe_ieps


            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_tabla_impuestos(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand(" insert into factura_impuestos (id_factura,impuesto,tipo,calculo,tasa,total,importe,tabla) 
                                                                                  values (@id_factura,@impuesto,@tipo,@calculo,@tasa,@total,@importe,@tabla); ")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@impuesto", MySqlDbType.String).Value = datos.impuesto
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@calculo", MySqlDbType.String).Value = datos.calculo
            _adaptador.InsertCommand.Parameters.Add("@tasa", MySqlDbType.String).Value = datos.tasa
            _adaptador.InsertCommand.Parameters.Add("@total", MySqlDbType.Decimal).Value = datos.total
            _adaptador.InsertCommand.Parameters.Add("@importe", MySqlDbType.Decimal).Value = datos.importe
            _adaptador.InsertCommand.Parameters.Add("@tabla", MySqlDbType.String).Value = datos.tabla

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_tabla_nomina(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into factura_nomina(id_factura,fecha_pago,fecha_inicial_pago,fecha_final_pago,num_dias_pagados,total_percepciones,total_deducciones,total_otros_pagos,e_curp,e_registro_patronal,e_rfc_patron_origen,r_curp,r_num_seguridad_social,r_fecha_i_laborar,r_antiguedad,r_tipo_contrato,r_sindicalizado,r_tipo_jornada,r_tipo_regimen,r_num_empleado,r_departamento,r_puesto,r_riesgo,r_periodicidad,r_banco,r_cuenta_bancaria,r_salario_base,r_salario_diario,r_clave_ent_f) 
values(@id_factura,@fecha_pago,@fecha_inicial_pago,@fecha_final_pago,@num_dias_pagados,@total_percepciones,@total_deducciones,@total_otros_pagos,@e_curp,@e_registro_patronal,@e_rfc_patron_origen,@r_curp,@r_num_seguridad_social,@r_fecha_i_laborar,
@r_antiguedad,@r_tipo_contrato,@r_sindicalizado,@r_tipo_jornada,@r_tipo_regimen,@r_num_empleado,@r_departamento,@r_puesto,@r_riesgo,@r_periodicidad,@r_banco,@r_cuenta_bancaria,@r_salario_base,@r_salario_diario,@r_clave_ent_f);")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@fecha_pago", MySqlDbType.Date).Value = datos.fecha_pago
            _adaptador.InsertCommand.Parameters.Add("@fecha_inicial_pago", MySqlDbType.Date).Value = datos.fecha_inicial_p
            _adaptador.InsertCommand.Parameters.Add("@fecha_final_pago", MySqlDbType.Date).Value = datos.fecha_final_p
            _adaptador.InsertCommand.Parameters.Add("@num_dias_pagados", MySqlDbType.String).Value = datos.num_dias_pagados
            _adaptador.InsertCommand.Parameters.Add("@total_percepciones", MySqlDbType.Decimal).Value = datos.total_percepciones
            _adaptador.InsertCommand.Parameters.Add("@total_deducciones", MySqlDbType.Decimal).Value = datos.total_deducciones
            _adaptador.InsertCommand.Parameters.Add("@total_otros_pagos", MySqlDbType.Decimal).Value = datos.total_otros_pagos
            _adaptador.InsertCommand.Parameters.Add("@e_curp", MySqlDbType.String).Value = datos.e_curp
            _adaptador.InsertCommand.Parameters.Add("@e_registro_patronal", MySqlDbType.String).Value = datos.e_registro_patronal
            _adaptador.InsertCommand.Parameters.Add("@e_rfc_patron_origen", MySqlDbType.String).Value = datos.e_rfc_patron_origen
            _adaptador.InsertCommand.Parameters.Add("@r_curp", MySqlDbType.String).Value = datos.r_curp
            _adaptador.InsertCommand.Parameters.Add("@r_num_seguridad_social", MySqlDbType.String).Value = datos.r_num_seguridad_social
            _adaptador.InsertCommand.Parameters.Add("@r_fecha_i_laborar", MySqlDbType.Date).Value = datos.r_fecha_i_laborar
            _adaptador.InsertCommand.Parameters.Add("@r_antiguedad", MySqlDbType.String).Value = datos.r_antiguedad
            _adaptador.InsertCommand.Parameters.Add("@r_tipo_contrato", MySqlDbType.String).Value = datos.r_tipo_contrato
            _adaptador.InsertCommand.Parameters.Add("@r_sindicalizado", MySqlDbType.String).Value = datos.r_sindicalizado
            _adaptador.InsertCommand.Parameters.Add("@r_tipo_jornada", MySqlDbType.String).Value = datos.r_tipo_jornada
            _adaptador.InsertCommand.Parameters.Add("@r_tipo_regimen", MySqlDbType.String).Value = datos.r_tipo_regimen
            _adaptador.InsertCommand.Parameters.Add("@r_num_empleado", MySqlDbType.String).Value = datos.r_num_empleado
            _adaptador.InsertCommand.Parameters.Add("@r_departamento", MySqlDbType.String).Value = datos.r_departamento
            _adaptador.InsertCommand.Parameters.Add("@r_puesto", MySqlDbType.String).Value = datos.r_puesto
            _adaptador.InsertCommand.Parameters.Add("@r_riesgo", MySqlDbType.String).Value = datos.r_riesgo
            _adaptador.InsertCommand.Parameters.Add("@r_periodicidad", MySqlDbType.String).Value = datos.r_periodicidad
            _adaptador.InsertCommand.Parameters.Add("@r_banco", MySqlDbType.String).Value = datos.r_banco
            _adaptador.InsertCommand.Parameters.Add("@r_cuenta_bancaria", MySqlDbType.String).Value = datos.r_cuenta_bancaria
            _adaptador.InsertCommand.Parameters.Add("@r_salario_base", MySqlDbType.String).Value = datos.r_salario_base
            _adaptador.InsertCommand.Parameters.Add("@r_salario_diario", MySqlDbType.String).Value = datos.r_salario_diario
            _adaptador.InsertCommand.Parameters.Add("@r_clave_ent_f", MySqlDbType.String).Value = datos.r_clave_ent_f


            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_nomina_deducciones(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand(" insert into factura_nomina_deducciones(id_factura,tipo,clave,concepto,importe) values (@id_factura,@tipo,@clave,@concepto,@importe); ")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@concepto", MySqlDbType.String).Value = datos.concepto
            _adaptador.InsertCommand.Parameters.Add("@importe", MySqlDbType.Decimal).Value = datos.importe

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_nomina_incapacidades(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand(" insert into factura_nomina_incapacidad(id_factura,dias_inc,tipo_inc,importe_mon) values (@id_factura,@dias_inc,@tipo_inc,@importe_mon); ")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@dias_inc", MySqlDbType.String).Value = datos.dias
            _adaptador.InsertCommand.Parameters.Add("@tipo_inc", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@importe_mon", MySqlDbType.Decimal).Value = datos.importe

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_nomina_otrosP(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into factura_nomina_otrosP(id_factura,tipo,clave,importe,sae_subs_c,csa_anio,csa_saldo_f,csa_rem_sf) 
                                                        values (@id_factura,@tipo,@clave,@importe,@sae_subs_c,@csa_anio,@csa_saldo_f,@csa_rem_sf);")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@importe", MySqlDbType.Decimal).Value = datos.importe
            _adaptador.InsertCommand.Parameters.Add("@sae_subs_c", MySqlDbType.Decimal).Value = datos.sae_subs_c
            _adaptador.InsertCommand.Parameters.Add("@csa_anio", MySqlDbType.String).Value = datos.csa_anio
            _adaptador.InsertCommand.Parameters.Add("@csa_saldo_f", MySqlDbType.Decimal).Value = datos.csa_saldo_f
            _adaptador.InsertCommand.Parameters.Add("@csa_rem_sf", MySqlDbType.Decimal).Value = datos.csa_rem_sf

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function

    Public Function insert_nomina_percepciones(ByVal datos As Class_datos)
        Dim estado As Boolean = True
        Try
            Conexion_Global()
            _adaptador.InsertCommand = New MySqlCommand("insert into factura_nomina_percepciones(id_factura,tipo,clave,concepto,importe_gravado,importe_exento,aot_valor_mercado,aot_precio_otorgado,he_dias,he_tipo_hora,he_horas_extra,jpr_total_e,jpr_total_p,jpr_monto_diario,jpr_ingreso_acum,jpr_ingreso_n_acum,si_total_p,si_num_a_s,si_usmo,si_ing_a,si_ing_n_a) 
 values (@id_factura,@tipo,@clave,@concepto,@importe_gravado,@importe_exento,@aot_valor_mercado,@aot_precio_otorgado,@he_dias,@he_tipo_hora,@he_horas_extra,@jpr_total_e,@jpr_total_p,@jpr_monto_diario,@jpr_ingreso_acum,@jpr_ingreso_n_acum,@si_total_p,
@si_num_a_s,@si_usmo,@si_ing_a,@si_ing_n_a);")

            _adaptador.InsertCommand.Parameters.Add("@id_factura", MySqlDbType.Decimal).Value = datos.id_factura
            _adaptador.InsertCommand.Parameters.Add("@tipo", MySqlDbType.String).Value = datos.tipo
            _adaptador.InsertCommand.Parameters.Add("@clave", MySqlDbType.String).Value = datos.clave
            _adaptador.InsertCommand.Parameters.Add("@concepto", MySqlDbType.String).Value = datos.concepto
            _adaptador.InsertCommand.Parameters.Add("@importe_gravado", MySqlDbType.Decimal).Value = datos.importe_gravado
            _adaptador.InsertCommand.Parameters.Add("@importe_exento", MySqlDbType.Decimal).Value = datos.importe_exento
            _adaptador.InsertCommand.Parameters.Add("@aot_valor_mercado", MySqlDbType.Decimal).Value = datos.aot_valor_mercado
            _adaptador.InsertCommand.Parameters.Add("@aot_precio_otorgado", MySqlDbType.Decimal).Value = datos.aot_precio_otorgado
            _adaptador.InsertCommand.Parameters.Add("@he_dias", MySqlDbType.String).Value = datos.he_dias
            _adaptador.InsertCommand.Parameters.Add("@he_tipo_hora", MySqlDbType.String).Value = datos.he_tipo_hora
            _adaptador.InsertCommand.Parameters.Add("@he_horas_extra", MySqlDbType.String).Value = datos.he_horas_extra
            _adaptador.InsertCommand.Parameters.Add("@jpr_total_e", MySqlDbType.Decimal).Value = datos.jpr_total_e
            _adaptador.InsertCommand.Parameters.Add("@jpr_total_p", MySqlDbType.Decimal).Value = datos.jpr_total_p
            _adaptador.InsertCommand.Parameters.Add("@jpr_monto_diario", MySqlDbType.Decimal).Value = datos.jpr_monto_diario
            _adaptador.InsertCommand.Parameters.Add("@jpr_ingreso_acum", MySqlDbType.Decimal).Value = datos.jpr_ingreso_acum
            _adaptador.InsertCommand.Parameters.Add("@jpr_ingreso_n_acum", MySqlDbType.Decimal).Value = datos.jpr_ingreso_n_acum
            _adaptador.InsertCommand.Parameters.Add("@si_total_p", MySqlDbType.Decimal).Value = datos.si_total_p
            _adaptador.InsertCommand.Parameters.Add("@si_num_a_s", MySqlDbType.String).Value = datos.si_num_a_s
            _adaptador.InsertCommand.Parameters.Add("@si_usmo", MySqlDbType.Decimal).Value = datos.si_usmo
            _adaptador.InsertCommand.Parameters.Add("@si_ing_a", MySqlDbType.Decimal).Value = datos.si_ing_a
            _adaptador.InsertCommand.Parameters.Add("@si_ing_n_a", MySqlDbType.Decimal).Value = datos.si_ing_n_a

            _conexion.Open()
            _adaptador.InsertCommand.Connection = _conexion
            _adaptador.InsertCommand.ExecuteNonQuery()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        Finally
            cerrar()
            _conexion.Close()
        End Try
        Return estado
    End Function
End Class
