Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrAltaImpuestos

    Dim id_impuesto_config As Integer = 0

    Public Sub init_dgv()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        dgvImpuestos.Rows.Clear()

        Dim cuenta_c As String = ""
        Dim nombre_c As String = ""
        Dim cuenta_a As String = ""
        Dim nombre_a As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from impuesto_config", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                get_cuenta_nombre(cuenta_c, nombre_c, resultado.GetString("id_cuenta_cargo"))
                get_cuenta_nombre(cuenta_a, nombre_a, resultado.GetString("id_cuenta_abono"))

                dgvImpuestos.Rows.Add(resultado.GetString("id_impuesto"),
                                      resultado.GetString("tipo"),
                                      resultado.GetString("tipo_factor"),
                                      resultado.GetDecimal("tasa_cuota"),
                                      resultado.GetString("impuesto"), cuenta_c, nombre_c, cuenta_a, nombre_a)
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Public Sub get_cuenta_nombre(ByRef cuenta As String, ByRef nombre As String, ByVal id_cuenta As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where id_cuenta = '" & id_cuenta & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cuenta = resultado.GetString("numero_cuenta")
                nombre = resultado.GetString("nombre_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub scrAltaImpuestos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        cbCargo.Items.Clear()
        cbAbono.Items.Clear()
        cbCargo.Text = ""
        cbAbono.Text = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If b = True Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable where tipo = 'R' order by numero_cuenta", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cbCargo.Items.Add(resultado.GetString("numero_cuenta"))
                    cbAbono.Items.Add(resultado.GetString("numero_cuenta"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

        init_dgv()
    End Sub

    Private Sub cbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargo.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbCargo.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                lbCargo.Text = resultado.GetString("nombre_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub cbAbono_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbAbono.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbAbono.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                lbAbono.Text = resultado.GetString("nombre_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_cargo As Integer = 0
        Dim id_abono As Integer = 0

        If cbTipo.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbTipo.Focus()
            Return
        End If

        If cbFactor.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbFactor.Focus()
            Return
        End If

        If tbTasaCuota.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbTasaCuota.Focus()
            Return
        End If

        If cbImpuesto.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbImpuesto.Focus()
            Return
        End If

        If cbCargo.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCargo.Focus()
            Return
        End If

        If cbAbono.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbAbono.Focus()
            Return
        End If

        'OBTENEMOS ID DE LA CUENTA DE CARGO
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbCargo.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_cargo = resultado.GetString("id_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'OBTENEMOS ID DE LA CUENTA DE ABONO
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbAbono.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_abono = resultado.GetString("id_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'GUARDAMOS LA CONFIGURACION
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" insert into impuesto_config (tipo,tipo_factor,tasa_cuota,impuesto,id_cuenta_cargo,id_cuenta_abono) 
                                            values ('" & cbTipo.Text & "','" & cbFactor.Text & "','" & tbTasaCuota.Text & "', '" & cbImpuesto.Text & "','" & id_cargo & "','" & id_abono & "') ", _conexion)
            resultado = comandoSql.ExecuteReader
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        MessageBox.Show("Impuesto configurado con éxito", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        init_dgv()

        cbTipo.Text = ""
        cbFactor.Text = ""
        tbTasaCuota.Text = ""
        cbImpuesto.Text = ""
        cbCargo.Text = ""
        cbAbono.Text = ""
        lbAbono.Text = "---"
        lbCargo.Text = "---"
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Visible = False
        btnGuardar.Visible = True
        btnGuardaE.Visible = False
        btnEdit.Visible = False
        btnCancelEdit.Visible = True
        btnElimina.Visible = False
        btnNCuenta.Visible = True

        cbTipo.Text = ""
        cbFactor.Text = ""
        tbTasaCuota.Text = ""
        cbImpuesto.Text = ""
        cbCargo.Text = ""
        cbAbono.Text = ""
        lbAbono.Text = "---"
        lbCargo.Text = "---"

        cbTipo.Enabled = True
        cbFactor.Enabled = True
        tbTasaCuota.Enabled = True
        cbImpuesto.Enabled = True
        cbCargo.Enabled = True
        cbAbono.Enabled = True
        lbAbono.Enabled = True
        lbCargo.Enabled = True
    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        btnNuevo.Visible = False
        btnGuardar.Visible = False
        btnGuardaE.Visible = True
        btnEdit.Visible = False
        btnCancelEdit.Visible = True
        btnElimina.Visible = False
        btnNCuenta.Visible = True

        cbTipo.Enabled = True
        cbFactor.Enabled = True
        tbTasaCuota.Enabled = True
        cbImpuesto.Enabled = True
        cbCargo.Enabled = True
        cbAbono.Enabled = True
        lbAbono.Enabled = True
        lbCargo.Enabled = True
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        btnNuevo.Visible = True
        btnGuardar.Visible = False
        btnGuardaE.Visible = False
        btnEdit.Visible = False
        btnCancelEdit.Visible = False
        btnElimina.Visible = False
        btnNCuenta.Visible = False

        cbTipo.Text = ""
        cbFactor.Text = ""
        tbTasaCuota.Text = ""
        cbImpuesto.Text = ""
        cbCargo.Text = ""
        cbAbono.Text = ""
        lbAbono.Text = "---"
        lbCargo.Text = "---"

        cbTipo.Enabled = False
        cbFactor.Enabled = False
        tbTasaCuota.Enabled = False
        cbImpuesto.Enabled = False
        cbCargo.Enabled = False
        cbAbono.Enabled = False
        lbAbono.Enabled = False
        lbCargo.Enabled = False
    End Sub

    Private Sub dgvImpuestos_DoubleClick(sender As Object, e As EventArgs) Handles dgvImpuestos.DoubleClick
        btnNuevo.Visible = False
        btnGuardar.Visible = False
        btnGuardaE.Visible = True
        btnEdit.Visible = True
        btnCancelEdit.Visible = True
        btnElimina.Visible = True
        btnNCuenta.Visible = False

        cbTipo.Enabled = False
        cbFactor.Enabled = False
        tbTasaCuota.Enabled = False
        cbImpuesto.Enabled = False
        cbCargo.Enabled = False
        cbAbono.Enabled = False
        lbAbono.Enabled = False
        lbCargo.Enabled = False

        Dim indice As Integer = dgvImpuestos.CurrentRow.Index.ToString
        id_impuesto_config = dgvImpuestos.Rows(indice).Cells(0).Value

        cbTipo.Text = dgvImpuestos.Rows(indice).Cells(1).Value
        cbFactor.Text = dgvImpuestos.Rows(indice).Cells(2).Value
        tbTasaCuota.Text = dgvImpuestos.Rows(indice).Cells(3).Value
        cbImpuesto.Text = dgvImpuestos.Rows(indice).Cells(4).Value
        cbCargo.Text = dgvImpuestos.Rows(indice).Cells(5).Value
        cbAbono.Text = dgvImpuestos.Rows(indice).Cells(7).Value

    End Sub

    Private Sub btnGuardaE_Click(sender As Object, e As EventArgs) Handles btnGuardaE.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim conexion_2 As New Class_delete
        Dim datos As New Class_datos

        Dim id_cargo As Integer = 0
        Dim id_abono As Integer = 0

        If cbTipo.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbTipo.Focus()
            Return
        End If

        If cbFactor.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbFactor.Focus()
            Return
        End If

        If tbTasaCuota.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            tbTasaCuota.Focus()
            Return
        End If

        If cbImpuesto.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbImpuesto.Focus()
            Return
        End If

        If cbCargo.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCargo.Focus()
            Return
        End If

        If cbAbono.Text = "" Then
            MessageBox.Show("Campo obligatorio", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbAbono.Focus()
            Return
        End If

        'OBTENEMOS ID DE LA CUENTA DE CARGO
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbCargo.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_cargo = resultado.GetString("id_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'OBTENEMOS ID DE LA CUENTA DE ABONO
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbAbono.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                id_abono = resultado.GetString("id_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Dim result As Integer = MessageBox.Show("Al editar una cuenta, se cancelaran las pólizas involucradas ¿Desea continuar? ", "Contago Auto-Conta 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            'ELIMINAMOS LA CONFIGURACION PREVIA
            datos.id_cuenta = id_impuesto_config
            conexion_2.delete_impuesto_config(datos)

            'CANCELAMOS POLIZAS Y XML RELACIONADOS
            cancel_polizas_impuestos(tbTasaCuota.Text, cbFactor.Text, cbImpuesto.Text, cbTipo.Text)

            'GUARDAMOS LA CONFIGURACION
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" insert into impuesto_config (tipo,tipo_factor,tasa_cuota,impuesto,id_cuenta_cargo,id_cuenta_abono) 
                                            values ('" & cbTipo.Text & "','" & cbFactor.Text & "','" & tbTasaCuota.Text & "', '" & cbImpuesto.Text & "','" & id_cargo & "','" & id_abono & "') ", _conexion)
                resultado = comandoSql.ExecuteReader
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            MessageBox.Show("Impuesto configurado con éxito", "Contago Contabilidad 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            init_dgv()

            cbTipo.Text = ""
            cbFactor.Text = ""
            tbTasaCuota.Text = ""
            cbImpuesto.Text = ""
            cbCargo.Text = ""
            cbAbono.Text = ""
            lbAbono.Text = "---"
            lbCargo.Text = "---"
        End If
    End Sub

    Private Sub btnNCuenta_Click(sender As Object, e As EventArgs) Handles btnNCuenta.Click
        scrAltaCatalogo.Show()
        scrAltaCatalogo.BringToFront()
    End Sub
End Class