Imports System
Imports System.Data
Imports System.Data.Odbc
Imports System.IO
Imports System.Data.OleDb
Module mdlMain
    Public Const cnstIncomplete = 0
    Public Const cnstComplete = 3
    Public Const cnstCancelled = 4
    Public dtWCData As DataTable
    Structure CIMSData
        Dim strCust, strShipTo, strIdent, strL, strW, strD, strWidth, strLength, strInk1, strInk2, strInk3, strInk4, strPer1, strPer2, strPer3, strPer4, strDate, strStatus As String
    End Structure
    Public cdOldCIMS As CIMSData
    Structure WEBcnxData
        Dim Tasks As List(Of String)
        Dim Fields As List(Of CIMSData)
        Dim HTMLs As List(Of String)
        Dim Images As List(Of MemoryStream)
    End Structure
    Public wcData As WEBcnxData

    Function funcGetLookup(clmFrom As String, tblFrom As String, clmWhere As String, valWhere As String) As String
        Dim adoConnection As New OdbcConnection
        Dim strConnection = "DSN=CENTRAL;UID=enterprise;PWD=pca2010"
        adoConnection.ConnectionString = strConnection
        Dim strCommand As String = "Select " & clmFrom & " from " & tblFrom & " where " & clmWhere & " = " & valWhere & ";"
        Dim adoCommand As New OdbcCommand(strCommand, adoConnection)
        adoConnection.Open()
        Dim adoReader As OdbcDataReader = adoCommand.ExecuteReader()
        Dim strResult As String = ""

        Try
            While adoReader.Read
                strResult = adoReader.GetString(0)
            End While
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            adoReader.Close()
            adoConnection.Close()
        End Try
        Return strResult
    End Function
    Function funcGetRecords() As WEBcnxData

        Dim adoConnection As New OdbcConnection
        Dim strConnection = "DSN=CENTRAL;UID=enterprise;PWD=pca2010"
        adoConnection.ConnectionString = strConnection
        Dim strCommand As String = "Select * from WCTOCIMS where WC_SITE_CD = 388 order by WC_JOB_NO, WC_TASK_NO;"
        Dim adoCommand As New OdbcCommand(strCommand, adoConnection)
        adoConnection.Open()
        Dim adoReader As OdbcDataReader = adoCommand.ExecuteReader()
        Dim strCustomer As String = "" : Dim strCustCode As String = ""
        Dim strShipToCode As String = "" : Dim strShipTo As String = ""
        Dim colTemp As New List(Of String)
        Dim colPicTemp As New List(Of MemoryStream)
        Dim colCIMSTemp As New List(Of CIMSData)
        Dim colHTMLTemp As New List(Of String)

        'Try
        While adoReader.Read
            strCustCode = Strings.Trim(adoReader.Item("WC_SITE_CD").ToString) & Strings.Trim(adoReader.Item("WC_CCSCODE").ToString)
            strCustomer = funcGetLookup("CS_CSNAME", "CUSTOMER", "CS_CSCODE", CInt(strCustCode))
            strShipToCode = Strings.Trim(adoReader.Item("WC_SHIP_TO").ToString)
            strShipTo = funcGetLookup("A_NAME", "ADDRESS", "A_CUSTKEY", strCustCode & " and A_SHPTONUM = " & strShipToCode)
            colCIMSTemp.Add(New CIMSData With {.strCust = strCustomer,
                                .strShipTo = strShipTo,
                                .strIdent = Strings.Trim(adoReader.Item("WC_IDENT").ToString),
                                .strL = Strings.Trim(adoReader.Item("WC_LENGTH").ToString),
                                .strW = Strings.Trim(adoReader.Item("WC_WIDTH").ToString),
                                .strD = Strings.Trim(adoReader.Item("WC_DEPTH").ToString),
                                .strWidth = Strings.Trim(adoReader.Item("WC_BLANK_W").ToString),
                                .strLength = Strings.Trim(adoReader.Item("WC_BLANK_L").ToString),
                                .strPer1 = Strings.Trim(adoReader.Item("WC_PCT1").ToString),
                                .strPer2 = Strings.Trim(adoReader.Item("WC_PCT2").ToString),
                                .strPer3 = Strings.Trim(adoReader.Item("WC_PCT3").ToString),
                                .strPer4 = Strings.Trim(adoReader.Item("WC_PCT4").ToString),
                                .strInk1 = Strings.Trim(adoReader.Item("WC_INK1").ToString),
                                .strInk2 = Strings.Trim(adoReader.Item("WC_INK2").ToString),
                                .strInk3 = Strings.Trim(adoReader.Item("WC_INK3").ToString),
                                .strInk4 = Strings.Trim(adoReader.Item("WC_INK4").ToString),
                                .strDate = Strings.Trim(adoReader.Item("WC_DATE").ToString),
                                .strStatus = Strings.Trim(adoReader.Item("WC_TSTATUS").ToString)
                            })
            colHTMLTemp.Add(adoReader.Item("WC_TASKXML").ToString)
            colTemp.Add("J" & Strings.Trim(adoReader.Item("WC_JOB_NO").ToString) & "/T" & Strings.Trim(adoReader.Item("WC_TASK_NO").ToString) & " for " & strCustomer & " - " & Strings.Trim(adoReader.Item("WC_TASKSUB").ToString))
            If adoReader.GetValue(51).ToString.Length = 0 Then
                colPicTemp.Add(Nothing)
            Else
                Dim bytBLOBData(adoReader.GetBytes(51, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                adoReader.GetBytes(51, 0, bytBLOBData, 0, bytBLOBData.Length)
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                colPicTemp.Add(stmBLOBData)
            End If
        End While
        'Catch ex As Exception
        'frmWEBcnx.lbTasks.Items.Clear()
        'frmWEBcnx.lbTasks.Items.Add("No Records Found")
        'MsgBox(ex.Message)
        'Finally
        adoReader.Close()
        adoConnection.Close()
        'End Try
        Return New WEBcnxData With {.Tasks = colTemp, .Fields = colCIMSTemp, .HTMLs = colHTMLTemp, .Images = colPicTemp}
    End Function
    Function funcGetRecords3() As DataTable
        Dim dt As DateTime = Now
        Dim dt2 As DateTime = Now
        Dim dt3 As DateTime = Now
        Debug.Print("Start - " & dt.ToString)
        Dim adoConnection As New OdbcConnection
        Dim strConnection = "DSN=CENTRAL;UID=enterprise;PWD=pca2010"
        adoConnection.ConnectionString = strConnection
        Dim strCommand As String = "Select * from WCTOCIMS where WC_SITE_CD = 388 order by WC_JOB_NO, WC_TASK_NO;"
        Dim adoCommand As New OdbcCommand(strCommand, adoConnection)
        adoConnection.Open()
        Debug.Print("After Open - " & (Now - dt).ToString) : dt = Now
        Dim adoReader As OdbcDataReader = adoCommand.ExecuteReader()
        Dim strCustomer As String = "" : Dim strCustCode As String = ""
        Dim strShipToCode As String = "" : Dim strShipTo As String = ""
        Dim colTemp As New List(Of String)
        Dim colPicTemp As New List(Of MemoryStream)
        Dim colCIMSTemp As New List(Of CIMSData)
        Dim colHTMLTemp As New List(Of String)
        Dim dcTemp As New DataColumn
        Dim dcCustomer, dcShipTo, dcIdent, dcL, dcW, dcD, dcWidth, dcLength, dcPct1, dcPct2, dcPct3, dcPct4, dcInk1, dcInk2, dcInk3, dcInk4 As New DataColumn
        Dim dtTemp As New DataTable
        Dim drTemp As DataRow
        Dim dtDate As DateTime : Dim MSThing As New MemoryStream


        dcTemp.DataType = strCustomer.GetType  ' System.Type.GetType("String")
        dcTemp = New DataColumn : dcTemp.ColumnName = "ListValue" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Customer" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "ShipTo" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Subject" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Job" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Task" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ident" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Length" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Width" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Depth" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "BlankW" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "BlankL" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink1" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct1" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink2" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct2" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink3" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct3" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink4" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct4" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Status" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "HTML" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.DataType = dtDate.GetType : dcTemp.ColumnName = "Date" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.DataType = MSThing.GetType : dcTemp.ColumnName = "BLOB" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        Debug.Print("After defining table - " & (Now - dt).ToString) : dt = Now
        'Try

        While adoReader.Read
            dt2 = Now
            dt3 = Now
            strCustCode = Strings.Trim(adoReader.Item("WC_SITE_CD").ToString) & Strings.Trim(adoReader.Item("WC_CCSCODE").ToString)
            strCustomer = funcGetLookup("CS_CSNAME", "CUSTOMER", "CS_CSCODE", CInt(strCustCode))
            Debug.Print("After first lookup - " & (Now - dt2).ToString) : dt2 = Now
            strShipToCode = Strings.Trim(adoReader.Item("WC_SHIP_TO").ToString)
            strShipTo = funcGetLookup("A_NAME", "ADDRESS", "A_CUSTKEY", strCustCode & " and A_SHPTONUM = " & strShipToCode)
            Debug.Print("After second lookup - " & (Now - dt2).ToString) : dt2 = Now

            drTemp = dtTemp.NewRow
            Debug.Print("After new row - " & (Now - dt2).ToString) : dt2 = Now

            drTemp("Customer") = strCustomer
            drTemp("ShipTo") = strShipTo
            drTemp("Subject") = Strings.Trim(adoReader.Item("WC_TASKSUB").ToString)
            drTemp("Job") = Strings.Trim(adoReader.Item("WC_JOB_NO").ToString)
            drTemp("Task") = Strings.Trim(adoReader.Item("WC_TASK_NO").ToString)
            drTemp("Ident") = Strings.Trim(adoReader.Item("WC_IDENT").ToString)
            drTemp("Length") = Strings.Trim(adoReader.Item("WC_LENGTH").ToString)
            drTemp("Width") = Strings.Trim(adoReader.Item("WC_WIDTH").ToString)
            drTemp("Depth") = Strings.Trim(adoReader.Item("WC_DEPTH").ToString)
            drTemp("BlankW") = Strings.Trim(adoReader.Item("WC_BLANK_W").ToString)
            drTemp("BlankL") = Strings.Trim(adoReader.Item("WC_BLANK_L").ToString)
            drTemp("Ink1") = Strings.Trim(adoReader.Item("WC_INK1").ToString)
            drTemp("Pct1") = Strings.Trim(adoReader.Item("WC_PCT1").ToString)
            drTemp("Ink2") = Strings.Trim(adoReader.Item("WC_INK2").ToString)
            drTemp("Pct2") = Strings.Trim(adoReader.Item("WC_PCT2").ToString)
            drTemp("Ink3") = Strings.Trim(adoReader.Item("WC_INK3").ToString)
            drTemp("Pct3") = Strings.Trim(adoReader.Item("WC_PCT3").ToString)
            drTemp("Ink4") = Strings.Trim(adoReader.Item("WC_INK4").ToString)
            drTemp("Pct4") = Strings.Trim(adoReader.Item("WC_PCT4").ToString)
            drTemp("Status") = Strings.Trim(adoReader.Item("WC_TSTATUS").ToString)
            drTemp("Date") = Convert.ToDateTime(Strings.Trim(adoReader.Item("WC_DATE").ToString))
            drTemp("HTML") = Strings.Trim(adoReader.Item("WC_TASKXML").ToString)
            drTemp("ListValue") = drTemp("Subject") & " from J" & drTemp("Job") & "/T" & drTemp("Task") & " for " & drTemp("Customer")
            Debug.Print("After rows - " & (Now - dt2).ToString) : dt2 = Now

            If adoReader.GetValue(51).ToString.Length = 0 Then
                drTemp("BLOB") = Nothing
            Else
                Dim bytBLOBData(adoReader.GetBytes(51, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                adoReader.GetBytes(51, 0, bytBLOBData, 0, bytBLOBData.Length)
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                drTemp("BLOB") = stmBLOBData
            End If
            Debug.Print("After BLOB - " & (Now - dt2).ToString) : dt2 = Now

            dtTemp.Rows.Add(drTemp)
            Debug.Print("After row.add - " & (Now - dt2).ToString) : dt2 = Now
            Debug.Print("One Complete row - " & (Now - dt3).ToString) : dt3 = Now

        End While
        Debug.Print("After populating - " & (Now - dt).ToString) : dt = Now

        'Catch ex As Exception
        'frmWEBcnx.lbTasks.Items.Clear()
        'frmWEBcnx.lbTasks.Items.Add("No Records Found")
        'MsgBox(ex.Message)
        'Finally
        adoReader.Close()
        adoConnection.Close()
        Debug.Print("After closing DB - " & (Now - dt).ToString) : dt = Now

        'End Try
        Return dtTemp
    End Function
    Function funcGetRecords2() As DataTable
        Dim dt As DateTime = Now
        Dim dt2 As DateTime = Now
        Dim dt3 As DateTime = Now
        Debug.Print("Start - " & dt.ToString)
        Dim adoConnection As New OleDbConnection
        Dim strConnection = "Provider=OraOLEDB.Oracle;Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PCALAKIMPACT.pca.com)(PORT=1521)))(CONNECT_DATA=(SID=CTRTST)));User Id=enterprise;Password=pca2013;"
        adoConnection.ConnectionString = strConnection
        'Data Source=(DESCRIPTION=(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)(HOST=PCALAKIMPACT.pca.com)(PORT=1521)))(CONNECT_DATA=(SID=CENTRAL)));User Id=webcnx;Password=123;
        adoConnection.Open()
        Debug.Print("After Open - " & (Now - dt).ToString) : dt = Now
        Dim strCommand As String = "Select CUSTOMER.CS_NAME,
                                        ADDRESS.A_NAME,
                                        WCTOCIMS.WC_TASKSUB,
                                        WCTOCIMS.WC_JOB_NO,
                                        WCTOCIMS.WC_TASK_NO,
                                        WCTOCIMS.WC_IDENT,
                                        WCTOCIMS.WC_LENGTH,
                                        WCTOCIMS.WC_WIDTH,
                                        WCTOCIMS.WC_DEPTH,
                                        WCTOCIMS.WC_BLANK_W,
                                        WCTOCIMS.WC_BLANK_L,
                                        WCTOCIMS.WC_INK1,
                                        WCTOCIMS.WC_PCT1,
                                        WCTOCIMS.WC_INK2,
                                        WCTOCIMS.WC_PCT2,
                                        WCTOCIMS.WC_INK3,
                                        WCTOCIMS.WC_PCT3,
                                        WCTOCIMS.WC_INK4,
                                        WCTOCIMS.WC_PCT4,
                                        WCTOCIMS.WC_TSTATUS,
                                        WCTOCIMS.WC_DATE,
                                        WCTOCIMS.WC_TASKXML,
                                        WCTOCIMS.WC_IMAGEI
                                    from WCTOCIMS
                                    left join Customer on trim(WCTOCIMS.WC_SITE_CD)||trim(WCTOCIMS.WC_CCSCODE) = customer.cs_cscode
                                    left join Address on trim(WCTOCIMS.WC_SITE_CD)||trim(WCTOCIMS.WC_CCSCODE) = Address.A_CUSTKEY and 
                                        address.A_SHPTONUM = WCTOCIMS.WC_SHIP_TO
                                    where WC_SITE_CD = 388
                                    order by WC_JOB_NO, WC_TASK_NO"
        Dim adoCommand As New OleDbCommand(strCommand, adoConnection)
        Dim adoReader As OleDbDataReader = adoCommand.ExecuteReader()


        Dim strCustomer As String = "" : Dim strCustCode As String = ""
        Dim strShipToCode As String = "" : Dim strShipTo As String = ""
        Dim colTemp As New List(Of String)
        Dim colPicTemp As New List(Of MemoryStream)
        Dim colCIMSTemp As New List(Of CIMSData)
        Dim colHTMLTemp As New List(Of String)
        Dim dcTemp As New DataColumn
        Dim dcCustomer, dcShipTo, dcIdent, dcL, dcW, dcD, dcWidth, dcLength, dcPct1, dcPct2, dcPct3, dcPct4, dcInk1, dcInk2, dcInk3, dcInk4 As New DataColumn
        Dim dtTemp As New DataTable
        Dim drTemp As DataRow
        Dim dtDate As DateTime : Dim MSThing As New MemoryStream


        dcTemp.DataType = strCustomer.GetType  ' System.Type.GetType("String")
        dcTemp = New DataColumn : dcTemp.ColumnName = "ListValue" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Customer" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "ShipTo" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Subject" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Job" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Task" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ident" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Length" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Width" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Depth" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "BlankW" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "BlankL" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink1" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct1" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink2" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct2" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink3" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct3" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Ink4" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Pct4" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "Status" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.ColumnName = "HTML" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.DataType = dtDate.GetType : dcTemp.ColumnName = "Date" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        dcTemp = New DataColumn : dcTemp.DataType = MSThing.GetType : dcTemp.ColumnName = "BLOB" : dcTemp.ReadOnly = True : dtTemp.Columns.Add(dcTemp)
        Debug.Print("After defining table - " & (Now - dt).ToString) : dt = Now
        'Try

        While adoReader.Read
            dt2 = Now
            dt3 = Now
            'strCustCode = Strings.Trim(adoReader.Item("WC_SITE_CD").ToString) & Strings.Trim(adoReader.Item("WC_CCSCODE").ToString)
            'strCustomer = funcGetLookup("CS_CSNAME", "CUSTOMER", "CS_CSCODE", CInt(strCustCode))
            'Debug.Print("After first lookup - " & (Now - dt2).ToString) : dt2 = Now
            'strShipToCode = Strings.Trim(adoReader.Item("WC_SHIP_TO").ToString)
            'strShipTo = funcGetLookup("A_NAME", "ADDRESS", "A_CUSTKEY", strCustCode & " and A_SHPTONUM = " & strShipToCode)
            'Debug.Print("After second lookup - " & (Now - dt2).ToString) : dt2 = Now

            drTemp = dtTemp.NewRow
            Debug.Print("After new row - " & (Now - dt2).ToString) : dt2 = Now
            drTemp("Customer") = Strings.Trim(adoReader.Item("CS_NAME").ToString)
            drTemp("ShipTo") = Strings.Trim(adoReader.Item("A_NAME").ToString)
            drTemp("Subject") = Strings.Trim(adoReader.Item("WC_TASKSUB").ToString)
            drTemp("Job") = Strings.Trim(adoReader.Item("WC_JOB_NO").ToString)
            drTemp("Task") = Strings.Trim(adoReader.Item("WC_TASK_NO").ToString)
            drTemp("Ident") = Strings.Trim(adoReader.Item("WC_IDENT").ToString)
            drTemp("Length") = Strings.Trim(adoReader.Item("WC_LENGTH").ToString)
            drTemp("Width") = Strings.Trim(adoReader.Item("WC_WIDTH").ToString)
            drTemp("Depth") = Strings.Trim(adoReader.Item("WC_DEPTH").ToString)
            drTemp("BlankW") = Strings.Trim(adoReader.Item("WC_BLANK_W").ToString)
            drTemp("BlankL") = Strings.Trim(adoReader.Item("WC_BLANK_L").ToString)
            drTemp("Ink1") = Strings.Trim(adoReader.Item("WC_INK1").ToString)
            drTemp("Pct1") = Strings.Trim(adoReader.Item("WC_PCT1").ToString)
            drTemp("Ink2") = Strings.Trim(adoReader.Item("WC_INK2").ToString)
            drTemp("Pct2") = Strings.Trim(adoReader.Item("WC_PCT2").ToString)
            drTemp("Ink3") = Strings.Trim(adoReader.Item("WC_INK3").ToString)
            drTemp("Pct3") = Strings.Trim(adoReader.Item("WC_PCT3").ToString)
            drTemp("Ink4") = Strings.Trim(adoReader.Item("WC_INK4").ToString)
            drTemp("Pct4") = Strings.Trim(adoReader.Item("WC_PCT4").ToString)
            drTemp("Status") = Strings.Trim(adoReader.Item("WC_TSTATUS").ToString)
            drTemp("Date") = Convert.ToDateTime(Strings.Trim(Now)) 'adoReader.Item("WC_DATE").ToString))
            drTemp("HTML") = Strings.Trim(adoReader.Item("WC_TASKXML").ToString)
            drTemp("ListValue") = drTemp("Subject") & " from J" & drTemp("Job") & "/T" & drTemp("Task") & " for " & drTemp("Customer")
            Debug.Print("After rows - " & (Now - dt2).ToString) : dt2 = Now

            If adoReader.GetValue(22).ToString.Length = 0 Then
                drTemp("BLOB") = Nothing
            Else
                Dim bytBLOBData(adoReader.GetBytes(22, 0, Nothing, 0, Integer.MaxValue) - 1) As Byte
                adoReader.GetBytes(22, 0, bytBLOBData, 0, bytBLOBData.Length)
                Dim stmBLOBData As New MemoryStream(bytBLOBData)
                drTemp("BLOB") = stmBLOBData
            End If
            Debug.Print("After BLOB - " & (Now - dt2).ToString) : dt2 = Now

            dtTemp.Rows.Add(drTemp)
            Debug.Print("After row.add - " & (Now - dt2).ToString) : dt2 = Now
            Debug.Print("One Complete row - " & (Now - dt3).ToString) : dt3 = Now

        End While
        Debug.Print("After populating - " & (Now - dt).ToString) : dt = Now

        'Catch ex As Exception
        'frmWEBcnx.lbTasks.Items.Clear()
        'frmWEBcnx.lbTasks.Items.Add("No Records Found")
        'MsgBox(ex.Message)
        'Finally
        adoReader.Close()
        adoConnection.Close()
        Debug.Print("After closing DB - " & (Now - dt).ToString) : dt = Now

        'End Try
        Return dtTemp
    End Function
End Module
