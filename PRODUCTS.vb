Public Class PRODUCTS

    Private Sub PRODUCTS_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim rc As Integer
        dg.Rows.Add()
        rc = Val(dg.Rows.Count) - 1
        dg.Rows(rc).Cells(0).Value = Val(txtcode.Text)
        dg.Rows(rc).Cells(1).Value = cmbtype.Text
        dg.Rows(rc).Cells(2).Value = txtname.Text
        dg.Rows(rc).Cells(3).Value = Val(cmbgst.Text)

        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("PRODUCTS", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields(0).Value = Val(txtcode.Text)
        rs.Fields(1).Value = cmbtype.Text
        rs.Fields(2).Value = txtname.Text
        rs.Fields(3).Value = Val(cmbgst.Text)
        rs.Save()

        If rs.State = 1 Then rs.Close()
        rs.Open("STOCK", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields(0).Value = Val(txtcode.Text)
        rs.Fields(1).Value = cmbtype.Text
        rs.Fields(2).Value = txtname.Text
        rs.Fields(3).Value = "0"
        rs.Save()


        MsgBox("record added")
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        If Len(txtcode.Text) > 0 Then
            Dim rs As New ADODB.Recordset
            rs.Open("select * from PRODUCTS where code=" & (txtcode.Text) & "", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            rs.Fields(1).Value = cmbtype.Text
            rs.Fields(2).Value = txtname.Text
            rs.Fields(3).Value = Val(cmbgst.Text)

            rs.Update()
            rs.Close()
            If rs.State = 1 Then rs.Close()
            rs.Open("select * from STOCK where ID=" & txtcode.Text & " ", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)


            While rs.EOF = False
                rs.Fields(1).Value = cmbtype.Text
                rs.Fields(2).Value = txtname.Text
                rs.Update()
                rs.MoveNext()

            End While

            MsgBox("Product Updated Successfully........")
            'Update.Enabled = False
            'Button1_Click(sender, e)
            'getprodinfo()
            'nitin = 0
        End If
    End Sub
    'Public Sub getprodinfo()
    '    ms.Rows = 0
    '    Dim rs As New ADODB.Recordset
    '    'rs.Open("select * from productmaster", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
    '    rs.Open("select * from stock", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)

    '    If rs.RecordCount > 0 Then
    '        While rs.EOF = False
    '            ms.Rows = ms.Rows + 1
    '            ms.set_TextMatrix(ms.Rows - 1, 0, rs.Fields(0).Value)
    '            ms.set_TextMatrix(ms.Rows - 1, 1, rs.Fields(1).Value)
    '            ms.set_TextMatrix(ms.Rows - 1, 2, rs.Fields(2).Value)
    '            ms.set_TextMatrix(ms.Rows - 1, 3, rs.Fields(3).Value)
    '            rs.MoveNext()
    '        End While
    '    End If

    'End Sub
End Class