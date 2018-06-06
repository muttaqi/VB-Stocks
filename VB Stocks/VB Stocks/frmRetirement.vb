Imports VB_Stocks.GlobalVariables
Public Class frmRetirement

    Private Sub frmRetirement_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Forms.frmStocks.btnRetirement.Enabled = True

    End Sub

    Private Sub frmRetirement_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'set label text
        lblAccount.Text = "Current Account: " & retirementDep & "/$100,000"

        'Display progress bar amount
        pbrAccount.Minimum = 0
        pbrAccount.Maximum = 100000

        pbrAccount.Value = retirementDep

    End Sub

    Private Sub btnDeposit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeposit.Click
        If IsNumeric(txtDeposit.Text) Then
            'take away money and add to account
            If cash > txtDeposit.Text Then
                cash -= txtDeposit.Text
                retirementDep += txtDeposit.Text

                My.Forms.frmStocks.lblCash.Text = "Cash: " & FormatCurrency(cash)
            Else
                MsgBox("You don't have enough money!")

            End If
        Else
            MsgBox("That's not a number!")

        End If

        'set label text
        lblAccount.Text = "Current Account: " & FormatCurrency(retirementDep) & "/$100,000"

        'Display progress bar amount
        pbrAccount.Minimum = 0
        pbrAccount.Maximum = 100000

        pbrAccount.Value = retirementDep

        If retirementDep >= 100000 Then
            MsgBox("Congratulations! You have successfully saved up for retirement! Feel free to keep playing though ;)")


        End If
    End Sub
End Class