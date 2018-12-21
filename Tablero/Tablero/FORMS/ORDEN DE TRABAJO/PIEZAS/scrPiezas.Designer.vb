<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrPiezas
    Inherits MaterialSkin.Controls.MaterialForm

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrPiezas))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbMRO = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbTratamiento = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbCantidad = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.MaterialLabel4 = New MaterialSkin.Controls.MaterialLabel()
        Me.tbObservaciones = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGuarda = New System.Windows.Forms.ToolStripButton()
        Me.btnSubPDF = New System.Windows.Forms.ToolStripButton()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 140)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(122, 19)
        Me.MaterialLabel1.TabIndex = 2
        Me.MaterialLabel1.Text = "No. Dibujo/MRO:"
        '
        'tbMRO
        '
        Me.tbMRO.Depth = 0
        Me.tbMRO.Hint = ""
        Me.tbMRO.Location = New System.Drawing.Point(140, 140)
        Me.tbMRO.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbMRO.Name = "tbMRO"
        Me.tbMRO.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbMRO.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbMRO.SelectedText = ""
        Me.tbMRO.SelectionLength = 0
        Me.tbMRO.SelectionStart = 0
        Me.tbMRO.Size = New System.Drawing.Size(427, 23)
        Me.tbMRO.TabIndex = 0
        Me.tbMRO.TabStop = False
        Me.tbMRO.UseSystemPasswordChar = False
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 202)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(95, 19)
        Me.MaterialLabel2.TabIndex = 7
        Me.MaterialLabel2.Text = "Tratamiento:"
        '
        'tbTratamiento
        '
        Me.tbTratamiento.Depth = 0
        Me.tbTratamiento.Hint = ""
        Me.tbTratamiento.Location = New System.Drawing.Point(140, 198)
        Me.tbTratamiento.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbTratamiento.Name = "tbTratamiento"
        Me.tbTratamiento.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbTratamiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbTratamiento.SelectedText = ""
        Me.tbTratamiento.SelectionLength = 0
        Me.tbTratamiento.SelectionStart = 0
        Me.tbTratamiento.Size = New System.Drawing.Size(427, 23)
        Me.tbTratamiento.TabIndex = 1
        Me.tbTratamiento.TabStop = False
        Me.tbTratamiento.UseSystemPasswordChar = False
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 274)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(72, 19)
        Me.MaterialLabel3.TabIndex = 9
        Me.MaterialLabel3.Text = "Cantidad:"
        '
        'tbCantidad
        '
        Me.tbCantidad.Depth = 0
        Me.tbCantidad.Hint = ""
        Me.tbCantidad.Location = New System.Drawing.Point(140, 270)
        Me.tbCantidad.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbCantidad.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.tbCantidad.SelectedText = ""
        Me.tbCantidad.SelectionLength = 0
        Me.tbCantidad.SelectionStart = 0
        Me.tbCantidad.Size = New System.Drawing.Size(427, 23)
        Me.tbCantidad.TabIndex = 2
        Me.tbCantidad.TabStop = False
        Me.tbCantidad.UseSystemPasswordChar = False
        '
        'MaterialLabel4
        '
        Me.MaterialLabel4.AutoSize = True
        Me.MaterialLabel4.Depth = 0
        Me.MaterialLabel4.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel4.Location = New System.Drawing.Point(12, 343)
        Me.MaterialLabel4.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel4.Name = "MaterialLabel4"
        Me.MaterialLabel4.Size = New System.Drawing.Size(112, 19)
        Me.MaterialLabel4.TabIndex = 11
        Me.MaterialLabel4.Text = "Observaciones:"
        '
        'tbObservaciones
        '
        Me.tbObservaciones.Depth = 0
        Me.tbObservaciones.Hint = ""
        Me.tbObservaciones.Location = New System.Drawing.Point(140, 339)
        Me.tbObservaciones.MouseState = MaterialSkin.MouseState.HOVER
        Me.tbObservaciones.Name = "tbObservaciones"
        Me.tbObservaciones.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.tbObservaciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tbObservaciones.SelectedText = ""
        Me.tbObservaciones.SelectionLength = 0
        Me.tbObservaciones.SelectionStart = 0
        Me.tbObservaciones.Size = New System.Drawing.Size(427, 23)
        Me.tbObservaciones.TabIndex = 3
        Me.tbObservaciones.TabStop = False
        Me.tbObservaciones.UseSystemPasswordChar = False
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGuarda, Me.btnSubPDF})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 63)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1079, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGuarda
        '
        Me.btnGuarda.Image = CType(resources.GetObject("btnGuarda.Image"), System.Drawing.Image)
        Me.btnGuarda.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGuarda.Name = "btnGuarda"
        Me.btnGuarda.Size = New System.Drawing.Size(69, 22)
        Me.btnGuarda.Text = "Guardar"
        '
        'btnSubPDF
        '
        Me.btnSubPDF.Image = CType(resources.GetObject("btnSubPDF.Image"), System.Drawing.Image)
        Me.btnSubPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnSubPDF.Name = "btnSubPDF"
        Me.btnSubPDF.Size = New System.Drawing.Size(78, 22)
        Me.btnSubPDF.Text = "Subir PDF"
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(628, 140)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(435, 444)
        Me.AxAcroPDF1.TabIndex = 14
        '
        'scrPiezas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1075, 596)
        Me.Controls.Add(Me.AxAcroPDF1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.tbObservaciones)
        Me.Controls.Add(Me.MaterialLabel4)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.tbTratamiento)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.tbMRO)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "scrPiezas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Piezas"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbMRO As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbTratamiento As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbCantidad As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents MaterialLabel4 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents tbObservaciones As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGuarda As ToolStripButton
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnSubPDF As ToolStripButton
End Class
