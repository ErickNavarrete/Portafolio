<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrTransferenciaB
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrTransferenciaB))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbEmisor = New System.Windows.Forms.ComboBox()
        Me.cbReceptor = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbCantidad = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.dtp1 = New System.Windows.Forms.DateTimePicker()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 161)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Banco Emisor"
        '
        'cbEmisor
        '
        Me.cbEmisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbEmisor.FormattingEnabled = True
        Me.cbEmisor.Location = New System.Drawing.Point(144, 158)
        Me.cbEmisor.Name = "cbEmisor"
        Me.cbEmisor.Size = New System.Drawing.Size(267, 28)
        Me.cbEmisor.TabIndex = 1
        '
        'cbReceptor
        '
        Me.cbReceptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbReceptor.FormattingEnabled = True
        Me.cbReceptor.Location = New System.Drawing.Point(161, 288)
        Me.cbReceptor.Name = "cbReceptor"
        Me.cbReceptor.Size = New System.Drawing.Size(250, 28)
        Me.cbReceptor.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 291)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 22)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Banco Receptor"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 226)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(180, 22)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Cantidad a Transferir"
        '
        'tbCantidad
        '
        Me.tbCantidad.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCantidad.Location = New System.Drawing.Point(203, 223)
        Me.tbCantidad.Name = "tbCantidad"
        Me.tbCantidad.Size = New System.Drawing.Size(208, 27)
        Me.tbCantidad.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(157, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 22)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Fecha"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.ToolStrip2.Location = New System.Drawing.Point(-1, 63)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(433, 25)
        Me.ToolStrip2.TabIndex = 141
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'tsbGuardar
        '
        Me.tsbGuardar.Font = New System.Drawing.Font("Segoe UI Semibold", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tsbGuardar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.tsbGuardar.Image = CType(resources.GetObject("tsbGuardar.Image"), System.Drawing.Image)
        Me.tsbGuardar.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbGuardar.Name = "tsbGuardar"
        Me.tsbGuardar.Size = New System.Drawing.Size(69, 22)
        Me.tsbGuardar.Text = "Guardar"
        '
        'dtp1
        '
        Me.dtp1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dtp1.CustomFormat = "dd/MMMM/yyyy"
        Me.dtp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtp1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtp1.Location = New System.Drawing.Point(230, 100)
        Me.dtp1.Name = "dtp1"
        Me.dtp1.Size = New System.Drawing.Size(190, 27)
        Me.dtp1.TabIndex = 142
        '
        'scrTransferenciaB
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(432, 342)
        Me.Controls.Add(Me.dtp1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.tbCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cbReceptor)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.cbEmisor)
        Me.Controls.Add(Me.Label1)
        Me.Name = "scrTransferenciaB"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "scrTransferenciaB"
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents cbEmisor As ComboBox
    Friend WithEvents cbReceptor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbCantidad As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents dtp1 As DateTimePicker
End Class
