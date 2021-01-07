Public Class Form1


    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Input
        Const PercentTip15 As Decimal = 0.15
        Const PercentTip5 As Decimal = 0.05
        Dim InAmount As Decimal
        Try
            InAmount = tbxInput.Text
        Catch ex As Exception
            MessageBox.Show("Enter numeric value")
            tbxInput.Text = String.Empty
            Me.Focus()
            Exit Sub
        End Try
        'Calculate
        Dim Tip5 As Decimal = InAmount * PercentTip5
        Dim Tip15 As Decimal = InAmount * PercentTip15
        Dim Total15 As Decimal = InAmount + Tip15
        Dim Total5 As Decimal = InAmount + Tip5
        'Output
        tbxTip15.Text = Tip15.ToString("C")
        tbxTip5.Text = Tip5.ToString("c")
        tbxTotal15.Text = Total15.ToString("c")
        tbxTotal5.Text = Total5.ToString("c")
    End Sub
End Class
