Public Class Registration

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim a As New ADODB.Connection
        opendb()
    End Sub

    Private Sub btnsave_Click_1(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim ks As New ADODB.Recordset
        If txtpwd.Text = txtrpwd.Text Then
            ' MsgBox("match")
            ks.Open("userinfo", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            ks.AddNew()
            ks.Fields(0).Value = txtuname.Text
            ks.Fields(1).Value = txtpwd.Text
            ks.Fields(2).Value = txtrpwd.Text
            ks.Fields(3).Value = cmbrole.Text
            ks.Save()
            MsgBox("record added")
        ElseIf (txtpwd.Text <> txtrpwd.Text) Then
        Else
            MsgBox(" Password Not match")
        End If
        txtuname.Focus()
    End Sub

    Private Sub btnnext_Click(sender As Object, e As EventArgs) Handles btnnext.Click
        login.Show()
        Me.Close()
    End Sub

    'Private Sub txtuname_CursorChanged(sender As Object, e As EventArgs) Handles txtuname.CursorChanged
    '    If txtuname.Text = "" Then
    '        txtuname.Text = "Type your name"
    '        txtuname.ForeColor = Color.Black
    '    End If
    'End Sub

    Private Sub txtuname_GotFocus(sender As Object, e As EventArgs) Handles txtuname.GotFocus
        txtuname.BackColor = Color.CadetBlue
        If txtuname.Text = "type your name" Then
            txtuname.Text = ""
            txtuname.ForeColor = Color.Black
        End If
    End Sub

    Private Sub txtuname_LostFocus(sender As Object, e As EventArgs) Handles txtuname.LostFocus
        txtuname.BackColor = Color.White
    End Sub

    Private Sub txtpwd_GotFocus(sender As Object, e As EventArgs) Handles txtpwd.GotFocus
        txtpwd.BackColor = Color.LightBlue
    End Sub

    Private Sub txtpwd_LostFocus(sender As Object, e As EventArgs) Handles txtpwd.LostFocus
        txtpwd.BackColor = Color.White
    End Sub

    Private Sub txtrpwd_GotFocus(sender As Object, e As EventArgs) Handles txtrpwd.GotFocus
        txtrpwd.BackColor = Color.LightBlue
    End Sub

    Private Sub txtrpwd_LostFocus(sender As Object, e As EventArgs) Handles txtrpwd.LostFocus
        txtrpwd.BackColor = Color.White
    End Sub

    Private Sub cmbrole_GotFocus(sender As Object, e As EventArgs) Handles cmbrole.GotFocus
        cmbrole.BackColor = Color.LightBlue
    End Sub

    Private Sub cmbrole_LostFocus(sender As Object, e As EventArgs) Handles cmbrole.LostFocus
        cmbrole.BackColor = Color.White
    End Sub

    'Private Sub txtuname_MouseEnter(sender As Object, e As EventArgs) Handles txtuname.MouseEnter
    '    If txtuname.Text = "Type your name " Then
    '        txtuname.Text = ""
    '        txtuname.ForeColor = Color.Black
    '    End If
    'End Sub

    'Private Sub txtuname_MouseLeave(sender As Object, e As EventArgs) Handles txtuname.MouseLeave
    '    If txtuname.Text = " " Then
    '        txtuname.Text = " tyype your name"
    '        txtuname.ForeColor = Color.Gray
    '    End If
    'End Sub
End Class
