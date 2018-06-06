Imports VB_Stocks.GlobalVariables

Public Class frmStockDirectory

    Private Sub frmStockDirectory_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Forms.frmStocks.btnStocks.Enabled = True

    End Sub

    Private Sub frmStockDirectory_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim out As String

        'load directory and information
        out = "Stock" & vbTab & vbTab & vbTab & vbTab & "Abbreviation" & vbTab & "Number Owned" & vbTab & "Value Per Stock" & vbTab & "Total Value" & vbCrLf

        For i = 0 To 9
            out += stocks(i) & vbTab & stocksShort(i) & vbTab & vbTab & boughtStocks(i) & vbTab & vbTab & FormatCurrency(stockValue(i)(month)) & vbTab & vbTab & FormatCurrency(stockValue(i)(month) * boughtStocks(i)) & vbCrLf

        Next

        txtStockDirectory.Text = out
    End Sub

    Private Sub txtStockDirectory_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtStockDirectory.TextChanged

    End Sub
End Class