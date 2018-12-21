<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrOT_2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrOT_2))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnAgrega = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnGuarda = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardaAct = New System.Windows.Forms.ToolStripButton()
        Me.btnGenLay = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaLayout = New System.Windows.Forms.ToolStripButton()
        Me.btnImprime = New System.Windows.Forms.ToolStripButton()
        Me.btnEliminaOT = New System.Windows.Forms.ToolStripButton()
        Me.cbProyecto = New System.Windows.Forms.ComboBox()
        Me.cbCliente = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbUsuario = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbNumCot = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbSerie = New System.Windows.Forms.ComboBox()
        Me.tbFolio = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFen = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFechaE = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvPiezas = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsDetalle = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.ASIGNARTAREASToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EDITARDETALLEToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.tbUsuario = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgvExcel = New System.Windows.Forms.DataGridView()
        Me.UNIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DETALLE = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TRATAMIENTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OBSERVACIONES = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbOC = New System.Windows.Forms.TextBox()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbInfCNC = New System.Windows.Forms.TextBox()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbNotas = New System.Windows.Forms.RichTextBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.dgvPiezas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsDetalle.SuspendLayout()
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgrega, Me.btnEditar, Me.btnCancelaEdit, Me.btnGuarda, Me.btnGuardaAct, Me.btnGenLay, Me.btnCargaLayout, Me.btnImprime, Me.btnEliminaOT})
        Me.ToolStrip1.Location = New System.Drawing.Point(-3, 65)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1096, 25)
        Me.ToolStrip1.TabIndex = 10
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnAgrega
        '
        Me.btnAgrega.Image = CType(resources.GetObject("btnAgrega.Image"), System.Drawing.Image)
        Me.btnAgrega.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgrega.Name = "btnAgrega"
        Me.btnAgrega.Size = New System.Drawing.Size(110, 22)
        Me.btnAgrega.Text = "Agregar Unidad"
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 22)
        Me.btnEditar.Text = "Editar"
        Me.btnEditar.Visible = False
        '
        'btnCancelaEdit
        '
        Me.btnCancelaEdit.Image = CType(resources.GetObject("btnCancelaEdit.Image"), System.Drawing.Image)
        Me.btnCancelaEdit.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelaEdit.Name = "btnCancelaEdit"
        Me.btnCancelaEdit.Size = New System.Drawing.Size(115, 22)
        Me.btnCancelaEdit.Text = "Cancelar Edición"
        Me.btnCancelaEdit.Visible = False
        '
        'btnGuarda
        '
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(72, 22)
        Me.btnGuarda.Text = "Guardar "
        '
        'btnGuardaAct
        '
        Me.btnGuardaAct.Image = CType(resources.GetObject("btnGuardaAct.Image"), System.Drawing.Image)
        Me.btnGuardaAct.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardaAct.Name = "btnGuardaAct"
        Me.btnGuardaAct.Size = New System.Drawing.Size(133, 22)
        Me.btnGuardaAct.Text = "Guardar y Actualizar"
        Me.btnGuardaAct.Visible = False
        '
        'btnGenLay
        '
        Me.btnGenLay.Image = CType(resources.GetObject("btnGenLay.Image"), System.Drawing.Image)
        Me.btnGenLay.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGenLay.Name = "btnGenLay"
        Me.btnGenLay.Size = New System.Drawing.Size(107, 22)
        Me.btnGenLay.Text = "Generar Layout"
        '
        'btnCargaLayout
        '
        Me.btnCargaLayout.Image = CType(resources.GetObject("btnCargaLayout.Image"), System.Drawing.Image)
        Me.btnCargaLayout.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaLayout.Name = "btnCargaLayout"
        Me.btnCargaLayout.Size = New System.Drawing.Size(155, 22)
        Me.btnCargaLayout.Text = "Cargar Layout y Guardar"
        '
        'btnImprime
        '
        Me.btnImprime.Image = CType(resources.GetObject("btnImprime.Image"), System.Drawing.Image)
        Me.btnImprime.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnImprime.Name = "btnImprime"
        Me.btnImprime.Size = New System.Drawing.Size(73, 22)
        Me.btnImprime.Text = "Imprimir"
        Me.btnImprime.Visible = False
        '
        'btnEliminaOT
        '
        Me.btnEliminaOT.Image = CType(resources.GetObject("btnEliminaOT.Image"), System.Drawing.Image)
        Me.btnEliminaOT.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEliminaOT.Name = "btnEliminaOT"
        Me.btnEliminaOT.Size = New System.Drawing.Size(67, 22)
        Me.btnEliminaOT.Text = "Elminar"
        Me.btnEliminaOT.Visible = False
        '
        'cbProyecto
        '
        Me.cbProyecto.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbProyecto.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbProyecto.FormattingEnabled = True
        Me.cbProyecto.Location = New System.Drawing.Point(90, 135)
        Me.cbProyecto.Name = "cbProyecto"
        Me.cbProyecto.Size = New System.Drawing.Size(413, 21)
        Me.cbProyecto.TabIndex = 21
        '
        'cbCliente
        '
        Me.cbCliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbCliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbCliente.FormattingEnabled = True
        Me.cbCliente.Location = New System.Drawing.Point(90, 104)
        Me.cbCliente.Name = "cbCliente"
        Me.cbCliente.Size = New System.Drawing.Size(413, 21)
        Me.cbCliente.TabIndex = 20
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(12, 267)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(64, 19)
        Me.MaterialLabel8.TabIndex = 35
        Me.MaterialLabel8.Text = "Elabora:"
        '
        'cbUsuario
        '
        Me.cbUsuario.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append
        Me.cbUsuario.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cbUsuario.FormattingEnabled = True
        Me.cbUsuario.Location = New System.Drawing.Point(90, 167)
        Me.cbUsuario.Name = "cbUsuario"
        Me.cbUsuario.Size = New System.Drawing.Size(413, 21)
        Me.cbUsuario.TabIndex = 22
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(11, 166)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(65, 19)
        Me.MaterialLabel7.TabIndex = 34
        Me.MaterialLabel7.Text = "Usuario:"
        '
        'tbNumCot
        '
        Me.tbNumCot.Depth = 0
        Me.tbNumCot.Hint = ""
        Me.tbNumCot.Location = New System.Drawing.Point(742, 199)
        Me.tbNumCot.MaxLength = 32767
        Me.tbNumCot.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbNumCot.Name = "tbNumCot"
        Me.tbNumCot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbNumCot.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbNumCot.SelectedText = ""
        Me.tbNumCot.SelectionLength = 0
        Me.tbNumCot.SelectionStart = 0
        Me.tbNumCot.Size = New System.Drawing.Size(129, 23)
        Me.tbNumCot.TabIndex = 31
        Me.tbNumCot.TabStop = False
        Me.tbNumCot.UseSystemPasswordChar = False
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(566, 199)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(161, 19)
        Me.MaterialLabel6.TabIndex = 33
        Me.MaterialLabel6.Text = "Número de cotización:"
        '
        'cbSerie
        '
        Me.cbSerie.FormattingEnabled = True
        Me.cbSerie.Location = New System.Drawing.Point(645, 101)
        Me.cbSerie.Name = "cbSerie"
        Me.cbSerie.Size = New System.Drawing.Size(106, 21)
        Me.cbSerie.TabIndex = 26
        '
        'tbFolio
        '
        Me.tbFolio.Depth = 0
        Me.tbFolio.Hint = ""
        Me.tbFolio.Location = New System.Drawing.Point(758, 101)
        Me.tbFolio.MaxLength = 32767
        Me.tbFolio.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbFolio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbFolio.SelectedText = ""
        Me.tbFolio.SelectionLength = 0
        Me.tbFolio.SelectionStart = 0
        Me.tbFolio.Size = New System.Drawing.Size(129, 23)
        Me.tbFolio.TabIndex = 27
        Me.tbFolio.TabStop = False
        Me.tbFolio.UseSystemPasswordChar = False
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(566, 103)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel5.TabIndex = 32
        Me.MaterialLabel5.Text = "Serie:"
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(11, 134)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel4.TabIndex = 29
        Me.MaterialLabel4.Text = "Proyecto:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(11, 103)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel3.TabIndex = 25
        Me.MaterialLabel3.Text = "Cliente:"
        '
        'dtpFen
        '
        Me.dtpFen.CustomFormat = "dd/MMMM/yyyy"
        Me.dtpFen.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFen.Location = New System.Drawing.Point(742, 169)
        Me.dtpFen.Name = "dtpFen"
        Me.dtpFen.Size = New System.Drawing.Size(202, 20)
        Me.dtpFen.TabIndex = 30
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(566, 169)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(127, 19)
        Me.MaterialLabel2.TabIndex = 23
        Me.MaterialLabel2.Text = "Fecha de entrega:"
        '
        'dtpFechaE
        '
        Me.dtpFechaE.CustomFormat = "dd/MMMM/yyyy  "
        Me.dtpFechaE.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFechaE.Location = New System.Drawing.Point(742, 134)
        Me.dtpFechaE.Name = "dtpFechaE"
        Me.dtpFechaE.Size = New System.Drawing.Size(202, 20)
        Me.dtpFechaE.TabIndex = 28
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(566, 134)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(156, 19)
        Me.MaterialLabel1.TabIndex = 19
        Me.MaterialLabel1.Text = "Fecha de elaboración:"
        '
        'dgvPiezas
        '
        Me.dgvPiezas.AllowUserToAddRows = False
        Me.dgvPiezas.AllowUserToDeleteRows = False
        Me.dgvPiezas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPiezas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPiezas.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvPiezas.ContextMenuStrip = Me.cmsDetalle
        Me.dgvPiezas.Location = New System.Drawing.Point(15, 313)
        Me.dgvPiezas.Name = "dgvPiezas"
        Me.dgvPiezas.ReadOnly = True
        Me.dgvPiezas.Size = New System.Drawing.Size(1065, 273)
        Me.dgvPiezas.TabIndex = 36
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "UNIDAD"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column3.HeaderText = "DESCRIPCIÓN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        '
        'cmsDetalle
        '
        Me.cmsDetalle.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsDetalle.Depth = 0
        Me.cmsDetalle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ASIGNARTAREASToolStripMenuItem, Me.EDITARDETALLEToolStripMenuItem})
        Me.cmsDetalle.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmsDetalle.Name = "cmsDetalle"
        Me.cmsDetalle.Size = New System.Drawing.Size(168, 48)
        '
        'ASIGNARTAREASToolStripMenuItem
        '
        Me.ASIGNARTAREASToolStripMenuItem.Enabled = False
        Me.ASIGNARTAREASToolStripMenuItem.Name = "ASIGNARTAREASToolStripMenuItem"
        Me.ASIGNARTAREASToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.ASIGNARTAREASToolStripMenuItem.Text = "ASIGNAR TAREAS"
        '
        'EDITARDETALLEToolStripMenuItem
        '
        Me.EDITARDETALLEToolStripMenuItem.Name = "EDITARDETALLEToolStripMenuItem"
        Me.EDITARDETALLEToolStripMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.EDITARDETALLEToolStripMenuItem.Text = "DETALLE"
        '
        'tbUsuario
        '
        Me.tbUsuario.Depth = 0
        Me.tbUsuario.Hint = ""
        Me.tbUsuario.Location = New System.Drawing.Point(91, 266)
        Me.tbUsuario.MaxLength = 32767
        Me.tbUsuario.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbUsuario.Name = "tbUsuario"
        Me.tbUsuario.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbUsuario.SelectedText = ""
        Me.tbUsuario.SelectionLength = 0
        Me.tbUsuario.SelectionStart = 0
        Me.tbUsuario.Size = New System.Drawing.Size(413, 23)
        Me.tbUsuario.TabIndex = 37
        Me.tbUsuario.TabStop = False
        Me.tbUsuario.UseSystemPasswordChar = False
        '
        'dgvExcel
        '
        Me.dgvExcel.AllowUserToAddRows = False
        Me.dgvExcel.AllowUserToDeleteRows = False
        Me.dgvExcel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvExcel.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.UNIDAD, Me.DETALLE, Me.TRATAMIENTO, Me.CANTIDAD, Me.OBSERVACIONES})
        Me.dgvExcel.Location = New System.Drawing.Point(191, 343)
        Me.dgvExcel.Name = "dgvExcel"
        Me.dgvExcel.ReadOnly = True
        Me.dgvExcel.Size = New System.Drawing.Size(536, 150)
        Me.dgvExcel.TabIndex = 38
        Me.dgvExcel.Visible = False
        '
        'UNIDAD
        '
        Me.UNIDAD.HeaderText = "UNIDAD"
        Me.UNIDAD.Name = "UNIDAD"
        Me.UNIDAD.ReadOnly = True
        '
        'DETALLE
        '
        Me.DETALLE.HeaderText = "DETALLE"
        Me.DETALLE.Name = "DETALLE"
        Me.DETALLE.ReadOnly = True
        '
        'TRATAMIENTO
        '
        Me.TRATAMIENTO.HeaderText = "TRATAMIENTO"
        Me.TRATAMIENTO.Name = "TRATAMIENTO"
        Me.TRATAMIENTO.ReadOnly = True
        '
        'CANTIDAD
        '
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.ReadOnly = True
        '
        'OBSERVACIONES
        '
        Me.OBSERVACIONES.HeaderText = "OBSERVACIONES"
        Me.OBSERVACIONES.Name = "OBSERVACIONES"
        Me.OBSERVACIONES.ReadOnly = True
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(11, 199)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(129, 19)
        Me.MaterialLabel9.TabIndex = 39
        Me.MaterialLabel9.Text = "Orden de Compra:"
        '
        'tbOC
        '
        Me.tbOC.Location = New System.Drawing.Point(146, 198)
        Me.tbOC.Name = "tbOC"
        Me.tbOC.Size = New System.Drawing.Size(357, 20)
        Me.tbOC.TabIndex = 40
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(12, 231)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(149, 19)
        Me.MaterialLabel10.TabIndex = 41
        Me.MaterialLabel10.Text = "Información en CNC:"
        '
        'tbInfCNC
        '
        Me.tbInfCNC.Location = New System.Drawing.Point(167, 230)
        Me.tbInfCNC.Name = "tbInfCNC"
        Me.tbInfCNC.Size = New System.Drawing.Size(336, 20)
        Me.tbInfCNC.TabIndex = 42
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(566, 229)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(54, 19)
        Me.MaterialLabel11.TabIndex = 43
        Me.MaterialLabel11.Text = "Notas:"
        '
        'tbNotas
        '
        Me.tbNotas.Location = New System.Drawing.Point(626, 229)
        Me.tbNotas.Name = "tbNotas"
        Me.tbNotas.Size = New System.Drawing.Size(453, 78)
        Me.tbNotas.TabIndex = 44
        Me.tbNotas.Text = ""
        '
        'scrOT_2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1092, 598)
        Me.Controls.Add(Me.tbNotas)
        Me.Controls.Add(Me.MaterialLabel11)
        Me.Controls.Add(Me.tbInfCNC)
        Me.Controls.Add(Me.MaterialLabel10)
        Me.Controls.Add(Me.tbOC)
        Me.Controls.Add(Me.MaterialLabel9)
        Me.Controls.Add(Me.dgvExcel)
        Me.Controls.Add(Me.tbUsuario)
        Me.Controls.Add(Me.dgvPiezas)
        Me.Controls.Add(Me.cbProyecto)
        Me.Controls.Add(Me.cbCliente)
        Me.Controls.Add(Me.MaterialLabel8)
        Me.Controls.Add(Me.cbUsuario)
        Me.Controls.Add(Me.MaterialLabel7)
        Me.Controls.Add(Me.tbNumCot)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.cbSerie)
        Me.Controls.Add(Me.tbFolio)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.dtpFen)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.dtpFechaE)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "scrOT_2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Orden de Trabajo"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.dgvPiezas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsDetalle.ResumeLayout(False)
        CType(Me.dgvExcel, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnAgrega As ToolStripButton
    Friend WithEvents btnGuarda As ToolStripButton
    Friend WithEvents cbProyecto As ComboBox
    Friend WithEvents cbCliente As ComboBox
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbUsuario As ComboBox
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbNumCot As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbSerie As ComboBox
    Friend WithEvents tbFolio As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFen As DateTimePicker
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFechaE As DateTimePicker
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvPiezas As DataGridView
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents cmsDetalle As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents EDITARDETALLEToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ASIGNARTAREASToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tbUsuario As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents btnGuardaAct As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnCancelaEdit As ToolStripButton
    Friend WithEvents btnGenLay As ToolStripButton
    Friend WithEvents btnCargaLayout As ToolStripButton
    Friend WithEvents dgvExcel As DataGridView
    Friend WithEvents UNIDAD As DataGridViewTextBoxColumn
    Friend WithEvents DETALLE As DataGridViewTextBoxColumn
    Friend WithEvents TRATAMIENTO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents OBSERVACIONES As DataGridViewTextBoxColumn
    Friend WithEvents btnImprime As ToolStripButton
    Friend WithEvents btnEliminaOT As ToolStripButton
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbOC As TextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbInfCNC As TextBox
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbNotas As RichTextBox
End Class
