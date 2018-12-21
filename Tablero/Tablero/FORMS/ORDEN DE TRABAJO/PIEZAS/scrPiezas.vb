Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrPiezas

#Region "VARIABLES GLOBALES"
    Dim ruta As String = ""
    Dim id_pdf As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Sub carga_pdf()
        Try
            OpenFileDialog1.Filter = "PDF Files |*.pdf"
            If OpenFileDialog1.ShowDialog = DialogResult.OK Then
                AxAcroPDF1.src = OpenFileDialog1.FileName
                ruta = OpenFileDialog1.FileName
            End If
        Catch ex As Exception

        End Try
    End Sub

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

    Public Sub obtiene_pdf()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim bytes() As Byte
        Dim directorioArchivo As String
        directorioArchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "Ejemplo.pdf"

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from pdf", _conexionSI)
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

        'Process.Start(ruta)
    End Sub

    Public Sub guarda_pdf()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'GUARDAMOS PDF
        Try
            Dim strPath As String
            strPath = ruta
            Dim ruta2 As New FileStream(strPath, FileMode.Open, FileAccess.Read)
            Dim binario(ruta2.Length) As Byte
            ruta2.Read(binario, 0, ruta2.Length) 'Leo el archivo y lo convierto a binario 
            ruta2.Close() 'Cierro el FileStream 

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
    End Sub

#End Region

    Private Sub btnSubPDF_Click(sender As Object, e As EventArgs) Handles btnSubPDF.Click
        carga_pdf()
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        Dim item As Decimal = scrOT.dgvPiezas.Rows.Count

        guarda_pdf()
        scrOT.dgvPiezas.Rows.Add((item + 1), tbMRO.Text, tbCantidad.Text, tbObservaciones.Text, tbTratamiento.Text, id_pdf)
        Me.Close()
    End Sub

End Class