<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrMenuOT
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrMenuOT))
        Me.dgvMenuOT = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsOpciones = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.PROCESOSToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbTipoB = New System.Windows.Forms.ToolStripComboBox()
        Me.tbOpc = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.btnUsuarios = New System.Windows.Forms.ToolStripButton()
        Me.btnCredenciales = New System.Windows.Forms.ToolStripButton()
        Me.dtpFI = New System.Windows.Forms.DateTimePicker()
        Me.dtpFF = New System.Windows.Forms.DateTimePicker()
        Me.NIp = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.pbCodigo = New System.Windows.Forms.PictureBox()
        Me.pbCodigo2 = New System.Windows.Forms.PictureBox()
        Me.pbCodigo3 = New System.Windows.Forms.PictureBox()
        Me.btnGeneraReporte = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvMenuOT, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOpciones.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCodigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbCodigo3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvMenuOT
        '
        Me.dgvMenuOT.AllowUserToAddRows = False
        Me.dgvMenuOT.AllowUserToDeleteRows = False
        Me.dgvMenuOT.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvMenuOT.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMenuOT.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column6, Me.Column2, Me.Column3, Me.Column4, Me.Column5})
        Me.dgvMenuOT.Location = New System.Drawing.Point(12, 90)
        Me.dgvMenuOT.Name = "dgvMenuOT"
        Me.dgvMenuOT.ReadOnly = True
        Me.dgvMenuOT.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvMenuOT.Size = New System.Drawing.Size(1270, 406)
        Me.dgvMenuOT.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_ot"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column6
        '
        Me.Column6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column6.HeaderText = "Cliente"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "Proyecto"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Fecha Elaboración"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Serie"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Folio"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'cmsOpciones
        '
        Me.cmsOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsOpciones.Depth = 0
        Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PROCESOSToolStripMenuItem})
        Me.cmsOpciones.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmsOpciones.Name = "cmsOpciones"
        Me.cmsOpciones.Size = New System.Drawing.Size(133, 26)
        '
        'PROCESOSToolStripMenuItem
        '
        Me.PROCESOSToolStripMenuItem.Name = "PROCESOSToolStripMenuItem"
        Me.PROCESOSToolStripMenuItem.Size = New System.Drawing.Size(132, 22)
        Me.PROCESOSToolStripMenuItem.Text = "PROCESOS"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.ToolStripLabel1, Me.cbTipoB, Me.tbOpc, Me.ToolStripButton2, Me.ToolStripButton3, Me.btnUsuarios, Me.btnCredenciales, Me.btnGeneraReporte})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 62)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1294, 25)
        Me.ToolStrip1.TabIndex = 1
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(95, 22)
        Me.ToolStripButton1.Text = "Nueva orden"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(141, 22)
        Me.ToolStripLabel1.Text = "            Tipo de Búsqueda:"
        '
        'cbTipoB
        '
        Me.cbTipoB.Items.AddRange(New Object() {"Todos", "Cliente", "Proyecto"})
        Me.cbTipoB.Name = "cbTipoB"
        Me.cbTipoB.Size = New System.Drawing.Size(140, 25)
        '
        'tbOpc
        '
        Me.tbOpc.Name = "tbOpc"
        Me.tbOpc.Size = New System.Drawing.Size(150, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.Image = CType(resources.GetObject("ToolStripButton2.Image"), System.Drawing.Image)
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(62, 22)
        Me.ToolStripButton2.Text = "Buscar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripButton3.Image = CType(resources.GetObject("ToolStripButton3.Image"), System.Drawing.Image)
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripButton3.Text = "Tablero"
        '
        'btnUsuarios
        '
        Me.btnUsuarios.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnUsuarios.Image = CType(resources.GetObject("btnUsuarios.Image"), System.Drawing.Image)
        Me.btnUsuarios.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUsuarios.Name = "btnUsuarios"
        Me.btnUsuarios.Size = New System.Drawing.Size(72, 22)
        Me.btnUsuarios.Text = "Usuarios"
        '
        'btnCredenciales
        '
        Me.btnCredenciales.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnCredenciales.Image = CType(resources.GetObject("btnCredenciales.Image"), System.Drawing.Image)
        Me.btnCredenciales.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCredenciales.Name = "btnCredenciales"
        Me.btnCredenciales.Size = New System.Drawing.Size(94, 22)
        Me.btnCredenciales.Text = "Credenciales"
        '
        'dtpFI
        '
        Me.dtpFI.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFI.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFI.Location = New System.Drawing.Point(611, 64)
        Me.dtpFI.Name = "dtpFI"
        Me.dtpFI.Size = New System.Drawing.Size(159, 20)
        Me.dtpFI.TabIndex = 2
        '
        'dtpFF
        '
        Me.dtpFF.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFF.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFF.Location = New System.Drawing.Point(779, 64)
        Me.dtpFF.Name = "dtpFF"
        Me.dtpFF.Size = New System.Drawing.Size(159, 20)
        Me.dtpFF.TabIndex = 3
        '
        'NIp
        '
        Me.NIp.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info
        Me.NIp.BalloonTipText = "Minimizado"
        Me.NIp.ContextMenuStrip = Me.cmsOpciones
        Me.NIp.Icon = CType(resources.GetObject("NIp.Icon"), System.Drawing.Icon)
        Me.NIp.Text = "NotifyIcon1"
        '
        'pbCodigo
        '
        Me.pbCodigo.Location = New System.Drawing.Point(42, 145)
        Me.pbCodigo.Name = "pbCodigo"
        Me.pbCodigo.Size = New System.Drawing.Size(306, 129)
        Me.pbCodigo.TabIndex = 44
        Me.pbCodigo.TabStop = False
        Me.pbCodigo.Visible = False
        '
        'pbCodigo2
        '
        Me.pbCodigo2.Location = New System.Drawing.Point(377, 145)
        Me.pbCodigo2.Name = "pbCodigo2"
        Me.pbCodigo2.Size = New System.Drawing.Size(306, 129)
        Me.pbCodigo2.TabIndex = 45
        Me.pbCodigo2.TabStop = False
        Me.pbCodigo2.Visible = False
        '
        'pbCodigo3
        '
        Me.pbCodigo3.Location = New System.Drawing.Point(709, 145)
        Me.pbCodigo3.Name = "pbCodigo3"
        Me.pbCodigo3.Size = New System.Drawing.Size(306, 129)
        Me.pbCodigo3.TabIndex = 46
        Me.pbCodigo3.TabStop = False
        Me.pbCodigo3.Visible = False
        '
        'btnGeneraReporte
        '
        Me.btnGeneraReporte.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.btnGeneraReporte.Image = CType(resources.GetObject("btnGeneraReporte.Image"), System.Drawing.Image)
        Me.btnGeneraReporte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGeneraReporte.Name = "btnGeneraReporte"
        Me.btnGeneraReporte.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btnGeneraReporte.Size = New System.Drawing.Size(112, 22)
        Me.btnGeneraReporte.Text = "Generar Reporte"
        '
        'scrMenuOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1294, 508)
        Me.Controls.Add(Me.pbCodigo3)
        Me.Controls.Add(Me.pbCodigo2)
        Me.Controls.Add(Me.pbCodigo)
        Me.Controls.Add(Me.dtpFF)
        Me.Controls.Add(Me.dtpFI)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvMenuOT)
        Me.Name = "scrMenuOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menú Orden de Trabajo"
        CType(Me.dgvMenuOT, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOpciones.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCodigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbCodigo3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvMenuOT As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbTipoB As ToolStripComboBox
    Friend WithEvents ToolStripButton2 As ToolStripButton
    Friend WithEvents tbOpc As ToolStripTextBox
    Friend WithEvents dtpFI As DateTimePicker
    Friend WithEvents dtpFF As DateTimePicker
    Friend WithEvents cmsOpciones As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents PROCESOSToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripButton3 As ToolStripButton
    Friend WithEvents NIp As NotifyIcon
    Friend WithEvents btnUsuarios As ToolStripButton
    Friend WithEvents btnCredenciales As ToolStripButton
    Friend WithEvents pbCodigo As PictureBox
    Friend WithEvents pbCodigo2 As PictureBox
    Friend WithEvents pbCodigo3 As PictureBox
    Friend WithEvents btnGeneraReporte As ToolStripButton
End Class
