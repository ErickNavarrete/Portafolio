Public Class Class_datos

    Private _id_usuario As String
    Private _id_base As String
    Private _Usuario As String
    Private _Contrasenia As String

    Public Property id_usuario() As Integer
        Get
            Return _id_usuario
        End Get
        Set(ByVal value As Integer)
            _id_usuario = value
        End Set
    End Property

    Public Property id_base() As String
        Get
            Return _id_base
        End Get
        Set(ByVal value As String)
            _id_base = value
        End Set
    End Property

    Public Property Usuario() As String
        Get
            Return _Usuario
        End Get
        Set(ByVal value As String)
            _Usuario = value
        End Set
    End Property

    Public Property contrasenia() As String
        Get
            Return _Contrasenia
        End Get
        Set(ByVal value As String)
            _Contrasenia = value
        End Set
    End Property

#Region "Catalogo Cuentas"

    Private _id_cuenta_padre As Integer
    Private _numero_cuenta_unico As String
    Private _numero_cuenta As String
    Private _nombre_cuenta As String
    Private _tipo As String = ""
    Private _naturaleza As String
    Private _cuenta_sat As String
    Private _usuario_creador As String

    Public Property id_cuenta_padre() As Integer
        Get
            Return _id_cuenta_padre
        End Get
        Set(ByVal value As Integer)
            _id_cuenta_padre = value
        End Set
    End Property

    Public Property numero_cuenta_unico() As String
        Get
            Return _numero_cuenta_unico
        End Get
        Set(ByVal value As String)
            _numero_cuenta_unico = value
        End Set
    End Property

    Public Property numero_cuenta() As String
        Get
            Return _numero_cuenta
        End Get
        Set(ByVal value As String)
            _numero_cuenta = value
        End Set
    End Property

    Public Property nombre_cuenta() As String
        Get
            Return _nombre_cuenta
        End Get
        Set(ByVal value As String)
            _nombre_cuenta = value
        End Set
    End Property

    Public Property tipo() As String
        Get
            Return _tipo
        End Get
        Set(ByVal value As String)
            _tipo = value
        End Set
    End Property

    Public Property naturaleza() As String
        Get
            Return _naturaleza
        End Get
        Set(ByVal value As String)
            _naturaleza = value
        End Set
    End Property

    Public Property cuenta_sat() As String
        Get
            Return _cuenta_sat
        End Get
        Set(ByVal value As String)
            _cuenta_sat = value
        End Set
    End Property

    Public Property usuario_creador() As String
        Get
            Return _usuario_creador
        End Get
        Set(ByVal value As String)
            _usuario_creador = value
        End Set
    End Property

#End Region

#Region "Usuarios"

    Private _user As String
    Private _pass As String

    Public Property user() As String
        Get
            Return _user
        End Get
        Set(ByVal value As String)
            _user = value
        End Set
    End Property

    Public Property pass() As String
        Get
            Return _pass
        End Get
        Set(ByVal value As String)
            _pass = value
        End Set
    End Property

#End Region

#Region "Alta_empresa"
    Private _base As String

    Private _nombre_emp As String
    Private _rfc_emp As String
    Private _regimen_emp As String

    Public Property base() As String
        Get
            Return _base
        End Get
        Set(ByVal value As String)
            _base = value
        End Set
    End Property

    Public Property nombre_emp() As String
        Get
            Return _nombre_emp
        End Get
        Set(ByVal value As String)
            _nombre_emp = value
        End Set
    End Property

    Public Property rfc_emp() As String
        Get
            Return _rfc_emp
        End Get
        Set(ByVal value As String)
            _rfc_emp = value
        End Set
    End Property

    Public Property regimen_emp() As String
        Get
            Return _regimen_emp
        End Get
        Set(ByVal value As String)
            _regimen_emp = value
        End Set
    End Property

#End Region

#Region "ConfigRFC"
    Private _id_cargo As Integer
    Private _id_abono As Integer

    Public Property id_cargo() As Integer
        Get
            Return _id_cargo
        End Get
        Set(ByVal value As Integer)
            _id_cargo = value
        End Set
    End Property

    Public Property id_abono() As Integer
        Get
            Return _id_abono
        End Get
        Set(ByVal value As Integer)
            _id_abono = value
        End Set
    End Property


#End Region

