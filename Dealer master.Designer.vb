<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dealer_master
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dealer_master))
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel2 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.txtid = New Guna.UI.WinForms.GunaTextBox()
        Me.txtdname = New Guna.UI.WinForms.GunaTextBox()
        Me.txtcity = New Guna.UI.WinForms.GunaTextBox()
        Me.txtmob = New Guna.UI.WinForms.GunaTextBox()
        Me.txtgst = New Guna.UI.WinForms.GunaTextBox()
        Me.txtac = New Guna.UI.WinForms.GunaTextBox()
        Me.txtifsc = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel7 = New Guna.UI.WinForms.GunaLabel()
        Me.btnnew = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnsave = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnsearch = New Guna.UI.WinForms.GunaGradientButton()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GunaGradientButton1 = New Guna.UI.WinForms.GunaGradientButton()
        Me.GunaGradientPanel1 = New Guna.UI.WinForms.GunaGradientPanel()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.GunaLabel8 = New Guna.UI.WinForms.GunaLabel()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaGradientPanel1.SuspendLayout()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(16, 39)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(33, 17)
        Me.GunaLabel1.TabIndex = 1
        Me.GunaLabel1.Text = "ID"
        '
        'GunaLabel2
        '
        Me.GunaLabel2.AutoSize = True
        Me.GunaLabel2.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel2.Location = New System.Drawing.Point(16, 91)
        Me.GunaLabel2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel2.Name = "GunaLabel2"
        Me.GunaLabel2.Size = New System.Drawing.Size(160, 17)
        Me.GunaLabel2.TabIndex = 2
        Me.GunaLabel2.Text = "Dealer Name"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(16, 139)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(61, 17)
        Me.GunaLabel3.TabIndex = 3
        Me.GunaLabel3.Text = "City"
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(16, 191)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(134, 17)
        Me.GunaLabel4.TabIndex = 4
        Me.GunaLabel4.Text = "Mobile No."
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(16, 243)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(95, 17)
        Me.GunaLabel5.TabIndex = 5
        Me.GunaLabel5.Text = "GST NO."
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(16, 295)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(155, 17)
        Me.GunaLabel6.TabIndex = 6
        Me.GunaLabel6.Text = "ACCOUNT NO."
        '
        'txtid
        '
        Me.txtid.BaseColor = System.Drawing.Color.White
        Me.txtid.BorderColor = System.Drawing.Color.Silver
        Me.txtid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtid.Location = New System.Drawing.Point(189, 39)
        Me.txtid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtid.Name = "txtid"
        Me.txtid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtid.SelectedText = ""
        Me.txtid.Size = New System.Drawing.Size(177, 26)
        Me.txtid.TabIndex = 7
        '
        'txtdname
        '
        Me.txtdname.BaseColor = System.Drawing.Color.White
        Me.txtdname.BorderColor = System.Drawing.Color.Silver
        Me.txtdname.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtdname.FocusedBaseColor = System.Drawing.Color.White
        Me.txtdname.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtdname.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtdname.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtdname.Location = New System.Drawing.Point(189, 91)
        Me.txtdname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtdname.Name = "txtdname"
        Me.txtdname.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtdname.SelectedText = ""
        Me.txtdname.Size = New System.Drawing.Size(177, 26)
        Me.txtdname.TabIndex = 8
        Me.txtdname.Text = " "
        '
        'txtcity
        '
        Me.txtcity.BaseColor = System.Drawing.Color.White
        Me.txtcity.BorderColor = System.Drawing.Color.Silver
        Me.txtcity.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtcity.FocusedBaseColor = System.Drawing.Color.White
        Me.txtcity.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtcity.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtcity.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtcity.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txtcity.Location = New System.Drawing.Point(189, 139)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtcity.SelectedText = ""
        Me.txtcity.Size = New System.Drawing.Size(177, 26)
        Me.txtcity.TabIndex = 9
        Me.txtcity.Text = " "
        '
        'txtmob
        '
        Me.txtmob.BaseColor = System.Drawing.Color.White
        Me.txtmob.BorderColor = System.Drawing.Color.Silver
        Me.txtmob.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtmob.FocusedBaseColor = System.Drawing.Color.White
        Me.txtmob.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtmob.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtmob.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtmob.Location = New System.Drawing.Point(189, 191)
        Me.txtmob.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmob.MaxLength = 10
        Me.txtmob.Name = "txtmob"
        Me.txtmob.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtmob.SelectedText = ""
        Me.txtmob.Size = New System.Drawing.Size(177, 26)
        Me.txtmob.TabIndex = 10
        Me.txtmob.Text = " "
        '
        'txtgst
        '
        Me.txtgst.BaseColor = System.Drawing.Color.White
        Me.txtgst.BorderColor = System.Drawing.Color.Silver
        Me.txtgst.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtgst.FocusedBaseColor = System.Drawing.Color.White
        Me.txtgst.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtgst.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtgst.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtgst.Location = New System.Drawing.Point(189, 243)
        Me.txtgst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgst.Name = "txtgst"
        Me.txtgst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgst.SelectedText = ""
        Me.txtgst.Size = New System.Drawing.Size(177, 26)
        Me.txtgst.TabIndex = 11
        Me.txtgst.Text = " "
        '
        'txtac
        '
        Me.txtac.BaseColor = System.Drawing.Color.White
        Me.txtac.BorderColor = System.Drawing.Color.Silver
        Me.txtac.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtac.FocusedBaseColor = System.Drawing.Color.White
        Me.txtac.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtac.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtac.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtac.Location = New System.Drawing.Point(189, 295)
        Me.txtac.Margin = New System.Windows.Forms.Padding(2)
        Me.txtac.Name = "txtac"
        Me.txtac.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtac.SelectedText = ""
        Me.txtac.Size = New System.Drawing.Size(177, 26)
        Me.txtac.TabIndex = 12
        Me.txtac.Text = " "
        '
        'txtifsc
        '
        Me.txtifsc.BaseColor = System.Drawing.Color.White
        Me.txtifsc.BorderColor = System.Drawing.Color.Silver
        Me.txtifsc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtifsc.FocusedBaseColor = System.Drawing.Color.White
        Me.txtifsc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtifsc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtifsc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtifsc.Location = New System.Drawing.Point(189, 347)
        Me.txtifsc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtifsc.Name = "txtifsc"
        Me.txtifsc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtifsc.SelectedText = ""
        Me.txtifsc.Size = New System.Drawing.Size(177, 26)
        Me.txtifsc.TabIndex = 13
        '
        'GunaLabel7
        '
        Me.GunaLabel7.AutoSize = True
        Me.GunaLabel7.Font = New System.Drawing.Font("Engravers MT", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel7.Location = New System.Drawing.Point(16, 347)
        Me.GunaLabel7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel7.Name = "GunaLabel7"
        Me.GunaLabel7.Size = New System.Drawing.Size(121, 17)
        Me.GunaLabel7.TabIndex = 14
        Me.GunaLabel7.Text = "IFSC CODE"
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
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Nothing
        Me.btnnew.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnnew.Location = New System.Drawing.Point(7, 399)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnnew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnnew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnew.OnHoverImage = Nothing
        Me.btnnew.OnPressedColor = System.Drawing.Color.Black
        Me.btnnew.Size = New System.Drawing.Size(65, 34)
        Me.btnnew.TabIndex = 15
        Me.btnnew.Text = " NEW"
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
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsave.Location = New System.Drawing.Point(102, 399)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(74, 34)
        Me.btnsave.TabIndex = 16
        Me.btnsave.Text = " SAVE"
        '
        'btnsearch
        '
        Me.btnsearch.AnimationHoverSpeed = 0.07!
        Me.btnsearch.AnimationSpeed = 0.03!
        Me.btnsearch.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnsearch.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnsearch.BorderColor = System.Drawing.Color.Black
        Me.btnsearch.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsearch.FocusedColor = System.Drawing.Color.Empty
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.Color.White
        Me.btnsearch.Image = Nothing
        Me.btnsearch.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsearch.Location = New System.Drawing.Point(208, 399)
        Me.btnsearch.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsearch.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsearch.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsearch.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsearch.OnHoverImage = Nothing
        Me.btnsearch.OnPressedColor = System.Drawing.Color.Black
        Me.btnsearch.Size = New System.Drawing.Size(73, 34)
        Me.btnsearch.TabIndex = 17
        Me.btnsearch.Text = "SEARCH"
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.LightBlue
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7})
        Me.dg.Location = New System.Drawing.Point(400, 32)
        Me.dg.Margin = New System.Windows.Forms.Padding(2)
        Me.dg.Name = "dg"
        Me.dg.RowHeadersVisible = False
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(599, 374)
        Me.dg.TabIndex = 18
        '
        'Column1
        '
        Me.Column1.HeaderText = "ID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "DEALER_NAME"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "CITY"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "MOB_NO"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "GST_NO"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "A/C_NO"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "IFSC_CODE"
        Me.Column7.Name = "Column7"
        '
        'GunaGradientButton1
        '
        Me.GunaGradientButton1.AnimationHoverSpeed = 0.07!
        Me.GunaGradientButton1.AnimationSpeed = 0.03!
        Me.GunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.GunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.GunaGradientButton1.BorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.GunaGradientButton1.FocusedColor = System.Drawing.Color.Empty
        Me.GunaGradientButton1.Font = New System.Drawing.Font("Segoe UI Symbol", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaGradientButton1.ForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.Image = Nothing
        Me.GunaGradientButton1.ImageSize = New System.Drawing.Size(20, 20)
        Me.GunaGradientButton1.Location = New System.Drawing.Point(315, 399)
        Me.GunaGradientButton1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradientButton1.Name = "GunaGradientButton1"
        Me.GunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.GunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White
        Me.GunaGradientButton1.OnHoverImage = Nothing
        Me.GunaGradientButton1.OnPressedColor = System.Drawing.Color.Black
        Me.GunaGradientButton1.Size = New System.Drawing.Size(76, 34)
        Me.GunaGradientButton1.TabIndex = 19
        Me.GunaGradientButton1.Text = "EXIT"
        '
        'GunaGradientPanel1
        '
        Me.GunaGradientPanel1.BackgroundImage = CType(resources.GetObject("GunaGradientPanel1.BackgroundImage"), System.Drawing.Image)
        Me.GunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.GunaGradientPanel1.Controls.Add(Me.GunaGradientButton1)
        Me.GunaGradientPanel1.Controls.Add(Me.dg)
        Me.GunaGradientPanel1.Controls.Add(Me.btnsearch)
        Me.GunaGradientPanel1.Controls.Add(Me.txtac)
        Me.GunaGradientPanel1.Controls.Add(Me.btnsave)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel3)
        Me.GunaGradientPanel1.Controls.Add(Me.btnnew)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel4)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel5)
        Me.GunaGradientPanel1.Controls.Add(Me.txtdname)
        Me.GunaGradientPanel1.Controls.Add(Me.txtid)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel7)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel2)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel6)
        Me.GunaGradientPanel1.Controls.Add(Me.GunaLabel1)
        Me.GunaGradientPanel1.Controls.Add(Me.txtifsc)
        Me.GunaGradientPanel1.Controls.Add(Me.txtcity)
        Me.GunaGradientPanel1.Controls.Add(Me.txtmob)
        Me.GunaGradientPanel1.Controls.Add(Me.txtgst)
        Me.GunaGradientPanel1.GradientColor1 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor2 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor3 = System.Drawing.Color.White
        Me.GunaGradientPanel1.GradientColor4 = System.Drawing.Color.White
        Me.GunaGradientPanel1.Location = New System.Drawing.Point(1, 81)
        Me.GunaGradientPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaGradientPanel1.Name = "GunaGradientPanel1"
        Me.GunaGradientPanel1.Size = New System.Drawing.Size(1061, 488)
        Me.GunaGradientPanel1.TabIndex = 21
        Me.GunaGradientPanel1.Text = "helo"
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.GunaLabel8)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(261, 3)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(526, 65)
        Me.GunaShadowPanel1.TabIndex = 22
        '
        'GunaLabel8
        '
        Me.GunaLabel8.AutoSize = True
        Me.GunaLabel8.Font = New System.Drawing.Font("Segoe UI", 22.2!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel8.Location = New System.Drawing.Point(94, 11)
        Me.GunaLabel8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel8.Name = "GunaLabel8"
        Me.GunaLabel8.Size = New System.Drawing.Size(360, 41)
        Me.GunaLabel8.TabIndex = 0
        Me.GunaLabel8.Text = " DEALER INFORMATION"
        '
        'Dealer_master
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.NavajoWhite
        Me.ClientSize = New System.Drawing.Size(1060, 614)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.GunaGradientPanel1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Dealer_master"
        Me.Text = "Dealer_master"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaGradientPanel1.ResumeLayout(False)
        Me.GunaGradientPanel1.PerformLayout()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel2 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtdname As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtcity As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtmob As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtgst As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtac As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtifsc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel7 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnnew As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnsearch As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents GunaGradientButton1 As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaGradientPanel1 As Guna.UI.WinForms.GunaGradientPanel
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents GunaLabel8 As Guna.UI.WinForms.GunaLabel
End Class
