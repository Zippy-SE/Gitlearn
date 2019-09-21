Public Class frmInvoiceTotal

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Dim subtotal As Decimal = CDec(txtSubtotal.Text)
        Dim discountPercent As Decimal

        If txtCustomerType.Text = "R" Then
            If subtotal < 100 Then
                discountPercent = 0
            ElseIf subtotal >= 100 AndAlso subtotal < 250 Then
                discountPercent = 0.1D
            ElseIf subtotal >= 250 Then
                discountPercent = 0.25D
            End If
        ElseIf txtCustomerType.Text = "C" Then
            If subtotal < 250 Then
                discountPercent = 0.2D
            Else
                discountPercent = 0.3D
            End If
        Else
            discountPercent = 0.4D
        End If

        Dim discountAmount As Decimal = subtotal * discountPercent
        Dim invoiceTotal As Decimal = subtotal - discountAmount

        txtDiscountPercent.Text = FormatPercent(discountPercent, 1)
        txtDiscountAmount.Text = FormatCurrency(discountAmount)
        txtTotal.Text = FormatCurrency(invoiceTotal)

        txtCustomerType.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

End Class