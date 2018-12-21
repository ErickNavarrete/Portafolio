Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient


Module Mod_Conecction
    ''' 
    Public _cadena As String
    Public _conexion As New MySqlConnection

    ''' <summary>
    ''' Conecta a la base de datos MySql
    ''' </summary>
    ''' <returns>True or False</returns>
    ''' 
    Public Function Conexion_Global() As Boolean
        Dim estado As Boolean = True

        'Dim ip As String = Class_datos_altacuentascontables.ip
        Dim ip As String = var_globales.ip
        Dim user As String = "root"
        Dim pass As String = "ZMalqp10"
        Dim db As String = var_globales.base
        'MsgBox(Class_datos_altacuentascontables.ip)

        Try
            _cadena = ("server= " & ip.Trim() & ";user id=" & user.Trim() & ";password=" & pass.Trim() & ";database=" & db.Trim() & "")
            _conexion = New MySqlConnection(_cadena)
        Catch ex As MySqlException
            MessageBox.Show("Error: " & vbCrLf & ex.ToString, "Nombre de la App", MessageBoxButtons.OK, MessageBoxIcon.Error)
            estado = False
        End Try
        Return estado
    End Function

    ''' <summary>
    ''' Cierra la conexión a la base de datos MySql
    ''' </summary>
    ''' 
    Public Sub cerrar()
        _conexion.Close()
    End Sub

End Module
