Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class scrMenuOT
#Region "FUNCIONES"
    Public Sub init_menu_ot()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim Fecha As String = ""
        Dim fechax As Date
        Dim fechay As String

        Fecha = Date.Today.ToString("yyyy-MM-dd")
        Fecha = Fecha.Substring(4, 4)

        dgvMenuOT.Rows.Clear()

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where fecha_elab like '%" & Fecha & "%' and estado = 1", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                fechax = resultado.GetString("fecha_elab")
                fechay = fechax.ToString("dd/MMMM/yyyy")

                dgvMenuOT.Rows.Add(resultado.GetDecimal("id_ot"),
                                   resultado.GetString("cliente"),
                                   resultado.GetString("proyecto"),
                                   fechay,
                                   resultado.GetString("serie"),
                                   resultado.GetString("folio"))

            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()
    End Sub

    Public Sub tipo_busqueda()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim fecha_i As String = dtpFI.Value.ToString("yyyy-MM-dd")
        Dim fecha_f As String = dtpFF.Value.ToString("yyyy-MM-dd")

        Dim fechax As Date
        Dim fechay As String

        dgvMenuOT.Rows.Clear()

        If cbTipoB.Text = "" Then
            MessageBox.Show(" Seleccione un tipo de búsqueda ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbTipoB.Focus()
            Return
        End If

        Select Case cbTipoB.Text
            Case "Todos"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("select * from orden_trabajo where fecha_elab between '" & fecha_i & "' and '" & fecha_f & "' and estado = 1  ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        fechax = resultado.GetString("fecha_elab")
                        fechay = fechax.ToString("dd/MMMM/yyyy")

                        dgvMenuOT.Rows.Add(resultado.GetDecimal("id_ot"),
                                           resultado.GetString("cliente"),
                                           resultado.GetString("proyecto"),
                                           fechay,
                                           resultado.GetString("serie"),
                                           resultado.GetString("folio"))

                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Case "Cliente"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("select * from orden_trabajo where fecha_elab between '" & fecha_i & "' and '" & fecha_f & "' and estado = 1 and cliente like '%" & tbOpc.Text & "%'  ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        fechax = resultado.GetString("fecha_elab")
                        fechay = fechax.ToString("dd/MMMM/yyyy")

                        dgvMenuOT.Rows.Add(resultado.GetDecimal("id_ot"),
                                           resultado.GetString("cliente"),
                                           resultado.GetString("proyecto"),
                                           fechay,
                                           resultado.GetString("serie"),
                                           resultado.GetString("folio"))

                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Case "Proyecto"
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("select * from orden_trabajo where fecha_elab between '" & fecha_i & "' and '" & fecha_f & "' and estado = 1 and proyecto like '%" & tbOpc.Text & "%'  ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    'Dentro de un ciclo leemos los resultados
                    While resultado.Read
                        fechax = resultado.GetString("fecha_elab")
                        fechay = fechax.ToString("dd/MMMM/yyyy")

                        dgvMenuOT.Rows.Add(resultado.GetDecimal("id_ot"),
                                           resultado.GetString("cliente"),
                                           resultado.GetString("proyecto"),
                                           fechay,
                                           resultado.GetString("serie"),
                                           resultado.GetString("folio"))

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
#End Region

    Private Sub scrMenuOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_menu_ot()
    End Sub

    Private Sub scrMenuOT(sender As Object, e As EventArgs) Handles MyBase.Shown
        cbTipoB.Focus()
    End Sub

    Private Sub ToolStripButton2_Click(sender As Object, e As EventArgs) Handles ToolStripButton2.Click
        tipo_busqueda()
    End Sub

    Private Sub PROCESOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PROCESOSToolStripMenuItem.Click
        Dim indice As Integer = dgvMenuOT.CurrentRow.Index.ToString
        Dim id As Integer = dgvMenuOT.Rows(indice).Cells(0).Value

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        'VERFICAMOS QUE NO ESTE EN PROCESO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from historial where id_ot = '" & id & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                MessageBox.Show("Orden de Trabajo en proceso", "Control DMM(C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return
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
            comandoSql = New MySqlCommand("select * from orden_trabajo where id_ot = '" & id & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                scrAgregarProceso.tbProyecto.Text = resultado.GetString("proyecto")
                scrAgregarProceso.tbCliente.Text = resultado.GetString("cliente")
                scrAgregarProceso.tbSerie.Text = resultado.GetString("serie")
                scrAgregarProceso.tbFolio.Text = resultado.GetString("folio")

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
            comandoSql = New MySqlCommand("select * from orden_trabajo_det where id_ot = '" & id & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim lista As ListViewItem
                lista = New ListViewItem(resultado.GetString("mro"))
                lista.SubItems.Add(resultado.GetString("id_ot_det"))
                scrAgregarProceso.lvPiezas.Items.Add(lista)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        scrAgregarProceso.id_ot = id
        scrAgregarProceso.Show()
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        scrOT_2.Show()
        scrOT_2.BringToFront()
    End Sub

    Private Sub ToolStripButton3_Click(sender As Object, e As EventArgs) Handles ToolStripButton3.Click
        scrTablero2.Show()
        scrTablero2.BringToFront()
    End Sub

    Private Sub scrMenuOT_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize

        'If Me.WindowState = FormWindowState.Minimized Then
        '    NIp.Visible = True
        '    Me.Hide()
        '    NIp.ShowBalloonTip(2000)
        'End If

    End Sub

    Private Sub NIp_MouseDoubleClick(sender As Object, e As MouseEventArgs) Handles NIp.MouseDoubleClick
        'Me.Show()
        'Me.WindowState = FormWindowState.Normal
        'Me.BringToFront()
        'NIp.Visible = False
    End Sub

    Private Sub dgvMenuOT_DoubleClick(sender As Object, e As EventArgs) Handles dgvMenuOT.DoubleClick
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim indice As Integer = dgvMenuOT.CurrentRow.Index
        Dim id_ot As Integer = dgvMenuOT.Rows(indice).Cells(0).Value

        scrOT_2.Show()
        scrOT_2.BringToFront()

        'DATOS GENERALES
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                scrOT_2.id_ot = id_ot
                scrOT_2.cbCliente.Text = resultado.GetString("cliente")
                scrOT_2.cbCliente.Enabled = False
                scrOT_2.cbProyecto.Text = resultado.GetString("proyecto")
                scrOT_2.cbProyecto.Enabled = False
                scrOT_2.cbUsuario.Text = resultado.GetString("usuario")
                scrOT_2.cbUsuario.Enabled = False
                scrOT_2.cbSerie.Text = resultado.GetString("serie")
                scrOT_2.cbSerie.Enabled = False
                scrOT_2.tbFolio.Text = resultado.GetString("folio")
                scrOT_2.tbFolio.Enabled = False
                scrOT_2.dtpFechaE.Value = resultado.GetDateTime("fecha_elab")
                scrOT_2.dtpFechaE.Enabled = False
                scrOT_2.dtpFen.Value = resultado.GetDateTime("fecha_entrega")
                scrOT_2.dtpFen.Enabled = False
                scrOT_2.tbNumCot.Text = resultado.GetString("numero_cotizacion")
                scrOT_2.tbNumCot.Enabled = False
                scrOT_2.tbUsuario.Text = resultado.GetString("usuario_c")
                scrOT_2.tbUsuario.Enabled = False
                scrOT_2.tbOC.Text = resultado.GetString("orden_compra")
                scrOT_2.tbOC.Enabled = False
                scrOT_2.tbInfCNC.Text = resultado.GetString("inf_cnc")
                scrOT_2.tbInfCNC.Enabled = False
                scrOT_2.tbNotas.Text = resultado.GetString("notas")
                scrOT_2.tbNotas.Enabled = False
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'UNIDADES
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from unidad where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                scrOT_2.dgvPiezas.Rows.Add(resultado.GetString("id_unidad"),
                                            resultado.GetString("clave"),
                                            resultado.GetString("descripcion"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        scrOT_2.btnAgrega.Visible = False
        scrOT_2.ASIGNARTAREASToolStripMenuItem.Enabled = True
        scrOT_2.btnGuarda.Visible = False
        scrOT_2.btnGuardaAct.Visible = False
        scrOT_2.btnEditar.Visible = True
        scrOT_2.btnGenLay.Visible = False
        scrOT_2.btnCargaLayout.Visible = False
        scrOT_2.btnImprime.Visible = True
        scrOT_2.btnEliminaOT.Visible = True
    End Sub

    Private Sub btnUsuarios_Click(sender As Object, e As EventArgs) Handles btnUsuarios.Click
        scrUsuarios.Show()
        scrUsuarios.BringToFront()
    End Sub

    Private Sub btnCredenciales_Click(sender As Object, e As EventArgs) Handles btnCredenciales.Click
        Dim clave_usu As String = "pi"
        Dim clave_contra As String = "root"
        Dim clave_programa As String = "python a.py"

        Dim ds As New dsCb3
        Dim cr As New crCb3
        Dim r As New scrVistaPrevia

        'GENERAMOS EL CODIGO DE BARRAS
        Try
            Dim alto As Single = 0
            Dim bm As Bitmap = Nothing
            Dim bm2 As Bitmap = Nothing
            Dim bm3 As Bitmap = Nothing
            bm = class_codigo_barras.codigo_cb(clave_usu)
            bm2 = class_codigo_barras.codigo_cb(clave_contra)
            bm3 = class_codigo_barras.codigo_cb(clave_programa)

            pbCodigo.BackgroundImage = bm
            pbCodigo2.BackgroundImage = bm2
            pbCodigo3.BackgroundImage = bm3
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

        'DECLARAMOS UNA VARIABLE PARA GUARDAR LA IMAGEN
        Dim arrayBin As Byte()
        Dim arrayBin2 As Byte()
        Dim arrayBin3 As Byte()

        'Convertimos la imágen a binario por medio de la función y guardamos el resultado en un arreglo Byte
        arrayBin = ImgToBin(Me.pbCodigo.BackgroundImage)
        arrayBin2 = ImgToBin(Me.pbCodigo2.BackgroundImage)
        arrayBin3 = ImgToBin(Me.pbCodigo3.BackgroundImage)

        ds.dtCodigoBarras.AdddtCodigoBarrasRow(clave_usu, arrayBin, clave_contra, arrayBin2, clave_programa, arrayBin3)

        cr.SetDataSource(ds)
        r.crv1.ReportSource = cr
        r.ShowDialog()
        cr.Close()
        ds.Clear()
    End Sub

    Private Sub btnGeneraReporte_Click(sender As Object, e As EventArgs) Handles btnGeneraReporte.Click
        scrTipoReporte.Show()
        scrTipoReporte.BringToFront()
    End Sub
End Class