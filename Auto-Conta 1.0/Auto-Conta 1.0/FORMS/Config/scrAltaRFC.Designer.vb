<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrAltaRFC
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrAltaRFC))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbRFC = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbAbono = New System.Windows.Forms.ComboBox()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardarEdi = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelEdit = New System.Windows.Forms.ToolStripButton()
        Me.tsbnumero = New System.Windows.Forms.ToolStripButton()
        Me.tsbNombre = New System.Windows.Forms.ToolStripButton()
        Me.btnAddCuenta = New System.Windows.Forms.ToolStripButton()
        Me.dgvRegistrados = New System.Windows.Forms.DataGridView()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblTIpoc = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.cbCuentas = New System.Windows.Forms.ComboBox()
        Me.lbCuentaCargo = New System.Windows.Forms.Label()
        Me.lbCuentaAbono = New System.Windows.Forms.Label()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvRegistrados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(736, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipo.Enabled = False
        Me.cbTipo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"Emitidos", "Recibidos"})
        Me.cbTipo.Location = New System.Drawing.Point(796, 107)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(164, 28)
        Me.cbTipo.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(740, 211)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "RFC"
        '
        'tbRFC
        '
        Me.tbRFC.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbRFC.Enabled = False
        Me.tbRFC.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbRFC.Location = New System.Drawing.Point(796, 206)
        Me.tbRFC.Name = "tbRFC"
        Me.tbRFC.Size = New System.Drawing.Size(340, 27)
        Me.tbRFC.TabIndex = 2
        '
        'tbNombre
        '
        Me.tbNombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNombre.Enabled = False
        Me.tbNombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNombre.Location = New System.Drawing.Point(796, 167)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.Size = New System.Drawing.Size(340, 27)
        Me.tbNombre.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(714, 172)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 22)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Nombre"
        '
        'cbAbono
        '
        Me.cbAbono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAbono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbAbono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAbono.Enabled = False
        Me.cbAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbAbono.FormattingEnabled = True
        Me.cbAbono.Location = New System.Drawing.Point(796, 340)
        Me.cbAbono.Name = "cbAbono"
        Me.cbAbono.Size = New System.Drawing.Size(337, 28)
        Me.cbAbono.TabIndex = 5
        '
        'cbCargo
        '
        Me.cbCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCargo.Enabled = False
        Me.cbCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(796, 256)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(340, 28)
        Me.cbCargo.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(592, 262)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(195, 22)
        Me.Label4.TabIndex = 27
        Me.Label4.Text = "Cuenta contable Cargo"
        '
        'Label5
        '
        Me.Label5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(592, 346)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(198, 22)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Cuenta contable Abono"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEdit, Me.btnElimina, Me.tsbGuardar, Me.btnGuardarEdi, Me.btnCancelEdit, Me.tsbnumero, Me.tsbNombre, Me.btnAddCuenta})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 63)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1155, 25)
        Me.ToolStrip2.TabIndex = 8
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnEdit
        '
        Me.btnEdit.Image = CType(resources.GetObject("btnEdit.Image"), System.Drawing.Image)
        Me.btnEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(57, 22)
        Me.btnEdit.Text = "Editar"
        Me.btnEdit.Visible = False
        '
        'btnElimina
        '
        Me.btnElimina.Image = CType(resources.GetObject("btnElimina.Image"), System.Drawing.Image)
        Me.btnElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(70, 22)
        Me.btnElimina.Text = "Eliminar"
        Me.btnElimina.Visible = False
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuardar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        Me.tsbGuardar.Visible = False
        '
        'btnGuardarEdi
        '
        Me.btnGuardarEdi.Image = CType(resources.GetObject("btnGuardarEdi.Image"), System.Drawing.Image)
        Me.btnGuardarEdi.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardarEdi.Name = "btnGuardarEdi"
        Me.btnGuardarEdi.Size = New System.Drawing.Size(111, 22)
        Me.btnGuardarEdi.Text = "Guardar Edición"
        Me.btnGuardarEdi.Visible = False
        '
        'btnCancelEdit
        '
        Me.btnCancelEdit.Image = CType(resources.GetObject("btnCancelEdit.Image"), System.Drawing.Image)
        Me.btnCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(115, 22)
        Me.btnCancelEdit.Text = "Cancelar Edición"
        Me.btnCancelEdit.Visible = False
        '
        'tsbnumero
        '
        Me.tsbnumero.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbnumero.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbnumero.Image = CType(resources.GetObject("tsbnumero.Image"), System.Drawing.Image)
        Me.tsbnumero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbnumero.Name = "tsbnumero"
        Me.tsbnumero.Size = New System.Drawing.Size(128, 22)
        Me.tsbnumero.Text = "Buscar por número"
        Me.tsbnumero.Visible = False
        '
        'tsbNombre
        '
        Me.tsbNombre.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNombre.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbNombre.Image = CType(resources.GetObject("tsbNombre.Image"), System.Drawing.Image)
        Me.tsbNombre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNombre.Name = "tsbNombre"
        Me.tsbNombre.Size = New System.Drawing.Size(128, 22)
        Me.tsbNombre.Text = "Buscar por nombre"
        Me.tsbNombre.Visible = False
        '
        'btnAddCuenta
        '
        Me.btnAddCuenta.Image = CType(resources.GetObject("btnAddCuenta.Image"), System.Drawing.Image)
        Me.btnAddCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAddCuenta.Name = "btnAddCuenta"
        Me.btnAddCuenta.Size = New System.Drawing.Size(103, 22)
        Me.btnAddCuenta.Text = "Añadir Cuenta"
        Me.btnAddCuenta.Visible = False
        '
        'dgvRegistrados
        '
        Me.dgvRegistrados.AllowUserToAddRows = False
        Me.dgvRegistrados.AllowUserToDeleteRows = False
        Me.dgvRegistrados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvRegistrados.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvRegistrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRegistrados.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column6, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column7, Me.Column5, Me.Column8})
        Me.dgvRegistrados.Location = New System.Drawing.Point(12, 103)
        Me.dgvRegistrados.Name = "dgvRegistrados"
        Me.dgvRegistrados.ReadOnly = True
        Me.dgvRegistrados.Size = New System.Drawing.Size(574, 528)
        Me.dgvRegistrados.TabIndex = 138
        '
        'Column6
        '
        Me.Column6.HeaderText = "id"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "NOMBRE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "RFC"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "TIPO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.HeaderText = "CUENTA CARGO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 250
        '
        'Column7
        '
        Me.Column7.HeaderText = "NOMBRE CUENTA CARGO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 300
        '
        'Column5
        '
        Me.Column5.HeaderText = "CUENTA ABONO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 250
        '
        'Column8
        '
        Me.Column8.HeaderText = "NOMBRE CUENTA ABONO"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 300
        '
        'lblTIpoc
        '
        Me.lblTIpoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblTIpoc.AutoSize = True
        Me.lblTIpoc.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTIpoc.Location = New System.Drawing.Point(1038, 104)
        Me.lblTIpoc.Name = "lblTIpoc"
        Me.lblTIpoc.Size = New System.Drawing.Size(70, 22)
        Me.lblTIpoc.TabIndex = 140
        Me.lblTIpoc.Text = "numero"
        Me.lblTIpoc.Visible = False
        '
        'Label7
        '
        Me.Label7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(643, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(144, 22)
        Me.Label7.TabIndex = 142
        Me.Label7.Text = "Cuenta Bancaria"
        '
        'cbCuentas
        '
        Me.cbCuentas.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCuentas.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.cbCuentas.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCuentas.Enabled = False
        Me.cbCuentas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCuentas.FormattingEnabled = True
        Me.cbCuentas.Location = New System.Drawing.Point(796, 434)
        Me.cbCuentas.Name = "cbCuentas"
        Me.cbCuentas.Size = New System.Drawing.Size(337, 28)
        Me.cbCuentas.TabIndex = 7
        '
        'lbCuentaCargo
        '
        Me.lbCuentaCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCuentaCargo.AutoSize = True
        Me.lbCuentaCargo.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCuentaCargo.Location = New System.Drawing.Point(792, 299)
        Me.lbCuentaCargo.Name = "lbCuentaCargo"
        Me.lbCuentaCargo.Size = New System.Drawing.Size(20, 16)
        Me.lbCuentaCargo.TabIndex = 4
        Me.lbCuentaCargo.Text = "---"
        '
        'lbCuentaAbono
        '
        Me.lbCuentaAbono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCuentaAbono.AutoSize = True
        Me.lbCuentaAbono.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbCuentaAbono.Location = New System.Drawing.Point(792, 389)
        Me.lbCuentaAbono.Name = "lbCuentaAbono"
        Me.lbCuentaAbono.Size = New System.Drawing.Size(20, 16)
        Me.lbCuentaAbono.TabIndex = 6
        Me.lbCuentaAbono.Text = "---"
        '
        'scrAltaRFC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1154, 643)
        Me.Controls.Add(Me.lbCuentaAbono)
        Me.Controls.Add(Me.lbCuentaCargo)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cbCuentas)
        Me.Controls.Add(Me.lblTIpoc)
        Me.Controls.Add(Me.dgvRegistrados)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.cbAbono)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbNombre)
        Me.Controls.Add(Me.tbRFC)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.Label1)
        Me.Name = "scrAltaRFC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta RFC"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvRegistrados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbRFC As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents cbAbono As ComboBox
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbnumero As ToolStripButton
    Friend WithEvents dgvRegistrados As DataGridView
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tsbNombre As ToolStripButton
    Friend WithEvents lblTIpoc As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents cbCuentas As ComboBox
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents lbCuentaCargo As Label
    Friend WithEvents lbCuentaAbono As Label
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnGuardarEdi As ToolStripButton
    Friend WithEvents btnCancelEdit As ToolStripButton
    Friend WithEvents btnAddCuenta As ToolStripButton
End Class
