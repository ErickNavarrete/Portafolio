<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrUsuariosEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrUsuariosEmpresas))
        Me.tabSelect = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tabSeleccion = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvUsuarios = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsUsuarios = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevUs = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimUs = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.base = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tsEmp = New System.Windows.Forms.ToolStrip()
        Me.tsbNuevEmp = New System.Windows.Forms.ToolStripButton()
        Me.tsbElimEmp = New System.Windows.Forms.ToolStripButton()
        Me.tabSeleccion.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsUsuarios.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tsEmp.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabSelect
        '
        Me.tabSelect.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSelect.BaseTabControl = Me.tabSeleccion
        Me.tabSelect.Depth = 0
        Me.tabSelect.Location = New System.Drawing.Point(0, 64)
        Me.tabSelect.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabSelect.Name = "tabSelect"
        Me.tabSelect.Size = New System.Drawing.Size(618, 23)
        Me.tabSelect.TabIndex = 2
        Me.tabSelect.Text = "MaterialTabSelector1"
        '
        'tabSeleccion
        '
        Me.tabSeleccion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabSeleccion.Controls.Add(Me.TabPage1)
        Me.tabSeleccion.Controls.Add(Me.TabPage2)
        Me.tabSeleccion.Depth = 0
        Me.tabSeleccion.Location = New System.Drawing.Point(12, 93)
        Me.tabSeleccion.MouseState = MaterialSkin.MouseState.HOVER
        Me.tabSeleccion.Name = "tabSeleccion"
        Me.tabSeleccion.SelectedIndex = 0
        Me.tabSeleccion.Size = New System.Drawing.Size(594, 347)
        Me.tabSeleccion.TabIndex = 3
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvUsuarios)
        Me.TabPage1.Controls.Add(Me.tsUsuarios)
        Me.TabPage1.Location = New System.Drawing.Point(4, 30)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(586, 313)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Usuarios"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvUsuarios
        '
        Me.dgvUsuarios.AllowUserToAddRows = False
        Me.dgvUsuarios.AllowUserToDeleteRows = False
        Me.dgvUsuarios.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUsuarios.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.empresa})
        Me.dgvUsuarios.Location = New System.Drawing.Point(6, 39)
        Me.dgvUsuarios.Name = "dgvUsuarios"
        Me.dgvUsuarios.ReadOnly = True
        Me.dgvUsuarios.RowHeadersVisible = False
        Me.dgvUsuarios.Size = New System.Drawing.Size(574, 268)
        Me.dgvUsuarios.TabIndex = 37
        '
        'id
        '
        Me.id.HeaderText = "id_us"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        '
        'empresa
        '
        Me.empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.empresa.HeaderText = "Ususario"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        '
        'tsUsuarios
        '
        Me.tsUsuarios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsUsuarios.AutoSize = False
        Me.tsUsuarios.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsUsuarios.Dock = System.Windows.Forms.DockStyle.None
        Me.tsUsuarios.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevUs, Me.tsbElimUs})
        Me.tsUsuarios.Location = New System.Drawing.Point(3, 3)
        Me.tsUsuarios.Name = "tsUsuarios"
        Me.tsUsuarios.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsUsuarios.Size = New System.Drawing.Size(580, 32)
        Me.tsUsuarios.TabIndex = 29
        Me.tsUsuarios.Text = "ToolStrip1"
        '
        'tsbNuevUs
        '
        Me.tsbNuevUs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNuevUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbNuevUs.Image = CType(resources.GetObject("tsbNuevUs.Image"), System.Drawing.Image)
        Me.tsbNuevUs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevUs.Name = "tsbNuevUs"
        Me.tsbNuevUs.Size = New System.Drawing.Size(105, 29)
        Me.tsbNuevUs.Text = "Nuevo Usuario"
        '
        'tsbElimUs
        '
        Me.tsbElimUs.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbElimUs.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbElimUs.Image = CType(resources.GetObject("tsbElimUs.Image"), System.Drawing.Image)
        Me.tsbElimUs.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimUs.Name = "tsbElimUs"
        Me.tsbElimUs.Size = New System.Drawing.Size(113, 29)
        Me.tsbElimUs.Text = "Eliminar Usuario"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.dgvEmpresas)
        Me.TabPage2.Controls.Add(Me.tsEmp)
        Me.TabPage2.Location = New System.Drawing.Point(4, 30)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(586, 313)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Empresas"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.AllowUserToAddRows = False
        Me.dgvEmpresas.AllowUserToDeleteRows = False
        Me.dgvEmpresas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvEmpresas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.rfc, Me.base})
        Me.dgvEmpresas.Location = New System.Drawing.Point(6, 39)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.RowHeadersVisible = False
        Me.dgvEmpresas.Size = New System.Drawing.Size(574, 268)
        Me.dgvEmpresas.TabIndex = 38
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "id_emp"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Visible = False
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.DataGridViewTextBoxColumn2.HeaderText = "Empresa"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'rfc
        '
        Me.rfc.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.rfc.HeaderText = "RFC"
        Me.rfc.Name = "rfc"
        '
        'base
        '
        Me.base.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.base.HeaderText = "Base"
        Me.base.Name = "base"
        '
        'tsEmp
        '
        Me.tsEmp.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tsEmp.AutoSize = False
        Me.tsEmp.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsEmp.Dock = System.Windows.Forms.DockStyle.None
        Me.tsEmp.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbNuevEmp, Me.tsbElimEmp})
        Me.tsEmp.Location = New System.Drawing.Point(3, 3)
        Me.tsEmp.Name = "tsEmp"
        Me.tsEmp.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.tsEmp.Size = New System.Drawing.Size(580, 32)
        Me.tsEmp.TabIndex = 30
        Me.tsEmp.Text = "ToolStrip2"
        '
        'tsbNuevEmp
        '
        Me.tsbNuevEmp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNuevEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbNuevEmp.Image = CType(resources.GetObject("tsbNuevEmp.Image"), System.Drawing.Image)
        Me.tsbNuevEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNuevEmp.Name = "tsbNuevEmp"
        Me.tsbNuevEmp.Size = New System.Drawing.Size(109, 29)
        Me.tsbNuevEmp.Text = "Nueva Empresa"
        '
        'tsbElimEmp
        '
        Me.tsbElimEmp.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbElimEmp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.tsbElimEmp.Image = CType(resources.GetObject("tsbElimEmp.Image"), System.Drawing.Image)
        Me.tsbElimEmp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbElimEmp.Name = "tsbElimEmp"
        Me.tsbElimEmp.Size = New System.Drawing.Size(118, 29)
        Me.tsbElimEmp.Text = "Eliminar Empresa"
        '
        'scrUsuariosEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 452)
        Me.Controls.Add(Me.tabSeleccion)
        Me.Controls.Add(Me.tabSelect)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "scrUsuariosEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Usuarios y Empresas"
        Me.tabSeleccion.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.dgvUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsUsuarios.ResumeLayout(False)
        Me.tsUsuarios.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tsEmp.ResumeLayout(False)
        Me.tsEmp.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tabSelect As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tabSeleccion As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents dgvUsuarios As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents tsUsuarios As ToolStrip
    Friend WithEvents tsbNuevUs As ToolStripButton
    Friend WithEvents tsbElimUs As ToolStripButton
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents dgvEmpresas As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents rfc As DataGridViewTextBoxColumn
    Friend WithEvents base As DataGridViewTextBoxColumn
    Friend WithEvents tsEmp As ToolStrip
    Friend WithEvents tsbNuevEmp As ToolStripButton
    Friend WithEvents tsbElimEmp As ToolStripButton
End Class