#Region "Bancos"
    Private _banco As String
    Private _CuentaB As String
    Private _id_banco As Integer
    Private _id_bancoR As Integer
    Private _fechat As String
    Private _deposito As Decimal
    Private _retiro As Decimal




    Public Property banco() As String
        Get
            Return _banco
        End Get
        Set(ByVal value As String)
            _banco = value
        End Set
    End Property

    Public Property Cuentab() As String
        Get
            Return _CuentaB
        End Get
        Set(ByVal value As String)
            _CuentaB = value
        End Set
    End Property


    Public Property id_banco() As Integer
        Get
            Return _id_banco
        End Get
        Set(ByVal value As Integer)
            _id_banco = value
        End Set
    End Property


    Public Property id_bancoR() As Integer
        Get
            Return _id_bancoR
        End Get
        Set(ByVal value As Integer)
            _id_bancoR = value
        End Set
    End Property


    Public Property fechat() As String
        Get
            Return _fechat
        End Get
        Set(ByVal value As String)
            _fechat = value
        End Set
    End Property


    Public Property deposito() As String
        Get
            Return _deposito
        End Get
        Set(ByVal value As String)
            _deposito = value
        End Set
    End Property


    Public Property retiro() As String
        Get
            Return _retiro
        End Get
        Set(ByVal value As String)
            _retiro = value
        End Set
    End Property

#End Region

#Region "Polizas"

#Region "Polizas"

    Private _tipo_poliza As String
    Private _numero_poliza As Integer

    Private _mes As String
    Private _anio As String
    Private _usuariomodificador As String
    Private _origen As String
    Private _estado As String

    Public Property tipo_poliza() As String
        Get
            Return _tipo_poliza
        End Get
        Set(ByVal value As String)
            _tipo_poliza = value
        End Set
    End Property

    Public Property numero_poliza() As Integer
        Get
            Return _numero_poliza
        End Get
        Set(ByVal value As Integer)
            _numero_poliza = value
        End Set
    End Property





    Public Property mes() As String
        Get
            Return _mes
        End Get
        Set(ByVal value As String)
            _mes = value
        End Set
    End Property

    Public Property anio() As String
        Get
            Return _anio
        End Get
        Set(ByVal value As String)
            _anio = value
        End Set
    End Property

    Public Property usuariomodificador() As String
        Get
            Return _usuariomodificador
        End Get
        Set(ByVal value As String)
            _usuariomodificador = value
        End Set
    End Property

    Public Property origen() As String
        Get
            Return _origen
        End Get
        Set(ByVal value As String)
            _origen = value
        End Set
    End Property

    Public Property estado() As String
        Get
            Return _estado
        End Get
        Set(ByVal value As String)
            _estado = value
        End Set
    End Property

#End Region

#Region "Poliza Det"

    Private _id_poliza As Integer
    Private _id_cuenta As Integer
    Private _cargo As Decimal
    Private _abono As Decimal
    Private _desc_asiento As String

    Public Property id_poliza() As Integer
        Get
            Return _id_poliza
        End Get
        Set(ByVal value As Integer)
            _id_poliza = value
        End Set
    End Property

    Public Property id_cuenta() As Integer
        Get
            Return _id_cuenta
        End Get
        Set(ByVal value As Integer)
            _id_cuenta = value
        End Set
    End Property

    Public Property abono() As Decimal
        Get
            Return _abono
        End Get
        Set(ByVal value As Decimal)
            _abono = value
        End Set
    End Property

    Public Property cargo() As Decimal
        Get
            Return _cargo
        End Get
        Set(ByVal value As Decimal)
            _cargo = value
        End Set
    End Property

    Public Property desc_asiento() As String
        Get
            Return _desc_asiento
        End Get
        Set(ByVal value As String)
            _desc_asiento = value
        End Set
    End Property

#End Region

#End Region

