Public Class DEALER_ACC

    Private Sub DEALER_ACC_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        opendb()
        getdealer()
    End Sub
    Public Sub getdealer()
        dg.Rows.Clear()
        Dim rs As New ADODB.Recordset
        Dim rc As Integer
        rs.Open("select * from DEALER ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rs.RecordCount > 0 Then
            While rs.EOF = False
                dg.Rows.Add()
                rc = Val(dg.Rows.Count) - 1
                dg.Rows(rc).Cells(0).Value = rs.Fields(0).Value
                dg.Rows(rc).Cells(1).Value = rs.Fields(1).Value
                dg.Rows(rc).Cells(2).Value = rs.Fields(2).Value
                dg.Rows(rc).Cells(3).Value = rs.Fields(3).Value
                dg.Rows(rc).Cells(4).Value = rs.Fields(4).Value
                dg.Rows(rc).Cells(5).Value = rs.Fields(5).Value
                dg.Rows(rc).Cells(6).Value = rs.Fields(6).Value

                rs.MoveNext()
            End While
        End If
    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
        dgv.Rows.Clear()
        Dim rc As New ADODB.Recordset
        Dim kh As Integer
        rc.Open("select * from DEALER_AC where DEALER_NAME='" & dg.CurrentRow.Cells(1).Value & "' ", con, ADODB.CursorTypeEnum.adOpenStatic, ADODB.LockTypeEnum.adLockOptimistic)
        If rc.RecordCount > 0 Then
            MsgBox(rc.RecordCount)
            While rc.EOF = False
                dgv.Rows.Add()
                kh = Val(dgv.Rows.Count) - 1
                dgv.Rows(kh).Cells(0).Value = rc.Fields(0).Value
                dgv.Rows(kh).Cells(1).Value = rc.Fields(2).Value
                dgv.Rows(kh).Cells(2).Value = rc.Fields(4).Value
                dgv.Rows(kh).Cells(3).Value = rc.Fields(5).Value
                dgv.Rows(kh).Cells(4).Value = rc.Fields(6).Value
                dgv.Rows(kh).Cells(5).Value = rc.Fields(7).Value

                rc.MoveNext()

                lbltot.Text = Val(lbltot.Text) + dgv.Rows(kh).Cells(3).Value
                lbldb.Text = Val(lbldb.Text) + Val(dgv.Rows(kh).Cells(4).Value)
                lblbal.Text = Val(lblbal.Text) + dgv.Rows(kh).Cells(5).Value
                'rc.MoveNext()
            End While
        End If



    End Sub

    'Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick
    '    dgv.Rows(rc).cells(0).value = dg.CurrentRow.Cells(0).Value
    '    txtname.Text = dg.CurrentRow.Cells(1).Value
    '    txtaddress.Text = dg.CurrentRow.Cells(2).Value
    '    txtcity.Text = dg.CurrentRow.Cells(3).Value
    '    txtmob.Text = dg.CurrentRow.Cells(3).Value
    'End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick

    End Sub

    Private Sub dgv_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgv.CellContentClick

    End Sub

  
    Private Sub GunaGradientButton1_Click(sender As Object, e As EventArgs) Handles GunaGradientButton1.Click
        Me.Close()
    End Sub
End Class