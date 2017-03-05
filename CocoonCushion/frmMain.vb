Imports System.Data.SqlClient
Imports System.Data.SqlServerCe
Imports System.IO


Public Class frmMain
    Private DataFolder As String = "DATA\"
    Private tmpDataSetTrans As DataTable = Nothing
    Private tmpDataSetHist As DataTable = Nothing
    Private dbClass As dbConnection = Nothing
    Private dbYear As String = String.Empty
    Private dbMth As String = String.Empty
    Private dbDay As String = String.Empty
    Private dbDataMat As MaterialData = Nothing
    Private dbDataCust As CustomerData = Nothing
    Private tmpValidateMoney As String = ""

    Private Function validateMoney(ByVal strMoney As String) As String
        Dim number As Decimal
        If Decimal.TryParse(strMoney, number) Then
            Return number.ToString("0.00")
        End If
        Return ""
    End Function

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dbClass = New dbConnection
        tmpDataSetTrans = New DataTable
        tmpDataSetHist = New DataTable
        InitDataTable(tmpDataSetTrans)
        InitDataTable(tmpDataSetHist)
        If Not Directory.Exists(DataFolder) Then
            Directory.CreateDirectory(DataFolder)
        End If
        Me.txtDateMat.Text = Today.ToString("dd/MM/yyyy")
        Me.txtDateCust.Text = Today.ToString("dd/MM/yyyy")
    End Sub

    Private Sub InitDataTable(ByRef tmpDataSet As DataTable)
        tmpDataSet.Columns.Add("ID", GetType(Integer))
        tmpDataSet.Columns.Add("Date", GetType(Date))
        tmpDataSet.Columns.Add("Vendor", GetType(String))
        tmpDataSet.Columns.Add("Name", GetType(String))
        tmpDataSet.Columns.Add("Item", GetType(String))
        tmpDataSet.Columns.Add("Phone", GetType(String))
        tmpDataSet.Columns.Add("Quantity", GetType(Integer))
        tmpDataSet.Columns.Add("Debit", GetType(Single))
        tmpDataSet.Columns.Add("Credit", GetType(Single))
        tmpDataSet.Columns.Add("Balance", GetType(Single))
    End Sub

    Private Sub AddtoDataTable(ByVal tmpMat As MaterialData, ByRef dtbl As DataTable)
        Dim newData As DataRow = dtbl.NewRow
        newData.Item("Date") = tmpMat.tDate
        newData.Item("Vendor") = tmpMat.Vendor
        newData.Item("Item") = tmpMat.Item
        newData.Item("Quantity") = tmpMat.Quantity
        newData.Item("Debit") = tmpMat.Debit
        dtbl.Rows.Add(newData)
    End Sub

    Private Sub AddtoDataTable(ByVal tmpCust As CustomerData, ByRef dtbl As DataTable)
        Dim newData As DataRow = dtbl.NewRow
        newData.Item("Date") = tmpCust.tDate
        newData.Item("Name") = tmpCust.Name
        newData.Item("Item") = tmpCust.Item
        newData.Item("Phone") = tmpCust.Phone
        newData.Item("Quantity") = tmpCust.Quantity
        newData.Item("Credit") = tmpCust.Credit
        dtbl.Rows.Add(newData)
    End Sub

    Private Sub frmMain_Resize(sender As Object, e As EventArgs) Handles MyBase.Resize
        pnlHistory.Height = MyBase.Height - 319
    End Sub

    Private Sub frmMain_FormClosing(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        dbClass.CloseDB()
        dbClass.DisposeAll()
        dbClass = Nothing
    End Sub

    Private Sub btnAddMat_Click(sender As Object, e As EventArgs) Handles btnAddMat.Click
        If txtDateMat.Text <> "" Then
            dbDataMat = New MaterialData
            dbYear = Microsoft.VisualBasic.Right(txtDateMat.Text, 4)
            dbMth = Microsoft.VisualBasic.Mid(txtDateMat.Text, 4, 2)
            dbDay = Microsoft.VisualBasic.Left(txtDateMat.Text, 2)
            dbDataMat.tDate = New Date(dbYear, dbMth, dbDay)
            dbDataMat.Vendor = txtVendor.Text
            dbDataMat.Item = txtItemMat.Text
            dbDataMat.Quantity = txtQuantityMat.Text
            tmpValidateMoney = validateMoney(txtDebit.Text)
            If tmpValidateMoney = "" Then
                Exit Sub
            Else
                dbDataMat.Debit = tmpValidateMoney
            End If

            dbClass.CreateDB(DataFolder & dbYear)
            dbClass.ConnectDB()
            dbClass.CreateTable(Helper.ToMonth(dbMth))
            dbClass.InsertMaterial(Helper.ToMonth(dbMth), dbDataMat)

            AddtoDataTable(dbDataMat, tmpDataSetTrans)
            dgvTransaction.DataSource = tmpDataSetTrans
        End If
    End Sub

    Private Sub btnAddCust_Click(sender As Object, e As EventArgs) Handles btnAddCust.Click
        If txtDateCust.Text <> "" Then
            dbDataCust = New CustomerData
            dbYear = Microsoft.VisualBasic.Right(txtDateCust.Text, 4)
            dbMth = Microsoft.VisualBasic.Mid(txtDateCust.Text, 4, 2)
            dbDay = Microsoft.VisualBasic.Left(txtDateCust.Text, 2)
            dbDataCust.tDate = New Date(dbYear, dbMth, dbDay)
            dbDataCust.Name = txtName.Text
            dbDataCust.Phone = txtPhone.Text
            dbDataCust.Item = txtItemCust.Text
            dbDataCust.Quantity = txtQuantityCust.Text
            tmpValidateMoney = validateMoney(txtCredit.Text)
            If tmpValidateMoney = "" Then
                Exit Sub
            Else
                dbDataCust.Credit = tmpValidateMoney
            End If

            dbClass.CreateDB(DataFolder & dbYear)
            dbClass.ConnectDB()
            dbClass.CreateTable(Helper.ToMonth(dbMth))
            dbClass.InsertCustomer(Helper.ToMonth(dbMth), dbDataCust)
            
            AddtoDataTable(dbDataCust, tmpDataSetTrans)
            dgvTransaction.DataSource = tmpDataSetTrans
        End If
    End Sub

    Private Sub btnHistUpdate_Click(sender As Object, e As EventArgs) Handles btnHistUpdate.Click
        Dim tmpdatatbl As DataTable = Nothing
        Dim balMoney As Decimal
        For Each LogFile In Directory.GetFiles(DataFolder)
            If InStr(LogFile, ".sdf") <> 0 Then
                dbClass.CreateDB(LogFile.Split("."c)(0))
                dbClass.ConnectDB()
                If Not dbClass.CheckTable(Helper.ToMonth(1)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(1), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(2)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(2), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(3)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(3), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(4)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(4), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(5)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(5), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(6)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(6), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(7)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(7), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(8)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(8), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(9)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(9), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(10)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(10), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(11)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(11), balMoney)
                End If
                If Not dbClass.CheckTable(Helper.ToMonth(12)) Then
                    dbClass.UpdateBalDB(Helper.ToMonth(12), balMoney)
                End If
            End If
        Next
        tmpdatatbl = Nothing
    End Sub

    Private Sub chkHistAll_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistAll.CheckedChanged
        If chkHistAll.Checked Then
            DateTimePicker1.Enabled = False
            chkHistMth.Enabled = False
            tmpDataSetHist.Rows.Clear()
            Dim tmpdatatbl As DataTable = Nothing
            For Each LogFile In Directory.GetFiles(DataFolder)
                If InStr(LogFile, ".sdf") <> 0 Then
                    dbClass.CreateDB(LogFile.Split("."c)(0))
                    dbClass.ConnectDB()
                    If Not dbClass.CheckTable(Helper.ToMonth(1)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(1))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(2)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(2))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(3)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(3))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(4)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(4))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(5)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(5))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(6)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(6))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(7)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(7))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(8)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(8))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(9)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(9))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(10)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(10))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(11)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(11))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                    If Not dbClass.CheckTable(Helper.ToMonth(12)) Then
                        tmpdatatbl = dbClass.QueryDB(Helper.ToMonth(12))
                        If tmpdatatbl IsNot Nothing Then
                            tmpDataSetHist.Merge(tmpdatatbl)
                        End If
                    End If
                End If
            Next
            tmpdatatbl = Nothing
            dgvHistory.DataSource = tmpDataSetHist
        Else
            DateTimePicker1.Enabled = True
            chkHistMth.Enabled = True
            chkHistMth_CheckedChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub chkHistMth_CheckedChanged(sender As Object, e As EventArgs) Handles chkHistMth.CheckedChanged
        If chkHistMth.Checked Then
            dbClass.CreateDB(DataFolder & DateTimePicker1.Value.Year)
            dbClass.ConnectDB()
            dbClass.CreateTable(Helper.ToMonth(DateTimePicker1.Value.Month))
            dgvHistory.DataSource = dbClass.QueryDB(Helper.ToMonth(DateTimePicker1.Value.Month))
            'dbClass.CreateDB(DataFolder & DateTimePicker1.Value.Year)
            'dbClass.ConnectDB()
            'dbClass.CreateTable(Helper.ToMonth(DateTimePicker1.Value.Month))
            'dgvHistory.DataSource = dbClass.QueryDatasetDB(Helper.ToMonth(DateTimePicker1.Value.Month))
        Else
            dbClass.CreateDB(DataFolder & DateTimePicker1.Value.Year)
            dbClass.ConnectDB()
            dbClass.CreateTable(Helper.ToMonth(DateTimePicker1.Value.Month))
            dgvHistory.DataSource = dbClass.QueryDB(Helper.ToMonth(DateTimePicker1.Value.Month),
                                                    " where Date = '" & DateTimePicker1.Value.ToString("yyyyMMdd") & "'")
        End If
    End Sub

    Private Sub DateTimePicker1_ValueChanged(sender As Object, e As EventArgs) Handles DateTimePicker1.ValueChanged
        chkHistMth_CheckedChanged(Nothing, Nothing)
    End Sub

    Private Sub tabHistory_Select() Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedIndex = 1 Then
            chkHistMth_CheckedChanged(Nothing, Nothing)
        End If
    End Sub

    Private Sub dgvHistory_DataChg() Handles dgvHistory.DataSourceChanged
        HideColHistory()
    End Sub

    Private Sub dgvTransaction_DataChg() Handles dgvTransaction.DataSourceChanged
        HideColTransaction()
    End Sub

    Private Sub HideColTransaction()
        For Each col As DataGridViewColumn In dgvTransaction.Columns
            If col.Name = "tmpData" OrElse col.Name = "ID" Then
                col.Visible = False
            ElseIf col.Name = "Date" Then
                col.DefaultCellStyle.Format = "dd/MM/yyyy"
            ElseIf col.Name = "Debit" OrElse col.Name = "Credit" OrElse col.Name = "Balance" Then
                col.DefaultCellStyle.Format = "0.00"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub

    Private Sub HideColHistory()
        For Each col As DataGridViewColumn In dgvHistory.Columns
            If col.Name = "tmpData" OrElse col.Name = "ID" Then
                col.Visible = False
            ElseIf col.Name = "Date" Then
                col.DefaultCellStyle.Format = "dd/MM/yyyy"
            ElseIf col.Name = "Debit" OrElse col.Name = "Credit" OrElse col.Name = "Balance" Then
                col.DefaultCellStyle.Format = "0.00"
                col.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight
            End If
        Next
    End Sub
