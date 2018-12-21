<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrOT
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrOT))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFechaE = New System.Windows.Forms.DateTimePicker()
        Me.dtpFen = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbFolio = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.cbSerie = New System.Windows.Forms.ComboBox()
        Me.dgvPiezas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAgrega = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbNumCot = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbElabora = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.cbProyecto = New System.Windows.Forms.ComboBox()
        CType(Me.dgvPiezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(567, 129)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(156, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Fecha de elaboración:"
        '
        'dtpFechaE
        '
        Me.dtpFechaE.CustomFormat = "dd/MMMM/yyyy  "
        Me.dtpFechaE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaE.Location = New System.Drawing.Point(743, 129)
        Me.dtpFechaE.Name = "dtpFechaE"
        Me.dtpFechaE.Size = New System.Drawing.Size(202, 20)
        Me.dtpFechaE.TabIndex = 6
        '
        'dtpFen
        '
        Me.dtpFen.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFen.Location = New System.Drawing.Point(743, 164)
        Me.dtpFen.Name = "dtpFen"
        Me.dtpFen.Size = New System.Drawing.Size(202, 20)
        Me.dtpFen.TabIndex = 7
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(567, 164)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(127, 19)
        Me.MaterialLabel2.TabIndex = 2
        Me.MaterialLabel2.Text = "Fecha de entrega:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 98)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel3.TabIndex = 4
        Me.MaterialLabel3.Text = "Cliente:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(12, 129)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel4.TabIndex = 6
        Me.MaterialLabel4.Text = "Proyecto:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(567, 98)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel5.TabIndex = 8
        Me.MaterialLabel5.Text = "Serie:"
        '
        'tbFolio
        '
        Me.tbFolio.Depth = 0
        Me.tbFolio.Hint = ""
        Me.tbFolio.Location = New System.Drawing.Point(759, 96)
        Me.tbFolio.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFolio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbFolio.SelectedText = ""
        Me.tbFolio.SelectionLength = 0
        Me.tbFolio.SelectionStart = 0
        Me.tbFolio.Size = New System.Drawing.Size(129, 23)
        Me.tbFolio.TabIndex = 5
        Me.tbFolio.TabStop = False
        Me.tbFolio.UseSystemPasswordChar = False
        '
        'cbSerie
        '
        Me.cbSerie.FormattingEnabled = True
        Me.cbSerie.Location = New System.Drawing.Point(646, 96)
        Me.cbSerie.Name = "cbSerie"
        Me.cbSerie.Size = New System.Drawing.Size(106, 21)
        Me.cbSerie.TabIndex = 4
        '
        'dgvPiezas
        '
        Me.dgvPiezas.AllowUserToAddRows = False
        Me.dgvPiezas.AllowUserToDeleteRows = False
        Me.dgvPiezas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPiezas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6})
        Me.dgvPiezas.Location = New System.Drawing.Point(16, 240)
        Me.dgvPiezas.Name = "dgvPiezas"
        Me.dgvPiezas.ReadOnly = True
        Me.dgvPiezas.Size = New System.Drawing.Size(935, 262)
        Me.dgvPiezas.TabIndex = 11
        '
        'Column1
        '
        Me.Column1.HeaderText = "Item"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "No. Dibujo/MRO"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "Qty"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'Column4
        '
        Me.Column4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column4.HeaderText = "Observaciones"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "Tratamiento"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Visible = False
        '
        'Column6
        '
        Me.Column6.HeaderText = "id_pdf"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        Me.Column6.Visible = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgrega, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(-1, 61)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(979, 25)
        Me.ToolStrip1.TabIndex = 9
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAgrega
        '
        Me.btnAgrega.Image = CType(resources.GetObject("btnAgrega.Image"), System.Drawing.Image)
        Me.btnAgrega.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgrega.Name = "btnAgrega"
        Me.btnAgrega.Size = New System.Drawing.Size(69, 22)
        Me.btnAgrega.Text = "Agregar"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(72, 22)
        Me.ToolStripButton1.Text = "Guardar "
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(567, 194)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(161, 19)
        Me.MaterialLabel6.TabIndex = 14
        Me.MaterialLabel6.Text = "Número de cotización:"
        '
        'tbNumCot
        '
        Me.tbNumCot.Depth = 0
        Me.tbNumCot.Hint = ""
        Me.tbNumCot.Location = New System.Drawing.Point(743, 194)
        Me.tbNumCot.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNumCot.Name = "tbNumCot"
        Me.tbNumCot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNumCot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbNumCot.SelectedText = ""
        Me.tbNumCot.SelectionLength = 0
        Me.tbNumCot.SelectionStart = 0
        Me.tbNumCot.Size = New System.Drawing.Size(129, 23)
        Me.tbNumCot.TabIndex = 8
        Me.tbNumCot.TabStop = False
        Me.tbNumCot.UseSystemPasswordChar = False
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(12, 161)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel7.TabIndex = 16
        Me.MaterialLabel7.Text = "Usuario:"
        '
        'cbUsuario
        '
        Me.cbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(91, 162)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(413, 21)
        Me.cbUsuario.TabIndex = 2
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(12, 195)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(64, 19)
        Me.MaterialLabel8.TabIndex = 18
        Me.MaterialLabel8.Text = "Elabora:"
        '
        'cbElabora
        '
        Me.cbElabora.FormattingEnabled = True
        Me.cbElabora.Location = New System.Drawing.Point(91, 195)
        Me.cbElabora.Name = "cbElabora"
        Me.cbElabora.Size = New System.Drawing.Size(413, 21)
        Me.cbElabora.TabIndex = 3
        '
        'cbCliente
        '
        Me.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(91, 99)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(413, 21)
        Me.cbCliente.TabIndex = 0
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbProyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProyecto.FormattingEnabled = True
        Me.cbProyecto.Location = New System.Drawing.Point(91, 130)
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.Size = New System.Drawing.Size(413, 21)
        Me.cbProyecto.TabIndex = 1
        '
        'scrOT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(976, 522)
        Me.Controls.Add(Me.cbProyecto)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.cbElabora)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.tbNumCot)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.dgvPiezas)
        Me.Controls.Add(Me.cbSerie)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.dtpFen)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.dtpFechaE)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "scrOT"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Trabajo"
        CType(Me.dgvPiezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFechaE As DateTimePicker
    Friend WithEvents dtpFen As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbFolio As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents cbSerie As ComboBox
    Friend WithEvents dgvPiezas As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents btnAgrega As ToolStripButton
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbNumCot As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbElabora As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents cbProyecto As ComboBox
End Class
