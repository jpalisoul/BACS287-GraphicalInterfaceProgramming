Module Finance_Calc
    Public Function my_FV(ByVal dblRate As Double, ByVal dblPeriods As Double, ByVal dblPayment As Double, ByVal dblPresentValue As Double) As Decimal
        Dim dblFutureValue As Double = 0
        dblFutureValue = FV(dblRate, dblPeriods, dblPayment, dblPresentValue)
        Return Convert.ToDecimal(dblFutureValue)
    End Function
End Module