#Region "XML"
#Region "CABECERA"
    Private _serie_t As String = ""
    Private _folio_t As String = ""
    Private _fecha As String = ""
    Private _rfc_r As String = ""
    Private _nombre_r As String = ""
    Private _rfc_e As String = ""
    Private _nombre_e As String = ""
    Private _tipo_cambio As Decimal = 0
    Private _moneda As String = ""
    Private _uso_cfdi As String = ""
    Private _sub_t As Decimal = 0
    Private _total_t As Decimal = 0
    Private _descuento_g As Decimal = 0
    Private _uuid As String = ""
    Private _cert As String = ""
    Private _certsat As String = ""
    Private _fechacert As String = ""
    Private _cfdi As String = ""
    Private _sellosat As String = ""
    Private _cadena As String = ""
    Private _estatus As String = ""
    Private _condicion As String = ""
    Private _forma As String = ""
    Private _decimales As Decimal = 0
    Private _rfc_prov_certif As String = ""
    Private _no_certif_sat As String = ""
    Private _base_datos As String = ""
    Private _version As String = ""
    Private _config As String = ""

    Public Property serie_t() As String
        Get
            Return _serie_t
        End Get
        Set(ByVal value As String)
            _serie_t = value
        End Set
    End Property

    Public Property folio_t() As String
        Get
            Return _folio_t
        End Get
        Set(ByVal value As String)
            _folio_t = value
        End Set
    End Property

    Public Property fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property rfc_r() As String
        Get
            Return _rfc_r
        End Get
        Set(ByVal value As String)
            _rfc_r = value
        End Set
    End Property

    Public Property nombre_r() As String
        Get
            Return _nombre_r
        End Get
        Set(ByVal value As String)
            _nombre_r = value
        End Set
    End Property

    Public Property rfc_e() As String
        Get
            Return _rfc_e
        End Get
        Set(ByVal value As String)
            _rfc_e = value
        End Set
    End Property

    Public Property nombre_e() As String
        Get
            Return _nombre_e
        End Get
        Set(ByVal value As String)
            _nombre_e = value
        End Set
    End Property

    Public Property tipo_cambio() As Decimal
        Get
            Return _tipo_cambio
        End Get
        Set(ByVal value As Decimal)
            _tipo_cambio = value
        End Set
    End Property

    Public Property moneda() As String
        Get
            Return _moneda
        End Get
        Set(ByVal value As String)
            _moneda = value
        End Set
    End Property

    Public Property uso_cfdi() As String
        Get
            Return _uso_cfdi
        End Get
        Set(ByVal value As String)
            _uso_cfdi = value
        End Set
    End Property

    Public Property sub_t() As Decimal
        Get
            Return _sub_t
        End Get
        Set(ByVal value As Decimal)
            _sub_t = value
        End Set
    End Property

    Public Property total_t() As Decimal
        Get
            Return _total_t
        End Get
        Set(ByVal value As Decimal)
            _total_t = value
        End Set
    End Property

    Public Property descuento_g() As Decimal
        Get
            Return _descuento_g
        End Get
        Set(ByVal value As Decimal)
            _descuento_g = value
        End Set
    End Property

    Public Property uuid() As String
        Get
            Return _uuid
        End Get
        Set(ByVal value As String)
            _uuid = value
        End Set
    End Property

    Public Property cert() As String
        Get
            Return _cert
        End Get
        Set(ByVal value As String)
            _cert = value
        End Set
    End Property

    Public Property certsat() As String
        Get
            Return _certsat
        End Get
        Set(ByVal value As String)
            _certsat = value
        End Set
    End Property

    Public Property fechacert() As String
        Get
            Return _fechacert
        End Get
        Set(ByVal value As String)
            _fechacert = value
        End Set
    End Property

    Public Property cfdi() As String
        Get
            Return _cfdi
        End Get
        Set(ByVal value As String)
            _cfdi = value
        End Set
    End Property

    Public Property sellosat() As String
        Get
            Return _sellosat
        End Get
        Set(ByVal value As String)
            _sellosat = value
        End Set
    End Property

    Public Property cadena() As String
        Get
            Return _cadena
        End Get
        Set(ByVal value As String)
            _cadena = value
        End Set
    End Property

    Public Property estatus() As String
        Get
            Return _estatus
        End Get
        Set(ByVal value As String)
            _estatus = value
        End Set
    End Property

    Public Property condicion() As String
        Get
            Return _condicion
        End Get
        Set(ByVal value As String)
            _condicion = value
        End Set
    End Property

    Public Property forma() As String
        Get
            Return _forma
        End Get
        Set(ByVal value As String)
            _forma = value
        End Set
    End Property

    Public Property decimales() As Decimal
        Get
            Return _decimales
        End Get
        Set(ByVal value As Decimal)
            _decimales = value
        End Set
    End Property

    Public Property rfc_prov_certif() As String
        Get
            Return _rfc_prov_certif
        End Get
        Set(ByVal value As String)
            _rfc_prov_certif = value
        End Set
    End Property

    Public Property no_certif_sat() As String
        Get
            Return _no_certif_sat
        End Get
        Set(ByVal value As String)
            _no_certif_sat = value
        End Set
    End Property

    Public Property base_datos() As String
        Get
            Return _base_datos
        End Get
        Set(ByVal value As String)
            _base_datos = value
        End Set
    End Property

    Public Property version() As String
        Get
            Return _version
        End Get
        Set(ByVal value As String)
            _version = value
        End Set
    End Property

    Public Property config() As String
        Get
            Return _config
        End Get
        Set(ByVal value As String)
            _config = value
        End Set
    End Property
#End Region

