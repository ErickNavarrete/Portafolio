Imports System.Xml
Imports System
Imports System.IO
Imports System.Text
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrCargaXML
    Dim cont_i As Integer = 0
    Dim cont_c As Integer = 0
    Dim cont_n As Integer = 0
    Dim num_f As Integer = 0
    Dim max As Integer = 0
    Dim band As Boolean = False

#Region "FUNCIONES"
#Region "CONCEPTOS"
    Public Sub nodo_conceptos(ByVal jsonObject As JObject)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken("cfdi:Concepto").Children().ToList
        Dim cont As Integer = 0

        Dim col As New DataGridViewTextBoxColumn
        col.Name = "CONT"
        dgvConceptos.Columns.Add(col)

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then
                dgvConceptos.Rows.Add(num_f.ToString)
                Dim jo As JObject = JObject.Parse(e.ToString)
                For Each prop As JProperty In jo.Properties()
                    If prop.Name.ToString.Substring(0, 4) = "cfdi" Then
                        nuevo_nodo_conceptos(jo, prop, cont)
                    Else
                        set_nodo_conceptos(prop.Name, cont, prop.Value)
                    End If
                Next
                cont = cont + 1
            Else
                If dgvConceptos.Rows.Count = 0 Then
                    dgvConceptos.Rows.Add(num_f.ToString)
                End If

                Dim h As JProperty = e
                If h.Name.ToString.Substring(0, 4) = "cfdi" Then
                    nuevo_nodo_conceptos(jsonObject.SelectToken("cfdi:Concepto"), h, cont)
                Else
                    set_nodo_conceptos(h.Name, cont, h.Value)
                End If
            End If
        Next

    End Sub

    Public Sub nuevo_nodo_conceptos(ByVal jsonObject As JObject, ByVal x As JProperty, ByVal cont As Integer)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken(x.Name).Children().ToList

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then
                cont_c = cont_c + 1
                Dim jo As JObject = JObject.Parse(e.ToString)
                For Each prop As JProperty In jo.Properties()
                    If prop.Name.ToString.Substring(0, 4) = "cfdi" Then
                        nuevo_nodo_conceptos(jo, prop, cont)
                    Else
                        set_nodo_conceptos(x.Name & cont_c & " " & prop.Name, cont, prop.Value)
                    End If
                Next
            Else
                Dim prop As JProperty = e
                If prop.Name.ToString.Substring(0, 4) = "cfdi" Or prop.Name.ToString.Substring(0, 4) = "terc" Then
                    nuevo_nodo_conceptos(jsonObject.SelectToken(x.Name), prop, cont)
                Else
                    set_nodo_conceptos(x.Name & " " & prop.Name, cont, prop.Value)
                End If
            End If
        Next

    End Sub

    Public Sub set_nodo_conceptos(ByVal nombre As String, ByVal cont As Integer, ByVal valor As String)
        Dim bandera As Boolean = False
        For Each column As DataGridViewColumn In dgvConceptos.Columns
            If column.Name = nombre Then
                bandera = True
            End If
        Next

        If bandera Then
            dgvConceptos.Rows(cont).Cells(nombre).Value = valor
        Else
            Dim col As New DataGridViewTextBoxColumn
            col.Name = nombre
            dgvConceptos.Columns.Add(col)
            dgvConceptos.Rows(cont).Cells(nombre).Value = valor
        End If
    End Sub
#End Region

#Region "IMPUESTOS"
    Public Sub nodo_impuestos(ByVal jsonObject As JObject)
        dgvImpuestos.Columns.Clear()
        Dim col As New DataGridViewTextBoxColumn
        col.Name = "CONT"
        dgvImpuestos.Columns.Add(col)
        dgvImpuestos.Rows.Add(num_f.ToString)

        Dim cont As Decimal = 0

        Dim prueba As List(Of JToken) = jsonObject.Children().ToList
        For Each e As JToken In prueba
            Dim h As JProperty = e
            If h.Name.ToString.Substring(0, 4) = "cfdi" Then
                nuevo_nodo_impuestos(jsonObject, h, cont)
            Else
                set_nodo_impuestos(h.Name, cont, h.Value)
            End If
        Next
    End Sub

    Public Sub nuevo_nodo_impuestos(ByVal jsonObject As JObject, ByVal x As JProperty, ByVal cont As Integer)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken(x.Name).Children().ToList

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then
                cont_i = cont_i + 1
                Dim jo As JObject = JObject.Parse(e.ToString)
                For Each prop As JProperty In jo.Properties()
                    If prop.Name.ToString.Substring(0, 4) = "cfdi" Then
                        nuevo_nodo_impuestos(jo, prop, cont)
                    Else
                        set_nodo_impuestos(x.Name & cont_i & " " & prop.Name, cont, prop.Value)
                    End If
                Next
            Else
                Dim h As JProperty = e
                If h.Name.ToString.Substring(0, 4) = "cfdi" Then
                    nuevo_nodo_impuestos(jsonObject.SelectToken(x.Name), h, cont)
                Else
                    set_nodo_impuestos(x.Name & " " & h.Name, cont, h.Value)
                End If
            End If
        Next
    End Sub

    Public Sub set_nodo_impuestos(ByVal nombre As String, ByVal cont As Integer, ByVal valor As String)
        Dim bandera As Boolean = False

        For Each column As DataGridViewColumn In dgvImpuestos.Columns
            If column.Name = nombre Then
                bandera = True
            End If
        Next

        If bandera Then
            dgvImpuestos.Rows(cont).Cells(nombre).Value = valor
        Else
            Dim col As New DataGridViewTextBoxColumn
            col.Name = nombre
            dgvImpuestos.Columns.Add(col)
            dgvImpuestos.Rows(cont).Cells(nombre).Value = valor
        End If
    End Sub
#End Region

#Region "PAGOS"
    Public Sub nodo_pagos(ByVal jsonObject As JObject)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken("pago10:DoctoRelacionado").Children().ToList

        Dim cont As Integer = 0
        Dim col As New DataGridViewTextBoxColumn
        col.Name = "CONT"
        dgvPagos.Columns.Add(col)

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then
                dgvPagos.Rows.Add(num_f.ToString)
                Dim jo As JObject = JObject.Parse(e.ToString)
                For Each prop As JProperty In jo.Properties()
                    If prop.Name.ToString.Substring(0, 4) = "cfdi" Then
                    Else
                        set_nodo_pagos(prop.Name, cont, prop.Value)
                    End If
                Next
                cont = cont + 1
            Else
                If dgvPagos.Rows.Count = 0 Then
                    dgvPagos.Rows.Add(num_f.ToString)
                End If

                Dim h As JProperty = e
                If h.Name.ToString.Substring(0, 4) = "cfdi" Then
                    'nuevo_nodo_conceptos(jsonObject.SelectToken("cfdi:Concepto"), h, cont)
                Else
                    set_nodo_pagos(h.Name, cont, h.Value)
                End If
            End If
        Next
    End Sub

    Public Sub nodo_pagos2(ByVal jsonObject As JObject)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken("pago10:Pago").Children().ToList
        Dim cont As Integer = 0

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then
                Dim jo As JObject = JObject.Parse(e.ToString)
                nodo_pagos3(jo, cont)
                cont = cont + 1
            Else
                Dim h As JProperty = e
                If h.Name = "pago10:DoctoRelacionado" Then
                    nodo_pagos(jsonObject.SelectToken("pago10:Pago"))
                End If
            End If
        Next
    End Sub

    Public Sub nodo_pagos3(ByVal jsonObject As JObject, ByVal cont As Integer)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken("pago10:DoctoRelacionado").Children().ToList

        Dim col As New DataGridViewTextBoxColumn
        col.Name = "CONT"
        dgvPagos.Columns.Add(col)
        dgvPagos.Rows.Add(num_f.ToString)

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then

            Else
                Dim h As JProperty = e
                If h.Name.ToString.Substring(0, 4) = "cfdi" Then
                Else
                    set_nodo_pagos(h.Name, cont, h.Value)
                End If
            End If
        Next
    End Sub

    Public Sub set_nodo_pagos(ByVal nombre As String, ByVal cont As Integer, ByVal valor As String)
        Dim bandera As Boolean = False
        For Each column As DataGridViewColumn In dgvPagos.Columns
            If column.Name = nombre Then
                bandera = True
            End If
        Next

        If bandera Then
            dgvPagos.Rows(cont).Cells(nombre).Value = valor
        Else
            Dim col As New DataGridViewTextBoxColumn
            col.Name = nombre
            dgvPagos.Columns.Add(col)
            dgvPagos.Rows(cont).Cells(nombre).Value = valor
        End If
    End Sub
