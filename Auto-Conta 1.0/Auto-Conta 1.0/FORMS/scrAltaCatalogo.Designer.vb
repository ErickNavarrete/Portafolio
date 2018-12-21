<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrAltaCatalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrAltaCatalogo))
        Me.dgvCatalogo = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Numero_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNCuenta = New System.Windows.Forms.ToolStripButton()
        Me.btnGuarda = New System.Windows.Forms.ToolStripButton()
        Me.btnActualiza = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaCat = New System.Windows.Forms.ToolStripButton()
        Me.cbNombreSAT = New System.Windows.Forms.ComboBox()
        Me.tbNombrecuenta = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbNumerocuenta = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbCuentaSAT = New System.Windows.Forms.ComboBox()
        Me.cbNaturaleza = New System.Windows.Forms.ComboBox()
        Me.lblIdCuenta = New System.Windows.Forms.Label()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lblCuentaPadre = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvCatalogo2 = New System.Windows.Forms.DataGridView()
        Me.lblNaturaleza = New System.Windows.Forms.Label()
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvCatalogo2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvCatalogo
        '
        Me.dgvCatalogo.AllowUserToAddRows = False
        Me.dgvCatalogo.AllowUserToDeleteRows = False
        Me.dgvCatalogo.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvCatalogo.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalogo.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Numero_cuenta, Me.Nombre_cuenta, Me.Column2, Me.Column3})
        Me.dgvCatalogo.Location = New System.Drawing.Point(6, 92)
        Me.dgvCatalogo.Name = "dgvCatalogo"
        Me.dgvCatalogo.ReadOnly = True
        Me.dgvCatalogo.RowHeadersVisible = False
        Me.dgvCatalogo.Size = New System.Drawing.Size(545, 450)
        Me.dgvCatalogo.TabIndex = 13
        '
        'Column1
        '
        Me.Column1.HeaderText = "id"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Numero_cuenta
        '
        Me.Numero_cuenta.HeaderText = "NÚMERO DE CUENTA"
        Me.Numero_cuenta.Name = "Numero_cuenta"
        Me.Numero_cuenta.ReadOnly = True
        Me.Numero_cuenta.Width = 140
        '
        'Nombre_cuenta
        '
        Me.Nombre_cuenta.HeaderText = "NOMBRE DE LA CUENTA"
        Me.Nombre_cuenta.Name = "Nombre_cuenta"
        Me.Nombre_cuenta.ReadOnly = True
        Me.Nombre_cuenta.Width = 150
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUENTA SAT"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOMBRE CUENTA SAT"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNCuenta, Me.btnGuarda, Me.btnActualiza, Me.btnEditar, Me.btnElimina, Me.btnCancelaEdit, Me.btnCargaCat})
        Me.ToolStrip1.Location = New System.Drawing.Point(-2, 63)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1165, 26)
        Me.ToolStrip1.TabIndex = 5
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'btnNCuenta
        '
        Me.btnNCuenta.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNCuenta.Image = CType(resources.GetObject("btnNCuenta.Image"), System.Drawing.Image)
        Me.btnNCuenta.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNCuenta.Name = "btnNCuenta"
        Me.btnNCuenta.Size = New System.Drawing.Size(62, 23)
        Me.btnNCuenta.Text = "Nuevo"
        '
        'btnGuarda
        '
        Me.btnGuarda.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGuarda.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(69, 23)
        Me.btnGuarda.Text = "Guardar"
        Me.btnGuarda.Visible = False
        '
        'btnActualiza
        '
        Me.btnActualiza.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnActualiza.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnActualiza.Image = CType(resources.GetObject("btnActualiza.Image"), System.Drawing.Image)
        Me.btnActualiza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(111, 23)
        Me.btnActualiza.Text = "Guardar Edición"
        Me.btnActualiza.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 23)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.Visible = False
        '
        'btnElimina
        '
        Me.btnElimina.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnElimina.Image = CType(resources.GetObject("btnElimina.Image"), System.Drawing.Image)
        Me.btnElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(111, 23)
        Me.btnElimina.Text = "Eliminar Cuenta"
        Me.btnElimina.Visible = False
        '
        'btnCancelaEdit
        '
        Me.btnCancelaEdit.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCancelaEdit.Image = CType(resources.GetObject("btnCancelaEdit.Image"), System.Drawing.Image)
        Me.btnCancelaEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelaEdit.Name = "btnCancelaEdit"
        Me.btnCancelaEdit.Size = New System.Drawing.Size(115, 23)
        Me.btnCancelaEdit.Text = "Cancelar Edición"
        Me.btnCancelaEdit.Visible = False
        '
        'btnCargaCat
        '
        Me.btnCargaCat.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCargaCat.Image = CType(resources.GetObject("btnCargaCat.Image"), System.Drawing.Image)
        Me.btnCargaCat.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaCat.Name = "btnCargaCat"
        Me.btnCargaCat.Size = New System.Drawing.Size(136, 23)
        Me.btnCargaCat.Text = "Cargar Catalago SAT"
        Me.btnCargaCat.Visible = False
        '
        'cbNombreSAT
        '
        Me.cbNombreSAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNombreSAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbNombreSAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbNombreSAT.Enabled = False
        Me.cbNombreSAT.FormattingEnabled = True
        Me.cbNombreSAT.Location = New System.Drawing.Point(760, 402)
        Me.cbNombreSAT.Name = "cbNombreSAT"
        Me.cbNombreSAT.Size = New System.Drawing.Size(391, 21)
        Me.cbNombreSAT.TabIndex = 22
        '
        'tbNombrecuenta
        '
        Me.tbNombrecuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNombrecuenta.Depth = 0
        Me.tbNombrecuenta.Enabled = False
        Me.tbNombrecuenta.Hint = ""
        Me.tbNombrecuenta.Location = New System.Drawing.Point(760, 281)
        Me.tbNombrecuenta.MaxLength = 32767
        Me.tbNombrecuenta.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNombrecuenta.Name = "tbNombrecuenta"
        Me.tbNombrecuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNombrecuenta.SelectedText = ""
        Me.tbNombrecuenta.SelectionLength = 0
        Me.tbNombrecuenta.SelectionStart = 0
        Me.tbNombrecuenta.Size = New System.Drawing.Size(391, 23)
        Me.tbNombrecuenta.TabIndex = 18
        Me.tbNombrecuenta.TabStop = False
        Me.tbNombrecuenta.UseSystemPasswordChar = False
        '
        'tbNumerocuenta
        '
        Me.tbNumerocuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNumerocuenta.Depth = 0
        Me.tbNumerocuenta.Enabled = False
        Me.tbNumerocuenta.Hint = ""
        Me.tbNumerocuenta.Location = New System.Drawing.Point(760, 229)
        Me.tbNumerocuenta.MaxLength = 32767
        Me.tbNumerocuenta.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNumerocuenta.Name = "tbNumerocuenta"
        Me.tbNumerocuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNumerocuenta.SelectedText = ""
        Me.tbNumerocuenta.SelectionLength = 0
        Me.tbNumerocuenta.SelectionStart = 0
        Me.tbNumerocuenta.Size = New System.Drawing.Size(391, 23)
        Me.tbNumerocuenta.TabIndex = 16
        Me.tbNumerocuenta.TabStop = False
        Me.tbNumerocuenta.UseSystemPasswordChar = False
        '
        'cbCuentaSAT
        '
        Me.cbCuentaSAT.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbCuentaSAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCuentaSAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCuentaSAT.Enabled = False
        Me.cbCuentaSAT.FormattingEnabled = True
        Me.cbCuentaSAT.Location = New System.Drawing.Point(760, 342)
        Me.cbCuentaSAT.Name = "cbCuentaSAT"
        Me.cbCuentaSAT.Size = New System.Drawing.Size(391, 21)
        Me.cbCuentaSAT.TabIndex = 20
        '
        'cbNaturaleza
        '
        Me.cbNaturaleza.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.cbNaturaleza.Enabled = False
        Me.cbNaturaleza.FormattingEnabled = True
        Me.cbNaturaleza.Location = New System.Drawing.Point(760, 175)
        Me.cbNaturaleza.Name = "cbNaturaleza"
        Me.cbNaturaleza.Size = New System.Drawing.Size(391, 21)
        Me.cbNaturaleza.TabIndex = 14
        '
        'lblIdCuenta
        '
        Me.lblIdCuenta.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblIdCuenta.AutoSize = True
        Me.lblIdCuenta.Location = New System.Drawing.Point(944, 123)
        Me.lblIdCuenta.Name = "lblIdCuenta"
        Me.lblIdCuenta.Size = New System.Drawing.Size(10, 13)
        Me.lblIdCuenta.TabIndex = 25
        Me.lblIdCuenta.Text = "-"
        Me.lblIdCuenta.Visible = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(568, 118)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(102, 19)
        Me.MaterialLabel1.TabIndex = 27
        Me.MaterialLabel1.Text = "Cuenta Padre:"
        '
        'lblCuentaPadre
        '
        Me.lblCuentaPadre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCuentaPadre.AutoSize = True
        Me.lblCuentaPadre.Depth = 0
        Me.lblCuentaPadre.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblCuentaPadre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblCuentaPadre.Location = New System.Drawing.Point(691, 118)
        Me.lblCuentaPadre.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblCuentaPadre.Name = "lblCuentaPadre"
        Me.lblCuentaPadre.Size = New System.Drawing.Size(45, 19)
        Me.lblCuentaPadre.TabIndex = 28
        Me.lblCuentaPadre.Text = "XXXX"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(572, 169)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(85, 19)
        Me.MaterialLabel2.TabIndex = 29
        Me.MaterialLabel2.Text = "Naturaleza:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(568, 225)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(138, 19)
        Me.MaterialLabel3.TabIndex = 30
        Me.MaterialLabel3.Text = "Número de Cuenta:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(568, 282)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(154, 19)
        Me.MaterialLabel4.TabIndex = 31
        Me.MaterialLabel4.Text = "Nombre de la Cuenta:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(568, 345)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(92, 19)
        Me.MaterialLabel5.TabIndex = 32
        Me.MaterialLabel5.Text = "Cuenta SAT:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(568, 402)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(186, 19)
        Me.MaterialLabel6.TabIndex = 33
        Me.MaterialLabel6.Text = "Nombre de la Cuenta SAT:"
        '
        'dgvCatalogo2
        '
        Me.dgvCatalogo2.AllowUserToAddRows = False
        Me.dgvCatalogo2.AllowUserToDeleteRows = False
        Me.dgvCatalogo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCatalogo2.Location = New System.Drawing.Point(490, 480)
        Me.dgvCatalogo2.Name = "dgvCatalogo2"
        Me.dgvCatalogo2.ReadOnly = True
        Me.dgvCatalogo2.Size = New System.Drawing.Size(50, 49)
        Me.dgvCatalogo2.TabIndex = 34
        Me.dgvCatalogo2.Visible = False
        '
        'lblNaturaleza
        '
        Me.lblNaturaleza.AutoSize = True
        Me.lblNaturaleza.Location = New System.Drawing.Point(695, 496)
        Me.lblNaturaleza.Name = "lblNaturaleza"
        Me.lblNaturaleza.Size = New System.Drawing.Size(10, 13)
        Me.lblNaturaleza.TabIndex = 35
        Me.lblNaturaleza.Text = "-"
        Me.lblNaturaleza.Visible = False
        '
        'scrAltaCatalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1161, 551)
        Me.Controls.Add(Me.lblNaturaleza)
        Me.Controls.Add(Me.dgvCatalogo2)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.lblCuentaPadre)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.cbNombreSAT)
        Me.Controls.Add(Me.tbNombrecuenta)
        Me.Controls.Add(Me.tbNumerocuenta)
        Me.Controls.Add(Me.cbCuentaSAT)
        Me.Controls.Add(Me.cbNaturaleza)
        Me.Controls.Add(Me.lblIdCuenta)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvCatalogo)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name = "scrAltaCatalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Catalogo"
        CType(Me.dgvCatalogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvCatalogo2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvCatalogo As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGuarda As ToolStripButton
    Friend WithEvents btnActualiza As ToolStripButton
    Friend WithEvents cbNombreSAT As ComboBox
    Friend WithEvents tbNombrecuenta As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbNumerocuenta As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbCuentaSAT As ComboBox
    Friend WithEvents cbNaturaleza As ComboBox
    Friend WithEvents lblIdCuenta As Label
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lblCuentaPadre As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Numero_cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Nombre_cuenta As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnCargaCat As ToolStripButton
    Friend WithEvents dgvCatalogo2 As DataGridView
    Friend WithEvents lblNaturaleza As Label
    Friend WithEvents btnNCuenta As ToolStripButton
    Friend WithEvents btnCancelaEdit As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
End Class
