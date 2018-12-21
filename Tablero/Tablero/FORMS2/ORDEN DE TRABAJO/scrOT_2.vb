Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Imports System.Data.OleDb

Public Class scrOT_2
#Region "VARIABLES GLOBALES"
    Public id_ot As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Sub GridAExcel(ByVal ElGrid As DataGridView)
        Dim Ejemplo As String

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
            Ejemplo = tbFolio.Text & "_" & cbProyecto.Text & "_" & cbCliente.Text & ".xlsx"
            'MsgBox(Ejemplo)

            If saveFileDialog1.FileName <> "" Then
                exLibro.SaveAs(Ejemplo)
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

    Public Function primera_fecha(ByVal mes As String) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where folio like '%___-" & mes & "-__' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Return False
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Return True
    End Function

    Public Sub check_folio()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim serie As String = ""

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where serie = '" & cbSerie.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                serie = resultado.GetString("folio")
                serie = serie.Substring(0, 3)
                serie = Convert.ToInt64(serie) + 1

                Select Case serie.Length
                    Case "1"
                        tbFolio.Text = "00" & serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                    Case "2"
                        tbFolio.Text = "0" & serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                    Case "3"
                        tbFolio.Text = serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                End Select
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If primera_fecha(DateTime.Now.ToString("MM")) Then
            tbFolio.Text = "001" & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
        End If
    End Sub
