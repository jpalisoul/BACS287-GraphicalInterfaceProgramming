Module Functions

    Public Function payment(ByVal dblRate As Double, ByVal dblPeriods As Double, ByVal dblLoanAmount As Double) As Double
        Dim dblPayment As Double = 0
        dblPayment = Pmt(dblRate, dblPeriods, dblLoanAmount)
        Return (dblPayment)
    End Function

    Public Function pop(ByVal dblRate As Double, ByVal num_periods As Double, ByVal dblPeriods As Double, ByVal dblLoanAmount As Double) As Double
        Dim dblPrinciple As Double = 0
        dblPrinciple = PPmt(dblRate, num_periods, dblPeriods, dblLoanAmount)
        Return (dblPrinciple)
    End Function

    Public Function interest(ByVal dblRate As Double, ByVal num_periods As Double, ByVal dblPeriods As Double, ByVal dblLoanAmount As Double) As Double
        Dim dblInterest As Double = 0
        dblInterest = IPmt(dblRate, num_periods, dblPeriods, dblLoanAmount)
        Return (dblInterest)
    End Function
End Module
