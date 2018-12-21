Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrVerPoliza
    Public Sub load_poliza(ByVal id_poliza As String)
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader

        Dim id_factura As Integer = 0

        'CABECERA DE LA PÓLIZA
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from polizas where id_poliza = '" & id_poliza & "'; ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                tbNombrePol.Text = resultado.GetString("tipo_poliza")
                tbNumPol.Text = resultado.GetString("numero_poliza")
                tbDes.Text = resultado.GetString("descripcion")
                dtpFecha.Value = resultado.GetDateTime("fecha")
                id_factura = resultado.GetDecimal("id_factura")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        dgvPoliza.Rows.Clear()
        dgvXML.Rows.Clear()
        tbTotCar.Text = 0
        tbtotAbo.Text = 0
        tbTotXMl.Text = 0

        'DETALLE DE LA PÓLIZA
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select cc.numero_cuenta,cc.nombre_cuenta,pd.cargo,pd.abono,pd.desc_asiento from polizas_det pd join (catalogo_contable cc) on (pd.id_cuenta = cc.id_cuenta) where pd.id_poliza = '" & id_poliza & "'; ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvPoliza.Rows.Add(resultado.GetString("numero_cuenta"),
                                   resultado.GetString("nombre_cuenta"),
                                   resultado.GetDecimal("cargo"),
                                   resultado.GetDecimal("abono"),
                                   resultado.GetString("desc_asiento"))

                tbTotCar.Text = tbTotCar.Text + resultado.GetDecimal("cargo")
                tbtotAbo.Text = tbtotAbo.Text + resultado.GetDecimal("abono")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        'XML DE LA PÓLIZA
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand(" select * from factura where id_timbrados = '" & id_factura & "' ", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                dgvXML.Rows.Add(resultado.GetString("uuid"),
                                resultado.GetString("nombre_e"),
                                resultado.GetString("rfc_e"),
                                resultado.GetString("nombre_r"),
                                resultado.GetString("rfc_r"),
                                resultado.GetString("folio_t"),
                                resultado.GetDateTime("fecha_t").ToString("dd/MMMM/yyyy"),
                                resultado.GetDecimal("total_t"),
                                resultado.GetString("tipo"))

                tbTotXMl.Text = resultado.GetDecimal("total_t")
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()
    End Sub
End Class