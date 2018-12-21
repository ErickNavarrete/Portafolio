Imports System.IO
Imports CrystalDecisions.Shared
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.Drawing.Drawing2D

Public Class scrCargaPDF
    Dim ruta As String = ""
    Dim cropX As Integer
    Dim cropY As Integer
    Dim cropWidth As Integer
    Dim cropHeight As Integer

    Dim oCropX As Integer
    Dim oCropY As Integer
    Dim cropBitmap As Bitmap

    Dim val1 As Integer
    Dim val2 As Integer

    Public cropPen As Pen
    Public cropPenSize As Integer = 1 '2
    Public cropDashStyle As Drawing2D.DashStyle = Drawing2D.DashStyle.Solid
    Public cropPenColor As Color = Color.Red

    Dim imagen As String = ""

#Region "FUNCIONES"
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

    Private Sub BytesAArchivo(ByVal bytes() As Byte, ByVal Path As String)
        Dim K As Long
        If bytes Is Nothing Then Exit Sub
        Try
            K = UBound(bytes)
            Dim fs As New FileStream(Path, FileMode.OpenOrCreate, FileAccess.Write)
            fs.Write(bytes, 0, K)
            fs.Close()
        Catch ex As Exception
            Throw New Exception(ex.Message, ex)
        End Try
    End Sub
