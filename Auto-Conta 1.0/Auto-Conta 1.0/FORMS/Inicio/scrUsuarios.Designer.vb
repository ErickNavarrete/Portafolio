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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrUsuarios))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.tsbGyN = New System.Windows.Forms.ToolStripButton()
        Me.tsbGyC = New System.Windows.Forms.ToolStripButton()
        Me.tsbGC = New System.Windows.Forms.ToolStripButton()
        Me.lblIdUser = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvEmpresas = New System.Windows.Forms.DataGridView()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.empresa = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.seleccion = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.rbtnList = New MaterialSkin.Controls.MaterialRadioButton()
        Me.rbtnEmp = New MaterialSkin.Controls.MaterialRadioButton()
        Me.tbPass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbUsuario = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbConfirPass = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGyN, Me.tsbGyC, Me.tsbGC})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 64)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(591, 25)
        Me.ToolStrip1.TabIndex = 15
        Me.ToolStrip1.Text = "ToolStrip2"
        '
        'tsbGyN
        '
        Me.tsbGyN.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbGyN.Image = CType(resources.GetObject("tsbGyN.Image"), System.Drawing.Image)
        Me.tsbGyN.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGyN.Name = "tsbGyN"
        Me.tsbGyN.Size = New System.Drawing.Size(131, 22)
        Me.tsbGyN.Text = "Guardar y Nuevo"
        '
        'tsbGyC
        '
        Me.tsbGyC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbGyC.Image = CType(resources.GetObject("tsbGyC.Image"), System.Drawing.Image)
        Me.tsbGyC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGyC.Name = "tsbGyC"
        Me.tsbGyC.Size = New System.Drawing.Size(129, 22)
        Me.tsbGyC.Text = "Guardar y Cerrar"
        '
        'tsbGC
        '
        Me.tsbGC.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbGC.Image = CType(resources.GetObject("tsbGC.Image"), System.Drawing.Image)
        Me.tsbGC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGC.Name = "tsbGC"
        Me.tsbGC.Size = New System.Drawing.Size(134, 22)
        Me.tsbGC.Text = "Guardar Cambios"
        Me.tsbGC.Visible = False
        '
        'lblIdUser
        '
        Me.lblIdUser.AutoSize = True
        Me.lblIdUser.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblIdUser.Depth = 0
        Me.lblIdUser.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblIdUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblIdUser.Location = New System.Drawing.Point(297, 101)
        Me.lblIdUser.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblIdUser.Name = "lblIdUser"
        Me.lblIdUser.Size = New System.Drawing.Size(13, 19)
        Me.lblIdUser.TabIndex = 41
        Me.lblIdUser.Text = "-"
        Me.lblIdUser.Visible = False
        '
        'dgvEmpresas
        '
        Me.dgvEmpresas.AllowUserToAddRows = False
        Me.dgvEmpresas.AllowUserToDeleteRows = False
        Me.dgvEmpresas.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvEmpresas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmpresas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.id, Me.empresa, Me.seleccion})
        Me.dgvEmpresas.Location = New System.Drawing.Point(16, 266)
        Me.dgvEmpresas.Name = "dgvEmpresas"
        Me.dgvEmpresas.RowHeadersVisible = False
        Me.dgvEmpresas.Size = New System.Drawing.Size(324, 189)
        Me.dgvEmpresas.TabIndex = 38
        '
        'id
        '
        Me.id.HeaderText = "id_emp"
        Me.id.Name = "id"
        Me.id.Visible = False
        '
        'empresa
        '
        Me.empresa.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.empresa.HeaderText = "Empresa"
        Me.empresa.Name = "empresa"
        Me.empresa.ReadOnly = True
        '
        'seleccion
        '
        Me.seleccion.HeaderText = "Seleccion"
        Me.seleccion.Name = "seleccion"
        Me.seleccion.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.seleccion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        '
        'rbtnList
        '
        Me.rbtnList.AutoSize = True
        Me.rbtnList.Depth = 0
        Me.rbtnList.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbtnList.Location = New System.Drawing.Point(191, 221)
        Me.rbtnList.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnList.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbtnList.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbtnList.Name = "rbtnList"
        Me.rbtnList.Ripple = True
        Me.rbtnList.Size = New System.Drawing.Size(149, 30)
        Me.rbtnList.TabIndex = 37
        Me.rbtnList.TabStop = True
        Me.rbtnList.Text = "Seleccionar de lista"
        Me.rbtnList.UseVisualStyleBackColor = True
        '
        'rbtnEmp
        '
        Me.rbtnEmp.AutoSize = True
        Me.rbtnEmp.Depth = 0
        Me.rbtnEmp.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.rbtnEmp.Location = New System.Drawing.Point(16, 221)
        Me.rbtnEmp.Margin = New System.Windows.Forms.Padding(0)
        Me.rbtnEmp.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.rbtnEmp.MouseState = MaterialSkin.MouseState.HOVER
        Me.rbtnEmp.Name = "rbtnEmp"
        Me.rbtnEmp.Ripple = True
        Me.rbtnEmp.Size = New System.Drawing.Size(146, 30)
        Me.rbtnEmp.TabIndex = 36
        Me.rbtnEmp.TabStop = True
        Me.rbtnEmp.Text = "Todas las mpresas"
        Me.rbtnEmp.UseVisualStyleBackColor = True
        '
        'tbPass
        '
        Me.tbPass.Depth = 0
        Me.tbPass.Hint = ""
        Me.tbPass.Location = New System.Drawing.Point(108, 141)
        Me.tbPass.MaxLength = 32767
        Me.tbPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbPass.Name = "tbPass"
        Me.tbPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbPass.SelectedText = ""
        Me.tbPass.SelectionLength = 0
        Me.tbPass.SelectionStart = 0
        Me.tbPass.Size = New System.Drawing.Size(183, 23)
        Me.tbPass.TabIndex = 34
        Me.tbPass.TabStop = False
        Me.tbPass.UseSystemPasswordChar = True
        '
        'tbUsuario
        '
        Me.tbUsuario.Depth = 0
        Me.tbUsuario.Hint = ""
        Me.tbUsuario.Location = New System.Drawing.Point(108, 101)
        Me.tbUsuario.MaxLength = 32767
        Me.tbUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsuario.SelectedText = ""
        Me.tbUsuario.SelectionLength = 0
        Me.tbUsuario.SelectionStart = 0
        Me.tbUsuario.Size = New System.Drawing.Size(183, 23)
        Me.tbUsuario.TabIndex = 32
        Me.tbUsuario.TabStop = False
        Me.tbUsuario.UseSystemPasswordChar = False
        '
        'tbConfirPass
        '
        Me.tbConfirPass.Depth = 0
        Me.tbConfirPass.Hint = ""
        Me.tbConfirPass.Location = New System.Drawing.Point(108, 179)
        Me.tbConfirPass.MaxLength = 32767
        Me.tbConfirPass.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbConfirPass.Name = "tbConfirPass"
        Me.tbConfirPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbConfirPass.SelectedText = ""
        Me.tbConfirPass.SelectionLength = 0
        Me.tbConfirPass.SelectionStart = 0
        Me.tbConfirPass.Size = New System.Drawing.Size(183, 23)
        Me.tbConfirPass.TabIndex = 35
        Me.tbConfirPass.TabStop = False
        Me.tbConfirPass.UseSystemPasswordChar = True
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 179)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(80, 19)
        Me.MaterialLabel3.TabIndex = 40
        Me.MaterialLabel3.Text = "Confirmar:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 141)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(90, 19)
        Me.MaterialLabel2.TabIndex = 39
        Me.MaterialLabel2.Text = "Contraseña:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 101)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel1.TabIndex = 33
        Me.MaterialLabel1.Text = "Usuario:"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Controls.Add(Me.TreeView1)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 92)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(234, 363)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Permisos"
        '
        'TreeView1
        '
        Me.TreeView1.CheckBoxes = True
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(3, 25)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(228, 335)
        Me.TreeView1.TabIndex = 0
        '
        'scrUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(591, 473)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.lblIdUser)
        Me.Controls.Add(Me.dgvEmpresas)
        Me.Controls.Add(Me.rbtnList)
        Me.Controls.Add(Me.rbtnEmp)
        Me.Controls.Add(Me.tbPass)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.tbConfirPass)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "scrUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Alta Usuarios"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvEmpresas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents tsbGyN As ToolStripButton
    Friend WithEvents tsbGyC As ToolStripButton
    Friend WithEvents tsbGC As ToolStripButton
    Friend WithEvents lblIdUser As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvEmpresas As DataGridView
    Friend WithEvents id As DataGridViewTextBoxColumn
    Friend WithEvents empresa As DataGridViewTextBoxColumn
    Friend WithEvents seleccion As DataGridViewCheckBoxColumn
    Friend WithEvents rbtnList As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents rbtnEmp As MaterialSkin.Controls.MaterialRadioButton
    Friend WithEvents tbPass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbUsuario As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbConfirPass As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TreeView1 As TreeView
End Class