#End Region

#Region "NOMINA"
    Public Sub nodo_nomima(ByVal jsonObject As JObject)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken("nomina12:Nomina").Children().ToList

        Dim cont As Integer = 0
        Dim col As New DataGridViewTextBoxColumn
        col.Name = "CONT"
        dgvImpuestos.Columns.Add(col)

        For Each e As JToken In prueba
            If dgvImpuestos.Rows.Count = 0 Then
                dgvImpuestos.Rows.Add(num_f.ToString)
            End If

            Dim h As JProperty = e
            If h.Name.ToString.Substring(0, 8) = "nomina12" Then
                nuevo_nodo_nomina(jsonObject.SelectToken("nomina12:Nomina"), h, cont)
            Else
                set_nodo_nomina(h.Name, cont, h.Value)
            End If
        Next
    End Sub

    Public Sub set_nodo_nomina(ByVal nombre As String, ByVal cont As Integer, ByVal valor As String)
        Dim bandera As Boolean = False
        For Each column As DataGridViewColumn In dgvImpuestos.Columns
            If column.Name = nombre Then
                bandera = True
            End If
        Next

        If bandera Then
            dgvImpuestos.Rows(cont).Cells(nombre).Value = valor
        Else
            Dim col As New DataGridViewTextBoxColumn
            col.Name = nombre
            dgvImpuestos.Columns.Add(col)
            dgvImpuestos.Rows(cont).Cells(nombre).Value = valor
        End If
    End Sub

    Public Sub nuevo_nodo_nomina(ByVal jsonObject As JObject, ByVal x As JProperty, ByVal cont As Integer)
        Dim prueba As List(Of JToken) = jsonObject.SelectToken(x.Name).Children().ToList

        For Each e As JToken In prueba
            If e.ToString.Substring(0, 1) = "{" Then
                Dim jo As JObject = JObject.Parse(e.ToString)
                cont_n += 1
                For Each prop As JProperty In jo.Properties()
                    If prop.Name.ToString.Substring(0, 4) = "nomi" Then
                        nodo_impuestos_nomina(jo.SelectToken(prop.Name), x.Name & cont_n & " " & prop.Name)
                    Else
                        set_nodo_impuestos_nomina(x.Name & cont_n & " " & prop.Name, cont, prop.Value)
                    End If
                Next
            Else
                Dim prop As JProperty = e
                Select Case prop.Name
                    Case "nomina12:Percepcion"
                        nodo_impuestos_nomina(jsonObject.SelectToken(x.Name), "nomina12:Percepcion")
                    Case "nomina12:Deduccion"
                        nodo_impuestos_nomina(jsonObject.SelectToken(x.Name), "nomina12:Deduccion")
                    Case "nomina12:OtroPago"
                        nodo_impuestos_nomina(jsonObject.SelectToken(x.Name), "nomina12:OtroPago")
                    Case "nomina12:Incapacidad"
                        nodo_impuestos_nomina(jsonObject.SelectToken(x.Name), "nomina12:Incapacidad")
                    Case "nomina12:JubilacionPensionRetiro"
                        nodo_impuestos_nomina(jsonObject.SelectToken(x.Name).SelectToken(prop.Name), "nomina12:JubilacionPensionRetiro")
                    Case "nomina12:SeparacionIndemnizacion"
                        nodo_impuestos_nomina(jsonObject.SelectToken(x.Name).SelectToken(prop.Name), "nomina12:SeparacionIndemnizacion")
                    Case Else
                        If evaluate_nomina_impuestos(x.Name) Then
                            Try
                                set_nodo_impuestos_nomina(x.Name & " " & prop.Name, cont, prop.Value)
                            Catch ex As Exception
                                nodo_impuestos_nomina(jsonObject.SelectToken(x.Name).SelectToken(prop.Name), x.Name & " " & prop.Name)
                            End Try
                        Else
                            If prop.Name.ToString.Substring(0, 4) = "nomi" Then

                            Else
                                set_nodo_nomina(x.Name & " " & prop.Name, cont, prop.Value)
                            End If
                        End If
                End Select
            End If
        Next
    End Sub

    Public Sub nodo_impuestos_nomina(ByVal jsonObject As JObject, ByVal nombre As String)
        Dim prueba As List(Of JToken) = jsonObject.Children().ToList

        Dim cont As Integer = 0
        Dim col As New DataGridViewTextBoxColumn
        col.Name = "CONT"
        dgvPagos.Columns.Add(col)

        For Each e As JToken In prueba
            If dgvPagos.Rows.Count = 0 Then
                dgvPagos.Rows.Add(num_f.ToString)
            End If
            Dim h As JProperty = e
            If h.Name.ToString.Substring(0, 4) = "nomi" Then
                nuevo_nodo_nomina(jsonObject, h, cont)
            Else
                set_nodo_impuestos_nomina(nombre & " " & h.Name, cont, h.Value)
            End If
        Next

    End Sub

    Public Sub set_nodo_impuestos_nomina(ByVal nombre As String, ByVal cont As Integer, ByVal valor As String)
        Dim bandera As Boolean = False
        For Each column As DataGridViewColumn In dgvPagos.Columns
            If column.Name = nombre Then
                bandera = True
            End If
        Next

        If bandera Then
            dgvPagos.Rows(cont).Cells(nombre).Value = valor
        Else
            Dim col As New DataGridViewTextBoxColumn
            col.Name = nombre
            dgvPagos.Columns.Add(col)
            dgvPagos.Rows(cont).Cells(nombre).Value = valor
        End If
    End Sub

    Public Function evaluate_nomina_impuestos(ByVal valor As String) As Boolean
        If valor = "nomina12:Percepcion" Or valor = "nomina12:Deduccion" Or valor = "nomina12:OtroPago" Or valor = "nomina12:Incapacidad" Then
            Return True
        End If
        Return False
    End Function
