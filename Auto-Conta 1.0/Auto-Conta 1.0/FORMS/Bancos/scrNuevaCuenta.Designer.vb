<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrNuevaCuenta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrNuevaCuenta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbBanco = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbCuentab = New System.Windows.Forms.TextBox()
        Me.dgvCuentaB = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cmsBanco = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NuevoBancoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cmsDATAG = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.EditarCuentaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.cbCcontable = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tsbnumero = New System.Windows.Forms.ToolStripButton()
        Me.tsbNombre = New System.Windows.Forms.ToolStripButton()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvCuentaB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.cmsBanco.SuspendLayout()
        Me.cmsDATAG.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco:"
        '
        'cbBanco
        '
        Me.cbBanco.ContextMenuStrip = Me.cmsBanco
        Me.cbBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBanco.FormattingEnabled = True
        Me.cbBanco.Location = New System.Drawing.Point(85, 113)
        Me.cbBanco.Name = "cbBanco"
        Me.cbBanco.Size = New System.Drawing.Size(270, 28)
        Me.cbBanco.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(375, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(73, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Cuenta:"
        '
        'tbCuentab
        '
        Me.tbCuentab.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCuentab.Location = New System.Drawing.Point(454, 113)
        Me.tbCuentab.Name = "tbCuentab"
        Me.tbCuentab.Size = New System.Drawing.Size(444, 27)
        Me.tbCuentab.TabIndex = 3
        '
        'dgvCuentaB
        '
        Me.dgvCuentaB.AllowUserToAddRows = False
        Me.dgvCuentaB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvCuentaB.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dgvCuentaB.Location = New System.Drawing.Point(12, 200)
        Me.dgvCuentaB.Name = "dgvCuentaB"
        Me.dgvCuentaB.Size = New System.Drawing.Size(895, 321)
        Me.dgvCuentaB.TabIndex = 4
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar, Me.tsbnumero, Me.tsbNombre})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 63)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(944, 25)
        Me.ToolStrip2.TabIndex = 141
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'cmsBanco
        '
        Me.cmsBanco.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NuevoBancoToolStripMenuItem})
        Me.cmsBanco.Name = "cmsBanco"
        Me.cmsBanco.Size = New System.Drawing.Size(146, 26)
        '
        'NuevoBancoToolStripMenuItem
        '
        Me.NuevoBancoToolStripMenuItem.Name = "NuevoBancoToolStripMenuItem"
        Me.NuevoBancoToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.NuevoBancoToolStripMenuItem.Text = "Nuevo Banco"
        '
        'cmsDATAG
        '
        Me.cmsDATAG.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EditarCuentaToolStripMenuItem})
        Me.cmsDATAG.Name = "cmsDATAG"
        Me.cmsDATAG.Size = New System.Drawing.Size(146, 26)
        '
        'EditarCuentaToolStripMenuItem
        '
        Me.EditarCuentaToolStripMenuItem.Name = "EditarCuentaToolStripMenuItem"
        Me.EditarCuentaToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.EditarCuentaToolStripMenuItem.Text = "Editar Cuenta"
        '
        'cbCcontable
        '
        Me.cbCcontable.ContextMenuStrip = Me.cmsBanco
        Me.cbCcontable.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbCcontable.FormattingEnabled = True
        Me.cbCcontable.Location = New System.Drawing.Point(164, 158)
        Me.cbCcontable.Name = "cbCcontable"
        Me.cbCcontable.Size = New System.Drawing.Size(284, 28)
        Me.cbCcontable.TabIndex = 145
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 161)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(145, 22)
        Me.Label3.TabIndex = 144
        Me.Label3.Text = "Cuenta Contable"
        '
        'tsbnumero
        '
        Me.tsbnumero.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbnumero.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbnumero.Image = CType(resources.GetObject("tsbnumero.Image"), System.Drawing.Image)
        Me.tsbnumero.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbnumero.Name = "tsbnumero"
        Me.tsbnumero.Size = New System.Drawing.Size(128, 22)
        Me.tsbnumero.Text = "Buscar por número"
        '
        'tsbNombre
        '
        Me.tsbNombre.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbNombre.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbNombre.Image = CType(resources.GetObject("tsbNombre.Image"), System.Drawing.Image)
        Me.tsbNombre.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbNombre.Name = "tsbNombre"
        Me.tsbNombre.Size = New System.Drawing.Size(128, 22)
        Me.tsbNombre.Text = "Buscar por nombre"
        Me.tsbNombre.Visible = False
        '
        'Column1
        '
        Me.Column1.HeaderText = "Banco"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 250
        '
        'Column2
        '
        Me.Column2.HeaderText = "Cuenta Bancaria"
        Me.Column2.Name = "Column2"
        Me.Column2.Width = 300
        '
        'Column3
        '
        Me.Column3.HeaderText = "Nombre cuenta contable"
        Me.Column3.Name = "Column3"
        Me.Column3.Width = 150
        '
        'Column4
        '
        Me.Column4.HeaderText = "Número cuenta contable"
        Me.Column4.Name = "Column4"
        Me.Column4.Width = 150
        '
        'scrNuevaCuenta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 533)
        Me.Controls.Add(Me.cbCcontable)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.dgvCuentaB)
        Me.Controls.Add(Me.tbCuentab)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbBanco)
        Me.Controls.Add(Me.Label1)
        Me.Name = "scrNuevaCuenta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "scrNuevaCuenta"
        CType(Me.dgvCuentaB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.cmsBanco.ResumeLayout(False)
        Me.cmsDATAG.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbBanco As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbCuentab As TextBox
    Friend WithEvents dgvCuentaB As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents cmsBanco As ContextMenuStrip
    Friend WithEvents NuevoBancoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cmsDATAG As ContextMenuStrip
    Friend WithEvents EditarCuentaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents cbCcontable As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tsbnumero As ToolStripButton
    Friend WithEvents tsbNombre As ToolStripButton
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
End Class
