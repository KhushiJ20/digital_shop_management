Imports System.Data.OleDb

Public Class CUSTOMER_PAYMENT

    'Public Sub getdealer_acc()
    '    Dim credit, balance As Double
    '    credit = 0
    '    balance = 0
    '    Dim rs As New ADODB.Recordset
    '    If rs.State = 1 Then rs.Close()
    '    rs.Open("select Credit, Balance from CUSTOMER_AC where Cid=" & txtid.Text & "", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
    '    If rs.RecordCount > 0 Then
    '        While rs.EOF = False
    '            credit = credit + Val(rs.Fields(0).Value)
    '            balance = balance + Val(rs.Fields(1).Value)
    '            rs.MoveNext()
    '        End While
    '        txttot.Text = credit - balance
    '    End If
    '    txttot.Text = credit - balance
    '    txtbal.Text = Val(txttot.Text) - Val(txtpaid.Text)

    'End Sub

    Private Sub CUSTOMER_PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()

    End Sub



    Private Sub txtpaid_TextChanged(sender As Object, e As EventArgs) Handles txtpaid.TextChanged
        'If Not IsNumeric(txtpaid.Text) Then
        '    txtpaid.Text = ""
        'End If
        'txtbal.Text = Val(txttot.Text) - (Val(txtpaid.Text))
    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        'Dim rs As New ADODB.Recordset
        'If rs.State = 1 Then rs.Close()
        'rs.Open("customeraccount", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        'rs.AddNew()
        'rs.Fields(0).Value = txtreceipttno.Text
        'rs.Fields(1).Value = "PAYMENT"
        'rs.Fields(2).Value = txtdcode.Text
        'rs.Fields(3).Value = txtdname.Text
        'rs.Fields(4).Value = txtcity.Text
        'rs.Fields(5).Value = inwdate.Value.Date
        'rs.Fields(6).Value = "0" 'txtGtotal.Text
        'rs.Fields(7).Value = CDbl(txtAmountpaid.Text)
        'rs.Fields(8).Value = txtextra.Text
        'rs.Fields(9).Value = CDbl(txtbalance.Text)

        'rs.Fields(10).Value = 0 'txtextra.Text

        'rs.Save()

        'If rs.State = 1 Then rs.Close()
        'rs.Open("customerreceipt", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        'rs.AddNew()
        'rs.Fields(0).Value = txtreceipttno.Text
        'rs.Save()

        'MsgBox("Customer Payment update successfuly......")
        'no = Val(txtreceipttno.Text)
        ''Button3_Click(sender, e)
        'clear_control()
        'newid()
    End Sub


   

    Private Sub txtid_TextChanged(sender As Object, e As EventArgs) Handles txtid.TextChanged
        '   getdealer_acc()
        If Val(txtid.Text) > 0 Then Customer_acc()
    End Sub

    Private Sub txtcustname_TextChanged_1(sender As Object, e As EventArgs) Handles txtcustname.TextChanged
        dg.Visible = True
        Dim constr As String
        constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database5.accdb"
        Dim qry As String = "select * from  CUSTOMER_INFO where CUST_NAME like '%" & txtcustname.Text & "%'"
        Dim con As New OleDbConnection(constr)
        Dim da As New OleDbDataAdapter(qry, con)
        Dim ds As New DataSet
        con.Open()
        da.Fill(ds, "CUSTOMER_INFO")
        con.Close()
        dg.DataSource = ds
        dg.DataMember = "CUSTOMER_INFO"


    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        txtcustname.Text = dg.CurrentRow.Cells(1).Value
        dg.Visible = False
        Dim kh As New ADODB.Recordset
        kh.Open("select ID ,CITY from CUSTOMER_INFO where CUST_NAME ='" & txtcustname.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If kh.RecordCount > 0 Then
            While kh.EOF = False
                txtid.Text = kh.Fields(0).Value
                txtcity.Text = kh.Fields(1).Value

                kh.MoveNext()
            End While
        End If


        'Dim vi As New ADODB.Recordset
        'vi.Open("select ID ,CITY from CUSTOMER_INFO where CUST_NAME ='" & txtcustname.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        'If kh.RecordCount > 0 Then
        '    While kh.EOF = False
        '        txtid.Text = kh.Fields(0).Value
        '        txtcity.Text = kh.Fields(1).Value

        '        kh.MoveNext()
        '    End While
        'End If
    End Sub
    Public Sub Customer_acc()
        Dim credit, debit As Double
        credit = 0
        debit = 0
        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("select Total , creadit from CUSTOMER_AC where Cid=" & Val(txtid.Text) & "", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount > 0 Then
            While rs.EOF = False
                credit = credit + Val(rs.Fields(0).Value)
                debit = debit + Val(rs.Fields(1).Value)
                rs.MoveNext()
            End While
            ' txttotal.Text = credit - debit
        End If
        txttot.Text = credit - debit


    End Sub
    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

   
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btnnew_Click(sender As Object, e As EventArgs) Handles btnnew.Click
        clear_control()
    End Sub
    Public Sub clear_control()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub

End Class