Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'clearing inputs, setting down payment to zero and setting 'radMonthly' to True'
        txtInput1.Clear()
        txtInput2.Text = "0"
        txtInput3.Clear()
        txtInput4.Clear()
        lblLoanAmount.Text = ""
        lblPayment.Text = ""
        lblPrinciple.Text = ""
        lblInterest.Text = ""
        radMonthly.Checked = True
        radQuarterly.Checked = False
        radYearly.Checked = False
        txtInput1.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'creating variables'

        Dim dblHouseCost As Double = 0
        Dim dblDownPayment As Double = 0
        Dim dblInterest As Double = 0
        Dim dblYears As Double = 0
        Dim dblPaymentOutput As Double = 0
        Dim dblPrincipleOutput As Double = 0
        Dim dblInterestOutput As Double = 0
        Dim dblLoanAmount As Double = 0
        Dim blnIsConverted As Boolean = False

        'Moving txtInput1 into dblHouseCost and checking for valid characters'
        blnIsConverted = Double.TryParse(txtInput1.Text, dblHouseCost)
        If blnIsConverted = False Then
            MsgBox("Error--Input Must be Numeric for House Cost", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Moving txtInput2 into dblDownPayment and checking for valid characters'
        blnIsConverted = Double.TryParse(txtInput2.Text, dblDownPayment)
        If blnIsConverted = False Then
            MsgBox("Error--Input Must be Numeric for Down Payment", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Moving txtInput3 into dblInterest and checking for valid characters'
        blnIsConverted = Double.TryParse(txtInput3.Text, dblInterest)
        If blnIsConverted = False Then
            MsgBox("Error--Input Must be Numeric for Interst %", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput3.Clear()
            txtInput3.Focus()
            Exit Sub
        End If

        'Moving txtInput4 into dblYears and checking for valid characters'
        blnIsConverted = Double.TryParse(txtInput4.Text, dblYears)
        If blnIsConverted = False Then
            MsgBox("Error--Input Must be Numeric for Years", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput4.Clear()
            txtInput4.Focus()
            Exit Sub
        End If

        If dblHouseCost <= 0 Then
            MsgBox("Error--Input Must be Greater than 0 for House Cost", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        If dblDownPayment < 0 Then
            MsgBox("Error--Input Must be at least 0 for Down Payment", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        If dblInterest <= 0 Then
            MsgBox("Error--Input Must be Greater than 0 for Interest", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput3.Clear()
            txtInput3.Focus()
            Exit Sub
        End If

        If dblYears <= 0 Then
            MsgBox("Error--Input Must be Greater than 0 for Years", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput4.Clear()
            txtInput4.Focus()
            Exit Sub
        End If

        If dblDownPayment > dblHouseCost Then
            MsgBox("Error--Down Payment is greater than House Cost", MsgBoxStyle.OkOnly, "Error")
            txtInput1.Clear()
            txtInput2.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        If dblInterest >= 1 Then
            dblInterest = dblInterest / 100
            MsgBox("Check--We scaled your Interest input down to decimal Interest", MsgBoxStyle.OkOnly, "Notification")
        End If


        'Monthly Payment'
        If radMonthly.Checked() = True Then
            dblInterest = dblInterest / 12
            dblYears = dblYears * 12
            dblLoanAmount = dblHouseCost - dblDownPayment
            'Calling Functions'
            dblPaymentOutput = payment(dblInterest, dblYears, -dblLoanAmount)
            dblPrincipleOutput = pop(dblInterest, 1, dblYears, -dblLoanAmount)
            dblInterestOutput = interest(dblInterest, 1, dblYears, -dblLoanAmount)

            'output'
            lblLoanAmount.Text = "$" + dblLoanAmount.ToString("n")
            lblPayment.Text = "$" + dblPaymentOutput.ToString("n")
            lblPrinciple.Text = "$" + dblPrincipleOutput.ToString("n")
            lblInterest.Text = "$" + dblInterestOutput.ToString("n")

        End If

        'Quarterly Payment'
        If radQuarterly.Checked() = True Then
            dblInterest = dblInterest / 4
            dblYears = dblYears * 4
            dblLoanAmount = dblHouseCost - dblDownPayment
            'Calling Functions'
            dblPaymentOutput = payment(dblInterest, dblYears, -dblLoanAmount)
            dblPrincipleOutput = pop(dblInterest, 1, dblYears, -dblLoanAmount)
            dblInterestOutput = interest(dblInterest, 1, dblYears, -dblLoanAmount)

            'output'
            lblLoanAmount.Text = "$" + dblLoanAmount.ToString("n")
            lblPayment.Text = "$" + dblPaymentOutput.ToString("n")
            lblPrinciple.Text = "$" + dblPrincipleOutput.ToString("n")
            lblInterest.Text = "$" + dblInterestOutput.ToString("n")

        End If

        'Yearly Payment'
        If radYearly.Checked() = True Then
            dblLoanAmount = dblHouseCost - dblDownPayment
            'Calling Functions'
            dblPaymentOutput = payment(dblInterest, dblYears, -dblLoanAmount)
            dblPrincipleOutput = pop(dblInterest, 1, dblYears, -dblLoanAmount)
            dblInterestOutput = interest(dblInterest, 1, dblYears, -dblLoanAmount)

            'output'
            lblLoanAmount.Text = "$" + dblLoanAmount.ToString("n")
            lblPayment.Text = "$" + dblPaymentOutput.ToString("n")
            lblPrinciple.Text = "$" + dblPrincipleOutput.ToString("n")
            lblInterest.Text = "$" + dblInterestOutput.ToString("n")

        End If



    End Sub
End Class
