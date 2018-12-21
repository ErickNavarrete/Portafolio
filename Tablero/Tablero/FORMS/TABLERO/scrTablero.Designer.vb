<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrTablero
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrTablero))
        Me.tFecha = New System.Windows.Forms.Timer(Me.components)
        Me.dgvTablero = New System.Windows.Forms.DataGridView()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnTareas = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.cbTipo = New System.Windows.Forms.ToolStripComboBox()
        Me.cbOpcion = New System.Windows.Forms.ToolStripComboBox()
        Me.btnBuscqueda = New System.Windows.Forms.ToolStripButton()
        Me.tFecha2 = New System.Windows.Forms.Timer(Me.components)
        Me.tEstacion = New System.Windows.Forms.Timer(Me.components)
        Me.tProyecto_t = New System.Windows.Forms.Timer(Me.components)
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tFecha
        '
        Me.tFecha.Enabled = True
        Me.tFecha.Interval = 1000
        '
        'dgvTablero
        '
        Me.dgvTablero.AllowUserToAddRows = False
        Me.dgvTablero.AllowUserToDeleteRows = False
        Me.dgvTablero.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvTablero.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvTablero.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dgvTablero.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTablero.Location = New System.Drawing.Point(12, 105)
        Me.dgvTablero.Name = "dgvTablero"
        Me.dgvTablero.ReadOnly = True
        Me.dgvTablero.Size = New System.Drawing.Size(1123, 370)
        Me.dgvTablero.TabIndex = 7
        '
        'lbFecha
        '
        Me.lbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(851, 497)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(284, 30)
        Me.lbFecha.TabIndex = 8
        Me.lbFecha.Text = "dd/MMMM/yyyy hh:mm:ss"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnTareas, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.cbTipo, Me.cbOpcion, Me.btnBuscqueda})
        Me.ToolStrip1.Location = New System.Drawing.Point(-2, 62)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1160, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnTareas
        '
        Me.btnTareas.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTareas.Image = CType(resources.GetObject("btnTareas.Image"), System.Drawing.Image)
        Me.btnTareas.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnTareas.Name = "btnTareas"
        Me.btnTareas.Size = New System.Drawing.Size(137, 22)
        Me.btnTareas.Text = "Administrar Tareas"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(66, 22)
        Me.ToolStripLabel1.Text = "Buscar por:"
        '
        'cbTipo
        '
        Me.cbTipo.Items.AddRange(New Object() {"TODOS", "ESTACIÓN", "PROYECTO"})
        Me.cbTipo.Name = "cbTipo"
        Me.cbTipo.Size = New System.Drawing.Size(121, 25)
        '
        'cbOpcion
        '
        Me.cbOpcion.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbOpcion.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbOpcion.Name = "cbOpcion"
        Me.cbOpcion.Size = New System.Drawing.Size(200, 25)
        '
        'btnBuscqueda
        '
        Me.btnBuscqueda.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnBuscqueda.Image = CType(resources.GetObject("btnBuscqueda.Image"), System.Drawing.Image)
        Me.btnBuscqueda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnBuscqueda.Name = "btnBuscqueda"
        Me.btnBuscqueda.Size = New System.Drawing.Size(23, 22)
        Me.btnBuscqueda.Text = "ToolStripButton1"
        '
        'tFecha2
        '
        Me.tFecha2.Interval = 1000
        '
        'tEstacion
        '
        Me.tEstacion.Interval = 1000
        '
        'tProyecto_t
        '
        Me.tProyecto_t.Interval = 1000
        '
        'scrTablero
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1147, 538)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.dgvTablero)
        Me.Name = "scrTablero"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablero"
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tFecha As Timer
    Friend WithEvents dgvTablero As DataGridView
    Friend WithEvents lbFecha As Label
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnTareas As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents cbTipo As ToolStripComboBox
    Friend WithEvents btnBuscqueda As ToolStripButton
    Friend WithEvents cbOpcion As ToolStripComboBox
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents tFecha2 As Timer
    Friend WithEvents tEstacion As Timer
    Friend WithEvents tProyecto_t As Timer
End Class
