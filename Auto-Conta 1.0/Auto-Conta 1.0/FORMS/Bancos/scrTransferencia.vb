Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient



Public Class scrTransferencia

#Region "Variables"
    Dim idcuentaEMI As Integer
    Dim idcuentarec As Integer
    Dim idccontableEMI As Integer
    Dim idccontablerec As Integer
    Dim saldo As Decimal
    Dim saldo1 As Decimal
#End Region


    Private Sub btnNTrans_Click(sender As Object, e As EventArgs) Handles btnNTrans.Click

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False

        pnNueva.Visible = True
        pnNueva.Size = New Size(832, 535)


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
                    cbBancoEmisor.Items.Add(resultado.GetString("cuenta"))
                    cbBancoReceptor.Items.Add(resultado.GetString("cuenta"))
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

    Private Sub cbBancoEmisor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancoEmisor.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        Dim b1 As Boolean = False
        Dim retiro As Decimal = 0
        Dim deposito As Decimal = 0
        Dim total As Decimal
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from cuentas_bancos where cuenta = '" & cbBancoEmisor.Text & "'", _conexion)
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
                comandoSql = New MySqlCommand("select * from cuentas_bancos where cuenta = '" & cbBancoEmisor.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    idcuentaEMI = resultado.GetString("id_cuentaB")
                    saldo = resultado.GetDecimal("saldo")
                    idccontableEMI = resultado.GetString("ccontable")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'buscamos los depositos y retiros de la cuenta

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from movimientos_bancos where id_cuentab = '" & idcuentaEMI & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    b1 = True

                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If b1 = True Then
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select sum(deposito), sum(retiro) from movimientos_bancos where id_cuentab = '" & idcuentaEMI & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        deposito = resultado.GetDecimal("sum(deposito)")
                        retiro = resultado.GetDecimal("sum(retiro)")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            End If

        End If


        total = saldo + deposito - retiro
        tbSaldoEmi.Text = total


    End Sub

    Private Sub cbBancoReceptor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbBancoReceptor.SelectedIndexChanged
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        Dim b1 As Boolean = False
        Dim retiro As Decimal = 0
        Dim deposito As Decimal = 0
        Dim total As Decimal = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from cuentas_bancos where cuenta = '" & cbBancoReceptor.Text & "'", _conexion)
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
                comandoSql = New MySqlCommand("select * from cuentas_bancos where cuenta = '" & cbBancoReceptor.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    idcuentaRec = resultado.GetString("id_cuentaB")
                    saldo1 = resultado.GetDecimal("saldo")
                    idccontablerec = resultado.GetString("ccontable")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            'buscamos los depositos y retiros de la cuenta

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from movimientos_bancos where id_cuentab = '" & idcuentarec & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    b1 = True

                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            If b1 = True Then
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand("select sum(deposito), sum(retiro) from movimientos_bancos where id_cuentab = '" & idcuentarec & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        deposito = resultado.GetDecimal("sum(deposito)")
                        retiro = resultado.GetDecimal("sum(retiro)")
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            End If

        End If


        total = saldo1 + deposito - retiro
        tbSaldoRec.Text = total

    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim conexion As New Class_insert
        Dim datos As New Class_datos
        Dim fecha1 As Date
        Dim fecha1f As String
        Dim b As Boolean = False


        fecha1 = dtpFecha.Value
        fecha1f = fecha1.ToString("yyyy-MM-dd")
#Region "Errores"

        If cbBancoEmisor.Text = "" Then
            MessageBox.Show("El campo Banco emisor no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbBancoReceptor.Text = "" Then
            MessageBox.Show("El campo Banco receptor no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbTtrans.Text = "" Then
            MessageBox.Show("El campo total transferencia no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbBancoEmisor.Text = cbBancoReceptor.Text Then
            MessageBox.Show("No se puede realizar una transferencia entre la misma cuenta bancaria", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

#End Region


        If MessageBox.Show("Esta seguro que desea crear la transferencia bancaria con la fecha: " & dtpFecha.Value.ToShortDateString, "Contago Auto_conta", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = DialogResult.OK Then

            datos.id_cuentaemi = idcuentaEMI
            datos.id_cuentarec = idcuentarec
            datos.total = Convert.ToDecimal(tbTtrans.Text)
            datos.fecha = fecha1f
            If tbNotas.Text = "" Then
                datos.notas = ""
            Else
                datos.notas = tbNotas.Text
            End If


            If conexion.insertartransferencia(datos) Then

            End If

            'hacemos movimiento del banco retiro

            datos.id_banco = idcuentaEMI
            datos.deposito = 0
            datos.retiro = Convert.ToDecimal(tbTtrans.Text)


            If conexion.insertarmovbancos(datos) Then

            End If

            'hacemos movimiento del banco retiro

            datos.id_banco = idcuentarec
            datos.deposito = Convert.ToDecimal(tbTtrans.Text)
            datos.retiro = 0


            If conexion.insertarmovbancos(datos) Then

            End If


            'poliza 

            datos.tipo_poliza = "Diario"

            mes(dtpFecha.Value.Month)


            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from polizas where tipo_poliza = 'Diario' and mes = '" & var_globales.mes & "' and anio = '" & dtpFecha.Value.Year & "'", _conexion)
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
                    comandoSql = New MySqlCommand("select * from polizas where tipo_poliza = 'Diario' and mes = '" & var_globales.mes & "' and anio = '" & dtpFecha.Value.Year & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        datos.numero_poliza = resultado.GetInt64("numero_poliza") + 1
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            End If
        Else

            datos.numero_poliza = 1
        End If

        datos.descripcion = tbNotas.Text
        datos.total = Convert.ToDecimal(tbTtrans.Text)
        datos.mes = var_globales.mes
        datos.anio = dtpFecha.Value.Year
        datos.user = scrPrincipal2.lblNUsuario.Text
        datos.usuariomodificador = scrPrincipal2.lblNUsuario.Text
        datos.origen = "Transferencia bancaria"

        If conexion.insertaPolizas(datos) Then

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select max(id_poliza) from polizas", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    datos.id_poliza = resultado.GetString("max(id_poliza)")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

            datos.fechat = fecha1f

            datos.id_cuenta = idccontablerec
            datos.cargo = Convert.ToDecimal(tbTtrans.Text)
            datos.abono = 0
            datos.desc_asiento = "Transferencia bancaria "

            If conexion.insertaPolDet(datos) Then

            End If

            datos.fechat = fecha1f

            datos.id_cuenta = idccontableEMI
            datos.cargo = 0
            datos.abono = Convert.ToDecimal(tbTtrans.Text)
            datos.desc_asiento = "Transferencia bancaria "

            If conexion.insertaPolDet(datos) Then

            End If



        End If




    End Sub


End Class