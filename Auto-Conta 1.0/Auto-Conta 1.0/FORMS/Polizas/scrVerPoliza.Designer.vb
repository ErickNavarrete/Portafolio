<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrVerPoliza
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.tbDes = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbNombrePol = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbNumPol = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgvPoliza = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tbtotAbo = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbTotCar = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTotXMl = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvXML = New System.Windows.Forms.DataGridView()
        Me.numero_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_cuenta = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cargo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.abono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.descripcion_asi = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.uuid = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_emisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcsmisor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.nombre_receptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rfcReceptor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.folio = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.tipo_comp = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgvPoliza, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvXML, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tbDes
        '
        Me.tbDes.Depth = 0
        Me.tbDes.Enabled = False
        Me.tbDes.Hint = ""
        Me.tbDes.Location = New System.Drawing.Point(432, 133)
        Me.tbDes.MaxLength = 32767
        Me.tbDes.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbDes.Name = "tbDes"
        Me.tbDes.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbDes.SelectedText = ""
        Me.tbDes.SelectionLength = 0
        Me.tbDes.SelectionStart = 0
        Me.tbDes.Size = New System.Drawing.Size(287, 23)
        Me.tbDes.TabIndex = 158
        Me.tbDes.TabStop = False
        Me.tbDes.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(333, 133)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel4.TabIndex = 162
        Me.MaterialLabel4.Text = "Descripción:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(573, 92)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(53, 19)
        Me.MaterialLabel3.TabIndex = 161
        Me.MaterialLabel3.Text = "Fecha:"
        '
        'dtpFecha
        '
        Me.dtpFecha.Enabled = False
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(632, 92)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(87, 20)
        Me.dtpFecha.TabIndex = 156
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 133)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(132, 19)
        Me.MaterialLabel2.TabIndex = 160
        Me.MaterialLabel2.Text = "Número de Poliza:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 92)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(132, 19)
        Me.MaterialLabel1.TabIndex = 159
        Me.MaterialLabel1.Text = "Nombre de Poliza:"
        '
        'tbNombrePol
        '
        Me.tbNombrePol.Depth = 0
        Me.tbNombrePol.Enabled = False
        Me.tbNombrePol.Hint = ""
        Me.tbNombrePol.Location = New System.Drawing.Point(154, 88)
        Me.tbNombrePol.MaxLength = 32767
        Me.tbNombrePol.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNombrePol.Name = "tbNombrePol"
        Me.tbNombrePol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNombrePol.SelectedText = ""
        Me.tbNombrePol.SelectionLength = 0
        Me.tbNombrePol.SelectionStart = 0
        Me.tbNombrePol.Size = New System.Drawing.Size(175, 23)
        Me.tbNombrePol.TabIndex = 163
        Me.tbNombrePol.TabStop = False
        Me.tbNombrePol.UseSystemPasswordChar = False
        '
        'tbNumPol
        '
        Me.tbNumPol.Depth = 0
        Me.tbNumPol.Enabled = False
        Me.tbNumPol.Hint = ""
        Me.tbNumPol.Location = New System.Drawing.Point(154, 133)
        Me.tbNumPol.MaxLength = 32767
        Me.tbNumPol.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNumPol.Name = "tbNumPol"
        Me.tbNumPol.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNumPol.SelectedText = ""
        Me.tbNumPol.SelectionLength = 0
        Me.tbNumPol.SelectionStart = 0
        Me.tbNumPol.Size = New System.Drawing.Size(175, 23)
        Me.tbNumPol.TabIndex = 164
        Me.tbNumPol.TabStop = False
        Me.tbNumPol.UseSystemPasswordChar = False
        '
        'dgvPoliza
        '
        Me.dgvPoliza.AllowUserToAddRows = False
        Me.dgvPoliza.AllowUserToDeleteRows = False
        Me.dgvPoliza.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPoliza.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvPoliza.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPoliza.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.numero_cuenta, Me.nombre_cuenta, Me.cargo, Me.abono, Me.descripcion_asi})
        Me.dgvPoliza.Location = New System.Drawing.Point(16, 173)
        Me.dgvPoliza.Name = "dgvPoliza"
        Me.dgvPoliza.ReadOnly = True
        Me.dgvPoliza.RowHeadersVisible = False
        Me.dgvPoliza.Size = New System.Drawing.Size(707, 176)
        Me.dgvPoliza.TabIndex = 165
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(353, 360)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 169
        Me.Label2.Text = "Cargo"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(537, 360)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 20)
        Me.Label1.TabIndex = 168
        Me.Label1.Text = "Abono"
        '
        'tbtotAbo
        '
        Me.tbtotAbo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbtotAbo.Depth = 0
        Me.tbtotAbo.Enabled = False
        Me.tbtotAbo.Hint = ""
        Me.tbtotAbo.Location = New System.Drawing.Point(604, 360)
        Me.tbtotAbo.MaxLength = 32767
        Me.tbtotAbo.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbtotAbo.Name = "tbtotAbo"
        Me.tbtotAbo.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbtotAbo.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbtotAbo.SelectedText = ""
        Me.tbtotAbo.SelectionLength = 0
        Me.tbtotAbo.SelectionStart = 0
        Me.tbtotAbo.Size = New System.Drawing.Size(115, 23)
        Me.tbtotAbo.TabIndex = 167
        Me.tbtotAbo.TabStop = False
        Me.tbtotAbo.Text = "0.00"
        Me.tbtotAbo.UseSystemPasswordChar = False
        '
        'tbTotCar
        '
        Me.tbTotCar.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotCar.Depth = 0
        Me.tbTotCar.Enabled = False
        Me.tbTotCar.Hint = ""
        Me.tbTotCar.Location = New System.Drawing.Point(416, 360)
        Me.tbTotCar.MaxLength = 32767
        Me.tbTotCar.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbTotCar.Name = "tbTotCar"
        Me.tbTotCar.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotCar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTotCar.SelectedText = ""
        Me.tbTotCar.SelectionLength = 0
        Me.tbTotCar.SelectionStart = 0
        Me.tbTotCar.Size = New System.Drawing.Size(115, 23)
        Me.tbTotCar.TabIndex = 166
        Me.tbTotCar.TabStop = False
        Me.tbTotCar.Text = "0.00"
        Me.tbTotCar.UseSystemPasswordChar = False
        '
        'Label3
        '
        Me.Label3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(508, 597)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 20)
        Me.Label3.TabIndex = 172
        Me.Label3.Text = "Total XML"
        '
        'tbTotXMl
        '
        Me.tbTotXMl.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTotXMl.Depth = 0
        Me.tbTotXMl.Enabled = False
        Me.tbTotXMl.Hint = ""
        Me.tbTotXMl.Location = New System.Drawing.Point(604, 596)
        Me.tbTotXMl.MaxLength = 32767
        Me.tbTotXMl.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbTotXMl.Name = "tbTotXMl"
        Me.tbTotXMl.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTotXMl.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbTotXMl.SelectedText = ""
        Me.tbTotXMl.SelectionLength = 0
        Me.tbTotXMl.SelectionStart = 0
        Me.tbTotXMl.Size = New System.Drawing.Size(115, 23)
        Me.tbTotXMl.TabIndex = 171
        Me.tbTotXMl.TabStop = False
        Me.tbTotXMl.UseSystemPasswordChar = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.dgvXML)
        Me.GroupBox1.Location = New System.Drawing.Point(16, 401)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(703, 180)
        Me.GroupBox1.TabIndex = 170
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "XML de la Poliza"
        '
        'dgvXML
        '
        Me.dgvXML.AllowUserToAddRows = False
        Me.dgvXML.AllowUserToDeleteRows = False
        Me.dgvXML.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvXML.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.dgvXML.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvXML.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.uuid, Me.nombre_emisor, Me.rfcsmisor, Me.nombre_receptor, Me.rfcReceptor, Me.folio, Me.fecha, Me.total, Me.tipo_comp})
        Me.dgvXML.Location = New System.Drawing.Point(10, 20)
        Me.dgvXML.Name = "dgvXML"
        Me.dgvXML.ReadOnly = True
        Me.dgvXML.RowHeadersVisible = False
        Me.dgvXML.Size = New System.Drawing.Size(690, 154)
        Me.dgvXML.TabIndex = 0
        '
        'numero_cuenta
        '
        Me.numero_cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.numero_cuenta.HeaderText = "Número de la Cuenta"
        Me.numero_cuenta.Name = "numero_cuenta"
        Me.numero_cuenta.ReadOnly = True
        '
        'nombre_cuenta
        '
        Me.nombre_cuenta.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.nombre_cuenta.HeaderText = "Nombre de la Cuenta"
        Me.nombre_cuenta.Name = "nombre_cuenta"
        Me.nombre_cuenta.ReadOnly = True
        '
        'cargo
        '
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle1.Format = "N2"
        DataGridViewCellStyle1.NullValue = "0.00"
        Me.cargo.DefaultCellStyle = DataGridViewCellStyle1
        Me.cargo.HeaderText = "Cargo"
        Me.cargo.Name = "cargo"
        Me.cargo.ReadOnly = True
        '
        'abono
        '
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle2.Format = "N2"
        DataGridViewCellStyle2.NullValue = "0.00"
        Me.abono.DefaultCellStyle = DataGridViewCellStyle2
        Me.abono.HeaderText = "Abono"
        Me.abono.Name = "abono"
        Me.abono.ReadOnly = True
        '
        'descripcion_asi
        '
        Me.descripcion_asi.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.descripcion_asi.HeaderText = "Descripcion del Asiento"
        Me.descripcion_asi.Name = "descripcion_asi"
        Me.descripcion_asi.ReadOnly = True
        '
        'uuid
        '
        Me.uuid.HeaderText = "UUID"
        Me.uuid.Name = "uuid"
        Me.uuid.ReadOnly = True
        '
        'nombre_emisor
        '
        Me.nombre_emisor.HeaderText = "Nombre del Emisor"
        Me.nombre_emisor.Name = "nombre_emisor"
        Me.nombre_emisor.ReadOnly = True
        '
        'rfcsmisor
        '
        Me.rfcsmisor.HeaderText = "RFC Emisor"
        Me.rfcsmisor.Name = "rfcsmisor"
        Me.rfcsmisor.ReadOnly = True
        '
        'nombre_receptor
        '
        Me.nombre_receptor.HeaderText = "Nombre Receptor"
        Me.nombre_receptor.Name = "nombre_receptor"
        Me.nombre_receptor.ReadOnly = True
        '
        'rfcReceptor
        '
        Me.rfcReceptor.HeaderText = "RFC Receptor"
        Me.rfcReceptor.Name = "rfcReceptor"
        Me.rfcReceptor.ReadOnly = True
        '
        'folio
        '
        Me.folio.HeaderText = "Folio"
        Me.folio.Name = "folio"
        Me.folio.ReadOnly = True
        '
        'fecha
        '
        Me.fecha.HeaderText = "Fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        '
        'total
        '
        Me.total.HeaderText = "Total"
        Me.total.Name = "total"
        Me.total.ReadOnly = True
        '
        'tipo_comp
        '
        Me.tipo_comp.HeaderText = "Tipo de Comprobante"
        Me.tipo_comp.Name = "tipo_comp"
        Me.tipo_comp.ReadOnly = True
        '
        'scrVerPoliza
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 631)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.tbTotXMl)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbtotAbo)
        Me.Controls.Add(Me.tbTotCar)
        Me.Controls.Add(Me.dgvPoliza)
        Me.Controls.Add(Me.tbNumPol)
        Me.Controls.Add(Me.tbNombrePol)
        Me.Controls.Add(Me.tbDes)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "scrVerPoliza"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ver Póliza"
        CType(Me.dgvPoliza, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvXML, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbDes As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbNombrePol As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbNumPol As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgvPoliza As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents tbtotAbo As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbTotCar As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Label3 As Label
    Friend WithEvents tbTotXMl As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvXML As DataGridView
    Friend WithEvents numero_cuenta As DataGridViewTextBoxColumn
    Friend WithEvents nombre_cuenta As DataGridViewTextBoxColumn
    Friend WithEvents cargo As DataGridViewTextBoxColumn
    Friend WithEvents abono As DataGridViewTextBoxColumn
    Friend WithEvents descripcion_asi As DataGridViewTextBoxColumn
    Friend WithEvents uuid As DataGridViewTextBoxColumn
    Friend WithEvents nombre_emisor As DataGridViewTextBoxColumn
    Friend WithEvents rfcsmisor As DataGridViewTextBoxColumn
    Friend WithEvents nombre_receptor As DataGridViewTextBoxColumn
    Friend WithEvents rfcReceptor As DataGridViewTextBoxColumn
    Friend WithEvents folio As DataGridViewTextBoxColumn
    Friend WithEvents fecha As DataGridViewTextBoxColumn
    Friend WithEvents total As DataGridViewTextBoxColumn
    Friend WithEvents tipo_comp As DataGridViewTextBoxColumn
End Class