#Region "DETALLE"
    Private _id_factura As Decimal = 0
    Private _id_art As Decimal = 0
    Private _id_almacen As Decimal = 0
    Private _item As Decimal = 0
    Private _cantidad As Decimal = 0
    Private _importe_unit As Decimal = 0
    Private _precio_unit As Decimal = 0
    Private _importe_tot As Decimal = 0
    Private _precio_tot As Decimal = 0
    Private _iva As String = "0.00"
    Private _impuesto_iva As String = "-"
    Private _tasa_iva As String = "-"
    Private _tipo_iva As String = "-"
    Private _ieps As String = "0.00"
    Private _impuesto_ieps As String = "-"
    Private _tipo_ieps As String = "-"
    Private _tasa_ieps As String = "-"
    Private _isr As String = "0.00"
    Private _impuesto_isr As String = "-"
    Private _tipo_isr As String = "-"
    Private _tasa_isr As String = "-"
    Private _iva_ret As String = "0.00"
    Private _impuesto_iva_ret As String = "-"
    Private _tipo_iva_ret As String = "-"
    Private _tasa_iva_ret As String = "-"
    Private _almacenable As String = "SI"
    Private _descuento As Decimal = 0
    Private _importe_ieps As Decimal = 0
    Private _notas As String = ""
    Private _notas_f As String = ""


    Public Property id_factura() As Decimal
        Get
            Return _id_factura
        End Get
        Set(ByVal value As Decimal)
            _id_factura = value
        End Set
    End Property

    Public Property id_art() As Decimal
        Get
            Return _id_art
        End Get
        Set(ByVal value As Decimal)
            _id_art = value
        End Set
    End Property

    Public Property item() As Decimal
        Get
            Return _item
        End Get
        Set(ByVal value As Decimal)
            _item = value
        End Set
    End Property

    Public Property id_almacen() As Decimal
        Get
            Return _id_almacen
        End Get
        Set(ByVal value As Decimal)
            _id_almacen = value
        End Set
    End Property

    Public Property cantidad() As Decimal
        Get
            Return _cantidad
        End Get
        Set(ByVal value As Decimal)
            _cantidad = value
        End Set
    End Property

    Public Property importe_unit() As Decimal
        Get
            Return _importe_unit
        End Get
        Set(ByVal value As Decimal)
            _importe_unit = value
        End Set
    End Property

    Public Property precio_unit() As Decimal
        Get
            Return _precio_unit
        End Get
        Set(ByVal value As Decimal)
            _precio_unit = value
        End Set
    End Property

    Public Property importe_tot() As Decimal
        Get
            Return _importe_tot
        End Get
        Set(ByVal value As Decimal)
            _importe_tot = value
        End Set
    End Property

    Public Property precio_tot() As Decimal
        Get
            Return _precio_tot
        End Get
        Set(ByVal value As Decimal)
            _precio_tot = value
        End Set
    End Property

    Public Property iva() As String
        Get
            Return _iva
        End Get
        Set(ByVal value As String)
            _iva = value
        End Set
    End Property

    Public Property impuesto_iva() As String
        Get
            Return _impuesto_iva
        End Get
        Set(ByVal value As String)
            _impuesto_iva = value
        End Set
    End Property

    Public Property tasa_iva() As String
        Get
            Return _tasa_iva
        End Get
        Set(ByVal value As String)
            _tasa_iva = value
        End Set
    End Property

    Public Property tipo_iva() As String
        Get
            Return _tipo_iva
        End Get
        Set(ByVal value As String)
            _tipo_iva = value
        End Set
    End Property

    Public Property ieps() As String
        Get
            Return _ieps
        End Get
        Set(ByVal value As String)
            _ieps = value
        End Set
    End Property

    Public Property impuesto_ieps() As String
        Get
            Return _impuesto_ieps
        End Get
        Set(ByVal value As String)
            _impuesto_ieps = value
        End Set
    End Property

    Public Property tipo_ieps() As String
        Get
            Return _tipo_ieps
        End Get
        Set(ByVal value As String)
            _tipo_ieps = value
        End Set
    End Property

    Public Property tasa_ieps() As String
        Get
            Return _tasa_ieps
        End Get
        Set(ByVal value As String)
            _tasa_ieps = value
        End Set
    End Property

    Public Property isr() As String
        Get
            Return _isr
        End Get
        Set(ByVal value As String)
            _isr = value
        End Set
    End Property

    Public Property impuesto_isr() As String
        Get
            Return _impuesto_isr
        End Get
        Set(ByVal value As String)
            _impuesto_isr = value
        End Set
    End Property

    Public Property tipo_isr() As String
        Get
            Return _tipo_isr
        End Get
        Set(ByVal value As String)
            _tipo_isr = value
        End Set
    End Property

    Public Property tasa_isr() As String
        Get
            Return _tasa_isr
        End Get
        Set(ByVal value As String)
            _tasa_isr = value
        End Set
    End Property

    Public Property iva_ret() As String
        Get
            Return _iva_ret
        End Get
        Set(ByVal value As String)
            _iva_ret = value
        End Set
    End Property

    Public Property impuesto_iva_ret() As String
        Get
            Return _impuesto_iva_ret
        End Get
        Set(ByVal value As String)
            _impuesto_iva_ret = value
        End Set
    End Property

    Public Property tipo_iva_ret() As String
        Get
            Return _tipo_iva_ret
        End Get
        Set(ByVal value As String)
            _tipo_iva_ret = value
        End Set
    End Property

    Public Property tasa_iva_ret() As String
        Get
            Return _tasa_iva_ret
        End Get
        Set(ByVal value As String)
            _tasa_iva_ret = value
        End Set
    End Property

    Public Property almacenable() As String
        Get
            Return _almacenable
        End Get
        Set(ByVal value As String)
            _almacenable = value
        End Set
    End Property

    Public Property descuento() As Decimal
        Get
            Return _descuento
        End Get
        Set(ByVal value As Decimal)
            _descuento = value
        End Set
    End Property

    Public Property importe_ieps() As Decimal
        Get
            Return _importe_ieps
        End Get
        Set(ByVal value As Decimal)
            _importe_ieps = value
        End Set
    End Property

    Public Property notas() As String
        Get
            Return _notas
        End Get
        Set(ByVal value As String)
            _notas = value
        End Set
    End Property

    Public Property notas_f() As String
        Get
            Return _notas_f
        End Get
        Set(ByVal value As String)
            _notas_f = value
        End Set
    End Property
