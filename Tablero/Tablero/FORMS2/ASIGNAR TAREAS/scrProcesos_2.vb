Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports iTextSharp.text.pdf
Imports System.IO
Imports System.ComponentModel
Imports System.Drawing

Imports System.Data.OleDb

Public Class scrProcesos_2
    Public id_detalle As Integer = 0
    Dim id_proceso As Integer = 0
    Public id_ot As Integer = 0
    Public id_unidad As Integer = 0

    Dim clave_proceso As String = ""
    Dim fila_edit As Integer = 0
    Public nombre_detalle As String = ""

    Public claves As String = ""
    Public mro As String = ""
    Public tratamiento As String = ""
    Public cantidad As String = ""
    Public cliente As String = ""
    Public usuario As String = ""

#Region "FUNCIONES"
    Public Sub init_procesos()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        lvProcesos.Items.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from proceso where estado = 1", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim lista As ListViewItem
                lista = New ListViewItem(resultado.GetString("clave"))
                lista.SubItems.Add(resultado.GetString("id_proceso"))
                lvProcesos.Items.Add(lista)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub proceso_seleccionado()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvEstacion.Rows.Clear()

        For i As Int16 = 0 To lvProcesos.SelectedIndices.Count - 1
            id_proceso = lvProcesos.Items(lvProcesos.SelectedIndices(i)).SubItems(1).Text
            clave_proceso = lvProcesos.Items(lvProcesos.SelectedIndices(i)).Text
        Next

        'LLENAMOS DATAGRID
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from estacion where id_proceso = '" & id_proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvEstacion.Rows.Add(resultado.GetString("id_estacion"), resultado.GetString("nombre"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Function condiciones() As Boolean
        If id_detalle = 0 Then
            MessageBox.Show("Indique una pieza para poder continuar", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If id_proceso = 0 Then
            MessageBox.Show("Indique un proceso para poder continuar", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(2).Visible = True Then
                Return True
            End If
        Next

        MessageBox.Show("Indique una estación", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Return False
    End Function

    Public Sub agrega_pieza_proceso()
        Dim id_estacion As Integer = 0
        Dim estacion As String = ""

        Dim bandera As Boolean = False
        Dim cont As Integer = 1

        If btnAgregaP.Text = "Modificar" Then
            dgvAux.Rows.Remove(dgvAux.Rows(fila_edit))
            For Each row As DataGridViewRow In dgvAux.Rows
                row.Cells(3).Value = cont
                cont += 1
            Next
        End If

        dgvPP.Rows.Clear()

        'ID DE ESTACIÓN
        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(2).Value = True Then
                id_estacion = row.Cells(0).Value
                estacion = row.Cells(1).Value
            End If
        Next

        'CONDICIONES PARA AGREAGAR UN NUEVO PROCESO
        For Each row As DataGridViewRow In dgvAux.Rows
            If row.Cells(3).Value = tbNumProc.Text Then
                If row.Cells(9).Value = "TERMINADO" Or row.Cells(9).Value = "EN CURSO" Then
                    MessageBox.Show(" No se puede agregar este proceso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Return
                End If
            End If
        Next

        'AGREGAMOS EL NUEVO PROCESO EN EL LUGAR CORRESPONDIENTE
        For Each row As DataGridViewRow In dgvAux.Rows
            If row.Cells(3).Value < tbNumProc.Text Then
                dgvPP.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
            ElseIf row.Cells(3).Value = tbNumProc.Text Then
                dgvPP.Rows.Add(id_detalle, id_proceso, id_estacion, tbNumProc.Text, clave_proceso, dtpF_Interna.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), rtbObservacion.Text, estacion, tbHoras.Text, "")
                dgvPP.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value + 1, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
                bandera = True
            ElseIf row.Cells(3).Value > tbNumProc.Text Then
                dgvPP.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value + 1, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
            End If
        Next

        If bandera = False Then
            dgvPP.Rows.Add(id_detalle, id_proceso, id_estacion, dgvPP.Rows.Count + 1, clave_proceso, dtpF_Interna.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), rtbObservacion.Text, estacion, tbHoras.Text)
        End If

        'ACTUALIZAMOS EL AUXILIAR
        dgvAux.Rows.Clear()
        For Each row As DataGridViewRow In dgvPP.Rows
            dgvAux.Rows.Add(row.Cells(0).Value, row.Cells(1).Value, row.Cells(2).Value, row.Cells(3).Value, row.Cells(4).Value, row.Cells(5).Value, row.Cells(6).Value, row.Cells(7).Value, row.Cells(8).Value, row.Cells(9).Value)
        Next

        dgvEstacion.Rows.Clear()
        'tbNumProc.Text = 0
        tbHoras.Text = "0"
        rtbObservacion.Text = ""
        btnAgregaP.Text = "Agregar"
    End Sub

    Public Sub init_detalle()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvDetalle.Rows.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from detalle where id_unidad = '" & id_unidad & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvDetalle.Rows.Add(resultado.GetString("id_detalle"),
                                    resultado.GetString("mro"),
                                    resultado.GetString("tratamiento"),
                                    resultado.GetString("cantidad"),
                                    resultado.GetString("observaciones"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub elimina_proceso()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim indice As Integer = dgvPP.CurrentRow.Index.ToString()
        Dim numero_prc As String = dgvPP.Rows(indice).Cells(3).Value
        Dim id_proceso As String = dgvPP.Rows(indice).Cells(1).Value

        Dim cont As Integer = 1
        Dim result As Integer = 0

        'CONDICIONES PARA ELIMINAR
        result = MessageBox.Show("¿Desea eliminar este proceso?", "Control DMM(C) 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.No Then
            Return
        End If

        If dgvPP.Rows(indice).Cells(9).Value = "TERMINADO" Or dgvPP.Rows(indice).Cells(9).Value = "EN CURSO" Then
            MessageBox.Show(" No se puede modificar el proceso si ya esta terminado o en curso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        'ELIMINAMOS LA FILA
        dgvPP.Rows.Remove(dgvPP.CurrentRow)

        'ELIMINAMOS DE LA BASE
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" delete from proceso_ot where id_detalle = '" & id_detalle & "' and id_proceso = '" & id_proceso & "' and num_proc = '" & numero_prc & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'REORDENAMOS LA TABLA y ACTUALIZAMOS LA BASE
        For Each row As DataGridViewRow In dgvPP.Rows
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" update proceso_ot set num_proc = '" & cont & "' where id_detalle = '" & id_detalle & "' and id_proceso = '" & row.Cells(1).Value & "' and num_proc = '" & row.Cells(3).Value & "'  ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            row.Cells(3).Value = cont
            cont = cont + 1
        Next

    End Sub

    Public Sub get_detalle()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim indice As Integer = dgvDetalle.CurrentRow.Index
        id_detalle = dgvDetalle.Rows(indice).Cells(0).Value
        nombre_detalle = dgvDetalle.Rows(indice).Cells(1).Value
        mro = dgvDetalle.Rows(indice).Cells(1).Value
        tratamiento = dgvDetalle.Rows(indice).Cells(2).Value
        cantidad = dgvDetalle.Rows(indice).Cells(3).Value

        btnEditar.Visible = True
        btnAgreegaP.Visible = True
        btnGuarda.Visible = False
        btnCancelaEdi.Visible = False
        'btnGeneraCB.Visible = True
        'btnGeneraCB2.Visible = True
        btnGeneraCb3.Visible = True
        btnCreaL.Visible = True
        btnCargaL.Visible = True

        dgvPP.Rows.Clear()
        dgvAux.Rows.Clear()

        'CONSULTAMOS SI YA TIENE TAREAS ASIGNADAS
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select po.id_detalle, po.id_proceso, po.id_estacion, po.num_proc, p.clave, po.fecha_interna, po.observaciones ,e.nombre, po.tiempo, po.estado from proceso_ot po join (proceso p, estacion e) on (po.id_proceso = p.id_proceso and e.id_estacion = po.id_estacion)  where id_detalle = '" & id_detalle & "' order by num_proc ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvPP.Rows.Add(resultado.GetString("id_detalle"), resultado.GetString("id_proceso"), resultado.GetString("id_estacion"), resultado.GetString("num_proc"), resultado.GetString("clave"), resultado.GetDateTime("fecha_interna").ToString("dd/MM/yyyy hh:mm:ss tt"), resultado.GetString("observaciones"), resultado.GetString("nombre"), resultado.GetString("tiempo"), resultado.GetString("estado"))
                dgvAux.Rows.Add(resultado.GetString("id_detalle"), resultado.GetString("id_proceso"), resultado.GetString("id_estacion"), resultado.GetString("num_proc"), resultado.GetString("clave"), resultado.GetDateTime("fecha_interna").ToString("dd/MM/yyyy hh:mm:ss tt"), resultado.GetString("observaciones"), resultado.GetString("nombre"), resultado.GetString("tiempo"), resultado.GetString("estado"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        tbNumProc.Text = dgvPP.Rows.Count + 1
    End Sub

    Public Sub genera_cb()
        Dim codigo As String
        Dim claves As String

        Dim ds As New dsCb
        Dim cr As New crCb
        Dim r As New scrVistaPrevia

        claves = tbProyecto.Text & "." & tbSerie.Text & "." & tbCliente.Text & "." & nombre_detalle
        codigo = id_ot & "." & id_unidad & "." & id_detalle

        'GENERAMOS EL CODIGO DE BARRAS
        Try
            Dim alto As Single = 0
            Dim bm As Bitmap = Nothing
            bm = class_codigo_barras.codigo_cb(codigo)
            pbCodigo.BackgroundImage = bm
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'DECLARAMOS UNA VARIABLE PARA GUARDAR LA IMAGEN
        Dim arrayBin As Byte()

        'Convertimos la imágen a binario por medio de la función y guardamos el resultado en un arreglo Byte
        arrayBin = ImgToBin(Me.pbCodigo.BackgroundImage)

        ds.dtCodigoBarras.AdddtCodigoBarrasRow(claves, arrayBin)

        cr.SetDataSource(ds)
        r.crv1.ReportSource = cr
        r.ShowDialog()
        cr.Close()
        ds.Clear()
    End Sub

    Public Function ImgToBin(ByVal pic As Image) As Byte()
        'Evaluamos que la imágen contenga datos
        If Not pic Is Nothing Then
            'Variable para almacenar la imágen como stream(flujo de datos)
            Dim bin As New MemoryStream

            'Convertimos a binario Raw
            pic.Save(bin, Imaging.ImageFormat.Jpeg)

            'Regresa la imágen ya en binario, pero contenida en un arreglo
            Return bin.GetBuffer
        Else
            Return Nothing
        End If
    End Function

    Public Function BinToImg(ByVal arrayBin As Byte()) As Image
        'Manejo de Excepción
        Try
            'Evaluamos que el arreglo contenga datos
            If Not (arrayBin) Is Nothing Then
                'Guardamos en una variable el flujo de datos del arreglo
                Dim bin As New MemoryStream(arrayBin)

                'Por medio del método FromStream construimos la imágen
                Dim imgReConstruida As Image = Image.FromStream(bin)

                'Regresamos la imágen como objeto
                Return imgReConstruida
            Else
                Return Nothing
            End If
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Public Sub GridAExcel(ByVal ElGrid As DataGridView)
        'Dim Ejemplo As String

        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet

        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()

            Dim saveFileDialog1 As New SaveFileDialog()

            'saveFileDialog1.FileName = lb_Serie.Text & "_" & lb_Folio.Text & "_" & cbProveedor.Text
            'Ejemplo = tbFolio.Text & "_" & cbProyecto.Text & "_" & cbCliente.Text & ".xlsx"
            'MsgBox(Ejemplo)

            If saveFileDialog1.FileName <> "" Then
                'exLibro.SaveAs(Ejemplo)
                MessageBox.Show("Layout generado", "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

            exApp.Application.Visible = True
            exLibro.Close()
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
        End Try

    End Sub

    Public Function importarExcelNominarfc(ByVal tabla As DataGridView) As Boolean
        Dim myFileDialog As New OpenFileDialog()
        'Dim xSheet As String = ""

        'Activamos los filtros y mostramos el cuadro de abrir archivo
        With myFileDialog
            .Filter = "Excel 2007|*.xlsx"
            .Title = "Open File"
            .InitialDirectory = "C:\Documentos"
        End With
        'Dentro de un IF comprobamos que exista una ruta al archivo

        Dim result As DialogResult = myFileDialog.ShowDialog()
        If result = Windows.Forms.DialogResult.OK Then
            If myFileDialog.FileName.ToString <> "" Then
                Dim ExcelFile As String = myFileDialog.FileName.ToString
                Dim dataset As New DataSet
                Dim datadapter As OleDbDataAdapter
                Dim datatable As DataTable
                Dim conn As OleDbConnection

                'Generamos el objeto de la conexión para abrir el archivo
                conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + ExcelFile + ";Extended Properties=Excel 12.0;")

                'Dentro de un TRY abrimos el archivo para manejar las excepciones
                Try
                    datadapter = New OleDbDataAdapter("SELECT * FROM [Hoja2$]", conn)
                    conn.Open()
                    datadapter.Fill(dataset, "MyData")
                    datatable = dataset.Tables("MyData")
                    tabla.DataSource = dataset
                    tabla.DataMember = "MyData"
                    conn.Close()
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    conn.Close()
                End Try

                Return True
            End If
            Return False
        Else
            Return False
        End If
        ' MsgBox("Información Actualizada", MsgBoxStyle.Information, "Importación Finalizada")
    End Function

    Public Sub save_tareas()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim estado As String = ""

        If dgvPP.Rows.Count = 0 Then
            MessageBox.Show("Sin tareas asignadas", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'CONSULTAMOS SI SE PUEDE ASIGNAR TAREAS
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from historial where id_detalle = '" & id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                If resultado.GetString("id_proceso") = 0 Then
                    MessageBox.Show("Este detalle ya se encuentra en curso", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return
                End If
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'ELIMINAMOS LOS PROCESOS DADOS DE ALTA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("delete from proceso_ot where id_detalle = '" & id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        For Each rows As DataGridViewRow In dgvPP.Rows
            If rows.Cells(9).Value Is Nothing Then
                estado = ""
            Else
                estado = rows.Cells(9).Value
            End If

            datos.id = id_detalle                   'ID_ORDEN_TRABAJO
            datos.id_polizas = rows.Cells(1).Value  'ID_PROCESO
            datos.total = rows.Cells(2).Value       'ID_ESTACION
            datos.fecha = rows.Cells(5).Value       'FECHA_INTERNA
            datos.cel = rows.Cells(6).Value         'OBSERVACIONES
            datos.ciudad = rows.Cells(3).Value      'NÚMERO PROCESO
            datos.clave = estado                    'ESTADO
            datos.colonia = rows.Cells(8).Value     'HORAS DE TRABAJO

            conexion.insert_proceso_ot2(datos)
        Next

        dgvPP.Rows.Clear()
        dgvAux.Rows.Clear()
        dgvEstacion.Rows.Clear()
        rtbObservacion.Clear()
        tbHoras.Clear()
        tbNumProc.Clear()

        btnEditar.Visible = False
        btnAgreegaP.Visible = False
        btnGuarda.Visible = False
        btnCancelaEdi.Visible = False
        'btnGeneraCB.Visible = False
        'btnGeneraCB2.Visible = True
        btnGeneraCb3.Visible = False
        btnAgregaP.Enabled = False
        btnCargaL.Visible = False
        btnCreaL.Visible = False
    End Sub
#End Region

    Private Sub dgvDetalle_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDetalle.CellClick
        get_detalle()
    End Sub

    Private Sub btnAgreegaP_Click(sender As Object, e As EventArgs) Handles btnAgreegaP.Click
        scrProcesos.Show()
        scrProcesos.BringToFront()
    End Sub

    Private Sub lvProcesos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProcesos.SelectedIndexChanged
        proceso_seleccionado()
    End Sub

    Private Sub dgvEstacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstacion.CellContentClick
        Dim indice As Integer = dgvEstacion.CurrentRow.Index.ToString

        For Each row As DataGridViewRow In dgvEstacion.Rows
            row.Cells(2).Value = False
        Next

        dgvEstacion.Rows(indice).Cells(2).Value = True
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnAgregaP.Enabled = True
        btnCancelaEdi.Visible = True
        btnEditar.Visible = False
        btnGuarda.Visible = True
    End Sub

    Private Sub btnCancelaEdi_Click(sender As Object, e As EventArgs) Handles btnCancelaEdi.Click
        btnAgregaP.Enabled = False
        btnCancelaEdi.Visible = False
        btnEditar.Visible = True
        btnGuarda.Visible = False
        'btnGeneraCB.Visible = False
        btnGeneraCB2.Visible = False
    End Sub

    Private Sub btnAgregaP_Click(sender As Object, e As EventArgs) Handles btnAgregaP.Click
        If condiciones() Then
            agrega_pieza_proceso()
        End If
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        save_tareas()
        MessageBox.Show("Tareas guardadas con éxito", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub CAMBIARESTACIÓNToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CAMBIARESTACIÓNToolStripMenuItem.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim indice As Integer = dgvPP.CurrentRow.Index.ToString
        Dim id_estacion As Integer = 0
        fila_edit = indice

        'VERIFICAMOS EL ESTADO DEL PROCESO
        If dgvPP.Rows(indice).Cells(7).Value = "TERMINADO" Or dgvPP.Rows(indice).Cells(7).Value = "EN CURSO" Then
            MessageBox.Show(" No se puede modificar el proceso si ya esta terminado o en curso ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        id_proceso = dgvPP.Rows(indice).Cells(1).Value
        clave_proceso = dgvPP.Rows(indice).Cells(4).Value
        id_estacion = dgvPP.Rows(indice).Cells(2).Value

        dtpF_Interna.Value = dgvPP.Rows(indice).Cells(5).Value
        tbNumProc.Text = dgvPP.Rows(indice).Cells(3).Value
        tbHoras.Text = dgvPP.Rows(indice).Cells(8).Value
        rtbObservacion.Text = dgvPP.Rows(indice).Cells(6).Value

        dgvEstacion.Rows.Clear()

        'LLENAMOS DATAGRID
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from estacion where id_proceso = '" & id_proceso & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvEstacion.Rows.Add(resultado.GetString("id_estacion"), resultado.GetString("nombre"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(0).Value = id_estacion Then
                row.Cells(2).Value = True
            End If
        Next

        btnAgregaP.Text = "Modificar"

    End Sub

    Private Sub ELIMINARTAREAToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ELIMINARTAREAToolStripMenuItem.Click
        elimina_proceso()
        get_detalle()
    End Sub

    Private Sub btnGeneraCB_Click(sender As Object, e As EventArgs) Handles btnGeneraCB.Click
        genera_cb()
    End Sub

    Private Sub btnGeneraCB2_Click(sender As Object, e As EventArgs) Handles btnGeneraCB2.Click
        Dim codigo As String
        Dim claves As String

        Dim ds As New dsCb2
        Dim cr As New crCB2
        Dim r As New scrVistaPrevia

        claves = tbProyecto.Text & "." & tbSerie.Text & "." & tbCliente.Text & "." & nombre_detalle
        codigo = id_ot & "." & id_unidad & "." & id_detalle

        'GENERAMOS EL CODIGO DE BARRAS
        Try
            Dim alto As Single = 0
            Dim bm As Bitmap = Nothing
            bm = class_codigo_barras.codigo_cb(codigo)
            pbCodigo.BackgroundImage = bm
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'DECLARAMOS UNA VARIABLE PARA GUARDAR LA IMAGEN
        Dim arrayBin As Byte()

        'Convertimos la imágen a binario por medio de la función y guardamos el resultado en un arreglo Byte
        arrayBin = ImgToBin(Me.pbCodigo.BackgroundImage)

        ds.dtGeneral.AdddtGeneralRow(arrayBin, tbProyecto.Text, "", "", tbSerie.Text, tbCliente.Text, nombre_detalle)

        For Each row As DataGridViewRow In dgvPP.Rows
            ds.dtDetalle.AdddtDetalleRow(row.Cells(4).Value, row.Cells(7).Value, row.Cells(5).Value, row.Cells(6).Value)
        Next

        cr.SetDataSource(ds)
        r.crv1.ReportSource = cr
        r.ShowDialog()
        cr.Close()
        ds.Clear()
    End Sub

    Private Sub btnGeneraCb3_Click(sender As Object, e As EventArgs) Handles btnGeneraCb3.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim extras As String = ""

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cliente = resultado.GetString("cliente")
                usuario = resultado.GetString("usuario")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Try
            My.Computer.FileSystem.DeleteFile("C:\Imagen\Imagen_" & mro & "_" & id_detalle & ".jpg")
        Catch ex As Exception

        End Try

        Dim codigo As String

        Dim ds As New dsCb
        Dim cr As New crCb
        Dim r As New scrVistaPrevia

        claves = tbProyecto.Text & "." & tbSerie.Text & "." & tbCliente.Text & "." & nombre_detalle & vbLf & extras
        codigo = id_ot & "." & id_unidad & "." & id_detalle

        'GENERAMOS EL CODIGO DE BARRAS
        Try
            Dim alto As Single = 0
            Dim bm As Bitmap = Nothing
            bm = class_codigo_barras.codigo_cb(codigo)
            pbCodigo.BackgroundImage = bm
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        scrCargaPDF.Show()
        scrCargaPDF.BringToFront()
    End Sub

    Private Sub scrProcesos_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim col As New DataGridViewTextBoxColumn
        col.Name = "DETALLE"
        dgvConfig.Columns.Add(col)

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select * from proceso where estado = 1 ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim col2 As New DataGridViewTextBoxColumn
                col2.Name = resultado.GetString("clave")
                dgvConfig.Columns.Add(col2)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select d.mro from detalle d join(unidad u,orden_trabajo ot) on (d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) where ot.id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                dgvConfig.Rows.Add(resultado.GetString("mro"))
            End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()
    End Sub

    Private Sub btnCreaL_Click(sender As Object, e As EventArgs) Handles btnCreaL.Click
        GridAExcel(dgvConfig)
    End Sub

    Private Sub btnCargaL_Click(sender As Object, e As EventArgs) Handles btnCargaL.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvConfig.Columns.Clear()
        importarExcelNominarfc(dgvConfig)

        Dim id_proceso As Integer = 0
        Dim id_estacion As Integer = 0
        Dim band As Boolean = True

        'VERIFICAMOS QUE CORRESPONDA EL EXCEL A LOS DETALLES DEL PROYECTO
        For Each row As DataGridViewRow In dgvConfig.Rows
            band = True

            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" select * from detalle d join(unidad u,orden_trabajo ot) on (d.id_unidad = u.id_unidad and u.id_ot = ot.id_ot) where ot.id_ot = '" & id_ot & "' and d.mro = '" & row.Cells(0).Value & "' ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    band = False
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()
            If band Then
                MessageBox.Show("Detalles no correspondientes al proyecto", "Control DMM", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        'GUARDAMOS LOS DETALLES
        For Each row As DataGridViewRow In dgvConfig.Rows
            dgvPP.Rows.Clear()
            'OBTENEMOS ID DEL DETALLE
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand(" select * from detalle where id_unidad = '" & id_unidad & "' and mro = '" & row.Cells(0).Value & "' ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    id_detalle = resultado.GetInt32("id_detalle")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()
            For Each column As DataGridViewColumn In dgvConfig.Columns
                If column.Name <> "DETALLE" Then
                    'OBTENEMOS ID DEL PROCESO
                    Try
                        conexion_GlobalSI()
                        _conexionSI.Open()
                        comandoSql = New MySqlCommand(" select * from proceso where clave = '" & column.Name.ToString & "' ", _conexionSI)
                        resultado = comandoSql.ExecuteReader
                        'Dentro de un ciclo leemos los resultados
                        While resultado.Read
                            id_proceso = resultado.GetInt32("id_proceso")
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrarSI()
                    End Try
                    _conexionSI.Close()

                    'OBTENEMOS LA PRIMERA ESTACION QUE ENCUENTRE
                    Try
                        conexion_GlobalSI()
                        _conexionSI.Open()
                        comandoSql = New MySqlCommand(" select * from estacion where id_proceso = '" & id_proceso & "' ", _conexionSI)
                        resultado = comandoSql.ExecuteReader
                        'Dentro de un ciclo leemos los resultados
                        While resultado.Read
                            id_estacion = resultado.GetInt32("id_estacion")
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrarSI()
                    End Try
                    _conexionSI.Close()

                    If dgvConfig.Rows(row.Index).Cells(column.Name).Value.ToString.IndexOf(",") > -1 Then
                        Dim aux() As String = dgvConfig.Rows(row.Index).Cells(column.Name).Value.ToString.Split(",")
                        For Each a As String In aux
                            dgvPP.Rows.Add(id_detalle, id_proceso, id_estacion, a, column.Name, DateTime.Now, "", "", "")
                        Next
                    Else
                        If dgvConfig.Rows(row.Index).Cells(column.Name).Value.ToString <> "" Then
                            dgvPP.Rows.Add(id_detalle, id_proceso, id_estacion, dgvConfig.Rows(row.Index).Cells(column.Name).Value.ToString, column.Name, DateTime.Now, "", "", "")
                        End If
                    End If
                End If
                dgvPP.Sort(dgvPP.Columns(3), ListSortDirection.Ascending)
            Next
            save_tareas()
        Next

        MessageBox.Show("Tareas guardadas con éxito", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub
End Class