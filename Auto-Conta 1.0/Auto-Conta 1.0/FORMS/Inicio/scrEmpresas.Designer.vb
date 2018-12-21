<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrEmpresas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrEmpresas))
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.cbRegFis = New System.Windows.Forms.ComboBox()
        Me.tbNombreBaese = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbRFCEmp = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbNomEmp = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 64)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(514, 25)
        Me.ToolStrip2.TabIndex = 4
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(54, 22)
        Me.tsbGuardar.Text = "Crear"
        '
        'cbRegFis
        '
        Me.cbRegFis.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbRegFis.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbRegFis.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbRegFis.FormattingEnabled = True
        Me.cbRegFis.Location = New System.Drawing.Point(188, 189)
        Me.cbRegFis.Name = "cbRegFis"
        Me.cbRegFis.Size = New System.Drawing.Size(310, 28)
        Me.cbRegFis.Sorted = True
        Me.cbRegFis.TabIndex = 3
        '
        'tbNombreBaese
        '
        Me.tbNombreBaese.Depth = 0
        Me.tbNombreBaese.Hint = ""
        Me.tbNombreBaese.Location = New System.Drawing.Point(188, 102)
        Me.tbNombreBaese.MaxLength = 32767
        Me.tbNombreBaese.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNombreBaese.Name = "tbNombreBaese"
        Me.tbNombreBaese.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNombreBaese.SelectedText = ""
        Me.tbNombreBaese.SelectionLength = 0
        Me.tbNombreBaese.SelectionStart = 0
        Me.tbNombreBaese.Size = New System.Drawing.Size(310, 23)
        Me.tbNombreBaese.TabIndex = 0
        Me.tbNombreBaese.TabStop = False
        Me.tbNombreBaese.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 102)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(140, 19)
        Me.MaterialLabel3.TabIndex = 139
        Me.MaterialLabel3.Text = "Nombre de la Base:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 189)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(170, 19)
        Me.MaterialLabel2.TabIndex = 138
        Me.MaterialLabel2.Text = "Regimen de la Empresa:"
        '
        'tbRFCEmp
        '
        Me.tbRFCEmp.Depth = 0
        Me.tbRFCEmp.Hint = ""
        Me.tbRFCEmp.Location = New System.Drawing.Point(188, 160)
        Me.tbRFCEmp.MaxLength = 15
        Me.tbRFCEmp.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbRFCEmp.Name = "tbRFCEmp"
        Me.tbRFCEmp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbRFCEmp.SelectedText = ""
        Me.tbRFCEmp.SelectionLength = 0
        Me.tbRFCEmp.SelectionStart = 0
        Me.tbRFCEmp.Size = New System.Drawing.Size(310, 23)
        Me.tbRFCEmp.TabIndex = 2
        Me.tbRFCEmp.TabStop = False
        Me.tbRFCEmp.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 160)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(139, 19)
        Me.MaterialLabel1.TabIndex = 137
        Me.MaterialLabel1.Text = "RFC de la Empresa:"
        '
        'tbNomEmp
        '
        Me.tbNomEmp.Depth = 0
        Me.tbNomEmp.Hint = ""
        Me.tbNomEmp.Location = New System.Drawing.Point(188, 131)
        Me.tbNomEmp.MaxLength = 32767
        Me.tbNomEmp.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNomEmp.Name = "tbNomEmp"
        Me.tbNomEmp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNomEmp.SelectedText = ""
        Me.tbNomEmp.SelectionLength = 0
        Me.tbNomEmp.SelectionStart = 0
        Me.tbNomEmp.Size = New System.Drawing.Size(310, 23)
        Me.tbNomEmp.TabIndex = 1
        Me.tbNomEmp.TabStop = False
        Me.tbNomEmp.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(12, 131)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(166, 19)
        Me.MaterialLabel5.TabIndex = 136
        Me.MaterialLabel5.Text = "Nombre de la Empresa:"
        '
        'scrEmpresas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 232)
        Me.Controls.Add(Me.cbRegFis)
        Me.Controls.Add(Me.tbNombreBaese)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.tbRFCEmp)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.tbNomEmp)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "scrEmpresas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nueva Empresa"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents cbRegFis As ComboBox
    Friend WithEvents tbNombreBaese As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbRFCEmp As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbNomEmp As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
End Class
