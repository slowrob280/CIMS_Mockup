Imports System
Imports System.Data
Imports System.Data.Odbc

Public Class frmCIMS
    Private Sub ckWEBcnx_Click(sender As Object, e As EventArgs) Handles ckWEBcnx.Click
        If ckWEBcnx.Checked = True Then
            With cdOldCIMS
                .strCust = lblCustomer.Text
                .strShipTo = lblShipTo.Text
                .strIdent = lblCustID.Text
                .strL = lblL.Text
                .strW = lblW.Text
                .strD = lblD.Text
                .strLength = lblLength.Text
                .strWidth = lblWidth.Text
            End With

            Dim p As Point : p.X = Me.Location.X + Me.Width : p.Y = Me.Location.Y
            frmWEBcnx.Show()
            frmWEBcnx.Location = p
        End If
    End Sub

    Sub PopulateTaskList()
        Dim adoConnection As New OdbcConnection
        Dim strConnection = "DSN=CENTRAL;UID=enterprise;PWD=pca2010"
        adoConnection.ConnectionString = strConnection
        Dim strCommand As String = "Select * from WCTOCIMS where WC_SITE_CD = 388 order by WC_KEY;"
        Dim adoCommand As New OdbcCommand(strCommand, adoConnection)
        adoConnection.Open()
        Dim adoReader As OdbcDataReader = adoCommand.ExecuteReader()
        Dim strCustomer As String = ""
        Dim strCustCode As String = ""
        frmWEBcnx.lbTasks.Items.Clear()

        Try
            While adoReader.Read
                strCustCode = Strings.Trim(adoReader.GetString(1)) & Strings.Trim(adoReader.GetString(2))
                strCustomer = funcGetLookup("CS_CSNAME", "CUSTOMER", "CS_CSCODE", CInt(strCustCode))
                frmWEBcnx.lbTasks.Items.Add(strCustomer & " - J" & adoReader.GetDecimal(38) & "/T" & adoReader.GetString(39) & " - " & adoReader.GetString(4))
            End While
        Catch ex As Exception
            frmWEBcnx.lbTasks.Items.Clear()
            frmWEBcnx.lbTasks.Items.Add("No Records Found")
            MsgBox(ex.Message)
        Finally
            adoReader.Close()
            adoConnection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim p As Point : p.X = Me.Location.X + Me.Width : p.Y = Me.Location.Y
        frmWEBcnx2.Show()
        frmWEBcnx2.Location = p
    End Sub

End Class
