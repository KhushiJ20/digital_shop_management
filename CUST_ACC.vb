Imports System.Data.OleDb

Public Class CUST_ACC

    Private Sub txtcustname_TextChanged(sender As Object, e As EventArgs) Handles txtcustname.TextChanged
        dgv.Visible = True
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

    End Sub
    'Public Sub getestmdetail_beforeDate()
    '    msd.Rows = 0
    '    cr = 0
    '    db = 0
    '    gst = 0
    '    Dim rs As New ADODB.Recordset
    '    Dim t As String
    '    t = "PURCHASE"
    '    rs.Open("select * from customeraccount where not type='" & t & "' and  tdate < #" & FormatDateTime(dtp.Value.Date, DateFormat.GeneralDate) & "#  order by tdate asc", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
    '    If rs.RecordCount > 0 Then
    '        While rs.EOF = False
    '            cr = cr + Val(rs.Fields(6).Value)
    '            db = db + Val(rs.Fields(7).Value)
    '            gst = gst + Val(rs.Fields(10).Value)

    '            rs.MoveNext()
    '        End While
    '        bal = cr - db
    '        msd.Rows = msd.Rows + 1
    '        msd.set_TextMatrix(msd.Rows - 1, 2, "Prev")
    '        msd.set_TextMatrix(msd.Rows - 1, 3, cr)
    '        msd.set_TextMatrix(msd.Rows - 1, 4, db)
    '        msd.set_TextMatrix(msd.Rows - 1, 6, gst)
    '    Else
    '        MsgBox("No Transaction")
    '    End If

    'End Sub

    Private Sub CUST_ACC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
    End Sub

 
    Private Sub btnshow_Click(sender As Object, e As EventArgs) Handles btnshow.Click





        Dim constr As String
        Dim qry As String
        constr = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=D:\Database5.accdb"
        ' qry = "select * from CUSTOMER_AC where CUST_NAME ='" & txtcustname.Text & "' and I_date>=" & Val(dtpfrom.Value.Date) & "and I_date <=" & Val(dtpto.Value.Date) & ""
        qry = "select * from CUSTOMER_AC where CUST_NAME ='" & txtcustname.Text & "' and I_date>=# " & dtpfrom.Value.Date & " # and I_date <=# " & dtpto.Value.Date & "#"
        'qry = "select * from CUSTOMER_AC where CUST_NAME ='" & txtcustname.Text & "'"


        Dim con As New OleDbConnection(constr)
        Dim da As New OleDbDataAdapter(qry, con)
        Dim ds As New DataSet
        con.Open()
        da.Fill(ds, "CUSTOMER_AC")
        con.Close()
        dg.DataSource = ds
        dg.DataMember = "CUSTOMER_AC"

        '        '  dgv.Rows.Clear()
        '        Dim rc As New ADODB.Recordset
        '        Dim kh As Integer
        '        '  rc.Open("select * from DEALER_AC where DEALER_NAME='" & dg.CurrentRow.Cells(1).Value & "' ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        '        If rc.RecordCount > 0 Then
        '            MsgBox(rc.RecordCount)
        '            While rc.EOF = False
        '                lbltot.Text = Val(lbltot.Text) + dgv.Rows(kh).Cells(3).Value
        '                lblpaid.Text = Val(lblpaid.Text) + Val(dgv.Rows(kh).Cells(4).Value)
        '                lblbal.Text = Val(lblbal.Text) + dgv.Rows(kh).Cells(5).Value

        '            End While
        'End If 
        'lbltot.Text = Val(lbltot.Text) + dgv.Rows(kh).Cells(3).Value
        'lblpaid.Text = Val(lblpaid.Text) + Val(dgv.Rows(kh).Cells(4).Value)
        'lblbal.Text = Val(lblbal.Text) + dgv.Rows(kh).Cells(5).Value
    End Sub

   
    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub txtinwno_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub lblcust_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub lbltot_Click(sender As Object, e As EventArgs) Handles lbltot.Click

    End Sub
End Class