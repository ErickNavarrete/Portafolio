﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrTablero3
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrTablero3))
        Me.btnBusqueda = New MaterialSkin.Controls.MaterialFlatButton()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbBusq3 = New System.Windows.Forms.ComboBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbBusq2 = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbBusq1 = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvTablero = New System.Windows.Forms.DataGridView()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.tFecha = New System.Windows.Forms.Timer(Me.components)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnBusqueda
        '
        Me.btnBusqueda.AutoSize = True
        Me.btnBusqueda.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnBusqueda.Depth = 0
        Me.btnBusqueda.Location = New System.Drawing.Point(985, 133)
        Me.btnBusqueda.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnBusqueda.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnBusqueda.Name = "btnBusqueda"
        Me.btnBusqueda.Primary = False
        Me.btnBusqueda.Size = New System.Drawing.Size(65, 36)
        Me.btnBusqueda.TabIndex = 48
        Me.btnBusqueda.Text = "Buscar"
        Me.btnBusqueda.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox3.Controls.Add(Me.MaterialLabel3)
        Me.GroupBox3.Controls.Add(Me.cbBusq3)
        Me.GroupBox3.Location = New System.Drawing.Point(652, 107)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(316, 75)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "FILTRO 3"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(6, 16)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(133, 19)
        Me.MaterialLabel3.TabIndex = 42
        Me.MaterialLabel3.Text = "Tipo de Búsqueda:"
        '
        'cbBusq3
        '
        Me.cbBusq3.FormattingEnabled = True
        Me.cbBusq3.Location = New System.Drawing.Point(10, 41)
        Me.cbBusq3.Name = "cbBusq3"
        Me.cbBusq3.Size = New System.Drawing.Size(293, 21)
        Me.cbBusq3.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.MaterialLabel2)
        Me.GroupBox2.Controls.Add(Me.cbBusq2)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 75)
        Me.GroupBox2.TabIndex = 46
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "FILTRO 2"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(6, 16)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(133, 19)
        Me.MaterialLabel2.TabIndex = 42
        Me.MaterialLabel2.Text = "Tipo de Búsqueda:"
        '
        'cbBusq2
        '
        Me.cbBusq2.FormattingEnabled = True
        Me.cbBusq2.Location = New System.Drawing.Point(10, 41)
        Me.cbBusq2.Name = "cbBusq2"
        Me.cbBusq2.Size = New System.Drawing.Size(293, 21)
        Me.cbBusq2.TabIndex = 41
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.cbBusq1)
        Me.GroupBox1.Controls.Add(Me.MaterialLabel1)
        Me.GroupBox1.Location = New System.Drawing.Point(8, 107)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 75)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "FILTRO 1"
        '
        'cbBusq1
        '
        Me.cbBusq1.FormattingEnabled = True
        Me.cbBusq1.Items.AddRange(New Object() {"Orden de Trabajo"})
        Me.cbBusq1.Location = New System.Drawing.Point(10, 41)
        Me.cbBusq1.Name = "cbBusq1"
        Me.cbBusq1.Size = New System.Drawing.Size(293, 21)
        Me.cbBusq1.TabIndex = 41
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(6, 19)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(133, 19)
        Me.MaterialLabel1.TabIndex = 40
        Me.MaterialLabel1.Text = "Tipo de Búsqueda:"
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
        Me.dgvTablero.Location = New System.Drawing.Point(8, 193)
        Me.dgvTablero.Name = "dgvTablero"
        Me.dgvTablero.ReadOnly = True
        Me.dgvTablero.Size = New System.Drawing.Size(1161, 357)
        Me.dgvTablero.TabIndex = 49
        '
        'lbFecha
        '
        Me.lbFecha.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbFecha.AutoSize = True
        Me.lbFecha.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(789, 564)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(284, 30)
        Me.lbFecha.TabIndex = 50
        Me.lbFecha.Text = "dd/MMMM/yyyy hh:mm:ss"
        '
        'tFecha
        '
        Me.tFecha.Enabled = True
        Me.tFecha.Interval = 1000
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(-2, 64)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1185, 25)
        Me.ToolStrip1.TabIndex = 51
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(112, 22)
        Me.ToolStripButton1.Text = "Generar Reporte"
        Me.ToolStripButton1.Visible = False
        '
        'scrTablero3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1182, 603)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.dgvTablero)
        Me.Controls.Add(Me.btnBusqueda)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "scrTablero3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tablero"
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgvTablero, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnBusqueda As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbBusq3 As ComboBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbBusq2 As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbBusq1 As ComboBox
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvTablero As DataGridView
    Friend WithEvents lbFecha As Label
    Friend WithEvents tFecha As Timer
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
End Class