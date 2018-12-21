<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrImagenC
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrImagenC))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.cbHorientacion = New System.Windows.Forms.ToolStripComboBox()
        Me.pCorte = New System.Windows.Forms.PictureBox()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.pCorte, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1, Me.cbHorientacion})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 66)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(91, 22)
        Me.ToolStripButton1.Text = "Imprimir CB"
        '
        'cbHorientacion
        '
        Me.cbHorientacion.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbHorientacion.Items.AddRange(New Object() {"HORIZONTAL", "VERTICAL"})
        Me.cbHorientacion.Name = "cbHorientacion"
        Me.cbHorientacion.Size = New System.Drawing.Size(121, 25)
        '
        'pCorte
        '
        Me.pCorte.Location = New System.Drawing.Point(12, 101)
        Me.pCorte.Name = "pCorte"
        Me.pCorte.Size = New System.Drawing.Size(776, 442)
        Me.pCorte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pCorte.TabIndex = 1
        Me.pCorte.TabStop = False
        '
        'scrImagenC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 555)
        Me.Controls.Add(Me.pCorte)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "scrImagenC"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Imagen"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.pCorte, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents pCorte As PictureBox
    Friend WithEvents cbHorientacion As ToolStripComboBox
End Class
