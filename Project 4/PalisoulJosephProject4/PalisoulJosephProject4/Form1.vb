Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click

        'Closting the Form'
        Me.Close()

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        'Clearing Inputs and Output label'
        txtInput1.Clear()
        txtInput2.Clear()
        txtInput3.Clear()
        lblOutput.Text = ""
        txtInput1.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        Dim dblInput1 As Double = 0
        Dim dblInput2 As Double = 0
        Dim dblInput3 As Double = 0
        Dim dblOutput As Double = 0
        Dim intYears As Int16 = 0
        Dim blnIsConverted As Boolean = False
        Dim blnLoopValue As Boolean = False

        'Moving Inputs Into there respective variables and checking to make sure a numeric input.

        'Input1'
        blnIsConverted = Double.TryParse(txtInput1.Text, dblInput1)
        If blnIsConverted = False Then
            MsgBox("Initial Balance must be numeric and greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Input2'
        blnIsConverted = Double.TryParse(txtInput2.Text, dblInput2)
        If blnIsConverted = False Then
            MsgBox("Retirement Goal must be numeric and greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Input3'
        blnIsConverted = Double.TryParse(txtInput3.Text, dblInput3)
        If blnIsConverted = False Then
            MsgBox("Annual Interest must be numeric, greater than 0, and less than .5", MsgBoxStyle.OkOnly, "Input Error")
            txtInput3.Clear()
            txtInput3.Focus()
            Exit Sub
        End If

        'Checking Inputs to make sure they are greater than 0'

        'Input1'
        If dblInput1 <= 0 Then
            MsgBox("Initial Balance must be greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Input2'
        If dblInput2 <= 0 Then
            MsgBox("Retirement Goal must be greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Input3'
        If dblInput3 <= 0 Or dblInput3 > 0.5 Then
            MsgBox("Annual Interest must be greater than 0 and less than .5", MsgBoxStyle.OkOnly, "Input Error")
            txtInput3.Clear()
            txtInput3.Focus()
            Exit Sub
        End If

        'Checking that Input 1 !> Input 2'
        If dblInput1 > dblInput2 Then
            MsgBox("Retirement Goal must be greater than Initial Value", MsgBoxStyle.OkOnly, "Input Error")
            txtInput1.Clear()
            txtInput2.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Calculations' 
        dblOutput = dblInput1
        Do While dblOutput < dblInput2
            dblOutput += (dblOutput * dblInput3)
            intYears += 1
        Loop
        lblOutput.Text = "You will have $" + dblOutput.ToString("n") + " in " + intYears.ToString + " years."


    End Sub
End Class
