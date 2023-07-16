<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class invoice
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtinward = New System.Windows.Forms.TextBox()
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtcustname = New System.Windows.Forms.TextBox()
        Me.txtcustcity = New System.Windows.Forms.TextBox()
        Me.txtcustmob = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtextra = New System.Windows.Forms.TextBox()
        Me.txtbalance = New System.Windows.Forms.TextBox()
        Me.txtpaidamt = New System.Windows.Forms.TextBox()
        Me.txtgtot = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtperpc = New Guna.UI.WinForms.GunaTextBox()
        Me.lblper = New Guna.UI.WinForms.GunaLabel()
        Me.lblgst = New Guna.UI.WinForms.GunaLabel()
        Me.txtgst = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel6 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel5 = New Guna.UI.WinForms.GunaLabel()
        Me.txttotal = New Guna.UI.WinForms.GunaTextBox()
        Me.txtrate = New Guna.UI.WinForms.GunaTextBox()
        Me.txtqty = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel4 = New Guna.UI.WinForms.GunaLabel()
        Me.txtpid = New Guna.UI.WinForms.GunaTextBox()
        Me.cmbname = New System.Windows.Forms.ComboBox()
        Me.GunaLabel11 = New Guna.UI.WinForms.GunaLabel()
        Me.cmbptype = New System.Windows.Forms.ComboBox()
        Me.GunaLabel1 = New Guna.UI.WinForms.GunaLabel()
        Me.GunaLabel3 = New Guna.UI.WinForms.GunaLabel()
        Me.btnnew = New Guna.UI.WinForms.GunaGradientButton()
        Me.cmbtype = New System.Windows.Forms.ComboBox()
        Me.btnsave = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnexit = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnprint = New Guna.UI.WinForms.GunaGradientButton()
        Me.btnenter = New Guna.UI.WinForms.GunaGradientButton()
        Me.txtNTOT = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel10 = New Guna.UI.WinForms.GunaLabel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtmob = New System.Windows.Forms.TextBox()
        Me.txtcity = New System.Windows.Forms.TextBox()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.txtadd = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtcustadd = New System.Windows.Forms.TextBox()
        Me.txtTGST = New Guna.UI.WinForms.GunaTextBox()
        Me.GunaLabel9 = New Guna.UI.WinForms.GunaLabel()
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.dtpdate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 90)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Inward no."
        '
        'txtinward
        '
        Me.txtinward.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtinward.Location = New System.Drawing.Point(97, 87)
        Me.txtinward.Margin = New System.Windows.Forms.Padding(2)
        Me.txtinward.Name = "txtinward"
        Me.txtinward.Size = New System.Drawing.Size(76, 23)
        Me.txtinward.TabIndex = 1
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10})
        Me.dg.Location = New System.Drawing.Point(17, 305)
        Me.dg.Margin = New System.Windows.Forms.Padding(2)
        Me.dg.Name = "dg"
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(1032, 244)
        Me.dg.TabIndex = 2
        '
        'Column1
        '
        Me.Column1.HeaderText = "PID"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PROD_TYPE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PROD_NAME "
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "QTY"
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        Me.Column5.HeaderText = "RATE"
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        Me.Column6.HeaderText = "PER/PC"
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        Me.Column7.HeaderText = "TOTAL"
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        Me.Column8.HeaderText = "GST"
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        Me.Column9.HeaderText = "TGST"
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        Me.Column10.HeaderText = "NETTOTAL"
        Me.Column10.Name = "Column10"
        '
        'txtcustname
        '
        Me.txtcustname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustname.Location = New System.Drawing.Point(334, 86)
        Me.txtcustname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(242, 23)
        Me.txtcustname.TabIndex = 1
        '
        'txtcustcity
        '
        Me.txtcustcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustcity.Location = New System.Drawing.Point(334, 163)
        Me.txtcustcity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustcity.Name = "txtcustcity"
        Me.txtcustcity.Size = New System.Drawing.Size(242, 23)
        Me.txtcustcity.TabIndex = 4
        '
        'txtcustmob
        '
        Me.txtcustmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustmob.Location = New System.Drawing.Point(334, 197)
        Me.txtcustmob.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustmob.Name = "txtcustmob"
        Me.txtcustmob.Size = New System.Drawing.Size(162, 23)
        Me.txtcustmob.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(206, 89)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(122, 17)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Customer Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(206, 166)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 17)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "City"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(206, 200)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(66, 17)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Mob no."
        '
        'txtextra
        '
        Me.txtextra.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtextra.Location = New System.Drawing.Point(116, 573)
        Me.txtextra.Margin = New System.Windows.Forms.Padding(2)
        Me.txtextra.Name = "txtextra"
        Me.txtextra.Size = New System.Drawing.Size(452, 23)
        Me.txtextra.TabIndex = 9
        '
        'txtbalance
        '
        Me.txtbalance.Location = New System.Drawing.Point(931, 625)
        Me.txtbalance.Margin = New System.Windows.Forms.Padding(2)
        Me.txtbalance.Name = "txtbalance"
        Me.txtbalance.Size = New System.Drawing.Size(120, 20)
        Me.txtbalance.TabIndex = 10
        '
        'txtpaidamt
        '
        Me.txtpaidamt.Location = New System.Drawing.Point(931, 594)
        Me.txtpaidamt.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpaidamt.Name = "txtpaidamt"
        Me.txtpaidamt.Size = New System.Drawing.Size(120, 20)
        Me.txtpaidamt.TabIndex = 7
        '
        'txtgtot
        '
        Me.txtgtot.Location = New System.Drawing.Point(931, 562)
        Me.txtgtot.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgtot.Name = "txtgtot"
        Me.txtgtot.Size = New System.Drawing.Size(120, 20)
        Me.txtgtot.TabIndex = 12
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(607, 628)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Type"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(788, 626)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(147, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Remaining Balance"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(788, 596)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(99, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Paid Amount"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(788, 564)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 16
        Me.Label8.Text = "Total"
        '
        'txtperpc
        '
        Me.txtperpc.BaseColor = System.Drawing.Color.White
        Me.txtperpc.BorderColor = System.Drawing.Color.Silver
        Me.txtperpc.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtperpc.FocusedBaseColor = System.Drawing.Color.White
        Me.txtperpc.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtperpc.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtperpc.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtperpc.Location = New System.Drawing.Point(505, 37)
        Me.txtperpc.Margin = New System.Windows.Forms.Padding(2)
        Me.txtperpc.Name = "txtperpc"
        Me.txtperpc.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtperpc.SelectedText = ""
        Me.txtperpc.Size = New System.Drawing.Size(64, 26)
        Me.txtperpc.TabIndex = 95
        '
        'lblper
        '
        Me.lblper.AutoSize = True
        Me.lblper.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblper.Location = New System.Drawing.Point(502, 8)
        Me.lblper.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblper.Name = "lblper"
        Me.lblper.Size = New System.Drawing.Size(66, 19)
        Me.lblper.TabIndex = 94
        Me.lblper.Text = "PER/PCS"
        '
        'lblgst
        '
        Me.lblgst.AutoSize = True
        Me.lblgst.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgst.Location = New System.Drawing.Point(682, 8)
        Me.lblgst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblgst.Name = "lblgst"
        Me.lblgst.Size = New System.Drawing.Size(35, 19)
        Me.lblgst.TabIndex = 91
        Me.lblgst.Text = "GST"
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
        Me.txtgst.Location = New System.Drawing.Point(671, 37)
        Me.txtgst.Margin = New System.Windows.Forms.Padding(2)
        Me.txtgst.Name = "txtgst"
        Me.txtgst.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtgst.SelectedText = ""
        Me.txtgst.Size = New System.Drawing.Size(61, 26)
        Me.txtgst.TabIndex = 93
        '
        'GunaLabel6
        '
        Me.GunaLabel6.AutoSize = True
        Me.GunaLabel6.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel6.Location = New System.Drawing.Point(587, 8)
        Me.GunaLabel6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel6.Name = "GunaLabel6"
        Me.GunaLabel6.Size = New System.Drawing.Size(50, 19)
        Me.GunaLabel6.TabIndex = 90
        Me.GunaLabel6.Text = "TOTAL"
        '
        'GunaLabel5
        '
        Me.GunaLabel5.AutoSize = True
        Me.GunaLabel5.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel5.Location = New System.Drawing.Point(427, 8)
        Me.GunaLabel5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel5.Name = "GunaLabel5"
        Me.GunaLabel5.Size = New System.Drawing.Size(42, 19)
        Me.GunaLabel5.TabIndex = 89
        Me.GunaLabel5.Text = "RATE"
        '
        'txttotal
        '
        Me.txttotal.BaseColor = System.Drawing.Color.White
        Me.txttotal.BorderColor = System.Drawing.Color.Silver
        Me.txttotal.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txttotal.FocusedBaseColor = System.Drawing.Color.White
        Me.txttotal.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txttotal.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txttotal.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txttotal.Location = New System.Drawing.Point(590, 37)
        Me.txttotal.Margin = New System.Windows.Forms.Padding(2)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txttotal.SelectedText = ""
        Me.txttotal.Size = New System.Drawing.Size(61, 26)
        Me.txttotal.TabIndex = 92
        '
        'txtrate
        '
        Me.txtrate.BaseColor = System.Drawing.Color.White
        Me.txtrate.BorderColor = System.Drawing.Color.Silver
        Me.txtrate.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtrate.FocusedBaseColor = System.Drawing.Color.White
        Me.txtrate.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtrate.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtrate.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtrate.Location = New System.Drawing.Point(430, 37)
        Me.txtrate.Margin = New System.Windows.Forms.Padding(2)
        Me.txtrate.Name = "txtrate"
        Me.txtrate.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtrate.SelectedText = ""
        Me.txtrate.Size = New System.Drawing.Size(61, 26)
        Me.txtrate.TabIndex = 5
        '
        'txtqty
        '
        Me.txtqty.BaseColor = System.Drawing.Color.White
        Me.txtqty.BorderColor = System.Drawing.Color.Silver
        Me.txtqty.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtqty.FocusedBaseColor = System.Drawing.Color.White
        Me.txtqty.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtqty.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtqty.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtqty.Location = New System.Drawing.Point(371, 37)
        Me.txtqty.Margin = New System.Windows.Forms.Padding(2)
        Me.txtqty.Name = "txtqty"
        Me.txtqty.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtqty.SelectedText = ""
        Me.txtqty.Size = New System.Drawing.Size(45, 26)
        Me.txtqty.TabIndex = 4
        '
        'GunaLabel4
        '
        Me.GunaLabel4.AutoSize = True
        Me.GunaLabel4.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel4.Location = New System.Drawing.Point(368, 8)
        Me.GunaLabel4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel4.Name = "GunaLabel4"
        Me.GunaLabel4.Size = New System.Drawing.Size(36, 19)
        Me.GunaLabel4.TabIndex = 88
        Me.GunaLabel4.Text = "QTY"
        '
        'txtpid
        '
        Me.txtpid.BaseColor = System.Drawing.Color.White
        Me.txtpid.BorderColor = System.Drawing.Color.Silver
        Me.txtpid.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtpid.FocusedBaseColor = System.Drawing.Color.White
        Me.txtpid.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtpid.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtpid.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtpid.Location = New System.Drawing.Point(15, 37)
        Me.txtpid.Margin = New System.Windows.Forms.Padding(2)
        Me.txtpid.Name = "txtpid"
        Me.txtpid.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtpid.SelectedText = ""
        Me.txtpid.Size = New System.Drawing.Size(36, 26)
        Me.txtpid.TabIndex = 100
        '
        'cmbname
        '
        Me.cmbname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbname.FormattingEnabled = True
        Me.cmbname.Location = New System.Drawing.Point(196, 40)
        Me.cmbname.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbname.Name = "cmbname"
        Me.cmbname.Size = New System.Drawing.Size(150, 25)
        Me.cmbname.TabIndex = 3
        '
        'GunaLabel11
        '
        Me.GunaLabel11.AutoSize = True
        Me.GunaLabel11.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel11.Location = New System.Drawing.Point(58, 11)
        Me.GunaLabel11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel11.Name = "GunaLabel11"
        Me.GunaLabel11.Size = New System.Drawing.Size(87, 19)
        Me.GunaLabel11.TabIndex = 101
        Me.GunaLabel11.Text = "PROD_TYPE"
        '
        'cmbptype
        '
        Me.cmbptype.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbptype.FormattingEnabled = True
        Me.cmbptype.Location = New System.Drawing.Point(61, 40)
        Me.cmbptype.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbptype.Name = "cmbptype"
        Me.cmbptype.Size = New System.Drawing.Size(117, 25)
        Me.cmbptype.TabIndex = 2
        '
        'GunaLabel1
        '
        Me.GunaLabel1.AutoSize = True
        Me.GunaLabel1.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel1.Location = New System.Drawing.Point(194, 11)
        Me.GunaLabel1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel1.Name = "GunaLabel1"
        Me.GunaLabel1.Size = New System.Drawing.Size(120, 19)
        Me.GunaLabel1.TabIndex = 99
        Me.GunaLabel1.Text = "PRODUCT NAME"
        '
        'GunaLabel3
        '
        Me.GunaLabel3.AutoSize = True
        Me.GunaLabel3.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel3.Location = New System.Drawing.Point(12, 11)
        Me.GunaLabel3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel3.Name = "GunaLabel3"
        Me.GunaLabel3.Size = New System.Drawing.Size(32, 19)
        Me.GunaLabel3.TabIndex = 98
        Me.GunaLabel3.Text = "PID"
        '
        'btnnew
        '
        Me.btnnew.AnimationHoverSpeed = 0.07!
        Me.btnnew.AnimationSpeed = 0.03!
        Me.btnnew.BaseColor1 = System.Drawing.Color.MediumBlue
        Me.btnnew.BaseColor2 = System.Drawing.Color.CornflowerBlue
        Me.btnnew.BorderColor = System.Drawing.Color.Black
        Me.btnnew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnnew.FocusedColor = System.Drawing.Color.Empty
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Nothing
        Me.btnnew.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnnew.Location = New System.Drawing.Point(31, 608)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnnew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnnew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnew.OnHoverImage = Nothing
        Me.btnnew.OnPressedColor = System.Drawing.Color.Black
        Me.btnnew.Size = New System.Drawing.Size(87, 34)
        Me.btnnew.TabIndex = 102
        Me.btnnew.Text = "NEW"
        '
        'cmbtype
        '
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"Online", "cash"})
        Me.cmbtype.Location = New System.Drawing.Point(660, 626)
        Me.cmbtype.Margin = New System.Windows.Forms.Padding(2)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.Size = New System.Drawing.Size(92, 21)
        Me.cmbtype.TabIndex = 8
        '
        'btnsave
        '
        Me.btnsave.AnimationHoverSpeed = 0.07!
        Me.btnsave.AnimationSpeed = 0.03!
        Me.btnsave.BaseColor1 = System.Drawing.Color.DarkGreen
        Me.btnsave.BaseColor2 = System.Drawing.Color.MediumSeaGreen
        Me.btnsave.BorderColor = System.Drawing.Color.Black
        Me.btnsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnsave.FocusedColor = System.Drawing.Color.Empty
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnsave.Location = New System.Drawing.Point(134, 609)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(104, 34)
        Me.btnsave.TabIndex = 10
        Me.btnsave.Text = "SAVE"
        '
        'btnexit
        '
        Me.btnexit.AnimationHoverSpeed = 0.07!
        Me.btnexit.AnimationSpeed = 0.03!
        Me.btnexit.BaseColor1 = System.Drawing.Color.Brown
        Me.btnexit.BaseColor2 = System.Drawing.Color.Red
        Me.btnexit.BorderColor = System.Drawing.Color.Black
        Me.btnexit.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnexit.FocusedColor = System.Drawing.Color.Empty
        Me.btnexit.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Image = Nothing
        Me.btnexit.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnexit.Location = New System.Drawing.Point(261, 609)
        Me.btnexit.Margin = New System.Windows.Forms.Padding(2)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnexit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnexit.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnexit.OnHoverForeColor = System.Drawing.Color.White
        Me.btnexit.OnHoverImage = Nothing
        Me.btnexit.OnPressedColor = System.Drawing.Color.Black
        Me.btnexit.Size = New System.Drawing.Size(91, 34)
        Me.btnexit.TabIndex = 105
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
        Me.btnprint.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprint.ForeColor = System.Drawing.Color.White
        Me.btnprint.Image = Nothing
        Me.btnprint.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnprint.Location = New System.Drawing.Point(378, 611)
        Me.btnprint.Margin = New System.Windows.Forms.Padding(2)
        Me.btnprint.Name = "btnprint"
        Me.btnprint.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnprint.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnprint.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnprint.OnHoverForeColor = System.Drawing.Color.White
        Me.btnprint.OnHoverImage = Nothing
        Me.btnprint.OnPressedColor = System.Drawing.Color.Black
        Me.btnprint.Size = New System.Drawing.Size(106, 34)
        Me.btnprint.TabIndex = 106
        Me.btnprint.Text = "PRINT"
        '
        'btnenter
        '
        Me.btnenter.AnimationHoverSpeed = 0.07!
        Me.btnenter.AnimationSpeed = 0.03!
        Me.btnenter.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnenter.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnenter.BorderColor = System.Drawing.Color.Black
        Me.btnenter.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnenter.FocusedColor = System.Drawing.Color.Empty
        Me.btnenter.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnenter.ForeColor = System.Drawing.Color.White
        Me.btnenter.Image = Nothing
        Me.btnenter.ImageSize = New System.Drawing.Size(20, 20)
        Me.btnenter.Location = New System.Drawing.Point(958, 28)
        Me.btnenter.Margin = New System.Windows.Forms.Padding(2)
        Me.btnenter.Name = "btnenter"
        Me.btnenter.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnenter.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnenter.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnenter.OnHoverForeColor = System.Drawing.Color.White
        Me.btnenter.OnHoverImage = Nothing
        Me.btnenter.OnPressedColor = System.Drawing.Color.Black
        Me.btnenter.Size = New System.Drawing.Size(63, 34)
        Me.btnenter.TabIndex = 6
        Me.btnenter.Text = "ENTER"
        '
        'txtNTOT
        '
        Me.txtNTOT.BaseColor = System.Drawing.Color.White
        Me.txtNTOT.BorderColor = System.Drawing.Color.Silver
        Me.txtNTOT.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtNTOT.FocusedBaseColor = System.Drawing.Color.White
        Me.txtNTOT.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtNTOT.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtNTOT.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtNTOT.Location = New System.Drawing.Point(854, 35)
        Me.txtNTOT.Margin = New System.Windows.Forms.Padding(2)
        Me.txtNTOT.Name = "txtNTOT"
        Me.txtNTOT.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtNTOT.SelectedText = ""
        Me.txtNTOT.Size = New System.Drawing.Size(80, 26)
        Me.txtNTOT.TabIndex = 109
        '
        'GunaLabel10
        '
        Me.GunaLabel10.AutoSize = True
        Me.GunaLabel10.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel10.Location = New System.Drawing.Point(854, 6)
        Me.GunaLabel10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel10.Name = "GunaLabel10"
        Me.GunaLabel10.Size = New System.Drawing.Size(80, 19)
        Me.GunaLabel10.TabIndex = 108
        Me.GunaLabel10.Text = "NET TOTAL"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(34, 573)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(45, 17)
        Me.Label9.TabIndex = 110
        Me.Label9.Text = "Extra"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(182, 117)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(66, 17)
        Me.Label10.TabIndex = 116
        Me.Label10.Text = "Mob no."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(14, 117)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 17)
        Me.Label11.TabIndex = 115
        Me.Label11.Text = "City"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 41)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(49, 17)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Name"
        '
        'txtmob
        '
        Me.txtmob.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtmob.Location = New System.Drawing.Point(243, 115)
        Me.txtmob.Margin = New System.Windows.Forms.Padding(2)
        Me.txtmob.Name = "txtmob"
        Me.txtmob.Size = New System.Drawing.Size(120, 23)
        Me.txtmob.TabIndex = 113
        '
        'txtcity
        '
        Me.txtcity.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcity.Location = New System.Drawing.Point(80, 115)
        Me.txtcity.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcity.Name = "txtcity"
        Me.txtcity.Size = New System.Drawing.Size(99, 23)
        Me.txtcity.TabIndex = 112
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(80, 41)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(283, 23)
        Me.txtname.TabIndex = 111
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(120, 10)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(104, 17)
        Me.Label13.TabIndex = 117
        Me.Label13.Text = "Ship Address"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Salmon
        Me.Panel1.Controls.Add(Me.txtadd)
        Me.Panel1.Controls.Add(Me.Label14)
        Me.Panel1.Controls.Add(Me.txtname)
        Me.Panel1.Controls.Add(Me.Label13)
        Me.Panel1.Controls.Add(Me.txtcity)
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.txtmob)
        Me.Panel1.Controls.Add(Me.Label11)
        Me.Panel1.Controls.Add(Me.Label12)
        Me.Panel1.Location = New System.Drawing.Point(678, 76)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(371, 143)
        Me.Panel1.TabIndex = 118
        '
        'txtadd
        '
        Me.txtadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtadd.Location = New System.Drawing.Point(80, 75)
        Me.txtadd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtadd.Name = "txtadd"
        Me.txtadd.Size = New System.Drawing.Size(283, 23)
        Me.txtadd.TabIndex = 119
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(14, 77)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(67, 17)
        Me.Label14.TabIndex = 118
        Me.Label14.Text = "Address"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(206, 129)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 17)
        Me.Label15.TabIndex = 120
        Me.Label15.Text = "Address"
        '
        'txtcustadd
        '
        Me.txtcustadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcustadd.Location = New System.Drawing.Point(334, 127)
        Me.txtcustadd.Margin = New System.Windows.Forms.Padding(2)
        Me.txtcustadd.Name = "txtcustadd"
        Me.txtcustadd.Size = New System.Drawing.Size(242, 23)
        Me.txtcustadd.TabIndex = 119
        '
        'txtTGST
        '
        Me.txtTGST.BaseColor = System.Drawing.Color.White
        Me.txtTGST.BorderColor = System.Drawing.Color.Silver
        Me.txtTGST.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.txtTGST.FocusedBaseColor = System.Drawing.Color.White
        Me.txtTGST.FocusedBorderColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.txtTGST.FocusedForeColor = System.Drawing.SystemColors.ControlText
        Me.txtTGST.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.txtTGST.Location = New System.Drawing.Point(752, 37)
        Me.txtTGST.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTGST.Name = "txtTGST"
        Me.txtTGST.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.txtTGST.SelectedText = ""
        Me.txtTGST.Size = New System.Drawing.Size(78, 26)
        Me.txtTGST.TabIndex = 122
        '
        'GunaLabel9
        '
        Me.GunaLabel9.AutoSize = True
        Me.GunaLabel9.Font = New System.Drawing.Font("Segoe UI", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GunaLabel9.Location = New System.Drawing.Point(749, 8)
        Me.GunaLabel9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.GunaLabel9.Name = "GunaLabel9"
        Me.GunaLabel9.Size = New System.Drawing.Size(43, 19)
        Me.GunaLabel9.TabIndex = 121
        Me.GunaLabel9.Text = "TGST"
        '
        'dgv
        '
        Me.dgv.AllowUserToAddRows = False
        Me.dgv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(391, 106)
        Me.dgv.Margin = New System.Windows.Forms.Padding(2)
        Me.dgv.Name = "dgv"
        Me.dgv.RowHeadersVisible = False
        Me.dgv.RowTemplate.Height = 24
        Me.dgv.Size = New System.Drawing.Size(184, 79)
        Me.dgv.TabIndex = 123
        Me.dgv.Visible = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Teal
        Me.Panel2.Controls.Add(Me.Label16)
        Me.Panel2.Location = New System.Drawing.Point(290, 10)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(443, 54)
        Me.Panel2.TabIndex = 124
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(153, 9)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(155, 37)
        Me.Label16.TabIndex = 7
        Me.Label16.Text = "INVOICE"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.txtTGST)
        Me.Panel3.Controls.Add(Me.GunaLabel4)
        Me.Panel3.Controls.Add(Me.txtqty)
        Me.Panel3.Controls.Add(Me.txtrate)
        Me.Panel3.Controls.Add(Me.GunaLabel9)
        Me.Panel3.Controls.Add(Me.txttotal)
        Me.Panel3.Controls.Add(Me.GunaLabel5)
        Me.Panel3.Controls.Add(Me.GunaLabel6)
        Me.Panel3.Controls.Add(Me.txtgst)
        Me.Panel3.Controls.Add(Me.lblgst)
        Me.Panel3.Controls.Add(Me.txtNTOT)
        Me.Panel3.Controls.Add(Me.lblper)
        Me.Panel3.Controls.Add(Me.GunaLabel10)
        Me.Panel3.Controls.Add(Me.txtperpc)
        Me.Panel3.Controls.Add(Me.btnenter)
        Me.Panel3.Controls.Add(Me.GunaLabel3)
        Me.Panel3.Controls.Add(Me.GunaLabel1)
        Me.Panel3.Controls.Add(Me.cmbptype)
        Me.Panel3.Controls.Add(Me.GunaLabel11)
        Me.Panel3.Controls.Add(Me.cmbname)
        Me.Panel3.Controls.Add(Me.txtpid)
        Me.Panel3.Location = New System.Drawing.Point(17, 232)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1032, 67)
        Me.Panel3.TabIndex = 125
        '
        'dtpdate
        '
        Me.dtpdate.Location = New System.Drawing.Point(13, 121)
        Me.dtpdate.Margin = New System.Windows.Forms.Padding(2)
        Me.dtpdate.Name = "dtpdate"
        Me.dtpdate.Size = New System.Drawing.Size(144, 20)
        Me.dtpdate.TabIndex = 126
        '
        'invoice
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LavenderBlush
        Me.ClientSize = New System.Drawing.Size(1082, 653)
        Me.Controls.Add(Me.dtpdate)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.dgv)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtcustadd)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.btnprint)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtgtot)
        Me.Controls.Add(Me.txtpaidamt)
        Me.Controls.Add(Me.txtbalance)
        Me.Controls.Add(Me.txtextra)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtcustmob)
        Me.Controls.Add(Me.txtcustcity)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.dg)
        Me.Controls.Add(Me.txtinward)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "invoice"
        Me.Text = "invoice"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtinward As System.Windows.Forms.TextBox
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents txtcustcity As System.Windows.Forms.TextBox
    Friend WithEvents txtcustmob As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtextra As System.Windows.Forms.TextBox
    Friend WithEvents txtbalance As System.Windows.Forms.TextBox
    Friend WithEvents txtpaidamt As System.Windows.Forms.TextBox
    Friend WithEvents txtgtot As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtperpc As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents lblper As Guna.UI.WinForms.GunaLabel
    Friend WithEvents lblgst As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtgst As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel6 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel5 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txttotal As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtrate As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents txtqty As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel4 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents txtpid As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents cmbname As System.Windows.Forms.ComboBox
    Friend WithEvents GunaLabel11 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents cmbptype As System.Windows.Forms.ComboBox
    Friend WithEvents GunaLabel1 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents GunaLabel3 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents btnnew As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents cmbtype As System.Windows.Forms.ComboBox
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnexit As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnprint As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents btnenter As Guna.UI.WinForms.GunaGradientButton
    Friend WithEvents txtNTOT As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel10 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtmob As System.Windows.Forms.TextBox
    Friend WithEvents txtcity As System.Windows.Forms.TextBox
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents txtadd As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txtcustadd As System.Windows.Forms.TextBox
    Friend WithEvents txtTGST As Guna.UI.WinForms.GunaTextBox
    Friend WithEvents GunaLabel9 As Guna.UI.WinForms.GunaLabel
    Friend WithEvents dgv As System.Windows.Forms.DataGridView
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents dtpdate As System.Windows.Forms.DateTimePicker
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column10 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
