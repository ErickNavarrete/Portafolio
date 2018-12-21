Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrProcesos

#Region "VARIABLES GLOBALES"
    Dim id_procesos As Decimal
    Dim clave_p As String = ""
#End Region

#Region "BOTONES"
    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        tbDescripcion.ReadOnly = False
        tbClave.Enabled = True

        'BOTONES
        btnNuevo.Visible = False
        btnEdita.Visible = False
        btnElimina.Visible = False
        btnGuarda.Visible = True
        btnActualiza.Visible = False
        btnCancelaEdit.Visible = True

        tbClave.Clear()
        tbDescripcion.Clear()
        dgvEstaciones.Rows.Clear()
    End Sub

    Private Sub btnEdita_Click(sender As Object, e As EventArgs) Handles btnEdita.Click
        tbDescripcion.ReadOnly = False
        tbClave.Enabled = True

        'BOTONES
        btnNuevo.Visible = False
        btnEdita.Visible = False
        btnElimina.Visible = False
        btnGuarda.Visible = False
        btnActualiza.Visible = True
        btnCancelaEdit.Visible = True
    End Sub

    Private Sub btnCancelaEdit_Click(sender As Object, e As EventArgs) Handles btnCancelaEdit.Click
        tbDescripcion.ReadOnly = True
        tbClave.Enabled = False

        'BOTONES
        btnNuevo.Visible = True
        btnEdita.Visible = True
        btnElimina.Visible = True
        btnGuarda.Visible = False
        btnActualiza.Visible = False
        btnCancelaEdit.Visible = False

        tbClave.Clear()
        tbDescripcion.Clear()
        dgvEstaciones.Rows.Clear()
    End Sub

#End Region

