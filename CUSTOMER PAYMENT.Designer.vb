<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER_PAYMENT
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.txtcustname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.btnnew = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btnexit = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btnsave = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.txtextra = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtbal = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtpaid = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txttot = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtcity = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtid = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GunaPanel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.Label4)
        Me.GunaPanel1.Location = New System.Drawing.Point(316, 28)
        Me.GunaPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(624, 78)
        Me.GunaPanel1.TabIndex = 141
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(117, 18)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(387, 41)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "CUSTOMER PAYMENT"
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.txtcustname)
        Me.GunaShadowPanel1.Controls.Add(Me.btnnew)
        Me.GunaShadowPanel1.Controls.Add(Me.btnexit)
        Me.GunaShadowPanel1.Controls.Add(Me.btnsave)
        Me.GunaShadowPanel1.Controls.Add(Me.dg)
        Me.GunaShadowPanel1.Controls.Add(Me.txtextra)
        Me.GunaShadowPanel1.Controls.Add(Me.Label9)
        Me.GunaShadowPanel1.Controls.Add(Me.txtbal)
        Me.GunaShadowPanel1.Controls.Add(Me.Label8)
        Me.GunaShadowPanel1.Controls.Add(Me.txtpaid)
        Me.GunaShadowPanel1.Controls.Add(Me.Label7)
        Me.GunaShadowPanel1.Controls.Add(Me.txttot)
        Me.GunaShadowPanel1.Controls.Add(Me.txtcity)
        Me.GunaShadowPanel1.Controls.Add(Me.txtid)
        Me.GunaShadowPanel1.Controls.Add(Me.Label1)
        Me.GunaShadowPanel1.Controls.Add(Me.Label3)
        Me.GunaShadowPanel1.Controls.Add(Me.Label2)
        Me.GunaShadowPanel1.Controls.Add(Me.Label5)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(60, 127)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(1148, 610)
        Me.GunaShadowPanel1.TabIndex = 142
        '
        'txtcustname
        '
        Me.txtcustname.BackColor = System.Drawing.Color.White
        Me.txtcustname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcustname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.LineColor = System.Drawing.Color.Gainsboro
        Me.txtcustname.Location = New System.Drawing.Point(272, 122)
        Me.txtcustname.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcustname.SelectedText = ""
        Me.txtcustname.Size = New System.Drawing.Size(231, 37)
        Me.txtcustname.TabIndex = 22
        '
        'btnnew
        '
        Me.btnnew.AnimationHoverSpeed = 0.07!
        Me.btnnew.AnimationSpeed = 0.03!
        Me.btnnew.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnnew.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnnew.BorderColor = System.Drawing.Color.Black
        Me.btnnew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnew.FocusedColor = System.Drawing.Color.Empty
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Nothing
        Me.btnnew.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnnew.Location = New System.Drawing.Point(765, 494)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnnew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnnew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnew.OnHoverImage = Nothing
        Me.btnnew.OnPressedColor = System.Drawing.Color.Black
        Me.btnnew.Size = New System.Drawing.Size(135, 66)
        Me.btnnew.TabIndex = 21
        Me.btnnew.Text = "NEW"
        '
        'btnexit
        '
        Me.btnexit.AnimationHoverSpeed = 0.07!
        Me.btnexit.AnimationSpeed = 0.03!
        Me.btnexit.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexit.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexit.BorderColor = System.Drawing.Color.Black
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexit.FocusedColor = System.Drawing.Color.Empty
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = Nothing
        Me.btnexit.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnexit.Location = New System.Drawing.Point(948, 494)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnexit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexit.OnHoverImage = Nothing
        Me.btnexit.OnPressedColor = System.Drawing.Color.Black
        Me.btnexit.Size = New System.Drawing.Size(135, 66)
        Me.btnexit.TabIndex = 20
        Me.btnexit.Text = "EXIT"
        '
        'btnsave
        '
        Me.btnsave.AnimationHoverSpeed = 0.07!
        Me.btnsave.AnimationSpeed = 0.03!
        Me.btnsave.BaseColor1 = System.Drawing.Color.DarkGreen
        Me.btnsave.BaseColor2 = System.Drawing.Color.Lime
        Me.btnsave.BorderColor = System.Drawing.Color.Black
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsave.FocusedColor = System.Drawing.Color.Empty
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnsave.Location = New System.Drawing.Point(601, 494)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(135, 66)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "SAVE"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.BackgroundColor = System.Drawing.Color.DarkSalmon
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(531, 63)
        Me.dg.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(567, 409)
        Me.dg.TabIndex = 18
        Me.dg.Visible = False
        '
        'txtextra
        '
        Me.txtextra.BackColor = System.Drawing.Color.White
        Me.txtextra.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtextra.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtextra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextra.LineColor = System.Drawing.Color.Gainsboro
        Me.txtextra.Location = New System.Drawing.Point(275, 450)
        Me.txtextra.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtextra.MaxLength = 10
        Me.txtextra.Name = "txtextra"
        Me.txtextra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtextra.SelectedText = ""
        Me.txtextra.Size = New System.Drawing.Size(231, 37)
        Me.txtextra.TabIndex = 16
        Me.txtextra.Text = " "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(135, 450)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(69, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "EXTRA"
        '
        'txtbal
        '
        Me.txtbal.BackColor = System.Drawing.Color.White
        Me.txtbal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtbal.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtbal.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbal.LineColor = System.Drawing.Color.Gainsboro
        Me.txtbal.Location = New System.Drawing.Point(275, 385)
        Me.txtbal.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtbal.MaxLength = 10
        Me.txtbal.Name = "txtbal"
        Me.txtbal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtbal.SelectedText = ""
        Me.txtbal.Size = New System.Drawing.Size(231, 37)
        Me.txtbal.TabIndex = 14
        Me.txtbal.Text = " "
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(135, 385)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(95, 20)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "BALANCE"
        '
        'txtpaid
        '
        Me.txtpaid.BackColor = System.Drawing.Color.White
        Me.txtpaid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpaid.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpaid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpaid.LineColor = System.Drawing.Color.Gainsboro
        Me.txtpaid.Location = New System.Drawing.Point(275, 320)
        Me.txtpaid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtpaid.MaxLength = 10
        Me.txtpaid.Name = "txtpaid"
        Me.txtpaid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpaid.SelectedText = ""
        Me.txtpaid.Size = New System.Drawing.Size(231, 37)
        Me.txtpaid.TabIndex = 12
        Me.txtpaid.Text = " "
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(135, 320)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(96, 20)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "AMT PAID"
        '
        'txttot
        '
        Me.txttot.BackColor = System.Drawing.Color.White
        Me.txttot.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttot.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttot.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttot.LineColor = System.Drawing.Color.Gainsboro
        Me.txttot.Location = New System.Drawing.Point(275, 252)
        Me.txttot.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txttot.MaxLength = 10
        Me.txttot.Name = "txttot"
        Me.txttot.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttot.SelectedText = ""
        Me.txttot.Size = New System.Drawing.Size(231, 37)
        Me.txttot.TabIndex = 8
        Me.txttot.Text = " "
        '
        'txtcity
        '
        Me.txtcity.BackColor = System.Drawing.Color.White
        Me.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcity.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.LineColor = System.Drawing.Color.Gainsboro
        Me.txtcity.Location = New System.Drawing.Point(275, 182)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcity.SelectedText = ""
        Me.txtcity.Size = New System.Drawing.Size(231, 37)
        Me.txtcity.TabIndex = 7
        Me.txtcity.Text = " "
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.LineColor = System.Drawing.Color.Gainsboro
        Me.txtid.Location = New System.Drawing.Point(275, 63)
        Me.txtid.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(231, 37)
        Me.txtid.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(135, 252)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 20)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "TOTAL"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(132, 182)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(55, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " CITY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 122)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUST_NAME"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(132, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(28, 20)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "ID"
        '
        'CUSTOMER_PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1257, 817)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "CUSTOMER_PAYMENT"
        Me.Text = "CUSTOMER_PAYMENT"
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents txttot As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtcity As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtid As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtextra As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtbal As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtpaid As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnnew As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btnexit As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents txtcustname As Guna.UI.WinForms.GunaLineTextBox
End Class
