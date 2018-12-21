Public Class class_datos
    Private _uuid As String = ""
    Private _razonsocialemisor As String = ""
    Private _folio As String = ""
    Private _fechaemision As String = ""
    Private _total As Decimal
    Private _contrato As String = ""
    Private _partidafinal As String
    Private _fondo As String = ""
    Private _programa As String = ""
    Private _unidadr As String = ""
    Private _partidae As String = ""
    Private _partida As String = ""
    Private _ntipo As String = ""
    Private _cuenta As String = ""
    Private _id As Integer

    Private _parte As Decimal
    Private _tipo_poliza As String = ""
    Private _fecha As DateTime
    Private _fecha2 As DateTime
    Private _fecha3 As DateTime
    Private _N_poliza As Integer
    Private _descripcion As String = ""
    Private _descripciona As String = ""
    Private _total_cargo As Decimal
    Private _total_abono As Decimal
    Private _id_polizas As Integer
    Private _numero_cuenta As String = ""
    Private _nombre_cuenta As String = ""

    Private _rfc As String = ""
    Private _clave As String = ""
    Private _calle As String = ""
    Private _nexte As String = ""
    Private _nint As String = ""
    Private _cp As String = ""
    Private _correo As String = ""
    Private _numero As String = ""
    Private _cel As String = ""
    Private _colonia As String = ""
    Private _ciudad As String = ""
    Private _estado As String
    Private _pais As String = ""
    Private _orden As String = ""
    Private _nombre As String = ""
    Private _departamento As String = ""
    Private _hos As String = ""
    Private _puert As Int64


    Public Property departamento() As String
        Get
            Return _departamento
        End Get
        Set(ByVal value As String)
            _departamento = value
        End Set
    End Property

    Public Property nombre() As String
        Get
            Return _nombre
        End Get
        Set(ByVal value As String)
            _nombre = value
        End Set
    End Property

    Public Property parte() As Decimal
        Get
            Return _parte
        End Get
        Set(ByVal value As Decimal)
            _parte = value
        End Set
    End Property

    Public Property orden() As String
        Get
            Return _orden
        End Get
        Set(ByVal value As String)
            _orden = value
        End Set
    End Property

    Public Property colonia() As String
        Get
            Return _colonia
        End Get
        Set(ByVal value As String)
            _colonia = value
        End Set
    End Property

    Public Property ciudad() As String
        Get
            Return _ciudad
        End Get
        Set(ByVal value As String)
            _ciudad = value
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

    Public Property pais() As String
        Get
            Return _pais
        End Get
        Set(ByVal value As String)
            _pais = value
        End Set
    End Property

    Public Property cp() As String
        Get
            Return _cp
        End Get
        Set(ByVal value As String)
            _cp = value
        End Set
    End Property

    Public Property correo() As String
        Get
            Return _correo
        End Get
        Set(ByVal value As String)
            _correo = value
        End Set
    End Property

    Public Property numero() As String
        Get
            Return _numero
        End Get
        Set(ByVal value As String)
            _numero = value
        End Set
    End Property

    Public Property cel() As String
        Get
            Return _cel
        End Get
        Set(ByVal value As String)
            _cel = value
        End Set
    End Property

    Public Property calle() As String
        Get
            Return _calle
        End Get
        Set(ByVal value As String)
            _calle = value
        End Set
    End Property

    Public Property Nexte() As String
        Get
            Return _nexte
        End Get
        Set(ByVal value As String)
            _nexte = value
        End Set
    End Property

    Public Property nint() As String
        Get
            Return _nint
        End Get
        Set(ByVal value As String)
            _nint = value
        End Set
    End Property

    Public Property clave() As String
        Get
            Return _clave
        End Get
        Set(ByVal value As String)
            _clave = value
        End Set
    End Property

    Public Property rfc() As String
        Get
            Return _rfc
        End Get
        Set(ByVal value As String)
            _rfc = value
        End Set
    End Property

    Public Property fecha3() As DateTime
        Get
            Return _fecha3
        End Get
        Set(ByVal value As DateTime)
            _fecha3 = value
        End Set
    End Property

    Public Property fecha2() As DateTime
        Get
            Return _fecha2
        End Get
        Set(ByVal value As DateTime)
            _fecha2 = value
        End Set
    End Property

    Public Property cuenta() As String
        Get
            Return _cuenta
        End Get
        Set(ByVal value As String)
            _cuenta = value
        End Set
    End Property

    Public Property id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property ntipo() As String
        Get
            Return _ntipo
        End Get
        Set(ByVal value As String)
            _ntipo = value
        End Set
    End Property

    Public Property fondo() As String
        Get
            Return _fondo
        End Get
        Set(ByVal value As String)
            _fondo = value
        End Set
    End Property

    Public Property programa() As String
        Get
            Return _programa
        End Get
        Set(ByVal value As String)
            _programa = value
        End Set
    End Property

    Public Property unidadr() As String
        Get
            Return _unidadr
        End Get
        Set(ByVal value As String)
            _unidadr = value
        End Set
    End Property

    Public Property partidae() As String
        Get
            Return _partidae
        End Get
        Set(ByVal value As String)
            _partidae = value
        End Set
    End Property

    Public Property partida() As String
        Get
            Return _partida
        End Get
        Set(ByVal value As String)
            _partida = value
        End Set
    End Property

    Public Property partidafinal() As String
        Get
            Return _partidafinal
        End Get
        Set(ByVal value As String)
            _partidafinal = value
        End Set
    End Property

    Public Property contrato() As String
        Get
            Return _contrato
        End Get
        Set(ByVal value As String)
            _contrato = value
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

    Public Property razonsocialemisor() As String
        Get
            Return _razonsocialemisor
        End Get
        Set(ByVal value As String)
            _razonsocialemisor = value
        End Set
    End Property

    Public Property folio() As String
        Get
            Return _folio
        End Get
        Set(ByVal value As String)
            _folio = value
        End Set
    End Property

    Public Property fechaemision() As String
        Get
            Return _fechaemision
        End Get
        Set(ByVal value As String)
            _fechaemision = value
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

    Public Property id_polizas() As Integer
        Get
            Return _id_polizas
        End Get
        Set(ByVal value As Integer)
            _id_polizas = value
        End Set
    End Property

    Public Property total_cargo() As Decimal
        Get
            Return _total_cargo
        End Get
        Set(ByVal value As Decimal)
            _total_cargo = value
        End Set
    End Property

    Public Property total_abono() As Decimal
        Get
            Return _total_abono
        End Get
        Set(ByVal value As Decimal)
            _total_abono = value
        End Set
    End Property

    Public Property fecha() As DateTime
        Get
            Return _fecha
        End Get
        Set(ByVal value As DateTime)
            _fecha = value
        End Set
    End Property

    Public Property N_poliza() As Integer
        Get
            Return _N_poliza
        End Get
        Set(ByVal value As Integer)
            _N_poliza = value
        End Set
    End Property

    Public Property descripciona() As String
        Get
            Return _descripciona
        End Get
        Set(ByVal value As String)
            _descripciona = value
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

    Public Property tipo_poliza() As String
        Get
            Return _tipo_poliza
        End Get
        Set(ByVal value As String)
            _tipo_poliza = value
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

    Public Property hos() As String
        Get
            Return _hos
        End Get
        Set(ByVal value As String)
            _hos = value
        End Set
    End Property

    Public Property puert() As Int64
        Get
            Return _puert
        End Get
        Set(ByVal value As Int64)
            _puert = value
        End Set
    End Property
End Class
