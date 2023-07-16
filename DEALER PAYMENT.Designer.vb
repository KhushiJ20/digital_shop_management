<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DEALER_PAYMENT
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.inwdate = New System.Windows.Forms.DateTimePicker()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtdcode = New System.Windows.Forms.TextBox()
        Me.cmbdealername = New System.Windows.Forms.ComboBox()
        Me.lblExtra = New System.Windows.Forms.Label()
        Me.txtextra = New System.Windows.Forms.TextBox()
        Me.lblBalance = New System.Windows.Forms.Label()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.lblamtpaid = New System.Windows.Forms.Label()
        Me.txtAmountpaid = New System.Windows.Forms.TextBox()
        Me.lbltotal = New System.Windows.Forms.Label()
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.lblcity = New System.Windows.Forms.Label()
        Me.lblfirmname = New System.Windows.Forms.Label()
        Me.lbldealercode = New System.Windows.Forms.Label()
        Me.lblreceipttno = New System.Windows.Forms.Label()
        Me.txtreceiptno = New System.Windows.Forms.TextBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaPanel1 = New Guna.UI.WinForms.GunaPanel()
        Me.btnsave = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnexit = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnnew = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.GunaPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Tomato
        Me.Label4.Location = New System.Drawing.Point(88, 15)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(263, 33)
        Me.Label4.TabIndex = 138
        Me.Label4.Text = "DEALER PAYMENT"
        '
        'inwdate
        '
        Me.inwdate.CalendarFont = New System.Drawing.Font("Microsoft YaHei", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.inwdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.inwdate.Location = New System.Drawing.Point(421, 19)
        Me.inwdate.Name = "inwdate"
        Me.inwdate.Size = New System.Drawing.Size(156, 20)
        Me.inwdate.TabIndex = 137
        '
        'txtcity
        '
        Me.txtcity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcity.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(249, 188)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(253, 25)
        Me.txtcity.TabIndex = 136
        '
        'txtdcode
        '
        Me.txtdcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtdcode.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdcode.Location = New System.Drawing.Point(251, 92)
        Me.txtdcode.Name = "txtdcode"
        Me.txtdcode.Size = New System.Drawing.Size(96, 25)
        Me.txtdcode.TabIndex = 134
        '
        'cmbdealername
        '
        Me.cmbdealername.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbdealername.FormattingEnabled = True
        Me.cmbdealername.Location = New System.Drawing.Point(250, 141)
        Me.cmbdealername.Name = "cmbdealername"
        Me.cmbdealername.Size = New System.Drawing.Size(255, 25)
        Me.cmbdealername.TabIndex = 133
        '
        'lblExtra
        '
        Me.lblExtra.AutoSize = True
        Me.lblExtra.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExtra.Location = New System.Drawing.Point(172, 369)
        Me.lblExtra.Name = "lblExtra"
        Me.lblExtra.Size = New System.Drawing.Size(50, 18)
        Me.lblExtra.TabIndex = 129
        Me.lblExtra.Text = "Extra"
        '
        'txtextra
        '
        Me.txtextra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtextra.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextra.Location = New System.Drawing.Point(250, 368)
        Me.txtextra.Name = "txtextra"
        Me.txtextra.Size = New System.Drawing.Size(253, 25)
        Me.txtextra.TabIndex = 128
        '
        'lblBalance
        '
        Me.lblBalance.AutoSize = True
        Me.lblBalance.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBalance.Location = New System.Drawing.Point(148, 325)
        Me.lblBalance.Name = "lblBalance"
        Me.lblBalance.Size = New System.Drawing.Size(74, 18)
        Me.lblBalance.TabIndex = 127
        Me.lblBalance.Text = "Balance"
        '
        'txtbalance
        '
        Me.txtbalance.BackColor = System.Drawing.Color.LavenderBlush
        Me.txtbalance.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtbalance.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbalance.Location = New System.Drawing.Point(249, 324)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(253, 25)
        Me.txtbalance.TabIndex = 126
        '
        'lblamtpaid
        '
        Me.lblamtpaid.AutoSize = True
        Me.lblamtpaid.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblamtpaid.Location = New System.Drawing.Point(115, 283)
        Me.lblamtpaid.Name = "lblamtpaid"
        Me.lblamtpaid.Size = New System.Drawing.Size(109, 18)
        Me.lblamtpaid.TabIndex = 125
        Me.lblamtpaid.Text = "Amount Paid"
        '
        'txtAmountpaid
        '
        Me.txtAmountpaid.BackColor = System.Drawing.Color.SeaShell
        Me.txtAmountpaid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAmountpaid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAmountpaid.Location = New System.Drawing.Point(249, 276)
        Me.txtAmountpaid.Name = "txtAmountpaid"
        Me.txtAmountpaid.Size = New System.Drawing.Size(253, 25)
        Me.txtAmountpaid.TabIndex = 124
        '
        'lbltotal
        '
        Me.lbltotal.AutoSize = True
        Me.lbltotal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotal.Location = New System.Drawing.Point(174, 241)
        Me.lbltotal.Name = "lbltotal"
        Me.lbltotal.Size = New System.Drawing.Size(48, 18)
        Me.lbltotal.TabIndex = 123
        Me.lbltotal.Text = "Total"
        '
        'txttotal
        '
        Me.txttotal.BackColor = System.Drawing.Color.SkyBlue
        Me.txttotal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txttotal.Location = New System.Drawing.Point(250, 234)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(253, 25)
        Me.txttotal.TabIndex = 122
        '
        'lblcity
        '
        Me.lblcity.AutoSize = True
        Me.lblcity.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcity.Location = New System.Drawing.Point(183, 195)
        Me.lblcity.Name = "lblcity"
        Me.lblcity.Size = New System.Drawing.Size(39, 18)
        Me.lblcity.TabIndex = 121
        Me.lblcity.Text = "City"
        '
        'lblfirmname
        '
        Me.lblfirmname.AutoSize = True
        Me.lblfirmname.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfirmname.Location = New System.Drawing.Point(113, 148)
        Me.lblfirmname.Name = "lblfirmname"
        Me.lblfirmname.Size = New System.Drawing.Size(111, 18)
        Me.lblfirmname.TabIndex = 119
        Me.lblfirmname.Text = "Dealer Name"
        '
        'lbldealercode
        '
        Me.lbldealercode.AutoSize = True
        Me.lbldealercode.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldealercode.Location = New System.Drawing.Point(119, 94)
        Me.lbldealercode.Name = "lbldealercode"
        Me.lbldealercode.Size = New System.Drawing.Size(105, 18)
        Me.lbldealercode.TabIndex = 118
        Me.lbldealercode.Text = "Dealer code"
        '
        'lblreceipttno
        '
        Me.lblreceipttno.AutoSize = True
        Me.lblreceipttno.Font = New System.Drawing.Font("Arial Rounded MT Bold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblreceipttno.Location = New System.Drawing.Point(121, 55)
        Me.lblreceipttno.Name = "lblreceipttno"
        Me.lblreceipttno.Size = New System.Drawing.Size(101, 18)
        Me.lblreceipttno.TabIndex = 117
        Me.lblreceipttno.Text = "Receipt No."
        '
        'txtreceiptno
        '
        Me.txtreceiptno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtreceiptno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtreceiptno.Location = New System.Drawing.Point(250, 53)
        Me.txtreceiptno.Name = "txtreceiptno"
        Me.txtreceiptno.Size = New System.Drawing.Size(96, 25)
        Me.txtreceiptno.TabIndex = 116
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.White
        Me.GunaShadowPanel1.Controls.Add(Me.txttotal)
        Me.GunaShadowPanel1.Controls.Add(Me.txtreceiptno)
        Me.GunaShadowPanel1.Controls.Add(Me.inwdate)
        Me.GunaShadowPanel1.Controls.Add(Me.lblreceipttno)
        Me.GunaShadowPanel1.Controls.Add(Me.txtcity)
        Me.GunaShadowPanel1.Controls.Add(Me.lbldealercode)
        Me.GunaShadowPanel1.Controls.Add(Me.lblfirmname)
        Me.GunaShadowPanel1.Controls.Add(Me.txtdcode)
        Me.GunaShadowPanel1.Controls.Add(Me.cmbdealername)
        Me.GunaShadowPanel1.Controls.Add(Me.lblcity)
        Me.GunaShadowPanel1.Controls.Add(Me.lbltotal)
        Me.GunaShadowPanel1.Controls.Add(Me.txtAmountpaid)
        Me.GunaShadowPanel1.Controls.Add(Me.lblamtpaid)
        Me.GunaShadowPanel1.Controls.Add(Me.lblExtra)
        Me.GunaShadowPanel1.Controls.Add(Me.txtbalance)
        Me.GunaShadowPanel1.Controls.Add(Me.txtextra)
        Me.GunaShadowPanel1.Controls.Add(Me.lblBalance)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(83, 92)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(609, 472)
        Me.GunaShadowPanel1.TabIndex = 139
        '
        'GunaPanel1
        '
        Me.GunaPanel1.Controls.Add(Me.Label4)
        Me.GunaPanel1.Location = New System.Drawing.Point(179, 12)
        Me.GunaPanel1.Name = "GunaPanel1"
        Me.GunaPanel1.Size = New System.Drawing.Size(438, 63)
        Me.GunaPanel1.TabIndex = 140
        '
        'btnsave
        '
        Me.btnsave.AnimationHoverSpeed = 0.07!
        Me.btnsave.AnimationSpeed = 0.03!
        Me.btnsave.BaseColor1 = System.Drawing.Color.DarkGreen
        Me.btnsave.BaseColor2 = System.Drawing.Color.LightGreen
        Me.btnsave.BorderColor = System.Drawing.Color.Black
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsave.FocusedColor = System.Drawing.Color.Empty
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsave.Location = New System.Drawing.Point(333, 587)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(112, 42)
        Me.btnsave.TabIndex = 141
        Me.btnsave.Text = " SAVE"
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
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = Nothing
        Me.btnexit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnexit.Location = New System.Drawing.Point(504, 587)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnexit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexit.OnHoverImage = Nothing
        Me.btnexit.OnPressedColor = System.Drawing.Color.Black
        Me.btnexit.Size = New System.Drawing.Size(104, 42)
        Me.btnexit.TabIndex = 142
        Me.btnexit.Text = " EXIT"
        '
        'btnnew
        '
        Me.btnnew.AnimationHoverSpeed = 0.07!
        Me.btnnew.AnimationSpeed = 0.03!
        Me.btnnew.BaseColor1 = System.Drawing.Color.RoyalBlue
        Me.btnnew.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnnew.BorderColor = System.Drawing.Color.Black
        Me.btnnew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnew.FocusedColor = System.Drawing.Color.Empty
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Nothing
        Me.btnnew.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnnew.Location = New System.Drawing.Point(150, 587)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnnew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnnew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnew.OnHoverImage = Nothing
        Me.btnnew.OnPressedColor = System.Drawing.Color.Black
        Me.btnnew.Size = New System.Drawing.Size(112, 42)
        Me.btnnew.TabIndex = 143
        Me.btnnew.Text = " NEW"
        '
        'DEALER_PAYMENT
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(855, 665)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.GunaPanel1)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Name = "DEALER_PAYMENT"
        Me.Text = "DEALER_PAYMENT"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.GunaPanel1.ResumeLayout(False)
        Me.GunaPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents inwdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtdcode As System.Windows.Forms.TextBox
    Friend WithEvents cmbdealername As System.Windows.Forms.ComboBox
    Friend WithEvents lblExtra As System.Windows.Forms.Label
    Friend WithEvents txtextra As System.Windows.Forms.TextBox
    Friend WithEvents lblBalance As System.Windows.Forms.Label
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents lblamtpaid As System.Windows.Forms.Label
    Friend WithEvents txtAmountpaid As System.Windows.Forms.TextBox
    Friend WithEvents lbltotal As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents lblcity As System.Windows.Forms.Label
    Friend WithEvents lblfirmname As System.Windows.Forms.Label
    Friend WithEvents lbldealercode As System.Windows.Forms.Label
    Friend WithEvents lblreceipttno As System.Windows.Forms.Label
    Friend WithEvents txtreceiptno As System.Windows.Forms.TextBox
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaPanel1 As Guna.UI.WinForms.GunaPanel
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnexit As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnnew As Guna.UI.WinForms.GunaGradientButton
End Class