#End Region

    Private Sub scrOT_2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'INICIAMOS CLIENTE
        cbCliente.Items.Clear()
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select distinct cliente from orden_trabajo order by cliente", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbCliente.Items.Add(resultado.GetString("cliente"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'INICIAMOS PROYECTO
        cbProyecto.Items.Clear()
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select distinct proyecto from orden_trabajo order by proyecto", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbProyecto.Items.Add(resultado.GetString("proyecto"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'INICIAMOS USUARIO
        cbUsuario.Items.Clear()
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select distinct usuario from orden_trabajo order by usuario", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbUsuario.Items.Add(resultado.GetString("usuario"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'INICIAMOS FOLIO
        cbSerie.Items.Clear()
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select distinct serie from orden_trabajo order by serie", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                cbSerie.Items.Add(resultado.GetString("serie"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Private Sub btnAgrega_Click(sender As Object, e As EventArgs) Handles btnAgrega.Click
        scrUnidad.id_ot = id_ot
        scrUnidad.init_unidad()
        scrUnidad.Show()
        scrUnidad.BringToFront()
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbCliente.Text = "" Then
            MessageBox.Show(" Cliente obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCliente.Focus()
            Return
        End If

        If cbProyecto.Text = "" Then
            MessageBox.Show(" Proyecto obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbProyecto.Focus()
            Return
        End If

        If cbUsuario.Text = "" Then
            MessageBox.Show(" Usuario obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUsuario.Focus()
            Return
        End If

        If cbSerie.Text = "" Or tbFolio.Text = "" Then
            MessageBox.Show(" Serie y Folio obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSerie.Focus()
            Return
        End If

        If dgvPiezas.Rows.Count = 0 Then
            MessageBox.Show(" Sin piezas por añadir ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        check_folio()

        datos.unidadr = cbCliente.Text                  'CLIENTE
        datos.uuid = cbProyecto.Text                    'PROYECTO
        datos.calle = cbUsuario.Text                    'USUARIO
        datos.cel = cbSerie.Text                        'SERIE
        datos.ciudad = tbFolio.Text                     'FOLIO
        datos.clave = tbNumCot.Text                     'NÚMERO COTIZACIÓN
        datos.fecha = dtpFechaE.Value                   'FECHA ELABORACIÓN
        datos.fecha2 = dtpFen.Value                     'FECHA ENTREGA
        datos.id = 0                                    'ID USUARIO
        datos.nombre = tbUsuario.Text                   'USUARIO CREADOR
        datos.colonia = tbOC.Text                       'ORDEN DE COMPRA
        datos.contrato = tbNotas.Text                   'NOTAS
        datos.correo = tbInfCNC.Text                    'INFORMACION CNC

        If conexion.insert_orden_trabajo(datos) Then
            'OBTENEMOS ID DEL ULTIMO REGISTRO
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand("select * from orden_trabajo", _conexionSI)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    id_ot = resultado.GetDecimal("id_ot")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            For Each row As DataGridViewRow In dgvPiezas.Rows
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" update unidad set id_ot = '" & id_ot & "' where id_unidad = '" & row.Cells(0).Value & "' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Next

            scrMenuOT.init_menu_ot()
            MessageBox.Show(" Orden de Trabajo creada con éxito ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()

        Else
            MessageBox.Show(" Error ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbSerie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSerie.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim serie As String = ""

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where serie = '" & cbSerie.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                serie = resultado.GetString("folio")
                serie = serie.Substring(0, 3)
                serie = Convert.ToInt64(serie) + 1

                Select Case serie.Length
                    Case "1"
                        tbFolio.Text = "00" & serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                    Case "2"
                        tbFolio.Text = "0" & serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                    Case "3"
                        tbFolio.Text = serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                End Select
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If primera_fecha(DateTime.Now.ToString("MM")) Then
            tbFolio.Text = "001" & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
        End If
    End Sub

    Private Sub EDITARDETALLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EDITARDETALLEToolStripMenuItem.Click
        Dim indice As Integer = dgvPiezas.CurrentRow.Index

        scrDetalle.id_unidad = dgvPiezas.Rows(indice).Cells(0).Value
        scrDetalle.tbUnidad.Text = dgvPiezas.Rows(indice).Cells(1).Value
        scrDetalle.tbOrdenT.Text = cbSerie.Text & " - " & tbFolio.Text

        scrDetalle.init_detalle()
        scrDetalle.Show()
        scrDetalle.BringToFront()
    End Sub

    Private Sub ASIGNARTAREASToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ASIGNARTAREASToolStripMenuItem.Click
        Dim indice As Integer = dgvPiezas.CurrentRow.Index

        scrProcesos_2.tbProyecto.Text = cbProyecto.Text
        scrProcesos_2.tbSerie.Text = cbSerie.Text & " - " & tbFolio.Text
        scrProcesos_2.tbCliente.Text = dgvPiezas.Rows(indice).Cells(1).Value
        scrProcesos_2.id_unidad = dgvPiezas.Rows(indice).Cells(0).Value
        scrProcesos_2.id_ot = id_ot

        scrProcesos_2.init_detalle()
        scrProcesos_2.init_procesos()
        scrProcesos_2.Show()
        scrProcesos_2.BringToFront()
    End Sub

    Private Sub btnGuardaAct_Click(sender As Object, e As EventArgs) Handles btnGuardaAct.Click
        Dim datos As New class_datos
        Dim conexion As New class_update_datos

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbCliente.Text = "" Then
            MessageBox.Show(" Cliente obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCliente.Focus()
            Return
        End If

        If cbProyecto.Text = "" Then
            MessageBox.Show(" Proyecto obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbProyecto.Focus()
            Return
        End If

        If cbUsuario.Text = "" Then
            MessageBox.Show(" Usuario obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUsuario.Focus()
            Return
        End If

        If cbSerie.Text = "" Or tbFolio.Text = "" Then
            MessageBox.Show(" Serie y Folio obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSerie.Focus()
            Return
        End If

        If dgvPiezas.Rows.Count = 0 Then
            MessageBox.Show(" Sin piezas por añadir ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        datos.unidadr = cbCliente.Text                  'CLIENTE
        datos.uuid = cbProyecto.Text                    'PROYECTO
        datos.calle = cbUsuario.Text                    'USUARIO
        datos.fecha = dtpFechaE.Value                   'FECHA ELABORACIÓN
        datos.fecha2 = dtpFen.Value                     'FECHA ENTREGA
        datos.id = id_ot                                'ID OT
        datos.colonia = tbOC.Text                       'ORDEN DE COMPRA
        datos.contrato = tbNotas.Text                   'NOTAS
        datos.correo = tbInfCNC.Text                    'INFORMCACION CNC

        If conexion.update_orden_trabajo(datos) Then
            For Each row As DataGridViewRow In dgvPiezas.Rows
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" update unidad set id_ot = '" & id_ot & "' where id_unidad = '" & row.Cells(0).Value & "' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Next

            scrMenuOT.init_menu_ot()
            MessageBox.Show(" Orden de Trabajo actualizada con éxito ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnAgrega.Visible = True
        btnGuardaAct.Visible = True
        btnCancelaEdit.Visible = True
        btnEditar.Visible = False

        cbCliente.Enabled = True
        cbProyecto.Enabled = True
        cbUsuario.Enabled = True
        dtpFechaE.Enabled = True
        dtpFen.Enabled = True
        tbNotas.Enabled = True
        tbOC.Enabled = True
        tbInfCNC.Enabled = True
    End Sub

    Private Sub btnCancelaEdit_Click(sender As Object, e As EventArgs) Handles btnCancelaEdit.Click
        btnAgrega.Visible = False
        btnGuardaAct.Visible = False
        btnCancelaEdit.Visible = False
        btnEditar.Visible = True

        cbCliente.Enabled = False
        cbProyecto.Enabled = False
        cbUsuario.Enabled = False
        dtpFechaE.Enabled = False
        dtpFen.Enabled = False
    End Sub

    Private Sub btnGenLay_Click(sender As Object, e As EventArgs) Handles btnGenLay.Click
        If cbCliente.Text = "" Then
            MessageBox.Show(" Cliente obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCliente.Focus()
            Return
        End If

        If cbProyecto.Text = "" Then
            MessageBox.Show(" Proyecto obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbProyecto.Focus()
            Return
        End If

        If cbUsuario.Text = "" Then
            MessageBox.Show(" Usuario obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUsuario.Focus()
            Return
        End If

        If cbSerie.Text = "" Or tbFolio.Text = "" Then
            MessageBox.Show(" Serie y Folio obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSerie.Focus()
            Return
        End If
        GridAExcel(dgvExcel)
    End Sub

    Private Sub btnCargaLayout_Click(sender As Object, e As EventArgs) Handles btnCargaLayout.Click
        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bandera As Boolean = True
        Dim id_unidad As Integer = 0

        dgvExcel.Columns.Clear()
        If importarExcelNominarfc(dgvExcel) = False Then
            Return
        End If
        'Return

        check_folio()

        'GUARDAMOS LA CABECERA.
        datos.unidadr = cbCliente.Text                  'CLIENTE
        datos.uuid = cbProyecto.Text                    'PROYECTO
        datos.calle = cbUsuario.Text                    'USUARIO
        datos.cel = cbSerie.Text                        'SERIE
        datos.ciudad = tbFolio.Text                     'FOLIO
        datos.clave = tbNumCot.Text                     'NÚMERO COTIZACIÓN
        datos.fecha = dtpFechaE.Value                   'FECHA ELABORACIÓN
        datos.fecha2 = dtpFen.Value                     'FECHA ENTREGA
        datos.id = 0                                    'ID USUARIO
        datos.nombre = tbUsuario.Text                   'USUARIO CREADOR
        datos.colonia = tbOC.Text                       'ORDEN DE COMPRA
        datos.contrato = tbNotas.Text                   'NOTAS
        datos.correo = tbInfCNC.Text                    'INFORMCACION CNC

        If conexion.insert_orden_trabajo(datos) Then
            'OBTENEMOS ID DEL ULTIMO REGISTRO
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand("select * from orden_trabajo", _conexionSI)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    id_ot = resultado.GetDecimal("id_ot")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            For Each row As DataGridViewRow In dgvExcel.Rows
                If Convert.ToString(row.Cells(0).Value).Trim() = String.Empty Then
                Else
                    'CONSULTAMOS SI YA EXISTE LA UNIDAD
                    Try
                        conexion_GlobalSI()
                        _conexionSI.Open()
                        comandoSql = New MySqlCommand("select * from unidad where clave = '" & row.Cells(0).Value & "' and id_ot = '" & id_ot & "' ", _conexionSI)
                        resultado = comandoSql.ExecuteReader
                        'Dentro de un ciclo leemos los resultados
                        While resultado.Read
                            bandera = False
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrarSI()
                    End Try
                    _conexionSI.Close()

                    'DAMOS DE ALTA LA UNIDAD
                    If bandera Then
                        Try
                            conexion_GlobalSI()
                            _conexionSI.Open()
                            comandoSql = New MySqlCommand(" insert into unidad(clave,descripcion,id_ot) values ('" & row.Cells(0).Value & "', '" & row.Cells(0).Value & "', '" & id_ot & "') ", _conexionSI)
                            resultado = comandoSql.ExecuteReader
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrarSI()
                        End Try
                        _conexionSI.Close()
                    End If

                    'CONSULTAMOS EL ID DE LA UNIDAD
                    Try
                        conexion_GlobalSI()
                        _conexionSI.Open()
                        comandoSql = New MySqlCommand("select * from unidad where clave = '" & row.Cells(0).Value & "' and id_ot = '" & id_ot & "' ", _conexionSI)
                        resultado = comandoSql.ExecuteReader
                        'Dentro de un ciclo leemos los resultados
                        While resultado.Read
                            id_unidad = resultado.GetDecimal("id_unidad")
                        End While
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrarSI()
                    End Try
                    _conexionSI.Close()

                    'DAMOS DE ALTA EL DETALLE
                    Try
                        conexion_GlobalSI()
                        _conexionSI.Open()
                        comandoSql = New MySqlCommand("insert into detalle(id_unidad,mro,tratamiento,cantidad,observaciones) values ('" & id_unidad & "','" & row.Cells(1).Value & "','" & row.Cells(2).Value & "','" & row.Cells(3).Value & "','" & row.Cells(4).Value & "')", _conexionSI)
                        resultado = comandoSql.ExecuteReader
                        resultado.Close()
                    Catch ex As MySqlException
                        MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Finally
                        cerrarSI()
                    End Try
                    _conexionSI.Close()
                End If
                bandera = True
            Next

            scrMenuOT.init_menu_ot()
            MessageBox.Show(" Orden de Trabajo creada con éxito ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        End If
    End Sub

    Private Sub tbFolio_Click(sender As Object, e As EventArgs) Handles tbFolio.GotFocus
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bandera As Boolean = False
        Dim serie As String = ""

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where serie = '" & cbSerie.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                serie = resultado.GetString("folio")
                serie = serie.Substring(0, 3)
                serie = Convert.ToInt64(serie) + 1

                Select Case serie.Length
                    Case "1"
                        tbFolio.Text = "00" & serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                    Case "2"
                        tbFolio.Text = "0" & serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                    Case "3"
                        tbFolio.Text = serie & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
                End Select
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        If primera_fecha(DateTime.Now.ToString("MM")) Then
            tbFolio.Text = "001" & "-" & DateTime.Now.ToString("MM") & "-" & DateTime.Now.ToString("yy")
        End If
    End Sub

    Private Sub btnImprime_Click(sender As Object, e As EventArgs) Handles btnImprime.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim ds As New dsOt
        Dim cr As New crOT
        Dim r As New scrVistaPrevia

        Dim cont As Decimal = 1
        Dim num_p As Decimal = 0
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                ds.General.AddGeneralRow(resultado.GetDateTime("fecha_elab").ToString("dd/MMMM/yyyy"), resultado.GetString("serie") & " " & resultado.GetString("folio"), resultado.GetDateTime("fecha_entrega").ToString("dd/MMMM/yyyy"), resultado.GetString("numero_cotizacion"), resultado.GetString("cliente").ToUpper, resultado.GetString("proyecto").ToUpper, resultado.GetString("usuario").ToUpper, resultado.GetString("notas"), resultado.GetString("orden_compra"), resultado.GetString("inf_cnc"), resultado.GetString("usuario_c").ToUpper)
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
            comandoSql = New MySqlCommand("select * from detalle d join unidad u on (u.id_unidad = d.id_unidad) where u.id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim aux() As String
                If resultado.GetString("cantidad").IndexOf("/") > -1 Then
                    aux = resultado.GetString("cantidad").Split("/")
                    num_p = Convert.ToDecimal(aux(0)) + Convert.ToDecimal(aux(1))
                Else
                    num_p = resultado.GetDecimal("cantidad")
                End If

                ds.Detalle.AddDetalleRow(cont, resultado.GetString("clave").ToUpper, resultado.GetString("mro").ToUpper, resultado.GetString("cantidad"), resultado.GetString("tratamiento").ToUpper, num_p, resultado.GetString("observaciones"))
                cont += 1
                num_p = 0
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        cr.SetDataSource(ds)
        r.crv1.ReportSource = cr
        r.ShowDialog()
        cr.Close()
        ds.Clear()
    End Sub

    Private Sub btnEliminaOT_Click(sender As Object, e As EventArgs) Handles btnEliminaOT.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim result As Integer = MessageBox.Show(" ¿Desea eliminar esta orden de trabajo? ", "Control DMM (C) 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand("update orden_trabajo set estado = 0 where id_ot = '" & id_ot & "' ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            MessageBox.Show(" Orden de Trabajo eliminada con éxito", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
            scrMenuOT.init_menu_ot()
        End If
    End Sub

End Class