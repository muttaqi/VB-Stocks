<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmStocks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea9 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend9 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series9 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea10 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend10 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series10 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea11 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend11 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series11 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea12 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend12 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series12 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.lblMonth = New System.Windows.Forms.Label()
        Me.lblCash = New System.Windows.Forms.Label()
        Me.lblPort = New System.Windows.Forms.Label()
        Me.lblRetirement = New System.Windows.Forms.Label()
        Me.chrtStock1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrtStock2 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.chrtStock3 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.lblTop = New System.Windows.Forms.Label()
        Me.btnBuy1 = New System.Windows.Forms.Button()
        Me.btnSell1 = New System.Windows.Forms.Button()
        Me.btnSell2 = New System.Windows.Forms.Button()
        Me.btnBuy2 = New System.Windows.Forms.Button()
        Me.btnSell3 = New System.Windows.Forms.Button()
        Me.btnBuy3 = New System.Windows.Forms.Button()
        Me.lblStock1 = New System.Windows.Forms.Label()
        Me.lblStock2 = New System.Windows.Forms.Label()
        Me.lblStock3 = New System.Windows.Forms.Label()
        Me.lblVal3 = New System.Windows.Forms.Label()
        Me.lblVal2 = New System.Windows.Forms.Label()
        Me.lblVal1 = New System.Windows.Forms.Label()
        Me.lblValS = New System.Windows.Forms.Label()
        Me.lblStockS = New System.Windows.Forms.Label()
        Me.btnSellS = New System.Windows.Forms.Button()
        Me.btnBuyS = New System.Windows.Forms.Button()
        Me.chrtStockS = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.txtS = New System.Windows.Forms.TextBox()
        Me.btnS = New System.Windows.Forms.Button()
        Me.txtStocksOwned = New System.Windows.Forms.TextBox()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.lblExpenses = New System.Windows.Forms.Label()
        Me.btnLoan = New System.Windows.Forms.Button()
        Me.btnStocks = New System.Windows.Forms.Button()
        Me.btnAdvance = New System.Windows.Forms.Button()
        Me.btnRetirement = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        CType(Me.chrtStock1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtStock2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtStock3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.chrtStockS, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMonth
        '
        Me.lblMonth.AutoSize = True
        Me.lblMonth.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMonth.Location = New System.Drawing.Point(213, 663)
        Me.lblMonth.Name = "lblMonth"
        Me.lblMonth.Size = New System.Drawing.Size(63, 14)
        Me.lblMonth.TabIndex = 4
        Me.lblMonth.Text = "Month: 1"
        '
        'lblCash
        '
        Me.lblCash.AutoSize = True
        Me.lblCash.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCash.Location = New System.Drawing.Point(363, 663)
        Me.lblCash.Name = "lblCash"
        Me.lblCash.Size = New System.Drawing.Size(133, 14)
        Me.lblCash.TabIndex = 5
        Me.lblCash.Text = "Liquid Cash: 10000"
        '
        'lblPort
        '
        Me.lblPort.AutoSize = True
        Me.lblPort.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPort.Location = New System.Drawing.Point(558, 663)
        Me.lblPort.Name = "lblPort"
        Me.lblPort.Size = New System.Drawing.Size(133, 14)
        Me.lblPort.TabIndex = 6
        Me.lblPort.Text = "Portfolio Value: 0"
        '
        'lblRetirement
        '
        Me.lblRetirement.AutoSize = True
        Me.lblRetirement.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRetirement.Location = New System.Drawing.Point(755, 663)
        Me.lblRetirement.Name = "lblRetirement"
        Me.lblRetirement.Size = New System.Drawing.Size(217, 14)
        Me.lblRetirement.TabIndex = 7
        Me.lblRetirement.Text = "Retirement Account: 0 / 100000"
        '
        'chrtStock1
        '
        Me.chrtStock1.BackColor = System.Drawing.Color.Black
        ChartArea9.Name = "ChartArea1"
        Me.chrtStock1.ChartAreas.Add(ChartArea9)
        Legend9.Name = "Legend1"
        Me.chrtStock1.Legends.Add(Legend9)
        Me.chrtStock1.Location = New System.Drawing.Point(20, 140)
        Me.chrtStock1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chrtStock1.Name = "chrtStock1"
        Series9.BackSecondaryColor = System.Drawing.Color.Transparent
        Series9.ChartArea = "ChartArea1"
        Series9.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series9.Color = System.Drawing.Color.Lime
        Series9.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Series9.LabelBackColor = System.Drawing.Color.Black
        Series9.LabelForeColor = System.Drawing.Color.Lime
        Series9.Legend = "Legend1"
        Series9.Name = "Series1"
        Me.chrtStock1.Series.Add(Series9)
        Me.chrtStock1.Size = New System.Drawing.Size(618, 164)
        Me.chrtStock1.TabIndex = 11
        Me.chrtStock1.Text = "Chart1"
        '
        'chrtStock2
        '
        Me.chrtStock2.BackColor = System.Drawing.Color.Black
        ChartArea10.Name = "ChartArea1"
        Me.chrtStock2.ChartAreas.Add(ChartArea10)
        Legend10.Name = "Legend1"
        Me.chrtStock2.Legends.Add(Legend10)
        Me.chrtStock2.Location = New System.Drawing.Point(20, 309)
        Me.chrtStock2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chrtStock2.Name = "chrtStock2"
        Series10.ChartArea = "ChartArea1"
        Series10.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series10.Color = System.Drawing.Color.Lime
        Series10.Legend = "Legend1"
        Series10.Name = "Series1"
        Me.chrtStock2.Series.Add(Series10)
        Me.chrtStock2.Size = New System.Drawing.Size(618, 162)
        Me.chrtStock2.TabIndex = 12
        Me.chrtStock2.Text = "Chart2"
        '
        'chrtStock3
        '
        Me.chrtStock3.BackColor = System.Drawing.Color.Black
        ChartArea11.Name = "ChartArea1"
        Me.chrtStock3.ChartAreas.Add(ChartArea11)
        Legend11.Name = "Legend1"
        Me.chrtStock3.Legends.Add(Legend11)
        Me.chrtStock3.Location = New System.Drawing.Point(20, 476)
        Me.chrtStock3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chrtStock3.Name = "chrtStock3"
        Series11.ChartArea = "ChartArea1"
        Series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series11.Color = System.Drawing.Color.Lime
        Series11.Legend = "Legend1"
        Series11.Name = "Series1"
        Me.chrtStock3.Series.Add(Series11)
        Me.chrtStock3.Size = New System.Drawing.Size(618, 165)
        Me.chrtStock3.TabIndex = 13
        Me.chrtStock3.Text = "Chart3"
        '
        'lblTop
        '
        Me.lblTop.AutoSize = True
        Me.lblTop.Location = New System.Drawing.Point(17, 122)
        Me.lblTop.Name = "lblTop"
        Me.lblTop.Size = New System.Drawing.Size(84, 14)
        Me.lblTop.TabIndex = 14
        Me.lblTop.Text = "Top Stocks:"
        '
        'btnBuy1
        '
        Me.btnBuy1.BackColor = System.Drawing.Color.Black
        Me.btnBuy1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy1.Location = New System.Drawing.Point(529, 179)
        Me.btnBuy1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuy1.Name = "btnBuy1"
        Me.btnBuy1.Size = New System.Drawing.Size(87, 24)
        Me.btnBuy1.TabIndex = 15
        Me.btnBuy1.Text = "Buy"
        Me.btnBuy1.UseVisualStyleBackColor = False
        '
        'btnSell1
        '
        Me.btnSell1.BackColor = System.Drawing.Color.Black
        Me.btnSell1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell1.Location = New System.Drawing.Point(529, 211)
        Me.btnSell1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSell1.Name = "btnSell1"
        Me.btnSell1.Size = New System.Drawing.Size(87, 24)
        Me.btnSell1.TabIndex = 16
        Me.btnSell1.Text = "Sell"
        Me.btnSell1.UseVisualStyleBackColor = False
        '
        'btnSell2
        '
        Me.btnSell2.BackColor = System.Drawing.Color.Black
        Me.btnSell2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell2.Location = New System.Drawing.Point(529, 381)
        Me.btnSell2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSell2.Name = "btnSell2"
        Me.btnSell2.Size = New System.Drawing.Size(87, 24)
        Me.btnSell2.TabIndex = 18
        Me.btnSell2.Text = "Sell"
        Me.btnSell2.UseVisualStyleBackColor = False
        '
        'btnBuy2
        '
        Me.btnBuy2.BackColor = System.Drawing.Color.Black
        Me.btnBuy2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy2.Location = New System.Drawing.Point(529, 349)
        Me.btnBuy2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuy2.Name = "btnBuy2"
        Me.btnBuy2.Size = New System.Drawing.Size(87, 24)
        Me.btnBuy2.TabIndex = 17
        Me.btnBuy2.Text = "Buy"
        Me.btnBuy2.UseVisualStyleBackColor = False
        '
        'btnSell3
        '
        Me.btnSell3.BackColor = System.Drawing.Color.Black
        Me.btnSell3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSell3.Location = New System.Drawing.Point(529, 551)
        Me.btnSell3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSell3.Name = "btnSell3"
        Me.btnSell3.Size = New System.Drawing.Size(87, 24)
        Me.btnSell3.TabIndex = 20
        Me.btnSell3.Text = "Sell"
        Me.btnSell3.UseVisualStyleBackColor = False
        '
        'btnBuy3
        '
        Me.btnBuy3.BackColor = System.Drawing.Color.Black
        Me.btnBuy3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuy3.Location = New System.Drawing.Point(529, 519)
        Me.btnBuy3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuy3.Name = "btnBuy3"
        Me.btnBuy3.Size = New System.Drawing.Size(87, 24)
        Me.btnBuy3.TabIndex = 19
        Me.btnBuy3.Text = "Buy"
        Me.btnBuy3.UseVisualStyleBackColor = False
        '
        'lblStock1
        '
        Me.lblStock1.AutoSize = True
        Me.lblStock1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock1.Location = New System.Drawing.Point(526, 240)
        Me.lblStock1.Name = "lblStock1"
        Me.lblStock1.Size = New System.Drawing.Size(42, 14)
        Me.lblStock1.TabIndex = 21
        Me.lblStock1.Text = "Owned"
        '
        'lblStock2
        '
        Me.lblStock2.AutoSize = True
        Me.lblStock2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock2.Location = New System.Drawing.Point(526, 409)
        Me.lblStock2.Name = "lblStock2"
        Me.lblStock2.Size = New System.Drawing.Size(42, 14)
        Me.lblStock2.TabIndex = 22
        Me.lblStock2.Text = "Owned"
        '
        'lblStock3
        '
        Me.lblStock3.AutoSize = True
        Me.lblStock3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStock3.Location = New System.Drawing.Point(526, 579)
        Me.lblStock3.Name = "lblStock3"
        Me.lblStock3.Size = New System.Drawing.Size(42, 14)
        Me.lblStock3.TabIndex = 23
        Me.lblStock3.Text = "Owned"
        '
        'lblVal3
        '
        Me.lblVal3.AutoSize = True
        Me.lblVal3.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal3.Location = New System.Drawing.Point(526, 605)
        Me.lblVal3.Name = "lblVal3"
        Me.lblVal3.Size = New System.Drawing.Size(42, 14)
        Me.lblVal3.TabIndex = 24
        Me.lblVal3.Text = "Value"
        '
        'lblVal2
        '
        Me.lblVal2.AutoSize = True
        Me.lblVal2.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal2.Location = New System.Drawing.Point(526, 433)
        Me.lblVal2.Name = "lblVal2"
        Me.lblVal2.Size = New System.Drawing.Size(42, 14)
        Me.lblVal2.TabIndex = 25
        Me.lblVal2.Text = "Value"
        '
        'lblVal1
        '
        Me.lblVal1.AutoSize = True
        Me.lblVal1.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVal1.Location = New System.Drawing.Point(526, 268)
        Me.lblVal1.Name = "lblVal1"
        Me.lblVal1.Size = New System.Drawing.Size(42, 14)
        Me.lblVal1.TabIndex = 26
        Me.lblVal1.Text = "Value"
        '
        'lblValS
        '
        Me.lblValS.AutoSize = True
        Me.lblValS.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblValS.Location = New System.Drawing.Point(1144, 283)
        Me.lblValS.Name = "lblValS"
        Me.lblValS.Size = New System.Drawing.Size(42, 14)
        Me.lblValS.TabIndex = 31
        Me.lblValS.Text = "Value"
        '
        'lblStockS
        '
        Me.lblStockS.AutoSize = True
        Me.lblStockS.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStockS.Location = New System.Drawing.Point(1144, 257)
        Me.lblStockS.Name = "lblStockS"
        Me.lblStockS.Size = New System.Drawing.Size(42, 14)
        Me.lblStockS.TabIndex = 30
        Me.lblStockS.Text = "Owned"
        '
        'btnSellS
        '
        Me.btnSellS.BackColor = System.Drawing.Color.Black
        Me.btnSellS.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSellS.Location = New System.Drawing.Point(1147, 225)
        Me.btnSellS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSellS.Name = "btnSellS"
        Me.btnSellS.Size = New System.Drawing.Size(87, 24)
        Me.btnSellS.TabIndex = 29
        Me.btnSellS.Text = "Sell"
        Me.btnSellS.UseVisualStyleBackColor = False
        '
        'btnBuyS
        '
        Me.btnBuyS.BackColor = System.Drawing.Color.Black
        Me.btnBuyS.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBuyS.Location = New System.Drawing.Point(1147, 193)
        Me.btnBuyS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnBuyS.Name = "btnBuyS"
        Me.btnBuyS.Size = New System.Drawing.Size(87, 24)
        Me.btnBuyS.TabIndex = 28
        Me.btnBuyS.Text = "Buy"
        Me.btnBuyS.UseVisualStyleBackColor = False
        '
        'chrtStockS
        '
        Me.chrtStockS.BackColor = System.Drawing.Color.Black
        ChartArea12.Name = "ChartArea1"
        Me.chrtStockS.ChartAreas.Add(ChartArea12)
        Legend12.Name = "Legend1"
        Me.chrtStockS.Legends.Add(Legend12)
        Me.chrtStockS.Location = New System.Drawing.Point(666, 158)
        Me.chrtStockS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.chrtStockS.Name = "chrtStockS"
        Series12.ChartArea = "ChartArea1"
        Series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line
        Series12.Color = System.Drawing.Color.Lime
        Series12.Legend = "Legend1"
        Series12.Name = "Series1"
        Me.chrtStockS.Series.Add(Series12)
        Me.chrtStockS.Size = New System.Drawing.Size(588, 164)
        Me.chrtStockS.TabIndex = 27
        Me.chrtStockS.Text = "Chart1"
        '
        'txtS
        '
        Me.txtS.Location = New System.Drawing.Point(681, 116)
        Me.txtS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtS.Name = "txtS"
        Me.txtS.Size = New System.Drawing.Size(116, 20)
        Me.txtS.TabIndex = 32
        '
        'btnS
        '
        Me.btnS.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnS.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnS.Location = New System.Drawing.Point(814, 114)
        Me.btnS.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnS.Name = "btnS"
        Me.btnS.Size = New System.Drawing.Size(87, 24)
        Me.btnS.TabIndex = 33
        Me.btnS.Text = "Search"
        Me.btnS.UseVisualStyleBackColor = False
        '
        'txtStocksOwned
        '
        Me.txtStocksOwned.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.txtStocksOwned.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtStocksOwned.ForeColor = System.Drawing.Color.Lime
        Me.txtStocksOwned.Location = New System.Drawing.Point(644, 309)
        Me.txtStocksOwned.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txtStocksOwned.Multiline = True
        Me.txtStocksOwned.Name = "txtStocksOwned"
        Me.txtStocksOwned.ReadOnly = True
        Me.txtStocksOwned.Size = New System.Drawing.Size(630, 317)
        Me.txtStocksOwned.TabIndex = 35
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUser.Location = New System.Drawing.Point(79, 663)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(42, 14)
        Me.lblUser.TabIndex = 36
        Me.lblUser.Text = "User:"
        '
        'lblExpenses
        '
        Me.lblExpenses.AutoSize = True
        Me.lblExpenses.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblExpenses.Location = New System.Drawing.Point(1033, 663)
        Me.lblExpenses.Name = "lblExpenses"
        Me.lblExpenses.Size = New System.Drawing.Size(91, 14)
        Me.lblExpenses.TabIndex = 38
        Me.lblExpenses.Text = "Expenses: $0"
        '
        'btnLoan
        '
        Me.btnLoan.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnLoan.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLoan.Location = New System.Drawing.Point(31, 65)
        Me.btnLoan.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnLoan.Name = "btnLoan"
        Me.btnLoan.Size = New System.Drawing.Size(405, 43)
        Me.btnLoan.TabIndex = 0
        Me.btnLoan.Text = "Loans"
        Me.btnLoan.UseVisualStyleBackColor = False
        '
        'btnStocks
        '
        Me.btnStocks.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnStocks.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStocks.Location = New System.Drawing.Point(31, 4)
        Me.btnStocks.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnStocks.Name = "btnStocks"
        Me.btnStocks.Size = New System.Drawing.Size(618, 55)
        Me.btnStocks.TabIndex = 3
        Me.btnStocks.Text = "Stock Directory"
        Me.btnStocks.UseVisualStyleBackColor = False
        '
        'btnAdvance
        '
        Me.btnAdvance.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnAdvance.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdvance.Location = New System.Drawing.Point(655, 4)
        Me.btnAdvance.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnAdvance.Name = "btnAdvance"
        Me.btnAdvance.Size = New System.Drawing.Size(608, 55)
        Me.btnAdvance.TabIndex = 9
        Me.btnAdvance.Text = "Advance Month"
        Me.btnAdvance.UseVisualStyleBackColor = False
        '
        'btnRetirement
        '
        Me.btnRetirement.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnRetirement.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRetirement.Location = New System.Drawing.Point(442, 65)
        Me.btnRetirement.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnRetirement.Name = "btnRetirement"
        Me.btnRetirement.Size = New System.Drawing.Size(419, 43)
        Me.btnRetirement.TabIndex = 10
        Me.btnRetirement.Text = "Retirement Account"
        Me.btnRetirement.UseVisualStyleBackColor = False
        '
        'btnSave
        '
        Me.btnSave.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnSave.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(867, 65)
        Me.btnSave.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(396, 43)
        Me.btnSave.TabIndex = 37
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = False
        '
        'frmStocks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1297, 692)
        Me.Controls.Add(Me.lblExpenses)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.lblUser)
        Me.Controls.Add(Me.txtStocksOwned)
        Me.Controls.Add(Me.btnS)
        Me.Controls.Add(Me.txtS)
        Me.Controls.Add(Me.lblValS)
        Me.Controls.Add(Me.lblStockS)
        Me.Controls.Add(Me.btnSellS)
        Me.Controls.Add(Me.btnBuyS)
        Me.Controls.Add(Me.chrtStockS)
        Me.Controls.Add(Me.lblVal1)
        Me.Controls.Add(Me.lblVal2)
        Me.Controls.Add(Me.lblVal3)
        Me.Controls.Add(Me.lblStock3)
        Me.Controls.Add(Me.lblStock2)
        Me.Controls.Add(Me.lblStock1)
        Me.Controls.Add(Me.btnSell3)
        Me.Controls.Add(Me.btnBuy3)
        Me.Controls.Add(Me.btnSell2)
        Me.Controls.Add(Me.btnBuy2)
        Me.Controls.Add(Me.btnSell1)
        Me.Controls.Add(Me.btnBuy1)
        Me.Controls.Add(Me.lblTop)
        Me.Controls.Add(Me.chrtStock3)
        Me.Controls.Add(Me.chrtStock2)
        Me.Controls.Add(Me.chrtStock1)
        Me.Controls.Add(Me.btnRetirement)
        Me.Controls.Add(Me.btnAdvance)
        Me.Controls.Add(Me.lblRetirement)
        Me.Controls.Add(Me.lblPort)
        Me.Controls.Add(Me.lblCash)
        Me.Controls.Add(Me.lblMonth)
        Me.Controls.Add(Me.btnStocks)
        Me.Controls.Add(Me.btnLoan)
        Me.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Lime
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmStocks"
        Me.Text = "Main Menu"
        CType(Me.chrtStock1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtStock2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtStock3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chrtStockS, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblMonth As System.Windows.Forms.Label
    Friend WithEvents lblCash As System.Windows.Forms.Label
    Friend WithEvents lblPort As System.Windows.Forms.Label
    Friend WithEvents lblRetirement As System.Windows.Forms.Label
    Friend WithEvents chrtStock1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chrtStock2 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents chrtStock3 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents lblTop As System.Windows.Forms.Label
    Friend WithEvents btnBuy1 As System.Windows.Forms.Button
    Friend WithEvents btnSell1 As System.Windows.Forms.Button
    Friend WithEvents btnSell2 As System.Windows.Forms.Button
    Friend WithEvents btnBuy2 As System.Windows.Forms.Button
    Friend WithEvents btnSell3 As System.Windows.Forms.Button
    Friend WithEvents btnBuy3 As System.Windows.Forms.Button
    Friend WithEvents lblStock1 As System.Windows.Forms.Label
    Friend WithEvents lblStock2 As System.Windows.Forms.Label
    Friend WithEvents lblStock3 As System.Windows.Forms.Label
    Friend WithEvents lblVal3 As System.Windows.Forms.Label
    Friend WithEvents lblVal2 As System.Windows.Forms.Label
    Friend WithEvents lblVal1 As System.Windows.Forms.Label
    Friend WithEvents lblValS As System.Windows.Forms.Label
    Friend WithEvents lblStockS As System.Windows.Forms.Label
    Friend WithEvents btnSellS As System.Windows.Forms.Button
    Friend WithEvents btnBuyS As System.Windows.Forms.Button
    Friend WithEvents chrtStockS As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents txtS As System.Windows.Forms.TextBox
    Friend WithEvents btnS As System.Windows.Forms.Button
    Friend WithEvents txtStocksOwned As System.Windows.Forms.TextBox
    Friend WithEvents lblUser As System.Windows.Forms.Label
    Friend WithEvents lblExpenses As System.Windows.Forms.Label
    Friend WithEvents btnLoan As System.Windows.Forms.Button
    Friend WithEvents btnStocks As System.Windows.Forms.Button
    Friend WithEvents btnAdvance As System.Windows.Forms.Button
    Friend WithEvents btnRetirement As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
End Class