End Class

Public Class dbConnection
    Private con As SqlCeConnection = Nothing
    Private eng As SqlCeEngine = Nothing
    Private cmd As SqlCeCommand = Nothing
    Private password As String = "c0cO0nCush1oN!2014"
    Private connectString As String = ""
    Private cmdString As String = ""
    Private objResult As Integer
    Private tmpdbName As String = ""

    Public Sub CreateDB(ByVal dbName As String)
        If tmpdbName = "" Then
            tmpdbName = dbName
        ElseIf tmpdbName <> dbName Then
            tmpdbName = dbName
            con.Close()
        End If
        connectString = String.Format("DataSource=""{0}.sdf""; Password='{1}'", dbName, password)
        If Not File.Exists(String.Format("{0}.sdf", dbName)) Then
            eng = New SqlCeEngine(connectString)
            eng.CreateDatabase()
            eng = Nothing
        End If
        con = New SqlCeConnection(connectString)
    End Sub

    Public Sub ConnectDB()
        If con.State = ConnectionState.Closed Then
            con.Open()
        End If
    End Sub

    Public Sub CloseDB()
        If con IsNot Nothing AndAlso con.State = ConnectionState.Open Then
            con.Close()
        End If
    End Sub

    Public Sub DisposeAll()
        eng = Nothing
        cmd = Nothing
        con = Nothing
    End Sub

    Public Function CheckTable(ByVal tblName As String) As Boolean
        cmdString = "SELECT COUNT(*) FROM Information_Schema.Tables WHERE TABLE_NAME = @tableName"
        Try
            cmd = New SqlCeCommand(cmdString, con)
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@tableName", tblName)
            objResult = Convert.ToInt32(cmd.ExecuteScalar())
        Catch sqlexception As SqlCeException
            MessageBox.Show(sqlexception.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return objResult = 0
    End Function

    Public Sub CreateTable(ByVal tblName As String) 'MMM-yyyy
        ConnectDB()
        If CheckTable(tblName) Then
            cmdString = "create table " + tblName + " (" _
            + "ID INT IDENTITY NOT NULL PRIMARY KEY, " _
            + "Date datetime not null, " _
            + "Vendor nvarchar (50), " _
            + "Name nvarchar (50), " _
            + "Item nvarchar (40), " _
            + "Phone nvarchar (20), " _
            + "Quantity integer, " _
            + "Debit money, " _
            + "Credit money, " _
            + "Balance money, " _
            + "tmpData nvarchar (200) )"

            Try
                cmd = New SqlCeCommand(cmdString, con)
                cmd.ExecuteNonQuery()
            Catch sqlexception As SqlCeException
                MessageBox.Show(sqlexception.Message, "Oh Crap." _
                , MessageBoxButtons.OK, MessageBoxIcon.Error)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Oh Crap." _
                , MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
    End Sub

    Public Sub InsertMaterial(ByVal tblName As String, ByVal insData As MaterialData) 'MMM-yyyy
        ConnectDB()
        cmdString = "insert into " + tblName + " " _
        + "(Date, Vendor, Item, Quantity, Debit) " _
        + "values (@tdate, @vendor, @item, @quantity, @debit)"

        Try
            cmd = New SqlCeCommand(cmdString, con)
            cmd.Parameters.AddWithValue("@tdate", insData.tDate)
            cmd.Parameters.AddWithValue("@vendor", insData.Vendor)
            cmd.Parameters.AddWithValue("@item", insData.Item)
            cmd.Parameters.AddWithValue("@quantity", insData.Quantity)
            cmd.Parameters.AddWithValue("@debit", insData.Debit)
            cmd.ExecuteNonQuery()
        Catch sqlexception As SqlCeException
            MessageBox.Show(sqlexception.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Sub InsertCustomer(ByVal tblName As String, ByVal insData As CustomerData) 'MMM-yyyy
        ConnectDB()
        cmdString = "insert into " + tblName + " " _
        + "(Date, Name, Phone, Item, Quantity, Credit) " _
        + "values (@tdate, @name, @phone, @item, @quantity, @credit)"

        Try
            cmd = New SqlCeCommand(cmdString, con)
            cmd.Parameters.AddWithValue("@tdate", insData.tDate)
            cmd.Parameters.AddWithValue("@name", insData.Name)
            cmd.Parameters.AddWithValue("@phone", insData.Phone)
            cmd.Parameters.AddWithValue("@item", insData.Item)
            cmd.Parameters.AddWithValue("@quantity", insData.Quantity)
            cmd.Parameters.AddWithValue("@credit", insData.Credit)
            cmd.ExecuteNonQuery()
        Catch sqlexception As SqlCeException
            MessageBox.Show(sqlexception.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function QueryDB(ByVal tblName As String, Optional ByVal param As String = "") As DataTable
        Dim tmpTbl As DataTable = Nothing
        ConnectDB()
        cmdString = "select ID, Date, Vendor, Name, Item, Phone, Quantity, Debit, Credit, Balance from " _
            & tblName & param & " order by Date,ID Asc"

        Try
            cmd = New SqlCeCommand(cmdString, con)
            cmd.CommandType = CommandType.Text
            Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
            If rs.HasRows Then
                Dim ordID As Integer = rs.GetOrdinal("ID")
                Dim ordDate As Integer = rs.GetOrdinal("Date")
                Dim ordVendor As Integer = rs.GetOrdinal("Vendor")
                Dim ordName As Integer = rs.GetOrdinal("Name")
                Dim ordItem As Integer = rs.GetOrdinal("Item")
                Dim ordPhone As Integer = rs.GetOrdinal("Phone")
                Dim ordQuantity As Integer = rs.GetOrdinal("Quantity")
                Dim ordDebit As Integer = rs.GetOrdinal("Debit")
                Dim ordCredit As Integer = rs.GetOrdinal("Credit")
                Dim ordBalance As Integer = rs.GetOrdinal("Balance")

                tmpTbl = New DataTable
                InitDataTable(tmpTbl)

                rs.ReadFirst()

                Dim addData As DataRow = tmpTbl.NewRow
                addData.Item("ID") = rs.GetInt32(ordID)
                addData.Item("Date") = rs.GetDateTime(ordDate)
                addData.Item("Vendor") = If(rs(ordVendor) Is DBNull.Value, DBNull.Value, rs.GetString(ordVendor))
                addData.Item("Name") = If(rs(ordName) Is DBNull.Value, DBNull.Value, rs.GetString(ordName))
                addData.Item("Item") = If(rs(ordItem) Is DBNull.Value, DBNull.Value, rs.GetString(ordItem))
                addData.Item("Phone") = If(rs(ordPhone) Is DBNull.Value, DBNull.Value, rs.GetString(ordPhone))
                addData.Item("Quantity") = If(rs(ordQuantity) Is DBNull.Value, DBNull.Value, rs.GetInt32(ordQuantity))
                addData.Item("Debit") = If(rs(ordDebit) Is DBNull.Value, DBNull.Value, rs.GetDecimal(ordDebit))
                addData.Item("Credit") = If(rs(ordCredit) Is DBNull.Value, DBNull.Value, rs.GetDecimal(ordCredit))
                addData.Item("Balance") = If(rs(ordBalance) Is DBNull.Value, DBNull.Value, rs.GetDecimal(ordBalance))
                tmpTbl.Rows.Add(addData)

                Do While rs.Read()
                    addData = tmpTbl.NewRow
                    addData.Item("ID") = rs.GetInt32(ordID)
                    addData.Item("Date") = rs.GetDateTime(ordDate)
                    addData.Item("Vendor") = If(rs(ordVendor) Is DBNull.Value, DBNull.Value, rs.GetString(ordVendor))
                    addData.Item("Name") = If(rs(ordName) Is DBNull.Value, DBNull.Value, rs.GetString(ordName))
                    addData.Item("Item") = If(rs(ordItem) Is DBNull.Value, DBNull.Value, rs.GetString(ordItem))
                    addData.Item("Phone") = If(rs(ordPhone) Is DBNull.Value, DBNull.Value, rs.GetString(ordPhone))
                    addData.Item("Quantity") = If(rs(ordQuantity) Is DBNull.Value, DBNull.Value, rs.GetInt32(ordQuantity))
                    addData.Item("Debit") = If(rs(ordDebit) Is DBNull.Value, DBNull.Value, rs.GetDecimal(ordDebit))
                    addData.Item("Credit") = If(rs(ordCredit) Is DBNull.Value, DBNull.Value, rs.GetDecimal(ordCredit))
                    addData.Item("Balance") = If(rs(ordBalance) Is DBNull.Value, DBNull.Value, rs.GetDecimal(ordBalance))
                    tmpTbl.Rows.Add(addData)
                Loop
            End If
        Catch sqlexception As SqlCeException
            MessageBox.Show(sqlexception.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return tmpTbl
    End Function

    Public Sub UpdateBalDB(ByVal tblName As String, ByRef param As Decimal)
        ConnectDB()
        cmdString = "select * from " _
            & tblName & " order by Date,ID Asc"

        Try
            cmd = New SqlCeCommand(cmdString, con)
            cmd.CommandType = CommandType.Text
            Dim rs As SqlCeResultSet = cmd.ExecuteResultSet(ResultSetOptions.Updatable Or ResultSetOptions.Scrollable)
            If rs.HasRows Then
                Dim ordDebit As Integer = rs.GetOrdinal("Debit")
                Dim ordCredit As Integer = rs.GetOrdinal("Credit")
                Dim ordBalance As Integer = rs.GetOrdinal("Balance")

                rs.ReadFirst()

                If rs(ordDebit) IsNot DBNull.Value Then
                    param -= rs.GetDecimal(ordDebit)
                End If
                If rs(ordCredit) IsNot DBNull.Value Then
                    param += rs.GetDecimal(ordCredit)
                End If

                rs.SetDecimal(ordBalance, param)
                rs.Update()

                Do While rs.Read()
                    If rs(ordDebit) IsNot DBNull.Value Then
                        param -= rs.GetDecimal(ordDebit)
                    End If
                    If rs(ordCredit) IsNot DBNull.Value Then
                        param += rs.GetDecimal(ordCredit)
                    End If

                    rs.SetDecimal(ordBalance, param)
                    rs.Update()
                Loop
            End If
        Catch sqlexception As SqlCeException
            MessageBox.Show(sqlexception.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Public Function QueryDatasetDB(ByVal tblName As String) As SqlCeResultSet 'MMM-yyyy
        ConnectDB()
        Dim rs As SqlCeResultSet = Nothing
        Try
            cmd = New SqlCeCommand(tblName, con)
            cmd.CommandType = CommandType.TableDirect
            rs = cmd.ExecuteResultSet(ResultSetOptions.Scrollable)
        Catch sqlexception As SqlCeException
            MessageBox.Show(sqlexception.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Oh Crap." _
            , MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return rs
    End Function

    Private Sub InitDataTable(ByRef tmpDataSet As DataTable)
        tmpDataSet.Columns.Add("ID", GetType(Integer))
        tmpDataSet.Columns.Add("Date", GetType(Date))
        tmpDataSet.Columns.Add("Vendor", GetType(String))
        tmpDataSet.Columns.Add("Name", GetType(String))
        tmpDataSet.Columns.Add("Item", GetType(String))
        tmpDataSet.Columns.Add("Phone", GetType(String))
        tmpDataSet.Columns.Add("Quantity", GetType(Integer))
        tmpDataSet.Columns.Add("Debit", GetType(Single))
        tmpDataSet.Columns.Add("Credit", GetType(Single))
        tmpDataSet.Columns.Add("Balance", GetType(Single))
    End Sub
End Class

Public Class MaterialData
    Public Property tDate As Date
    Public Property Vendor As String
    Public Property Item As String
    Public Property Quantity As Integer
    Public Property Debit As Single
End Class

Public Class CustomerData
    Public Property tDate As Date
    Public Property Name As String
    Public Property Phone As String
    Public Property Item As String
    Public Property Quantity As Integer
    Public Property Credit As Single
End Class

Public Class Helper
    Public Shared Function ToMonth(ByVal mth As Integer) As String
        Select Case mth
            Case 1
                ToMonth = "Jan"
            Case 2
                ToMonth = "Feb"
            Case 3
                ToMonth = "Mar"
            Case 4
                ToMonth = "Apr"
            Case 5
                ToMonth = "May"
            Case 6
                ToMonth = "Jun"
            Case 7
                ToMonth = "Jul"
            Case 8
                ToMonth = "Aug"
            Case 9
                ToMonth = "Sep"
            Case 10
                ToMonth = "Oct"
            Case 11
                ToMonth = "Nov"
            Case 12
                ToMonth = "Dec"
            Case Else
                ToMonth = String.Empty
        End Select
    End Function
End Class