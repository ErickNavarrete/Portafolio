Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrTransferenciaB
    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim conexion As New Class_insert
        Dim datos As New Class_datos
        Dim cuentacontablee As Integer
        Dim cuentacontabler As Integer
        Dim idbancoe As Integer
        Dim idbancor As Integer
        Dim b As Boolean = False

        If cbReceptor.Text = cbEmisor.Text Then
            MessageBox.Show("las cuentas bancarias deben ser distintas para continuar", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbEmisor.Text = "" Then
            MessageBox.Show("El campo del banco emisor no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbReceptor.Text = "" Then
            MessageBox.Show("El campo del banco receptor no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbCantidad.Text = "" Then
            MessageBox.Show("El campo cantidad no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If


        ''banco emisor
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select id_cuentaB, id_cuenta from cuentas_bancos cu join catalogo_contable cat on cu.ccontable = cat.id_cuenta where cuenta =  '" & cbEmisor.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
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
                comandoSql = New MySqlCommand("select id_cuentaB, id_cuenta from cuentas_bancos cu join catalogo_contable cat on cu.ccontable = cat.id_cuenta where cuenta =  '" & cbEmisor.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    idbancoe = resultado.GetInt64("id_cuentab")
                    cuentacontablee = resultado.GetInt64("id_cuenta")
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            MessageBox.Show("Error la cuenta contable no existe en la base de datos", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If



        ''banco receptor 


        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select id_cuentaB, id_cuenta from cuentas_bancos cu join catalogo_contable cat on cu.ccontable = cat.id_cuenta where cuenta =  '" & cbReceptor.Text & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
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
                comandoSql = New MySqlCommand("select id_cuentaB, id_cuenta from cuentas_bancos cu join catalogo_contable cat on cu.ccontable = cat.id_cuenta where cuenta =  '" & cbReceptor.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    idbancor = resultado.GetInt64("id_cuentab")
                    cuentacontabler = resultado.GetInt64("id_cuenta")
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            MessageBox.Show("Error la cuenta contable no existe en la base de datos", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

#Region "Transferencia"

        ''para insertar
        datos.cantidad = tbCantidad.Text
        datos.id_banco = idbancoe
        datos.id_bancoR = idbancor
        datos.fechat = dtp1.Value.ToString("yyyy-MM-dd")
        datos.user = scrPrincipal2.lblNUsuario.Text

        If conexion.insertartransferencia(datos) Then

        Else
            MessageBox.Show("Error al insertar el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
#End Region



#Region "Movimiento bancos"

        'emisor
        datos.id_banco = idbancoe
        datos.deposito = 0
        datos.retiro = tbCantidad.Text
        datos.fechat = dtp1.Value.ToString("yyyy-MM-dd")
        datos.user = scrPrincipal2.lblNUsuario.Text


        If conexion.insertarmovbancos(datos) Then

        Else
            MessageBox.Show("Error al insertar el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


        'receptor
        datos.id_banco = idbancor
        datos.deposito = tbCantidad.Text
        datos.retiro = 0
        datos.fechat = dtp1.Value.ToString("yyyy-MM-dd")
        datos.user = scrPrincipal2.lblNUsuario.Text


        If conexion.insertarmovbancos(datos) Then


        Else
            MessageBox.Show("Error al insertar el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


#End Region

#Region "Polizas"

        datos.tipo_poliza = "Diario"

        mes(dtp1.Value.Month)
        datos.mes = var_globales.mes
        datos.anio = dtp1.Value.Year
        datos.total = tbCantidad.Text
        datos.descripcion = "Poliza de transferencia bancaria de " & var_globales.mes & dtp1.Value.ToString("yyyy-MM-dd")
        datos.fechat = dtp1.Value.ToString("yyyy-MM-dd")

        b = False
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from polizas where mes = '" & var_globales.mes & "' and anio = '" & dtp1.Value.Year & "'", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
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
                comandoSql = New MySqlCommand("select * from polizas where mes = '" & var_globales.mes & "' and anio = '" & dtp1.Value.Year & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.numero_poliza = Convert.ToInt64(resultado.GetInt64("numero_poliza")) + 1
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            datos.numero_poliza = 1
        End If

        datos.user = scrPrincipal2.lblNUsuario.Text
        datos.origen = "Transferencia bancaria"


        If conexion.insertaPolizas(datos) Then

            'Cargos
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select max(id_poliza) from polizas ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_poliza = resultado.GetInt64("max(id_poliza)")
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            datos.fechat = dtp1.Value.ToString("yyyy-MM-dd")
            datos.id_cuenta = cuentacontabler
            datos.cargo = tbCantidad.Text
            datos.abono = 0
            datos.desc_asiento = "Deposito por transferencia de la cuenta: " & cbEmisor.Text

            If conexion.insertaPolDet(datos) Then

            End If

            'Abonos
            datos.fechat = dtp1.Value.ToString("yyyy-MM-dd")
            datos.id_cuenta = cuentacontablee
            datos.cargo = 0
            datos.abono = tbCantidad.Text
            datos.desc_asiento = "Retiro por transferencia a la cuenta: " & cbReceptor.Text

            If conexion.insertaPolDet(datos) Then

            End If

            MessageBox.Show("Transferencia realizada correctamente", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Information)
            cbEmisor.Text = ""
            cbReceptor.Text = ""
            tbCantidad.Text = ""

        Else
            MessageBox.Show("Error al insertar el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If


#End Region
    End Sub

    Private Sub scrTransferenciaB_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from cuentas_bancos", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                b = True
            End While
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
                    cbEmisor.Items.Add(resultado.GetString("cuenta"))
                    cbReceptor.Items.Add(resultado.GetString("cuenta"))
                End While
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

    End Sub
End Class