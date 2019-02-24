Imports System.IO

Public Class frmWEBcnx2
    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
        frmCIMS.lblCustomer.Text = cdOldCIMS.strCust
        frmCIMS.lblShipTo.Text = cdOldCIMS.strShipTo
        frmCIMS.lblCustID.Text = cdOldCIMS.strIdent
        frmCIMS.lblL.Text = cdOldCIMS.strL
        frmCIMS.lblW.Text = cdOldCIMS.strW
        frmCIMS.lblD.Text = cdOldCIMS.strD
        frmCIMS.lblWidth.Text = cdOldCIMS.strWidth
        frmCIMS.lblLength.Text = cdOldCIMS.strLength
        frmCIMS.ckWEBcnx.Checked = False
    End Sub
    Private Sub frmWEBcnx2_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor = Cursors.WaitCursor
        dtWCData = funcGetRecords2()
        lbTasks.DataSource = dtWCData
        lbTasks.DisplayMember = "ListValue"
        lbTasks_SelectedIndexChanged(lbTasks, New EventArgs())
        Cursor = Cursors.Default
        subApplyFilter()
        lbTasks.SelectedIndex = -1
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        subFillCIMS()
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        'this is where we would write the status back to Impact Table _
        'Change the status to "COmpleted"
        Me.Close()

    End Sub
    Private Sub lbTasks_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lbTasks.SelectedIndexChanged
        subShowData()
    End Sub
    Private Sub txtFilter_TextChanged(sender As Object, e As EventArgs) Handles txtFilter.TextChanged
        subApplyFilter()
    End Sub

    Private Sub ckIncComp_CheckedChanged(sender As Object, e As EventArgs) Handles ckIncComp.CheckedChanged
        lblAge.Visible = ckIncComp.Checked
        lblDays.Visible = ckIncComp.Checked
        txtAge.Visible = ckIncComp.Checked
        subApplyFilter()
    End Sub

    Private Sub txtAge_TextChanged(sender As Object, e As EventArgs)
        subApplyFilter()
    End Sub

    Private Sub txtAge_ValueChanged(sender As Object, e As EventArgs) Handles txtAge.ValueChanged
        subApplyFilter()
    End Sub
    Sub subFillCIMS()
        lbTasks.ValueMember = "Customer" : frmCIMS.lblCustomer.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "ShipTo" : frmCIMS.lblShipTo.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "Ident" : frmCIMS.lblCustID.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "Length" : frmCIMS.lblL.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "Width" : frmCIMS.lblW.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "Depth" : frmCIMS.lblD.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "BlankW" : frmCIMS.lblWidth.Text = lbTasks.SelectedValue
        lbTasks.ValueMember = "BlankL" : frmCIMS.lblLength.Text = lbTasks.SelectedValue

        'MsgBox(lbTasks.SelectedItem.column("Customer").ToString)

        frmCIMS.dgvPrint.Rows.Clear()
        Dim strInk, strPct As String
        For i = 1 To 4
            lbTasks.ValueMember = CStr("Ink" & CStr(i)) : strInk = lbTasks.SelectedValue
            lbTasks.ValueMember = CStr("Pct" & CStr(i)) : strPct = lbTasks.SelectedValue
            If strInk <> "" Then frmCIMS.dgvPrint.Rows.Add(New String() {strPct, "Estimating Ink Premium"})
        Next

    End Sub
    Sub subApplyFilter()
        If Not dtWCData Is Nothing Then
            Dim strFilter As String = ""
            Dim dvDefault As DataView = dtWCData.DefaultView
            Dim deDate As DateTime

            If ckIncComp.Checked Then
                deDate = Today.AddDays(txtAge.Value * -1)
                strFilter = "ListValue LIKE '%" & txtFilter.Text & "%' and (Status = '" & cnstIncomplete & "' or (Status = '" & cnstComplete & "' and Date > #" & deDate.ToShortDateString & "#))"
            Else
                strFilter = "ListValue LIKE '%" & txtFilter.Text & "%' and Status = '" & cnstIncomplete & "'"
            End If
            Try
                dvDefault.RowFilter = strFilter
                dvDefault.Sort = "ListValue ASC"
                subShowData()
            Catch ex As Exception
                MsgBox(ex.Message)
                dvDefault.RowFilter = ""
            End Try

        End If
    End Sub
    Sub subShowData()
        lbTasks.ValueMember = "HTML"
        webBrowser.DocumentText = lbTasks.SelectedValue
        lbTasks.ValueMember = "BLOB"
        Try
            If Not lbTasks.SelectedValue Is Nothing Then
                If lbTasks.SelectedValue.ToString <> "" Then
                    picDrawing.Image = Image.FromStream(lbTasks.SelectedValue)
                Else
                    picDrawing.Image = Nothing
                End If
            End If
        Catch ex As Exception

        End Try

        If ckAutoFill.Checked Then subFillCIMS()
    End Sub

    Private Sub ckAutoFill_CheckedChanged(sender As Object, e As EventArgs) Handles ckAutoFill.CheckedChanged
        If ckAutoFill.Checked Then subFillCIMS()
    End Sub
End Class