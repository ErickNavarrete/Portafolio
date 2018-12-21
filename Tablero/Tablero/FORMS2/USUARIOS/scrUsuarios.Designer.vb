<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrUsuarios))
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsOpciones = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.GENERACBToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.pbCodigo = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbOpcion = New System.Windows.Forms.ToolStripComboBox()
        Me.tbOpcion = New System.Windows.Forms.ToolStripTextBox()
        Me.btnBusqueda = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsOpciones.SuspendLayout()
        CType(Me.pbCodigo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvUsuarios.ContextMenuStrip = Me.cmsOpciones
        Me.dgvUsuarios.Location = New System.Drawing.Point(12, 91)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.Size = New System.Drawing.Size(942, 367)
        Me.dgvUsuarios.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "NOMBRE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "DEPARTAMENTO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 200
        '
        'cmsOpciones
        '
        Me.cmsOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GENERACBToolStripMenuItem})
        Me.cmsOpciones.Name = "cmsOpciones"
        Me.cmsOpciones.Size = New System.Drawing.Size(137, 26)
        '
        'GENERACBToolStripMenuItem
        '
        Me.GENERACBToolStripMenuItem.Name = "GENERACBToolStripMenuItem"
        Me.GENERACBToolStripMenuItem.Size = New System.Drawing.Size(136, 22)
        Me.GENERACBToolStripMenuItem.Text = "GENERA CB"
        '
        'pbCodigo
        '
        Me.pbCodigo.Location = New System.Drawing.Point(26, 139)
        Me.pbCodigo.Name = "pbCodigo"
        Me.pbCodigo.Size = New System.Drawing.Size(306, 129)
        Me.pbCodigo.TabIndex = 44
        Me.pbCodigo.TabStop = False
        Me.pbCodigo.Visible = False
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
        Me.ToolStrip1.Size = New System.Drawing.Size(967, 25)
        Me.ToolStrip1.TabIndex = 45
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(105, 22)
        Me.ToolStripLabel1.Text = "Tipo de Búsqueda:"
        '
        'cbOpcion
        '
        Me.cbOpcion.Items.AddRange(New Object() {"Departamento", "Nombre", "Todos"})
        Me.cbOpcion.Name = "cbOpcion"
        Me.cbOpcion.Size = New System.Drawing.Size(130, 25)
        '
        'tbOpcion
        '
        Me.tbOpcion.Name = "tbOpcion"
        Me.tbOpcion.Size = New System.Drawing.Size(200, 25)
        '
        'btnBusqueda
        '
        Me.btnBusqueda.Image = CType(resources.GetObject("btnBusqueda.Image"), System.Drawing.Image)
        Me.btnBusqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Size = New System.Drawing.Size(62, 22)
        Me.btnBusqueda.Text = "Buscar"
        '
        'scrUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 470)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.pbCodigo)
        Me.Controls.Add(Me.dgvUsuarios)
        Me.Name = "scrUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios"
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsOpciones.ResumeLayout(False)
        CType(Me.pbCodigo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents cmsOpciones As ContextMenuStrip
    Friend WithEvents GENERACBToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents pbCodigo As PictureBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbOpcion As ToolStripComboBox
    Friend WithEvents tbOpcion As ToolStripTextBox
    Friend WithEvents btnBusqueda As ToolStripButton
End Class
