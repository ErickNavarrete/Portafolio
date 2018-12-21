Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Module mod_Rutinas_Globales

    Public Sub Completa_cuenta(cuenta)
        Dim datos As New Class_datos

        If Len(cuenta) = 1 Then
            var_globales.ccontableunica = "000000000" & cuenta
        End If

        If Len(cuenta) = 2 Then
            var_globales.ccontableunica = "00000000" & cuenta
        End If

        If Len(cuenta) = 3 Then
            var_globales.ccontableunica = "0000000" & cuenta
        End If

        If Len(cuenta) = 4 Then
            var_globales.ccontableunica = "000000" & cuenta
        End If

        If Len(cuenta) = 5 Then
            var_globales.ccontableunica = "00000" & cuenta
        End If

        If Len(cuenta) = 6 Then
            var_globales.ccontableunica = "0000" & cuenta
        End If

        If Len(cuenta) = 7 Then
            var_globales.ccontableunica = "000" & cuenta
        End If

        If Len(cuenta) = 8 Then
            var_globales.ccontableunica = "00" & cuenta
        End If

        If Len(cuenta) = 9 Then
            var_globales.ccontableunica = "0" & cuenta
        End If

        If Len(cuenta) = 10 Then
            var_globales.ccontableunica = cuenta
        End If


    End Sub


    Public Sub mes(mes)
        If mes = "1" Then
            var_globales.mes = "Enero"
        End If

        If mes = "2" Then
            var_globales.mes = "Febrero"
        End If

        If mes = "3" Then
            var_globales.mes = "Marzo"
        End If

        If mes = "4" Then
            var_globales.mes = "Abril"
        End If

        If mes = "5" Then
            var_globales.mes = "Mayo"
        End If

        If mes = "6" Then
            var_globales.mes = "Junio"
        End If

        If mes = "7" Then
            var_globales.mes = "Julio"
        End If

        If mes = "8" Then
            var_globales.mes = "Agosto"
        End If

        If mes = "9" Then
            var_globales.mes = "Septiembre"
        End If

        If mes = "10" Then
            var_globales.mes = "Octubre"
        End If

        If mes = "11" Then
            var_globales.mes = "Noviembre"
        End If

        If mes = "12" Then
            var_globales.mes = "Diciembre"
        End If
    End Sub

End Module