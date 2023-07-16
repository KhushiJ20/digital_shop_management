Public Class Dealer_master

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        adddata()
        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("DEALER", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields(0).Value = Val(txtid.Text)
        rs.Fields(1).Value = txtdname.Text
        rs.Fields(2).Value = txtcity.Text
        rs.Fields(3).Value = Val(txtmob.Text)
        rs.Fields(4).Value = Val(txtgst.Text)
        rs.Fields(5).Value = Val(txtac.Text)
        rs.Fields(6).Value = txtifsc.Text
        rs.Save()
        MsgBox("record added")
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


    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtid.Text = ""
        txtdname.Text = ""
        txtcity.Text = ""
        txtmob.Text = ""
        txtgst.Text = ""
        txtac.Text = ""
        txtifsc.Text = ""
        newid()
    End Sub

    Public Sub getdata()
        DG.Rows.Clear()
        Dim rs As New ADODB.Recordset
        Dim rc As Integer
        rs.Open("select * From DEALER ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount > 0 Then
            While rs.EOF = False
                DG.Rows.Add()
                rc = Val(DG.Rows.Count) - 1
                DG.Rows(rc).Cells(0).Value = rs.Fields(0).Value
                DG.Rows(rc).Cells(1).Value = rs.Fields(1).Value
                DG.Rows(rc).Cells(2).Value = rs.Fields(2).Value
                DG.Rows(rc).Cells(3).Value = rs.Fields(3).Value
                dg.Rows(rc).Cells(4).Value = rs.Fields(4).Value
                dg.Rows(rc).Cells(5).Value = rs.Fields(5).Value
                dg.Rows(rc).Cells(6).Value = rs.Fields(6).Value
                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        getdata()
    End Sub

    Private Sub Dealer_master_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        newid()
    End Sub

    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub
    Public Sub adddata()
        Dim rc As Integer
                dg.Rows.Add()
                rc = Val(dg.Rows.Count) - 1
                dg.Rows(rc).Cells(0).Value = Val(txtid.Text)
                dg.Rows(rc).Cells(1).Value = txtdname.Text
                dg.Rows(rc).Cells(2).Value = txtcity.Text
                dg.Rows(rc).Cells(3).Value = txtmob.Text
                dg.Rows(rc).Cells(4).Value = txtgst.Text
                dg.Rows(rc).Cells(5).Value = txtac.Text
                dg.Rows(rc).Cells(6).Value = txtifsc.Text
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub
End Class