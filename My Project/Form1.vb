Public Class FrmVehicleLoanCalculator
    Private Sub FrmVehicleLoanCalculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Const dblMonthsOfTheYear As Double = 12
        Const dblNewVehicle As Double = 0.05
        Const dblUsedVehicle As Double = 0.08
        Dim dblAnnualRAte As Double = dblNewVehicle

    End Sub

    Private Sub btnCalculator_Click(sender As Object, e As EventArgs) Handles btnCalculator.Click
        Const dblMonthsOfTheYear As Double = 12
        Const dblNewVehicle As Double = 0.05
        Const dblUsedVehicle As Double = 0.08
        Dim dblAnnualRAte As Double = dblNewVehicle

        ' Private Sub btnCalc_Click(sender As Object, e As EventArgs)
        ' ... (Variable declarations)
        Dim dblVehicleCost As Double
        Dim dblDownPayment As Double
        Dim intMonth As Integer
        Dim dblLoan As Double
        Dim dblMonthlyPayment As Double
        Dim dblInterest As Double
        Dim dblPrincipal As Double
        Dim intCount As Integer
        Dim strOut As String
        Dim blnInputOk = True

        'NOT ENTERING THE SPACE TEXT INPUT PROVIDED....MESSAGE
        If Not Double.TryParse(txtCostofVehicle.Text, dblVehicleCost) Then
            lblAnnualRate.Text = "*** Vehicle Cost Must Be A Numeric Value ***"
            blnInputOk = False
        End If
        If Not Double.TryParse(txtAmountofDownPayment.Text, dblDownPayment) Then
            lblAnnualRate.Text = "Invalid"
            blnInputOk = False
        End If
        If Not Integer.TryParse(txtNumberofMonths.Text, intCount) Then
            lblAnnualRate.Text = "Error... Enter Valid Integer"
        End If

        If blnInputOk = True Then
            '(Calculations for loan, monthly payment, and loop for each month)
            dblLoan = dblVehicleCost - dblDownPayment
            dblMonthlyPayment = Pmt(dblAnnualRAte / dblMonthsOfTheYear, intCount, -dblLoan)
            lstout.Items.Clear()
            lblAnnualRate.Text = String.Empty

            For calc As Integer = 1 To intCount
                dblInterest = IPmt(dblAnnualRAte / dblMonthsOfTheYear, calc, intCount, -dblLoan)
                dblPrincipal = PPmt(dblAnnualRAte / dblMonthsOfTheYear, calc, intCount, -dblLoan)


                strOut = "Month " & calc.ToString("d2")
                strOut &= ": Payment = " & dblMonthlyPayment.ToString("n2")
                strOut &= ": Interest = " & dblInterest.ToString("n2")
                strOut &= ": Principal = " & dblPrincipal.ToString("n2")
                lstout.Items.Add(strOut)
            Next
        End If

    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        rdoNew.Checked = False
        rdoUsed.Checked = False
        lblAnnualRate.ResetText()
        txtCostofvehicle.Clear()
        txtAmountofDownPayment.Clear()
        txtNumberofMonths.Clear()
        lstout.Items.Clear()
        lblAnnualRate.ResetText()
        txtCostofvehicle.Focus()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Dim result As DialogResult
        result = MessageBox.Show("Do you wish to Exit...", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub btnPrevious_Click(sender As Object, e As EventArgs) Handles btnPrevious.Click

        Me.Hide()
        frmHome.Show()

    End Sub
End Class