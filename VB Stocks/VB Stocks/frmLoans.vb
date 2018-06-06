Imports VB_Stocks.GlobalVariables

Public Class frmLoans
    Dim loanVal1, loanVal2, loanVal3 As Integer
    Dim interestVal1, interestVal2, interestVal3 As Single
    Dim payment1, payment2, payment3 As Integer

    're-enable button
    Private Sub frmLoans_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Forms.frmStocks.btnLoan.Enabled = True

    End Sub

    Private Sub frmLoans_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Randomize()

        'SET UP LOAN INFO

        'names
        lblLoanName1.Text = "LOAN 1"
        lblLoanName2.Text = "LOAN 2"
        lblLoanName3.Text = "LOAN 3"

        'values
        loanVal1 = (150 * Rnd()) + 50
        loanVal2 = (150 * Rnd()) + 50
        loanVal3 = (150 * Rnd()) + 50

        'interests
        interestVal1 = (0.009 * Rnd()) + 0.001
        interestVal2 = (0.009 * Rnd()) + 0.001
        interestVal3 = (0.009 * Rnd()) + 0.001

        'per month payments
        payment1 = (19 * Rnd()) + 1
        payment2 = (19 * Rnd()) + 1
        payment3 = (19 * Rnd()) + 1

        'display the information
        lblLoanVal1.Text = "Value: " & FormatCurrency(loanVal1)
        lblInterest1.Text = "Interest Per Month: " & FormatPercent(interestVal1)
        lblPayment1.Text = "Initial Payment Due Per Month" & FormatCurrency(Int(payment1))

        lblLoanVal2.Text = "Value: " & FormatCurrency(loanVal2)
        lblInterest2.Text = "Interest Per Month: " & FormatPercent(interestVal2)
        lblPayment2.Text = "Initial Payment Due Per Month" & FormatCurrency(Int(payment2))

        lblLoanVal3.Text = "Value: " & FormatCurrency(loanVal3)
        lblInterest3.Text = "Interest Per Month: " & FormatPercent(interestVal3)
        lblPayment3.Text = "Initial Payment Due Per Month" & FormatCurrency(Int(payment3))

        Dim out As String

        'DISPLAY CURRENT LOANS

        'headers
        out = "Loan Value" & vbTab & vbTab & vbTab & "Interest Value" & vbTab & "Current Payment Per Month" & vbCrLf

        'for each loan, add info to a phrase
        For i = 0 To loanVals.Count - 1
            out += FormatCurrency(loanVals(i)) & vbTab & interestVals(i) & vbTab & FormatCurrency(payBackVals(i)) & vbCrLf

        Next

        'display phrase
        txtLoans.Text = out

    End Sub

    Private Sub btnLoan1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan1.Click
        'add corresponding info to lists
        loanVals.Add(loanVal1)
        interestVals.Add(interestVal1)
        payBackVals.Add(payment1)

        'disable button
        btnLoan1.Enabled = False

        're-update loan information
        Dim out As String

        out = "Loan Value" & vbTab & "Interest Value" & vbTab & "Current Payment Per Month" & vbCrLf

        For i = 0 To loanVals.Count - 1
            out += FormatCurrency(loanVals(i)) & vbTab & interestVals(i) & vbTab & FormatCurrency(payBackVals(i)) & vbCrLf

        Next

        txtLoans.Text = out

    End Sub

    'same
    Private Sub btnLoan2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan2.Click
        loanVals.Add(loanVal2)
        interestVals.Add(interestVal2)
        payBackVals.Add(payment2)

        btnLoan2.Enabled = False

        're-update loan information
        Dim out As String

        out = "Loan Value" & vbTab & "Interest Value" & vbTab & "Current Payment Per Month" & vbCrLf

        For i = 0 To loanVals.Count - 1
            out += FormatCurrency(loanVals(i)) & vbTab & interestVals(i) & vbTab & FormatCurrency(payBackVals(i)) & vbCrLf

        Next

        txtLoans.Text = out

    End Sub

    Private Sub btnLoan3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan3.Click
        loanVals.Add(loanVal3)
        interestVals.Add(interestVal3)
        payBackVals.Add(payment3)

        btnLoan3.Enabled = False

        're-update loan information
        Dim out As String

        out = "Loan Value" & vbTab & "Interest Value" & vbTab & "Current Payment Per Month" & vbCrLf

        For i = 0 To loanVals.Count - 1
            out += FormatCurrency(loanVals(i)) & vbTab & interestVals(i) & vbTab & FormatCurrency(payBackVals(i)) & vbCrLf

        Next

        txtLoans.Text = out

    End Sub
End Class