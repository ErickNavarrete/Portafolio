Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrOT

#Region "VARIABLES GLOBALES"
    Dim id_ot As Integer = 0
#End Region

#Region "FUNCIONES"
    Public Function condiciones() As Boolean
        If cbCliente.Text = "" Then
            MessageBox.Show(" Cliente obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCliente.Focus()
            Return False
        End If

        If cbProyecto.Text = "" Then
            MessageBox.Show(" Proyecto obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbProyecto.Focus()
            Return False
        End If

        If cbUsuario.Text = "" Then
            MessageBox.Show(" Usuario obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbUsuario.Focus()
            Return False
        End If

        If cbElabora.Text = "" Then
            MessageBox.Show(" Campo obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbElabora.Focus()
            Return False
        End If

        If cbSerie.Text = "" Or tbFolio.Text = "" Then
            MessageBox.Show(" Serie y Folio obligatorio ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbSerie.Focus()
            Return False
        End If

        If dgvPiezas.Rows.Count = 0 Then
            MessageBox.Show(" Sin piezas por añadir ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return False
        End If

        Return True
    End Function

    Public Sub guarda_general()
        Dim datos As New class_datos
        Dim conexion As New class_insert_datos

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        datos.unidadr = cbCliente.Text                  'CLIENTE
        datos.uuid = cbProyecto.Text                    'PROYECTO
        datos.calle = cbUsuario.Text                    'USUARIO
        datos.cel = cbSerie.Text                        'SERIE
        datos.ciudad = tbFolio.Text                     'FOLIO
        datos.clave = tbNumCot.Text                     'NÚMERO COTIZACIÓN
        datos.fecha = dtpFechaE.Value                   'FECHA ELABORACIÓN
        datos.fecha2 = dtpFen.Value                     'FECHA ENTREGA
        datos.id = 0                                    'ID USUARIO

        If conexion.insert_orden_trabajo(datos) Then
        Else
            MessageBox.Show(" Error ", "Control DMM (C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

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

    End Sub

    Public Sub guarda_detalle()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        For Each row In dgvPiezas.Rows
            Try
                conexion_GlobalSI()
                _conexionSI.Open()
                comandoSql = New MySqlCommand("insert into orden_trabajo_det (id_ot,id_pdf,mro,tratamiento,cantidad,observaciones) values ('" & id_ot & "','" & row.cells(5).value & "','" & row.cells(1).value & "','" & row.cells(4).value & "','" & row.cells(2).value & "','" & row.cells(3).value & "')", _conexionSI)
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

    Public Sub init_orden_t()
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

    Public Sub serie_seleccionada()
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
    End Sub
#End Region

    Private Sub btnAgrega_Click(sender As Object, e As EventArgs) Handles btnAgrega.Click
        'CONTAMOS EL NUMERO DE FILAS
        If dgvPiezas.Rows.Count = 0 Then
            scrPiezas.Show()
        Else
            MessageBox.Show("Solo una tarea por Orden de Trabajo", "Control DMM(C) 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        If condiciones() Then
            guarda_general()
            guarda_detalle()
            scrMenuOT.init_menu_ot()
            Me.Close()
        End If
    End Sub

    Private Sub scrOT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        init_orden_t()
    End Sub

    Private Sub cbSerie_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbSerie.SelectedIndexChanged
        serie_seleccionada()
    End Sub
End Class