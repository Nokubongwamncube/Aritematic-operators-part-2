Public Class Form1
    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim dprice As Decimal
        Dim dquantity As Decimal
        Dim dDiscount As Decimal
        Dim dVAT As Decimal

        Dim dTotalcostVAT As Decimal
        Dim DTotalcostexVAT As Decimal

        dprice = 10
        dquantity = 10
        dDiscount = 2
        dVAT = 0.15


        DTotalcostexVAT = dquantity * (dprice - dDiscount)
        MsgBox("total cost exclusive VAT" & DTotalcostexVAT)

        dTotalcostVAT = DTotalcostexVAT * dVAT + DTotalcostexVAT


        MsgBox("total cost inclusive VAT" & dTotalcostVAT)



    End Sub
End Class
