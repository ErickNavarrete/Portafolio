<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrMuestraDetalles
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrMuestraDetalles))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.dgvDetalles = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvTareas = New System.Windows.Forms.DataGridView()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbOpcion = New System.Windows.Forms.ToolStripComboBox()
        Me.tbOpcion = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBusqueda = New System.Windows.Forms.ToolStripButton()
        Me.cmsOpciones = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.COPIARToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.cbOpcion, Me.tbOpcion, Me.btnBusqueda})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 63)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(968, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'dgvDetalles
        '
        Me.dgvDetalles.AllowUserToAddRows = False
        Me.dgvDetalles.AllowUserToDeleteRows = False
        Me.dgvDetalles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalles.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvDetalles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalles.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvDetalles.ContextMenuStrip = Me.cmsOpciones
        Me.dgvDetalles.Location = New System.Drawing.Point(12, 106)
        Me.dgvDetalles.Name = "dgvDetalles"
        Me.dgvDetalles.ReadOnly = True
        Me.dgvDetalles.Size = New System.Drawing.Size(571, 332)
        Me.dgvDetalles.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID_DETALLE"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "DETALLE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 200
        '
        'Column3
        '
        Me.Column3.HeaderText = "UNIDAD"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'Column4
        '
        Me.Column4.HeaderText = "OT"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'dgvTareas
        '
        Me.dgvTareas.AllowUserToAddRows = False
        Me.dgvTareas.AllowUserToDeleteRows = False
        Me.dgvTareas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTareas.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvTareas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTareas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column5, Me.Column6})
        Me.dgvTareas.Location = New System.Drawing.Point(623, 106)
        Me.dgvTareas.Name = "dgvTareas"
        Me.dgvTareas.ReadOnly = True
        Me.dgvTareas.Size = New System.Drawing.Size(328, 332)
        Me.dgvTareas.TabIndex = 2
        '
        'Column5
        '
        Me.Column5.HeaderText = "TAREA"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "ESTACIÓN"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Width = 150
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "Buscar Por:"
        '
        'cbOpcion
        '
        Me.cbOpcion.Items.AddRange(New Object() {"UNIDAD", "OT", "TODOS"})
        Me.cbOpcion.Name = "cbOpcion"
        Me.cbOpcion.Size = New System.Drawing.Size(130, 25)
        '
        'tbOpcion
        '
        Me.tbOpcion.Name = "tbOpcion"
        Me.tbOpcion.Size = New System.Drawing.Size(150, 25)
        '
        'btnBusqueda
        '
        Me.btnBusqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBusqueda.Image = CType(resources.GetObject("btnBusqueda.Image"), System.Drawing.Image)
        Me.btnBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Size = New System.Drawing.Size(23, 22)
        Me.btnBusqueda.Text = "ToolStripButton1"
        '
        'cmsOpciones
        '
        Me.cmsOpciones.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsOpciones.Depth = 0
        Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.COPIARToolStripMenuItem})
        Me.cmsOpciones.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmsOpciones.Name = "cmsOpciones"
        Me.cmsOpciones.Size = New System.Drawing.Size(181, 48)
        '
        'COPIARToolStripMenuItem
        '
        Me.COPIARToolStripMenuItem.Name = "COPIARToolStripMenuItem"
        Me.COPIARToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.COPIARToolStripMenuItem.Text = "COPIAR"
        '
        'scrMuestraDetalles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 450)
        Me.Controls.Add(Me.dgvTareas)
        Me.Controls.Add(Me.dgvDetalles)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "scrMuestraDetalles"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Muestra Detalles"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvDetalles, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvTareas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOpciones.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents dgvDetalles As DataGridView
    Friend WithEvents dgvTareas As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbOpcion As ToolStripComboBox
    Friend WithEvents tbOpcion As ToolStripTextBox
    Friend WithEvents btnBusqueda As ToolStripButton
    Friend WithEvents cmsOpciones As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents COPIARToolStripMenuItem As ToolStripMenuItem
End Class
