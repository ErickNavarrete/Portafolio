<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrCargaPDF
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrCargaPDF))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnCargaPDF = New System.Windows.Forms.ToolStripButton()
        Me.btnCorte = New System.Windows.Forms.ToolStripButton()
        Me.btnCargaImagen = New System.Windows.Forms.ToolStripButton()
        Me.btnGeneraCB = New System.Windows.Forms.ToolStripButton()
        Me.btnZoomIn = New System.Windows.Forms.ToolStripButton()
        Me.btnZomOut = New System.Windows.Forms.ToolStripButton()
        Me.cbHorientacion = New System.Windows.Forms.ToolStripComboBox()
        Me.AxAcroPDF1 = New AxAcroPDFLib.AxAcroPDF()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.pbPDF = New System.Windows.Forms.PictureBox()
        Me.pbImagenC = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.pbEjem = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbImagenC, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.pbEjem, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnCargaPDF, Me.btnCorte, Me.btnCargaImagen, Me.btnGeneraCB, Me.btnZoomIn, Me.btnZomOut, Me.cbHorientacion})
        Me.ToolStrip1.Location = New System.Drawing.Point(9, 65)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(897, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnCargaPDF
        '
        Me.btnCargaPDF.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCargaPDF.Image = CType(resources.GetObject("btnCargaPDF.Image"), System.Drawing.Image)
        Me.btnCargaPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaPDF.Name = "btnCargaPDF"
        Me.btnCargaPDF.Size = New System.Drawing.Size(86, 22)
        Me.btnCargaPDF.Text = "Cargar PDF"
        '
        'btnCorte
        '
        Me.btnCorte.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCorte.Image = CType(resources.GetObject("btnCorte.Image"), System.Drawing.Image)
        Me.btnCorte.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCorte.Name = "btnCorte"
        Me.btnCorte.Size = New System.Drawing.Size(56, 22)
        Me.btnCorte.Text = "Corte"
        '
        'btnCargaImagen
        '
        Me.btnCargaImagen.ForeColor = System.Drawing.SystemColors.Control
        Me.btnCargaImagen.Image = CType(resources.GetObject("btnCargaImagen.Image"), System.Drawing.Image)
        Me.btnCargaImagen.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnCargaImagen.Name = "btnCargaImagen"
        Me.btnCargaImagen.Size = New System.Drawing.Size(105, 22)
        Me.btnCargaImagen.Text = "Cargar Imagen"
        Me.btnCargaImagen.Visible = False
        '
        'btnGeneraCB
        '
        Me.btnGeneraCB.ForeColor = System.Drawing.SystemColors.Control
        Me.btnGeneraCB.Image = CType(resources.GetObject("btnGeneraCB.Image"), System.Drawing.Image)
        Me.btnGeneraCB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGeneraCB.Name = "btnGeneraCB"
        Me.btnGeneraCB.Size = New System.Drawing.Size(91, 22)
        Me.btnGeneraCB.Text = "Imprimir CB"
        '
        'btnZoomIn
        '
        Me.btnZoomIn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZoomIn.Image = CType(resources.GetObject("btnZoomIn.Image"), System.Drawing.Image)
        Me.btnZoomIn.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZoomIn.Name = "btnZoomIn"
        Me.btnZoomIn.Size = New System.Drawing.Size(23, 22)
        Me.btnZoomIn.Text = "ToolStripButton1"
        Me.btnZoomIn.Visible = False
        '
        'btnZomOut
        '
        Me.btnZomOut.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.btnZomOut.Image = CType(resources.GetObject("btnZomOut.Image"), System.Drawing.Image)
        Me.btnZomOut.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnZomOut.Name = "btnZomOut"
        Me.btnZomOut.Size = New System.Drawing.Size(23, 22)
        Me.btnZomOut.Text = "ToolStripButton2"
        Me.btnZomOut.Visible = False
        '
        'cbHorientacion
        '
        Me.cbHorientacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold)
        Me.cbHorientacion.Items.AddRange(New Object() {"HORIZONTAL", "VERTICAL"})
        Me.cbHorientacion.Name = "cbHorientacion"
        Me.cbHorientacion.Size = New System.Drawing.Size(121, 25)
        '
        'AxAcroPDF1
        '
        Me.AxAcroPDF1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxAcroPDF1.Enabled = True
        Me.AxAcroPDF1.Location = New System.Drawing.Point(7, 15)
        Me.AxAcroPDF1.Name = "AxAcroPDF1"
        Me.AxAcroPDF1.OcxState = CType(resources.GetObject("AxAcroPDF1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxAcroPDF1.Size = New System.Drawing.Size(876, 494)
        Me.AxAcroPDF1.TabIndex = 15
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'pbPDF
        '
        Me.pbPDF.Location = New System.Drawing.Point(7, 15)
        Me.pbPDF.Name = "pbPDF"
        Me.pbPDF.Size = New System.Drawing.Size(172, 154)
        Me.pbPDF.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbPDF.TabIndex = 45
        Me.pbPDF.TabStop = False
        Me.pbPDF.Visible = False
        '
        'pbImagenC
        '
        Me.pbImagenC.Location = New System.Drawing.Point(7, 175)
        Me.pbImagenC.Name = "pbImagenC"
        Me.pbImagenC.Size = New System.Drawing.Size(72, 81)
        Me.pbImagenC.TabIndex = 46
        Me.pbImagenC.TabStop = False
        Me.pbImagenC.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.pbEjem)
        Me.Panel1.Controls.Add(Me.AxAcroPDF1)
        Me.Panel1.Controls.Add(Me.pbPDF)
        Me.Panel1.Controls.Add(Me.pbImagenC)
        Me.Panel1.Location = New System.Drawing.Point(2, 93)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(892, 519)
        Me.Panel1.TabIndex = 47
        '
        'pbEjem
        '
        Me.pbEjem.Location = New System.Drawing.Point(7, 15)
        Me.pbEjem.Name = "pbEjem"
        Me.pbEjem.Size = New System.Drawing.Size(562, 368)
        Me.pbEjem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbEjem.TabIndex = 47
        Me.pbEjem.TabStop = False
        Me.pbEjem.Visible = False
        '
        'scrCargaPDF
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(897, 614)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "scrCargaPDF"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Carga PDF"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.AxAcroPDF1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbPDF, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbImagenC, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.pbEjem, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents AxAcroPDF1 As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents btnCargaPDF As ToolStripButton
    Friend WithEvents btnGeneraCB As ToolStripButton
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents pbPDF As PictureBox
    Friend WithEvents btnCargaImagen As ToolStripButton
    Friend WithEvents pbImagenC As PictureBox
    Friend WithEvents btnCorte As ToolStripButton
    Friend WithEvents btnZoomIn As ToolStripButton
    Friend WithEvents btnZomOut As ToolStripButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents pbEjem As PictureBox
    Friend WithEvents cbHorientacion As ToolStripComboBox
End Class
