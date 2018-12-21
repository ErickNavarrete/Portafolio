<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrIniciarsesion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrIniciarsesion))
        Me.lbOpcion = New System.Windows.Forms.Label()
        Me.tbContra = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lblBase = New MaterialSkin.Controls.MaterialLabel()
        Me.btnVerifica = New System.Windows.Forms.Button()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbEmpresa = New System.Windows.Forms.ComboBox()
        Me.btnIniciar = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.cbConexion = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbUsuarios = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'lbOpcion
        '
        Me.lbOpcion.AutoSize = True
        Me.lbOpcion.Location = New System.Drawing.Point(358, 261)
        Me.lbOpcion.Name = "lbOpcion"
        Me.lbOpcion.Size = New System.Drawing.Size(13, 13)
        Me.lbOpcion.TabIndex = 26
        Me.lbOpcion.Text = "0"
        Me.lbOpcion.Visible = False
        '
        'tbContra
        '
        Me.tbContra.Depth = 0
        Me.tbContra.Hint = ""
        Me.tbContra.Location = New System.Drawing.Point(118, 154)
        Me.tbContra.MaxLength = 32767
        Me.tbContra.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbContra.Name = "tbContra"
        Me.tbContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.tbContra.SelectedText = ""
        Me.tbContra.SelectionLength = 0
        Me.tbContra.SelectionStart = 0
        Me.tbContra.Size = New System.Drawing.Size(354, 23)
        Me.tbContra.TabIndex = 16
        Me.tbContra.TabStop = False
        Me.tbContra.UseSystemPasswordChar = False
        '
        'lblBase
        '
        Me.lblBase.AutoSize = True
        Me.lblBase.Depth = 0
        Me.lblBase.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.lblBase.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblBase.Location = New System.Drawing.Point(40, 248)
        Me.lblBase.MouseState = MaterialSkin.MouseState.HOVER
        Me.lblBase.Name = "lblBase"
        Me.lblBase.Size = New System.Drawing.Size(72, 19)
        Me.lblBase.TabIndex = 25
        Me.lblBase.Text = "Empresa:"
        Me.lblBase.Visible = False
        '
        'btnVerifica
        '
        Me.btnVerifica.BackColor = System.Drawing.Color.Transparent
        Me.btnVerifica.BackgroundImage = CType(resources.GetObject("btnVerifica.BackgroundImage"), System.Drawing.Image)
        Me.btnVerifica.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerifica.FlatAppearance.BorderSize = 0
        Me.btnVerifica.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerifica.Location = New System.Drawing.Point(478, 160)
        Me.btnVerifica.Name = "btnVerifica"
        Me.btnVerifica.Size = New System.Drawing.Size(29, 23)
        Me.btnVerifica.TabIndex = 17
        Me.btnVerifica.UseVisualStyleBackColor = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(22, 195)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel4.TabIndex = 23
        Me.MaterialLabel4.Text = "Empresa:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(22, 160)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(90, 19)
        Me.MaterialLabel3.TabIndex = 22
        Me.MaterialLabel3.Text = "Contraseña:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(22, 125)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel2.TabIndex = 21
        Me.MaterialLabel2.Text = "Usuario:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(22, 89)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(76, 19)
        Me.MaterialLabel1.TabIndex = 19
        Me.MaterialLabel1.Text = "Conexión:"
        '
        'cbEmpresa
        '
        Me.cbEmpresa.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cbEmpresa.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbEmpresa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbEmpresa.Enabled = False
        Me.cbEmpresa.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmpresa.FormattingEnabled = True
        Me.cbEmpresa.Location = New System.Drawing.Point(118, 189)
        Me.cbEmpresa.Name = "cbEmpresa"
        Me.cbEmpresa.Size = New System.Drawing.Size(354, 29)
        Me.cbEmpresa.Sorted = True
        Me.cbEmpresa.TabIndex = 18
        '
        'btnIniciar
        '
        Me.btnIniciar.AutoSize = True
        Me.btnIniciar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnIniciar.Depth = 0
        Me.btnIniciar.Icon = Nothing
        Me.btnIniciar.Location = New System.Drawing.Point(213, 240)
        Me.btnIniciar.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnIniciar.Name = "btnIniciar"
        Me.btnIniciar.Primary = True
        Me.btnIniciar.Size = New System.Drawing.Size(120, 36)
        Me.btnIniciar.TabIndex = 20
        Me.btnIniciar.Text = "Iniciar Sesión"
        Me.btnIniciar.UseVisualStyleBackColor = True
        '
        'cbConexion
        '
        Me.cbConexion.Depth = 0
        Me.cbConexion.Hint = ""
        Me.cbConexion.Location = New System.Drawing.Point(118, 85)
        Me.cbConexion.MaxLength = 32767
        Me.cbConexion.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbConexion.Name = "cbConexion"
        Me.cbConexion.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cbConexion.SelectedText = ""
        Me.cbConexion.SelectionLength = 0
        Me.cbConexion.SelectionStart = 0
        Me.cbConexion.Size = New System.Drawing.Size(354, 23)
        Me.cbConexion.TabIndex = 27
        Me.cbConexion.TabStop = False
        Me.cbConexion.UseSystemPasswordChar = False
        '
        'cbUsuarios
        '
        Me.cbUsuarios.Depth = 0
        Me.cbUsuarios.Hint = ""
        Me.cbUsuarios.Location = New System.Drawing.Point(118, 121)
        Me.cbUsuarios.MaxLength = 32767
        Me.cbUsuarios.MouseState = MaterialSkin.MouseState.HOVER
        Me.cbUsuarios.Name = "cbUsuarios"
        Me.cbUsuarios.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.cbUsuarios.SelectedText = ""
        Me.cbUsuarios.SelectionLength = 0
        Me.cbUsuarios.SelectionStart = 0
        Me.cbUsuarios.Size = New System.Drawing.Size(354, 23)
        Me.cbUsuarios.TabIndex = 28
        Me.cbUsuarios.TabStop = False
        Me.cbUsuarios.UseSystemPasswordChar = False
        '
        'scrIniciarsesion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(542, 311)
        Me.Controls.Add(Me.cbUsuarios)
        Me.Controls.Add(Me.cbConexion)
        Me.Controls.Add(Me.lbOpcion)
        Me.Controls.Add(Me.tbContra)
        Me.Controls.Add(Me.lblBase)
        Me.Controls.Add(Me.btnVerifica)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.cbEmpresa)
        Me.Controls.Add(Me.btnIniciar)
        Me.Name = "scrIniciarsesion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbOpcion As Label
    Friend WithEvents tbContra As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lblBase As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents btnVerifica As Button
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbEmpresa As ComboBox
    Friend WithEvents btnIniciar As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents cbConexion As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbUsuarios As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
