<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUST_ACC
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
        Me.dtpto = New System.Windows.Forms.DateTimePicker()
        Me.dtpfrom = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.lblbal = New System.Windows.Forms.Label()
        Me.lblpaid = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.btnexit = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnprint = New Guna.UI.WinForms.GunaGradientButton()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.btnshow = New Guna.UI.WinForms.GunaGradientButton()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtpto
        '
        Me.dtpto.CustomFormat = "dd-MMM-yy"
        Me.dtpto.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpto.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpto.Location = New System.Drawing.Point(271, 168)
        Me.dtpto.Name = "dtpto"
        Me.dtpto.Size = New System.Drawing.Size(156, 23)
        Me.dtpto.TabIndex = 216
        Me.dtpto.Value = New Date(2022, 5, 11, 0, 0, 0, 0)
        '
        'dtpfrom
        '
        Me.dtpfrom.CustomFormat = "dd-MMM-yy"
        Me.dtpfrom.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpfrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtpfrom.Location = New System.Drawing.Point(94, 168)
        Me.dtpfrom.Name = "dtpfrom"
        Me.dtpfrom.Size = New System.Drawing.Size(156, 23)
        Me.dtpfrom.TabIndex = 215
        Me.dtpfrom.Value = New Date(2017, 7, 27, 0, 0, 0, 0)
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(44, 84)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(44, 17)
        Me.Label12.TabIndex = 212
        Me.Label12.Text = "Name"
        '
        'txtcustname
        '
        Me.txtcustname.BackColor = System.Drawing.Color.PaleTurquoise
        Me.txtcustname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtcustname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(94, 82)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(556, 25)
        Me.txtcustname.TabIndex = 211
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Red
        Me.Label4.Font = New System.Drawing.Font("Tahoma", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(198, 18)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(349, 33)
        Me.Label4.TabIndex = 202
        Me.Label4.Text = "Customer Account Detail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label2.Location = New System.Drawing.Point(429, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 17)
        Me.Label2.TabIndex = 197
        Me.Label2.Text = "Balance"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label1.Location = New System.Drawing.Point(338, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 17)
        Me.Label1.TabIndex = 196
        Me.Label1.Text = "Paid"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.BlueViolet
        Me.Label13.Location = New System.Drawing.Point(234, 532)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(37, 17)
        Me.Label13.TabIndex = 195
        Me.Label13.Text = "Total"
        '
        'lblbal
        '
        Me.lblbal.AutoSize = True
        Me.lblbal.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.lblbal.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbal.ForeColor = System.Drawing.Color.White
        Me.lblbal.Location = New System.Drawing.Point(423, 553)
        Me.lblbal.Name = "lblbal"
        Me.lblbal.Size = New System.Drawing.Size(73, 23)
        Me.lblbal.TabIndex = 193
        Me.lblbal.Text = "Label3"
        '
        'lblpaid
        '
        Me.lblpaid.AutoSize = True
        Me.lblpaid.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.lblpaid.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblpaid.ForeColor = System.Drawing.Color.White
        Me.lblpaid.Location = New System.Drawing.Point(319, 553)
        Me.lblpaid.Name = "lblpaid"
        Me.lblpaid.Size = New System.Drawing.Size(73, 23)
        Me.lblpaid.TabIndex = 192
        Me.lblpaid.Text = "Label2"
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.BackColor = System.Drawing.Color.Red
        Me.lbltot.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.ForeColor = System.Drawing.Color.White
        Me.lbltot.Location = New System.Drawing.Point(219, 553)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(73, 23)
        Me.lbltot.TabIndex = 191
        Me.lbltot.Text = "Label1"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.LightCoral
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Location = New System.Drawing.Point(47, 197)
        Me.dg.Name = "dg"
        Me.dg.Size = New System.Drawing.Size(603, 317)
        Me.dg.TabIndex = 219
        '
        'btnexit
        '
        Me.btnexit.AnimationHoverSpeed = 0.07!
        Me.btnexit.AnimationSpeed = 0.03!
        Me.btnexit.BaseColor1 = System.Drawing.Color.Red
        Me.btnexit.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnexit.BorderColor = System.Drawing.Color.Black
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexit.FocusedColor = System.Drawing.Color.Empty
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = Nothing
        Me.btnexit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnexit.Location = New System.Drawing.Point(237, 592)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnexit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexit.OnHoverImage = Nothing
        Me.btnexit.OnPressedColor = System.Drawing.Color.Black
        Me.btnexit.Size = New System.Drawing.Size(100, 42)
        Me.btnexit.TabIndex = 225
        Me.btnexit.Text = "EXIT"
        '
        'btnprint
        '
        Me.btnprint.AnimationHoverSpeed = 0.07!
        Me.btnprint.AnimationSpeed = 0.03!
        Me.btnprint.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnprint.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnprint.BorderColor = System.Drawing.Color.Black
        Me.btnprint.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnprint.FocusedColor = System.Drawing.Color.Empty
        Me.btnprint.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Image = Nothing
        Me.btnprint.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnprint.Location = New System.Drawing.Point(372, 592)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnprint.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnprint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnprint.OnHoverImage = Nothing
        Me.btnprint.OnPressedColor = System.Drawing.Color.Black
        Me.btnprint.Size = New System.Drawing.Size(100, 42)
        Me.btnprint.TabIndex = 226
        Me.btnprint.Text = "PRINT"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.BackgroundColor = System.Drawing.Color.PaleVioletRed
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(311, 101)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(339, 57)
        Me.dgv.TabIndex = 227
        Me.dgv.Visible = False
        '
        'btnshow
        '
        Me.btnshow.AnimationHoverSpeed = 0.07!
        Me.btnshow.AnimationSpeed = 0.03!
        Me.btnshow.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnshow.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnshow.BorderColor = System.Drawing.Color.Black
        Me.btnshow.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnshow.FocusedColor = System.Drawing.Color.Empty
        Me.btnshow.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnshow.ForeColor = System.Drawing.Color.White
        Me.btnshow.Image = Nothing
        Me.btnshow.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnshow.Location = New System.Drawing.Point(454, 164)
        Me.btnshow.Name = "btnshow"
        Me.btnshow.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnshow.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnshow.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnshow.OnHoverForeColor = System.Drawing.Color.White
        Me.btnshow.OnHoverImage = Nothing
        Me.btnshow.OnPressedColor = System.Drawing.Color.Black
        Me.btnshow.Size = New System.Drawing.Size(135, 25)
        Me.btnshow.TabIndex = 228
        Me.btnshow.Text = "SHOW BY DATE"
        '
        'CUST_ACC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleGoldenrod
        Me.ClientSize = New System.Drawing.Size(856, 657)
        Me.Controls.Add(Me.btnshow)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.dtpto)
        Me.Controls.Add(Me.dtpfrom)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.lblbal)
        Me.Controls.Add(Me.lblpaid)
        Me.Controls.Add(Me.lbltot)
        Me.Name = "CUST_ACC"
        Me.Text = "CUST_ACC"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtpto As System.Windows.Forms.DateTimePicker
    Friend WithEvents dtpfrom As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents lblbal As System.Windows.Forms.Label
    Friend WithEvents lblpaid As System.Windows.Forms.Label
    Friend WithEvents lbltot As System.Windows.Forms.Label
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents btnexit As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnprint As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents btnshow As Guna.UI.WinForms.GunaGradientButton
End Class
