Public Class frmFutureValue

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click
        Dim monthlyInvestment As Decimal = CDec(txtMonthlyInvestment.Text)
        Dim yearlyInterestRate As Decimal = CDec(txtInterestRate.Text)
        Dim years As Integer = CInt(txtYears.Text)

        Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
        Dim months As Integer = years * 12

        Dim futureValue As Decimal
        For i As Integer = 1 To months
            futureValue = (futureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
        Next
        txtFutureValue.Text = FormatCurrency(futureValue)
        txtMonthlyInvestment.Select()
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class