#Region "FUNCIONES"
    Public Sub init_procesos()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        lvProceso.Items.Clear()
        dgvEstaciones.Rows.Clear()

        tbClave.Text = ""
        tbDescripcion.Text = ""

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from proceso where estado = 1", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                Dim lista As ListViewItem
                lista = New ListViewItem(resultado.GetString("clave"))
                lista.SubItems.Add(resultado.GetString("descripcion"))
                lvProceso.Items.Add(lista)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub

    Public Sub guarda_datos()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim id_proceso As Integer = 0

        If tbClave.Text = "" Then
            MessageBox.Show(" Clave obligatoria ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbClave.Focus()
            Return
        End If

        If tbDescripcion.Text = "" Then
            MessageBox.Show(" Descripción obligatoria ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbDescripcion.Focus()
            Return
        End If

        If condicion_existente(tbClave.Text) = False Then
            datos.unidadr = tbClave.Text                    'CLAVE
            datos.uuid = tbDescripcion.Text                 'DESCRIPCIÓN
            datos.total = "0"                               'ID_USUARIO
            If conexion.insert_proceso(datos) Then
                MessageBox.Show(" Proceso dado de alta correctamente ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show(" Clave ya registrada ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'OBTENEMOS ID DEL PROCESO
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select max(id_proceso) from proceso", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                id_proceso = resultado.GetString("max(id_proceso)")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'AGREGAMOS LAS ESTACIONES
        For Each row As DataGridViewRow In dgvEstaciones.Rows
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand("insert into estacion (id_proceso, nombre) values ('" & id_proceso & "', '" & row.Cells(1).Value & "') ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()
        Next

    End Sub

    Public Function condicion_existente(ByVal clave As String) As Boolean
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim encontro As Boolean = False

        If clave_p = clave Then
            Return False
        End If

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from proceso where clave = '" & clave & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                encontro = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        Return encontro
    End Function

    Public Sub actualiza_datos()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New class_datos
        Dim conexion As New class_update_datos

        Dim bandera As Boolean = False

        If tbClave.Text = "" Then
            MessageBox.Show(" Clave obligatoria ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbClave.Focus()
            Return
        End If

        If tbDescripcion.Text = "" Then
            MessageBox.Show(" Descripción obligatoria ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbDescripcion.Focus()
            Return
        End If

        If condicion_existente(tbClave.Text) = False Then
            datos.unidadr = tbClave.Text                    'CLAVE
            datos.uuid = tbDescripcion.Text                 'DESCRIPCIÓN
            datos.total = "0"                               'ID_USUARIO
            datos.fecha = DateTime.Today                    'FECHA MODIFICACIÓN
            datos.total_abono = id_procesos                 'ID_PROCESO

            If conexion.update_proceso(datos) Then
                MessageBox.Show(" Proceso actualizado correctamente ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Else
            MessageBox.Show(" Clave ya registrada ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

        'CONSULTAMOS SI EL PROCESO YA TIENE ESTACIONES REGISTRADAS, EN CASO DE QUE NO SE GUARDAN NORMALMENTE

        For Each row As DataGridViewRow In dgvEstaciones.Rows
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand("select * from estacion where id_estacion = '" & row.Cells(0).Value & "' ", _conexionSI)
                resultado = comandoSql.ExecuteReader
                'Dentro de un ciclo leemos los resultados
                While resultado.Read
                    bandera = True
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrarSI()
            End Try
            _conexionSI.Close()

            'SI BANDERA = TRUE SE ACTUALIZA
            If bandera = True Then
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand(" update estacion set nombre = '" & row.Cells(1).Value & "' where id_estacion = '" & row.Cells(0).Value & "' ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            Else
                Try
                    conexion_GlobalSI()
                    _conexionSI.Open()
                    comandoSql = New MySqlCommand("insert into estacion (id_proceso, nombre) values ('" & id_procesos & "', '" & row.Cells(1).Value & "') ", _conexionSI)
                    resultado = comandoSql.ExecuteReader
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrarSI()
                End Try
                _conexionSI.Close()
            End If

            bandera = False
        Next
    End Sub

    Public Sub proceso_seleccionado()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        tbDescripcion.ReadOnly = True
        tbClave.Enabled = False

        'BOTONES
        btnNuevo.Visible = True
        btnEdita.Visible = True
        btnElimina.Visible = True
        btnGuarda.Visible = False
        btnActualiza.Visible = False
        btnCancelaEdit.Visible = False

        Dim clave As String = ""

        For i As Int16 = 0 To lvProceso.SelectedIndices.Count - 1
            clave = lvProceso.SelectedItems.Item(i).Text
            clave_p = clave
        Next

        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from proceso where clave = '" & clave & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                tbClave.Text = resultado.GetString("clave")
                tbDescripcion.Text = resultado.GetString("descripcion")
                id_procesos = resultado.GetDecimal("id_proceso")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

        'MOSTRAMOS LAS ESTACIONES DADAS DE ALTA
        Try
            conexion_GlobalSI()
            _conexionSI.Open()
            comandoSql = New MySqlCommand("select * from estacion where id_proceso = '" & id_procesos & "' ", _conexionSI)
            resultado = comandoSql.ExecuteReader
            'Dentro de un ciclo leemos los resultados
            While resultado.Read
                dgvEstaciones.Rows.Add(resultado.GetString("id_proceso"), resultado.GetString("nombre"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Punto de Venta (C) 2016", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrarSI()
        End Try
        _conexionSI.Close()

    End Sub

    Public Sub elimina_proceso()
        Dim datos As New class_datos
        Dim conexion As New class_delete_datos

        Dim opcion As Integer = MessageBox.Show("¿Esta seguro que desea eliminar este proceso?", "Control DMM (C) 2018", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If opcion = DialogResult.Yes Then
            datos.total = "0"
            datos.fecha = DateTime.Today
            datos.total_abono = id_procesos
            If conexion.delete_proceso(datos) Then
                MessageBox.Show(" Proceso eliminado ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        End If
    End Sub

    Public Sub agrega_estacion()
        'CONDICIONES
        For Each row As DataGridViewRow In dgvEstaciones.Rows
            If row.Cells(1).Value = tbEstacion.Text Then
                MessageBox.Show(" Estación ya registrada ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next

        dgvEstaciones.Rows.Add("", tbEstacion.Text)
        tbEstacion.Clear()
    End Sub
#End Region

    Private Sub scrProcesos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_procesos()
    End Sub

    Private Sub btnGuarda_Click(sender As Object, e As EventArgs) Handles btnGuarda.Click
        guarda_datos()
        init_procesos()
        scrProcesos_2.init_procesos()
    End Sub

    Private Sub btnActualiza_Click(sender As Object, e As EventArgs) Handles btnActualiza.Click
        actualiza_datos()
        init_procesos()
        scrProcesos_2.init_procesos()
    End Sub

    Private Sub lvProceso_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lvProceso.SelectedIndexChanged
        proceso_seleccionado()
    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        elimina_proceso()
        init_procesos()
        scrAgregarProceso.init_procesos()
    End Sub

    Private Sub btnAgregaE_Click(sender As Object, e As EventArgs) Handles btnAgregaE.Click
        agrega_estacion()
    End Sub
End Class
