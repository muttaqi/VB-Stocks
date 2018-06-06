'Muttaqi Islam
'13/06/2017
'Make a stock simulator game, in which players must invest in stocks to save up for their retirement

Imports System.IO

Public Class frmOpen

    Dim users, passwords As New List(Of String)
    Dim alreadyUsed, match As Boolean

    'check if a list is unique
    Public Function Unique(ByVal l As List(Of String)) As Boolean
        For i = 0 To l.Count - 1
            For j = 0 To l.Count - 1
                If j <> i Then
                    If l.Item(j) = l.Item(i) Then
                        Return False

                    End If

                End If

            Next

        Next

        Return True

    End Function

    'generate game data(executed if it is the first time)
    Public Sub generateSub()
        Randomize()

        Dim rndVal As Integer
        Dim count As Integer
        Dim read, readShort As String
        Dim word1 As New StreamReader("1stWord.txt")
        Dim word2 As New StreamReader("2ndWord.txt")
        Dim word3 As New StreamReader("3rdWord.txt")

        'GENERATE STOCK NAMES

        'do until all stock names are unique
        Do
            'start from scratch if it has to loop again
            GlobalVariables.stocks.Clear()
            GlobalVariables.stocksShort.Clear()

            'do for 10 stocks
            For i = 0 To 9
                'random number
                rndVal = Int((17 * Rnd()) + 1)

                count = 0

                'go to that random line in the text
                Do Until count = rndVal - 1
                    word1.ReadLine()
                    word1.ReadLine()
                    count += 1
                Loop

                'add it to the name as well as its short name
                read = word1.ReadLine
                readShort = word1.ReadLine

                'data stored in a list
                GlobalVariables.stocks.Add(read & " ")
                GlobalVariables.stocksShort.Add(readShort)

                'do the same for second word and third word
                rndVal = Int((9 * Rnd()) + 1)

                count = 0

                Do Until count = rndVal - 1
                    word2.ReadLine()
                    word2.ReadLine()
                    count += 1
                Loop

                read = word2.ReadLine
                readShort = word2.ReadLine

                GlobalVariables.stocks.Item(i) += (read & " ")
                GlobalVariables.stocksShort.Item(i) += (readShort)

                rndVal = Int((5 * Rnd()) + 1)

                count = 0

                Do Until count = rndVal - 1
                    word3.ReadLine()
                    word3.ReadLine()
                    count += 1
                Loop

                read = word3.ReadLine
                readShort = word3.ReadLine

                GlobalVariables.stocks.Item(i) += (read)
                GlobalVariables.stocksShort.Item(i) += (readShort)

                'reset lines for each file and do the same thing for next stock
                word1.DiscardBufferedData()
                word1.BaseStream.Seek(0, IO.SeekOrigin.Begin)

                word2.DiscardBufferedData()
                word2.BaseStream.Seek(0, IO.SeekOrigin.Begin)

                word3.DiscardBufferedData()
                word3.BaseStream.Seek(0, IO.SeekOrigin.Begin)

            Next

        Loop Until Unique(GlobalVariables.stocks) = True

        Randomize()

        'set default values for stock value and quantity of stocks in posession
        For i = 0 To 9
            GlobalVariables.boughtStocks.Add(0)
            GlobalVariables.stockValue(i).Add(Int((10 * Rnd()) + 1))

        Next

        'close streamreaders
        word1.Close()
        word2.Close()
        word3.Close()

        'set default cash and month
        GlobalVariables.month = 0
        GlobalVariables.cash = 1000
        GlobalVariables.retirementDep = 0

        'set the user in use(the user who is playing) to the text
        GlobalVariables.userInUse = txtUser.Text

    End Sub

    'used to generate high score table
    Public Sub highScores()
        Dim currentRetirementArray(users.Count) As Integer
        Dim fileBoolList(users.Count) As Boolean
        Dim out As String

        'headers
        out = "USER" & vbTab & "RETIREMENT DEPOSIT" & vbCrLf

        'for each user, if they have a save file store their retirement deposit in an array
        For i = 0 To users.Count - 1

            If My.Computer.FileSystem.FileExists(users(i) & ".txt") Then
                Dim inFile As New StreamReader(users(i) & ".txt")

                inFile.ReadLine()
                inFile.ReadLine()
                inFile.ReadLine()

                currentRetirementArray(i) = Encrypt(inFile.ReadLine())

                inFile.Close()
            End If

        Next

        'sort the array
        Array.Sort(currentRetirementArray)

        'highest to lowest
        Array.Reverse(currentRetirementArray)

        'for each value in the array,
        For i = 0 To users.Count - 1
            'check each user
            For j = 0 To users.Count - 1
                'if their save file exists,
                If File.Exists(users(j) & ".txt") Then
                    Dim inFile As New StreamReader(users(j) & ".txt")

                    inFile.ReadLine()
                    inFile.ReadLine()
                    inFile.ReadLine()

                    'and if the values match AND it hasn't been used previously, then place user information with its retirement deposit to the phrase
                    If currentRetirementArray(i) = Encrypt(inFile.ReadLine()) And Not fileBoolList(j) Then
                        out += users(j) & vbTab & currentRetirementArray(i) & vbCrLf

                        'ensure the username isn't used again
                        fileBoolList(j) = True

                    End If

                    inFile.Close()
                End If

            Next

        Next

        'display
        txtHighScores.Text = out

    End Sub

    'encryption and decryption function
    Public Function Encrypt(ByVal str As String) As String
        Dim out As String = ""

        'flip character ascii and output it
        For Each c As Char In str
            out += Chr(255 - Asc(c))

        Next

        Return out

    End Function

    'dynamic textboxes for aesthetic
    Private Sub txtUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Click
        txtUser.Text = ""
    End Sub

    Private Sub txtPass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Click
        txtPass.Text = ""
    End Sub

    Private Sub txtRegUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegUser.Click
        txtRegUser.Text = ""
    End Sub

    Private Sub txtRegPass_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegPass.Click
        txtRegPass.Text = ""
    End Sub

    Private Sub txtUser_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUser.Leave
        If txtUser.Text = "" Then
            txtUser.Text = "Username"

        End If
    End Sub

    Private Sub txtPass_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtPass.Leave
        If txtPass.Text = "" Then
            txtPass.Text = "Password"

        End If
    End Sub

    Private Sub txtRegUser_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegUser.Leave
        If txtRegUser.Text = "" Then
            txtRegUser.Text = "Username"

        End If
    End Sub

    Private Sub txtRegPass_leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtRegPass.Leave
        If txtRegPass.Text = "" Then
            txtRegPass.Text = "Password"

        End If
    End Sub

    'log on button
    Private Sub btnLog_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLog.Click
        'for each user
        For i = 0 To users.Count - 1

            'check if it is a match
            If users.Item(i) = txtUser.Text And passwords.Item(i) = txtPass.Text Then

                'is it is tell them
                MsgBox("Successful Log On!")

                GlobalVariables.userInUse = users.Item(i)

                'if the user save file exists then read in all data from save file to corresponding lists
                If (File.Exists(GlobalVariables.userInUse & ".txt")) Then
                    Dim inFile As New StreamReader(users.Item(i) & ".txt")

                    'general info
                    GlobalVariables.userInUse = Encrypt(inFile.ReadLine)
                    GlobalVariables.month = Int(Encrypt(inFile.ReadLine))
                    GlobalVariables.cash = Int(Encrypt(inFile.ReadLine))
                    GlobalVariables.retirementDep = Int(Encrypt(inFile.ReadLine))

                    'each stock
                    For j = 0 To 9
                        GlobalVariables.stocks.Add(Encrypt(inFile.ReadLine))
                        GlobalVariables.stocksShort.Add(Encrypt(inFile.ReadLine))
                        GlobalVariables.boughtStocks.Add(Int(Encrypt(inFile.ReadLine)))

                        'each value per month (needed for graphs)
                        For k = 0 To GlobalVariables.month
                            GlobalVariables.stockValue(j).Add(Int(Encrypt(inFile.ReadLine)))

                        Next

                    Next

                    For j = 0 To GlobalVariables.loanVals.Count - 1
                        GlobalVariables.loanVals(i) = Encrypt(inFile.ReadLine)
                        GlobalVariables.interestVals(i) = Encrypt(inFile.ReadLine)
                        GlobalVariables.payBackVals(i) = Encrypt(inFile.ReadLine)

                    Next

                    'otherwise generate data
                Else
                    generateSub()

                End If

                'hide current form and show next one
                frmStocks.Show()

                Dim outFile As New System.IO.StreamWriter("LoginInfo.txt")

                'writes out login data from lists
                For k = 0 To users.Count - 1
                    outFile.WriteLine(Encrypt(users.Item(k)))
                    outFile.WriteLine(Encrypt(passwords.Item(k)))

                Next

                outFile.Close()

                Me.Hide()

                Exit For
            End If

        Next

        'if no match tell the user through label
        lblInvalid.ForeColor = Color.Red
        lblInvalid.Text = "Invalid username and password combination"

    End Sub

    Private Sub btnReg_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReg.Click
        'check if username is already used
        For i = 0 To users.Count - 1
            If users.Item(i) = txtRegUser.Text Then
                alreadyUsed = True

            End If
        Next

        'if it is then tell them
        If alreadyUsed Then
            lblRegInvalid.ForeColor = Color.Red
            lblRegInvalid.Text = "That username is already used"

            'otherwise add information to corresponding list
        ElseIf Not txtRegUser.Text = "Username" Or Not txtRegPass.Text = "Password" Then
            users.Add(txtRegUser.Text)
            passwords.Add(txtRegPass.Text)

            MsgBox("Successfully Registered!")

        End If

        alreadyUsed = False

    End Sub

    Private Sub frmOpen_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim inFile As New System.IO.StreamReader("LoginInfo.txt")

        'setup multi-dimensional list
        For i = 0 To 9
            GlobalVariables.stockValue.Add(New List(Of Single))
        Next

        'read in login data and put into corresponding list
        Do Until inFile.EndOfStream
            users.Add(Encrypt(inFile.ReadLine()))
            passwords.Add(Encrypt(inFile.ReadLine()))

        Loop

        inFile.Close()

        highScores()
    End Sub

    Private Sub frmOpen_FormClosed(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.FormClosed
        Dim outFile As New System.IO.StreamWriter("LoginInfo.txt")

        'writes out login data from lists
        For i = 0 To users.Count - 1
            outFile.WriteLine(Encrypt(users.Item(i)))
            outFile.WriteLine(Encrypt(passwords.Item(i)))

        Next

        outFile.Close()
    End Sub
End Class

'global variables
Public Class GlobalVariables
    Public Shared month, portValue, retirementDep As Integer
    Public Shared stocks, stocksShort, loanNames As New List(Of String)
    Public Shared boughtStocks, loanVals As New List(Of Integer)
    Public Shared stockValue As New List(Of List(Of Single))
    Public Shared interestVals, payBackVals As New List(Of Single)
    Public Shared userInUse As String
    Public Shared cash As Single
End Class