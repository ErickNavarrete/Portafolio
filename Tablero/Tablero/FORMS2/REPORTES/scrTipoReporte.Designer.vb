<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class scrTipoReporte
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrTipoReporte))
        Me.MaterialLabel1 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbOT = New System.Windows.Forms.ComboBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.btnGeneraPDF = New System.Windows.Forms.ToolStripButton()
        Me.cbUnidad = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel2 = New MaterialSkin.Controls.MaterialLabel()
        Me.cbDetalle = New System.Windows.Forms.ComboBox()
        Me.MaterialLabel3 = New MaterialSkin.Controls.MaterialLabel()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MaterialLabel1
        '
        Me.MaterialLabel1.AutoSize = True
        Me.MaterialLabel1.Depth = 0
        Me.MaterialLabel1.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel1.Location = New System.Drawing.Point(12, 103)
        Me.MaterialLabel1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel1.Name = "MaterialLabel1"
        Me.MaterialLabel1.Size = New System.Drawing.Size(127, 19)
        Me.MaterialLabel1.TabIndex = 0
        Me.MaterialLabel1.Text = "Orden de Trabajo:"
        '
        'cbOT
        '
        Me.cbOT.FormattingEnabled = True
        Me.cbOT.Location = New System.Drawing.Point(12, 125)
        Me.cbOT.Name = "cbOT"
        Me.cbOT.Size = New System.Drawing.Size(275, 21)
        Me.cbOT.TabIndex = 1
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.ToolStrip1.AutoSize = False
        Me.ToolStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.btnGeneraPDF})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 64)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(390, 25)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'btnGeneraPDF
        '
        Me.btnGeneraPDF.Image = CType(resources.GetObject("btnGeneraPDF.Image"), System.Drawing.Image)
        Me.btnGeneraPDF.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.btnGeneraPDF.Name = "btnGeneraPDF"
        Me.btnGeneraPDF.Size = New System.Drawing.Size(73, 22)
        Me.btnGeneraPDF.Text = "Imprimir"
        '
        'cbUnidad
        '
        Me.cbUnidad.FormattingEnabled = True
        Me.cbUnidad.Location = New System.Drawing.Point(12, 180)
        Me.cbUnidad.Name = "cbUnidad"
        Me.cbUnidad.Size = New System.Drawing.Size(275, 21)
        Me.cbUnidad.TabIndex = 4
        '
        'MaterialLabel2
        '
        Me.MaterialLabel2.AutoSize = True
        Me.MaterialLabel2.Depth = 0
        Me.MaterialLabel2.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel2.Location = New System.Drawing.Point(12, 158)
        Me.MaterialLabel2.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel2.Name = "MaterialLabel2"
        Me.MaterialLabel2.Size = New System.Drawing.Size(59, 19)
        Me.MaterialLabel2.TabIndex = 3
        Me.MaterialLabel2.Text = "Unidad:"
        '
        'cbDetalle
        '
        Me.cbDetalle.FormattingEnabled = True
        Me.cbDetalle.Location = New System.Drawing.Point(12, 237)
        Me.cbDetalle.Name = "cbDetalle"
        Me.cbDetalle.Size = New System.Drawing.Size(275, 21)
        Me.cbDetalle.TabIndex = 6
        '
        'MaterialLabel3
        '
        Me.MaterialLabel3.AutoSize = True
        Me.MaterialLabel3.Depth = 0
        Me.MaterialLabel3.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.MaterialLabel3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.MaterialLabel3.Location = New System.Drawing.Point(12, 215)
        Me.MaterialLabel3.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialLabel3.Name = "MaterialLabel3"
        Me.MaterialLabel3.Size = New System.Drawing.Size(60, 19)
        Me.MaterialLabel3.TabIndex = 5
        Me.MaterialLabel3.Text = "Detalle:"
        '
        'scrTipoReporte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 298)
        Me.Controls.Add(Me.cbDetalle)
        Me.Controls.Add(Me.MaterialLabel3)
        Me.Controls.Add(Me.cbUnidad)
        Me.Controls.Add(Me.MaterialLabel2)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.cbOT)
        Me.Controls.Add(Me.MaterialLabel1)
        Me.Name = "scrTipoReporte"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo de Reporte"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MaterialLabel1 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbOT As ComboBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents btnGeneraPDF As ToolStripButton
    Friend WithEvents cbUnidad As ComboBox
    Friend WithEvents MaterialLabel2 As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents cbDetalle As ComboBox
    Friend WithEvents MaterialLabel3 As MaterialSkin.Controls.MaterialLabel
End Class
