<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CUSTOMER_INFO
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
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.txtaddress = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtmob = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtcity = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtname = New Guna.UI.WinForms.GunaLineTextBox()
        Me.txtid = New Guna.UI.WinForms.GunaLineTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnnew = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnsave = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnsearch = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnexit = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaShadowPanel2 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnupdate = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaShadowPanel1.SuspendLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.txtaddress)
        Me.GunaShadowPanel1.Controls.Add(Me.Label6)
        Me.GunaShadowPanel1.Controls.Add(Me.txtmob)
        Me.GunaShadowPanel1.Controls.Add(Me.txtcity)
        Me.GunaShadowPanel1.Controls.Add(Me.txtname)
        Me.GunaShadowPanel1.Controls.Add(Me.txtid)
        Me.GunaShadowPanel1.Controls.Add(Me.Label4)
        Me.GunaShadowPanel1.Controls.Add(Me.Label3)
        Me.GunaShadowPanel1.Controls.Add(Me.Label2)
        Me.GunaShadowPanel1.Controls.Add(Me.Label1)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(9, 80)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(339, 375)
        Me.GunaShadowPanel1.TabIndex = 0
        '
        'txtaddress
        '
        Me.txtaddress.BackColor = System.Drawing.Color.White
        Me.txtaddress.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtaddress.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtaddress.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtaddress.LineColor = System.Drawing.Color.Gainsboro
        Me.txtaddress.Location = New System.Drawing.Point(134, 166)
        Me.txtaddress.Margin = New System.Windows.Forms.Padding(2)
        Me.txtaddress.Name = "txtaddress"
        Me.txtaddress.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtaddress.SelectedText = ""
        Me.txtaddress.Size = New System.Drawing.Size(166, 26)
        Me.txtaddress.TabIndex = 10
        Me.txtaddress.Text = " "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(30, 174)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(81, 17)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "ADDRESS"
        '
        'txtmob
        '
        Me.txtmob.BackColor = System.Drawing.Color.White
        Me.txtmob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmob.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmob.LineColor = System.Drawing.Color.Gainsboro
        Me.txtmob.Location = New System.Drawing.Point(134, 296)
        Me.txtmob.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmob.MaxLength = 10
        Me.txtmob.Name = "txtmob"
        Me.txtmob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmob.SelectedText = ""
        Me.txtmob.Size = New System.Drawing.Size(166, 26)
        Me.txtmob.TabIndex = 8
        Me.txtmob.Text = " "
        '
        'txtcity
        '
        Me.txtcity.BackColor = System.Drawing.Color.White
        Me.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcity.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.LineColor = System.Drawing.Color.Gainsboro
        Me.txtcity.Location = New System.Drawing.Point(134, 230)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcity.SelectedText = ""
        Me.txtcity.Size = New System.Drawing.Size(166, 26)
        Me.txtcity.TabIndex = 7
        Me.txtcity.Text = " "
        '
        'txtname
        '
        Me.txtname.BackColor = System.Drawing.Color.White
        Me.txtname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtname.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.LineColor = System.Drawing.Color.Gainsboro
        Me.txtname.Location = New System.Drawing.Point(134, 108)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtname.SelectedText = ""
        Me.txtname.Size = New System.Drawing.Size(166, 26)
        Me.txtname.TabIndex = 6
        Me.txtname.Text = " "
        '
        'txtid
        '
        Me.txtid.BackColor = System.Drawing.Color.White
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedLineColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.LineColor = System.Drawing.Color.Gainsboro
        Me.txtid.Location = New System.Drawing.Point(134, 29)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(173, 26)
        Me.txtid.TabIndex = 5
        Me.txtid.Text = " "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(27, 306)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(79, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = " MOB_NO"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(27, 230)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = " CITY"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 108)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(101, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "CUST_NAME"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(27, 40)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.PaleTurquoise
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column5, Me.Column3, Me.Column4})
        Me.dg.GridColor = System.Drawing.SystemColors.ActiveBorder
        Me.dg.Location = New System.Drawing.Point(373, 80)
        Me.dg.Margin = New System.Windows.Forms.Padding(2)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(392, 375)
        Me.dg.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "CUST_NAME"
        Me.Column2.Name = "Column2"
        '
        'Column5
        '
        Me.Column5.HeaderText = "ADDRESS"
        Me.Column5.Name = "Column5"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CITY"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "MOB_N0"
        Me.Column4.Name = "Column4"
        '
        'btnnew
        '
        Me.btnnew.AnimationHoverSpeed = 0.07!
        Me.btnnew.AnimationSpeed = 0.03!
        Me.btnnew.BaseColor1 = System.Drawing.Color.Gold
        Me.btnnew.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnnew.BorderColor = System.Drawing.Color.Black
        Me.btnnew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnew.FocusedColor = System.Drawing.Color.Empty
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Nothing
        Me.btnnew.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnnew.Location = New System.Drawing.Point(9, 476)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnnew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnnew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnew.OnHoverImage = Nothing
        Me.btnnew.OnPressedColor = System.Drawing.Color.Black
        Me.btnnew.Size = New System.Drawing.Size(120, 34)
        Me.btnnew.TabIndex = 9
        Me.btnnew.Text = "NEW"
        Me.btnnew.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsave
        '
        Me.btnsave.AnimationHoverSpeed = 0.07!
        Me.btnsave.AnimationSpeed = 0.03!
        Me.btnsave.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnsave.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnsave.BorderColor = System.Drawing.Color.Black
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsave.FocusedColor = System.Drawing.Color.Empty
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsave.Location = New System.Drawing.Point(152, 476)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(120, 34)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = " SAVE"
        Me.btnsave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnsearch
        '
        Me.btnsearch.AnimationHoverSpeed = 0.07!
        Me.btnsearch.AnimationSpeed = 0.03!
        Me.btnsearch.BaseColor1 = System.Drawing.Color.DarkGreen
        Me.btnsearch.BaseColor2 = System.Drawing.Color.MediumSeaGreen
        Me.btnsearch.BorderColor = System.Drawing.Color.Black
        Me.btnsearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Nothing
        Me.btnsearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsearch.Location = New System.Drawing.Point(291, 476)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsearch.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsearch.OnHoverImage = Nothing
        Me.btnsearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnsearch.Size = New System.Drawing.Size(120, 34)
        Me.btnsearch.TabIndex = 11
        Me.btnsearch.Text = " SEARCH"
        Me.btnsearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnexit
        '
        Me.btnexit.AnimationHoverSpeed = 0.07!
        Me.btnexit.AnimationSpeed = 0.03!
        Me.btnexit.BaseColor1 = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.btnexit.BaseColor2 = System.Drawing.Color.Tomato
        Me.btnexit.BorderColor = System.Drawing.Color.Black
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexit.FocusedColor = System.Drawing.Color.Empty
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = Nothing
        Me.btnexit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnexit.Location = New System.Drawing.Point(577, 476)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnexit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexit.OnHoverImage = Nothing
        Me.btnexit.OnPressedColor = System.Drawing.Color.Black
        Me.btnexit.Size = New System.Drawing.Size(120, 34)
        Me.btnexit.TabIndex = 12
        Me.btnexit.Text = " EXIT"
        Me.btnexit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'GunaShadowPanel2
        '
        Me.GunaShadowPanel2.BackColor = System.Drawing.Color.PeachPuff
        Me.GunaShadowPanel2.BaseColor = System.Drawing.Color.Pink
        Me.GunaShadowPanel2.Controls.Add(Me.Label5)
        Me.GunaShadowPanel2.Location = New System.Drawing.Point(88, 10)
        Me.GunaShadowPanel2.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel2.Name = "GunaShadowPanel2"
        Me.GunaShadowPanel2.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel2.Size = New System.Drawing.Size(559, 58)
        Me.GunaShadowPanel2.TabIndex = 13
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Wide Latin", 13.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(41, 18)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(518, 23)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "CUSTOMER INFORMATION"
        '
        'btnupdate
        '
        Me.btnupdate.AnimationHoverSpeed = 0.07!
        Me.btnupdate.AnimationSpeed = 0.03!
        Me.btnupdate.BaseColor1 = System.Drawing.Color.DeepPink
        Me.btnupdate.BaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnupdate.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Image = Nothing
        Me.btnupdate.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnupdate.Location = New System.Drawing.Point(429, 476)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnupdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupdate.OnHoverImage = Nothing
        Me.btnupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdate.Size = New System.Drawing.Size(120, 34)
        Me.btnupdate.TabIndex = 14
        Me.btnupdate.Text = "UPDATE"
        Me.btnupdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'CUSTOMER_INFO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(780, 549)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GunaShadowPanel2)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "CUSTOMER_INFO"
        Me.Text = "CUSTOMER_INFO"
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel2.ResumeLayout(False)
        Me.GunaShadowPanel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents txtmob As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtcity As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtname As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents txtid As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnnew As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnsearch As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnexit As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents GunaShadowPanel2 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtaddress As Guna.UI.WinForms.GunaLineTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnupdate As Guna.UI.WinForms.GunaGradientButton
End Class
