Public Class login

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("select * from userinfo where UserName='" & txtuname.Text & "'and Password=" & Val(txtpwd.Text) & "and role='" & cmbrole.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount > 0 Then
            MsgBox("login Success")
        Else
            MsgBox("Invalid username / password")
        End If
    End Sub

    Private Sub txtuname_GotFocus(sender As Object, e As EventArgs) Handles txtuname.GotFocus
        txtuname.BackColor = Color.Aqua
    End Sub

    Private Sub txtuname_LostFocus(sender As Object, e As EventArgs) Handles txtuname.LostFocus
        txtuname.BackColor = Color.White
    End Sub

    Private Sub txtpwd_GotFocus(sender As Object, e As EventArgs) Handles txtpwd.GotFocus
        txtpwd.BackColor = Color.AliceBlue
    End Sub

    Private Sub txtpwd_LostFocus(sender As Object, e As EventArgs) Handles txtpwd.LostFocus
        txtpwd.BackColor = Color.White
    End Sub

    Private Sub cmbrole_GotFocus(sender As Object, e As EventArgs) Handles cmbrole.GotFocus
        cmbrole.BackColor = Color.AntiqueWhite

    End Sub

    Private Sub cmbrole_LostFocus(sender As Object, e As EventArgs) Handles cmbrole.LostFocus
        cmbrole.BackColor = Color.White
    End Sub
End Class