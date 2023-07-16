Public Class inward

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        txttotal.Text = Val(txtqty.Text) * Val(txtrate.Text)
        'txtTGST.Text = Val(txttotal.Text) * Val(txtgst.Text) / 100
    End Sub

    Private Sub txtrate_TextChanged(sender As Object, e As EventArgs) Handles txtrate.TextChanged
        txttotal.Text = Val(txtqty.Text) * Val(txtrate.Text)
        '  txtTGST.Text = Val(txttotal.Text) * Val(txtgst.Text) / 100
    End Sub

    Private Sub inward_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        demo()
        kh()
        newid()
    End Sub

    Public Sub total()
        Dim t, i, k As Integer
        t = 0
        k = (dg.Rows.Count) - 1
        For i = 0 To k
            t = t + dg.Rows(i).Cells(10).Value
        Next
        txtgtotal.Text = t
    End Sub

    Public Sub demo()
        cmbdealer.Items.Clear()
        Dim rs As New ADODB.Recordset
        rs.Open("select distinct DEALER_NAME from DEALER ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        While rs.EOF = False
            cmbdealer.Items.Add(rs.Fields(0).Value)
            ' txtid.Text = rs.Fields(1).Value
            rs.MoveNext()
        End While
    End Sub
    Public Sub newid()
        Dim rs As New ADODB.Recordset
        Dim bn As Integer
        rs.Open("select max(INWARDNO) from INW_DETAIL", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If IsDBNull(rs.Fields(0).Value) Then
            bn = 0
        Else
            bn = Val(rs.Fields(0).Value)
        End If
        txtinward.Text = bn + 1
    End Sub

    Public Sub kh()
        Dim rs As New ADODB.Recordset
       rs.Open("select PROD_TYPE from PRODUCTS ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        While rs.EOF = False
            cmbtype.Items.Add(rs.Fields(0).Value)
            ' cmbname.Items.Clear()
            rs.MoveNext()
        End While
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbtype.SelectedIndexChanged
        cmbname.Items.Clear()
        Dim kh As New ADODB.Recordset
        kh.Open("select PROD_NAME,GST,code from PRODUCTS where PROD_TYPE='" & cmbtype.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If kh.RecordCount > 0 Then
            While kh.EOF = False
                cmbname.Items.Add(kh.Fields(0).Value)
                txtgst.Text = kh.Fields(1).Value
                txtpid.Text = kh.Fields(2).Value
                kh.MoveNext()

            End While
        End If
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim rc As Integer
        rc = Val(dg.Rows.Count) - 1
        Dim rs As New ADODB.Recordset
        For r = 0 To rc
            If rs.State = 1 Then rs.Close()
            rs.Open("select qty from STOCK where id=" & Val(Me.dg.Rows(r).Cells(0).Value) & "", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            rs.Fields(0).Value = Val(rs.Fields(0).Value) + Val(dg.Rows(r).Cells(3).Value)
            rs.Update()
        Next

        Dim kh As Integer
        kh = Val(dg.Rows.Count) - 1
        Dim s As New ADODB.Recordset
        s.Open("INW_DETAIL", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For r = 0 To kh
            s.AddNew()
            s.Fields(0).Value = Val(txtinward.Text)
            s.Fields(1).Value = dg.Rows(r).Cells(0).Value
            s.Fields(2).Value = dg.Rows(r).Cells(1).Value
            s.Fields(3).Value = dg.Rows(r).Cells(2).Value
            s.Fields(4).Value = dg.Rows(r).Cells(3).Value
            s.Fields(5).Value = dg.Rows(r).Cells(4).Value
            s.Fields(6).Value = dg.Rows(r).Cells(5).Value
            s.Fields(7).Value = dg.Rows(r).Cells(6).Value
            s.Fields(8).Value = dg.Rows(r).Cells(7).Value
            s.Fields(9).Value = dg.Rows(r).Cells(8).Value
            s.Fields(10).Value = dg.Rows(r).Cells(9).Value
            s.Fields(11).Value = dg.Rows(r).Cells(10).Value

        Next
        s.Save()


        Dim da As Integer
        da = Val(dg.Rows.Count) - 1
        Dim ab As New ADODB.Recordset
        ab.Open("DEALER_AC", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For r = 0 To da
            ab.AddNew()
            ab.Fields(0).Value = Val(txtinward.Text)
            ab.Fields(1).Value = cmbptype.Text
            ab.Fields(2).Value = txtid.Text
            ab.Fields(3).Value = cmbdealer.Text
            ab.Fields(4).Value = dtpinward.Value.Date
            ab.Fields(5).Value = Val(txtgtotal.Text)
            ab.Fields(6).Value = Val(txtpaid.Text)
            ab.Fields(7).Value = Val(txtrem.Text)
            ab.Fields(8).Value = Val(txtextra.Text)

        Next
        ab.Save()

        MsgBox("Record Added Successfully.....")
    End Sub

    Private Sub btndgenter_Click(sender As Object, e As EventArgs) Handles btndgenter.Click
        If (txtNTOT.Text > 0) Then
            Dim rs As Integer
            dg.Rows.Add()
            rs = Val(dg.Rows.Count) - 1
            dg.Rows(rs).Cells(0).Value = txtpid.Text
            dg.Rows(rs).Cells(1).Value = cmbtype.Text()
            dg.Rows(rs).Cells(2).Value = cmbname.Text()
            dg.Rows(rs).Cells(3).Value = txtqty.Text
            dg.Rows(rs).Cells(4).Value = txtrate.Text
            dg.Rows(rs).Cells(5).Value = Val(txtperpc.Text)
            dg.Rows(rs).Cells(6).Value = txttotal.Text
            dg.Rows(rs).Cells(7).Value = txtgst.Text
            dg.Rows(rs).Cells(8).Value = txtTGST.Text
            dg.Rows(rs).Cells(9).Value = txttransport.Text
            dg.Rows(rs).Cells(10).Value = Val(txtNTOT.Text)

            total()

            txtpid.Text = ""
            cmbtype.Text = ""
            cmbname.Text = ""
            txtqty.Text = ""
            txtrate.Text = ""
            txttotal.Text = ""
            txtgst.Text = ""
            txtTGST.Text = ""
            txttransport.Text = ""
            txtNTOT.Text = ""
            cmbtype.Focus()
        End If
    End Sub

    Private Sub txtNTOT_TextChanged(sender As Object, e As EventArgs) Handles txtNTOT.TextChanged
        txtperpc.Text = Val(txtNTOT.Text) / Val(txtqty.Text)
    End Sub

    Private Sub txttransport_TextChanged(sender As Object, e As EventArgs) Handles txttransport.TextChanged
        txtNTOT.Text = Val(txttransport.Text) + Val(txtTGST.Text) + Val(txttotal.Text)
    End Sub

    Private Sub cmbdealer_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdealer.SelectedIndexChanged
        Dim kh As New ADODB.Recordset
        kh.Open("select ID from DEALER where DEALER_Name ='" & cmbdealer.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If kh.RecordCount > 0 Then
            While kh.EOF = False
                txtid.Text = kh.Fields(0).Value
                kh.MoveNext()

            End While
                End If 
    End Sub

    Private Sub txtgtotal_TextChanged(sender As Object, e As EventArgs) Handles txtgtotal.TextChanged
        'If Len(txtgtotal.Text) > 0 Then
        '    txtbalance.Text = CDbl(txtgtotal.Text) - Val(txtpaid.Text)
        '    'txtlrno.Text = RupeesToWord(Val(txtbalance.Text))
        '   txtamtinword.Text = RupeesToWord(FormatNumber(txtgtotal.Text, 0))
        txtgtotal.Text = FormatNumber(txtgtotal.Text, 0)
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub txtpaid_TextChanged(sender As Object, e As EventArgs) Handles txtpaid.TextChanged
        txtrem.Text = Val(txtgtotal.Text) - Val(txtpaid.Text)
    End Sub

    Private Sub txtgst_TextChanged(sender As Object, e As EventArgs) Handles txtgst.TextChanged
        txtTGST.Text = Val(txttotal.Text) * Val(txtgst.Text) / 100
    End Sub

    Private Sub txtTGST_TextChanged(sender As Object, e As EventArgs) Handles txtTGST.TextChanged

    End Sub
End Class