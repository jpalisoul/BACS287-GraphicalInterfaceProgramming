Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtInput1.Clear()
        txtInput2.Clear()
        lblCirOutput.Text = ""
        lblPriceOutput.Text = ""
        txtInput1.Focus()

    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click

        'Implementation of Variables'
        Dim dblInput1 As Double = 0
        Dim dblInput2 As Double = 0
        Dim dblCirOutput As Double = 0
        Dim dblPriceOutput As Double = 0
        Dim blnIsConverted As Boolean = False
        Const dblPi As Double = Math.PI


        'Moving txtInput1 into dblInput1 and checking for invalid characters'
        blnIsConverted = Double.TryParse(txtInput1.Text, dblInput1)
        If blnIsConverted = False Then
            MsgBox("Error--Input Must be Numeric for Diameter", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Moving txtInput2 into dblInput2 and checking for invalid characters'
        blnIsConverted = Double.TryParse(txtInput2.Text, dblInput2)
        If blnIsConverted = False Then
            MsgBox("Error--Input must be Numeric for Price per foot", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Check to make sure dblInput1 is greater than 0'
        If dblInput1 <= 0 Then
            MsgBox("Error--Input must be greater than 0 for Diameter", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Check to make sure dblInput2 is greater than 0'
        If dblInput2 <= 0 Then
            MsgBox("Error--Input must be greater than 0 for Price per foot", MsgBoxStyle.OkOnly, "Invalid Input")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Circumference Calculation'
        dblCirOutput = dblInput1 * dblPi
        lblCirOutput.Text = dblCirOutput.ToString("n3")

        'Cost Calculation'
        dblPriceOutput = dblCirOutput * dblInput2
        lblPriceOutput.Text = "$" + dblPriceOutput.ToString("n")

    End Sub
End Class
