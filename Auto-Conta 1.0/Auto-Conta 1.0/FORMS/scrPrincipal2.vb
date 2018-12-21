Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrPrincipal2
#Region "Variables"
    Dim cargosi As Decimal
    Dim abonosi As Decimal
    Dim cargo As Decimal
    Dim abono As Decimal
#End Region

#Region "FUNCIONES"
    Public Sub config_panel_botones(ByVal tipo As String)
        'PANELES CONFIG
        pConfig.Size = New Size(164, 46)
        pConfig.Location = New Point(883, 102)
        pConfig.Visible = False

        pBanco.Size = New Size(164, 46)
        pBanco.Location = New Point(885, 154)
        pBanco.Visible = False

        pXML.Size = New Size(164, 46)
        pXML.Location = New Point(883, 209)
        pXML.Visible = False

        pReportes.Size = New Size(164, 46)
        pReportes.Location = New Point(841, 264)
        pReportes.Visible = False

        Select Case tipo
            Case "CONFIGURACION"
                'BOTONES
                btnBancos.Location = New Point(3, 420)
                btnXML.Location = New Point(3, 449)
                btnReportes.Location = New Point(3, 478)
                'PANEL
                pConfig.Size = New Size(261, 370)
                pConfig.Location = New Point(3, 134)
                pConfig.Visible = True
            Case "BANCOS"
                btnBancos.Location = New Point(3, 44)
                btnXML.Location = New Point(3, 449)
                btnReportes.Location = New Point(3, 478)
                'PANEL
                pBanco.Size = New Size(261, 370)
                pBanco.Location = New Point(3, 167)
                pBanco.Visible = True
            Case "XML"
                btnBancos.Location = New Point(3, 44)
                btnXML.Location = New Point(3, 71)
                btnReportes.Location = New Point(3, 478)
                'PANEL
                pXML.Size = New Size(261, 370)
                pXML.Location = New Point(3, 192)
                pXML.Visible = True
            Case "REPORTES"
                btnBancos.Location = New Point(3, 44)
                btnXML.Location = New Point(3, 73)
                btnReportes.Location = New Point(3, 102)
                'PANEL
                pReportes.Size = New Size(261, 370)
                pReportes.Location = New Point(3, 225)
                pReportes.Visible = True
        End Select
    End Sub

    Public Sub config_panel(ByVal panel As Panel)
        'PANEL CONFIG
        pSXML.Visible = False
        pSXML.Size = New Size(109, 62)
        pSXML.Location = New Point(936, 291)

        pPolizas.Visible = False
        pPolizas.Size = New Size(109, 62)
        pPolizas.Location = New Point(936, 267)

        pLogo.Visible = False
        pLogo.Size = New Size(109, 62)
        pLogo.Location = New Point(936, 267)

        pBalanza.Visible = False
        pBalanza.Size = New Size(109, 62)
        pBalanza.Location = New Point(936, 267)

        pCXC.Visible = False
        pCXC.Size = New Size(109, 62)
        pCXC.Location = New Point(936, 267)

        panel.Visible = True
        panel.Size = New Size(780, 524)
        panel.Location = New Point(277, 102)
    End Sub
#End Region

