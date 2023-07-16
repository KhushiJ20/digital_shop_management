<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PRODUCTS
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
        Me.dg = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.lblcode = New System.Windows.Forms.Label()
        Me.lbltype = New System.Windows.Forms.Label()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lblgst = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.txtcode = New System.Windows.Forms.TextBox()
        Me.cmbgst = New Guna.UI.WinForms.GunaComboBox()
        Me.cmbtype = New Guna.UI.WinForms.GunaComboBox()
        Me.GunaShadowPanel1 = New Guna.UI.WinForms.GunaShadowPanel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnupdate = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btnnew = New Guna.UI.WinForms.GunaGradientCircleButton()
        Me.btnsave = New Guna.UI.WinForms.GunaGradientCircleButton()
        CType(Me.dg, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GunaShadowPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'dg
        '
        Me.dg.AllowUserToAddRows = False
        Me.dg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg.BackgroundColor = System.Drawing.Color.Lavender
        Me.dg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4})
        Me.dg.Location = New System.Drawing.Point(424, 104)
        Me.dg.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.dg.Name = "dg"
        Me.dg.RowTemplate.Height = 24
        Me.dg.Size = New System.Drawing.Size(404, 301)
        Me.dg.TabIndex = 0
        '
        'Column1
        '
        Me.Column1.HeaderText = "CODE"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "PROD_TYPE"
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        Me.Column3.HeaderText = "PROD_NAME"
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        Me.Column4.HeaderText = "GST"
        Me.Column4.Name = "Column4"
        '
        'lblcode
        '
        Me.lblcode.AutoSize = True
        Me.lblcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcode.Location = New System.Drawing.Point(65, 115)
        Me.lblcode.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblcode.Name = "lblcode"
        Me.lblcode.Size = New System.Drawing.Size(59, 20)
        Me.lblcode.TabIndex = 1
        Me.lblcode.Text = "CODE"
        '
        'lbltype
        '
        Me.lbltype.AutoSize = True
        Me.lbltype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltype.Location = New System.Drawing.Point(65, 195)
        Me.lbltype.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lbltype.Name = "lbltype"
        Me.lbltype.Size = New System.Drawing.Size(54, 20)
        Me.lbltype.TabIndex = 2
        Me.lbltype.Text = "TYPE"
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(65, 279)
        Me.lblname.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(149, 20)
        Me.lblname.TabIndex = 3
        Me.lblname.Text = "PRODUCT NAME"
        '
        'lblgst
        '
        Me.lblgst.AutoSize = True
        Me.lblgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblgst.Location = New System.Drawing.Point(65, 350)
        Me.lblgst.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblgst.Name = "lblgst"
        Me.lblgst.Size = New System.Drawing.Size(45, 20)
        Me.lblgst.TabIndex = 4
        Me.lblgst.Text = "GST"
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(224, 277)
        Me.txtname.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(147, 26)
        Me.txtname.TabIndex = 6
        '
        'txtcode
        '
        Me.txtcode.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcode.Location = New System.Drawing.Point(224, 113)
        Me.txtcode.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.txtcode.Name = "txtcode"
        Me.txtcode.Size = New System.Drawing.Size(147, 26)
        Me.txtcode.TabIndex = 9
        '
        'cmbgst
        '
        Me.cmbgst.BackColor = System.Drawing.Color.Transparent
        Me.cmbgst.BaseColor = System.Drawing.Color.White
        Me.cmbgst.BorderColor = System.Drawing.Color.Silver
        Me.cmbgst.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbgst.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbgst.FocusedColor = System.Drawing.Color.Empty
        Me.cmbgst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbgst.ForeColor = System.Drawing.Color.Black
        Me.cmbgst.FormattingEnabled = True
        Me.cmbgst.Items.AddRange(New Object() {"0%", "5%", "12%", "18%", "28%"})
        Me.cmbgst.Location = New System.Drawing.Point(224, 351)
        Me.cmbgst.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbgst.Name = "cmbgst"
        Me.cmbgst.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbgst.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbgst.Size = New System.Drawing.Size(92, 27)
        Me.cmbgst.TabIndex = 13
        '
        'cmbtype
        '
        Me.cmbtype.BackColor = System.Drawing.Color.Transparent
        Me.cmbtype.BaseColor = System.Drawing.Color.White
        Me.cmbtype.BorderColor = System.Drawing.Color.Silver
        Me.cmbtype.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed
        Me.cmbtype.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbtype.FocusedColor = System.Drawing.Color.Empty
        Me.cmbtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbtype.ForeColor = System.Drawing.Color.Black
        Me.cmbtype.FormattingEnabled = True
        Me.cmbtype.Items.AddRange(New Object() {"0%", "5%", "12%", "18%", "28%"})
        Me.cmbtype.Location = New System.Drawing.Point(224, 192)
        Me.cmbtype.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.cmbtype.Name = "cmbtype"
        Me.cmbtype.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(CType(CType(100, Byte), Integer), CType(CType(88, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.cmbtype.OnHoverItemForeColor = System.Drawing.Color.White
        Me.cmbtype.Size = New System.Drawing.Size(147, 27)
        Me.cmbtype.TabIndex = 14
        '
        'GunaShadowPanel1
        '
        Me.GunaShadowPanel1.BackColor = System.Drawing.Color.Transparent
        Me.GunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GunaShadowPanel1.Controls.Add(Me.Label1)
        Me.GunaShadowPanel1.Location = New System.Drawing.Point(179, 10)
        Me.GunaShadowPanel1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GunaShadowPanel1.Name = "GunaShadowPanel1"
        Me.GunaShadowPanel1.ShadowColor = System.Drawing.Color.Black
        Me.GunaShadowPanel1.Size = New System.Drawing.Size(430, 65)
        Me.GunaShadowPanel1.TabIndex = 15
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cooper Black", 22.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(63, 13)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 35)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "PRODUCTS ENTRY"
        '
        'btnupdate
        '
        Me.btnupdate.AnimationHoverSpeed = 0.07!
        Me.btnupdate.AnimationSpeed = 0.03!
        Me.btnupdate.BaseColor1 = System.Drawing.Color.SlateBlue
        Me.btnupdate.BaseColor2 = System.Drawing.Color.Fuchsia
        Me.btnupdate.BorderColor = System.Drawing.Color.Black
        Me.btnupdate.DialogResult = System.Windows.Forms.DialogResult.None
        Me.btnupdate.FocusedColor = System.Drawing.Color.Empty
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.Color.White
        Me.btnupdate.Image = Nothing
        Me.btnupdate.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnupdate.Location = New System.Drawing.Point(304, 428)
        Me.btnupdate.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnupdate.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnupdate.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnupdate.OnHoverForeColor = System.Drawing.Color.White
        Me.btnupdate.OnHoverImage = Nothing
        Me.btnupdate.OnPressedColor = System.Drawing.Color.Black
        Me.btnupdate.Size = New System.Drawing.Size(90, 59)
        Me.btnupdate.TabIndex = 17
        Me.btnupdate.Text = "UPDATE"
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
        Me.btnnew.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnew.ForeColor = System.Drawing.Color.White
        Me.btnnew.Image = Nothing
        Me.btnnew.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnnew.Location = New System.Drawing.Point(54, 428)
        Me.btnnew.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnnew.Name = "btnnew"
        Me.btnnew.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnnew.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnnew.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnnew.OnHoverForeColor = System.Drawing.Color.White
        Me.btnnew.OnHoverImage = Nothing
        Me.btnnew.OnPressedColor = System.Drawing.Color.Black
        Me.btnnew.Size = New System.Drawing.Size(90, 59)
        Me.btnnew.TabIndex = 18
        Me.btnnew.Text = "NEW"
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
        Me.btnsave.Font = New System.Drawing.Font("Segoe UI", 10.8!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsave.ForeColor = System.Drawing.Color.White
        Me.btnsave.Image = Nothing
        Me.btnsave.ImageSize = New System.Drawing.Size(52, 52)
        Me.btnsave.Location = New System.Drawing.Point(179, 428)
        Me.btnsave.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnsave.Name = "btnsave"
        Me.btnsave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(CType(CType(155, Byte), Integer), CType(CType(145, Byte), Integer), CType(CType(221, Byte), Integer))
        Me.btnsave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnsave.OnHoverBorderColor = System.Drawing.Color.Black
        Me.btnsave.OnHoverForeColor = System.Drawing.Color.White
        Me.btnsave.OnHoverImage = Nothing
        Me.btnsave.OnPressedColor = System.Drawing.Color.Black
        Me.btnsave.Size = New System.Drawing.Size(90, 59)
        Me.btnsave.TabIndex = 19
        Me.btnsave.Text = "SAVE"
        '
        'PRODUCTS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightCoral
        Me.ClientSize = New System.Drawing.Size(852, 602)
        Me.Controls.Add(Me.btnsave)
        Me.Controls.Add(Me.btnnew)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.GunaShadowPanel1)
        Me.Controls.Add(Me.cmbtype)
        Me.Controls.Add(Me.cmbgst)
        Me.Controls.Add(Me.txtcode)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.lblgst)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.lbltype)
        Me.Controls.Add(Me.lblcode)
        Me.Controls.Add(Me.dg)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "PRODUCTS"
        Me.Text = "PRODUCTS"
        CType(Me.dg, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GunaShadowPanel1.ResumeLayout(False)
        Me.GunaShadowPanel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dg As System.Windows.Forms.DataGridView
    Friend WithEvents lblcode As System.Windows.Forms.Label
    Friend WithEvents lbltype As System.Windows.Forms.Label
    Friend WithEvents lblname As System.Windows.Forms.Label
    Friend WithEvents lblgst As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents txtcode As System.Windows.Forms.TextBox
    Friend WithEvents cmbgst As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents cmbtype As Guna.UI.WinForms.GunaComboBox
    Friend WithEvents Column1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Column4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GunaShadowPanel1 As Guna.UI.WinForms.GunaShadowPanel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnupdate As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btnnew As Guna.UI.WinForms.GunaGradientCircleButton
    Friend WithEvents btnsave As Guna.UI.WinForms.GunaGradientCircleButton
End Class