#End Region

#Region "ARTICULOS"
    Private _clave As String = ""
    Private _clave_sat As String = ""
    Private _descripcion As String = ""
    Private _u_med_v As String = ""
    Private _u_med_c As String = ""
    Private _u_med_sat As String = ""
    Private _descripcion_sat As String = ""
    Private _cant_vent As Decimal = 1.0
    Private _importe_c As Decimal = 1.0
    Private _importe_v As Decimal = 1.0
    Private _facturable As String = "SI"
    Private _linea As String = ""
    Private _marca As String = ""
    Private _importado_c As String = "NO"

    Public Property clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property clave_sat() As String
        Get
            Return _clave_sat
        End Get
        Set(ByVal value As String)
            _clave_sat = value
        End Set
    End Property

    Public Property descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property u_med_v() As String
        Get
            Return _u_med_v
        End Get
        Set(ByVal value As String)
            _u_med_v = value
        End Set
    End Property

    Public Property u_med_c() As String
        Get
            Return _u_med_c
        End Get
        Set(ByVal value As String)
            _u_med_c = value
        End Set
    End Property

    Public Property u_med_sat() As String
        Get
            Return _u_med_sat
        End Get
        Set(ByVal value As String)
            _u_med_sat = value
        End Set
    End Property

    Public Property descripcion_sat() As String
        Get
            Return _descripcion_sat
        End Get
        Set(ByVal value As String)
            _descripcion_sat = value
        End Set
    End Property

    Public Property cant_vent() As Decimal
        Get
            Return _cant_vent
        End Get
        Set(ByVal value As Decimal)
            _cant_vent = value
        End Set
    End Property

    Public Property importe_c() As Decimal
        Get
            Return _importe_c
        End Get
        Set(ByVal value As Decimal)
            _importe_c = value
        End Set
    End Property

    Public Property importe_v() As Decimal
        Get
            Return _importe_v
        End Get
        Set(ByVal value As Decimal)
            _importe_v = value
        End Set
    End Property

    Public Property facturable() As String
        Get
            Return _facturable
        End Get
        Set(ByVal value As String)
            _facturable = value
        End Set
    End Property

    Public Property linea() As String
        Get
            Return _linea
        End Get
        Set(ByVal value As String)
            _linea = value
        End Set
    End Property

    Public Property marca() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property

    Public Property importado_c() As String
        Get
            Return _importado_c
        End Get
        Set(ByVal value As String)
            _importado_c = value
        End Set
    End Property
#End Region

