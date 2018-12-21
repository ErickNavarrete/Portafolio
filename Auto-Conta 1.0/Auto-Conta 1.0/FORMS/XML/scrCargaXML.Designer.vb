<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrCargaXML
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrCargaXML))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCargaXML = New System.Windows.Forms.ToolStripButton()
        Me.dgvXML = New System.Windows.Forms.DataGridView()
        Me.dgvConceptos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvImpuestos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRutas = New System.Windows.Forms.DataGridView()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvRFC = New System.Windows.Forms.DataGridView()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialContextMenuStrip1 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvXML_2 = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvImpSC = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialContextMenuStrip2 = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvSXML = New System.Windows.Forms.DataGridView()
        Me.Column22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvXML, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRutas, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvRFC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialContextMenuStrip1.SuspendLayout()
        CType(Me.dgvXML_2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvImpSC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MaterialContextMenuStrip2.SuspendLayout()
        CType(Me.dgvSXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargaXML})
        Me.ToolStrip1.Location = New System.Drawing.Point(-1, 66)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1205, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCargaXML
        '
        Me.btnCargaXML.Image = CType(resources.GetObject("btnCargaXML.Image"), System.Drawing.Image)
        Me.btnCargaXML.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaXML.Name = "btnCargaXML"
        Me.btnCargaXML.Size = New System.Drawing.Size(89, 22)
        Me.btnCargaXML.Text = "Cargar XML"
        '
        'dgvXML
        '
        Me.dgvXML.AllowUserToAddRows = False
        Me.dgvXML.AllowUserToDeleteRows = False
        Me.dgvXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvXML.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXML.Location = New System.Drawing.Point(1023, 423)
        Me.dgvXML.Name = "dgvXML"
        Me.dgvXML.ReadOnly = True
        Me.dgvXML.Size = New System.Drawing.Size(167, 116)
        Me.dgvXML.TabIndex = 2
        Me.dgvXML.Visible = False
        '
        'dgvConceptos
        '
        Me.dgvConceptos.AllowUserToAddRows = False
        Me.dgvConceptos.AllowUserToDeleteRows = False
        Me.dgvConceptos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvConceptos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvConceptos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvConceptos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvConceptos.Location = New System.Drawing.Point(1023, 423)
        Me.dgvConceptos.Name = "dgvConceptos"
        Me.dgvConceptos.ReadOnly = True
        Me.dgvConceptos.Size = New System.Drawing.Size(167, 116)
        Me.dgvConceptos.TabIndex = 6
        Me.dgvConceptos.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "CONT"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'dgvImpuestos
        '
        Me.dgvImpuestos.AllowUserToAddRows = False
        Me.dgvImpuestos.AllowUserToDeleteRows = False
        Me.dgvImpuestos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvImpuestos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvImpuestos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImpuestos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1})
        Me.dgvImpuestos.Location = New System.Drawing.Point(1068, 423)
        Me.dgvImpuestos.Name = "dgvImpuestos"
        Me.dgvImpuestos.ReadOnly = True
        Me.dgvImpuestos.Size = New System.Drawing.Size(122, 115)
        Me.dgvImpuestos.TabIndex = 7
        Me.dgvImpuestos.Visible = False
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "CONT"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvPagos.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2})
        Me.dgvPagos.Location = New System.Drawing.Point(1023, 423)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.Size = New System.Drawing.Size(167, 116)
        Me.dgvPagos.TabIndex = 8
        Me.dgvPagos.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "CONT"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'dgvRutas
        '
        Me.dgvRutas.AllowUserToAddRows = False
        Me.dgvRutas.AllowUserToDeleteRows = False
        Me.dgvRutas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRutas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column2})
        Me.dgvRutas.Location = New System.Drawing.Point(1023, 423)
        Me.dgvRutas.Name = "dgvRutas"
        Me.dgvRutas.ReadOnly = True
        Me.dgvRutas.Size = New System.Drawing.Size(167, 116)
        Me.dgvRutas.TabIndex = 9
        Me.dgvRutas.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "RUTA"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'dgvRFC
        '
        Me.dgvRFC.AllowUserToAddRows = False
        Me.dgvRFC.AllowUserToDeleteRows = False
        Me.dgvRFC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvRFC.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvRFC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvRFC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column3, Me.Column4, Me.Column19})
        Me.dgvRFC.ContextMenuStrip = Me.MaterialContextMenuStrip1
        Me.dgvRFC.Location = New System.Drawing.Point(12, 389)
        Me.dgvRFC.Name = "dgvRFC"
        Me.dgvRFC.ReadOnly = True
        Me.dgvRFC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvRFC.Size = New System.Drawing.Size(377, 150)
        Me.dgvRFC.TabIndex = 10
        '
        'Column3
        '
        Me.Column3.HeaderText = "NOMBRE"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "RFC"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 170
        '
        'Column19
        '
        Me.Column19.HeaderText = "TIPO"
        Me.Column19.Name = "Column19"
        Me.Column19.ReadOnly = True
        '
        'MaterialContextMenuStrip1
        '
        Me.MaterialContextMenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip1.Depth = 0
        Me.MaterialContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AÑADIRCONFIGURACIÓNToolStripMenuItem})
        Me.MaterialContextMenuStrip1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip1.Name = "MaterialContextMenuStrip1"
        Me.MaterialContextMenuStrip1.Size = New System.Drawing.Size(216, 26)
        '
        'AÑADIRCONFIGURACIÓNToolStripMenuItem
        '
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem.Name = "AÑADIRCONFIGURACIÓNToolStripMenuItem"
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem.Size = New System.Drawing.Size(215, 22)
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem.Text = "AÑADIR CONFIGURACIÓN"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 367)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(139, 19)
        Me.MaterialLabel1.TabIndex = 11
        Me.MaterialLabel1.Text = "RFC Sin Configurar."
        '
        'dgvXML_2
        '
        Me.dgvXML_2.AllowUserToAddRows = False
        Me.dgvXML_2.AllowUserToDeleteRows = False
        Me.dgvXML_2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvXML_2.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvXML_2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXML_2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column8, Me.Column6, Me.Column7, Me.Column13, Me.Column15, Me.Column14, Me.Column17, Me.Column16, Me.Column9, Me.Column10, Me.Column11, Me.Column12})
        Me.dgvXML_2.Location = New System.Drawing.Point(16, 99)
        Me.dgvXML_2.Name = "dgvXML_2"
        Me.dgvXML_2.ReadOnly = True
        Me.dgvXML_2.Size = New System.Drawing.Size(1174, 258)
        Me.dgvXML_2.TabIndex = 12
        '
        'Column5
        '
        Me.Column5.HeaderText = "ID_XML"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column8
        '
        Me.Column8.HeaderText = "VERSION"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        Me.Column8.Width = 80
        '
        'Column6
        '
        Me.Column6.HeaderText = "SERIE"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 50
        '
        'Column7
        '
        Me.Column7.HeaderText = "FOLIO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        Me.Column7.Width = 50
        '
        'Column13
        '
        Me.Column13.HeaderText = "FECHA"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        Me.Column13.Width = 120
        '
        'Column15
        '
        Me.Column15.HeaderText = "NOMBRE RECEPTOR"
        Me.Column15.Name = "Column15"
        Me.Column15.ReadOnly = True
        Me.Column15.Width = 200
        '
        'Column14
        '
        Me.Column14.HeaderText = "RFC RECEPTOR"
        Me.Column14.Name = "Column14"
        Me.Column14.ReadOnly = True
        Me.Column14.Width = 200
        '
        'Column17
        '
        Me.Column17.HeaderText = "NOMBRE EMISOR"
        Me.Column17.Name = "Column17"
        Me.Column17.ReadOnly = True
        Me.Column17.Width = 200
        '
        'Column16
        '
        Me.Column16.HeaderText = "RFC EMISOR"
        Me.Column16.Name = "Column16"
        Me.Column16.ReadOnly = True
        Me.Column16.Width = 200
        '
        'Column9
        '
        Me.Column9.HeaderText = "TIPO"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Width = 50
        '
        'Column10
        '
        Me.Column10.HeaderText = "UUID"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 200
        '
        'Column11
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column11.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column11.HeaderText = "SUBTOTAL"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Width = 150
        '
        'Column12
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column12.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column12.HeaderText = "TOTAL"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(395, 367)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(183, 19)
        Me.MaterialLabel2.TabIndex = 13
        Me.MaterialLabel2.Text = "Impuestos Sin Configurar."
        '
        'dgvImpSC
        '
        Me.dgvImpSC.AllowUserToAddRows = False
        Me.dgvImpSC.AllowUserToDeleteRows = False
        Me.dgvImpSC.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvImpSC.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvImpSC.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvImpSC.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.Column18, Me.Column20})
        Me.dgvImpSC.ContextMenuStrip = Me.MaterialContextMenuStrip2
        Me.dgvImpSC.Location = New System.Drawing.Point(395, 389)
        Me.dgvImpSC.Name = "dgvImpSC"
        Me.dgvImpSC.ReadOnly = True
        Me.dgvImpSC.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvImpSC.Size = New System.Drawing.Size(377, 150)
        Me.dgvImpSC.TabIndex = 14
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "TIPO FACTOR"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 200
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.HeaderText = "TASA O CUOTA"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        Me.DataGridViewTextBoxColumn4.Width = 170
        '
        'Column18
        '
        Me.Column18.HeaderText = "IMPUESTO"
        Me.Column18.Name = "Column18"
        Me.Column18.ReadOnly = True
        '
        'Column20
        '
        Me.Column20.HeaderText = "TIPO"
        Me.Column20.Name = "Column20"
        Me.Column20.ReadOnly = True
        '
        'MaterialContextMenuStrip2
        '
        Me.MaterialContextMenuStrip2.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MaterialContextMenuStrip2.Depth = 0
        Me.MaterialContextMenuStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AÑADIRCONFIGURACIÓNToolStripMenuItem1})
        Me.MaterialContextMenuStrip2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialContextMenuStrip2.Name = "MaterialContextMenuStrip2"
        Me.MaterialContextMenuStrip2.Size = New System.Drawing.Size(216, 26)
        '
        'AÑADIRCONFIGURACIÓNToolStripMenuItem1
        '
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem1.Name = "AÑADIRCONFIGURACIÓNToolStripMenuItem1"
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem1.Size = New System.Drawing.Size(215, 22)
        Me.AÑADIRCONFIGURACIÓNToolStripMenuItem1.Text = "AÑADIR CONFIGURACIÓN"
        '
        'dgvSXML
        '
        Me.dgvSXML.AllowUserToAddRows = False
        Me.dgvSXML.AllowUserToDeleteRows = False
        Me.dgvSXML.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvSXML.BackgroundColor = System.Drawing.SystemColors.ButtonFace
        Me.dgvSXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSXML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column22})
        Me.dgvSXML.ContextMenuStrip = Me.MaterialContextMenuStrip2
        Me.dgvSXML.Location = New System.Drawing.Point(789, 389)
        Me.dgvSXML.Name = "dgvSXML"
        Me.dgvSXML.ReadOnly = True
        Me.dgvSXML.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvSXML.Size = New System.Drawing.Size(377, 150)
        Me.dgvSXML.TabIndex = 15
        '
        'Column22
        '
        Me.Column22.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column22.HeaderText = "UUID"
        Me.Column22.Name = "Column22"
        Me.Column22.ReadOnly = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(785, 367)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(124, 19)
        Me.MaterialLabel3.TabIndex = 16
        Me.MaterialLabel3.Text = "XML Sin Agregar:"
        '
        'scrCargaXML
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 551)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.dgvSXML)
        Me.Controls.Add(Me.dgvImpSC)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.dgvRFC)
        Me.Controls.Add(Me.dgvPagos)
        Me.Controls.Add(Me.dgvImpuestos)
        Me.Controls.Add(Me.dgvConceptos)
        Me.Controls.Add(Me.dgvXML)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvXML_2)
        Me.Controls.Add(Me.dgvRutas)
        Me.Name = "scrCargaXML"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Subir XML"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvXML, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImpuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRutas, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvRFC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialContextMenuStrip1.ResumeLayout(False)
        CType(Me.dgvXML_2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvImpSC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MaterialContextMenuStrip2.ResumeLayout(False)
        CType(Me.dgvSXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnCargaXML As ToolStripButton
    Friend WithEvents dgvXML As DataGridView
    Friend WithEvents dgvConceptos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvImpuestos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents dgvPagos As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvRutas As DataGridView
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents dgvRFC As DataGridView
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvXML_2 As DataGridView
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvImpSC As DataGridView
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents Column18 As DataGridViewTextBoxColumn
    Friend WithEvents Column20 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialContextMenuStrip1 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents AÑADIRCONFIGURACIÓNToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialContextMenuStrip2 As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents AÑADIRCONFIGURACIÓNToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents dgvSXML As DataGridView
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Column22 As DataGridViewTextBoxColumn
End Class
