Public Class CUSTOMER_INFO

    Private Sub CUSTOMER_INFO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        newid()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim rc As Integer
        dg.Rows.Add()
        rc = Val(dg.Rows.Count) - 1
        dg.Rows(rc).Cells(0).Value = Val(txtid.Text)
        dg.Rows(rc).Cells(1).Value = txtname.Text
        dg.Rows(rc).Cells(2).Value = txtaddress.Text
        dg.Rows(rc).Cells(3).Value = txtcity.Text
        dg.Rows(rc).Cells(4).Value = txtmob.Text
       
        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("CUSTOMER_INFO", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields(0).Value = Val(txtid.Text)
        rs.Fields(1).Value = txtname.Text
        rs.Fields(2).Value = txtaddress.Text
        rs.Fields(3).Value = txtcity.Text
        rs.Fields(4).Value = Val(txtmob.Text)
        rs.Save()
        MsgBox("record added")
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = ""
        txtname.Text = ""
        txtaddress.Text = ""
        txtcity.Text = ""
        txtmob.Text = ""
        newid()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        getdata()
    End Sub
    Public Sub newid()
        Dim rs As New ADODB.Recordset
        Dim bn As Integer
        rs.Open("select max(ID) from DEALER", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If IsDBNull(rs.Fields(0).Value) Then
            bn = 0
        Else
            bn = Val(rs.Fields(0).Value)
        End If
        txtid.Text = bn + 1
    End Sub
    Public Sub getdata()
        DG.Rows.Clear()
        Dim rs As New ADODB.Recordset
        Dim rc As Integer
        rs.Open("select * From CUSTOMER_INFO ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount > 0 Then
            While rs.EOF = False
                DG.Rows.Add()
                rc = Val(DG.Rows.Count) - 1
                DG.Rows(rc).Cells(0).Value = rs.Fields(0).Value
                dg.Rows(rc).Cells(1).Value = rs.Fields(1).Value
                dg.Rows(rc).Cells(2).Value = rs.Fields(2).Value
                dg.Rows(rc).Cells(2).Value = rs.Fields(3).Value
                dg.Rows(rc).Cells(3).Value = rs.Fields(4).Value
                rs.MoveNext()
            End While
        End If
    End Sub

   
   
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Len(txtid.Text) > 0 Then
            Dim rs As New ADODB.Recordset
            rs.Open("select * from CUSTOMER_INFO where ID=" & (txtid.Text) & "", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            rs.Fields(1).Value = txtname.Text
            rs.Fields(2).Value = txtaddress.Text
            rs.Fields(3).Value = txtcity.Text
            rs.Fields(4).Value = txtmob.Text

            rs.Update()
            MsgBox("Successfully updated")
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        txtid.Text = dg.CurrentRow.Cells(0).Value
        txtname.Text = dg.CurrentRow.Cells(1).Value
        txtaddress.Text = dg.CurrentRow.Cells(2).Value
        txtcity.Text = dg.CurrentRow.Cells(3).Value
        txtmob.Text = dg.CurrentRow.Cells(3).Value

    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class