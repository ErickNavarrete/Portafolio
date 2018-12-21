<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrAgregarProceso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrAgregarProceso))
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.PIEZAS = New System.Windows.Forms.TabPage()
        Me.tbObserva = New System.Windows.Forms.TextBox()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.tbTratamiento = New System.Windows.Forms.TextBox()
        Me.tbNum = New System.Windows.Forms.TextBox()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel7 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbFolio = New System.Windows.Forms.TextBox()
        Me.tbSerie = New System.Windows.Forms.TextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbCliente = New System.Windows.Forms.TextBox()
        Me.tbProyecto = New System.Windows.Forms.TextBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.lvPiezas = New System.Windows.Forms.ListView()
        Me.MRO = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGuarda = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEd = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.tbHoras = New System.Windows.Forms.TextBox()
        Me.MaterialLabel12 = New MaterialSkin.Controls.MaterialLabel()
        Me.dgvEstacion = New System.Windows.Forms.DataGridView()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MaterialLabel11 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAgreaPro = New System.Windows.Forms.ToolStripButton()
        Me.dgvPP = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cmsProceso = New MaterialSkin.Controls.MaterialContextMenuStrip()
        Me.EliminarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.btnAgregaP = New System.Windows.Forms.Button()
        Me.rtbObservacion = New System.Windows.Forms.RichTextBox()
        Me.MaterialLabel10 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpFecha_Cliente = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel9 = New MaterialSkin.Controls.MaterialLabel()
        Me.dtpF_Interna = New System.Windows.Forms.DateTimePicker()
        Me.MaterialLabel8 = New MaterialSkin.Controls.MaterialLabel()
        Me.lvProcesos = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1.SuspendLayout()
        Me.PIEZAS.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEstacion, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        CType(Me.dgvPP, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.cmsProceso.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.PIEZAS)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(-4, 95)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(970, 674)
        Me.MaterialTabControl1.TabIndex = 18
        '
        'PIEZAS
        '
        Me.PIEZAS.Controls.Add(Me.tbObserva)
        Me.PIEZAS.Controls.Add(Me.tbCantidad)
        Me.PIEZAS.Controls.Add(Me.tbTratamiento)
        Me.PIEZAS.Controls.Add(Me.tbNum)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel4)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel5)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel6)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel7)
        Me.PIEZAS.Controls.Add(Me.tbFolio)
        Me.PIEZAS.Controls.Add(Me.tbSerie)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel3)
        Me.PIEZAS.Controls.Add(Me.tbCliente)
        Me.PIEZAS.Controls.Add(Me.tbProyecto)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel2)
        Me.PIEZAS.Controls.Add(Me.MaterialLabel1)
        Me.PIEZAS.Controls.Add(Me.lvPiezas)
        Me.PIEZAS.Controls.Add(Me.ToolStrip1)
        Me.PIEZAS.Location = New System.Drawing.Point(4, 22)
        Me.PIEZAS.Name = "PIEZAS"
        Me.PIEZAS.Padding = New System.Windows.Forms.Padding(3)
        Me.PIEZAS.Size = New System.Drawing.Size(962, 648)
        Me.PIEZAS.TabIndex = 0
        Me.PIEZAS.Text = "PIEZAS"
        Me.PIEZAS.UseVisualStyleBackColor = True
        '
        'tbObserva
        '
        Me.tbObserva.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbObserva.Location = New System.Drawing.Point(563, 378)
        Me.tbObserva.Name = "tbObserva"
        Me.tbObserva.ReadOnly = True
        Me.tbObserva.Size = New System.Drawing.Size(321, 20)
        Me.tbObserva.TabIndex = 43
        '
        'tbCantidad
        '
        Me.tbCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCantidad.Location = New System.Drawing.Point(563, 307)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.ReadOnly = True
        Me.tbCantidad.Size = New System.Drawing.Size(321, 20)
        Me.tbCantidad.TabIndex = 42
        Me.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbTratamiento
        '
        Me.tbTratamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbTratamiento.Location = New System.Drawing.Point(563, 237)
        Me.tbTratamiento.Name = "tbTratamiento"
        Me.tbTratamiento.ReadOnly = True
        Me.tbTratamiento.Size = New System.Drawing.Size(321, 20)
        Me.tbTratamiento.TabIndex = 41
        '
        'tbNum
        '
        Me.tbNum.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbNum.Location = New System.Drawing.Point(563, 173)
        Me.tbNum.Name = "tbNum"
        Me.tbNum.ReadOnly = True
        Me.tbNum.Size = New System.Drawing.Size(321, 20)
        Me.tbNum.TabIndex = 40
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(435, 377)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel4.TabIndex = 39
        Me.MaterialLabel4.Text = "Observaciones:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(435, 308)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel5.TabIndex = 38
        Me.MaterialLabel5.Text = "Cantidad:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(435, 236)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(95, 19)
        Me.MaterialLabel6.TabIndex = 37
        Me.MaterialLabel6.Text = "Tratamiento:"
        '
        'MaterialLabel7
        '
        Me.MaterialLabel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel7.AutoSize = True
        Me.MaterialLabel7.Depth = 0
        Me.MaterialLabel7.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel7.Location = New System.Drawing.Point(435, 174)
        Me.MaterialLabel7.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel7.Name = "MaterialLabel7"
        Me.MaterialLabel7.Size = New System.Drawing.Size(122, 19)
        Me.MaterialLabel7.TabIndex = 36
        Me.MaterialLabel7.Text = "No. Dibujo/MRO:"
        '
        'tbFolio
        '
        Me.tbFolio.Location = New System.Drawing.Point(645, 42)
        Me.tbFolio.Name = "tbFolio"
        Me.tbFolio.ReadOnly = True
        Me.tbFolio.Size = New System.Drawing.Size(128, 20)
        Me.tbFolio.TabIndex = 35
        '
        'tbSerie
        '
        Me.tbSerie.Location = New System.Drawing.Point(511, 41)
        Me.tbSerie.Name = "tbSerie"
        Me.tbSerie.ReadOnly = True
        Me.tbSerie.Size = New System.Drawing.Size(128, 20)
        Me.tbSerie.TabIndex = 34
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(458, 39)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(47, 19)
        Me.MaterialLabel3.TabIndex = 33
        Me.MaterialLabel3.Text = "Serie:"
        '
        'tbCliente
        '
        Me.tbCliente.Location = New System.Drawing.Point(88, 79)
        Me.tbCliente.Name = "tbCliente"
        Me.tbCliente.ReadOnly = True
        Me.tbCliente.Size = New System.Drawing.Size(321, 20)
        Me.tbCliente.TabIndex = 32
        '
        'tbProyecto
        '
        Me.tbProyecto.Location = New System.Drawing.Point(88, 40)
        Me.tbProyecto.Name = "tbProyecto"
        Me.tbProyecto.ReadOnly = True
        Me.tbProyecto.Size = New System.Drawing.Size(321, 20)
        Me.tbProyecto.TabIndex = 31
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(8, 78)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel2.TabIndex = 30
        Me.MaterialLabel2.Text = "Cliente:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(8, 42)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(73, 19)
        Me.MaterialLabel1.TabIndex = 29
        Me.MaterialLabel1.Text = "Proyecto:"
        '
        'lvPiezas
        '
        Me.lvPiezas.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvPiezas.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.MRO, Me.ID})
        Me.lvPiezas.Font = New System.Drawing.Font("Segoe UI Symbol", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvPiezas.Location = New System.Drawing.Point(12, 146)
        Me.lvPiezas.Name = "lvPiezas"
        Me.lvPiezas.Size = New System.Drawing.Size(417, 496)
        Me.lvPiezas.TabIndex = 27
        Me.lvPiezas.UseCompatibleStateImageBehavior = False
        Me.lvPiezas.View = System.Windows.Forms.View.Details
        '
        'MRO
        '
        Me.MRO.Text = "MRO"
        Me.MRO.Width = 400
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 0
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuarda, Me.btnEditar, Me.btnCancelaEd})
        Me.ToolStrip1.Location = New System.Drawing.Point(5, 6)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(919, 25)
        Me.ToolStrip1.TabIndex = 28
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGuarda
        '
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(69, 22)
        Me.btnGuarda.Text = "Guardar"
        Me.btnGuarda.Visible = False
        '
        'btnEditar
        '
        Me.btnEditar.Image = CType(resources.GetObject("btnEditar.Image"), System.Drawing.Image)
        Me.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEditar.Name = "btnEditar"
        Me.btnEditar.Size = New System.Drawing.Size(57, 22)
        Me.btnEditar.Text = "Editar"
        '
        'btnCancelaEd
        '
        Me.btnCancelaEd.Image = CType(resources.GetObject("btnCancelaEd.Image"), System.Drawing.Image)
        Me.btnCancelaEd.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCancelaEd.Name = "btnCancelaEd"
        Me.btnCancelaEd.Size = New System.Drawing.Size(115, 22)
        Me.btnCancelaEd.Text = "Cancelar Edición"
        Me.btnCancelaEd.Visible = False
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.tbHoras)
        Me.TabPage2.Controls.Add(Me.MaterialLabel12)
        Me.TabPage2.Controls.Add(Me.dgvEstacion)
        Me.TabPage2.Controls.Add(Me.MaterialLabel11)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Controls.Add(Me.dgvPP)
        Me.TabPage2.Controls.Add(Me.btnAgregaP)
        Me.TabPage2.Controls.Add(Me.rtbObservacion)
        Me.TabPage2.Controls.Add(Me.MaterialLabel10)
        Me.TabPage2.Controls.Add(Me.dtpFecha_Cliente)
        Me.TabPage2.Controls.Add(Me.MaterialLabel9)
        Me.TabPage2.Controls.Add(Me.dtpF_Interna)
        Me.TabPage2.Controls.Add(Me.MaterialLabel8)
        Me.TabPage2.Controls.Add(Me.lvProcesos)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(962, 648)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "PROCESOS"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'tbHoras
        '
        Me.tbHoras.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbHoras.Location = New System.Drawing.Point(309, 362)
        Me.tbHoras.Name = "tbHoras"
        Me.tbHoras.Size = New System.Drawing.Size(335, 22)
        Me.tbHoras.TabIndex = 43
        Me.tbHoras.Text = "0"
        Me.tbHoras.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'MaterialLabel12
        '
        Me.MaterialLabel12.AutoSize = True
        Me.MaterialLabel12.Depth = 0
        Me.MaterialLabel12.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel12.Location = New System.Drawing.Point(305, 340)
        Me.MaterialLabel12.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel12.Name = "MaterialLabel12"
        Me.MaterialLabel12.Size = New System.Drawing.Size(54, 19)
        Me.MaterialLabel12.TabIndex = 42
        Me.MaterialLabel12.Text = "Horas:"
        '
        'dgvEstacion
        '
        Me.dgvEstacion.AllowUserToAddRows = False
        Me.dgvEstacion.AllowUserToDeleteRows = False
        Me.dgvEstacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstacion.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column9, Me.Column8, Me.Column10})
        Me.dgvEstacion.Location = New System.Drawing.Point(309, 199)
        Me.dgvEstacion.Name = "dgvEstacion"
        Me.dgvEstacion.ReadOnly = True
        Me.dgvEstacion.Size = New System.Drawing.Size(335, 120)
        Me.dgvEstacion.TabIndex = 41
        '
        'Column9
        '
        Me.Column9.HeaderText = "id_estacion"
        Me.Column9.Name = "Column9"
        Me.Column9.ReadOnly = True
        Me.Column9.Visible = False
        Me.Column9.Width = 10
        '
        'Column8
        '
        Me.Column8.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column8.HeaderText = "ESTACIONES"
        Me.Column8.Name = "Column8"
        Me.Column8.ReadOnly = True
        '
        'Column10
        '
        Me.Column10.HeaderText = "USAR"
        Me.Column10.Name = "Column10"
        Me.Column10.ReadOnly = True
        Me.Column10.Width = 40
        '
        'MaterialLabel11
        '
        Me.MaterialLabel11.AutoSize = True
        Me.MaterialLabel11.Depth = 0
        Me.MaterialLabel11.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel11.Location = New System.Drawing.Point(305, 177)
        Me.MaterialLabel11.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel11.Name = "MaterialLabel11"
        Me.MaterialLabel11.Size = New System.Drawing.Size(147, 19)
        Me.MaterialLabel11.TabIndex = 40
        Me.MaterialLabel11.Text = "Estación de Trabajo:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgreaPro})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(954, 25)
        Me.ToolStrip2.TabIndex = 39
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAgreaPro
        '
        Me.btnAgreaPro.ForeColor = System.Drawing.Color.Black
        Me.btnAgreaPro.Image = CType(resources.GetObject("btnAgreaPro.Image"), System.Drawing.Image)
        Me.btnAgreaPro.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgreaPro.Name = "btnAgreaPro"
        Me.btnAgreaPro.Size = New System.Drawing.Size(114, 22)
        Me.btnAgreaPro.Text = "Agregar Proceso"
        '
        'dgvPP
        '
        Me.dgvPP.AllowUserToAddRows = False
        Me.dgvPP.AllowUserToDeleteRows = False
        Me.dgvPP.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvPP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPP.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column7, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column11, Me.Column12, Me.Column13})
        Me.dgvPP.ContextMenuStrip = Me.cmsProceso
        Me.dgvPP.Location = New System.Drawing.Point(680, 61)
        Me.dgvPP.Name = "dgvPP"
        Me.dgvPP.ReadOnly = True
        Me.dgvPP.Size = New System.Drawing.Size(286, 591)
        Me.dgvPP.TabIndex = 38
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_proceso"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.HeaderText = "id_pieza"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Visible = False
        '
        'Column7
        '
        Me.Column7.HeaderText = "NÚMERO PROCESO"
        Me.Column7.Name = "Column7"
        Me.Column7.ReadOnly = True
        '
        'Column3
        '
        Me.Column3.HeaderText = "PROCESO"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 250
        '
        'Column4
        '
        Me.Column4.HeaderText = "FECHA INTERNA"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        Me.Column4.Width = 150
        '
        'Column5
        '
        Me.Column5.HeaderText = "FECHA CLIENTE"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        Me.Column5.Width = 150
        '
        'Column6
        '
        Me.Column6.HeaderText = "OBSERVACIONES"
        Me.Column6.Name = "Column6"
        Me.Column6.ReadOnly = True
        '
        'Column11
        '
        Me.Column11.HeaderText = "id_estacion"
        Me.Column11.Name = "Column11"
        Me.Column11.ReadOnly = True
        Me.Column11.Visible = False
        '
        'Column12
        '
        Me.Column12.HeaderText = "ESTACIÓN"
        Me.Column12.Name = "Column12"
        Me.Column12.ReadOnly = True
        '
        'Column13
        '
        Me.Column13.HeaderText = "HORAS"
        Me.Column13.Name = "Column13"
        Me.Column13.ReadOnly = True
        '
        'cmsProceso
        '
        Me.cmsProceso.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmsProceso.Depth = 0
        Me.cmsProceso.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EliminarToolStripMenuItem})
        Me.cmsProceso.MouseState = MaterialSkin.MouseState.HOVER
        Me.cmsProceso.Name = "cmsProceso"
        Me.cmsProceso.Size = New System.Drawing.Size(128, 26)
        '
        'EliminarToolStripMenuItem
        '
        Me.EliminarToolStripMenuItem.Name = "EliminarToolStripMenuItem"
        Me.EliminarToolStripMenuItem.Size = New System.Drawing.Size(127, 22)
        Me.EliminarToolStripMenuItem.Text = "ELIMINAR"
        '
        'btnAgregaP
        '
        Me.btnAgregaP.Enabled = False
        Me.btnAgregaP.Location = New System.Drawing.Point(439, 549)
        Me.btnAgregaP.Name = "btnAgregaP"
        Me.btnAgregaP.Size = New System.Drawing.Size(75, 23)
        Me.btnAgregaP.TabIndex = 37
        Me.btnAgregaP.Text = "Agregar"
        Me.btnAgregaP.UseVisualStyleBackColor = True
        '
        'rtbObservacion
        '
        Me.rtbObservacion.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rtbObservacion.Location = New System.Drawing.Point(309, 431)
        Me.rtbObservacion.Name = "rtbObservacion"
        Me.rtbObservacion.Size = New System.Drawing.Size(335, 96)
        Me.rtbObservacion.TabIndex = 35
        Me.rtbObservacion.Text = ""
        '
        'MaterialLabel10
        '
        Me.MaterialLabel10.AutoSize = True
        Me.MaterialLabel10.Depth = 0
        Me.MaterialLabel10.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel10.Location = New System.Drawing.Point(305, 400)
        Me.MaterialLabel10.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel10.Name = "MaterialLabel10"
        Me.MaterialLabel10.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel10.TabIndex = 34
        Me.MaterialLabel10.Text = "Observaciones:"
        '
        'dtpFecha_Cliente
        '
        Me.dtpFecha_Cliente.CustomFormat = "dd/MMMM/yyyy    hh:mm:ss   tt "
        Me.dtpFecha_Cliente.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha_Cliente.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpFecha_Cliente.Location = New System.Drawing.Point(309, 131)
        Me.dtpFecha_Cliente.Name = "dtpFecha_Cliente"
        Me.dtpFecha_Cliente.Size = New System.Drawing.Size(335, 22)
        Me.dtpFecha_Cliente.TabIndex = 33
        '
        'MaterialLabel9
        '
        Me.MaterialLabel9.AutoSize = True
        Me.MaterialLabel9.Depth = 0
        Me.MaterialLabel9.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel9.Location = New System.Drawing.Point(305, 108)
        Me.MaterialLabel9.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel9.Name = "MaterialLabel9"
        Me.MaterialLabel9.Size = New System.Drawing.Size(179, 19)
        Me.MaterialLabel9.TabIndex = 32
        Me.MaterialLabel9.Text = "Fecha de Entrega Cliente:"
        '
        'dtpF_Interna
        '
        Me.dtpF_Interna.CustomFormat = "dd/MMMM/yyyy    hh:mm:ss  tt  "
        Me.dtpF_Interna.Font = New System.Drawing.Font("Segoe UI Symbol", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpF_Interna.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpF_Interna.Location = New System.Drawing.Point(309, 71)
        Me.dtpF_Interna.Name = "dtpF_Interna"
        Me.dtpF_Interna.Size = New System.Drawing.Size(335, 22)
        Me.dtpF_Interna.TabIndex = 31
        '
        'MaterialLabel8
        '
        Me.MaterialLabel8.AutoSize = True
        Me.MaterialLabel8.Depth = 0
        Me.MaterialLabel8.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel8.Location = New System.Drawing.Point(305, 48)
        Me.MaterialLabel8.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel8.Name = "MaterialLabel8"
        Me.MaterialLabel8.Size = New System.Drawing.Size(178, 19)
        Me.MaterialLabel8.TabIndex = 30
        Me.MaterialLabel8.Text = "Fecha de Entrega Interna:"
        '
        'lvProcesos
        '
        Me.lvProcesos.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lvProcesos.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1})
        Me.lvProcesos.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProcesos.Location = New System.Drawing.Point(12, 48)
        Me.lvProcesos.Name = "lvProcesos"
        Me.lvProcesos.Size = New System.Drawing.Size(270, 594)
        Me.lvProcesos.TabIndex = 0
        Me.lvProcesos.UseCompatibleStateImageBehavior = False
        Me.lvProcesos.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "PROCESOS"
        Me.ColumnHeader1.Width = 300
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.AxAcroPDF1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Size = New System.Drawing.Size(962, 648)
        Me.TabPage1.TabIndex = 2
        Me.TabPage1.Text = "PDF"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(12, 13)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(904, 629)
        Me.AxAcroPDF1.TabIndex = 0
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-4, 63)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(982, 35)
        Me.MaterialTabSelector1.TabIndex = 19
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'scrAgregarProceso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(966, 771)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "scrAgregarProceso"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Agregar Proceso"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.PIEZAS.ResumeLayout(False)
        Me.PIEZAS.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvEstacion, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        CType(Me.dgvPP, System.ComponentModel.ISupportInitialize).EndInit()
        Me.cmsProceso.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents PIEZAS As TabPage
    Friend WithEvents lvPiezas As ListView
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents tbFolio As TextBox
    Friend WithEvents tbSerie As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbCliente As TextBox
    Friend WithEvents tbProyecto As TextBox
    Friend WithEvents tbObserva As TextBox
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents tbTratamiento As TextBox
    Friend WithEvents tbNum As TextBox
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel7 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MRO As ColumnHeader
    Public WithEvents ID As ColumnHeader
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents rtbObservacion As RichTextBox
    Friend WithEvents MaterialLabel10 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpFecha_Cliente As DateTimePicker
    Friend WithEvents MaterialLabel9 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dtpF_Interna As DateTimePicker
    Friend WithEvents MaterialLabel8 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents lvProcesos As ListView
    Friend WithEvents btnAgregaP As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents dgvPP As DataGridView
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGuarda As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btnAgreaPro As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnCancelaEd As ToolStripButton
    Friend WithEvents MaterialLabel11 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvEstacion As DataGridView
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewCheckBoxColumn
    Friend WithEvents cmsProceso As MaterialSkin.Controls.MaterialContextMenuStrip
    Friend WithEvents EliminarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaterialLabel12 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbHoras As TextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
End Class