#End Region

    Public Sub alta_xml()
        dgvXML_2.Rows.Clear()
        dgvRFC.Rows.Clear()
        dgvImpSC.Rows.Clear()
        dgvSXML.Rows.Clear()

        For Each row As DataGridViewRow In dgvRutas.Rows
            'LIMPIAMOS LOS DATAGRID
            dgvXML.Columns.Clear()
            dgvImpuestos.Columns.Clear()
            dgvConceptos.Columns.Clear()
            dgvPagos.Columns.Clear()

            'INICIALIZAMOS VARIABLES
            cont_i = 0
            cont_c = 0
            cont_n = 0

            'DECLARAMOS VARIABLES
            Dim xml As String = ""
            Dim doc As XmlDocument = New XmlDocument()
            Dim path As String = ""

            path = row.Cells(0).Value.ToString
            xml = My.Computer.FileSystem.ReadAllText(path)
            num_f = num_f + 1
            doc.LoadXml(xml)
            Dim json As String = JsonConvert.SerializeXmlNode(doc)
            Dim jsonObject As JObject = JObject.Parse(json)

            Dim cont As Integer = 0
            Dim numero As New DataGridViewTextBoxColumn
            numero.Name = "CONT"
            dgvXML.Columns.Add(numero)
            dgvXML.Rows.Add(num_f.ToString)

            For Each prop As JProperty In jsonObject.Properties()
                Dim result As List(Of JToken) = jsonObject.SelectToken(prop.Name).Children().ToList
                For Each elem As JToken In result
                    Dim h As JProperty = elem

                    If h.Name.ToString.Substring(0, 4) = "cfdi" Then
                        nuevo_nivel(jsonObject.SelectToken(prop.Name), h, cont)
                    Else
                        set_nodo(prop.Name & " " & h.Name, cont, h.Value)
                    End If
                Next
            Next

            guarda_xml()
            band = False
        Next
    End Sub

    Public Sub nuevo_nivel(ByVal jsonObject As JObject, ByVal x As JProperty, ByVal cont As Integer)
        Dim result As List(Of JToken) = jsonObject.SelectToken(x.Name).Children().ToList
        Dim aux As String = ""

        For Each elem As JToken In result
            Dim h As JProperty = elem
            Select Case x.Name
                Case "cfdi:Conceptos"
                    nodo_conceptos(jsonObject.SelectToken(x.Name))
                Case "cfdi:Impuestos"
                    nodo_impuestos(jsonObject.SelectToken(x.Name))
                Case "pago10:Pagos"
                    If band = False Then
                        nodo_pagos2(jsonObject.SelectToken(x.Name))
                    End If
                    band = True
                Case Else
                    Select Case h.Name
                        Case "pago10:DoctoRelacionado"
                            nodo_pagos(jsonObject.SelectToken(x.Name))
                        Case "nomina12:Nomina"
                            nodo_nomima(jsonObject.SelectToken(x.Name))
                        Case Else
                            aux = h.Name
                            If h.Name.Length < 6 Then
                                aux = h.Name & "0000000"
                            End If
                            If h.Name.ToString.Substring(0, 4) = "cfdi" Or h.Name.ToString.Substring(0, 3) = "tfd" Or aux.ToString.Substring(0, 6) = "pago10" Then
                                nuevo_nivel(jsonObject.SelectToken(x.Name), h, cont)
                            Else
                                set_nodo(x.Name & " " & h.Name, cont, h.Value.ToString)
                            End If
                    End Select
            End Select
        Next
    End Sub

    Public Sub set_nodo(ByVal nombre As String, ByVal cont As Integer, ByVal valor As String)
        Dim col As New DataGridViewTextBoxColumn
        col.Name = nombre
        dgvXML.Columns.Add(col)
        dgvXML.Rows(cont).Cells(nombre).Value = valor
    End Sub

    Public Sub consulta_impuestos(ByVal row As DataGridViewRow, ByRef datos As Class_datos, ByVal cell As DataGridViewColumn)
        Try
            Dim impuesto As String = ""
            Dim aux() As String = cell.Name.ToString.Split(" ")
            If aux(1).ToLower = "@Impuesto".ToLower Then
                impuesto = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                'CASO ESPECIAL IVA RETENIDO O TRASLADADO
                If impuesto = "002" Then
                    If aux(0).IndexOf("Traslado") > 0 Then
                        impuesto = "002_t"
                    End If
                    If aux(0).IndexOf("Retencion") > 0 Then
                        impuesto = "002_r"
                    End If
                End If

                'RECORREMOS LAS COLUMNAS EN BUSCA DE LOS VALORES RESTANTES
                For Each cell2 As DataGridViewColumn In dgvConceptos.Columns
                    Select Case cell2.Name.ToLower
                        Case aux(0).ToLower & " " & "@Importe".ToLower
                            Select Case impuesto
                                Case "001"
                                    datos.isr = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_t"
                                    datos.iva = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_r"
                                    datos.iva_ret = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "003"
                                    datos.ieps = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                            End Select
                        Case aux(0).ToLower & " " & "@TasaOCuota".ToLower
                            Select Case impuesto
                                Case "001"
                                    datos.tasa_isr = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_t"
                                    datos.tasa_iva = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_r"
                                    datos.tasa_iva_ret = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "003"
                                    datos.tasa_ieps = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                            End Select
                        Case aux(0).ToLower & " " & "@TipoFactor".ToLower
                            Select Case impuesto
                                Case "001"
                                    datos.tipo_isr = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_t"
                                    datos.tipo_iva = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_r"
                                    datos.tipo_iva_ret = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "003"
                                    datos.tipo_ieps = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                            End Select
                        Case aux(0).ToLower & " " & "@Impuesto".ToLower
                            Select Case impuesto
                                Case "001"
                                    datos.impuesto_isr = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_t"
                                    datos.impuesto_iva = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "002_r"
                                    datos.impuesto_iva_ret = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                                Case "003"
                                    datos.importe_ieps = dgvConceptos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                            End Select
                    End Select
                Next
            End If
        Catch ex As Exception
        End Try
    End Sub

    Public Sub consulta_impuesto2(ByVal row As DataGridViewRow, ByRef datos As Class_datos, ByVal cell As DataGridViewColumn, ByVal id_factura As Integer)
        Try
            Dim datos_2 As New Class_datos
            Dim conexion_2 As New Class_insert

            Dim impuesto As String = ""
            Dim aux() As String = cell.Name.ToString.Split(" ")
            If aux(1).ToLower = "@Impuesto".ToLower Then
                impuesto = dgvImpuestos.Rows(row.Index).Cells(cell.Name).Value.ToString

                'CASO DE IMPUESTOS
                Select Case impuesto
                    Case "001"
                        datos.tipo = "ISR"
                        datos.impuesto = "ISR"
                        datos.tabla = "RETENIDO"
                    Case "002"
                        If aux(0).IndexOf("Traslado") > 0 Then
                            datos.tipo = "IVA"
                            datos.impuesto = "IVA"
                            datos.tabla = "TRASLADO"
                        End If

                        If aux(0).IndexOf("Retencion") > 0 Then
                            datos.tipo = "IVA_RET"
                            datos.impuesto = "IVA_RET"
                            datos.tabla = "RETENIDO"
                        End If
                    Case "003"
                        datos.tipo = "IEPS"
                        datos.impuesto = "IEPS"
                        datos.tabla = "TRASLADO"
                    Case Else
                        datos.tipo = impuesto
                        datos.impuesto = impuesto
                        If aux(0).IndexOf("Traslado") > 0 Then
                            datos.tabla = "TRASLADO"
                        End If

                        If aux(0).IndexOf("Retencion") > 0 Then
                            datos.tabla = "RETENIDO"
                        End If
                End Select

                'RECORREMOS LAS COLUMNAS EN BUSCA DE LOS VALORES RESTANTES
                For Each cell2 As DataGridViewColumn In dgvImpuestos.Columns
                    Select Case cell2.Name.ToLower
                        Case aux(0).ToLower & " " & "@TipoFactor".ToLower
                            datos.calculo = dgvImpuestos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                        Case aux(0).ToLower & " " & "@TasaOCuota".ToLower
                            datos.tasa = dgvImpuestos.Rows(row.Index).Cells(cell2.Name).Value.ToString * 100
                        Case aux(0).ToLower & " " & "@Importe".ToLower
                            datos.total = dgvImpuestos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                        Case aux(0).ToLower & " " & "@tasa".ToLower
                            datos.tasa = dgvImpuestos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                    End Select
                Next

                'VALORES EXTRA
                Try
                    datos.importe = datos.total / (datos.tasa / 100)
                Catch ex As Exception
                    datos.importe = 0.0
                End Try

                datos.id_factura = id_factura

                conexion_2.insert_tabla_impuestos(datos)
            End If
        Catch ex As Exception
            'MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub get_nomina_impuestos(ByRef datos As Class_datos, ByVal cell As DataGridViewColumn, ByVal id_factura As Integer)
        Try
            Dim conexion As New Class_insert
            Dim aux() As String = cell.Name.ToString.Split(" ")
            datos.id_factura = id_factura
            If aux(1).ToLower = "@Clave".ToLower Or aux(1).ToLower = "@TipoIncapacidad".ToLower Or aux(1).ToLower = "@TotalUnaExhibicion".ToLower Or aux(1).ToLower = "@TotalPagado".ToLower Then

                'BUSCAMOS LOS VALORES PARA ESE IMPUESTO
                For Each cell2 As DataGridViewColumn In dgvPagos.Columns
                    If aux(0).IndexOf("Percepcion") > -1 Then
                        Select Case cell2.Name.ToLower
                            Case aux(0).ToLower & " " & "@TipoPercepcion".ToLower
                                datos.tipo = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Clave".ToLower
                                datos.clave = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Concepto".ToLower
                                datos.concepto = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@ImporteGravado".ToLower
                                datos.importe_gravado = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@ImporteExento".ToLower
                                datos.importe_exento = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:AccionesOTitulos".ToLower & " " & "@ValorMercado".ToLower
                                datos.aot_valor_mercado = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:AccionesOTitulos".ToLower & " " & "@PrecioAlOtorgarse".ToLower
                                datos.aot_precio_otorgado = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:HorasExtra".ToLower & " " & "@Dias".ToLower
                                datos.he_dias = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:HorasExtra".ToLower & " " & "@TipoHoras".ToLower
                                datos.he_tipo_hora = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:HorasExtra".ToLower & " " & "@HorasExtra".ToLower
                                datos.he_horas_extra = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:HorasExtra".ToLower & " " & "@ImportePagado".ToLower
                                datos.abono = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:HorasExtra".ToLower & " " & "@ImportePagado".ToLower
                                datos.abono = dgvPagos.Rows(0).Cells(cell2.Name).Value
                        End Select
                    ElseIf aux(0).IndexOf("Deduccion") > -1 Then
                        Select Case cell2.Name.ToLower
                            Case aux(0).ToLower & " " & "@TipoDeduccion".ToLower
                                datos.tipo = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Clave".ToLower
                                datos.clave = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Concepto".ToLower
                                datos.concepto = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Importe".ToLower
                                datos.importe = dgvPagos.Rows(0).Cells(cell2.Name).Value
                        End Select
                    ElseIf aux(0).IndexOf("OtroPago") > -1 Then
                        Select Case cell2.Name.ToLower
                            Case aux(0).ToLower & " " & "@TipoOtroPago".ToLower
                                datos.tipo = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Clave".ToLower
                                datos.clave = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Concepto".ToLower
                                datos.concepto = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@Importe".ToLower
                                datos.importe = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:SubsidioAlEmpleo".ToLower & " " & "@SubsidioCausado".ToLower
                                datos.sae_subs_c = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:CompensacionSaldosAFavor".ToLower & " " & "@SaldoAFavor".ToLower
                                datos.csa_saldo_f = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:CompensacionSaldosAFavor".ToLower & " " & "@Año".ToLower
                                datos.csa_anio = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "nomina12:CompensacionSaldosAFavor".ToLower & " " & "@RemanenteSalFav".ToLower
                                datos.csa_rem_sf = dgvPagos.Rows(0).Cells(cell2.Name).Value
                        End Select
                    ElseIf aux(0).IndexOf("Incapacidad") > -1 Then
                        Select Case cell2.Name.ToLower
                            Case aux(0).ToLower & " " & "@DiasIncapacidad".ToLower
                                datos.dias = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@TipoIncapacidad".ToLower
                                datos.tipo = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@TipoIncapacidad".ToLower
                                datos.importe = dgvPagos.Rows(0).Cells(cell2.Name).Value
                        End Select
                    ElseIf aux(0).IndexOf("JubilacionPensionRetiro") > -1 Then
                        Select Case cell2.Name.ToLower
                            Case aux(0).ToLower & " " & "@TotalUnaExhibicion".ToLower
                                datos.jpr_total_e = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@TotalParcialidad".ToLower
                                datos.jpr_total_p = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@MontoDiario".ToLower
                                datos.jpr_monto_diario = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@IngresoAcumulable".ToLower
                                datos.jpr_ingreso_acum = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@IngresoNoAcumulable".ToLower
                                datos.jpr_ingreso_n_acum = dgvPagos.Rows(0).Cells(cell2.Name).Value
                        End Select
                    ElseIf aux(0).IndexOf("SeparacionIndemnizacion") > -1 Then
                        Select Case cell2.Name.ToLower
                            Case aux(0).ToLower & " " & "@TotalPagado".ToLower
                                datos.si_total_p = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@NumAñosServicio".ToLower
                                datos.si_num_a_s = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@UltimoSueldoMensOrd".ToLower
                                datos.si_usmo = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@IngresoAcumulable".ToLower
                                datos.si_ing_a = dgvPagos.Rows(0).Cells(cell2.Name).Value
                            Case aux(0).ToLower & " " & "@IngresoNoAcumulable".ToLower
                                datos.si_ing_n_a = dgvPagos.Rows(0).Cells(cell2.Name).Value
                        End Select
                    End If
                Next

                'GUARDAMOS LOS IMPUESTOS
                If aux(0).IndexOf("Percepcion") > -1 Then
                    conexion.insert_nomina_percepciones(datos)
                ElseIf aux(0).IndexOf("Deduccion") > -1 Then
                    conexion.insert_nomina_deducciones(datos)
                ElseIf aux(0).IndexOf("OtroPago") > -1 Then
                    conexion.insert_nomina_otrosP(datos)
                ElseIf aux(0).IndexOf("Incapacidad") > -1 Then
                    conexion.insert_nomina_incapacidades(datos)
                ElseIf aux(0).IndexOf("JubilacionPensionRetiro") > -1 Then
                    conexion.insert_nomina_percepciones(datos)
                ElseIf aux(0).IndexOf("SeparacionIndemnizacion") > -1 Then
                    conexion.insert_nomina_percepciones(datos)
                End If
            End If

        Catch ex As Exception

        End Try
    End Sub

    Public Sub guarda_xml()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_insert

        Dim band As Boolean = False

        Dim id_factura As Integer = 0
        Dim id_articulo As Integer = 0
        Dim cont As Integer = 1
        Dim pagos As Boolean = False
        Dim nomina As Boolean = False
        Dim id_documento As String = ""
        Dim moneda_dr As String = ""
        Dim metodo_pago_dr As String = ""
        Dim num_parcialidad As Integer = 0
        Dim imp_pagado As Decimal = 0

        Dim rfc_ As String = ""
        Dim tipo_ As String = ""
        Dim impuesto_ As String = ""
        Dim calculo_ As String = ""
        Dim tasa_ As String = ""
        Dim band_ As Boolean = False
        Dim tipo_p_ As String = ""
        Dim fecha_ As String = ""
        Dim total_ As Decimal = 0
        Dim subtotal_ As Decimal = 0
        Dim condicion_ As String = ""
        Dim folio_ As String = ""

        'CABACERA
        For Each cell As DataGridViewColumn In dgvXML.Columns
            Select Case cell.Name.ToLower
                Case "cfdi:Comprobante @Serie".ToLower
                    datos.serie_t = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @Folio".ToLower
                    datos.folio_t = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @Fecha".ToLower
                    Try
                        datos.fecha = Convert.ToDateTime(dgvXML.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-dd")
                    Catch ex As Exception
                    End Try
                Case "cfdi:Receptor @Rfc".ToLower
                    datos.rfc_r = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Receptor @Nombre".ToLower
                    datos.nombre_r = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Emisor @Rfc".ToLower
                    datos.rfc_e = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Emisor @Nombre".ToLower
                    datos.nombre_e = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @TipoCambio".ToLower
                    datos.tipo_cambio = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @Moneda".ToLower
                    datos.moneda = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Receptor @UsoCFDI".ToLower
                    Select Case dgvXML.Rows(0).Cells(cell.Name.ToLower).Value.ToString
                        Case "G01"
                            datos.uso_cfdi = "G01-Adquisición de mercancias"
                        Case "G02"
                            datos.uso_cfdi = "G02-Devoluciones, descuentos o bonificaciones"
                        Case "G03"
                            datos.uso_cfdi = "G03-Gastos en general"
                        Case "I01"
                            datos.uso_cfdi = "I01-Construcciones"
                        Case "I02"
                            datos.uso_cfdi = "I02-Mobilario y equipo de oficina por inversiones"
                        Case "I03"
                            datos.uso_cfdi = "I03-Equipo de transporte"
                        Case "I04"
                            datos.uso_cfdi = "I04-Equipo de computo y accesorios"
                        Case "I05"
                            datos.uso_cfdi = "I05-Dados, troqueles, moldes, matrices y herramental"
                        Case "I06"
                            datos.uso_cfdi = "I06-Comunicaciones telefónicas"
                        Case "I07"
                            datos.uso_cfdi = "I07-Comunicaciones satelitales"
                        Case "I08"
                            datos.uso_cfdi = "I08-Otra maquinaria y equipo"
                        Case "D01"
                            datos.uso_cfdi = "D01-Honorarios médicos, dentales y gastos hospitalarios"
                        Case "D02"
                            datos.uso_cfdi = "D02-Gastos médicos por incapacidad o discapacidad"
                        Case "D03"
                            datos.uso_cfdi = "D03-Gastos funerales"
                        Case "D04"
                            datos.uso_cfdi = "D04-Donativos"
                        Case "D05"
                            datos.uso_cfdi = "D05-Intereses reales efectivamente pagados por créditos hipotecarios (casa habitación)"
                        Case "D06"
                            datos.uso_cfdi = "D06-Aportaciones voluntarias al SAR"
                        Case "D07"
                            datos.uso_cfdi = "D07-Primas por seguros de gastos médicos"
                        Case "D08"
                            datos.uso_cfdi = "D08-Gastos de transportación escolar obligatoria"
                        Case "D09"
                            datos.uso_cfdi = "D09-Depósitos en cuentas para el ahorro, primas que tengan como base planes de pensiones"
                        Case "D10"
                            datos.uso_cfdi = "D10-Pagos por servicios educativos (colegiaturas)"
                        Case "P01"
                            datos.uso_cfdi = "P01-Por definir"
                    End Select
                Case "cfdi:Comprobante @SubTotal".ToLower
                    datos.sub_t = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @Total".ToLower
                    datos.total_t = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @Descuento".ToLower
                    datos.descuento_g = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "tfd:TimbreFiscalDigital @UUID".ToLower
                    datos.uuid = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @NoCertificado".ToLower
                    datos.cert = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "tfd:TimbreFiscalDigital @NoCertificadoSAT".ToLower
                    datos.certsat = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "tfd:TimbreFiscalDigital @FechaTimbrado".ToLower
                    datos.fecha = Convert.ToDateTime(dgvXML.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-dd")
                    datos.fechacert = Convert.ToDateTime(dgvXML.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-ddThh:mm:ss")
                Case "tfd:TimbreFiscalDigital @SelloCFD".ToLower
                    datos.cfdi = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "tfd:TimbreFiscalDigital @SelloSAT".ToLower
                    datos.sellosat = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "tfd:TimbreFiscalDigital @RfcProvCertif".ToLower
                    datos.rfc_prov_certif = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "tfd:TimbreFiscalDigital @NoCertificadoSAT".ToLower
                    datos.no_certif_sat = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @MetodoPago".ToLower
                    datos.condicion = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @FormaPago".ToLower
                    Select Case dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                        Case "01"
                            datos.forma = "01 Efectivo"
                        Case "02"
                            datos.forma = "02 Cheque nominativo"
                        Case "03"
                            datos.forma = "03 Transferencia electrónica de fondos"
                        Case "04"
                            datos.forma = "04 Tarjeta de crédito"
                        Case "05"
                            datos.forma = "05 Monedero electrónico"
                        Case "06"
                            datos.forma = "06 Dinero electrónico"
                        Case "08"
                            datos.forma = "08 Vales de despensa"
                        Case "12"
                            datos.forma = "12 Dación en pago"
                        Case "13"
                            datos.forma = "13 Pago por subrogación"
                        Case "14"
                            datos.forma = "14 Pago por consignación"
                        Case "15"
                            datos.forma = "15 Condonación"
                        Case "17"
                            datos.forma = "17 Compensación"
                        Case "23"
                            datos.forma = "23 Novación"
                        Case "24"
                            datos.forma = "24 Confusión"
                        Case "25"
                            datos.forma = "25 Remisión de deuda"
                        Case "26"
                            datos.forma = "26 Prescripción o caducidad"
                        Case "27"
                            datos.forma = "27 A satisfacción del acreedor"
                        Case "28"
                            datos.forma = "28 Tarjeta de débito"
                        Case "29"
                            datos.forma = "29 Tarjeta de servicios"
                        Case "99"
                            datos.forma = "99 Por definir"
                    End Select
                Case "cfdi:Comprobante @TipoDeComprobante".ToLower
                    datos.tipo = dgvXML.Rows(0).Cells(cell.Name).Value.ToString.Substring(0, 1).ToUpper
                Case "cfdi:Comprobante @Version".ToLower
                    datos.version = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @metodoDePago".ToLower
                    datos.forma = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
                Case "cfdi:Comprobante @formaDePago".ToLower
                    datos.condicion = dgvXML.Rows(0).Cells(cell.Name).Value.ToString
            End Select
        Next

        'COMPROBAMOS EL RFC DE LA EMPRESA
        If get_rfc_empresa(datos.rfc_r, datos.rfc_e) Then
            Return
        End If

        'COMPROBAMOS EL UUID PARA NO INSERTAR REPETIDOS
        If get_uuid(datos.uuid) Then
            Return
        End If

        'COMPROBAMOS SI EL RFC ESTA CONFIGURADO
        If get_config_rfc(datos.rfc_r, datos.rfc_e, rfc_, tipo_) Then
            If datos.rfc_r = rfc_ Then
                check_dgv(datos.nombre_r, datos.rfc_r, dgvRFC, tipo_)
            Else
                check_dgv(datos.nombre_e, datos.rfc_e, dgvRFC, tipo_)
            End If
            Return
        End If

        'COMPROBAMOS SI LOS IMPUESTOS ESTAN CONFIGURADOS
        For Each row As DataGridViewRow In dgvImpuestos.Rows
            For Each cell As DataGridViewColumn In dgvImpuestos.Columns
                If get_config_impuestos(row, cell, tipo_) = False Then
                    band_ = True
                End If
            Next
        Next

        If band_ Then
            Return
        End If

        'CASO ESPECIAL SIN NODO IMPUESTOS
        If datos.tipo <> "P" Then
            If datos.tipo <> "N" Then
                If get_nodo_impuestos(tipo_) = False Then
                    band_ = True
                Else
                    band_ = False
                End If

                If band_ Then
                    Return
                End If
            End If
        End If

        'VERIFICAMOS SI EL COMPROBANTE ES DE TIPO PAGO
        If datos.tipo = "P" Then
            pagos = True
            nomina = False

            'VERIFICAMOS QUE LOS UUID RELACIONADOS ESTEN DADOS DE ALTA EN EL SISTEMA
            If get_uuid_pagos() = False Then
                Return
            End If

        ElseIf datos.tipo = "N" Then
            pagos = False
            nomina = True
        End If

        'VALORES EXTRA
        datos.cadena = "||1.1|" & datos.uuid & "|" & datos.fechacert & "|" & datos.rfc_prov_certif & "|" & datos.cfdi & "|" & datos.no_certif_sat & "|"
        datos.decimales = 2
        datos.estatus = "Timbrado"

        If conexion.insert_factura(datos) Then
            'OBTENEMOS ID DE LA FACTURA
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select * from factura ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id_factura = resultado.GetString("id_timbrados")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'AGREGAMOS AL DATA GRID DE XML GUARDADOS
            dgvXML_2.Rows.Add(datos.id_factura, datos.version, datos.serie_t, datos.folio_t, datos.fechacert, datos.nombre_r, datos.rfc_r, datos.nombre_e, datos.rfc_e, datos.tipo, datos.uuid, datos.sub_t, datos.total_t)

            tipo_p_ = datos.tipo
            fecha_ = datos.fechacert
            total_ = datos.total_t
            subtotal_ = datos.sub_t
            condicion_ = datos.condicion
            folio_ = datos.serie_t & " - " & datos.folio_t

            'RECORREMOS EL DATA GRID CON LOS ARTICULOS
            For Each row As DataGridViewRow In dgvConceptos.Rows
                datos = New Class_datos
                For Each cell As DataGridViewColumn In dgvConceptos.Columns
                    Select Case cell.Name.ToLower
                        Case "@NoIdentificacion".ToLower
                            datos.clave = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                        Case "@ClaveProdServ".ToLower
                            datos.clave_sat = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                        Case "@Descripcion".ToLower
                            datos.descripcion = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                        Case "@Unidad".ToLower
                            datos.u_med_v = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                            datos.u_med_c = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                        Case "@ClaveUnidad".ToLower
                            datos.u_med_sat = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value.ToString
                        Case "@Cantidad".ToLower
                            datos.cantidad = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value
                        Case "@ValorUnitario".ToLower
                            datos.importe_unit = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value
                        Case "@Descuento".ToLower
                            datos.descuento = dgvConceptos.Rows(row.Index).Cells(cell.Name).Value
                        Case Else
                            consulta_impuestos(row, datos, cell)
                    End Select
                Next

                'CONSULTAMOS SI EL ARTICULO YA ESTA DADO DE ALTA
                If datos.clave = "" And datos.descripcion <> "" Then
                    datos.clave = datos.descripcion
                End If

                If datos.descripcion = "" And datos.clave <> "" Then
                    datos.descripcion = datos.clave
                End If

                If consulta_articulo(datos.clave, datos.descripcion, id_articulo) = False Then
                    conexion.insert_articulos(datos)
                    consulta_articulo(datos.clave, datos.descripcion, id_articulo)
                End If

                datos.id_art = id_articulo
                datos.item = cont
                datos.id_factura = id_factura
                datos.importe_tot = (datos.importe_unit - datos.descuento) * datos.cantidad
                datos.precio_tot = datos.importe_tot + datos.iva - datos.isr + datos.ieps - datos.iva_ret
                Try
                    datos.precio_unit = datos.precio_tot / datos.cantidad
                Catch ex As Exception
                    datos.precio_unit = 0.00
                End Try

                conexion.insert_factura_det(datos)
            Next

            'CHECAMOS SI ES NÓMINA
            If nomina Then
                datos.id_factura = id_factura
                'RECORREMOS EL DATAGRID CON LOS DATOS GENERALES DE LA NÓMINA
                For Each cell As DataGridViewColumn In dgvImpuestos.Columns
                    Select Case cell.Name.ToLower
                        Case "@FechaPago".ToLower
                            datos.fecha_pago = Convert.ToDateTime(dgvImpuestos.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-dd")
                        Case "@FechaInicialPago".ToLower
                            datos.fecha_inicial_p = Convert.ToDateTime(dgvImpuestos.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-dd")
                        Case "@FechaFinalPago".ToLower
                            datos.fecha_final_p = Convert.ToDateTime(dgvImpuestos.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-dd")
                        Case "@NumDiasPagados".ToLower
                            datos.num_dias_pagados = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "@TipoNomina".ToLower
                            datos.tipo_nomina = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "@TotalOtrosPagos".ToLower
                            datos.total_otros_pagos = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "@TotalDeducciones".ToLower
                            datos.total_deducciones = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "@TotalPercepciones".ToLower
                            datos.total_percepciones = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Emisor @Rfc".ToLower
                            datos.e_curp = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Emisor @RegistroPatronal".ToLower
                            datos.e_registro_patronal = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Emisor @RfcPatronOrigen".ToLower
                            datos.e_rfc_patron_origen = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @Curp".ToLower
                            datos.r_curp = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @NumSeguridadSocial".ToLower
                            datos.r_num_seguridad_social = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @FechaInicioRelLaboral".ToLower
                            datos.r_fecha_i_laborar = Convert.ToDateTime(dgvImpuestos.Rows(0).Cells(cell.Name).Value).ToString("yyyy-MM-dd")
                        Case "nomina12:Receptor @Antigüedad".ToLower
                            datos.r_antiguedad = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @TipoContrato".ToLower
                            datos.r_tipo_contrato = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @Sindicalizado".ToLower
                            datos.r_sindicalizado = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @TipoJornada".ToLower
                            datos.r_tipo_jornada = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @TipoRegimen".ToLower
                            datos.r_tipo_regimen = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @NumEmpleado".ToLower
                            datos.r_num_empleado = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @Departamento".ToLower
                            datos.r_departamento = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @Puesto".ToLower
                            datos.r_departamento = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @RiesgoPuesto".ToLower
                            datos.r_riesgo = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @PeriodicidadPago".ToLower
                            datos.r_periodicidad = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @Banco".ToLower
                            datos.r_banco = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @CuentaBancaria".ToLower
                            datos.r_cuenta_bancaria = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @SalarioBaseCotApor".ToLower
                            datos.r_salario_base = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @SalarioDiarioIntegrado".ToLower
                            datos.r_salario_diario = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                        Case "nomina12:Receptor @ClaveEntFed".ToLower
                            datos.r_clave_ent_f = dgvImpuestos.Rows(0).Cells(cell.Name).Value
                    End Select
                Next

                conexion.insert_tabla_nomina(datos)

                'RECORREMOS EL DATA GRID CON LOS IMPUESTOS
                For Each cell As DataGridViewColumn In dgvPagos.Columns
                    datos = New Class_datos
                    get_nomina_impuestos(datos, cell, id_factura)
                Next
            Else
                'RECORREMOS EL DATA GRID CON LOS IMPUESTOS
                For Each row As DataGridViewRow In dgvImpuestos.Rows
                    datos = New Class_datos
                    For Each cell As DataGridViewColumn In dgvImpuestos.Columns
                        consulta_impuesto2(row, datos, cell, id_factura)
                    Next
                Next

                'CASO ESPECIAL SIN NODO IMPUESTOS
                If pagos = False Then
                    If dgvImpuestos.Rows.Count = 0 Then
                        datos.id_factura = id_factura
                        datos.impuesto = "IVA"
                        datos.tipo = "IVA"
                        datos.calculo = "EXENTO"
                        datos.tasa = 0.0
                        datos.total = 0.0
                        datos.importe = 0.0
                        datos.tabla = "TRASLADO"

                        conexion.insert_tabla_impuestos(datos)
                    End If
                End If

                'RECORREMOS EL DATA GRID CON LOS PAGOS
                If pagos Then
                    For Each row As DataGridViewRow In dgvPagos.Rows
                        id_documento = ""
                        moneda_dr = ""
                        metodo_pago_dr = ""
                        num_parcialidad = 0
                        imp_pagado = 0
                        For Each cell As DataGridViewColumn In dgvPagos.Columns
                            Select Case cell.Name
                                Case "@IdDocumento"
                                    id_documento = row.Cells(cell.Name).Value
                                Case "@MonedaDR"
                                    moneda_dr = row.Cells(cell.Name).Value
                                Case "@MetodoDePagoDR"
                                    metodo_pago_dr = row.Cells(cell.Name).Value
                                Case "@NumParcialidad"
                                    num_parcialidad = row.Cells(cell.Name).Value
                                Case "@ImpPagado"
                                    imp_pagado = row.Cells(cell.Name).Value
                            End Select
                        Next

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
                    Next
                End If
            End If

            'CREAMOS LA PÓLIZA
            create_poliza(id_factura, tipo_, tipo_p_, fecha_, total_, subtotal_, condicion_, folio_)
        End If
    End Sub

    Public Function get_rfc_empresa(ByVal rfc_r As String, ByVal rfc_e As String) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = True

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from config_auto_conta.bases where base = '" & var_globales.base & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                If resultado.GetString("rfc_emp") = rfc_r Or resultado.GetString("rfc_emp") = rfc_e Then
                    b = False
                End If
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

    Public Function get_uuid(ByVal uuid As String) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from factura where uuid = '" & uuid & "' and estatus = 'Timbrado' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
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

    Public Function get_config_rfc(ByVal rfc_r As String, ByVal rfc_e As String, ByRef rfc_x As String, ByRef tipo As String) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = True
        Dim rfc_ As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from config_auto_conta.bases where base = '" & var_globales.base & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                If resultado.GetString("rfc_emp") = rfc_r Then
                    rfc_ = rfc_e
                    tipo = "RECIBIDOS"
                Else
                    rfc_ = rfc_r
                    tipo = "EMITIDOS"
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from rfc_config where rfc = '" & rfc_ & "' and tipo = '" & tipo & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = False
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        rfc_x = rfc_

        Return b
    End Function

    Public Function consulta_articulo(ByVal clave As String, ByVal descripcion As String, ByRef id_articulo As Integer) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from articulos where clave = '" & clave & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_articulo = resultado.GetInt64("id_art")
                Return True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from articulos where descripcion = '" & descripcion & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_articulo = resultado.GetInt64("id_art")
                Return True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return False
    End Function

    Public Function consulta_medida_sat(ByVal clave_sat As String) As String
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim medida As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from medidas_sat where clave_sat = '" & clave_sat & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                medida = resultado.GetString("descripcion")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return medida
    End Function

    Public Sub check_dgv(ByVal valor1 As String, ByVal valor2 As String, ByVal dgv As DataGridView, ByVal tipo As String)
        Dim band As Boolean = False
        For Each row As DataGridViewRow In dgv.Rows
            If row.Cells(0).Value = valor1 And row.Cells(2).Value = tipo Then
                band = True
            End If
        Next

        If band = False Then
            dgv.Rows.Add(valor1, valor2, tipo)
        End If

        If dgv.Rows.Count = 0 Then
            dgv.Rows.Add(valor1, valor2, tipo)
        End If
    End Sub

    Public Function get_config_impuestos(ByVal row As DataGridViewRow, ByVal cell As DataGridViewColumn, ByVal tipo As String) As Boolean
        Try
            Dim comandoSql As MySqlCommand
            Dim resultado As MySqlDataReader

            Dim impuesto As String = ""
            Dim calculo As String = ""
            Dim tasa As String = ""
            Dim bandera As Boolean = False
            Dim band As Boolean = False

            Dim aux() As String = cell.Name.ToString.Split(" ")
            If aux(1).ToLower = "@Impuesto".ToLower Then
                impuesto = dgvImpuestos.Rows(row.Index).Cells(cell.Name).Value.ToString

                'CASO DE IMPUESTOS
                Select Case impuesto
                    Case "001"
                        impuesto = "ISR"
                    Case "002"
                        If aux(0).IndexOf("Traslado") > 0 Then
                            impuesto = "IVA"
                        End If

                        If aux(0).IndexOf("Retencion") > 0 Then
                            impuesto = "IVA_RET"
                        End If
                    Case "003"
                        impuesto = "IEPS"
                End Select

                'RECORREMOS LAS COLUMNAS EN BUSCA DE LOS VALORES RESTANTES
                For Each cell2 As DataGridViewColumn In dgvImpuestos.Columns
                    Select Case cell2.Name.ToLower
                        Case aux(0).ToLower & " " & "@TipoFactor".ToLower
                            calculo = dgvImpuestos.Rows(row.Index).Cells(cell2.Name).Value.ToString
                        Case aux(0).ToLower & " " & "@TasaOCuota".ToLower
                            tasa = dgvImpuestos.Rows(row.Index).Cells(cell2.Name).Value.ToString * 100
                    End Select
                Next

                'CONSULTAMOS SI EL IMPUESTO ESTA CONFIGURADO
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from impuesto_config where tipo = '" & tipo & "' and tipo_factor = '" & calculo & "' and tasa_cuota = '" & tasa & "' and impuesto = '" & impuesto & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        bandera = True
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()

                If bandera = False Then
                    For Each row2 As DataGridViewRow In dgvImpSC.Rows
                        If row2.Cells(0).Value = calculo And row2.Cells(1).Value = tasa And row2.Cells(2).Value = impuesto And row2.Cells(3).Value = tipo Then
                            band = True
                        End If
                    Next

                    If band = False Then
                        dgvImpSC.Rows.Add(calculo, tasa, impuesto, tipo)
                    End If

                    If dgvImpSC.Rows.Count = 0 Then
                        dgvImpSC.Rows.Add(calculo, tasa, impuesto, tipo)
                    End If
                End If

                Return bandera
            End If
        Catch ex As Exception

        End Try
        Return True
    End Function

    Public Function get_uuid_pagos() As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_documento As String = ""
        Dim band As Boolean = False
        Dim band2 As Boolean = True

        For Each row As DataGridViewRow In dgvPagos.Rows
            id_documento = ""
            band = False

            id_documento = row.Cells("@IdDocumento").Value

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select * from factura where uuid = '" & id_documento & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    band = True
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If band = False Then
                dgvSXML.Rows.Add(id_documento)
                band2 = False
            End If
        Next

        Return band2
    End Function

    Public Function get_nodo_impuestos(ByVal tipo As String) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bandera As Boolean = False

        Dim calculo As String = "EXENTO"
        Dim tasa As String = "0"
        Dim impuesto As String = "IVA"

        If dgvImpuestos.Rows.Count = 0 Then
            'CONSULTAMOS SI EL IMPUESTO ESTA CONFIGURADO
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select * from impuesto_config where tipo = '" & tipo & "' and tipo_factor = '" & calculo & "' and tasa_cuota = '" & tasa & "' and impuesto = '" & impuesto & "' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    bandera = True
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If bandera = False Then
                For Each row2 As DataGridViewRow In dgvImpSC.Rows
                    If row2.Cells(0).Value = calculo And row2.Cells(1).Value = tasa And row2.Cells(2).Value = impuesto And row2.Cells(3).Value = tipo Then
                        band = True
                    End If
                Next

                If band = False Then
                    dgvImpSC.Rows.Add(calculo, tasa, impuesto, tipo)
                End If

                If dgvImpSC.Rows.Count = 0 Then
                    dgvImpSC.Rows.Add(calculo, tasa, impuesto, tipo)
                End If
            End If

            Return bandera
        End If

        Return True
    End Function
#End Region

    Private Sub btnCargaXML_Click(sender As Object, e As EventArgs) Handles btnCargaXML.Click
        dgvRutas.Rows.Clear()

        Dim ofd As New OpenFileDialog()

        With ofd
            .Filter = "XML|*.xml"
            .Title = "Open File"
            .Multiselect = True
        End With

        Dim contador As Integer = 0
        If ofd.ShowDialog() = DialogResult.OK Then
            For Each cadena In ofd.FileNames
                dgvRutas.Rows.Add(ofd.FileNames(contador))
                contador += 1
            Next
        End If

        alta_xml()
    End Sub

    Private Sub AÑADIRCONFIGURACIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AÑADIRCONFIGURACIÓNToolStripMenuItem.Click
        Dim indice As Integer = dgvRFC.CurrentRow.Index.ToString

        scrAltaRFC.cbTipo.Text = dgvRFC.Rows(indice).Cells(2).Value
        scrAltaRFC.tbRFC.Text = dgvRFC.Rows(indice).Cells(1).Value
        scrAltaRFC.tbNombre.Text = dgvRFC.Rows(indice).Cells(0).Value

        scrAltaRFC.btnNuevo.Visible = False
        scrAltaRFC.btnEdit.Visible = False
        scrAltaRFC.btnElimina.Visible = False
        scrAltaRFC.tsbGuardar.Visible = True
        scrAltaRFC.btnGuardarEdi.Visible = False
        scrAltaRFC.btnCancelEdit.Visible = True
        scrAltaRFC.btnAddCuenta.Visible = True

        scrAltaRFC.cbTipo.Enabled = True
        scrAltaRFC.tbNombre.Enabled = True
        scrAltaRFC.tbRFC.Enabled = True
        scrAltaRFC.cbCargo.Enabled = True
        scrAltaRFC.cbAbono.Enabled = True
        scrAltaRFC.cbCuentas.Enabled = True

        scrAltaRFC.Show()
    End Sub

    Private Sub AÑADIRCONFIGURACIÓNToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AÑADIRCONFIGURACIÓNToolStripMenuItem1.Click
        Dim indice As Integer = dgvImpSC.CurrentRow.Index.ToString

        scrAltaImpuestos.cbTipo.Text = dgvImpSC.Rows(indice).Cells(3).Value
        scrAltaImpuestos.cbFactor.Text = dgvImpSC.Rows(indice).Cells(0).Value
        scrAltaImpuestos.tbTasaCuota.Text = dgvImpSC.Rows(indice).Cells(1).Value
        scrAltaImpuestos.cbImpuesto.Text = dgvImpSC.Rows(indice).Cells(2).Value

        scrAltaImpuestos.Show()

        scrAltaImpuestos.btnNuevo.Visible = False
        scrAltaImpuestos.btnGuardar.Visible = True
        scrAltaImpuestos.btnGuardaE.Visible = False
        scrAltaImpuestos.btnEdit.Visible = False
        scrAltaImpuestos.btnCancelEdit.Visible = True
        scrAltaImpuestos.btnElimina.Visible = False
        scrAltaImpuestos.btnNCuenta.Visible = True

        scrAltaImpuestos.cbTipo.Enabled = True
        scrAltaImpuestos.cbFactor.Enabled = True
        scrAltaImpuestos.tbTasaCuota.Enabled = True
        scrAltaImpuestos.cbImpuesto.Enabled = True
        scrAltaImpuestos.cbCargo.Enabled = True
        scrAltaImpuestos.cbAbono.Enabled = True
        scrAltaImpuestos.lbAbono.Enabled = True
        scrAltaImpuestos.lbCargo.Enabled = True
    End Sub
End Class