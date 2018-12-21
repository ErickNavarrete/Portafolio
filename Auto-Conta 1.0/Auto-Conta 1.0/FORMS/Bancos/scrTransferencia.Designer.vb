<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class scrTransferencia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(scrTransferencia))
        Me.btnNTrans = New MaterialSkin.Controls.MaterialFlatButton()
        Me.btnVerTrans = New MaterialSkin.Controls.MaterialFlatButton()
        Me.pnNueva = New System.Windows.Forms.Panel()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.tsbGuardar = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbBancoEmisor = New System.Windows.Forms.ComboBox()
        Me.cbBancoReceptor = New System.Windows.Forms.ComboBox()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbTtrans = New System.Windows.Forms.TextBox()
        Me.tbNotas = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbSaldoEmi = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbSaldoRec = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.pnNueva.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnNTrans
        '
        Me.btnNTrans.AutoSize = True
        Me.btnNTrans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnNTrans.BackgroundImage = CType(resources.GetObject("btnNTrans.BackgroundImage"), System.Drawing.Image)
        Me.btnNTrans.Depth = 0
        Me.btnNTrans.Icon = CType(resources.GetObject("btnNTrans.Icon"), System.Drawing.Image)
        Me.btnNTrans.Location = New System.Drawing.Point(13, 277)
        Me.btnNTrans.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnNTrans.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnNTrans.Name = "btnNTrans"
        Me.btnNTrans.Primary = False
        Me.btnNTrans.Size = New System.Drawing.Size(204, 36)
        Me.btnNTrans.TabIndex = 2
        Me.btnNTrans.Text = "Nueva transferencia"
        Me.btnNTrans.UseVisualStyleBackColor = True
        '
        'btnVerTrans
        '
        Me.btnVerTrans.AutoSize = True
        Me.btnVerTrans.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.btnVerTrans.BackgroundImage = CType(resources.GetObject("btnVerTrans.BackgroundImage"), System.Drawing.Image)
        Me.btnVerTrans.Depth = 0
        Me.btnVerTrans.Icon = CType(resources.GetObject("btnVerTrans.Icon"), System.Drawing.Image)
        Me.btnVerTrans.Location = New System.Drawing.Point(13, 411)
        Me.btnVerTrans.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.btnVerTrans.MouseState = MaterialSkin.MouseState.HOVER
        Me.btnVerTrans.Name = "btnVerTrans"
        Me.btnVerTrans.Primary = False
        Me.btnVerTrans.Size = New System.Drawing.Size(193, 36)
        Me.btnVerTrans.TabIndex = 3
        Me.btnVerTrans.Text = "Ver Transferencias"
        Me.btnVerTrans.UseVisualStyleBackColor = True
        '
        'pnNueva
        '
        Me.pnNueva.Controls.Add(Me.tbSaldoRec)
        Me.pnNueva.Controls.Add(Me.Label5)
        Me.pnNueva.Controls.Add(Me.tbSaldoEmi)
        Me.pnNueva.Controls.Add(Me.Label9)
        Me.pnNueva.Controls.Add(Me.tbNotas)
        Me.pnNueva.Controls.Add(Me.Label4)
        Me.pnNueva.Controls.Add(Me.tbTtrans)
        Me.pnNueva.Controls.Add(Me.Label3)
        Me.pnNueva.Controls.Add(Me.dtpFecha)
        Me.pnNueva.Controls.Add(Me.cbBancoReceptor)
        Me.pnNueva.Controls.Add(Me.cbBancoEmisor)
        Me.pnNueva.Controls.Add(Me.Label2)
        Me.pnNueva.Controls.Add(Me.Label1)
        Me.pnNueva.Location = New System.Drawing.Point(261, 99)
        Me.pnNueva.Name = "pnNueva"
        Me.pnNueva.Size = New System.Drawing.Size(832, 535)
        Me.pnNueva.TabIndex = 4
        Me.pnNueva.Visible = False
        '
        'ToolStrip2
        '
        Me.ToolStrip2.AutoSize = False
        Me.ToolStrip2.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.None
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsbGuardar})
        Me.ToolStrip2.Location = New System.Drawing.Point(-1, 60)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1107, 25)
        Me.ToolStrip2.TabIndex = 137
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 86)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(143, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cuenta Emisora:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(11, 203)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(161, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Cuenta Receptora:"
        '
        'cbBancoEmisor
        '
        Me.cbBancoEmisor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancoEmisor.FormattingEnabled = True
        Me.cbBancoEmisor.Location = New System.Drawing.Point(13, 132)
        Me.cbBancoEmisor.Name = "cbBancoEmisor"
        Me.cbBancoEmisor.Size = New System.Drawing.Size(555, 28)
        Me.cbBancoEmisor.TabIndex = 2
        '
        'cbBancoReceptor
        '
        Me.cbBancoReceptor.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbBancoReceptor.FormattingEnabled = True
        Me.cbBancoReceptor.Location = New System.Drawing.Point(15, 246)
        Me.cbBancoReceptor.Name = "cbBancoReceptor"
        Me.cbBancoReceptor.Size = New System.Drawing.Size(553, 28)
        Me.cbBancoReceptor.TabIndex = 3
        '
        'dtpFecha
        '
        Me.dtpFecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpFecha.Location = New System.Drawing.Point(510, 3)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(319, 27)
        Me.dtpFecha.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(11, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(142, 22)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Total a transferir"
        '
        'tbTtrans
        '
        Me.tbTtrans.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbTtrans.Location = New System.Drawing.Point(15, 366)
        Me.tbTtrans.Name = "tbTtrans"
        Me.tbTtrans.Size = New System.Drawing.Size(179, 27)
        Me.tbTtrans.TabIndex = 6
        '
        'tbNotas
        '
        Me.tbNotas.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbNotas.Location = New System.Drawing.Point(406, 359)
        Me.tbNotas.Multiline = True
        Me.tbNotas.Name = "tbNotas"
        Me.tbNotas.Size = New System.Drawing.Size(411, 161)
        Me.tbNotas.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(402, 326)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 22)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Notas:"
        '
        'tbSaldoEmi
        '
        Me.tbSaldoEmi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaldoEmi.Location = New System.Drawing.Point(639, 177)
        Me.tbSaldoEmi.Name = "tbSaldoEmi"
        Me.tbSaldoEmi.ReadOnly = True
        Me.tbSaldoEmi.Size = New System.Drawing.Size(175, 26)
        Me.tbSaldoEmi.TabIndex = 49
        Me.tbSaldoEmi.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(419, 178)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(214, 25)
        Me.Label9.TabIndex = 50
        Me.Label9.Text = "Saldo Cuenta Emisora:"
        '
        'tbSaldoRec
        '
        Me.tbSaldoRec.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbSaldoRec.Location = New System.Drawing.Point(639, 280)
        Me.tbSaldoRec.Name = "tbSaldoRec"
        Me.tbSaldoRec.ReadOnly = True
        Me.tbSaldoRec.Size = New System.Drawing.Size(175, 26)
        Me.tbSaldoRec.TabIndex = 51
        Me.tbSaldoRec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(401, 279)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(232, 25)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Saldo Cuenta Receptora:"
        '
        'scrTransferencia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1105, 646)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.pnNueva)
        Me.Controls.Add(Me.btnVerTrans)
        Me.Controls.Add(Me.btnNTrans)
        Me.Name = "scrTransferencia"
        Me.Text = "scrTransferencia"
        Me.pnNueva.ResumeLayout(False)
        Me.pnNueva.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNTrans As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents btnVerTrans As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents pnNueva As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents tsbGuardar As ToolStripButton
    Friend WithEvents tbSaldoRec As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbSaldoEmi As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbNotas As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents tbTtrans As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents dtpFecha As DateTimePicker
    Friend WithEvents cbBancoReceptor As ComboBox
    Friend WithEvents cbBancoEmisor As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
