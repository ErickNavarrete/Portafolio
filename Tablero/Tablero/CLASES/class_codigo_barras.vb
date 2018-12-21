Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.Drawing.Drawing2D

Imports iTextSharp.text.pdf
Imports iTextSharp.text.pdf.BarcodeCodabar
Public Class class_codigo_barras
    Public Shared Function codigo_cb(ByRef _codigo As String)
        Dim barcode As New Barcode128
        barcode.StartStopText = True

        barcode.Code = _codigo
        Try
            Dim bm As New System.Drawing.Bitmap(barcode.CreateDrawingImage(Color.Black, Color.White))
            Return bm
        Catch ex As Exception
            Throw New Exception("error" & ex.ToString)
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Function


End Class
