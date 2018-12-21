Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module mod_polizas
#Region "CREA POLIZAS"

    Public Sub create_poliza(ByVal id_factura As Integer, ByVal tipo As String, ByVal tipo_poliza As String, ByVal fecha As String, ByVal total As Decimal, ByVal subtotal As Decimal, ByVal condicion As String, ByVal folio As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_insert

        'VARIABLES PARA LAS CUENTAS
        Dim id_cuenta_cargo_rfc As Integer = 0
        Dim id_cuenta_abono_rfc As Integer = 0
        Dim id_cuenta_banco As Integer = 0
        Dim id_cuenta_cargo_impuesto As Integer = 0
        Dim id_cuenta_abono_impuesto As Integer = 0

        'VARIABLES PARA LAS PÓLIZAS
        Dim id_poliza As Integer = 0
        Dim tipo_comprobante As String = tipo_poliza

        'TIPO DE POLIZA
        Select Case tipo_poliza
            Case "I"
                If tipo = "EMITIDOS" Then
                    tipo_poliza = "Ingreso"
                Else
                    tipo_poliza = "Egreso"
                End If
            Case "E"
                If tipo = "EMITIDOS" Then
                    tipo_poliza = "Egreso"
                Else
                    tipo_poliza = "Ingreso"
                End If
            Case "P"
                If tipo = "EMITIDOS" Then
                    tipo_poliza = "Ingreso"
                Else
                    tipo_poliza = "Egreso"
                End If

                polizas_pagos(id_factura, tipo_poliza, tipo, fecha)
                Return
        End Select

        'PRIMERA PÓLIZA
        'OBTENEMOS LA FECHA
        mes(Convert.ToDateTime(fecha).Month)

        'CREAMOS LA CABECERA
        datos.id_factura = id_factura
        datos.tipo_poliza = tipo_poliza                                                                            'TIPO DE PÓLIZA
        datos.mes = var_globales.mes                                                                               'MES DE LA PÓLIZA
        datos.anio = Convert.ToDateTime(fecha).Year                                                                'AÑO DE LA PÓLIXA
        datos.user = scrPrincipal2.lblNUsuario.Text                                                                'USUARIO CREADOR
        datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text                                                  'USUARIO CREADOR
        datos.numero_poliza = get_numero_poliza(tipo_poliza, var_globales.mes, Convert.ToDateTime(fecha).Year)     'NÚMERO DE PÓLIZA
        datos.total = total                                                                                        'TOTAL DE LA PÓLIZA
        datos.origen = "Póliza por XML"                                                                            'ORIGEN
        datos.descripcion = "Poliza generada por la factura: " & folio                                             'FOLIO DEL XML
        datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")                                            'FECHA DE LA PÓLIZA

        If conexion.insertaPolizas(datos) Then
            'OBTENEMOS EL ID DE LA PÓLIZA
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_poliza = resultado.GetString("max(id_poliza)")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'OBTENEMOS LAS CUENTAS DEL RFC DEPENDIENDO EL TIPO DE XML
            If tipo = "EMITIDOS" Then
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select rc.id_cuenta_abono, rc.id_cuenta_cargo, cb.ccontable from factura f join (rfc_config rc, cuentas_bancos cb) on (f.rfc_r = rc.rfc and cb.id_cuentaB = rc.id_cuentaB) where rc.tipo = 'EMITIDOS' and f.id_timbrados = '" & id_factura & "';", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_cuenta_abono_rfc = resultado.GetInt32("id_cuenta_abono")
                        id_cuenta_cargo_rfc = resultado.GetInt32("id_cuenta_cargo")
                        id_cuenta_banco = resultado.GetInt32("ccontable")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Else
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select rc.id_cuenta_abono, rc.id_cuenta_cargo, cb.ccontable from factura f join (rfc_config rc, cuentas_bancos cb) on (f.rfc_e = rc.rfc and cb.id_cuentaB = rc.id_cuentaB) where rc.tipo = 'RECIBIDOS' and f.id_timbrados = '" & id_factura & "';", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_cuenta_abono_rfc = resultado.GetInt32("id_cuenta_abono")
                        id_cuenta_cargo_rfc = resultado.GetInt32("id_cuenta_cargo")
                        id_cuenta_banco = resultado.GetInt32("ccontable")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            End If

            'PRIMER DETALLE (CARGO RFC)
            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
            datos.id_cuenta = id_cuenta_cargo_rfc                               'ID CUENTA CARGO RFC
            If tipo = "EMITIDOS" Then
                datos.cargo = total                                             'TOTAL DE LA FACTURA
                datos.abono = 0.0                                               'CEROS
            Else
                datos.cargo = subtotal                                          'TOTAL DE LA FACTURA
                datos.abono = 0.0                                               'CEROS
            End If
            datos.desc_asiento = ""                                             'DESCRIPCIÓN

            'GUARDAMOS EL PRIMER DETALLE
            conexion.insertaPolDet(datos)

            'SEGUNDO DETALLE (ABONO RFC)
            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
            datos.id_cuenta = id_cuenta_abono_rfc                               'ID CUENTA ABONO RFC
            If tipo = "EMITIDOS" Then
                datos.abono = subtotal                                           'TOTAL DE LA FACTURA
                datos.cargo = 0.0                                                'CEROS
            Else
                datos.abono = total                                              'TOTAL DE LA FACTURA
                datos.cargo = 0.0                                                'CEROS
            End If
            datos.desc_asiento = ""                                             'DESCRIPCIÓN

            'GUARDAMOS EL SEGUNDO DETALLE
            conexion.insertaPolDet(datos)

            'TERCER DETALLE (IMPUESTOS)
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select ic.id_cuenta_cargo, ic.id_cuenta_abono, fi.total, fi.tabla from factura_impuestos fi 
                                                    join (impuesto_config ic) on (fi.tasa = ic.tasa_cuota and fi.calculo = ic.tipo_factor and fi.tipo = ic.impuesto) where fi.id_factura = '" & id_factura & "' and ic.tipo = '" & tipo & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_cuenta_abono_impuesto = resultado.GetInt32("id_cuenta_abono")
                    id_cuenta_cargo_impuesto = resultado.GetInt32("id_cuenta_cargo")

                    If tipo = "EMITIDOS" Then
                        Select Case resultado.GetString("tabla")
                            Case "TRASLADO"
                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                datos.id_cuenta = id_cuenta_abono_impuesto                          'ID CUENTA ABONO RFC
                                datos.cargo = 0.0                                                   'CEROS
                                datos.abono = resultado.GetDecimal("total")                         'TOTAL
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN
                            Case "RETENIDO"
                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                datos.id_cuenta = id_cuenta_cargo_impuesto                          'ID CUENTA ABONO RFC
                                datos.abono = 0.0                                                   'CEROS
                                datos.cargo = resultado.GetDecimal("total")                         'TOTAL
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN
                        End Select
                    Else
                        Select Case resultado.GetString("tabla")
                            Case "RETENIDO"
                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                datos.id_cuenta = id_cuenta_abono_impuesto                          'ID CUENTA ABONO RFC
                                datos.cargo = 0.0                                                   'CEROS
                                datos.abono = resultado.GetDecimal("total")                         'TOTAL
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN
                            Case "TRASLADO"
                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                datos.id_cuenta = id_cuenta_cargo_impuesto                          'ID CUENTA ABONO RFC
                                datos.abono = 0.0                                                   'CEROS
                                datos.cargo = resultado.GetDecimal("total")                         'TOTAL
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN
                        End Select
                    End If

                    conexion.insertaPolDet(datos)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        End If

        'VERIFICAMOS QUE EL XML NO SEA UN PAGO EN PARCIALIDADES (PPD)
        If condicion <> "PPD" Then
            'SEGUNDA PÓLIZA BANCOS
            datos.tipo_poliza = tipo_poliza                                                                            'TIPO DE PÓLIZA
            datos.mes = var_globales.mes                                                                               'MES DE LA PÓLIZA
            datos.anio = Convert.ToDateTime(fecha).Year                                                                'AÑO DE LA PÓLIXA
            datos.user = scrPrincipal2.lblNUsuario.Text                                                                'USUARIO CREADOR
            datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text                                                  'USUARIO CREADOR
            datos.numero_poliza = get_numero_poliza(tipo_poliza, var_globales.mes, Convert.ToDateTime(fecha).Year)     'NÚMERO DE PÓLIZA
            datos.total = total                                                                                        'TOTAL DE LA PÓLIZA
            datos.origen = "Póliza por XML Banco"                                                                      'ORIGEN
            datos.descripcion = "Poliza generada por la factura: " & folio                                             'FOLIO DEL XML
            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")                                            'FECHA DE LA PÓLIZA

            If conexion.insertaPolizas(datos) Then
                'OBTENEMOS EL ID DE LA PÓLIZA
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_poliza = resultado.GetString("max(id_poliza)")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                'PRIMER DETALLE (CARGO RFC)
                If tipo = "EMITIDOS" Then
                    datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                    datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                    datos.id_cuenta = id_cuenta_cargo_rfc                               'ID CUENTA CARGO RFC
                    datos.cargo = 0.0                                                   'CEROS
                    datos.abono = total                                                 'TOTAL DE LA FACTURA
                    datos.desc_asiento = ""                                             'DESCRIPCIÓN
                Else
                    datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                    datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                    datos.id_cuenta = id_cuenta_abono_rfc                               'ID CUENTA ABONO RFC
                    datos.cargo = total                                                 'TOTAL DE LA FACTURA
                    datos.abono = 0.0                                                   'CEROS
                    datos.desc_asiento = ""                                             'DESCRIPCIÓN
                End If

                'GUARDAMOS EL PRIMER DETALLE
                conexion.insertaPolDet(datos)

                'SEGUNDO DETALLE (BANCOS)
                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                datos.id_cuenta = id_cuenta_banco                                   'ID CUENTA BANCO
                If tipo = "EMITIDOS" Then
                    datos.abono = 0.0                                               'CEROS
                    datos.cargo = total                                             'TOTAL DE LA FACTURA
                Else
                    datos.abono = total                                             'CEROS
                    datos.cargo = 0.0                                               'TOTAL DE LA FACTURA
                End If
                datos.desc_asiento = ""                                             'DESCRIPCIÓN

                'GUARDAMOS EL SEGUNDO DETALLE
                conexion.insertaPolDet(datos)
            End If

            'TERCERA PÓLIZA IMPUESTOS
            datos.tipo_poliza = tipo_poliza                                                                            'TIPO DE PÓLIZA
            datos.mes = var_globales.mes                                                                               'MES DE LA PÓLIZA
            datos.anio = Convert.ToDateTime(fecha).Year                                                                'AÑO DE LA PÓLIXA
            datos.user = scrPrincipal2.lblNUsuario.Text                                                                'USUARIO CREADOR
            datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text                                                  'USUARIO CREADOR
            datos.numero_poliza = get_numero_poliza(tipo_poliza, var_globales.mes, Convert.ToDateTime(fecha).Year)     'NÚMERO DE PÓLIZA
            datos.total = get_total_impuestos(id_factura)                                                              'TOTAL DE LA PÓLIZA
            datos.origen = "Póliza por XML Impuestos"                                                                  'ORIGEN
            datos.descripcion = "Poliza generada por la factura: " & folio                                             'FOLIO DEL XML
            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")                                            'FECHA DE LA PÓLIZA

            If conexion.insertaPolizas(datos) Then
                'OBTENEMOS EL ID DE LA PÓLIZA
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_poliza = resultado.GetString("max(id_poliza)")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                'PRIMER DETALLE (IMPUESTOS)
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select ic.id_cuenta_cargo, ic.id_cuenta_abono, fi.total, fi.tabla from factura_impuestos fi 
                                                    join (impuesto_config ic) on (fi.tasa = ic.tasa_cuota and fi.calculo = ic.tipo_factor and fi.tipo = ic.impuesto) where fi.id_factura = '" & id_factura & "' and ic.tipo = '" & tipo & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_cuenta_abono_impuesto = resultado.GetInt32("id_cuenta_abono")
                        id_cuenta_cargo_impuesto = resultado.GetInt32("id_cuenta_cargo")

                        Select Case resultado.GetString("tabla")
                            Case "RETENIDO"
                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                If tipo = "EMITIDOS" Then
                                    datos.id_cuenta = id_cuenta_abono_impuesto                      'ID CUENTA ABONO RFC
                                    datos.abono = 0.0                                               'CEROS
                                    datos.cargo = resultado.GetDecimal("total")                     'TOTAL
                                Else
                                    datos.id_cuenta = id_cuenta_cargo_impuesto                      'ID CUENTA ABONO RFC
                                    datos.abono = resultado.GetDecimal("total")                     'CEROS
                                    datos.cargo = 0.0                                               'TOTAL
                                End If
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN

                                conexion.insertaPolDet(datos)

                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA                                
                                If tipo = "EMITIDOS" Then
                                    datos.id_cuenta = id_cuenta_cargo_impuesto                      'ID CUENTA ABONO RFC
                                    datos.cargo = 0.0                                               'CEROS
                                    datos.abono = resultado.GetDecimal("total")                     'TOTAL
                                Else
                                    datos.cargo = resultado.GetDecimal("total")                     'CEROS
                                    datos.abono = 0.0                                               'TOTAL
                                    datos.id_cuenta = id_cuenta_abono_impuesto                      'ID CUENTA ABONO RFC
                                End If
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN

                                conexion.insertaPolDet(datos)

                            Case "TRASLADO"
                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                If tipo = "EMITIDOS" Then
                                    datos.id_cuenta = id_cuenta_cargo_impuesto                      'ID CUENTA ABONO RFC
                                    datos.cargo = 0.0                                               'CEROS
                                    datos.abono = resultado.GetDecimal("total")                     'TOTAL
                                Else
                                    datos.id_cuenta = id_cuenta_abono_impuesto                      'ID CUENTA ABONO RFC
                                    datos.cargo = resultado.GetDecimal("total")                     'CEROS
                                    datos.abono = 0.0                                               'TOTAL
                                End If
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN

                                conexion.insertaPolDet(datos)

                                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                                If tipo = "EMITIDOS" Then
                                    datos.id_cuenta = id_cuenta_abono_impuesto                      'ID CUENTA ABONO RFC
                                    datos.abono = 0.0                                               'CEROS
                                    datos.cargo = resultado.GetDecimal("total")                     'TOTAL
                                Else
                                    datos.id_cuenta = id_cuenta_cargo_impuesto                      'ID CUENTA ABONO RFC
                                    datos.abono = resultado.GetDecimal("total")                     'TOTAL
                                    datos.cargo = 0.0                                               'CEROS
                                End If
                                datos.desc_asiento = ""                                             'DESCRIPCIÓN

                                conexion.insertaPolDet(datos)
                        End Select
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            End If
        End If
    End Sub

    Public Function get_numero_poliza(ByVal tipo As String, ByVal mes As String, ByVal anio As String) As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim b As Boolean = False
        Dim numero_poliza As Integer = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from polizas where tipo_poliza = '" & tipo & "' and mes = '" & mes & "' and anio = '" & anio & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If b = True Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from polizas where tipo_poliza = '" & tipo & "' and mes = '" & mes & "' and anio = '" & anio & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    numero_poliza = resultado.GetInt64("numero_poliza") + 1
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            numero_poliza = 1
        End If

        Return numero_poliza
    End Function

    Public Function get_total_impuestos(ByVal id_factura As Integer) As Decimal
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim monto As Decimal = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select sum(total) from factura_impuestos where id_factura = '" & id_factura & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                monto = resultado.GetDecimal("sum(total)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return monto
    End Function

    Public Sub polizas_pagos(ByVal id_factura As String, ByVal tipo_poliza As String, ByVal tipo As String, ByVal fecha As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'OBTENEMOS EL ID DE LOS XML RELACIONADOS
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from factura_pagos where id_factura = '" & id_factura & "'; ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                create_polizas_pagos(resultado.GetString("uuid"), resultado.GetDecimal("importe_pagado"), tipo_poliza, tipo, fecha)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Public Sub create_polizas_pagos(ByVal uuid As String, ByVal monto As Decimal, ByVal tipo_poliza As String, ByVal tipo As String, ByVal fecha As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_insert

        'VARIABLES PARA LAS CUENTAS
        Dim id_cuenta_cargo_rfc As Integer = 0
        Dim id_cuenta_abono_rfc As Integer = 0
        Dim id_cuenta_banco As Integer = 0
        Dim id_cuenta_cargo_impuesto As Integer = 0
        Dim id_cuenta_abono_impuesto As Integer = 0
        Dim total_f As Decimal = 0
        Dim id_factura As Integer = 0
        Dim folio As String = ""

        'VARIABLES PARA LAS PÓLIZAS
        Dim id_poliza As Integer = 0

        'OBTENEMOS EL TOTAL DE LA FACTURA ORINGINAL Y SU ID
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from factura where uuid = '" & uuid & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_factura = resultado.GetInt32("id_timbrados")
                total_f = resultado.GetDecimal("total_t")
                folio = resultado.GetString("serie_t") & " - " & resultado.GetString("folio_t")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'OBTENEMOS LAS CUENTAS DEL RFC DEPENDIENDO EL TIPO DE XML
        If tipo = "EMITIDOS" Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select rc.id_cuenta_abono, rc.id_cuenta_cargo, f.serie_t, f.folio_t, cb.ccontable from factura f join (rfc_config rc, cuentas_bancos cb) on (f.rfc_r = rc.rfc and cb.id_cuentaB = rc.id_cuentaB) where rc.tipo = 'EMITIDOS' and f.id_timbrados = '" & id_factura & "';", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_cuenta_abono_rfc = resultado.GetInt32("id_cuenta_abono")
                    id_cuenta_cargo_rfc = resultado.GetInt32("id_cuenta_cargo")
                    id_cuenta_banco = resultado.GetInt32("ccontable")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select rc.id_cuenta_abono, rc.id_cuenta_cargo, cb.ccontable, f.serie_t, f.folio_t
 from factura f join (rfc_config rc, cuentas_bancos cb) on (f.rfc_e = rc.rfc and cb.id_cuentaB = rc.id_cuentaB) where rc.tipo = 'RECIBIDOS' and f.id_timbrados = '" & id_factura & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_cuenta_abono_rfc = resultado.GetInt32("id_cuenta_abono")
                    id_cuenta_cargo_rfc = resultado.GetInt32("id_cuenta_cargo")
                    id_cuenta_banco = resultado.GetInt32("ccontable")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

        'PRIMERA PÓLIZA BANCOS
        'OBTENEMOS LA FECHA
        mes(Convert.ToDateTime(fecha).Month)

        'CREAMOS LA CABECERA
        datos.id_factura = id_factura
        datos.tipo_poliza = tipo_poliza                                                                            'TIPO DE PÓLIZA
        datos.mes = var_globales.mes                                                                               'MES DE LA PÓLIZA
        datos.anio = Convert.ToDateTime(fecha).Year                                                                'AÑO DE LA PÓLIXA
        datos.user = scrPrincipal2.lblNUsuario.Text                                                                'USUARIO CREADOR
        datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text                                                  'USUARIO CREADOR
        datos.numero_poliza = get_numero_poliza(tipo_poliza, var_globales.mes, Convert.ToDateTime(fecha).Year)     'NÚMERO DE PÓLIZA
        datos.total = monto                                                                                        'TOTAL DE LA PÓLIZA
        datos.origen = "Póliza por XML"                                                                            'ORIGEN
        datos.descripcion = "Poliza generada por el pago de la factura: " & folio                                  'FOLIO DEL XML
        datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")                                            'FECHA DE LA PÓLIZA

        If conexion.insertaPolizas(datos) Then
            'OBTENEMOS EL ID DE LA PÓLIZA
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_poliza = resultado.GetString("max(id_poliza)")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'PRIMER DETALLE (CARGO RFC)
            If tipo = "EMITIDOS" Then
                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                datos.id_cuenta = id_cuenta_cargo_rfc                               'ID CUENTA CARGO RFC
                datos.cargo = 0.0                                                   'CEROS
                datos.abono = monto                                                 'TOTAL DE LA FACTURA
                datos.desc_asiento = ""                                             'DESCRIPCIÓN
            Else
                datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                datos.id_cuenta = id_cuenta_abono_rfc                               'ID CUENTA ABONO RFC
                datos.cargo = monto                                                 'TOTAL DE LA FACTURA
                datos.abono = 0.0                                                   'CEROS
                datos.desc_asiento = ""                                             'DESCRIPCIÓN
            End If

            'GUARDAMOS EL PRIMER DETALLE
            conexion.insertaPolDet(datos)

            'SEGUNDO DETALLE (BANCOS)
            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
            datos.id_cuenta = id_cuenta_banco                                   'ID CUENTA BANCO
            If tipo = "EMITIDOS" Then
                datos.abono = 0.0                                               'CEROS
                datos.cargo = monto                                             'TOTAL DE LA FACTURA
            Else
                datos.abono = monto                                             'CEROS
                datos.cargo = 0.0                                               'TOTAL DE LA FACTURA
            End If
            datos.desc_asiento = ""                                             'DESCRIPCIÓN

            'GUARDAMOS EL SEGUNDO DETALLE
            conexion.insertaPolDet(datos)
        End If

        'SEGUNDA PÓLIZA IMPUESTOS
        datos.tipo_poliza = tipo_poliza                                                                            'TIPO DE PÓLIZA
        datos.mes = var_globales.mes                                                                               'MES DE LA PÓLIZA
        datos.anio = Convert.ToDateTime(fecha).Year                                                                'AÑO DE LA PÓLIXA
        datos.user = scrPrincipal2.lblNUsuario.Text                                                                'USUARIO CREADOR
        datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text                                                  'USUARIO CREADOR
        datos.numero_poliza = get_numero_poliza(tipo_poliza, var_globales.mes, Convert.ToDateTime(fecha).Year)     'NÚMERO DE PÓLIZA
        datos.total = get_total_impuestos_2(id_factura, monto)                                                     'TOTAL DE LA PÓLIZA
        datos.origen = "Póliza por XML Impuestos"                                                                  'ORIGEN
        datos.descripcion = "Poliza generada por el pago de la factura: " & folio                                  'FOLIO DEL XML
        datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")                                            'FECHA DE LA PÓLIZA

        If conexion.insertaPolizas(datos) Then
            'OBTENEMOS EL ID DE LA PÓLIZA
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_poliza = resultado.GetString("max(id_poliza)")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'PRIMER DETALLE (IMPUESTOS)
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select ic.id_cuenta_cargo, ic.id_cuenta_abono, fi.total, fi.tabla, fi.tasa from factura_impuestos fi 
                                                    join (impuesto_config ic) on (fi.tasa = ic.tasa_cuota and fi.calculo = ic.tipo_factor and fi.tipo = ic.impuesto) where fi.id_factura = '" & id_factura & "' and ic.tipo = '" & tipo & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_cuenta_abono_impuesto = resultado.GetInt32("id_cuenta_abono")
                    id_cuenta_cargo_impuesto = resultado.GetInt32("id_cuenta_cargo")

                    Select Case resultado.GetString("tabla")
                        Case "RETENIDO"
                            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                            If tipo = "EMITIDOS" Then
                                datos.id_cuenta = id_cuenta_abono_impuesto                      'ID CUENTA ABONO RFC
                                datos.abono = 0.0                                               'MONTO
                                datos.cargo = (resultado.GetDecimal("tasa") / 100) * monto      'TOTAL
                            Else
                                datos.id_cuenta = id_cuenta_cargo_impuesto                      'ID CUENTA ABONO RFC
                                datos.abono = (resultado.GetDecimal("tasa") / 100) * monto      'MONTO
                                datos.cargo = 0.0                                               'CEROS
                            End If
                            datos.desc_asiento = ""                                             'DESCRIPCIÓN

                            conexion.insertaPolDet(datos)

                            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                            If tipo = "EMITIDOS" Then
                                datos.id_cuenta = id_cuenta_cargo_impuesto                      'ID CUENTA ABONO RFC
                                datos.cargo = 0.0                                               'CEROS
                                datos.abono = (resultado.GetDecimal("tasa") / 100) * monto      'TOTAL
                            Else
                                datos.id_cuenta = id_cuenta_abono_impuesto                      'ID CUENTA ABONO RFC
                                datos.cargo = (resultado.GetDecimal("tasa") / 100) * monto      'CEROS
                                datos.abono = 0.0                                               'TOTAL
                            End If
                            datos.desc_asiento = ""                                             'DESCRIPCIÓN

                            conexion.insertaPolDet(datos)

                        Case "TRASLADO"
                            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                            If tipo = "EMITIDOS" Then
                                datos.id_cuenta = id_cuenta_cargo_impuesto                     'ID CUENTA ABONO RFC
                                datos.cargo = 0.0                                              'CEROS
                                datos.abono = (resultado.GetDecimal("tasa") / 100) * monto     'TOTAL
                            Else
                                datos.id_cuenta = id_cuenta_abono_impuesto                     'ID CUENTA ABONO RFC
                                datos.cargo = (resultado.GetDecimal("tasa") / 100) * monto     'CEROS
                                datos.abono = 0.0                                              'TOTAL
                            End If
                            datos.desc_asiento = ""                                             'DESCRIPCIÓN

                            conexion.insertaPolDet(datos)

                            datos.id_poliza = id_poliza                                         'ID DE LA PÓLIZA
                            datos.fechat = Convert.ToDateTime(fecha).ToString("yyyy-MM-dd")     'FECHA DE LA PÓLIZA
                            If tipo = "EMITIDOS" Then
                                datos.id_cuenta = id_cuenta_abono_impuesto                          'ID CUENTA ABONO RFC
                                datos.abono = 0.0                                                   'CEROS
                                datos.cargo = (resultado.GetDecimal("tasa") / 100) * monto          'TOTAL
                            Else
                                datos.id_cuenta = id_cuenta_cargo_impuesto                          'ID CUENTA ABONO RFC
                                datos.abono = (resultado.GetDecimal("tasa") / 100) * monto      'CEROS
                                datos.cargo = 0.0                                               'TOTAL
                            End If

                            datos.desc_asiento = ""                                             'DESCRIPCIÓN

                            conexion.insertaPolDet(datos)
                    End Select
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If
    End Sub

    Public Function get_total_impuestos_2(ByVal id_factura As Integer, ByVal total As Decimal) As Decimal
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim monto As Decimal = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from factura_impuestos where id_factura = '" & id_factura & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                monto = monto + ((resultado.GetDecimal("tasa") / 100) * total)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return monto
    End Function

#End Region

#Region "CANCELA PÓLIZAS"

    Public Sub cancel_polizas_rfc(ByVal rfc As String, ByVal tipo As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_update

        If tipo = "Emitidos" Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select id_timbrados from factura where rfc_r = '" & rfc & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_factura = resultado.GetInt64("id_timbrados")
                    conexion.update_cancel_polizas_factura(datos)
                    conexion.update_cancel_factura(datos)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select id_timbrados from factura where rfc_e = '" & rfc & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_factura = resultado.GetInt64("id_timbrados")
                    conexion.update_cancel_polizas_factura(datos)
                    conexion.update_cancel_factura(datos)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If
    End Sub

    Public Sub cancel_polizas_impuestos(ByVal tasa As String, ByVal calculo As String, ByVal tipo_i As String, ByVal tipo As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_update

        If tipo = "Emitidos" Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select f.id_timbrados from factura f join (factura_impuestos fi) on (f.id_timbrados = fi.id_factura) where fi.tasa = '" & tasa & "' and fi.calculo = '" & calculo & "' and fi.tipo = '" & tipo_i & "' and f.rfc_r <> '" & get_rfc_empresa() & "'; ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_factura = resultado.GetInt64("id_timbrados")
                    conexion.update_cancel_polizas_factura(datos)
                    conexion.update_cancel_factura(datos)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select f.id_timbrados from factura f join (factura_impuestos fi) on (f.id_timbrados = fi.id_factura) where fi.tasa = '" & tasa & "' and fi.calculo = '" & calculo & "' and fi.tipo = '" & tipo_i & "' and f.rfc_e <> '" & get_rfc_empresa() & "'; ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_factura = resultado.GetInt64("id_timbrados")
                    conexion.update_cancel_polizas_factura(datos)
                    conexion.update_cancel_factura(datos)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If
    End Sub

    Public Function get_rfc_empresa() As String
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim b As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from config_auto_conta.bases where base = '" & var_globales.base & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = resultado.GetString("rfc_emp")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return b
    End Function

    Public Function get_nombre_empresa() As String
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim b As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from config_auto_conta.bases where base = '" & var_globales.base & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = resultado.GetString("nombre_emp")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return b
    End Function

#End Region

#Region "POLIZAS DEDUCIBLES"
    Public Sub no_deducible(ByVal id_factura As Integer, ByVal tipo As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_update
        Dim conexion2 As New Class_insert

        Dim id_poliza_impuestos As Integer = 0
        Dim id_poliza_xml As Integer = 0
        Dim id_poliza As Integer = 0
        Dim id_cuenta_cargo_rfc As Integer = 0
        Dim id_cuenta_abono_rfc As Integer = 0

        'PÓLIZA POR XML
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from polizas where origen = 'Póliza por XML' and id_factura = '" & id_factura & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_poliza_xml = resultado.GetInt64("id_poliza")
                datos.id_factura = id_factura
                datos.tipo_poliza = resultado.GetString("tipo_poliza")
                datos.mes = resultado.GetString("mes")
                datos.anio = resultado.GetString("anio")
                datos.user = scrPrincipal2.lblNUsuario.Text
                datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text
                datos.numero_poliza = resultado.GetString("numero_poliza")
                datos.total = resultado.GetDecimal("total")
                datos.origen = "Póliza por XML"
                datos.descripcion = resultado.GetString("descripcion")
                datos.fechat = resultado.GetDateTime("fecha").ToString("yyyy-MM-dd")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If conexion2.insertaPolizas(datos) Then
            'OBTENEMOS EL ID DE LA NUEVA PÓLIZA
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_poliza = resultado.GetString("max(id_poliza)")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If tipo = "RECIBIDO" Then
                'OBTENEMOS LAS CUENTAS DE CONFIGURACIÓN DEL RFC EMISOR
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select rc.id_cuenta_abono, rc.id_cuenta_cargo, cb.ccontable from factura f join (rfc_config rc, cuentas_bancos cb) on (f.rfc_e = rc.rfc and cb.id_cuentaB = rc.id_cuentaB) where rc.tipo = 'RECIBIDOS' and f.id_timbrados = '" & id_factura & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        id_cuenta_abono_rfc = resultado.GetInt32("id_cuenta_abono")
                        id_cuenta_cargo_rfc = resultado.GetInt32("id_cuenta_cargo")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                'OBTENEMOS EL DETALLE DE LA CUENTA A LA QUE CARGA
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select * from polizas_det where id_poliza = '" & id_poliza_xml & "' and id_cuenta = '" & id_cuenta_cargo_rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        datos.id_poliza = id_poliza
                        datos.fechat = resultado.GetDateTime("fecha").ToString("yyyy-MM-dd")
                        datos.id_cuenta = id_cuenta_cargo_rfc
                        datos.cargo = resultado.GetDecimal("cargo")
                        datos.abono = 0.0
                        datos.desc_asiento = ""
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                'GUARDAMOS EL PRIMER DETALLE
                conexion2.insertaPolDet(datos)

                'OBTENEMOS EL ID DE LA CUENTA DEL NO DEDUCIBLE
                If get_cuenta_no_deducible("601.83") = 0 Then
                    MessageBox.Show("La cuenta 'No deducible' no esta dada de alta", "ContaGo Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If

                'GUARDAMOS EL SEGUNDO DETALLE DE LA PÓLIZA
                datos.id_cuenta = get_cuenta_no_deducible("601.83")
                datos.abono = datos.cargo
                datos.cargo = 0.0

                conexion2.insertaPolDet(datos)
            End If
        End If

        'PÓLIZA POR IMPUESTOS
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from polizas where origen = 'Póliza por XML Banco' and id_factura = '" & id_factura & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_poliza_impuestos = resultado.GetInt64("id_poliza")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'ELIMINAMOS LA PÓLIZA DE IMPUESTOS
        datos.id_poliza = id_poliza_impuestos
        conexion.update_delete_polizas(datos)
    End Sub

    Public Function get_cuenta_no_deducible(ByVal numero_cuenta As String) As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_cuenta As Integer = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select cc.id_cuenta, cc.numero_cuenta from catalogo_contable cc join catalogo_cuentas_sat ccs on cc.cuenta_sat = ccs.id where ccs.numero_cuenta = '" & numero_cuenta & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_cuenta = resultado.GetInt64("id_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return id_cuenta
    End Function
#End Region
End Module
