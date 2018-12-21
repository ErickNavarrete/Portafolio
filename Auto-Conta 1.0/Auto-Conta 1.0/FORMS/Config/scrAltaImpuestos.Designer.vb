<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrAltaImpuestos
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrAltaImpuestos))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbTipo = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbFactor = New System.Windows.Forms.ComboBox()
        Me.tbTasaCuota = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbImpuesto = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardaE = New System.Windows.Forms.ToolStripButton()
        Me.btnEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnNCuenta = New System.Windows.Forms.ToolStripButton()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbCargo = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbAbono = New System.Windows.Forms.ComboBox()
        Me.lbCargo = New MaterialSkin.Controls.MaterialLabel()
        Me.lbAbono = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvImpuestos = New System.Windows.Forms.DataGridView()
        Me.ID_IMPUESTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TIPO_FACTOR = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TASA_O_CUOTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IMPUESTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(593, 112)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(43, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Tipo:"
        '
        'cbTipo
        '
        Me.cbTipo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbTipo.Enabled = False
        Me.cbTipo.FormattingEnabled = True
        Me.cbTipo.Items.AddRange(New Object() {"EMITIDOS", "RECIBIDOS"})
        Me.cbTipo.Location = New System.Drawing.Point(597, 134)
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(279, 21)
        Me.cbTipo.TabIndex = 0
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(593, 163)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(56, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Factor:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(593, 219)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(103, 19)
        Me.MaterialLabel3.TabIndex = 3
        Me.MaterialLabel3.Text = "Tasa o Cuota:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(593, 276)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(76, 19)
        Me.MaterialLabel4.TabIndex = 4
        Me.MaterialLabel4.Text = "Impuesto:"
        '
        'cbFactor
        '
        Me.cbFactor.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbFactor.Enabled = False
        Me.cbFactor.FormattingEnabled = True
        Me.cbFactor.Items.AddRange(New Object() {"CUOTA", "EXENTO", "TASA"})
        Me.cbFactor.Location = New System.Drawing.Point(597, 185)
        Me.cbFactor.Name = "cbFactor"
        Me.cbFactor.Size = New System.Drawing.Size(279, 21)
        Me.cbFactor.TabIndex = 1
        '
        'tbTasaCuota
        '
        Me.tbTasaCuota.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTasaCuota.Depth = 0
        Me.tbTasaCuota.Enabled = False
        Me.tbTasaCuota.Hint = ""
        Me.tbTasaCuota.Location = New System.Drawing.Point(597, 241)
        Me.tbTasaCuota.MaxLength = 32767
        Me.tbTasaCuota.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbTasaCuota.Name = "tbTasaCuota"
        Me.tbTasaCuota.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTasaCuota.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTasaCuota.SelectedText = ""
        Me.tbTasaCuota.SelectionLength = 0
        Me.tbTasaCuota.SelectionStart = 0
        Me.tbTasaCuota.Size = New System.Drawing.Size(279, 23)
        Me.tbTasaCuota.TabIndex = 2
        Me.tbTasaCuota.TabStop = False
        Me.tbTasaCuota.UseSystemPasswordChar = False
        '
        'cbImpuesto
        '
        Me.cbImpuesto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbImpuesto.Enabled = False
        Me.cbImpuesto.FormattingEnabled = True
        Me.cbImpuesto.Items.AddRange(New Object() {"IVA", "IEPS", "IVA_RET", "ISR"})
        Me.cbImpuesto.Location = New System.Drawing.Point(597, 298)
        Me.cbImpuesto.Name = "cbImpuesto"
        Me.cbImpuesto.Size = New System.Drawing.Size(279, 21)
        Me.cbImpuesto.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnGuardar, Me.btnGuardaE, Me.btnNCuenta, Me.btnEdit, Me.btnElimina, Me.btnCancelEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(2, 64)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(915, 25)
        Me.ToolStrip1.TabIndex = 6
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Visible = False
        '
        'btnGuardaE
        '
        Me.btnGuardaE.Image = CType(resources.GetObject("btnGuardaE.Image"), System.Drawing.Image)
        Me.btnGuardaE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardaE.Name = "btnGuardaE"
        Me.btnGuardaE.Size = New System.Drawing.Size(111, 22)
        Me.btnGuardaE.Text = "Guardar Edición"
        Me.btnGuardaE.Visible = False
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
        'btnCancelEdit
        '
        Me.btnCancelEdit.Image = CType(resources.GetObject("btnCancelEdit.Image"), System.Drawing.Image)
        Me.btnCancelEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelEdit.Name = "btnCancelEdit"
        Me.btnCancelEdit.Size = New System.Drawing.Size(115, 22)
        Me.btnCancelEdit.Text = "Cancelar Edición"
        Me.btnCancelEdit.Visible = False
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
        'btnNCuenta
        '
        Me.btnNCuenta.Image = CType(resources.GetObject("btnNCuenta.Image"), System.Drawing.Image)
        Me.btnNCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNCuenta.Name = "btnNCuenta"
        Me.btnNCuenta.Size = New System.Drawing.Size(103, 22)
        Me.btnNCuenta.Text = "Añadir Cuenta"
        Me.btnNCuenta.Visible = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(593, 336)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(168, 19)
        Me.MaterialLabel5.TabIndex = 12
        Me.MaterialLabel5.Text = "Cuenta Contable Cargo:"
        '
        'cbCargo
        '
        Me.cbCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCargo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCargo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCargo.Enabled = False
        Me.cbCargo.FormattingEnabled = True
        Me.cbCargo.Location = New System.Drawing.Point(597, 366)
        Me.cbCargo.Name = "cbCargo"
        Me.cbCargo.Size = New System.Drawing.Size(279, 21)
        Me.cbCargo.TabIndex = 4
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(593, 432)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(172, 19)
        Me.MaterialLabel6.TabIndex = 14
        Me.MaterialLabel6.Text = "Cuenta Contable Abono:"
        '
        'cbAbono
        '
        Me.cbAbono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbAbono.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbAbono.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbAbono.Enabled = False
        Me.cbAbono.FormattingEnabled = True
        Me.cbAbono.Location = New System.Drawing.Point(597, 463)
        Me.cbAbono.Name = "cbAbono"
        Me.cbAbono.Size = New System.Drawing.Size(279, 21)
        Me.cbAbono.TabIndex = 5
        '
        'lbCargo
        '
        Me.lbCargo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbCargo.AutoSize = True
        Me.lbCargo.Depth = 0
        Me.lbCargo.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbCargo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbCargo.Location = New System.Drawing.Point(593, 398)
        Me.lbCargo.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbCargo.Name = "lbCargo"
        Me.lbCargo.Size = New System.Drawing.Size(21, 19)
        Me.lbCargo.TabIndex = 16
        Me.lbCargo.Text = "---"
        '
        'lbAbono
        '
        Me.lbAbono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbAbono.AutoSize = True
        Me.lbAbono.Depth = 0
        Me.lbAbono.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lbAbono.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lbAbono.Location = New System.Drawing.Point(593, 496)
        Me.lbAbono.MouseState = MaterialSkin.MouseState.HOVER
        Me.lbAbono.Name = "lbAbono"
        Me.lbAbono.Size = New System.Drawing.Size(21, 19)
        Me.lbAbono.TabIndex = 17
        Me.lbAbono.Text = "---"
        '
        'dgvImpuestos
        '
        Me.dgvImpuestos.AllowUserToAddRows = False
        Me.dgvImpuestos.AllowUserToDeleteRows = False
        Me.dgvImpuestos.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvImpuestos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImpuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID_IMPUESTO, Me.Column5, Me.TIPO_FACTOR, Me.TASA_O_CUOTA, Me.IMPUESTO, Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvImpuestos.Location = New System.Drawing.Point(12, 112)
        Me.dgvImpuestos.Name = "dgvImpuestos"
        Me.dgvImpuestos.ReadOnly = True
        Me.dgvImpuestos.Size = New System.Drawing.Size(562, 437)
        Me.dgvImpuestos.TabIndex = 18
        '
        'ID_IMPUESTO
        '
        Me.ID_IMPUESTO.HeaderText = "ID_IMPUESTO"
        Me.ID_IMPUESTO.Name = "ID_IMPUESTO"
        Me.ID_IMPUESTO.ReadOnly = True
        Me.ID_IMPUESTO.Visible = False
        '
        'Column5
        '
        Me.Column5.HeaderText = "TIPO"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'TIPO_FACTOR
        '
        Me.TIPO_FACTOR.HeaderText = "TIPO FACTOR"
        Me.TIPO_FACTOR.Name = "TIPO_FACTOR"
        Me.TIPO_FACTOR.ReadOnly = True
        Me.TIPO_FACTOR.Width = 120
        '
        'TASA_O_CUOTA
        '
        Me.TASA_O_CUOTA.HeaderText = "TASA O CUOTA"
        Me.TASA_O_CUOTA.Name = "TASA_O_CUOTA"
        Me.TASA_O_CUOTA.ReadOnly = True
        Me.TASA_O_CUOTA.Width = 120
        '
        'IMPUESTO
        '
        Me.IMPUESTO.HeaderText = "IMPUESTO"
        Me.IMPUESTO.Name = "IMPUESTO"
        Me.IMPUESTO.ReadOnly = True
        '
        'Column1
        '
        Me.Column1.HeaderText = "CUENTA CARGO"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 120
        '
        'Column2
        '
        Me.Column2.HeaderText = "NOMBRE CUENTA CARGO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "CUENTA ABONO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "NOMBRE CUENTA ABONO"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 200
        '
        'scrAltaImpuestos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(915, 561)
        Me.Controls.Add(Me.dgvImpuestos)
        Me.Controls.Add(Me.lbAbono)
        Me.Controls.Add(Me.lbCargo)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.cbTipo)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.cbAbono)
        Me.Controls.Add(Me.cbFactor)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.cbCargo)
        Me.Controls.Add(Me.tbTasaCuota)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cbImpuesto)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Name = "scrAltaImpuestos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Impuestos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbTipo As ComboBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbFactor As ComboBox
    Friend WithEvents tbTasaCuota As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbImpuesto As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbCargo As ComboBox
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbAbono As ComboBox
    Friend WithEvents lbCargo As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lbAbono As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvImpuestos As DataGridView
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnEdit As ToolStripButton
    Friend WithEvents btnCancelEdit As ToolStripButton
    Friend WithEvents ID_IMPUESTO As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents TIPO_FACTOR As DataGridViewTextBoxColumn
    Friend WithEvents TASA_O_CUOTA As DataGridViewTextBoxColumn
    Friend WithEvents IMPUESTO As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardaE As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnNCuenta As ToolStripButton
End Class