#Region "IMPUESTOS"
    Dim _impuesto As String = ""
    Dim _calculo As String = ""
    Dim _tasa As String = 0
    Dim _unidades As Decimal = 0
    Dim _total As Decimal = 0
    Dim _importe As Decimal = 0
    Dim _tabla As String = ""

    Public Property impuesto() As String
        Get
            Return _impuesto
        End Get
        Set(ByVal value As String)
            _impuesto = value
        End Set
    End Property

    Public Property calculo() As String
        Get
            Return _calculo
        End Get
        Set(ByVal value As String)
            _calculo = value
        End Set
    End Property

    Public Property tasa() As String
        Get
            Return _tasa
        End Get
        Set(ByVal value As String)
            _tasa = value
        End Set
    End Property

    Public Property unidades() As Decimal
        Get
            Return _unidades
        End Get
        Set(ByVal value As Decimal)
            _unidades = value
        End Set
    End Property

    Public Property total() As Decimal
        Get
            Return _total
        End Get
        Set(ByVal value As Decimal)
            _total = value
        End Set
    End Property

    Public Property importe() As Decimal
        Get
            Return _importe
        End Get
        Set(ByVal value As Decimal)
            _importe = value
        End Set
    End Property

    Public Property tabla() As String
        Get
            Return _tabla
        End Get
        Set(ByVal value As String)
            _tabla = value
        End Set
    End Property
#End Region

#Region "NOMINA"
#Region "DATOS GENERALES"
    Private _fecha_pago As Date
    Private _fecha_inicial_p As Date
    Private _fecha_final_p As Date
    Private _num_dias_pagados As String = ""
    Private _tipo_nomina As String = ""
    Private _total_percepciones As Decimal = 0.0
    Private _total_deducciones As Decimal = 0.0
    Private _total_otros_pagos As Decimal = 0.0
    Private _e_curp As String = ""
    Private _e_registro_patronal As String = ""
    Private _e_rfc_patron_origen As String = ""
    Private _r_curp As String = ""
    Private _r_num_seguridad_social As String = ""
    Private _r_fecha_i_laborar As Date
    Private _r_antiguedad As String = ""
    Private _r_tipo_contrato As String = ""
    Private _r_sindicalizado As String = ""
    Private _r_tipo_jornada As String = ""
    Private _r_tipo_regimen As String = ""
    Private _r_num_empleado As String = ""
    Private _r_departamento As String = ""
    Private _r_puesto As String = ""
    Private _r_riesgo As String = ""
    Private _r_periodicidad As String = ""
    Private _r_banco As String = ""
    Private _r_cuenta_bancaria As String = ""
    Private _r_salario_base As String = ""
    Private _r_salario_diario As String = ""
    Private _r_clave_ent_f As String

    Public Property fecha_pago() As Date
        Get
            Return _fecha_pago
        End Get
        Set(ByVal value As Date)
            _fecha_pago = value
        End Set
    End Property

    Public Property fecha_inicial_p() As Date
        Get
            Return _fecha_inicial_p
        End Get
        Set(ByVal value As Date)
            _fecha_inicial_p = value
        End Set
    End Property

    Public Property fecha_final_p() As Date
        Get
            Return _fecha_final_p
        End Get
        Set(ByVal value As Date)
            _fecha_final_p = value
        End Set
    End Property

    Public Property tipo_nomina() As String
        Get
            Return _tipo_nomina
        End Get
        Set(ByVal value As String)
            _tipo_nomina = value
        End Set
    End Property

    Public Property num_dias_pagados() As String
        Get
            Return _num_dias_pagados
        End Get
        Set(ByVal value As String)
            _num_dias_pagados = value
        End Set
    End Property

    Public Property total_percepciones() As Decimal
        Get
            Return _total_percepciones
        End Get
        Set(ByVal value As Decimal)
            _total_percepciones = value
        End Set
    End Property

    Public Property total_deducciones() As Decimal
        Get
            Return _total_deducciones
        End Get
        Set(ByVal value As Decimal)
            _total_deducciones = value
        End Set
    End Property

    Public Property total_otros_pagos() As Decimal
        Get
            Return _total_otros_pagos
        End Get
        Set(ByVal value As Decimal)
            _total_otros_pagos = value
        End Set
    End Property

    Public Property e_curp() As String
        Get
            Return _e_curp
        End Get
        Set(ByVal value As String)
            _e_curp = value
        End Set
    End Property

    Public Property e_registro_patronal() As String
        Get
            Return _e_registro_patronal
        End Get
        Set(ByVal value As String)
            _e_registro_patronal = value
        End Set
    End Property

    Public Property e_rfc_patron_origen() As String
        Get
            Return _e_rfc_patron_origen
        End Get
        Set(ByVal value As String)
            _e_rfc_patron_origen = value
        End Set
    End Property

    Public Property r_curp() As String
        Get
            Return _r_curp
        End Get
        Set(ByVal value As String)
            _r_curp = value
        End Set
    End Property

    Public Property r_fecha_i_laborar() As Date
        Get
            Return _r_fecha_i_laborar
        End Get
        Set(ByVal value As Date)
            _r_fecha_i_laborar = value
        End Set
    End Property

    Public Property r_num_seguridad_social() As String
        Get
            Return _r_num_seguridad_social
        End Get
        Set(ByVal value As String)
            _r_num_seguridad_social = value
        End Set
    End Property

    Public Property r_antiguedad() As String
        Get
            Return _r_antiguedad
        End Get
        Set(ByVal value As String)
            _r_antiguedad = value
        End Set
    End Property

    Public Property r_tipo_contrato() As String
        Get
            Return _r_tipo_contrato
        End Get
        Set(ByVal value As String)
            _r_tipo_contrato = value
        End Set
    End Property

    Public Property r_sindicalizado() As String
        Get
            Return _r_sindicalizado
        End Get
        Set(ByVal value As String)
            _r_sindicalizado = value
        End Set
    End Property

    Public Property r_tipo_jornada() As String
        Get
            Return _r_tipo_jornada
        End Get
        Set(ByVal value As String)
            _r_tipo_jornada = value
        End Set
    End Property

    Public Property r_tipo_regimen() As String
        Get
            Return _r_tipo_regimen
        End Get
        Set(ByVal value As String)
            _r_tipo_regimen = value
        End Set
    End Property

    Public Property r_num_empleado() As String
        Get
            Return _r_num_empleado
        End Get
        Set(ByVal value As String)
            _r_num_empleado = value
        End Set
    End Property

    Public Property r_departamento() As String
        Get
            Return _r_departamento
        End Get
        Set(ByVal value As String)
            _r_departamento = value
        End Set
    End Property

    Public Property r_puesto() As String
        Get
            Return _r_puesto
        End Get
        Set(ByVal value As String)
            _r_puesto = value
        End Set
    End Property

    Public Property r_riesgo() As String
        Get
            Return _r_riesgo
        End Get
        Set(ByVal value As String)
            _r_riesgo = value
        End Set
    End Property

    Public Property r_periodicidad() As String
        Get
            Return _r_periodicidad
        End Get
        Set(ByVal value As String)
            _r_periodicidad = value
        End Set
    End Property

    Public Property r_banco() As String
        Get
            Return _r_banco
        End Get
        Set(ByVal value As String)
            _r_banco = value
        End Set
    End Property

    Public Property r_cuenta_bancaria() As String
        Get
            Return _r_cuenta_bancaria
        End Get
        Set(ByVal value As String)
            _r_cuenta_bancaria = value
        End Set
    End Property

    Public Property r_salario_base() As String
        Get
            Return _r_salario_base
        End Get
        Set(ByVal value As String)
            _r_salario_base = value
        End Set
    End Property

    Public Property r_salario_diario() As String
        Get
            Return _r_salario_diario
        End Get
        Set(ByVal value As String)
            _r_salario_diario = value
        End Set
    End Property

    Public Property r_clave_ent_f() As String
        Get
            Return _r_clave_ent_f
        End Get
        Set(ByVal value As String)
            _r_clave_ent_f = value
        End Set
    End Property
