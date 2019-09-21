Public Class frmFutureValue

    Private Sub btnCalculate_Click(sender As Object,
            e As EventArgs) Handles btnCalculate.Click

        Dim monthlyInvestment As Decimal = CDec(txtMonthlyInvestment.Text)
        Dim yearlyInterestRate As Decimal = CDec(txtInterestRate.Text)
        Dim years As Integer = CInt(txtYears.Text)

        Dim monthlyInterestRate As Decimal = yearlyInterestRate / 12 / 100
        Dim months As Integer = years * 12

        Dim futureValue As Decimal = Me.FutureValue(monthlyInvestment, monthlyInterestRate, months)

        txtFutureValue.Text = FormatCurrency(futureValue)
        txtMonthlyInvestment.Select()
    End Sub

    Private Function FutureValue(monthlyInvestment As Decimal,
            monthlyInterestRate As Decimal, ByVal months As Integer) _
            As Decimal
        For i As Integer = 1 To months
            FutureValue = (FutureValue + monthlyInvestment) *
                          (1 + monthlyInterestRate)
        Next
        Return FutureValue
    End Function

    Private Sub ClearFutureValue(sender As Object,
            e As EventArgs) Handles txtMonthlyInvestment.TextChanged,
            txtYears.TextChanged, txtInterestRate.TextChanged
        txtFutureValue.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object,
            e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub txtInterestRate_DoubleClick(sender As Object, e As EventArgs) Handles txtInterestRate.DoubleClick

    End Sub
End Class