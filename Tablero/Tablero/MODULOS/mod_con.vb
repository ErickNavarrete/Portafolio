Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module mod_con
    'Importamos las referencias necesarias para trabajar con mysql
    Public _cadenaSI As String
    Public _conexionSI As New MySqlConnection

    'Función para abrir la conexión
    Public Function conexion_GlobalSI() As Boolean
        'Función para guardar el estado de la conexión
        Dim estadosi As Boolean = True
        'Conversión de variables globales a locales
        'Dim ipSI As String = "localhost" 'dmm
        'Dim ipSI As String = "192.168.1.6"
        Dim ipSI As String = "ave-la.dynns.com"
        Dim usersi As String = "root"
        Dim passsi As String = "ZMalqp10"
        Dim database As String = "control_dmm"
        'Dim database As String = "cotizaciones_prueba"
        Try
            _cadenaSI = ("server= " & ipSI.Trim() & ";user id=" & usersi.Trim() & ";password=" & passsi.Trim() & ";database= " & database.Trim() & "")
            _conexionSI = New MySqlConnection(_cadenaSI)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "saldo inicial", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estadosi = False
        End Try
        Return estadosi
    End Function

    'Función para cerrar la conexión
    Public Sub cerrarSI()
        _conexionSI.Close()
    End Sub
End Module