#Region "CONFIGURACION"
    Private Sub btnConfig_Click(sender As Object, e As EventArgs) Handles btnConfig.Click
        config_panel_botones("CONFIGURACION")
        config_panel(pLogo)
    End Sub

    Private Sub MaterialFlatButton5_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton5.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        scrAlta_empresa.Show()
        scrAlta_empresa.BringToFront()

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from config_auto_conta.bases where base = '" & var_globales.base & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                scrAlta_empresa.tbNombreBaese.Text = resultado.GetString("base")
                scrAlta_empresa.tbNomEmp.Text = resultado.GetString("nombre_emp")
                scrAlta_empresa.tbRFCEmp.Text = resultado.GetString("rfc_emp")
                scrAlta_empresa.cbRegFis.Text = resultado.GetString("regimen_emp")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

    End Sub

    Private Sub btnRFC_Click(sender As Object, e As EventArgs) Handles btnRFC.Click
        scrAltaRFC.Show()
        scrAltaRFC.BringToFront()
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        scrAltaCatalogo.Show()
        scrAltaCatalogo.BringToFront()
    End Sub

    Private Sub MaterialFlatButton6_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton6.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim banUs As Boolean = False
        Dim banEm As Boolean = False

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from config_auto_conta.users", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                banUs = True
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
            comandoSql = New MySqlCommand("select * from config_auto_conta.bases", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                banEm = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If banUs = True Then
            scrUsuariosEmpresas.dgvUsuarios.Rows.Clear()
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.users where user_name <> 'root' order by user_name asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuariosEmpresas.dgvUsuarios.Rows.Add(resultado.GetInt64("id_user"), resultado.GetString("user_name"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

        If banEm = True Then
            scrUsuariosEmpresas.dgvEmpresas.Rows.Clear()
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from config_auto_conta.bases order by base asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    scrUsuariosEmpresas.dgvEmpresas.Rows.Add(resultado.GetInt64("id_base"), resultado.GetString("nombre_emp"), resultado.GetString("rfc_emp"), resultado.GetString("base"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

        scrUsuariosEmpresas.Show()
        scrUsuariosEmpresas.BringToFront()
    End Sub
#End Region

#Region "BANCOS"
    Private Sub btnBancos_Click(sender As Object, e As EventArgs) Handles btnBancos.Click
        config_panel_botones("BANCOS")
        config_panel(pLogo)
    End Sub
#End Region

#Region "XML"
    Private Sub btnXML_Click(sender As Object, e As EventArgs) Handles btnXML.Click
        config_panel_botones("XML")
        config_panel(pSXML)

        dgvXML_2.Rows.Clear()
        'MOSTRAMOS LOS XML GUARDADOS DEL MES
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from factura where fecha_t like '" & Date.Now.ToString("yyyy-MM") & "-__%' and estatus = 'Timbrado' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                  resultado.GetString("version"),
                                  resultado.GetString("serie_t"),
                                  resultado.GetString("folio_t"),
                                  resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                  resultado.GetString("nombre_r"),
                                  resultado.GetString("rfc_r"),
                                  resultado.GetString("nombre_e"),
                                  resultado.GetString("rfc_e"),
                                  resultado.GetString("tipo"),
                                  resultado.GetString("uuid"),
                                  resultado.GetDecimal("sub_t"),
                                  resultado.GetDecimal("total_t"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub btnSubirXML_Click(sender As Object, e As EventArgs) Handles btnSubirXML.Click
        scrCargaXML.Show()
        scrCargaXML.BringToFront()
    End Sub

    Private Sub tbXMLBus_Click(sender As Object, e As EventArgs) Handles btnXMLBus.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbXMLTb.Text = "" Then
            MessageBox.Show("Campo Obligatorio", "Contago Auto-Conta 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbXMLTb.Focus()
            Return
        End If

        dgvXML_2.Rows.Clear()

        Select Case cbXMLTb.Text
            Case "TODOS"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpXMLF1.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpXMLF2.Value.ToString("yyyy-MM-dd") & "' and estatus = 'Timbrado' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("version"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("uuid"),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "NOMBRE EMISOR"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpXMLF1.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpXMLF2.Value.ToString("yyyy-MM-dd") & "' and nombre_e like '%" & tbXMLOp.Text & "%'  and estatus = 'Timbrado' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("version"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("uuid"),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "NOMBRE RECEPTOR"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpXMLF1.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpXMLF2.Value.ToString("yyyy-MM-dd") & "' and nombre_r like '%" & tbXMLOp.Text & "%'  and estatus = 'Timbrado' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("version"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("uuid"),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "RFC EMISOR"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpXMLF1.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpXMLF2.Value.ToString("yyyy-MM-dd") & "' and rfc_e like '%" & tbXMLOp.Text & "%' and estatus = 'Timbrado' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("version"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("uuid"),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "RFC RECEPTOR"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpXMLF1.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpXMLF2.Value.ToString("yyyy-MM-dd") & "' and rfc_r like '%" & tbXMLOp.Text & "%' and estatus = 'Timbrado' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("version"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("uuid"),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
        End Select
    End Sub

    Private Sub btnVerPol_Click(sender As Object, e As EventArgs) Handles btnVerPol.Click
        config_panel(pPolizas)

        dgvPolizas.Rows.Clear()
        'MOSTRAMOS LAS PÓLIZAS GUARDADOS DEL MES
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from polizas where fecha like '" & Date.Now.ToString("yyyy-MM") & "-__%' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                    resultado.GetString("tipo_poliza"),
                                    resultado.GetString("numero_poliza"),
                                    resultado.GetString("descripcion"),
                                    resultado.GetString("estado"),
                                    resultado.GetDecimal("total"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub

    Private Sub btnPolB_Click(sender As Object, e As EventArgs) Handles btnPolB.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbOpPol.Text = "" Then
            MessageBox.Show("Campo Obligatorio", "Contago Auto-Conta 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbOpPol.Focus()
            Return
        End If

        If cbOpPol2.Text = "" Then
            MessageBox.Show("Campo Obligatorio", "Contago Auto-Conta 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbOpPol2.Focus()
            Return
        End If

        dgvPolizas.Rows.Clear()

        Select Case cbOpPol2.Text
            Case "TODAS"
                Select Case cbOpPol.Text
                    Case "TODAS"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "ACTIVO"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'activo' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "CANCELADA"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'cancelado' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                End Select
            Case "INGRESO"
                Select Case cbOpPol.Text
                    Case "TODAS"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and tipo_poliza = 'INGRESO' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "ACTIVO"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'activo' and tipo_poliza = 'INGRESO' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "CANCELADA"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'cancelado' and tipo_poliza = 'INGRESO' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                End Select
            Case "DIARIO"
                Select Case cbOpPol.Text
                    Case "TODAS"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and tipo_poliza = 'Diario' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "ACTIVO"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'activo' and tipo_poliza = 'Diario' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "CANCELADA"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'cancelado' and tipo_poliza = 'Diario' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                End Select
            Case "EGRESO"
                Select Case cbOpPol.Text
                    Case "TODAS"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and tipo_poliza = 'Egreso' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "ACTIVO"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'activo' and tipo_poliza = 'Egreso' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                    Case "CANCELADA"
                        Try
                            Conexion_Global()
                            _conexion.Open()
                            comandoSql = New MySqlCommand(" select * from polizas where fecha >= '" & dtpPolF1.Value.ToString("yyyy-MM-dd") & "' and fecha <= '" & dtpPolF2.Value.ToString("yyyy-MM-dd") & "' and estado = 'cancelado' and tipo_poliza = 'Egreso' ", _conexion)
                            resultado = comandoSql.ExecuteReader
                            While resultado.Read
                                dgvPolizas.Rows.Add(resultado.GetString("id_poliza"),
                                                    resultado.GetDateTime("fecha").ToString("dd/MMMM/yyyy"),
                                                    resultado.GetString("tipo_poliza"),
                                                    resultado.GetString("numero_poliza"),
                                                    resultado.GetString("descripcion"),
                                                    resultado.GetString("estado"),
                                                    resultado.GetDecimal("total"))
                            End While
                            resultado.Close()
                        Catch ex As MySqlException
                            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        Finally
                            cerrar()
                        End Try
                        _conexion.Close()
                End Select
        End Select
    End Sub

    Private Sub dgvPolizas_DoubleClick(sender As Object, e As EventArgs) Handles dgvPolizas.DoubleClick
        Dim indice As String = dgvPolizas.CurrentRow.Index.ToString
        scrVerPoliza.load_poliza(dgvPolizas.Rows(indice).Cells(0).Value)
        scrVerPoliza.Show()
        scrVerPoliza.BringToFront()
    End Sub

    Private Sub CANCELARToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CANCELARToolStripMenuItem.Click
        'MOSTRAMOS LOS XML GUARDADOS DEL MES
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim datos As New Class_datos
        Dim conexion As New Class_update

        Dim indice As Integer = dgvXML_2.CurrentRow.Index.ToString
        Dim id_factura As Integer = dgvXML_2.Rows(indice).Cells(0).Value

        Dim result As Integer = MessageBox.Show("Al cancelar una factura, se cancelaran las pólizas involucradas ¿Desea continuar? ", "Contago Auto-Conta 1.0", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2)

        If result = DialogResult.Yes Then
            datos.id_factura = id_factura
            conexion.update_cancel_polizas_factura(datos)
            conexion.update_cancel_factura(datos)

            dgvXML_2.Rows.Clear()

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand(" select * from factura where fecha_t like '" & Date.Now.ToString("yyyy-MM") & "-__%' and estatus = 'Timbrado' ", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    dgvXML_2.Rows.Add(resultado.GetString("id_timbrados"),
                                      resultado.GetString("version"),
                                      resultado.GetString("serie_t"),
                                      resultado.GetString("folio_t"),
                                      resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                      resultado.GetString("nombre_r"),
                                      resultado.GetString("rfc_r"),
                                      resultado.GetString("nombre_e"),
                                      resultado.GetString("rfc_e"),
                                      resultado.GetString("tipo"),
                                      resultado.GetString("uuid"),
                                      resultado.GetDecimal("sub_t"),
                                      resultado.GetDecimal("total_t"))
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

    Private Sub HACERNODEDUCIBLEToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HACERNODEDUCIBLEToolStripMenuItem.Click
        Dim indice As Integer = dgvXML_2.CurrentRow.Index.ToString
        Dim id_factura As Integer = dgvXML_2.Rows(indice).Cells(0).Value
        Dim rfc_r As String = dgvXML_2.Rows(indice).Cells(6).Value
        Dim rfc_e As String = dgvXML_2.Rows(indice).Cells(8).Value

        Dim rfc As String = get_rfc_empresa()
        Dim tipo As String = ""

        If rfc_r = rfc Then
            tipo = "RECIBIDO"
        Else
            tipo = "EMITIDO"
        End If
    End Sub
#End Region

#Region "REPORTES"
    Private Sub btnReportes_Click(sender As Object, e As EventArgs) Handles btnReportes.Click
        config_panel_botones("REPORTES")
        config_panel(pLogo)
    End Sub

    Private Sub btnXCobrar_Click(sender As Object, e As EventArgs) Handles btnXCobrar.Click
        config_panel(pCXC)
    End Sub

    Private Sub btnCxCBus_Click(sender As Object, e As EventArgs) Handles btnCxCBus.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbCxCOp.Text = "" Then
            MessageBox.Show("Campo Obligatorio", "Contago Auto-Conta 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbCxCOp.Focus()
            Return
        End If

        dgvPagos.Rows.Clear()

        Dim rfc As String = get_rfc_empresa()

        Select Case cbCxCOp.Text
            Case "TODOS"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpCxCIn.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpCxCFn.Value.ToString("yyyy-MM-dd") & "' and estatus = 'Timbrado' and condicion = 'PPD' and rfc_e = '" & rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvPagos.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("condicion"),
                                          resultado.GetString("uuid"),
                                          get_estatus_pago(resultado.GetString("uuid"), resultado.GetDecimal("total_t")),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "NOMBRE"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpCxCIn.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpCxCFn.ToString("yyyy-MM-dd") & "' and nombre_r like '%" & tbCxCOp.Text & "%'  and estatus = 'Timbrado' and condicion = 'PPD' and rfc_e = '" & rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvPagos.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("condicion"),
                                          resultado.GetString("uuid"),
                                          get_estatus_pago(resultado.GetString("uuid"), resultado.GetDecimal("total_t")),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "RFC"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtpCxCIn.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtpCxCFn.ToString("yyyy-MM-dd") & "' and rfc_r like '%" & tbCxCOp.Text & "%' and estatus = 'Timbrado' and condicion = 'PPD' and rfc_e = '" & rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvPagos.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_r"),
                                          resultado.GetString("rfc_r"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("condicion"),
                                          resultado.GetString("uuid"),
                                          get_estatus_pago(resultado.GetString("uuid"), resultado.GetDecimal("total_t")),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
        End Select
    End Sub

    Private Sub VERPAGOSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERPAGOSToolStripMenuItem.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        scrVerPagos.dgvPagos.Rows.Clear()

        Dim indice As Integer = dgvPagos2.CurrentRow.Index.ToString
        Dim uuid As String = dgvPagos2.Rows(indice).Cells(8).Value
        Dim total As Decimal = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select f.serie_t, f.folio_t, f.uuid, fp.importe_pagado from factura f join (factura_pagos fp) on (fp.id_factura = f.id_timbrados) where fp.uuid = '" & uuid & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                scrVerPagos.dgvPagos.Rows.Add(resultado.GetString("serie_t"),
                                              resultado.GetString("folio_t"),
                                              resultado.GetString("uuid"),
                                              resultado.GetDecimal("importe_pagado"))

                total += resultado.GetDecimal("importe_pagado")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        scrVerPagos.tbTotal.Text = total.ToString("N2")
        scrVerPagos.Text = "Ver Cobros"
        scrVerPagos.Show()
        scrVerPagos.BringToFront()
    End Sub

    Public Function get_estatus_pago(ByVal uuid As String, ByVal total As Decimal) As String
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim pago As Decimal = 0
        Dim estatus As String = ""

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select sum(importe_pagado) from factura_pagos where uuid = '" & uuid & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                Try
                    pago = resultado.GetDecimal("sum(importe_pagado)")
                Catch ex As Exception
                    pago = 0.0
                End Try
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If pago < total Then
            estatus = "Pendiente"
        Else
            estatus = "Pagado"
        End If

        Return estatus
    End Function

    Private Sub REALIZARPAGOToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REALIZARPAGOToolStripMenuItem.Click
        Dim indice As Integer = dgvPagos.CurrentRow.Index.ToString
        Dim total As Decimal = dgvPagos.Rows(indice).Cells(11).Value

        scrRealizaPago.Text = "Realizar Cobro"
        scrRealizaPago.gbDatosF.Text = "Datos de la Factura a Cobrar"
        scrRealizaPago.btnPC.Text = "Realizar Cobro"
        scrRealizaPago.tbNombre.Text = dgvPagos.Rows(indice).Cells(4).Value
        scrRealizaPago.tbRFC.Text = dgvPagos.Rows(indice).Cells(5).Value
        scrRealizaPago.tbTotal.Text = total.ToString("N2")
        scrRealizaPago.uuid = dgvPagos.Rows(indice).Cells(8).Value
        scrRealizaPago.nombre = get_nombre_empresa()
        scrRealizaPago.rfc = get_rfc_empresa()
        scrRealizaPago.tipo_ = "EMITIDOS"

        scrRealizaPago.Show()
        scrRealizaPago.BringToFront()

    End Sub

    Private Sub btnCXP_Click(sender As Object, e As EventArgs) Handles btnCXP.Click
        config_panel(pCXP)
    End Sub

    Private Sub btnBusCXP_Click(sender As Object, e As EventArgs) Handles btnBusCXP.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        If cbOpCXP.Text = "" Then
            MessageBox.Show("Campo Obligatorio", "Contago Auto-Conta 2018", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            cbOpCXP.Focus()
            Return
        End If

        dgvPagos2.Rows.Clear()

        Dim rfc As String = get_rfc_empresa()

        Select Case tbOpCXP.Text
            Case "TODOS"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtp1CXP.Value.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtp2CXP.Value.ToString("yyyy-MM-dd") & "' and estatus = 'Timbrado' and condicion = 'PPD' and rfc_r = '" & rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvPagos2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("condicion"),
                                          resultado.GetString("uuid"),
                                          get_estatus_pago(resultado.GetString("uuid"), resultado.GetDecimal("total_t")),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "NOMBRE"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtp1CXP.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtp2CXP.ToString("yyyy-MM-dd") & "' and nombre_r like '%" & tbOpCXP.Text & "%'  and estatus = 'Timbrado' and condicion = 'PPD' and rfc_r = '" & rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvPagos2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("condicion"),
                                          resultado.GetString("uuid"),
                                          get_estatus_pago(resultado.GetString("uuid"), resultado.GetDecimal("total_t")),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
            Case "RFC"
                Try
                    Conexion_Global()
                    _conexion.Open()
                    comandoSql = New MySqlCommand(" select * from factura where fecha_t >= '" & dtp1CXP.ToString("yyyy-MM-dd") & "' and fecha_t <= '" & dtp2CXP.ToString("yyyy-MM-dd") & "' and rfc_r like '%" & tbOpCXP.Text & "%' and estatus = 'Timbrado' and condicion = 'PPD' and rfc_r = '" & rfc & "' ", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        dgvPagos2.Rows.Add(resultado.GetString("id_timbrados"),
                                          resultado.GetString("serie_t"),
                                          resultado.GetString("folio_t"),
                                          resultado.GetDateTime("fecha_t").ToString("dd-MMMM-yyyy"),
                                          resultado.GetString("nombre_e"),
                                          resultado.GetString("rfc_e"),
                                          resultado.GetString("tipo"),
                                          resultado.GetString("condicion"),
                                          resultado.GetString("uuid"),
                                          get_estatus_pago(resultado.GetString("uuid"), resultado.GetDecimal("total_t")),
                                          resultado.GetDecimal("sub_t"),
                                          resultado.GetDecimal("total_t"))
                    End While
                    resultado.Close()
                Catch ex As MySqlException
                    MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Finally
                    cerrar()
                End Try
                _conexion.Close()
        End Select
    End Sub

    Private Sub VERCOBROSToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles VERCOBROSToolStripMenuItem.Click
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        scrVerPagos.dgvPagos.Rows.Clear()

        Dim indice As Integer = dgvPagos.CurrentRow.Index.ToString
        Dim uuid As String = dgvPagos.Rows(indice).Cells(8).Value
        Dim total As Decimal = 0

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select f.serie_t, f.folio_t, f.uuid, fp.importe_pagado from factura f join (factura_pagos fp) on (fp.id_factura = f.id_timbrados) where fp.uuid = '" & uuid & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                scrVerPagos.dgvPagos.Rows.Add(resultado.GetString("serie_t"),
                                              resultado.GetString("folio_t"),
                                              resultado.GetString("uuid"),
                                              resultado.GetDecimal("importe_pagado"))

                total += resultado.GetDecimal("importe_pagado")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        scrVerPagos.tbTotal.Text = total.ToString("N2")
        scrVerPagos.Text = "Ver Pagos"
        scrVerPagos.Show()
        scrVerPagos.BringToFront()
    End Sub

    Private Sub REALIZARCOBROToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles REALIZARCOBROToolStripMenuItem.Click
        Dim indice As Integer = dgvPagos2.CurrentRow.Index.ToString
        Dim total As Decimal = dgvPagos2.Rows(indice).Cells(11).Value

        scrRealizaPago.Text = "Realizar Pago"
        scrRealizaPago.gbDatosF.Text = "Datos de la Factura a Pagar"
        scrRealizaPago.btnPC.Text = "Realizar Pago"
        scrRealizaPago.tbNombre.Text = dgvPagos2.Rows(indice).Cells(4).Value
        scrRealizaPago.tbRFC.Text = dgvPagos2.Rows(indice).Cells(5).Value
        scrRealizaPago.tbTotal.Text = total.ToString("N2")
        scrRealizaPago.uuid = dgvPagos2.Rows(indice).Cells(8).Value
        scrRealizaPago.nombre = get_nombre_empresa()
        scrRealizaPago.rfc = get_rfc_empresa()
        scrRealizaPago.tipo_ = "RECIBIDOS"

        scrRealizaPago.Show()
        scrRealizaPago.BringToFront()
    End Sub
#End Region

    Private Sub scrPrincipal2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        scrIniciarsesion.Show()
        scrIniciarsesion.cbConexion.Select()
        scrIniciarsesion.TopMost = True
        config_panel(pLogo)
    End Sub

    Private Sub btnBanco_Click(sender As Object, e As EventArgs) Handles btnBanco.Click
        scrNuevoBanco.Show()
    End Sub

    Private Sub btnCuenta_Click(sender As Object, e As EventArgs) Handles btnCuenta.Click
        scrNuevaCuenta.Show()
    End Sub

    Private Sub MaterialFlatButton2_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton2.Click
        scrTransferencia.Show()
    End Sub

    Private Sub btnImpuestos_Click(sender As Object, e As EventArgs) Handles btnImpuestos.Click
        scrAltaImpuestos.Show()
        scrAltaImpuestos.BringToFront()
    End Sub

    Private Sub btnBalanza_Click(sender As Object, e As EventArgs) Handles btnBalanza.Click
        config_panel(pBalanza)
        dgvBalanza.Columns.Clear()
        dgvBalanza.Columns.Add("cunica", "cunica")
        dgvBalanza.Columns.Add("cuenta", "CUENTA")
        dgvBalanza.Columns.Add("nombre_cuenta", "NOMBRE")
        dgvBalanza.Columns.Add("Cargo_SI", "DEBE")
        dgvBalanza.Columns.Add("Abono_SI", "HABER")
        dgvBalanza.Columns.Add("Cargo", "CARGO")
        dgvBalanza.Columns.Add("Abono", "ABONO")
        dgvBalanza.Columns.Add("Cargo_SF", "DEBE")
        dgvBalanza.Columns.Add("Abono_SF", "HABER")
        dgvBalanza.Columns.Add("Tipo", "TIPO")
        dgvBalanza.Columns(0).Visible = False
        dgvBalanza.Columns(9).Visible = False
    End Sub

    Private Sub btnGeneraBalanza_Click(sender As Object, e As EventArgs) Handles btnGeneraBalanza.Click
        balanza()
    End Sub

    Public Sub balanza()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim banderaCuenta As Boolean = False
        Dim cuentaunica, cuenta, nombrecuenta As String
        Dim cargofin As Decimal
        Dim abonofin As Decimal
        Dim cantidad As Decimal
        Dim inicial As Decimal
        Dim tipo As String = ""
        Dim naturaleza As String = ""
        Dim naturaleza_a As String = ""


        dgvBalanza.Rows.Clear()
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                banderaCuenta = True
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        If banderaCuenta = True Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable order by numero_cuenta_unico asc", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cuentaunica = resultado.GetString("numero_cuenta_unico")
                    cuenta = resultado.GetString("numero_cuenta")
                    nombrecuenta = resultado.GetString("nombre_cuenta")
                    tipo = resultado.GetString("tipo")
                    si(cuentaunica)
                    mes1(cuentaunica)

                    naturaleza = resultado.GetString("naturaleza")

                    If naturaleza = "" Then
                        naturaleza = naturaleza_a
                    End If
                    naturaleza_a = naturaleza

                    'saldo final
                    If naturaleza = "D" Then
                        cargosi = cargosi - abonosi
                        abonosi = "0.00"
                    End If
                    If naturaleza = "A" Then
                        inicial = abonosi - cargosi
                        cargosi = "0.00"
                        abonosi = inicial
                    End If

                    'inicial = cargosi - abonosi
                    'If inicial > 0 Then
                    '    cargosi = inicial
                    '    abonosi = 0
                    'Else
                    '    cargosi = 0
                    '    abonosi = inicial * -1
                    'End If

                    cantidad = cargosi - abonosi + cargo - abono

                    If naturaleza = "D" Then
                        cargofin = cantidad
                        abonofin = 0
                    Else
                        cargofin = 0
                        abonofin = cantidad * -1
                    End If

                    If cargosi = 0 And abonosi = 0 And cargo = 0 And abono = 0 Then
                    Else
                        dgvBalanza.Rows.Add(cuentaunica, cuenta, nombrecuenta, cargosi, abonosi, cargo, abono, cargofin, abonofin, tipo)
                    End If
                    inicial = 0
                    cargofin = 0
                    abonofin = 0
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        End If
        dgvBalanza.Columns(0).Visible = False
        dgvBalanza.Columns(3).DefaultCellStyle.Format = "N2"
        dgvBalanza.Columns(4).DefaultCellStyle.Format = "N2"
        dgvBalanza.Columns(5).DefaultCellStyle.Format = "N2"
        dgvBalanza.Columns(6).DefaultCellStyle.Format = "N2"
        dgvBalanza.Columns(7).DefaultCellStyle.Format = "N2"
        dgvBalanza.Columns(8).DefaultCellStyle.Format = "N2"
        'dgvPrincipal.Columns(9).Visible = False

        dgvBalanza.Columns(3).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBalanza.Columns(4).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBalanza.Columns(5).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBalanza.Columns(6).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBalanza.Columns(7).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
        dgvBalanza.Columns(8).DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
    End Sub

    Public Sub si(cunica)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim fecha As String
        Dim fecha1 As Date

        Dim fechas As String
        Dim fechas1 As Date

        Dim dia As String
        Dim mes As String
        Dim año As String
        Dim dia1 As String
        Dim mes1 As String
        Dim año1 As String
        Dim b As Boolean = False
        cargosi = 0
        abonosi = 0

        fecha1 = dtpFin.Value
        fecha = fecha1.ToString("yyyy-MM-dd")

        fechas1 = dtpInicio.Value
        fechas = fechas1.ToString("yyyy-MM-dd")


        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("sELECT * from polizas_det pold join catalogo_contable cat on pold.id_cuenta = cat.id_cuenta 
 where pold.estado = 'activo' and fecha < '" & fechas & "' and cat.numero_cuenta_unico like '" & cunica & "%';", _conexion)
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
                comandoSql = New MySqlCommand(" sELECT sum(cargo), sum(abono) from polizas_det pold join catalogo_contable cat on pold.id_cuenta = cat.id_cuenta 
 where pold.estado = 'activo' and fecha < '" & fechas & "' and cat.numero_cuenta_unico like '" & cunica & "%';", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cargosi = resultado.GetString("sum(cargo)")
                    abonosi = resultado.GetString("sum(abono)")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        Else
            cargosi = 0
            abonosi = 0
        End If

    End Sub
    Public Sub mes1(cunica)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim fecha As String
        Dim fecha1 As Date

        Dim fechas As String
        Dim fechas1 As Date
        Dim dia As String
        Dim mes As String
        Dim año As String
        Dim dia1 As String
        Dim mes1 As String
        Dim año1 As String
        Dim b As Boolean = False
        cargo = 0
        abono = 0
        fecha1 = dtpFin.Value
        fecha = fecha1.ToString("yyyy-MM-dd")

        fechas1 = dtpInicio.Value
        fechas = fechas1.ToString("yyyy-MM-dd")

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("sELECT * from polizas_det pold join catalogo_contable cat on pold.id_cuenta = cat.id_cuenta join polizas pol on pold.id_poliza = pol.id_poliza
 where pold.estado = 'activo' and pold.fecha >= '" & fechas & "' and  pold.fecha <= '" & fecha & "' and cat.numero_cuenta_unico like '" & cunica & "%' and pol.numero_poliza <> '0' and pol.anio <= '" & fecha.Substring(0, 4) & "';", _conexion)
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
                comandoSql = New MySqlCommand(" sELECT sum(cargo), sum(abono) from polizas_det pold join catalogo_contable cat on pold.id_cuenta = cat.id_cuenta join polizas pol on pold.id_poliza = pol.id_poliza
 where pold.estado = 'activo' and pold.fecha >= '" & fechas & "' and  pold.fecha <= '" & fecha & "' and cat.numero_cuenta_unico like '" & cunica & "%' and pol.numero_poliza <> '0' and pol.anio <= '" & fecha.Substring(0, 4) & "';", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read

                    cargo = resultado.GetString("sum(cargo)")
                    abono = resultado.GetString("sum(abono)")
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

    Private Sub btnCambiarU_Click(sender As Object, e As EventArgs) Handles btnCambiarU.Click
        scrIniciarsesion.Show()
        scrIniciarsesion.BringToFront()

        lblNUsuario.Text = ""
        Me.Text = ""
        var_globales.base = "config_auto_conta"
    End Sub

End Class