Public Class DEALER_PAYMENT

   
    Private Sub DEALER_PAYMENT_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        vi()
        newid()
    End Sub
    Public Sub vi()
        cmbdealername.Items.Clear()
        Dim rs As New ADODB.Recordset
        'If rs.State = 1 Then rs.Close()
        rs.Open("select DEALER_NAME from DEALER", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        ' If rs.RecordCount > 0 Then
        While rs.EOF = False
            cmbdealername.Items.Add(rs.Fields(0).Value)
            rs.MoveNext()
        End While
        ' End If

    End Sub
    Public Sub clear_control()
        For Each c In Me.Controls
            If TypeOf c Is TextBox Or TypeOf c Is ComboBox Then
                c.Text = ""
            End If
        Next
    End Sub
    Public Sub newid()
        Dim rs As New ADODB.Recordset
        Dim bn As Integer
        rs.Open("select max(INWARD_No) from DEALER_AC", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If IsDBNull(rs.Fields(0).Value) Then
            bn = 0
        Else
            bn = Val(rs.Fields(0).Value)
        End If
        txtreceiptno.Text = bn + 1
    End Sub
   
    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click
        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("DEALER_AC", con, ADODB.CursorTypeEnum.adOpenDynamic, ADODB.LockTypeEnum.adLockOptimistic)
        rs.AddNew()
        rs.Fields(0).Value = Val(txtreceiptno.Text)
        rs.Fields(1).Value = "PAYMENT"
        rs.Fields(2).Value = txtdcode.Text
        rs.Fields(3).Value = cmbdealername.Text
        rs.Fields(4).Value = inwdate.Value.Date
        rs.Fields(5).Value = "0"
        rs.Fields(6).Value = txtAmountpaid.Text
        rs.Fields(7).Value = txtbalance.Text
        rs.Fields(8).Value = txtextra.Text
        ' rs.Fields(10).Value = 0

        rs.Save()

        MsgBox("Dealer Payment update successfully......")

        clear_control()
        'newid()
    End Sub

    Private Sub cmbdealername_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbdealername.SelectedIndexChanged
        Dim kh As New ADODB.Recordset
        kh.Open("select ID,CITY from DEALER where DEALER_NAME ='" & cmbdealername.Text & "'", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If kh.RecordCount > 0 Then
                txtdcode.Text = kh.Fields(0).Value
                txtcity.Text = kh.Fields(1).Value

        Else
            txtdcode.Text = "" 'kh.Fields(0).Value
            txtcity.Text = "" 'kh.Fields(1).Value


        End If

    End Sub
    Public Sub dealer_acc()
        Dim credit, debit As Double
        credit = 0
        debit = 0
        Dim rs As New ADODB.Recordset
        If rs.State = 1 Then rs.Close()
        rs.Open("select TOTAL ,DEBIT from DEALER_AC where DEALER_ID=" & Val(txtdcode.Text) & "", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockBatchOptimistic)
        If rs.RecordCount > 0 Then
            While rs.EOF = False
                credit = credit + Val(rs.Fields(0).Value)
                debit = debit + Val(rs.Fields(1).Value)
                rs.MoveNext()
            End While
            ' txttotal.Text = credit - debit
        End If
        txttotal.Text = credit - debit


    End Sub

    Private Sub txtdcode_TextChanged(sender As Object, e As EventArgs) Handles txtdcode.TextChanged
        dealer_acc()
    End Sub

    Private Sub txtAmountpaid_TextChanged(sender As Object, e As EventArgs) Handles txtAmountpaid.TextChanged
        If IsNumeric(txtAmountpaid.Text) Then
            txtbalance.Text = Val(txttotal.Text) - Val(txtAmountpaid.Text)
        Else
            txtAmountpaid.Text = ""
        End If
        txtbalance.Text = Val(txttotal.Text) - Val(txtAmountpaid.Text)

    End Sub
End Class