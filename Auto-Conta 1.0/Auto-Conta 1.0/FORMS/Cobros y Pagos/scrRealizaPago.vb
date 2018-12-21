Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrRealizaPago
    Public uuid As String = ""
    Public nombre As String = ""
    Public rfc As String = ""
    Public id_factura As Integer = 0
    Public tipo_ As String = ""

    Public Function get_num_parcialidad(ByVal uuid As String) As Integer
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim parcialidad As Integer = 1

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select count(uuid) from factura_pagos where uuid = '" & uuid & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                parcialidad = resultado.GetDecimal("count(uuid)") + 1
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return parcialidad
    End Function

    Private Sub btnPC_Click(sender As Object, e As EventArgs) Handles btnPC.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_insert

        Dim id_documento As String = ""
        Dim moneda_dr As String = ""
        Dim metodo_pago_dr As String = ""
        Dim num_parcialidad As Integer = 0
        Dim imp_pagado As Decimal = 0

        'DATOS CABECERA
        datos.serie_t = tbSerie.Text
        datos.folio_t = tbFolio.Text
        datos.fecha = dtpFP.Value.ToString("yyyy/MM/dd")
        If tipo_ = "EMITIDOS" Then
            datos.rfc_r = tbRFC.Text
            datos.nombre_r = tbNombre.Text
            datos.rfc_e = rfc
            datos.nombre_e = nombre
        Else
            datos.rfc_r = rfc
            datos.nombre_r = nombre
            datos.rfc_e = tbRFC.Text
            datos.nombre_e = tbNombre.Text
        End If
        datos.tipo_cambio = 0.0
        datos.moneda = "XXX"
        datos.uso_cfdi = "P01-Por definir"
        datos.sub_t = 0.0
        datos.total_t = 0.0
        datos.descuento_g = 0.0
        datos.uuid = tbUUID.Text
        datos.cert = ""
        datos.certsat = ""
        datos.fechacert = dtpFP.Value.ToString("yyyy/MM/dd")
        datos.cfdi = ""
        datos.sellosat = ""
        datos.cadena = ""
        datos.estatus = "Timbrado"
        datos.condicion = ""
        datos.forma = ""
        datos.decimales = 0.0
        datos.tipo = "P"
        datos.version = "3.3"

        If conexion.insert_factura(datos) Then
            'DATOS FACTURA PAGOS
            id_documento = uuid
            moneda_dr = "MXN"
            metodo_pago_dr = "PPD"
            imp_pagado = tbMonto.Text
            num_parcialidad = get_num_parcialidad(id_documento)

            'OBTENEMOS EL ÚLTIMO REGISTRO
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select * from factura ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_factura = resultado.GetInt64("id_timbrados")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'GUARDAMOS EL PAGO
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" insert into factura_pagos(id_factura,uuid,moneda,metodo_pago,num_parcialidad,importe_pagado) 
                                                        values ('" & id_factura & "', '" & id_documento & "', '" & moneda_dr & "', '" & metodo_pago_dr & "','" & num_parcialidad & "','" & imp_pagado & "') ", _conexion)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            create_poliza(id_factura, tipo_, "P", datos.fechacert, datos.total_t, datos.sub_t, datos.condicion, datos.serie_t & " - " & datos.folio_t)

            MessageBox.Show("Cobro realizado con éxito", "ContaGo Auto-Conta 1.0", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub tbTotal_DoubleClick(sender As Object, e As EventArgs) Handles tbTotal.DoubleClick
        tbMonto.Text = tbTotal.Text
    End Sub
End Class