#End Region

#Region "DEDUCCIONES"
    Private _concepto As String = ""

    Public Property concepto() As String
        Get
            Return _concepto
        End Get
        Set(ByVal value As String)
            _concepto = value
        End Set
    End Property
#End Region

#Region "INCAPACIDAD"
    Private _dias As String

    Public Property dias() As String
        Get
            Return _dias
        End Get
        Set(ByVal value As String)
            _dias = value
        End Set
    End Property
#End Region

#Region "OTROS PAGOS"
    Private _sae_subs_c As Decimal = 0
    Private _csa_anio As String = ""
    Private _csa_saldo_f As Decimal = 0
    Private _csa_rem_sf As Decimal = 0

    Public Property csa_anio() As String
        Get
            Return _csa_anio
        End Get
        Set(ByVal value As String)
            _csa_anio = value
        End Set
    End Property

    Public Property sae_subs_c() As Decimal
        Get
            Return _sae_subs_c
        End Get
        Set(ByVal value As Decimal)
            _sae_subs_c = value
        End Set
    End Property

    Public Property csa_saldo_f() As Decimal
        Get
            Return _csa_saldo_f
        End Get
        Set(ByVal value As Decimal)
            _csa_saldo_f = value
        End Set
    End Property

    Public Property csa_rem_sf() As Decimal
        Get
            Return _csa_rem_sf
        End Get
        Set(ByVal value As Decimal)
            _csa_rem_sf = value
        End Set
    End Property
#End Region

