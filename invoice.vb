Imports System.Data.OleDb

Public Class invoice
    Private Sub invoice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        kh()
        newid()
    End Sub
    Public Sub newid()
        Dim rs As New ADODB.Recordset
        Dim bn As Integer
        rs.Open("select max(Inw_No) from INVOICE ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If IsDBNull(rs.Fields(0).Value) Then
            bn = 0
        Else
            bn = Val(rs.Fields(0).Value)
        End If
        txtinward.Text = bn + 1
    End Sub


    Private Sub btnenter_Click(sender As Object, e As EventArgs) Handles btnenter.Click
        If (txtNTOT.Text > 0) Then
            Dim rs As Integer
            dg.Rows.Add()
            rs = Val(dg.Rows.Count) - 1
            dg.Rows(rs).Cells(0).Value = txtpid.Text
            dg.Rows(rs).Cells(1).Value = cmbptype.Text()
            dg.Rows(rs).Cells(2).Value = cmbname.Text()
            dg.Rows(rs).Cells(3).Value = txtqty.Text
            dg.Rows(rs).Cells(4).Value = txtrate.Text
            dg.Rows(rs).Cells(5).Value = Val(txtperpc.Text)
            dg.Rows(rs).Cells(6).Value = txttotal.Text
            dg.Rows(rs).Cells(7).Value = txtgst.Text
            dg.Rows(rs).Cells(8).Value = txtTGST.Text
            dg.Rows(rs).Cells(9).Value = Val(txtNTOT.Text)

            total()


            txtpid.Text = ""
            cmbptype.Text = ""
            cmbname.Text = ""
            txtqty.Text = ""
            txtrate.Text = ""
            txttotal.Text = ""
            txtgst.Text = ""
            txtTGST.Text = ""
            txtNTOT.Text = ""
            cmbptype.Focus()
        End If
    End Sub
    Public Sub total()
        Dim t, i, k As Integer
        t = 0
        k = (dg.Rows.Count) - 1
        For i = 0 To k
            t = t + dg.Rows(i).Cells(9).Value
        Next
        txtgtot.Text = t
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        txtcustname.Text = ""
        txtcustadd.Text = ""
        txtcustcity.Text = ""
        txtcustmob.Text = ""
        txtname.Text = ""
        txtcity.Text = ""
        txtcity.Text = ""
        txtmob.Text = ""
        newid()
    End Sub

    Private Sub cmbtype_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbptype.SelectedIndexChanged
        cmbname.Items.Clear()
        Dim kh As New ADODB.Recordset
        kh.Open("select PROD_NAME,GST,code from PRODUCTS where PROD_TYPE='" & cmbptype.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If kh.RecordCount > 0 Then
            While kh.EOF = False
                cmbname.Items.Add(kh.Fields(0).Value)
                txtgst.Text = kh.Fields(1).Value
                txtpid.Text = kh.Fields(2).Value
                kh.MoveNext()
            End While
        End If
    End Sub

    Private Sub txtqty_TextChanged(sender As Object, e As EventArgs) Handles txtqty.TextChanged
        txttotal.Text = Val(txtqty.Text) * Val(txtrate.Text)
        '  txtTGST.Text = Val(txttotal.Text) * Val(txtgst.Text) / 100
    End Sub

    Private Sub txtrate_TextChanged(sender As Object, e As EventArgs) Handles txtrate.TextChanged
        txttotal.Text = Val(txtqty.Text) * Val(txtrate.Text)
        'txtTGST.Text = Val(txttotal.Text) * Val(txtgst.Text) / 100
    End Sub

    Private Sub txtTGST_TextChanged(sender As Object, e As EventArgs) Handles txtTGST.TextChanged
        txtNTOT.Text = Val(txtTGST.Text) + Val(txttotal.Text)
    End Sub
    Public Sub kh()
        Dim rs As New ADODB.Recordset
        rs.Open("select PROD_TYPE from PRODUCTS ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        While rs.EOF = False
            cmbptype.Items.Add(rs.Fields(0).Value)
            ' cmbname.Items.Clear()
            rs.MoveNext()
        End While
    End Sub

    Private Sub txtcustname_TextChanged(sender As Object, e As EventArgs) Handles txtcustname.TextChanged
        dgv.Visible = True
        Dim constr As String
        constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database5.accdb"
        Dim qry As String = "select distinct CUST_NAME from  CUSTOMER_INFO where CUST_NAME like '%" & txtcustname.Text & "%'"
        Dim con As New OleDbConnection(constr)
        Dim da As New OleDbDataAdapter(qry, con)
        Dim ds As New DataSet
        con.Open()
        da.Fill(ds, "CUSTOMER_INFO")
        con.Close()
        dgv.DataSource = ds
        dgv.DataMember = "CUSTOMER_INFO"

    End Sub

    Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellClick
        txtcustname.Text = dgv.CurrentRow.Cells(0).Value
        dgv.Visible = False
        Dim kh As New ADODB.Recordset
        kh.Open("select ADDRESS ,CITY ,MOB_NO from CUSTOMER_INFO where CUST_NAME ='" & txtcustname.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If kh.RecordCount > 0 Then
            While kh.EOF = False
                txtcustadd.Text = kh.Fields(0).Value
                txtcustcity.Text = kh.Fields(1).Value
                txtcustmob.Text = kh.Fields(2).Value

                txtname.Text = txtcustname.Text
                txtadd.Text = kh.Fields(0).Value
                txtcity.Text = kh.Fields(1).Value
                txtmob.Text = kh.Fields(2).Value


                kh.MoveNext()

            End While
        End If

    End Sub
    'Public Sub demo()
    '    dgv.Columns.Clear()
    '    Dim rs As New ADODB.Recordset
    '    rs.Open("select CUST_NAME from CUSTOMER_INFO where CUST_NAME like '%" & txtcustname.Text & "%'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
    '    If rs.RecordCount > 0 Then
    '        While rs.EOF = False
    '            dgv.Columns.Add(rs.Fields(0).Value)
    '            rs.MoveNext()
    '        End While

    '    End If
    'End Sub

    'Private Sub dgv_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick
    '    ' rno = Val(dg.CurrentRow.Index)
    '    txtcustname.Text = dg.CurrentRow.Cells(0).Value
    '    txtid.Text = dg.CurrentRow.Cells(0).Value

    'End Sub


    Private Sub txtpaidamt_TextChanged(sender As Object, e As EventArgs) Handles txtpaidamt.TextChanged
        txtbalance.Text = txtgtot.Text - txtpaidamt.Text
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim rc As Integer
        rc = Val(dg.Rows.Count) - 1
        Dim rs As New ADODB.Recordset
        For r = 0 To rc
            If rs.State = 1 Then rs.Close()
            rs.Open("select qty from STOCK where id=" & Val(Me.dg.Rows(r).Cells(0).Value) & "", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
            rs.Fields(0).Value = Val(rs.Fields(0).Value) - Val(dg.Rows(r).Cells(3).Value)
            rs.Update()
        Next



        Dim kh As Integer
        kh = Val(dg.Rows.Count) - 1
        Dim s As New ADODB.Recordset
        s.Open("INVOICE", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For r = 0 To kh
            s.AddNew()
            s.Fields(0).Value = Val(txtinward.Text)
            s.Fields(1).Value = txtcustname.Text
            s.Fields(2).Value = txtcustmob.Text
            s.Fields(3).Value = dg.Rows(r).Cells(0).Value
            s.Fields(4).Value = dg.Rows(r).Cells(1).Value
            s.Fields(5).Value = dg.Rows(r).Cells(2).Value
            s.Fields(6).Value = dg.Rows(r).Cells(3).Value
            s.Fields(7).Value = dg.Rows(r).Cells(4).Value
            s.Fields(8).Value = dg.Rows(r).Cells(5).Value
            s.Fields(9).Value = dg.Rows(r).Cells(6).Value
            s.Fields(10).Value = dg.Rows(r).Cells(7).Value
            s.Fields(11).Value = dg.Rows(r).Cells(8).Value
            s.Fields(12).Value = dg.Rows(r).Cells(9).Value
            s.Fields(13).Value = Val(txtgtot.Text)
            s.Fields(14).Value = Val(txtpaidamt.Text)
            s.Fields(15).Value = Val(txtbalance.Text)
            s.Fields(16).Value = cmbtype.Text
            s.Fields(17).Value = txtextra.Text
        Next
        s.Save()

        Dim da As Integer
        da = Val(dg.Rows.Count) - 1
        Dim ab As New ADODB.Recordset
        ab.Open("CUSTOMER_AC", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        For r = 0 To da
            ab.AddNew()
            ab.Fields(0).Value = Val(txtinward.Text)
            ab.Fields(1).Value = txtcustname.Text
            ab.Fields(2).Value = dtpdate.Value.Date
            ab.Fields(3).Value = Val(txtgtot.Text)
            ab.Fields(4).Value = "0"
            ab.Fields(5).Value = Val(txtpaidamt.Text)
            ab.Fields(6).Value = cmbtype.Text
        Next
        ab.Save()


        MsgBox("Save Successfully..")
    End Sub

    Private Sub txtNTOT_TextChanged(sender As Object, e As EventArgs) Handles txtNTOT.TextChanged
        txtperpc.Text = Val(txtNTOT.Text) / Val(txtqty.Text)
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

    Private Sub txtinward_TextChanged(sender As Object, e As EventArgs) Handles txtinward.TextChanged

    End Sub

    Private Sub txtgst_TextChanged(sender As Object, e As EventArgs) Handles txtgst.TextChanged
        txtTGST.Text = Val(txttotal.Text) * Val(txtgst.Text) / 100

    End Sub

    Private Sub btnprint_Click(sender As Object, e As EventArgs) Handles btnprint.Click

    End Sub
End Class