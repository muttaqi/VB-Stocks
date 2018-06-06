Imports VB_Stocks.GlobalVariables
Imports System.IO

Public Class frmStocks
    Dim week
    Dim stock1 As Integer = -1
    Dim stock2 As Integer = -1
    Dim stock3 As Integer = -1
    Dim stockSearch As Integer

    'loads menu
    Private Sub loadMenu()
        Dim portWOCash As Single = 0
        Dim currentValueArray(10) As Single

        'add the value of each stock in user possession
        For i = 0 To 9
            portWOCash += stockValue.Item(i)(month) * boughtStocks.Item(i)

        Next

        'add stock values to liquid cash
        portValue = cash + portWOCash

        'display data
        lblCash.Text = "Cash: " & FormatCurrency(cash)
        lblPort.Text = "Portfolio Value: " & FormatCurrency(portValue)
        lblMonth.Text = "Month: " & month
        lblUser.Text = "Current User: " & userInUse
        lblRetirement.Text = "Retirement Account: " & retirementDep & "/$100,000"

        'sum of expenses(determines how much money is lost this month)
        Dim sum As Integer = 0

        'find sum
        For i = 0 To loanVals.Count - 1
            sum += Int(payBackVals(i))

        Next

        lblExpenses.Text = "Expenses Per Month: " & FormatCurrency(sum)

        'store current stocks in array
        For i = 0 To 9
            currentValueArray(i) = stockValue(i)(month)

        Next

        'DETERMINE MOST VALUABLE STOCKS
        Array.Sort(currentValueArray)

        stock1 = -1
        stock2 = -1
        stock3 = -1

        For i = 0 To 9
            If stockValue(i)(month) = currentValueArray(9) And stock1 = -1 Then
                stock1 = i

            ElseIf stockValue(i)(month) = currentValueArray(8) And stock2 = -1 Then
                stock2 = i

            ElseIf stockValue(i)(month) = currentValueArray(7) And stock3 = -1 Then
                stock3 = i

            End If

        Next

        'clear charts
        chrtStock1.Series.Clear()
        chrtStock2.Series.Clear()
        chrtStock3.Series.Clear()

        'set up properties
        chrtStock1.Series.Add("Series1")
        chrtStock2.Series.Add("Series1")
        chrtStock3.Series.Add("Series1")

        chrtStock1.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chrtStock2.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line
        chrtStock3.Series("Series1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        chrtStock1.ChartAreas(0).BackColor = Color.Black
        chrtStock2.ChartAreas(0).BackColor = Color.Black
        chrtStock3.ChartAreas(0).BackColor = Color.Black

        chrtStock1.Series("Series1").Color = Color.Lime
        chrtStock2.Series("Series1").Color = Color.Lime
        chrtStock3.Series("Series1").Color = Color.Lime

        chrtStock1.Series("Series1").BorderWidth = 3
        chrtStock2.Series("Series1").BorderWidth = 3
        chrtStock3.Series("Series1").BorderWidth = 3

        chrtStock1.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Lime
        chrtStock2.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Lime
        chrtStock3.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Lime

        chrtStock1.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Lime
        chrtStock2.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Lime
        chrtStock3.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Lime

        chrtStock1.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.DarkGray
        chrtStock2.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.DarkGray
        chrtStock3.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.DarkGray

        chrtStock1.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.DarkGray
        chrtStock2.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.DarkGray
        chrtStock3.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.DarkGray

        'display stock data
        chrtStock1.Series("Series1").LegendText = stocksShort.Item(stock1)
        chrtStock2.Series("Series1").LegendText = stocksShort.Item(stock2)
        chrtStock3.Series("Series1").LegendText = stocksShort.Item(stock3)

        For i = 0 To month
            chrtStock1.Series("Series1").Points.AddXY(i, stockValue(stock1)(i))
            chrtStock2.Series("Series1").Points.AddXY(i, stockValue(stock2)(i))
            chrtStock3.Series("Series1").Points.AddXY(i, stockValue(stock3)(i))
        Next

        'hiding sell button if user doesn't own any of the stock
        If boughtStocks(stock1) > 0 Then
            btnSell1.Enabled = True

        Else
            btnSell1.Enabled = False

        End If

        If boughtStocks(stock2) > 0 Then
            btnSell2.Enabled = True

        Else
            btnSell2.Enabled = False

        End If

        If boughtStocks(stock3) > 0 Then
            btnSell3.Enabled = True

        Else
            btnSell3.Enabled = False

        End If


        If boughtStocks(stockSearch) > 0 Then
            btnSellS.Enabled = True

        Else
            btnSellS.Enabled = False

        End If

        'display number of stocks held by user
        lblStock1.Text = "Owned: " & boughtStocks.Item(stock1)
        lblStock2.Text = "Owned: " & boughtStocks.Item(stock2)
        lblStock3.Text = "Owned: " & boughtStocks.Item(stock3)

        lblVal1.Text = "Value: " & FormatCurrency(stockValue.Item(stock1)(month))
        lblVal2.Text = "Value: " & FormatCurrency(stockValue.Item(stock2)(month))
        lblVal3.Text = "Value: " & FormatCurrency(stockValue.Item(stock3)(month))

        'DISPLAY STOCKS OWNED
        Dim out As String

        out = "Owned: " & vbCrLf & vbCrLf & "Stock" & vbTab & vbTab & vbTab & vbTab & "Short-Hand Name" & vbTab & "Number Owned" & vbTab & "Value Per Stock" & vbTab & "Total Value" & vbCrLf

        For i = 0 To 9
            If boughtStocks(i) > 0 Then
                out += stocks(i) & vbTab & stocksShort(i) & vbTab & vbTab & boughtStocks(i) & vbTab & vbTab & FormatCurrency(stockValue(i)(month)) & vbTab & vbTab & FormatCurrency(stockValue(i)(month) * boughtStocks(i)) & vbCrLf

            End If

        Next

        txtStocksOwned.Text = out
    End Sub

    Private Sub frmStocks_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        My.Forms.frmOpen.Close()

    End Sub

    Private Sub frmMainMenu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'clear charts
        chrtStockS.Series.Clear()

        'set up properties
        chrtStockS.Series.Add("srs1")

        chrtStockS.Series("srs1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        chrtStockS.ChartAreas(0).BackColor = Color.Black

        chrtStockS.Series("srs1").Color = Color.Lime

        chrtStockS.Series("srs1").BorderWidth = 3

        chrtStockS.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Lime

        chrtStockS.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Lime

        chrtStockS.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.DarkGray

        chrtStockS.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.DarkGray

        'display stock data
        chrtStockS.Series("srs1").LegendText = stocksShort.Item(stockSearch)

        loadMenu()

    End Sub

    'handle buying and selling stocks (add or subtract money and number of stocks bought), can't buy if not enough money
    Private Sub btnBuy1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy1.Click
        If cash > stockValue(stock1)(month) Then
            boughtStocks(stock1) += 1
            cash -= stockValue(stock1)(month)

        Else
            MsgBox("You Don't have enough money!")

        End If

        loadMenu()

    End Sub

    Private Sub btnSell1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSell1.Click
        boughtStocks(stock1) -= 1
        cash += stockValue(stock1)(month)

        loadMenu()

    End Sub

    Private Sub btnBuy2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy2.Click
        If cash > stockValue(stock2)(month) Then
            boughtStocks(stock2) += 1
            cash -= stockValue(stock2)(month)

        Else
            MsgBox("You Don't have enough money!")

        End If

        loadMenu()

    End Sub

    Private Sub btnSell2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSell2.Click
        boughtStocks(stock2) -= 1
        cash += stockValue(stock2)(month)

        loadMenu()

    End Sub

    Private Sub btnBuy3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuy3.Click
        If cash > stockValue(stock3)(month) Then
            boughtStocks(stock3) += 1
            cash -= stockValue(stock3)(month)

        Else
            MsgBox("You Don't have enough money!")

        End If

        loadMenu()

    End Sub

    Private Sub btnSell3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSell3.Click
        boughtStocks(stock3) -= 1
        cash += stockValue(stock3)(month)

        loadMenu()

    End Sub

    Private Sub btnBuyS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBuyS.Click
        If cash > stockValue(stockSearch)(month) Then
            boughtStocks(stockSearch) += 1
            cash -= stockValue(stockSearch)(month)

        Else
            MsgBox("You Don't have enough money!")

        End If

        loadMenu()

    End Sub

    Private Sub btnSellS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSellS.Click
        boughtStocks(stockSearch) -= 1
        cash += stockValue(stockSearch)(month)

        loadMenu()

    End Sub

    'every month, stocks change
    Private Sub stockChange()
        Dim change As Single
        Randomize()

        'randomly generate change for each stock and multiply it to stock values from last month
        For i = 0 To 9
            change = (Rnd() * 0.3) + 0.85
            stockValue(i).Add(change * stockValue(i)(month - 1))

            If stockValue(i)(month) <= 0 Then
                stockValue(i)(month) = 1

            End If

        Next

    End Sub

    Private Sub btnAdvance_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdvance.Click
        'add month
        month += 1

        'change stocks, reload menu
        stockChange()

        For i = 0 To 9
            If month > 3 Then
                If stockValue(i)(month) = stockValue(i)(month - 1) And stockValue(i)(month - 1) = stockValue(i)(month - 2) And stockValue(i)(month - 2) = stockValue(i)(month - 3) Then
                    Do Until stockValue(i)(month) <> stockValue(i)(month - 1)
                        Dim change As Single
                        Randomize()
                        MsgBox(i & " " & stockValue(i)(month - 3))

                        change = (Rnd() * 0.3) + 0.85

                        MsgBox(change)

                        stockValue(i)(month) = (change * stockValue(i)(month - 1))

                        If stockValue(i)(month) <= 0 Then
                            stockValue(i)(month) = 1

                        End If

                    Loop

                End If
            End If

        Next

        'REFRESH SEARCHED CHART

        'clear charts
        chrtStockS.Series.Clear()

        'set up properties
        chrtStockS.Series.Add("srs1")

        chrtStockS.Series("srs1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        chrtStockS.ChartAreas(0).BackColor = Color.Black

        chrtStockS.Series("srs1").Color = Color.Lime

        chrtStockS.Series("srs1").BorderWidth = 3

        chrtStockS.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Lime

        chrtStockS.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Lime

        chrtStockS.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.DarkGray

        chrtStockS.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.DarkGray

        'display stock data
        chrtStockS.Series("srs1").LegendText = stocksShort.Item(stockSearch)

        For i = 0 To month
            chrtStockS.Series("srs1").Points.AddXY(i, stockValue(stockSearch)(i))
        Next

        'hiding sell button if user doesn't own any of the stock
        If boughtStocks(stockSearch) < 0 Then
            btnSellS.Enabled = False

        End If

        'display number of stocks held by user
        lblStockS.Text = "Owned: " & boughtStocks.Item(stockSearch)

        lblValS.Text = "Value: " & FormatCurrency(stockValue.Item(stockSearch)(month))

        'sum of expenses(determines how much money is lost this month)
        Dim sum As Integer = 0

        'for each loan, apply interest and take away "payback value" from the loan
        For i = 0 To loanVals.Count - 1
            loanVals(i) *= 1 + interestVals(i)

            sum += Int(payBackVals(i))
            loanVals(i) -= Int(payBackVals(i))

        Next

        'if any loans are paid off, remove it from the list
        For i = 0 To loanVals.Count - 1
            If loanVals(i) <= 0 Then
                loanVals.Remove((loanVals(i)))

            End If

        Next

        'take away loan & expenses from cash
        GlobalVariables.cash -= sum + 5

        'display expenses
        lblExpenses.Text = "Expenses per month: " & FormatCurrency(sum)

        'if they lost all their money, they lost
        If GlobalVariables.cash <= 0 Then
            MsgBox("You went bankrupt and lost! Try again from your last save!")
            Me.Close()

            'if they ran out of time, they lost
        ElseIf month > 300 Then
            MsgBox("You got too old and now have to retire! Try again from your last save!")
            Me.Close()

            'if they are poised to lose next month, inform them
        ElseIf sum + 5 >= GlobalVariables.cash Then
            MsgBox("Be cautious, you may go in the red and lose next month if you don't make enough money!")

            'if they have little time left, inform them every 10 months
        ElseIf month > 200 And month Mod 10 = 0 Then
            MsgBox("You have " & 300 - month & "months left to win the game!")

        End If

        loadMenu()
    End Sub

    Private Sub btnS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnS.Click
        Dim found As Boolean = False
        'find the searched stock in either the stock list or shorthand stock list
        For i = 0 To 9
            If stocks(i).ToLower = txtS.Text.ToLower Or stocksShort(i).ToLower = txtS.Text.ToLower Then
                stockSearch = i
                found = True
                Exit For
            End If

        Next

        If found = False Then
            MsgBox("That wasn't found in the database, try again!")

        End If

        'clear charts
        chrtStockS.Series.Clear()

        'set up properties
        chrtStockS.Series.Add("srs1")

        chrtStockS.Series("srs1").ChartType = DataVisualization.Charting.SeriesChartType.Line

        chrtStockS.ChartAreas(0).BackColor = Color.Black

        chrtStockS.Series("srs1").Color = Color.Lime

        chrtStockS.Series("srs1").BorderWidth = 3

        chrtStockS.ChartAreas(0).AxisX.LabelStyle.ForeColor = Color.Lime

        chrtStockS.ChartAreas(0).AxisY.LabelStyle.ForeColor = Color.Lime

        chrtStockS.ChartAreas(0).AxisY.MajorGrid.LineColor = Color.DarkGray

        chrtStockS.ChartAreas(0).AxisX.MajorGrid.LineColor = Color.DarkGray

        'display stock data
        chrtStockS.Series("srs1").LegendText = stocksShort.Item(stockSearch)

        For i = 0 To month
            chrtStockS.Series("srs1").Points.AddXY(i, stockValue(stockSearch)(i))
        Next

        'hiding sell button if user doesn't own any of the stock
        If boughtStocks(stockSearch) < 0 Then
            btnSellS.Enabled = False

        End If

        'display number of stocks held by user
        lblStockS.Text = "Owned: " & boughtStocks.Item(stockSearch)

        lblValS.Text = "Value: " & stockValue.Item(stockSearch)(month)
    End Sub

    'show corresponding forms
    Private Sub btnRetirement_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRetirement.Click
        frmRetirement.Show()
        btnRetirement.Enabled = False

    End Sub

    Private Sub btnStocks_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStocks.Click
        frmStockDirectory.Show()
        btnStocks.Enabled = False

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim outFile As New StreamWriter(GlobalVariables.userInUse & ".txt")
        Dim out As String = ""

        'write out data from lists and vars to a save file

        'add to "out" phrase
        out += Encrypt(GlobalVariables.userInUse) & vbCrLf
        out += Encrypt(Str(GlobalVariables.month)) & vbCrLf
        out += Encrypt(Str(GlobalVariables.cash)) & vbCrLf
        out += Encrypt(GlobalVariables.retirementDep) & vbCrLf

        For j = 0 To 9
            out += Encrypt(GlobalVariables.stocks(j)) & vbCrLf
            out += Encrypt(GlobalVariables.stocksShort(j)) & vbCrLf
            out += Encrypt(Str(GlobalVariables.boughtStocks(j))) & vbCrLf

            For k = 0 To GlobalVariables.month
                out += Encrypt(Str(GlobalVariables.stockValue(j)(k))) & vbCrLf

            Next

        Next

        For i = 0 To GlobalVariables.loanVals.Count - 1
            out += Encrypt(GlobalVariables.loanVals(i)) & vbCrLf
            out += Encrypt(GlobalVariables.interestVals(i)) & vbCrLf
            out += Encrypt(GlobalVariables.payBackVals(i)) & vbCrLf

        Next

        'write "out"
        outFile.WriteLine(out)

        outFile.Close()
    End Sub

    'used to encrypt data so it can't be edited, asciis are flipped, can be used for decryption as well,
    Private Function Encrypt(ByVal str As String) As Object
        Dim out As String = ""

        'flip character ascii and output it
        For Each c As Char In str
            out += Chr(255 - Asc(c))

        Next

        Return out

    End Function

    Private Sub btnLoan_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLoan.Click
        frmLoans.Show()
        btnLoan.Enabled = False

    End Sub
End Class
