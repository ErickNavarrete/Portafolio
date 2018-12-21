Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrAltaRFC

#Region "Variables"
    Dim cargo As String
    Dim abono As String
    Dim ncargo As String
    Dim nabono As String

    Dim id_cargo As String
    Dim id_abono As String

    Dim id_config_rf As Integer = 0
#End Region

#Region "Metodos"
    Public Sub cargadatos()

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from rfc_config", _conexion)
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
                comandoSql = New MySqlCommand("select * from rfc_config", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cuentas(resultado.GetString("id_cuenta_cargo"), resultado.GetString("id_cuenta_abono"))

                    dgvRegistrados.Rows.Add(resultado.GetString("id_rfc"), resultado.GetString("rfc"), resultado.GetString("nombre"), resultado.GetString("tipo"), cargo, ncargo, abono, nabono)
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

    End Sub

    Public Sub cuentas(cuentac, cuentaa)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        cargo = ""
        ncargo = ""
        abono = ""
        nabono = ""
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where id_cuenta = '" & cuentac & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cargo = resultado.GetString("numero_cuenta")
                ncargo = resultado.GetString("nombre_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()


        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where id_cuenta = '" & cuentaa & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                abono = resultado.GetString("numero_cuenta")
                nabono = resultado.GetString("nombre_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

    End Sub

    Public Sub carganombre()
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
                comandoSql = New MySqlCommand("select * from catalogo_contable", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cbCargo.Items.Add(resultado.GetString("nombre_cuenta"))
                    cbAbono.Items.Add(resultado.GetString("nombre_cuenta"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If
    End Sub

    Public Sub carganumero()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False

        cbCargo.Items.Clear()
        cbAbono.Items.Clear()

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
    End Sub

    Public Sub buscaidnomnre()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where nombre_cuenta = '" & cbCargo.Text & "'", _conexion)
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

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where nombre_cuenta = '" & cbAbono.Text & "'", _conexion)
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


    End Sub

    Public Sub buscaidnumero()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbCargo.Text & "'", _conexion)
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

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbAbono.Text & "'", _conexion)
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
    End Sub

    Public Sub cargabancos()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        cbCuentas.Items.Clear()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from cuentas_bancos", _conexion)
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
                comandoSql = New MySqlCommand("select * from cuentas_bancos", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cbCuentas.Items.Add(resultado.GetString("cuenta"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If
    End Sub
#End Region

#Region "Eventos"

    Private Sub scrAltaRFC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargadatos()
        carganumero()
        cargabancos()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbnumero.Click
        carganumero()
        tsbnumero.Visible = False
        tsbNombre.Visible = True
        lblTIpoc.Text = "numero"
    End Sub

    Private Sub tsbNombre_Click(sender As Object, e As EventArgs) Handles tsbNombre.Click
        carganombre()
        tsbnumero.Visible = True
        tsbNombre.Visible = False
        lblTIpoc.Text = "nombre"
    End Sub

    Private Sub tsbGuardar_Click_1(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim conexion As New Class_insert
        Dim datos As New Class_datos

#Region "Errores"

        If cbCuentas.Text = "" Then
            MessageBox.Show("El campo cuenta bancaria no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbTipo.Text = "" Then
            MessageBox.Show("El campo tipo no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbRFC.Text = "" Then
            MessageBox.Show("El campo rfc no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbNombre.Text = "" Then
            MessageBox.Show("El campo nombre no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbCargo.Text = "" Then
            MessageBox.Show("El campo cuenta cargo no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        If cbAbono.Text = "" Then
            MessageBox.Show("El campo cuenta abono no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim b As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from cuentas_bancos where cuenta = '" & cbCuentas.Text & "'", _conexion)
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
                comandoSql = New MySqlCommand("select * from cuentas_bancos  where cuenta = '" & cbCuentas.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_cuenta = resultado.GetInt64("id_cuentaB")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        Else
            MessageBox.Show("La cuenta bancaria no existe en el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Return
        End If


#End Region
        datos.nombre_emp = tbNombre.Text
        datos.rfc_emp = tbRFC.Text
        datos.tipo = cbTipo.Text

        If lblTIpoc.Text = "nombre" Then
            buscaidnomnre()
        Else
            buscaidnumero()
        End If

        datos.id_cargo = id_cargo
        datos.id_abono = id_abono

        If conexion.insertarrfc(datos) Then
            dgvRegistrados.Rows.Clear()
            cargadatos()
            MessageBox.Show("RFC Configurado con éxito", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error al insertar el rfc", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub cbCargo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbCargo.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        lbCuentaCargo.Text = "---"

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbCargo.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                lbCuentaCargo.Text = resultado.GetString("nombre_cuenta")
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

        lbCuentaAbono.Text = "---"

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbAbono.Text & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                lbCuentaAbono.Text = resultado.GetString("nombre_cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub cbCargo_focus(sender As Object, e As EventArgs) Handles cbCargo.GotFocus
        carganumero()
    End Sub

    Private Sub cbAbono_focus(sender As Object, e As EventArgs) Handles cbAbono.GotFocus
        carganumero()
    End Sub
#End Region

    Public Function get_cuenta_b(ByVal id_rfc As Integer) As String
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim cuenta As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select cb.cuenta from rfc_config rc join cuentas_bancos cb on rc.id_cuentaB = cb.id_banco where rc.id_rfc = '" & id_rfc & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cuenta = resultado.GetString("cuenta")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        Return cuenta

    End Function

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        btnNuevo.Visible = False
        btnEdit.Visible = False
        btnElimina.Visible = False
        tsbGuardar.Visible = True
        btnGuardarEdi.Visible = False
        btnCancelEdit.Visible = True
        btnAddCuenta.Visible = True

        cbTipo.Text = ""
        tbNombre.Text = ""
        tbRFC.Text = ""
        cbCargo.Text = ""
        cbAbono.Text = ""
        cbCuentas.Text = ""

        cbTipo.Enabled = True
        tbNombre.Enabled = True
        tbRFC.Enabled = True
        cbCargo.Enabled = True
        cbAbono.Enabled = True
        cbCuentas.Enabled = True
    End Sub

    Private Sub btnCancelEdit_Click(sender As Object, e As EventArgs) Handles btnCancelEdit.Click
        btnNuevo.Visible = True
        btnEdit.Visible = False
        btnElimina.Visible = False
        tsbGuardar.Visible = False
        btnGuardarEdi.Visible = False
        btnCancelEdit.Visible = False
        btnAddCuenta.Visible = False

        cbTipo.Text = ""
        tbNombre.Text = ""
        tbRFC.Text = ""
        cbCargo.Text = ""
        cbAbono.Text = ""
        cbCuentas.Text = ""

        cbTipo.Enabled = False
        tbNombre.Enabled = False
        tbRFC.Enabled = False
        cbCargo.Enabled = False
        cbAbono.Enabled = False
        cbCuentas.Enabled = False
    End Sub

    Private Sub btnAddCuenta_Click(sender As Object, e As EventArgs) Handles btnAddCuenta.Click
        scrAltaCatalogo.Show()
        scrAltaCatalogo.BringToFront()
    End Sub

    Private Sub dgvRegistrados_DoubleClick(sender As Object, e As EventArgs) Handles dgvRegistrados.DoubleClick
        Dim indice As Integer = dgvRegistrados.CurrentRow.Index.ToString

        id_config_rf = dgvRegistrados.Rows(indice).Cells(0).Value

        cbTipo.Text = dgvRegistrados.Rows(indice).Cells(3).Value
        tbNombre.Text = dgvRegistrados.Rows(indice).Cells(1).Value
        tbRFC.Text = dgvRegistrados.Rows(indice).Cells(2).Value
        cbCargo.Text = dgvRegistrados.Rows(indice).Cells(4).Value
        cbAbono.Text = dgvRegistrados.Rows(indice).Cells(6).Value
        cbCuentas.Text = get_cuenta_b(id_config_rf)

        btnNuevo.Visible = False
        btnEdit.Visible = True
        btnElimina.Visible = True
        tsbGuardar.Visible = False
        btnGuardarEdi.Visible = True
        btnCancelEdit.Visible = True
        btnAddCuenta.Visible = False

        cbTipo.Enabled = False
        tbNombre.Enabled = False
        tbRFC.Enabled = False
        cbCargo.Enabled = False
        cbAbono.Enabled = False
        cbCuentas.Enabled = False

    End Sub

    Private Sub btnEdit_Click(sender As Object, e As EventArgs) Handles btnEdit.Click
        cbTipo.Enabled = True
        tbNombre.Enabled = True
        tbRFC.Enabled = True
        cbCargo.Enabled = True
        cbAbono.Enabled = True
        cbCuentas.Enabled = True
    End Sub

    Private Sub btnGuardarEdi_Click(sender As Object, e As EventArgs) Handles btnGuardarEdi.Click
        Dim conexion As New Class_insert
        Dim conexion_2 As New Class_delete
        Dim datos As New Class_datos

        datos.nombre_emp = tbNombre.Text
        datos.rfc_emp = tbRFC.Text
        datos.tipo = cbTipo.Text

        If lblTIpoc.Text = "nombre" Then
            buscaidnomnre()
        Else
            buscaidnumero()
        End If

        datos.id_cargo = id_cargo
        datos.id_abono = id_abono

        Dim result As Integer = MessageBox.Show("Al editar una cuenta, se cancelaran las pólizas involucradas ¿Desea continuar? ", "Contago Auto-Conta 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            'ELIMINAMOS LA CONFIGURACIÓN ANTERIOR
            datos.id_cuenta = id_config_rf
            conexion_2.delete_rfc_config(datos)

            'CANCELAMOS LAS PÓLIZAS Y XML RELACIONADOS
            cancel_polizas_rfc(tbRFC.Text, cbTipo.Text)

            'GUARDAMOS LA NUEVA CONFIGURACIÓN
            If conexion.insertarrfc(datos) Then
                dgvRegistrados.Rows.Clear()
                cargadatos()
                MessageBox.Show("RFC Configurado con éxito", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error al insertar el rfc", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If

    End Sub

    Private Sub btnElimina_Click(sender As Object, e As EventArgs) Handles btnElimina.Click
        Dim conexion As New Class_insert
        Dim conexion_2 As New Class_delete
        Dim datos As New Class_datos

        Dim result As Integer = MessageBox.Show("Al eliminar una cuenta, se cancelaran las pólizas involucradas ¿Desea continuar? ", "Contago Auto-Conta 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            'ELIMINAMOS LA CONFIGURACIÓN ANTERIOR
            datos.id_cuenta = id_config_rf
            conexion_2.delete_rfc_config(datos)

            'CANCELAMOS LAS PÓLIZAS Y XML RELACIONADOS
            cancel_polizas_rfc(tbRFC.Text, cbTipo.Text)
        End If
    End Sub
End Class