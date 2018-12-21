Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.IO
Public Class scrUsuarios
    Public Sub genera_cb()
        Dim codigo As String
        Dim claves As String

        Dim indice As Integer = dgvUsuarios.CurrentRow.Index

        Dim ds As New dsCb
        Dim cr As New crCb
        Dim r As New scrVistaPrevia

        claves = dgvUsuarios.Rows(indice).Cells(1).Value
        codigo = "000." & dgvUsuarios.Rows(indice).Cells(0).Value

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

    Private Sub scrUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvUsuarios.Rows.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from cotizaciones.requisitantes", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvUsuarios.Rows.Add(resultado.GetString("id_rec"), resultado.GetString("nombre"), resultado.GetString("departamento"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Private Sub GENERACBToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GENERACBToolStripMenuItem.Click
        genera_cb()
    End Sub

    Private Sub btnBusqueda_Click(sender As Object, e As EventArgs) Handles btnBusqueda.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvUsuarios.Rows.Clear()

        Select Case cbOpcion.Text
            Case "Departamento"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("select * from cotizaciones.requisitantes where departamento like '%" & tbOpcion.Text & "%' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvUsuarios.Rows.Add(resultado.GetString("id_rec"), resultado.GetString("nombre"), resultado.GetString("departamento"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Case "Nombre"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("select * from cotizaciones.requisitantes where nombre like '%" & tbOpcion.Text & "%' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvUsuarios.Rows.Add(resultado.GetString("id_rec"), resultado.GetString("nombre"), resultado.GetString("departamento"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Case "Todos"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("select * from cotizaciones.requisitantes", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        dgvUsuarios.Rows.Add(resultado.GetString("id_rec"), resultado.GetString("nombre"), resultado.GetString("departamento"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
        End Select
    End Sub

    Private Sub cbOpcion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbOpcion.SelectedIndexChanged
        tbOpcion.Text = ""
    End Sub
End Class