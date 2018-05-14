Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click

        txtInput1.Clear()
        txtInput2.Clear()
        txtInput3.Clear()
        txtInput4.Clear()
        lblHours.Text = ""
        lblGallons.Text = ""
        lblPaintCost.Text = ""
        lblLaborCost.Text = ""
        lblTotalCost.Text = ""
        txtInput1.Focus()

    End Sub

    Private Sub btncalc_Click(sender As Object, e As EventArgs) Handles btncalc.Click

        'Implementation of Variables'
        Dim dblInput1 As Double = 0
        Dim dblInput2 As Double = 0
        Dim dblInput3 As Double = 0
        Dim dblInput4 As Double = 0
        Dim dblHoursOutput As Double = 0
        Dim dblGallonsOutput As Double = 0
        Dim dblPaintCostOutput As Double = 0
        Dim dblLaborCostOutput As Double = 0
        Dim dblTotalCostOutput As Double = 0
        Dim blnIsConverted As Boolean = False
        Const dblPaintCoverage As Double = 400
        Const dblGallonTime As Double = 4


        'Moving Inputs Into there respective variables and checking to make sure a numeric input.

        'Input1'
        blnIsConverted = Double.TryParse(txtInput1.Text, dblInput1)
        If blnIsConverted = False Then
            MsgBox("Length input must be numeric and greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Input2'
        blnIsConverted = Double.TryParse(txtInput2.Text, dblInput2)
        If blnIsConverted = False Then
            MsgBox("Height input must be numeric and greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Input3'
        blnIsConverted = Double.TryParse(txtInput3.Text, dblInput3)
        If blnIsConverted = False Then
            MsgBox("Cost input must be numeric and greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput3.Clear()
            txtInput3.Focus()
            Exit Sub
        End If

        'Input4'
        blnIsConverted = Double.TryParse(txtInput4.Text, dblInput4)
        If blnIsConverted = False Then
            MsgBox("Wage input must be numeric and greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput4.Clear()
            txtInput4.Focus()
            Exit Sub
        End If

        'Checking Inputs to make sure they are greater than 0'

        'Input1'
        If dblInput1 <= 0 Then
            MsgBox("Length input must be greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput1.Clear()
            txtInput1.Focus()
            Exit Sub
        End If

        'Input2'
        If dblInput2 <= 0 Then
            MsgBox("Height input must be greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput2.Clear()
            txtInput2.Focus()
            Exit Sub
        End If

        'Input3'
        If dblInput3 <= 0 Then
            MsgBox("Cost input must be greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput3.Clear()
            txtInput3.Focus()
            Exit Sub
        End If

        'Input4'
        If dblInput4 <= 0 Then
            MsgBox("Wage input must be greater than 0", MsgBoxStyle.OkOnly, "Input Error")
            txtInput4.Clear()
            txtInput4.Focus()
            Exit Sub
        End If

        'Hours of Labor Calculation'
        dblHoursOutput = (dblInput1 * dblInput2) / (dblPaintCoverage / dblGallonTime)
        lblHours.Text = dblHoursOutput.ToString("n1")

        'Gallons of Paint Calculation' 
        dblGallonsOutput = (dblInput1 * dblInput2) / dblPaintCoverage
        lblGallons.Text = dblGallonsOutput.ToString("n")

        'Paint Cost Calculation'
        dblPaintCostOutput = (dblGallonsOutput * dblInput3)
        lblPaintCost.Text = "$" + dblPaintCostOutput.ToString("n")

        'Labor Cost Calculation'
        dblLaborCostOutput = (dblHoursOutput * dblInput4)
        lblLaborCost.Text = "$" + dblLaborCostOutput.ToString("n")

        'Total Cost Calculation'
        dblTotalCostOutput = (dblPaintCostOutput + dblLaborCostOutput)
        lblTotalCost.Text = "$" + dblTotalCostOutput.ToString("n")

    End Sub
End Class
