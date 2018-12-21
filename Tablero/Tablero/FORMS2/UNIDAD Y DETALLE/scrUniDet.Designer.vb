<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrUniDet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrUniDet))
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.dgvUnidad = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnNuevo = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaU = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardaA = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEdit = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.rtbTratamiento = New System.Windows.Forms.RichTextBox()
        Me.rtbObservacion = New System.Windows.Forms.RichTextBox()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.tbMRO = New System.Windows.Forms.TextBox()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.btnAgregaDetalle = New System.Windows.Forms.ToolStripButton()
        Me.btnGeneraCB = New System.Windows.Forms.ToolStripButton()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.btnNuevo.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-1, 60)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(896, 27)
        Me.MaterialTabSelector1.TabIndex = 0
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(-1, 93)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(896, 698)
        Me.MaterialTabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.dgvUnidad)
        Me.TabPage1.Controls.Add(Me.rtbDescripcion)
        Me.TabPage1.Controls.Add(Me.Label2)
        Me.TabPage1.Controls.Add(Me.tbClave)
        Me.TabPage1.Controls.Add(Me.Label1)
        Me.TabPage1.Controls.Add(Me.btnNuevo)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(888, 670)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Unidad"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'dgvUnidad
        '
        Me.dgvUnidad.AllowUserToAddRows = False
        Me.dgvUnidad.AllowUserToDeleteRows = False
        Me.dgvUnidad.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUnidad.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvUnidad.Location = New System.Drawing.Point(9, 31)
        Me.dgvUnidad.Name = "dgvUnidad"
        Me.dgvUnidad.ReadOnly = True
        Me.dgvUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnidad.Size = New System.Drawing.Size(410, 633)
        Me.dgvUnidad.TabIndex = 6
        '
        'Column1
        '
        Me.Column1.HeaderText = "°-"
        Me.Column1.Name = "Column1"
        Me.Column1.ReadOnly = True
        Me.Column1.Width = 50
        '
        'Column2
        '
        Me.Column2.HeaderText = "CLAVE"
        Me.Column2.Name = "Column2"
        Me.Column2.ReadOnly = True
        Me.Column2.Width = 150
        '
        'Column3
        '
        Me.Column3.HeaderText = "DESCRIPCIÓN"
        Me.Column3.Name = "Column3"
        Me.Column3.ReadOnly = True
        Me.Column3.Width = 300
        '
        'rtbDescripcion
        '
        Me.rtbDescripcion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbDescripcion.Enabled = False
        Me.rtbDescripcion.Location = New System.Drawing.Point(441, 200)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(416, 113)
        Me.rtbDescripcion.TabIndex = 5
        Me.rtbDescripcion.Text = ""
        '
        'Label2
        '
        Me.Label2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(437, 176)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(94, 21)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Descripción:"
        '
        'tbClave
        '
        Me.tbClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbClave.Enabled = False
        Me.tbClave.Location = New System.Drawing.Point(441, 131)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(416, 23)
        Me.tbClave.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Symbol", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(437, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 21)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Clave:"
        '
        'btnNuevo
        '
        Me.btnNuevo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaU, Me.btnGuardar, Me.btnGuardaA, Me.btnEditar, Me.btnCancelaEdit})
        Me.btnNuevo.Location = New System.Drawing.Point(3, 3)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(882, 25)
        Me.btnNuevo.TabIndex = 0
        Me.btnNuevo.Text = "ToolStrip1"
        '
        'btnNuevaU
        '
        Me.btnNuevaU.Image = CType(resources.GetObject("btnNuevaU.Image"), System.Drawing.Image)
        Me.btnNuevaU.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevaU.Name = "btnNuevaU"
        Me.btnNuevaU.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevaU.Text = "Nuevo"
        '
        'btnGuardar
        '
        Me.btnGuardar.Image = CType(resources.GetObject("btnGuardar.Image"), System.Drawing.Image)
        Me.btnGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardar.Name = "btnGuardar"
        Me.btnGuardar.Size = New System.Drawing.Size(69, 22)
        Me.btnGuardar.Text = "Guardar"
        Me.btnGuardar.Visible = False
        '
        'btnGuardaA
        '
        Me.btnGuardaA.Image = CType(resources.GetObject("btnGuardaA.Image"), System.Drawing.Image)
        Me.btnGuardaA.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuardaA.Name = "btnGuardaA"
        Me.btnGuardaA.Size = New System.Drawing.Size(133, 22)
        Me.btnGuardaA.Text = "Guardar y Actualizar"
        Me.btnGuardaA.Visible = False
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
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.rtbTratamiento)
        Me.TabPage2.Controls.Add(Me.rtbObservacion)
        Me.TabPage2.Controls.Add(Me.tbCantidad)
        Me.TabPage2.Controls.Add(Me.tbMRO)
        Me.TabPage2.Controls.Add(Me.dgvDetalle)
        Me.TabPage2.Controls.Add(Me.MaterialLabel4)
        Me.TabPage2.Controls.Add(Me.MaterialLabel3)
        Me.TabPage2.Controls.Add(Me.MaterialLabel2)
        Me.TabPage2.Controls.Add(Me.MaterialLabel1)
        Me.TabPage2.Controls.Add(Me.ToolStrip2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(888, 670)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Detalle"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'rtbTratamiento
        '
        Me.rtbTratamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbTratamiento.Enabled = False
        Me.rtbTratamiento.Location = New System.Drawing.Point(428, 138)
        Me.rtbTratamiento.Name = "rtbTratamiento"
        Me.rtbTratamiento.Size = New System.Drawing.Size(416, 91)
        Me.rtbTratamiento.TabIndex = 20
        Me.rtbTratamiento.Text = ""
        '
        'rtbObservacion
        '
        Me.rtbObservacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbObservacion.Enabled = False
        Me.rtbObservacion.Location = New System.Drawing.Point(428, 339)
        Me.rtbObservacion.Name = "rtbObservacion"
        Me.rtbObservacion.Size = New System.Drawing.Size(416, 91)
        Me.rtbObservacion.TabIndex = 19
        Me.rtbObservacion.Text = ""
        '
        'tbCantidad
        '
        Me.tbCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCantidad.Enabled = False
        Me.tbCantidad.Location = New System.Drawing.Point(428, 269)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(416, 23)
        Me.tbCantidad.TabIndex = 18
        Me.tbCantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbMRO
        '
        Me.tbMRO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMRO.Enabled = False
        Me.tbMRO.Location = New System.Drawing.Point(428, 74)
        Me.tbMRO.Name = "tbMRO"
        Me.tbMRO.Size = New System.Drawing.Size(416, 23)
        Me.tbMRO.TabIndex = 16
        '
        'dgvDetalle
        '
        Me.dgvDetalle.AllowUserToAddRows = False
        Me.dgvDetalle.AllowUserToDeleteRows = False
        Me.dgvDetalle.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvDetalle.BackgroundColor = System.Drawing.Color.White
        Me.dgvDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDetalle.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.Column4, Me.Column5})
        Me.dgvDetalle.Location = New System.Drawing.Point(3, 31)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(410, 633)
        Me.dgvDetalle.TabIndex = 15
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.HeaderText = "°-"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        Me.DataGridViewTextBoxColumn1.Width = 50
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.HeaderText = "No. DIBUJO/MRO:"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.HeaderText = "TRATAMIENTO"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.Width = 300
        '
        'Column4
        '
        Me.Column4.HeaderText = "CANTIDAD"
        Me.Column4.Name = "Column4"
        Me.Column4.ReadOnly = True
        '
        'Column5
        '
        Me.Column5.HeaderText = "OBSERVACIONES"
        Me.Column5.Name = "Column5"
        Me.Column5.ReadOnly = True
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(424, 317)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel4.TabIndex = 14
        Me.MaterialLabel4.Text = "Observaciones:"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(424, 247)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel3.TabIndex = 13
        Me.MaterialLabel3.Text = "Cantidad:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(424, 116)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(95, 19)
        Me.MaterialLabel2.TabIndex = 12
        Me.MaterialLabel2.Text = "Tratamiento:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(424, 52)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(122, 19)
        Me.MaterialLabel1.TabIndex = 4
        Me.MaterialLabel1.Text = "No. Dibujo/MRO:"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnAgregaDetalle, Me.btnGeneraCB})
        Me.ToolStrip2.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(882, 25)
        Me.ToolStrip2.TabIndex = 3
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'btnAgregaDetalle
        '
        Me.btnAgregaDetalle.Image = CType(resources.GetObject("btnAgregaDetalle.Image"), System.Drawing.Image)
        Me.btnAgregaDetalle.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnAgregaDetalle.Name = "btnAgregaDetalle"
        Me.btnAgregaDetalle.Size = New System.Drawing.Size(69, 22)
        Me.btnAgregaDetalle.Text = "Agregar"
        '
        'btnGeneraCB
        '
        Me.btnGeneraCB.Image = CType(resources.GetObject("btnGeneraCB.Image"), System.Drawing.Image)
        Me.btnGeneraCB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGeneraCB.Name = "btnGeneraCB"
        Me.btnGeneraCB.Size = New System.Drawing.Size(86, 22)
        Me.btnGeneraCB.Text = "Generar CB"
        Me.btnGeneraCB.Visible = False
        '
        'scrUniDet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(894, 793)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Font = New System.Drawing.Font("Segoe UI Symbol", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "scrUniDet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidad y Detalle"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.btnNuevo.ResumeLayout(False)
        Me.btnNuevo.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents btnNuevo As ToolStrip
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents tbClave As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnNuevaU As ToolStripButton
    Friend WithEvents btnGuardaA As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnCancelaEdit As ToolStripButton
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents btnAgregaDetalle As ToolStripButton
    Friend WithEvents btnGeneraCB As ToolStripButton
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents dgvUnidad As DataGridView
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents tbMRO As TextBox
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents rtbObservacion As RichTextBox
    Friend WithEvents rtbTratamiento As RichTextBox
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
End Class
