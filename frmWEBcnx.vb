Imports System.IO

Public Class frmWEBcnx
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
    Private Sub frmWEBcnx_Load(sender As Object, e As EventArgs) Handles Me.Load
        Cursor = Cursors.WaitCursor
        wcData = funcGetRecords()
        lbTasks.Items.Clear()
        If wcData.Tasks.Count > 0 Then
            For Each item In wcData.Tasks
                lbTasks.Items.Add(item)
            Next
            lbTasks.SelectedIndex = 0
        End If
        Cursor = Cursors.Default
    End Sub
    Private Sub lbTasks_SelectedValueChanged(sender As Object, e As EventArgs) Handles lbTasks.SelectedValueChanged
        Dim strItem As String() = wcData.Tasks.Item(lbTasks.SelectedIndex).Split(Constants.vbTab)
        webBrowser.DocumentText = wcData.HTMLs(lbTasks.SelectedIndex)
        If Not wcData.Images.Item(lbTasks.SelectedIndex) Is Nothing Then
            picDrawing.Image = Image.FromStream(wcData.Images.Item(lbTasks.SelectedIndex))
        Else
            picDrawing.Image = Nothing
        End If
        If ckAutoFill.Checked Then subFillCIMS()
    End Sub

    Private Sub btnImport_Click(sender As Object, e As EventArgs) Handles btnImport.Click
        subFillCIMS()
    End Sub

    Private Sub btnComplete_Click(sender As Object, e As EventArgs) Handles btnComplete.Click
        Me.Close()
    End Sub
    Sub subFillCIMS()
        frmCIMS.lblCustomer.Text = wcData.Fields(lbTasks.SelectedIndex).strCust
        frmCIMS.lblShipTo.Text = wcData.Fields(lbTasks.SelectedIndex).strShipTo
        frmCIMS.lblCustID.Text = wcData.Fields(lbTasks.SelectedIndex).strIdent
        frmCIMS.lblL.Text = wcData.Fields(lbTasks.SelectedIndex).strL
        frmCIMS.lblW.Text = wcData.Fields(lbTasks.SelectedIndex).strW
        frmCIMS.lblD.Text = wcData.Fields(lbTasks.SelectedIndex).strD
        frmCIMS.lblWidth.Text = wcData.Fields(lbTasks.SelectedIndex).strWidth
        frmCIMS.lblLength.Text = wcData.Fields(lbTasks.SelectedIndex).strLength

        frmCIMS.dgvPrint.Rows.Clear()
        If wcData.Fields(lbTasks.SelectedIndex).strInk1 <> "" Then _
            frmCIMS.dgvPrint.Rows.Add(New String() {wcData.Fields(lbTasks.SelectedIndex).strPer1, "Estimating Ink Pemium"})
        If wcData.Fields(lbTasks.SelectedIndex).strInk2 <> "" Then _
            frmCIMS.dgvPrint.Rows.Add(New String() {wcData.Fields(lbTasks.SelectedIndex).strPer2, "Estimating Ink Pemium"})
        If wcData.Fields(lbTasks.SelectedIndex).strInk3 <> "" Then _
            frmCIMS.dgvPrint.Rows.Add(New String() {wcData.Fields(lbTasks.SelectedIndex).strPer3, "Estimating Ink Pemium"})
        If wcData.Fields(lbTasks.SelectedIndex).strInk4 <> "" Then _
            frmCIMS.dgvPrint.Rows.Add(New String() {wcData.Fields(lbTasks.SelectedIndex).strPer4, "Estimating Ink Pemium"})
    End Sub
End Class