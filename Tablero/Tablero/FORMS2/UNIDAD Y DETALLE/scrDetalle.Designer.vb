<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrDetalle
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrDetalle))
        Me.btnNuevo = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaU = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardaA = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEdit = New System.Windows.Forms.ToolStripButton()
        Me.btnUDE = New System.Windows.Forms.ToolStripButton()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbUnidad = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbOrdenT = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.dgvDetalle = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel5 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel6 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbMRO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.tbCantidad = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.rtbTratamiento = New System.Windows.Forms.RichTextBox()
        Me.rtbObservacion = New System.Windows.Forms.RichTextBox()
        Me.btnNuevo.SuspendLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.AutoSize = False
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.None
        Me.btnNuevo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaU, Me.btnGuardar, Me.btnGuardaA, Me.btnEditar, Me.btnCancelaEdit, Me.btnUDE})
        Me.btnNuevo.Location = New System.Drawing.Point(1, 66)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(799, 25)
        Me.btnNuevo.TabIndex = 2
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
        'btnUDE
        '
        Me.btnUDE.Image = CType(resources.GetObject("btnUDE.Image"), System.Drawing.Image)
        Me.btnUDE.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnUDE.Name = "btnUDE"
        Me.btnUDE.Size = New System.Drawing.Size(151, 22)
        Me.btnUDE.Text = "Utilizar Detalle Existente"
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(457, 101)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel3.TabIndex = 27
        Me.MaterialLabel3.Text = "Unidad:"
        '
        'tbUnidad
        '
        Me.tbUnidad.Depth = 0
        Me.tbUnidad.Enabled = False
        Me.tbUnidad.Hint = ""
        Me.tbUnidad.Location = New System.Drawing.Point(522, 97)
        Me.tbUnidad.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbUnidad.Name = "tbUnidad"
        Me.tbUnidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbUnidad.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbUnidad.SelectedText = ""
        Me.tbUnidad.SelectionLength = 0
        Me.tbUnidad.SelectionStart = 0
        Me.tbUnidad.Size = New System.Drawing.Size(264, 23)
        Me.tbUnidad.TabIndex = 38
        Me.tbUnidad.TabStop = False
        Me.tbUnidad.UseSystemPasswordChar = False
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 101)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(127, 19)
        Me.MaterialLabel1.TabIndex = 39
        Me.MaterialLabel1.Text = "Orden de Trabajo:"
        '
        'tbOrdenT
        '
        Me.tbOrdenT.Depth = 0
        Me.tbOrdenT.Enabled = False
        Me.tbOrdenT.Hint = ""
        Me.tbOrdenT.Location = New System.Drawing.Point(145, 97)
        Me.tbOrdenT.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbOrdenT.Name = "tbOrdenT"
        Me.tbOrdenT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbOrdenT.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbOrdenT.SelectedText = ""
        Me.tbOrdenT.SelectionLength = 0
        Me.tbOrdenT.SelectionStart = 0
        Me.tbOrdenT.Size = New System.Drawing.Size(264, 23)
        Me.tbOrdenT.TabIndex = 40
        Me.tbOrdenT.TabStop = False
        Me.tbOrdenT.UseSystemPasswordChar = False
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
        Me.dgvDetalle.Location = New System.Drawing.Point(16, 141)
        Me.dgvDetalle.Name = "dgvDetalle"
        Me.dgvDetalle.ReadOnly = True
        Me.dgvDetalle.Size = New System.Drawing.Size(410, 517)
        Me.dgvDetalle.TabIndex = 41
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
        Me.MaterialLabel4.Location = New System.Drawing.Point(445, 433)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel4.TabIndex = 45
        Me.MaterialLabel4.Text = "Observaciones:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(445, 363)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel2.TabIndex = 44
        Me.MaterialLabel2.Text = "Cantidad:"
        '
        'MaterialLabel5
        '
        Me.MaterialLabel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel5.AutoSize = True
        Me.MaterialLabel5.Depth = 0
        Me.MaterialLabel5.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel5.Location = New System.Drawing.Point(445, 232)
        Me.MaterialLabel5.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel5.Name = "MaterialLabel5"
        Me.MaterialLabel5.Size = New System.Drawing.Size(95, 19)
        Me.MaterialLabel5.TabIndex = 43
        Me.MaterialLabel5.Text = "Tratamiento:"
        '
        'MaterialLabel6
        '
        Me.MaterialLabel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel6.AutoSize = True
        Me.MaterialLabel6.Depth = 0
        Me.MaterialLabel6.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel6.Location = New System.Drawing.Point(445, 168)
        Me.MaterialLabel6.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel6.Name = "MaterialLabel6"
        Me.MaterialLabel6.Size = New System.Drawing.Size(122, 19)
        Me.MaterialLabel6.TabIndex = 42
        Me.MaterialLabel6.Text = "No. Dibujo/MRO:"
        '
        'tbMRO
        '
        Me.tbMRO.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbMRO.Depth = 0
        Me.tbMRO.Enabled = False
        Me.tbMRO.Hint = ""
        Me.tbMRO.Location = New System.Drawing.Point(449, 190)
        Me.tbMRO.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbMRO.Name = "tbMRO"
        Me.tbMRO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbMRO.SelectedText = ""
        Me.tbMRO.SelectionLength = 0
        Me.tbMRO.SelectionStart = 0
        Me.tbMRO.Size = New System.Drawing.Size(337, 23)
        Me.tbMRO.TabIndex = 46
        Me.tbMRO.TabStop = False
        Me.tbMRO.UseSystemPasswordChar = False
        '
        'tbCantidad
        '
        Me.tbCantidad.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbCantidad.Depth = 0
        Me.tbCantidad.Enabled = False
        Me.tbCantidad.Hint = ""
        Me.tbCantidad.Location = New System.Drawing.Point(449, 385)
        Me.tbCantidad.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbCantidad.SelectedText = ""
        Me.tbCantidad.SelectionLength = 0
        Me.tbCantidad.SelectionStart = 0
        Me.tbCantidad.Size = New System.Drawing.Size(337, 23)
        Me.tbCantidad.TabIndex = 47
        Me.tbCantidad.TabStop = False
        Me.tbCantidad.UseSystemPasswordChar = False
        '
        'rtbTratamiento
        '
        Me.rtbTratamiento.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbTratamiento.Enabled = False
        Me.rtbTratamiento.Location = New System.Drawing.Point(449, 254)
        Me.rtbTratamiento.Name = "rtbTratamiento"
        Me.rtbTratamiento.Size = New System.Drawing.Size(337, 91)
        Me.rtbTratamiento.TabIndex = 48
        Me.rtbTratamiento.Text = ""
        '
        'rtbObservacion
        '
        Me.rtbObservacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtbObservacion.Enabled = False
        Me.rtbObservacion.Location = New System.Drawing.Point(449, 468)
        Me.rtbObservacion.Name = "rtbObservacion"
        Me.rtbObservacion.Size = New System.Drawing.Size(337, 91)
        Me.rtbObservacion.TabIndex = 49
        Me.rtbObservacion.Text = ""
        '
        'scrDetalle
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 666)
        Me.Controls.Add(Me.rtbObservacion)
        Me.Controls.Add(Me.rtbTratamiento)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.tbMRO)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.MaterialLabel5)
        Me.Controls.Add(Me.MaterialLabel6)
        Me.Controls.Add(Me.dgvDetalle)
        Me.Controls.Add(Me.tbOrdenT)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.tbUnidad)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "scrDetalle"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Detalle"
        Me.btnNuevo.ResumeLayout(False)
        Me.btnNuevo.PerformLayout()
        CType(Me.dgvDetalle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As ToolStrip
    Friend WithEvents btnNuevaU As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnGuardaA As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnCancelaEdit As ToolStripButton
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbUnidad As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbOrdenT As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents dgvDetalle As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel5 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel6 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbMRO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents tbCantidad As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents rtbTratamiento As RichTextBox
    Friend WithEvents rtbObservacion As RichTextBox
    Friend WithEvents btnUDE As ToolStripButton
End Class
