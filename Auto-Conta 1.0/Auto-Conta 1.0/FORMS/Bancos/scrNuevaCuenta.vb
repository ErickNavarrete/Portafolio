Imports MySql.Data
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient

Public Class scrNuevaCuenta
    Private Sub scrNuevaCuenta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        carga()
    End Sub


    Private Sub carga()

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        dgvCuentaB.Rows.Clear()
        cbBanco.Items.Clear()

#Region "Cuentas"

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
                comandoSql = New MySqlCommand("select banco, cuenta, nombre_cuenta, numero_cuenta from cuentas_bancos cu join bancos ba on cu.id_banco = ba.id_banc join catalogo_contable cat on cu.ccontable = cat.id_cuenta", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    dgvCuentaB.Rows.Add(resultado.GetString("banco"), resultado.GetString("cuenta"), resultado.GetString("nombre_cuenta"), resultado.GetString("numero_cuenta"))
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()
        End If

#End Region

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from bancos", _conexion)
            resultado = comandoSql.ExecuteReader
            While resultado.Read
                cbBanco.Items.Add(resultado.GetString("banco"))
            End While
            resultado.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            cerrar()
        End Try
        _conexion.Close()

        carganombre()
    End Sub

    Private Sub tsbGuardar_Click(sender As Object, e As EventArgs) Handles tsbGuardar.Click

        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim conexion As New Class_insert
        Dim datos As New Class_datos
        Dim idccontable As Integer
        Dim id As Integer
        Dim b As Boolean = False

        If cbBanco.Text = "" Then
            MessageBox.Show("El campo banco no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tbCuentab.Text = "" Then
            MessageBox.Show("El campo cuenta bancaria no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If cbCcontable.Text = "" Then
            MessageBox.Show("El campo cuenta contable no puede permanecer vacio", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from bancos where banco = '" & cbBanco.Text & "'", _conexion)
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
                comandoSql = New MySqlCommand("select * from bancos where banco = '" & cbBanco.Text & "'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    id = resultado.GetInt64("id_banc")
                End While
                resultado.Close()
            Catch ex As MySqlException
                MessageBox.Show(ex.Message, "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                cerrar()
            End Try
            _conexion.Close()

        Else
            MessageBox.Show("El Banco no existe en la base de datos", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return

        End If

        b = False
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from cuentas_bancos where cuenta = '" & tbCuentab.Text & "'", _conexion)
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
            MessageBox.Show("Error la cuenta bancaria ya existe en la base de datos", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If tsbNombre.Visible = True Then
            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable where numero_cuenta = '" & cbCcontable.Text & "'", _conexion)
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
                    comandoSql = New MySqlCommand("select * from catalogo_contable  where numero_cuenta = '" & cbCcontable.Text & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        idccontable = resultado.GetInt64("id_cuenta")
                    End While
                    resultado.Close()
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

        Else

            Try
                Conexion_Global()
                _conexion.Open()
                comandoSql = New MySqlCommand("select * from catalogo_contable where nombre_cuenta = '" & cbCcontable.Text & "'", _conexion)
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
                    comandoSql = New MySqlCommand("select * from catalogo_contable  where nombre_cuenta = '" & cbCcontable.Text & "'", _conexion)
                    resultado = comandoSql.ExecuteReader
                    While resultado.Read
                        idccontable = resultado.GetInt64("id_cuenta")
                    End While
                    resultado.Close()
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

        End If


        datos.id_cuenta_padre = idccontable
        datos.id_banco = id
        datos.Cuentab = tbCuentab.Text

        If conexion.insertarcuentaB(datos) Then
            MessageBox.Show("CUenta bancaria Guardada Correctamente", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cbBanco.Text = ""
            tbCuentab.Text = ""
            carga()

        Else
            MessageBox.Show("Error al insertar el banco", "Contago Egresos 2.1 2018", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If

    End Sub

    Private Sub NuevoBancoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NuevoBancoToolStripMenuItem.Click
        scrNuevoBanco.Show()
    End Sub

    Private Sub tsbnumero_Click(sender As Object, e As EventArgs) Handles tsbnumero.Click
        carganumero()
        tsbnumero.Visible = False
        tsbNombre.Visible = True
    End Sub


    Public Sub carganombre()
        Dim comandoSql As MySqlCommand
        Dim resultado As MySqlDataReader
        Dim b As Boolean = False
        cbCcontable.Items.Clear()
        cbCcontable.Text = ""
        Try
            Conexion_Global()
            _conexion.Open()
            comandoSql = New MySqlCommand("select * from catalogo_contable where tipo ='R'", _conexion)
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
                comandoSql = New MySqlCommand("select * from catalogo_contable where tipo ='R'", _conexion)
                resultado = comandoSql.ExecuteReader
                While resultado.Read
                    cbCcontable.Items.Add(resultado.GetString("nombre_cuenta"))

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
        cbCcontable.Items.Clear()
        cbCcontable.Text = ""
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
                    cbCcontable.Items.Add(resultado.GetString("numero_cuenta"))

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

    Private Sub tsbNombre_Click(sender As Object, e As EventArgs) Handles tsbNombre.Click
        carganombre()
        tsbnumero.Visible = True
        tsbNombre.Visible = False
    End Sub


End Class