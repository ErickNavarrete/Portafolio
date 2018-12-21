Imports System.IO
Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrAgregarProceso

#Region "VARIABLES GLOBALES"
    Dim id_proceso As Integer = 0
    Dim id_pieza As Integer = 0
    Dim ultima_fecha_interna As DateTime
    Dim ultima_fecha_cliente As DateTime
    Dim clave_proceso As String = ""
    Public id_ot As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Sub pieza_seleccionada()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_pdf As Integer = 0

        Dim clave As String = ""

        dgvPP.Rows.Clear()

        For i As Int16 = 0 To lvPiezas.SelectedIndices.Count - 1
            clave = lvPiezas.Items(lvPiezas.SelectedIndices(i)).SubItems(1).Text
            id_pieza = lvPiezas.Items(lvPiezas.SelectedIndices(i)).SubItems(1).Text
        Next

        Dim bytes() As Byte
        Dim directorioArchivo As String
        directorioArchivo = System.AppDomain.CurrentDomain.BaseDirectory() & "Ejemplo.pdf"

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from orden_trabajo_det where id_ot_det = '" & clave & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tbNum.Text = resultado.GetString("mro")
                tbTratamiento.Text = resultado.GetString("tratamiento")
                tbCantidad.Text = resultado.GetString("cantidad")
                tbObserva.Text = resultado.GetString("observaciones")
                id_pdf = resultado.GetDecimal("id_pdf")
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
            comandoSql = New MySqlCommand("select * from pdf where id_pdf = '" & id_pdf & "' ", _conexionSI)
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

        'CONSULTAMOS SI YA TIENE TAREAS ASIGNADAS
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand(" select po.id_proceso, po.num_proc, p.clave, po.fecha_interna, po.fecha_cliente, po.observaciones from proceso_ot po join (proceso p) on (po.id_proceso = p.id_proceso) where id_ot = '" & id_ot & "' and mro = '" & tbNum.Text & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvPP.Rows.Add(resultado.GetString("id_proceso"), 0, resultado.GetString("num_proc"), resultado.GetString("clave"), resultado.GetDateTime("fecha_interna").ToString("dd/MM/yyyy hh:mm:ss"), resultado.GetDateTime("fecha_cliente").ToString("dd/MM/yyyy hh:mm:ss"), resultado.GetString("observaciones"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()


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
        Dim result As Integer

        If id_pieza = 0 Then
            MessageBox.Show("Seleccione una pieza para poder continuar", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If id_proceso = 0 Then
            MessageBox.Show("Seleccione un proceso para poder continuar", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        If dgvPP.Rows.Count.ToString <> 0 Then
            result = DateTime.Compare(dtpF_Interna.Value, ultima_fecha_interna)
            If result < 0 Then
                MessageBox.Show("Fecha interna incorrecta", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If

            result = DateTime.Compare(dtpFecha_Cliente.Value, ultima_fecha_cliente)
            If result < 0 Then
                MessageBox.Show("Fecha Cliente incorrecta", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Return False
            End If
        End If

        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(2).Visible = True Then
                Return True
            End If
        Next

        MessageBox.Show("Seleccione una estación", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)

        Return False
    End Function

    Public Sub agrega_pieza_proceso()
        Dim id_estacion As Integer = 0
        Dim estacion As String = ""

        For Each row As DataGridViewRow In dgvEstacion.Rows
            If row.Cells(2).Value = True Then
                id_estacion = row.Cells(0).Value
                estacion = row.Cells(1).Value
            End If
        Next

        If id_estacion = 0 Then
            MessageBox.Show("Seleccione una estación para continuar", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        dgvPP.Rows.Add(id_proceso, id_pieza, dgvPP.Rows.Count + 1, clave_proceso, dtpF_Interna.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), dtpFecha_Cliente.Value.ToString("dd/MM/yyyy hh:mm:ss  tt"), rtbObservacion.Text, id_estacion, estacion, tbHoras.Text)
        ultima_fecha_cliente = dtpFecha_Cliente.Value
        ultima_fecha_interna = dtpF_Interna.Value

        dgvEstacion.Rows.Clear()
        tbHoras.Text = "0"
        rtbObservacion.Text = ""
    End Sub

    Public Sub guarda_proceso()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        If dgvPP.Rows.Count = 0 Then
            MessageBox.Show("Sin tareas asignadas", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Return
        End If

        'ELIMINAMOS LOS PROCESOS DADOS DE ALTA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("delete from proceso_ot where id_ot = '" & id_ot & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        For Each rows As DataGridViewRow In dgvPP.Rows
            datos.id = id_ot                        'ID_ORDEN_TRABAJO
            datos.id_polizas = rows.Cells(0).Value  'ID_PROCESO
            datos.calle = tbNum.Text                'MRO
            datos.fecha = rows.Cells(4).Value       'FECHA_INTERNA
            datos.fecha2 = rows.Cells(5).Value      'FECHA_CLIENTE
            datos.cel = rows.Cells(6).Value         'OBSERVACIONES
            datos.ciudad = rows.Cells(2).Value      'NÚMERO PROCESO
            datos.total = rows.Cells(7).Value       'ID_ESTACION
            datos.clave = ""                        'ESTADO
            datos.colonia = rows.Cells(9).Value     'HORAS DE TRABAJO

            conexion.insert_proceso_ot(datos)
        Next

        MessageBox.Show("Tareas guardadas con éxito", "Tablero 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)

        dgvPP.Rows.Clear()

    End Sub

    Public Sub elimina_proceso()
        Dim cont As Integer = 1

        dgvPP.Rows.Remove(dgvPP.CurrentRow)

        For Each row As DataGridViewRow In dgvPP.Rows
            row.Cells(2).Value = cont
            cont = cont + 1
        Next
    End Sub
#End Region

    Private Sub lvPiezas_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvPiezas.SelectedIndexChanged
        If dgvPP.Rows.Count > 0 Then
            Dim resultado As Integer = MessageBox.Show("Se han registrado cambios sobre este artículo, ¿Desea descartarlos?", "Tablero 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            If resultado = DialogResult.No Then
                Return
            End If
            If resultado = DialogResult.Yes Then
                dgvPP.Rows.Clear()
            End If
        End If
        pieza_seleccionada()
    End Sub

    Private Sub scrAgregarProceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_procesos()
    End Sub

    Private Sub lvProcesos_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProcesos.SelectedIndexChanged
        proceso_seleccionado()
    End Sub

    Private Sub btnAgregaP_Click(sender As Object, e As EventArgs) Handles btnAgregaP.Click
        If condiciones() Then
            agrega_pieza_proceso()
        End If
    End Sub

    Private Sub btnAgreaPro_Click(sender As Object, e As EventArgs) Handles btnAgreaPro.Click
        scrProcesos.Show()
        scrProcesos.BringToFront()
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        guarda_proceso()
    End Sub

    Private Sub btnEditar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        btnAgregaP.Enabled = True
        btnCancelaEd.Visible = True
        btnEditar.Visible = False
        btnGuarda.Visible = True
    End Sub

    Private Sub btnCancelaEd_Click(sender As Object, e As EventArgs) Handles btnCancelaEd.Click
        If dgvPP.Rows.Count > 0 Then
            Dim resultado As Integer = MessageBox.Show("Se han registrado cambios sobre este artículo, ¿Desea descartarlos?", "Tablero 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button2)
            If resultado = DialogResult.No Then
                Return
            End If
            If resultado = DialogResult.Yes Then
                dgvPP.Rows.Clear()
            End If
        End If

        btnAgregaP.Enabled = False
        btnCancelaEd.Visible = False
        btnEditar.Visible = True
        btnGuarda.Visible = False
    End Sub

    Private Sub dgvEstacion_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvEstacion.CellContentClick
        Dim indice As Integer = dgvEstacion.CurrentRow.Index.ToString

        For Each row As DataGridViewRow In dgvEstacion.Rows
            row.Cells(2).Value = False
        Next

        dgvEstacion.Rows(indice).Cells(2).Value = True
    End Sub

    Private Sub EliminarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EliminarToolStripMenuItem.Click
        elimina_proceso()
    End Sub
End Class