<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrNuevoBanco
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrNuevoBanco))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbBanco = New System.Windows.Forms.TextBox()
        Me.dgvBancos = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        CType(Me.dgvBancos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(62, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nombre del Banco"
        '
        'tbBanco
        '
        Me.tbBanco.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbBanco.Location = New System.Drawing.Point(11, 153)
        Me.tbBanco.Name = "tbBanco"
        Me.tbBanco.Size = New System.Drawing.Size(262, 27)
        Me.tbBanco.TabIndex = 1
        '
        'dgvBancos
        '
        Me.dgvBancos.AllowUserToAddRows = False
        Me.dgvBancos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvBancos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1})
        Me.dgvBancos.Location = New System.Drawing.Point(12, 216)
        Me.dgvBancos.Name = "dgvBancos"
        Me.dgvBancos.Size = New System.Drawing.Size(262, 194)
        Me.dgvBancos.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "Banco"
        Me.Column1.Name = "Column1"
        Me.Column1.Width = 200
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 64)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(286, 25)
        Me.ToolStrip2.TabIndex = 140
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
        'scrNuevoBanco
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(286, 422)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.dgvBancos)
        Me.Controls.Add(Me.tbBanco)
        Me.Controls.Add(Me.Label1)
        Me.Name = "scrNuevoBanco"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "scrNuevoBanco"
        CType(Me.dgvBancos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents tbBanco As TextBox
    Friend WithEvents dgvBancos As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbGuardar As ToolStripButton
End Class
