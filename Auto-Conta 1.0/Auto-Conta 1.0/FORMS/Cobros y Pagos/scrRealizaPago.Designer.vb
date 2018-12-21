<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrRealizaPago
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrRealizaPago))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFP = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbFolio = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbUUID = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbMonto = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.gbDatosF = New System.Windows.Forms.GroupBox()
        Me.tbTotal = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbRFC = New System.Windows.Forms.TextBox()
        Me.tbNombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.toll = New System.Windows.Forms.ToolStrip()
        Me.btnPC = New System.Windows.Forms.ToolStripButton()
        Me.tbSerie = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.gbDatosF.SuspendLayout()
        Me.toll.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(381, 184)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(111, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Fecha de Pago:"
        '
        'dtpFP
        '
        Me.dtpFP.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFP.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFP.Location = New System.Drawing.Point(498, 182)
        Me.dtpFP.Name = "dtpFP"
        Me.dtpFP.Size = New System.Drawing.Size(200, 20)
        Me.dtpFP.TabIndex = 1
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(381, 117)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Serie:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(570, 117)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel3.TabIndex = 4
        Me.MaterialLabel3.Text = "Folio:"
        '
        'tbFolio
        '
        Me.tbFolio.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbFolio.Depth = 0
        Me.tbFolio.Hint = ""
        Me.tbFolio.Location = New System.Drawing.Point(623, 113)
        Me.tbFolio.MaxLength = 32767
        Me.tbFolio.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFolio.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbFolio.SelectedText = ""
        Me.tbFolio.SelectionLength = 0
        Me.tbFolio.SelectionStart = 0
        Me.tbFolio.Size = New System.Drawing.Size(165, 23)
        Me.tbFolio.TabIndex = 17
        Me.tbFolio.TabStop = False
        Me.tbFolio.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(381, 245)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel4.TabIndex = 18
        Me.MaterialLabel4.Text = "UUID:"
        '
        'tbUUID
        '
        Me.tbUUID.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbUUID.Depth = 0
        Me.tbUUID.Hint = ""
        Me.tbUUID.Location = New System.Drawing.Point(434, 241)
        Me.tbUUID.MaxLength = 32767
        Me.tbUUID.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbUUID.Name = "tbUUID"
        Me.tbUUID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUUID.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbUUID.SelectedText = ""
        Me.tbUUID.SelectionLength = 0
        Me.tbUUID.SelectionStart = 0
        Me.tbUUID.Size = New System.Drawing.Size(354, 23)
        Me.tbUUID.TabIndex = 19
        Me.tbUUID.TabStop = False
        Me.tbUUID.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(381, 299)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(57, 19)
        Me.MaterialLabel5.TabIndex = 20
        Me.MaterialLabel5.Text = "Monto:"
        '
        'tbMonto
        '
        Me.tbMonto.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMonto.Depth = 0
        Me.tbMonto.Hint = ""
        Me.tbMonto.Location = New System.Drawing.Point(444, 295)
        Me.tbMonto.MaxLength = 32767
        Me.tbMonto.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbMonto.Name = "tbMonto"
        Me.tbMonto.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMonto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbMonto.SelectedText = ""
        Me.tbMonto.SelectionLength = 0
        Me.tbMonto.SelectionStart = 0
        Me.tbMonto.Size = New System.Drawing.Size(344, 23)
        Me.tbMonto.TabIndex = 21
        Me.tbMonto.TabStop = False
        Me.tbMonto.Text = "0.0"
        Me.tbMonto.UseSystemPasswordChar = False
        '
        'gbDatosF
        '
        Me.gbDatosF.BackColor = System.Drawing.SystemColors.ControlLight
        Me.gbDatosF.Controls.Add(Me.tbTotal)
        Me.gbDatosF.Controls.Add(Me.Label3)
        Me.gbDatosF.Controls.Add(Me.tbRFC)
        Me.gbDatosF.Controls.Add(Me.tbNombre)
        Me.gbDatosF.Controls.Add(Me.Label2)
        Me.gbDatosF.Controls.Add(Me.Label1)
        Me.gbDatosF.Font = New System.Drawing.Font("Segoe UI Symbol", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.gbDatosF.Location = New System.Drawing.Point(12, 117)
        Me.gbDatosF.Name = "gbDatosF"
        Me.gbDatosF.Size = New System.Drawing.Size(363, 359)
        Me.gbDatosF.TabIndex = 22
        Me.gbDatosF.TabStop = False
        Me.gbDatosF.Text = "Datos de la Factura a Pagar"
        '
        'tbTotal
        '
        Me.tbTotal.Location = New System.Drawing.Point(9, 202)
        Me.tbTotal.Name = "tbTotal"
        Me.tbTotal.ReadOnly = True
        Me.tbTotal.Size = New System.Drawing.Size(348, 25)
        Me.tbTotal.TabIndex = 5
        Me.tbTotal.Text = "0.0"
        Me.tbTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Total:"
        '
        'tbRFC
        '
        Me.tbRFC.Location = New System.Drawing.Point(6, 128)
        Me.tbRFC.Name = "tbRFC"
        Me.tbRFC.ReadOnly = True
        Me.tbRFC.Size = New System.Drawing.Size(348, 25)
        Me.tbRFC.TabIndex = 3
        '
        'tbNombre
        '
        Me.tbNombre.Location = New System.Drawing.Point(9, 60)
        Me.tbNombre.Name = "tbNombre"
        Me.tbNombre.ReadOnly = True
        Me.tbNombre.Size = New System.Drawing.Size(348, 25)
        Me.tbNombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(117, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nombre Receptor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 105)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(90, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "RFC Receptor:"
        '
        'toll
        '
        Me.toll.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.toll.AutoSize = False
        Me.toll.BackColor = System.Drawing.Color.Transparent
        Me.toll.Dock = System.Windows.Forms.DockStyle.None
        Me.toll.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnPC})
        Me.toll.Location = New System.Drawing.Point(9, 65)
        Me.toll.Name = "toll"
        Me.toll.Size = New System.Drawing.Size(791, 25)
        Me.toll.TabIndex = 23
        Me.toll.Text = "ToolStrip1"
        '
        'btnPC
        '
        Me.btnPC.Image = CType(resources.GetObject("btnPC.Image"), System.Drawing.Image)
        Me.btnPC.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnPC.Name = "btnPC"
        Me.btnPC.Size = New System.Drawing.Size(97, 22)
        Me.btnPC.Text = "Realizar Pago"
        '
        'tbSerie
        '
        Me.tbSerie.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbSerie.Depth = 0
        Me.tbSerie.Hint = ""
        Me.tbSerie.Location = New System.Drawing.Point(434, 113)
        Me.tbSerie.MaxLength = 32767
        Me.tbSerie.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbSerie.Name = "tbSerie"
        Me.tbSerie.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbSerie.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbSerie.SelectedText = ""
        Me.tbSerie.SelectionLength = 0
        Me.tbSerie.SelectionStart = 0
        Me.tbSerie.Size = New System.Drawing.Size(119, 23)
        Me.tbSerie.TabIndex = 24
        Me.tbSerie.TabStop = False
        Me.tbSerie.UseSystemPasswordChar = False
        '
        'scrRealizaPago
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 488)
        Me.Controls.Add(Me.tbSerie)
        Me.Controls.Add(Me.toll)
        Me.Controls.Add(Me.gbDatosF)
        Me.Controls.Add(Me.tbMonto)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.tbUUID)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.dtpFP)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "scrRealizaPago"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Realizar Pago"
        Me.gbDatosF.ResumeLayout(False)
        Me.gbDatosF.PerformLayout()
        Me.toll.ResumeLayout(False)
        Me.toll.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFP As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbFolio As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbUUID As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbMonto As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents gbDatosF As GroupBox
    Friend WithEvents tbTotal As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents tbRFC As TextBox
    Friend WithEvents tbNombre As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents toll As ToolStrip
    Friend WithEvents btnPC As ToolStripButton
    Friend WithEvents tbSerie As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