#End Region

    Private Sub btnCargaPDF_Click(sender As Object, e As EventArgs) Handles btnCargaPDF.Click
        pbEjem.Visible = False
        AxAcroPDF1.Visible = True
        btnZoomIn.Visible = False
        btnZomOut.Visible = False

        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                AxAcroPDF1.src = OpenFileDialog1.FileName
                ruta = OpenFileDialog1.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub btnGeneraCB_Click(sender As Object, e As EventArgs) Handles btnGeneraCB.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim f As New SautinSoft.PdfFocus()
        Dim pdfPath As String = ruta

        Dim resultado2 As String
        Dim id_pdf As Integer = 0

        Dim ds As New dsPDF
        Dim r As New scrVistaPrevia

        Dim crExportOptions As ExportOptions
        Dim crDiskFileDEstinationOptions As New DiskFileDestinationOptions
        Dim crFormatTypeOptions As New PdfRtfWordFormatOptions

        Dim arrayBin As Byte()
        Dim arrayBin2 As Byte()
        Dim image() As Byte

        If cbHorientacion.Text = "" Then
            MessageBox.Show("Indique una Horientación", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        If AxAcroPDF1.Visible = True Then

            If ruta = "" Then
                MessageBox.Show("PDF sin cargar.", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            Try
                resultado2 = InputBox("Indique el número de página a imprimir", "Control DMM (C) 2018")
            Catch ex As Exception
                resultado2 = ""
            End Try

            If resultado2 = "" Then
                MessageBox.Show("Valor inválido", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            f.OpenPdf(pdfPath)
            If f.PageCount > 0 Then
                f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
                f.ImageOptions.Dpi = 200
                f.ImageOptions.Resize(New Size With {.Width = 2100, .Height = 2000}, False)
                image = f.ToImage(resultado2)
                pbPDF.Image = BinToImg(image)
            End If

        End If

        'pbPDF.Image.Save("C:\facturacion33\Imagen.jpg", Drawing.Imaging.ImageFormat.Jpeg)

        arrayBin = ImgToBin(scrProcesos_2.pbCodigo.BackgroundImage)
        arrayBin2 = ImgToBin(Me.pbPDF.Image)

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

    Private Sub btnCargaImagen_Click(sender As Object, e As EventArgs) Handles btnCargaImagen.Click
        pbImagenC.Visible = True
        AxAcroPDF1.Visible = False

        'Variables Locales
        Dim nombreArchivo As String = ""
        Dim ofd As New OpenFileDialog

        'Definición de las propiedades del Open File Dialog
        With ofd
            '.InitialDirectory = "C:\"
            .Filter = "Archivos de Imagen JPG|*.jpg|Todos los archivos|*.*"
            .FilterIndex = 1
            .RestoreDirectory = True
        End With

        'Evaluamos la respuesta del usuario para guardar la ruta y nombre de la imágen, por último la cargamos en el picture box
        If (ofd.ShowDialog = DialogResult.OK) Then
            nombreArchivo = ofd.FileName
            Me.pbImagenC.Image = Image.FromFile(nombreArchivo)
            Me.pbPDF.Image = Image.FromFile(nombreArchivo)
        End If
    End Sub

    Private Sub scrCargaPDF_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'CONSULTAMOS SI YA TIENE ALGUN PDF ALMACENADO.
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bytes() As Byte
        Dim directorioArchivo As String
        directorioArchivo = "C:\Imagen\PDF_" & scrProcesos_2.mro & "_" & scrProcesos_2.id_detalle & ".pdf"

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from detalle d join (pdf p) on (p.id_pdf = d.id_pdf) where id_detalle = '" & scrProcesos_2.id_detalle & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                bytes = resultado("pdf")
                BytesAArchivo(bytes, directorioArchivo)
                AxAcroPDF1.src = directorioArchivo
                My.Computer.FileSystem.DeleteFile(directorioArchivo)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'My.Computer.FileSystem.DeleteFile("C:\Imagen\Imagen_" & scrProcesos_2.mro & "_" & scrProcesos_2.id_detalle & ".jpg")
    End Sub

    Private Sub btnCorte_Click(sender As Object, e As EventArgs) Handles btnCorte.Click
        Dim f As New SautinSoft.PdfFocus()
        Dim pdfPath As String = ruta
        Dim resultado2 As String
        Dim image() As Byte
        Dim folder As New FolderBrowserDialog

        Try
            resultado2 = InputBox("Indique el número de página", "Control DMM (C) 2018")
        Catch ex As Exception
            resultado2 = ""
        End Try

        If resultado2 = "" Then
            MessageBox.Show("Valor inválido", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        f.OpenPdf(pdfPath)
        If f.PageCount > 0 Then
            f.ImageOptions.ImageFormat = System.Drawing.Imaging.ImageFormat.Jpeg
            f.ImageOptions.Dpi = 200
            image = f.ToImage(resultado2)
            'pbPDF.Image = BinToImg(image)
        End If

        Try
            Cursor = Cursors.WaitCursor

            pbImagenC.Width = BinToImg(image).Width
            pbImagenC.Height = BinToImg(image).Height
            pbImagenC.Image = BinToImg(image)

            pbEjem.Width = pbImagenC.Width / 10
            pbEjem.Height = pbImagenC.Height / 10
            pbEjem.Image = pbImagenC.Image

            Cursor = Cursors.Default

            AxAcroPDF1.Visible = False
            pbEjem.Visible = True
        Catch ex As Exception

        End Try

    End Sub

    Private Sub pbImagenC_MouseDown(sender As Object, e As MouseEventArgs) Handles pbImagenC.MouseDown
        'Try
        '    If e.Button = Windows.Forms.MouseButtons.Left Then

        '        cropX = e.X
        '        cropY = e.Y

        '        cropPen = New Pen(cropPenColor, cropPenSize)
        '        cropPen.DashStyle = DashStyle.DashDotDot
        '        Cursor = Cursors.Cross

        '    End If
        '    pbEjem.Refresh()
        '    pbImagenC.Refresh()
        'Catch exc As Exception
        'End Try
    End Sub

    Private Sub pbImagenC_MouseMove(sender As Object, e As MouseEventArgs) Handles pbImagenC.MouseMove
        'Try

        '    If pbImagenC.Image Is Nothing Then Exit Sub

        '    If e.Button = Windows.Forms.MouseButtons.Left Then

        '        pbImagenC.Refresh()
        '        cropWidth = e.X - cropX
        '        cropHeight = e.Y - cropY

        '        val1 = e.X
        '        val2 = e.Y

        '        pbImagenC.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
        '        pbImagenC.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
        '    End If
        '    ' GC.Collect()

        'Catch exc As Exception

        '    If Err.Number = 5 Then Exit Sub
        'End Try
    End Sub

    Private Sub pbImagenC_MouseUp(sender As Object, e As MouseEventArgs) Handles pbImagenC.MouseUp
        'Try
        '    Cursor = Cursors.Default
        '    Try

        '        If cropWidth < 1 Then
        '            Exit Sub
        '        End If

        '        Dim BITMAP1 As Bitmap = pbImagenC.Image
        '        Dim BITMAP2 As New Bitmap(cropWidth, cropHeight)

        '        Dim rect As Rectangle = New Rectangle(cropX, cropY, cropWidth, cropHeight)
        '        Dim bit As Bitmap = New Bitmap(pbImagenC.Image, pbImagenC.Width, pbImagenC.Height)

        '        cropBitmap = New Bitmap(cropWidth, cropHeight)

        '        For Y = 0 To cropHeight - 1
        '            For X = 0 To cropWidth - 1
        '                Dim BMCOLOR As Color = BITMAP1.GetPixel(X + cropX, Y + cropY)
        '                BITMAP2.SetPixel(X, Y, BMCOLOR)
        '            Next
        '        Next

        '        scrImagenC.pCorte.Image = BITMAP2
        '        scrImagenC.Show()
        '        scrImagenC.BringToFront()

        '        Return

        '        Dim g As Graphics = Graphics.FromImage(cropBitmap)
        '        g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
        '        g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
        '        g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
        '        g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)
        '        'picPreview.Image = cropBitmap
        '        scrImagenC.pCorte.Image = cropBitmap
        '        scrImagenC.Show()
        '        scrImagenC.BringToFront()

        '    Catch exc As Exception
        '    End Try
        'Catch exc As Exception
        'End Try
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles btnZoomIn.Click
        pbEjem.Width *= 1.2
        pbEjem.Height *= 1.2

        'pbEjem.Image.RotateFlip()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles btnZomOut.Click
        pbEjem.Width *= 0.8
        pbEjem.Height *= 0.8
    End Sub

    Private Sub pbEjem_MouseDown(sender As Object, e As MouseEventArgs) Handles pbEjem.MouseDown
        Try
            If e.Button = Windows.Forms.MouseButtons.Left Then

                cropX = e.X
                cropY = e.Y

                cropPen = New Pen(cropPenColor, cropPenSize)
                cropPen.DashStyle = DashStyle.DashDotDot
                Cursor = Cursors.Cross

            End If
            pbEjem.Refresh()
            pbImagenC.Refresh()
        Catch exc As Exception
        End Try
    End Sub

    Private Sub pbEjem_MouseMove(sender As Object, e As MouseEventArgs) Handles pbEjem.MouseMove
        Try

            If pbImagenC.Image Is Nothing Then Exit Sub

            If e.Button = Windows.Forms.MouseButtons.Left Then

                pbImagenC.Refresh()
                pbEjem.Refresh()
                cropWidth = e.X - cropX
                cropHeight = e.Y - cropY

                pbEjem.CreateGraphics.DrawRectangle(cropPen, cropX, cropY, cropWidth, cropHeight)
                pbImagenC.CreateGraphics.DrawRectangle(cropPen, cropX * 10, cropY * 10, cropWidth * 10, cropHeight * 10)
            End If
            ' GC.Collect()

        Catch exc As Exception

            If Err.Number = 5 Then Exit Sub
        End Try
    End Sub

    Private Sub pbEjem_MouseUp(sender As Object, e As MouseEventArgs) Handles pbEjem.MouseUp
        Try
            Cursor = Cursors.WaitCursor
            Try

                If cropWidth < 1 Then
                    Exit Sub
                End If

                Dim rect As Rectangle = New Rectangle(cropX * 10, cropY * 10, cropWidth * 10, cropHeight * 10)
                Dim bit As Bitmap = New Bitmap(pbImagenC.Image, pbImagenC.Width, pbImagenC.Height)
                cropBitmap = New Bitmap(cropWidth * 10, cropHeight * 10)
                Dim g As Graphics = Graphics.FromImage(cropBitmap)
                g.InterpolationMode = Drawing2D.InterpolationMode.HighQualityBicubic
                g.PixelOffsetMode = Drawing2D.PixelOffsetMode.HighQuality
                g.CompositingQuality = Drawing2D.CompositingQuality.HighQuality
                g.DrawImage(bit, 0, 0, rect, GraphicsUnit.Pixel)

                scrImagenC.pCorte.Image = cropBitmap
                scrImagenC.Show()
                scrImagenC.BringToFront()


            Catch exc As Exception
            End Try
            Cursor = Cursors.Default
        Catch exc As Exception
        End Try
    End Sub
End Class