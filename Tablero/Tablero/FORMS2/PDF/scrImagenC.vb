Imports System.IO
Imports CrystalDecisions.Shared
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrImagenC
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

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim id_pdf As Integer = 0
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbHorientacion.Text = "" Then
            MessageBox.Show("Indique una Horientación", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Dim ds As New dsPDF
        Dim r As New scrVistaPrevia

        Dim crExportOptions As ExportOptions
        Dim crDiskFileDEstinationOptions As New DiskFileDestinationOptions
        Dim crFormatTypeOptions As New PdfRtfWordFormatOptions

        Dim arrayBin As Byte()
        Dim arrayBin2 As Byte()

        arrayBin = ImgToBin(scrProcesos_2.pbCodigo.BackgroundImage)
        arrayBin2 = ImgToBin(Me.pCorte.Image)

        ds.dtGeneral.AdddtGeneralRow(arrayBin2, arrayBin, scrProcesos_2.claves, scrProcesos_2.tbSerie.Text, scrProcesos_2.cliente, scrProcesos_2.usuario, scrProcesos_2.tbCliente.Text, scrProcesos_2.nombre_detalle, scrProcesos_2.cantidad, scrProcesos_2.tratamiento)

        Dim a As New FolderBrowserDialog
        a.ShowDialog()

        Dim ruta2 As String
        Dim nueva_ruta As String = ""
        ruta2 = a.SelectedPath()
        If Not Directory.Exists(ruta2) Then
            Directory.CreateDirectory(ruta2)
        End If

        If cbHorientacion.Text = "HORIZONTAL" Then
            Dim cr As New crPDF
            cr.SetDataSource(ds)
            r.crv1.ReportSource = cr
            r.ShowDialog()

            crDiskFileDEstinationOptions.DiskFileName = ruta2 & "\" & scrProcesos_2.tbSerie.Text & "-" & scrProcesos_2.tbProyecto.Text & "-" & scrProcesos_2.tbCliente.Text & "-" & scrProcesos_2.mro & ".pdf"
            nueva_ruta = ruta2 & "\" & scrProcesos_2.tbSerie.Text & "-" & scrProcesos_2.tbProyecto.Text & "-" & scrProcesos_2.tbCliente.Text & "-" & scrProcesos_2.mro & ".pdf"
            crExportOptions = cr.ExportOptions

            With crExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = crDiskFileDEstinationOptions
                .FormatOptions = crFormatTypeOptions
            End With

            cr.Export()
            cr.Close()
            ds.Clear()
        Else
            Dim cr_2 As New crPDF_2
            cr_2.SetDataSource(ds)
            r.crv1.ReportSource = cr_2
            r.ShowDialog()

            crDiskFileDEstinationOptions.DiskFileName = ruta2 & "\" & scrProcesos_2.tbSerie.Text & "-" & scrProcesos_2.tbProyecto.Text & "-" & scrProcesos_2.tbCliente.Text & "-" & scrProcesos_2.mro & ".pdf"
            nueva_ruta = ruta2 & "\" & scrProcesos_2.tbSerie.Text & "-" & scrProcesos_2.tbProyecto.Text & "-" & scrProcesos_2.tbCliente.Text & "-" & scrProcesos_2.mro & ".pdf"
            crExportOptions = cr_2.ExportOptions

            With crExportOptions
                .ExportDestinationType = ExportDestinationType.DiskFile
                .ExportFormatType = ExportFormatType.PortableDocFormat
                .DestinationOptions = crDiskFileDEstinationOptions
                .FormatOptions = crFormatTypeOptions
            End With

            cr_2.Export()
            cr_2.Close()
            ds.Clear()
        End If

        'GUARDAMOS PDF
        Try
            Dim strPath As String
            strPath = nueva_ruta
            Dim ruta3 As New FileStream(strPath, FileMode.Open, FileAccess.Read)
            Dim binario(ruta3.Length) As Byte
            ruta3.Read(binario, 0, ruta3.Length) 'Leo el archivo y lo convierto a binario 
            ruta3.Close() 'Cierro el FileStream 

            Dim _adaptador As New MySqlDataAdapter

            Try
                conexion_GlobalSI()
                _adaptador.InsertCommand = New MySqlCommand(" insert into pdf (pdf) values (?)", _conexionSI)
                _adaptador.InsertCommand.Parameters.AddWithValue("pdf", binario)
                _conexionSI.Open()
                _adaptador.InsertCommand.Connection = _conexionSI
                _adaptador.InsertCommand.ExecuteNonQuery()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Rekor 32bits", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
        Catch ex As Exception
            MsgBox("error")
        End Try

        'OBTENEMOS ID DEL ULTIMO REGISTRO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from pdf", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_pdf = resultado.GetDecimal("id_pdf")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'GUARDAMOS ID_PDF EN DETALLE
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("update detalle set id_pdf = '" & id_pdf & "' where id_detalle = '" & scrProcesos_2.id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        MessageBox.Show("PDF guardado", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub
End Class