<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrProcesos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrProcesos))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnNuevo = New System.Windows.Forms.ToolStripButton()
        Me.btnEdita = New System.Windows.Forms.ToolStripButton()
        Me.btnElimina = New System.Windows.Forms.ToolStripButton()
        Me.btnGuarda = New System.Windows.Forms.ToolStripButton()
        Me.btnActualiza = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEdit = New System.Windows.Forms.ToolStripButton()
        Me.CLAVE_L = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DESCRIPCION_L = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.lvProceso = New System.Windows.Forms.ListView()
        Me.CLAVE = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.DESCRIPCIÓN = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.tbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.MaterialTabSelector1 = New MaterialSkin.Controls.MaterialTabSelector()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.dgvEstaciones = New System.Windows.Forms.DataGridView()
        Me.tbEstacion = New System.Windows.Forms.TextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnAgregaE = New System.Windows.Forms.Button()
        Me.ToolStrip1.SuspendLayout()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.dgvEstaciones, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(417, 99)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(50, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "Clave:"
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(417, 145)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Descripción:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevo, Me.btnEdita, Me.btnElimina, Me.btnGuarda, Me.btnActualiza, Me.btnCancelaEdit})
        Me.ToolStrip1.Location = New System.Drawing.Point(3, 3)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(852, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnNuevo
        '
        Me.btnNuevo.Image = CType(resources.GetObject("btnNuevo.Image"), System.Drawing.Image)
        Me.btnNuevo.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(62, 22)
        Me.btnNuevo.Text = "Nuevo"
        '
        'btnEdita
        '
        Me.btnEdita.Image = CType(resources.GetObject("btnEdita.Image"), System.Drawing.Image)
        Me.btnEdita.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnEdita.Name = "btnEdita"
        Me.btnEdita.Size = New System.Drawing.Size(57, 22)
        Me.btnEdita.Text = "Editar"
        '
        'btnElimina
        '
        Me.btnElimina.Image = CType(resources.GetObject("btnElimina.Image"), System.Drawing.Image)
        Me.btnElimina.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnElimina.Name = "btnElimina"
        Me.btnElimina.Size = New System.Drawing.Size(70, 22)
        Me.btnElimina.Text = "Eliminar"
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
        'btnActualiza
        '
        Me.btnActualiza.Image = CType(resources.GetObject("btnActualiza.Image"), System.Drawing.Image)
        Me.btnActualiza.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnActualiza.Name = "btnActualiza"
        Me.btnActualiza.Size = New System.Drawing.Size(79, 22)
        Me.btnActualiza.Text = "Actualizar"
        Me.btnActualiza.Visible = False
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
        'CLAVE_L
        '
        Me.CLAVE_L.Text = "CLAVE"
        Me.CLAVE_L.Width = 150
        '
        'DESCRIPCION_L
        '
        Me.DESCRIPCION_L.Text = "DESCRIPCION"
        Me.DESCRIPCION_L.Width = 300
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "CLAVE"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "DESCRIPCION"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "CLAVE"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "DESCRIPCION"
        Me.ColumnHeader4.Width = 300
        '
        'lvProceso
        '
        Me.lvProceso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lvProceso.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.CLAVE, Me.DESCRIPCIÓN})
        Me.lvProceso.Font = New System.Drawing.Font("Segoe UI Symbol", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lvProceso.Location = New System.Drawing.Point(7, 42)
        Me.lvProceso.Name = "lvProceso"
        Me.lvProceso.Size = New System.Drawing.Size(371, 424)
        Me.lvProceso.TabIndex = 25
        Me.lvProceso.UseCompatibleStateImageBehavior = False
        Me.lvProceso.View = System.Windows.Forms.View.Details
        '
        'CLAVE
        '
        Me.CLAVE.Text = "CLAVE"
        Me.CLAVE.Width = 180
        '
        'DESCRIPCIÓN
        '
        Me.DESCRIPCIÓN.Text = "DESCRIPCIÓN"
        Me.DESCRIPCIÓN.Width = 180
        '
        'tbDescripcion
        '
        Me.tbDescripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbDescripcion.Location = New System.Drawing.Point(525, 146)
        Me.tbDescripcion.Name = "tbDescripcion"
        Me.tbDescripcion.ReadOnly = True
        Me.tbDescripcion.Size = New System.Drawing.Size(295, 149)
        Me.tbDescripcion.TabIndex = 1
        Me.tbDescripcion.Text = ""
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(12, 88)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(866, 498)
        Me.MaterialTabControl1.TabIndex = 26
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.tbClave)
        Me.TabPage1.Controls.Add(Me.lvProceso)
        Me.TabPage1.Controls.Add(Me.tbDescripcion)
        Me.TabPage1.Controls.Add(Me.ToolStrip1)
        Me.TabPage1.Controls.Add(Me.MaterialLabel2)
        Me.TabPage1.Controls.Add(Me.MaterialLabel1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(858, 472)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "procesos"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.btnAgregaE)
        Me.TabPage2.Controls.Add(Me.tbEstacion)
        Me.TabPage2.Controls.Add(Me.MaterialLabel3)
        Me.TabPage2.Controls.Add(Me.dgvEstaciones)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(858, 472)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "estaciones"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'MaterialTabSelector1
        '
        Me.MaterialTabSelector1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialTabSelector1.BaseTabControl = Me.MaterialTabControl1
        Me.MaterialTabSelector1.Depth = 0
        Me.MaterialTabSelector1.Location = New System.Drawing.Point(-7, 59)
        Me.MaterialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabSelector1.Name = "MaterialTabSelector1"
        Me.MaterialTabSelector1.Size = New System.Drawing.Size(890, 23)
        Me.MaterialTabSelector1.TabIndex = 27
        Me.MaterialTabSelector1.Text = "MaterialTabSelector1"
        '
        'tbClave
        '
        Me.tbClave.Enabled = False
        Me.tbClave.Location = New System.Drawing.Point(525, 99)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(295, 20)
        Me.tbClave.TabIndex = 26
        '
        'dgvEstaciones
        '
        Me.dgvEstaciones.AllowUserToAddRows = False
        Me.dgvEstaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEstaciones.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2})
        Me.dgvEstaciones.Location = New System.Drawing.Point(6, 82)
        Me.dgvEstaciones.Name = "dgvEstaciones"
        Me.dgvEstaciones.Size = New System.Drawing.Size(846, 384)
        Me.dgvEstaciones.TabIndex = 0
        '
        'tbEstacion
        '
        Me.tbEstacion.Location = New System.Drawing.Point(188, 20)
        Me.tbEstacion.Name = "tbEstacion"
        Me.tbEstacion.Size = New System.Drawing.Size(295, 20)
        Me.tbEstacion.TabIndex = 28
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(6, 21)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(166, 19)
        Me.MaterialLabel3.TabIndex = 27
        Me.MaterialLabel3.Text = "Nombre de la Estación:"
        '
        'Column1
        '
        Me.Column1.HeaderText = "id_estacion"
        Me.Column1.Name = "Column1"
        Me.Column1.Visible = False
        '
        'Column2
        '
        Me.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill
        Me.Column2.HeaderText = "NOMBRE DE LA ESTACIÓN"
        Me.Column2.Name = "Column2"
        '
        'btnAgregaE
        '
        Me.btnAgregaE.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnAgregaE.BackgroundImage = CType(resources.GetObject("btnAgregaE.BackgroundImage"), System.Drawing.Image)
        Me.btnAgregaE.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAgregaE.Location = New System.Drawing.Point(500, 16)
        Me.btnAgregaE.Name = "btnAgregaE"
        Me.btnAgregaE.Size = New System.Drawing.Size(30, 30)
        Me.btnAgregaE.TabIndex = 29
        Me.btnAgregaE.UseVisualStyleBackColor = True
        '
        'scrProcesos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(880, 594)
        Me.Controls.Add(Me.MaterialTabSelector1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Name = "scrProcesos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Procesos"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage1.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        CType(Me.dgvEstaciones, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGuarda As ToolStripButton
    Friend WithEvents CLAVE_L As ColumnHeader
    Friend WithEvents DESCRIPCION_L As ColumnHeader
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents lvProceso As ListView
    Friend WithEvents CLAVE As ColumnHeader
    Friend WithEvents DESCRIPCIÓN As ColumnHeader
    Friend WithEvents btnNuevo As ToolStripButton
    Friend WithEvents btnEdita As ToolStripButton
    Friend WithEvents btnElimina As ToolStripButton
    Friend WithEvents btnActualiza As ToolStripButton
    Friend WithEvents btnCancelaEdit As ToolStripButton
    Friend WithEvents tbDescripcion As RichTextBox
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents MaterialTabSelector1 As MaterialSkin.Controls.MaterialTabSelector
    Friend WithEvents tbClave As TextBox
    Friend WithEvents dgvEstaciones As DataGridView
    Friend WithEvents tbEstacion As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents btnAgregaE As Button
End Class
