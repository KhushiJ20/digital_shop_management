Public Class Entry_Form
   
    Private Sub btnregistration_Click(sender As Object, e As EventArgs) Handles btnregistration.Click
        Registration.Show()
    End Sub

    Private Sub GunaGradientButton2_Click(sender As Object, e As EventArgs) Handles btncust_info.Click
        CUSTOMER_INFO.Show()
    End Sub

    Private Sub GunaGradientButton3_Click(sender As Object, e As EventArgs) Handles btninwd.Click
        inward.Show()
    End Sub

    Private Sub btndeler_Click(sender As Object, e As EventArgs) Handles btndeler.Click
        Dealer_master.Show()
    End Sub

    Private Sub btnprod_Click(sender As Object, e As EventArgs) Handles btnprod.Click
        PRODUCT.Show()
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()
    End Sub

    Private Sub btninvoice_Click(sender As Object, e As EventArgs) Handles btninvoice.Click
        invoice.Show()
    End Sub

    Private Sub btndealeracc_Click(sender As Object, e As EventArgs) Handles btndealeracc.Click
        DEALER_ACC.Show()
    End Sub

    Private Sub btncustacc_Click(sender As Object, e As EventArgs) Handles btncustacc.Click
        CUST_ACC.Show()
    End Sub

    Private Sub btndelpayment_Click(sender As Object, e As EventArgs) Handles btndelpayment.Click
        DEALER_PAYMENT.Show()
    End Sub
End Class