#Region "PERCEPCIONES"
    Private _importe_gravado As Decimal = 0
    Private _importe_exento As Decimal = 0
    Private _aot_valor_mercado As Decimal = 0
    Private _aot_precio_otorgado As Decimal = 0
    Private _he_dias As String = ""
    Private _he_tipo_hora As String = ""
    Private _he_horas_extra As String = ""
    Private _jpr_total_e As Decimal = 0
    Private _jpr_total_p As Decimal = 0
    Private _jpr_monto_diario As Decimal = 0
    Private _jpr_ingreso_acum As Decimal = 0
    Private _jpr_ingreso_n_acum As Decimal = 0
    Private _si_total_p As Decimal = 0
    Private _si_num_a_s As String = ""
    Private _si_usmo As Decimal = 0
    Private _si_ing_a As Decimal = 0
    Private _si_ing_n_a As Decimal = 0

    Public Property importe_gravado() As Decimal
        Get
            Return _importe_gravado
        End Get
        Set(ByVal value As Decimal)
            _importe_gravado = value
        End Set
    End Property

    Public Property importe_exento() As Decimal
        Get
            Return _importe_exento
        End Get
        Set(ByVal value As Decimal)
            _importe_exento = value
        End Set
    End Property

    Public Property aot_valor_mercado() As Decimal
        Get
            Return _aot_valor_mercado
        End Get
        Set(ByVal value As Decimal)
            _aot_valor_mercado = value

        End Set
    End Property

    Public Property aot_precio_otorgado() As Decimal
        Get
            Return _aot_precio_otorgado
        End Get
        Set(ByVal value As Decimal)
            _aot_precio_otorgado = value

        End Set
    End Property

    Public Property jpr_total_e() As Decimal
        Get
            Return _jpr_total_e
        End Get
        Set(ByVal value As Decimal)
            _jpr_total_e = value

        End Set
    End Property

    Public Property jpr_total_p() As Decimal
        Get
            Return _jpr_total_p
        End Get
        Set(ByVal value As Decimal)
            _jpr_total_p = value
        End Set
    End Property

    Public Property jpr_monto_diario() As Decimal
        Get
            Return _jpr_monto_diario
        End Get
        Set(ByVal value As Decimal)
            _jpr_monto_diario = value
        End Set
    End Property

    Public Property jpr_ingreso_acum() As Decimal
        Get
            Return _jpr_ingreso_acum
        End Get
        Set(ByVal value As Decimal)
            _jpr_ingreso_acum = value
        End Set
    End Property

    Public Property jpr_ingreso_n_acum() As Decimal
        Get
            Return _jpr_ingreso_n_acum
        End Get
        Set(ByVal value As Decimal)
            _jpr_ingreso_n_acum = value
        End Set
    End Property

    Public Property si_total_p() As Decimal
        Get
            Return _si_total_p
        End Get
        Set(ByVal value As Decimal)
            _si_total_p = value
        End Set
    End Property

    Public Property si_usmo() As Decimal
        Get
            Return _si_usmo
        End Get
        Set(ByVal value As Decimal)
            _si_usmo = value
        End Set
    End Property

    Public Property si_ing_a() As Decimal
        Get
            Return _si_ing_a
        End Get
        Set(ByVal value As Decimal)
            _si_ing_a = value
        End Set
    End Property

    Public Property si_ing_n_a() As Decimal
        Get
            Return _si_ing_n_a
        End Get
        Set(ByVal value As Decimal)
            _si_ing_n_a = value
        End Set
    End Property

    Public Property he_dias() As String
        Get
            Return _he_dias
        End Get
        Set(ByVal value As String)
            _he_dias = value
        End Set
    End Property

    Public Property he_tipo_hora() As String
        Get
            Return _he_tipo_hora
        End Get
        Set(ByVal value As String)
            _he_tipo_hora = value
        End Set
    End Property

    Public Property he_horas_extra() As String
        Get
            Return _he_horas_extra
        End Get
        Set(ByVal value As String)
            _he_horas_extra = value
        End Set
    End Property

    Public Property si_num_a_s() As String
        Get
            Return _si_num_a_s
        End Get
        Set(ByVal value As String)
            _si_num_a_s = value
        End Set
    End Property
#End Region
#End Region
#End Region


#Region "Transferencia"

    Private _id_cuentaemi As String
    Private _id_cuentarec As String


    Public Property id_cuentaemi() As Integer
        Get
            Return _id_cuentaemi
        End Get
        Set(ByVal value As Integer)
            _id_cuentaemi = value
        End Set
    End Property

    Public Property id_cuentarec() As Integer
        Get
            Return _id_cuentarec
        End Get
        Set(ByVal value As Integer)
            _id_cuentarec = value
        End Set
    End Property


#End Region

End Class
