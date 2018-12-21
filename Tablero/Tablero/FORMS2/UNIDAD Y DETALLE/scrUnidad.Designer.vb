<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrUnidad
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrUnidad))
        Me.btnNuevo = New System.Windows.Forms.ToolStrip()
        Me.btnNuevaU = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardar = New System.Windows.Forms.ToolStripButton()
        Me.btnGuardaA = New System.Windows.Forms.ToolStripButton()
        Me.btnEditar = New System.Windows.Forms.ToolStripButton()
        Me.btnCancelaEdit = New System.Windows.Forms.ToolStripButton()
        Me.dgvUnidad = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.rtbDescripcion = New System.Windows.Forms.RichTextBox()
        Me.tbClave = New System.Windows.Forms.TextBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.btnNuevo.SuspendLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNuevo
        '
        Me.btnNuevo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnNuevo.AutoSize = False
        Me.btnNuevo.Dock = System.Windows.Forms.DockStyle.None
        Me.btnNuevo.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnNuevaU, Me.btnGuardar, Me.btnGuardaA, Me.btnEditar, Me.btnCancelaEdit})
        Me.btnNuevo.Location = New System.Drawing.Point(0, 67)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(799, 25)
        Me.btnNuevo.TabIndex = 1
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
        'dgvUnidad
        '
        Me.dgvUnidad.AllowUserToAddRows = False
        Me.dgvUnidad.AllowUserToDeleteRows = False
        Me.dgvUnidad.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvUnidad.BackgroundColor = System.Drawing.Color.White
        Me.dgvUnidad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvUnidad.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3})
        Me.dgvUnidad.Location = New System.Drawing.Point(12, 95)
        Me.dgvUnidad.Name = "dgvUnidad"
        Me.dgvUnidad.ReadOnly = True
        Me.dgvUnidad.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvUnidad.Size = New System.Drawing.Size(410, 552)
        Me.dgvUnidad.TabIndex = 7
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
        Me.rtbDescripcion.Location = New System.Drawing.Point(442, 258)
        Me.rtbDescripcion.Name = "rtbDescripcion"
        Me.rtbDescripcion.Size = New System.Drawing.Size(346, 113)
        Me.rtbDescripcion.TabIndex = 11
        Me.rtbDescripcion.Text = ""
        '
        'tbClave
        '
        Me.tbClave.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tbClave.Enabled = False
        Me.tbClave.Location = New System.Drawing.Point(442, 189)
        Me.tbClave.Name = "tbClave"
        Me.tbClave.Size = New System.Drawing.Size(346, 20)
        Me.tbClave.TabIndex = 9
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(438, 167)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(50, 19)
        Me.MaterialLabel3.TabIndex = 26
        Me.MaterialLabel3.Text = "Clave:"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(438, 236)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(93, 19)
        Me.MaterialLabel1.TabIndex = 27
        Me.MaterialLabel1.Text = "Descripción:"
        '
        'scrUnidad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 659)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.rtbDescripcion)
        Me.Controls.Add(Me.tbClave)
        Me.Controls.Add(Me.dgvUnidad)
        Me.Controls.Add(Me.btnNuevo)
        Me.Name = "scrUnidad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Unidad"
        Me.btnNuevo.ResumeLayout(False)
        Me.btnNuevo.PerformLayout()
        CType(Me.dgvUnidad, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNuevo As ToolStrip
    Friend WithEvents btnNuevaU As ToolStripButton
    Friend WithEvents btnGuardar As ToolStripButton
    Friend WithEvents btnGuardaA As ToolStripButton
    Friend WithEvents btnEditar As ToolStripButton
    Friend WithEvents btnCancelaEdit As ToolStripButton
    Friend WithEvents dgvUnidad As DataGridView
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents rtbDescripcion As RichTextBox
    Friend WithEvents tbClave As TextBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
End Class
