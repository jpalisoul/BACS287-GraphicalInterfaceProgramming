Public Class Form1

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnCalc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCalc.Click
        Dim dblInitialDeposit As Double = 0
        Dim dblInterest As Double = 0
        Dim dblPeriod As Double = 0
        Dim dblDeposits As Double = 0
        Dim decFutureValue As Decimal = 0

        ' Check Initial Deposit field for validity
        If Not (Double.TryParse(txtInitialValue.Text, dblInitialDeposit)) Then
            MsgBox("Error: Initial Value not a number")
            Exit Sub
        End If
        If dblInitialDeposit < 0 Then
            MsgBox("Error: Initial Deposit must be positive")
            Exit Sub
        End If
        ' Check Interest field for validity
        If Not (Double.TryParse(txtInterest.Text, dblInterest)) Then
            MsgBox("Error: Interest not a number")
            Exit Sub
        End If
        If dblInterest < 0 Then
            MsgBox("Error: Interest must be positive")
            Exit Sub
        End If
        ' Check Time Period field for validity
        If Not (Double.TryParse(txtPeriod.Text, dblPeriod)) Then
            MsgBox("Error: Period not a number")
            Exit Sub
        End If
        If dblPeriod < 0 Then
            MsgBox("Error: Perios field must be positive")
            Exit Sub
        End If
        ' Check Periodic Deposits field for validity
        If Not (Double.TryParse(txtDeposit.Text, dblDeposits)) Then
            MsgBox("Error: Deposit not a number")
            Exit Sub
        End If
        If dblDeposits < 0 Then
            MsgBox("Error: Deposits field must be positive")
            Exit Sub
        End If

        ' Check interest rate to see if reasonable
        If dblInterest < 0 Or dblInterest > 100 Then
            MsgBox("Error Interest out of range")
            Exit Sub
        End If

        ' Interest rate not reasonable, so scale for them
        If dblInterest >= 1 Then
            dblInterest = dblInterest / 100
        End If
        ' Scale the remainder of the input data for monthly payments
        dblInterest = dblInterest / 12
        dblPeriod = dblPeriod * 12

        ' use this data to call the built-in Future Value function
        decFutureValue = my_FV(dblInterest, dblPeriod, -dblDeposits, dblInitialDeposit)

        ' Put the final value in the form
        lblFutureValue.Text = decFutureValue.ToString("C2")

    End Sub

    Private Sub btnClear_Click(sender As System.Object, e As System.EventArgs) Handles btnClear.Click
        txtDeposit.Clear()
        txtInitialValue.Clear()
        txtInterest.Clear()
        txtPeriod.Clear()
        lblFutureValue.Text = ""
        txtDeposit.Focus()
    End Sub
End Class
