<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.pnlVendor = New System.Windows.Forms.Panel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtDebit = New System.Windows.Forms.TextBox()
        Me.txtQuantityMat = New System.Windows.Forms.TextBox()
        Me.btnAddMat = New System.Windows.Forms.Button()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtItemMat = New System.Windows.Forms.TextBox()
        Me.txtVendor = New System.Windows.Forms.TextBox()
        Me.txtDateMat = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pnlCustomer = New System.Windows.Forms.Panel()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtQuantityCust = New System.Windows.Forms.TextBox()
        Me.txtCredit = New System.Windows.Forms.TextBox()
        Me.txtPhone = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnAddCust = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtItemCust = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtDateCust = New System.Windows.Forms.MaskedTextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.pnlHistory = New System.Windows.Forms.Panel()
        Me.dgvTransaction = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.chkHistMth = New System.Windows.Forms.CheckBox()
        Me.chkHistAll = New System.Windows.Forms.CheckBox()
        Me.pnlHist = New System.Windows.Forms.Panel()
        Me.dgvHistory = New System.Windows.Forms.DataGridView()
        Me.btnHistUpdate = New System.Windows.Forms.Button()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.pnlVendor.SuspendLayout()
        Me.pnlCustomer.SuspendLayout()
        Me.pnlHistory.SuspendLayout()
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.pnlHist.SuspendLayout()
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(894, 450)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.TabPage1.Controls.Add(Me.pnlVendor)
        Me.TabPage1.Controls.Add(Me.pnlCustomer)
        Me.TabPage1.Controls.Add(Me.pnlHistory)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(886, 424)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Transaction"
        '
        'pnlVendor
        '
        Me.pnlVendor.BackColor = System.Drawing.Color.Transparent
        Me.pnlVendor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlVendor.Controls.Add(Me.Label16)
        Me.pnlVendor.Controls.Add(Me.Label10)
        Me.pnlVendor.Controls.Add(Me.txtDebit)
        Me.pnlVendor.Controls.Add(Me.txtQuantityMat)
        Me.pnlVendor.Controls.Add(Me.btnAddMat)
        Me.pnlVendor.Controls.Add(Me.Label9)
        Me.pnlVendor.Controls.Add(Me.txtItemMat)
        Me.pnlVendor.Controls.Add(Me.txtVendor)
        Me.pnlVendor.Controls.Add(Me.txtDateMat)
        Me.pnlVendor.Controls.Add(Me.Label11)
        Me.pnlVendor.Controls.Add(Me.Label12)
        Me.pnlVendor.Controls.Add(Me.Label13)
        Me.pnlVendor.Controls.Add(Me.Label14)
        Me.pnlVendor.Controls.Add(Me.Label2)
        Me.pnlVendor.Location = New System.Drawing.Point(3, 0)
        Me.pnlVendor.Name = "pnlVendor"
        Me.pnlVendor.Size = New System.Drawing.Size(429, 253)
        Me.pnlVendor.TabIndex = 3
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(200, 166)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(31, 13)
        Me.Label16.TabIndex = 24
        Me.Label16.Text = "MYR"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(210, 45)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 13)
        Me.Label10.TabIndex = 23
        Me.Label10.Text = "dd/MM/yyyy"
        '
        'txtDebit
        '
        Me.txtDebit.Location = New System.Drawing.Point(117, 162)
        Me.txtDebit.Name = "txtDebit"
        Me.txtDebit.Size = New System.Drawing.Size(78, 20)
        Me.txtDebit.TabIndex = 4
        Me.txtDebit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtQuantityMat
        '
        Me.txtQuantityMat.Location = New System.Drawing.Point(117, 132)
        Me.txtQuantityMat.Name = "txtQuantityMat"
        Me.txtQuantityMat.Size = New System.Drawing.Size(78, 20)
        Me.txtQuantityMat.TabIndex = 3
        Me.txtQuantityMat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'btnAddMat
        '
        Me.btnAddMat.Location = New System.Drawing.Point(305, 221)
        Me.btnAddMat.Name = "btnAddMat"
        Me.btnAddMat.Size = New System.Drawing.Size(74, 22)
        Me.btnAddMat.TabIndex = 5
        Me.btnAddMat.Text = "Insert Data"
        Me.btnAddMat.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 165)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(74, 13)
        Me.Label9.TabIndex = 22
        Me.Label9.Text = "TOTAL COST"
        '
        'txtItemMat
        '
        Me.txtItemMat.Location = New System.Drawing.Point(117, 102)
        Me.txtItemMat.Name = "txtItemMat"
        Me.txtItemMat.Size = New System.Drawing.Size(149, 20)
        Me.txtItemMat.TabIndex = 2
        '
        'txtVendor
        '
        Me.txtVendor.Location = New System.Drawing.Point(117, 72)
        Me.txtVendor.Name = "txtVendor"
        Me.txtVendor.Size = New System.Drawing.Size(294, 20)
        Me.txtVendor.TabIndex = 1
        '
        'txtDateMat
        '
        Me.txtDateMat.Location = New System.Drawing.Point(117, 42)
        Me.txtDateMat.Mask = "00/00/0000"
        Me.txtDateMat.Name = "txtDateMat"
        Me.txtDateMat.Size = New System.Drawing.Size(78, 20)
        Me.txtDateMat.TabIndex = 0
        Me.txtDateMat.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(29, 135)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "QUANTITY"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(58, 105)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(33, 13)
        Me.Label12.TabIndex = 15
        Me.Label12.Text = "ITEM"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(38, 75)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(53, 13)
        Me.Label13.TabIndex = 14
        Me.Label13.Text = "VENDOR"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(55, 45)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(36, 13)
        Me.Label14.TabIndex = 13
        Me.Label14.Text = "DATE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(125, 11)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(152, 17)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "MATERIAL PAYMENT"
        '
        'pnlCustomer
        '
        Me.pnlCustomer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlCustomer.Controls.Add(Me.Label17)
        Me.pnlCustomer.Controls.Add(Me.Label15)
        Me.pnlCustomer.Controls.Add(Me.txtQuantityCust)
        Me.pnlCustomer.Controls.Add(Me.txtCredit)
        Me.pnlCustomer.Controls.Add(Me.txtPhone)
        Me.pnlCustomer.Controls.Add(Me.Label7)
        Me.pnlCustomer.Controls.Add(Me.btnAddCust)
        Me.pnlCustomer.Controls.Add(Me.Label8)
        Me.pnlCustomer.Controls.Add(Me.txtItemCust)
        Me.pnlCustomer.Controls.Add(Me.txtName)
        Me.pnlCustomer.Controls.Add(Me.txtDateCust)
        Me.pnlCustomer.Controls.Add(Me.Label6)
        Me.pnlCustomer.Controls.Add(Me.Label5)
        Me.pnlCustomer.Controls.Add(Me.Label4)
        Me.pnlCustomer.Controls.Add(Me.Label3)
        Me.pnlCustomer.Controls.Add(Me.Label1)
        Me.pnlCustomer.Location = New System.Drawing.Point(433, 0)
        Me.pnlCustomer.Name = "pnlCustomer"
        Me.pnlCustomer.Size = New System.Drawing.Size(448, 253)
        Me.pnlCustomer.TabIndex = 4
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(191, 196)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(31, 13)
        Me.Label17.TabIndex = 31
        Me.Label17.Text = "MYR"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(205, 45)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(67, 13)
        Me.Label15.TabIndex = 30
        Me.Label15.Text = "dd/MM/yyyy"
        '
        'txtQuantityCust
        '
        Me.txtQuantityCust.Location = New System.Drawing.Point(108, 162)
        Me.txtQuantityCust.Name = "txtQuantityCust"
        Me.txtQuantityCust.Size = New System.Drawing.Size(78, 20)
        Me.txtQuantityCust.TabIndex = 4
        Me.txtQuantityCust.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtCredit
        '
        Me.txtCredit.Location = New System.Drawing.Point(108, 192)
        Me.txtCredit.Name = "txtCredit"
        Me.txtCredit.Size = New System.Drawing.Size(78, 20)
        Me.txtCredit.TabIndex = 5
        Me.txtCredit.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(108, 102)
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(149, 20)
        Me.txtPhone.TabIndex = 2
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(18, 105)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 13)
        Me.Label7.TabIndex = 29
        Me.Label7.Text = "PHONE NO"
        '
        'btnAddCust
        '
        Me.btnAddCust.Location = New System.Drawing.Point(295, 221)
        Me.btnAddCust.Name = "btnAddCust"
        Me.btnAddCust.Size = New System.Drawing.Size(74, 22)
        Me.btnAddCust.TabIndex = 6
        Me.btnAddCust.Text = "Insert Data"
        Me.btnAddCust.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 195)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(74, 13)
        Me.Label8.TabIndex = 10
        Me.Label8.Text = "TOTAL COST"
        '
        'txtItemCust
        '
        Me.txtItemCust.Location = New System.Drawing.Point(108, 132)
        Me.txtItemCust.Name = "txtItemCust"
        Me.txtItemCust.Size = New System.Drawing.Size(149, 20)
        Me.txtItemCust.TabIndex = 3
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(108, 72)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(294, 20)
        Me.txtName.TabIndex = 1
        '
        'txtDateCust
        '
        Me.txtDateCust.Location = New System.Drawing.Point(108, 42)
        Me.txtDateCust.Mask = "00/00/0000"
        Me.txtDateCust.Name = "txtDateCust"
        Me.txtDateCust.Size = New System.Drawing.Size(78, 20)
        Me.txtDateCust.TabIndex = 0
        Me.txtDateCust.ValidatingType = GetType(Date)
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(20, 165)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(62, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "QUANTITY"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(49, 135)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(33, 13)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "ITEM"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(44, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "NAME"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 45)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(36, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "DATE"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(219, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Tempus Sans ITC", 9.75!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(162, 11)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(155, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "CUSTOMER PAYMENT"
        '
        'pnlHistory
        '
        Me.pnlHistory.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.pnlHistory.Controls.Add(Me.dgvTransaction)
        Me.pnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.pnlHistory.Location = New System.Drawing.Point(3, 253)
        Me.pnlHistory.Name = "pnlHistory"
        Me.pnlHistory.Padding = New System.Windows.Forms.Padding(10)
        Me.pnlHistory.Size = New System.Drawing.Size(880, 168)
        Me.pnlHistory.TabIndex = 5
        '
        'dgvTransaction
        '
        Me.dgvTransaction.AllowUserToAddRows = False
        Me.dgvTransaction.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvTransaction.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvTransaction.Location = New System.Drawing.Point(10, 10)
        Me.dgvTransaction.Name = "dgvTransaction"
        Me.dgvTransaction.ReadOnly = True
        Me.dgvTransaction.Size = New System.Drawing.Size(858, 146)
        Me.dgvTransaction.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(194, Byte), Integer), CType(CType(194, Byte), Integer))
        Me.TabPage2.Controls.Add(Me.chkHistMth)
        Me.TabPage2.Controls.Add(Me.chkHistAll)
        Me.TabPage2.Controls.Add(Me.pnlHist)
        Me.TabPage2.Controls.Add(Me.btnHistUpdate)
        Me.TabPage2.Controls.Add(Me.DateTimePicker1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(886, 424)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "History"
        '
        'chkHistMth
        '
        Me.chkHistMth.AutoSize = True
        Me.chkHistMth.Location = New System.Drawing.Point(320, 42)
        Me.chkHistMth.Name = "chkHistMth"
        Me.chkHistMth.Size = New System.Drawing.Size(152, 17)
        Me.chkHistMth.TabIndex = 3
        Me.chkHistMth.Text = "Display all in current month"
        Me.chkHistMth.UseVisualStyleBackColor = True
        '
        'chkHistAll
        '
        Me.chkHistAll.AutoSize = True
        Me.chkHistAll.Location = New System.Drawing.Point(8, 21)
        Me.chkHistAll.Name = "chkHistAll"
        Me.chkHistAll.Size = New System.Drawing.Size(133, 17)
        Me.chkHistAll.TabIndex = 1
        Me.chkHistAll.Text = "Display all transactions"
        Me.chkHistAll.UseVisualStyleBackColor = True
        '
        'pnlHist
        '
        Me.pnlHist.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlHist.Controls.Add(Me.dgvHistory)
        Me.pnlHist.Location = New System.Drawing.Point(6, 59)
        Me.pnlHist.Name = "pnlHist"
        Me.pnlHist.Size = New System.Drawing.Size(874, 357)
        Me.pnlHist.TabIndex = 3
        '
        'dgvHistory
        '
        Me.dgvHistory.AllowUserToAddRows = False
        Me.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.dgvHistory.Location = New System.Drawing.Point(0, 0)
        Me.dgvHistory.Name = "dgvHistory"
        Me.dgvHistory.Size = New System.Drawing.Size(874, 357)
        Me.dgvHistory.TabIndex = 2
        '
        'btnHistUpdate
        '
        Me.btnHistUpdate.Location = New System.Drawing.Point(612, 17)
        Me.btnHistUpdate.Name = "btnHistUpdate"
        Me.btnHistUpdate.Size = New System.Drawing.Size(106, 22)
        Me.btnHistUpdate.TabIndex = 4
        Me.btnHistUpdate.Text = "Update Balance"
        Me.btnHistUpdate.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(320, 18)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(254, 20)
        Me.DateTimePicker1.TabIndex = 2
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(894, 450)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmMain"
        Me.Text = "Cocoon Cushion"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.pnlVendor.ResumeLayout(False)
        Me.pnlVendor.PerformLayout()
        Me.pnlCustomer.ResumeLayout(False)
        Me.pnlCustomer.PerformLayout()
        Me.pnlHistory.ResumeLayout(False)
        CType(Me.dgvTransaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.pnlHist.ResumeLayout(False)
        CType(Me.dgvHistory, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents pnlCustomer As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents pnlVendor As System.Windows.Forms.Panel
    Friend WithEvents pnlHistory As System.Windows.Forms.Panel
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents btnHistUpdate As System.Windows.Forms.Button
    Friend WithEvents pnlHist As System.Windows.Forms.Panel
    Friend WithEvents dgvHistory As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents dgvTransaction As System.Windows.Forms.DataGridView
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtItemCust As System.Windows.Forms.TextBox
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtDateCust As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtItemMat As System.Windows.Forms.TextBox
    Friend WithEvents txtVendor As System.Windows.Forms.TextBox
    Friend WithEvents txtDateMat As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents btnAddCust As System.Windows.Forms.Button
    Friend WithEvents btnAddMat As System.Windows.Forms.Button
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents chkHistAll As System.Windows.Forms.CheckBox
    Friend WithEvents txtDebit As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantityMat As System.Windows.Forms.TextBox
    Friend WithEvents txtQuantityCust As System.Windows.Forms.TextBox
    Friend WithEvents txtCredit As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents chkHistMth As System.Windows.Forms.CheckBox

End Class
