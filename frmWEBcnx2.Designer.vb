<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWEBcnx2
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
        Me.btnImport = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.btnComplete = New System.Windows.Forms.Button()
        Me.tcDisplay = New System.Windows.Forms.TabControl()
        Me.tpData = New System.Windows.Forms.TabPage()
        Me.webBrowser = New System.Windows.Forms.WebBrowser()
        Me.tpImage = New System.Windows.Forms.TabPage()
        Me.picDrawing = New System.Windows.Forms.PictureBox()
        Me.lbTasks = New System.Windows.Forms.ComboBox()
        Me.ckAutoFill = New System.Windows.Forms.CheckBox()
        Me.txtFilter = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ckIncComp = New System.Windows.Forms.CheckBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtAge = New System.Windows.Forms.NumericUpDown()
        Me.tcDisplay.SuspendLayout()
        Me.tpData.SuspendLayout()
        Me.tpImage.SuspendLayout()
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtAge, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(468, 588)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(160, 45)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(10, 588)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(160, 45)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComplete.AutoSize = True
        Me.btnComplete.Location = New System.Drawing.Point(174, 588)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(2)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(160, 45)
        Me.btnComplete.TabIndex = 2
        Me.btnComplete.Text = "Complete"
        Me.btnComplete.UseVisualStyleBackColor = True
        '
        'tcDisplay
        '
        Me.tcDisplay.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tcDisplay.Controls.Add(Me.tpData)
        Me.tcDisplay.Controls.Add(Me.tpImage)
        Me.tcDisplay.HotTrack = True
        Me.tcDisplay.Location = New System.Drawing.Point(7, 88)
        Me.tcDisplay.Margin = New System.Windows.Forms.Padding(2)
        Me.tcDisplay.Name = "tcDisplay"
        Me.tcDisplay.SelectedIndex = 0
        Me.tcDisplay.Size = New System.Drawing.Size(810, 496)
        Me.tcDisplay.TabIndex = 3
        '
        'tpData
        '
        Me.tpData.Controls.Add(Me.webBrowser)
        Me.tpData.Location = New System.Drawing.Point(4, 29)
        Me.tpData.Margin = New System.Windows.Forms.Padding(2)
        Me.tpData.Name = "tpData"
        Me.tpData.Padding = New System.Windows.Forms.Padding(2)
        Me.tpData.Size = New System.Drawing.Size(802, 463)
        Me.tpData.TabIndex = 0
        Me.tpData.Text = "Data"
        Me.tpData.UseVisualStyleBackColor = True
        '
        'webBrowser
        '
        Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser.Location = New System.Drawing.Point(2, 2)
        Me.webBrowser.Margin = New System.Windows.Forms.Padding(2)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(15, 16)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.Size = New System.Drawing.Size(798, 459)
        Me.webBrowser.TabIndex = 0
        '
        'tpImage
        '
        Me.tpImage.Controls.Add(Me.picDrawing)
        Me.tpImage.Location = New System.Drawing.Point(4, 29)
        Me.tpImage.Margin = New System.Windows.Forms.Padding(2)
        Me.tpImage.Name = "tpImage"
        Me.tpImage.Padding = New System.Windows.Forms.Padding(2)
        Me.tpImage.Size = New System.Drawing.Size(802, 477)
        Me.tpImage.TabIndex = 1
        Me.tpImage.Text = "Drawing"
        Me.tpImage.UseVisualStyleBackColor = True
        '
        'picDrawing
        '
        Me.picDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDrawing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDrawing.Location = New System.Drawing.Point(2, 2)
        Me.picDrawing.Margin = New System.Windows.Forms.Padding(2)
        Me.picDrawing.Name = "picDrawing"
        Me.picDrawing.Size = New System.Drawing.Size(798, 473)
        Me.picDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDrawing.TabIndex = 0
        Me.picDrawing.TabStop = False
        '
        'lbTasks
        '
        Me.lbTasks.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.lbTasks.FormattingEnabled = True
        Me.lbTasks.Location = New System.Drawing.Point(73, 43)
        Me.lbTasks.Margin = New System.Windows.Forms.Padding(2)
        Me.lbTasks.Name = "lbTasks"
        Me.lbTasks.Size = New System.Drawing.Size(744, 28)
        Me.lbTasks.TabIndex = 4
        '
        'ckAutoFill
        '
        Me.ckAutoFill.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckAutoFill.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckAutoFill.Location = New System.Drawing.Point(353, 588)
        Me.ckAutoFill.Margin = New System.Windows.Forms.Padding(2)
        Me.ckAutoFill.Name = "ckAutoFill"
        Me.ckAutoFill.Size = New System.Drawing.Size(111, 45)
        Me.ckAutoFill.TabIndex = 5
        Me.ckAutoFill.Text = "Auto-Import"
        Me.ckAutoFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckAutoFill.UseVisualStyleBackColor = True
        '
        'txtFilter
        '
        Me.txtFilter.Location = New System.Drawing.Point(73, 12)
        Me.txtFilter.Name = "txtFilter"
        Me.txtFilter.Size = New System.Drawing.Size(283, 26)
        Me.txtFilter.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 20)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "RFQs:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 15)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Search:"
        '
        'ckIncComp
        '
        Me.ckIncComp.AutoSize = True
        Me.ckIncComp.Location = New System.Drawing.Point(369, 13)
        Me.ckIncComp.Name = "ckIncComp"
        Me.ckIncComp.Size = New System.Drawing.Size(168, 24)
        Me.ckIncComp.TabIndex = 9
        Me.ckIncComp.Text = "Include Completed"
        Me.ckIncComp.UseVisualStyleBackColor = True
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(566, 15)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(79, 20)
        Me.lblAge.TabIndex = 12
        Me.lblAge.Text = "Max. Age:"
        Me.lblAge.Visible = False
        '
        'lblDays
        '
        Me.lblDays.AutoSize = True
        Me.lblDays.Location = New System.Drawing.Point(717, 16)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(42, 20)
        Me.lblDays.TabIndex = 13
        Me.lblDays.Text = "days"
        Me.lblDays.Visible = False
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(647, 13)
        Me.txtAge.Maximum = New Decimal(New Integer() {180, 0, 0, 0})
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(67, 26)
        Me.txtAge.TabIndex = 14
        Me.txtAge.Value = New Decimal(New Integer() {30, 0, 0, 0})
        Me.txtAge.Visible = False
        '
        'frmWEBcnx2
        '
        Me.AcceptButton = Me.btnComplete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(828, 644)
        Me.ControlBox = False
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.ckIncComp)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFilter)
        Me.Controls.Add(Me.ckAutoFill)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lbTasks)
        Me.Controls.Add(Me.tcDisplay)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.btnCancel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.MinimumSize = New System.Drawing.Size(850, 700)
        Me.Name = "frmWEBcnx2"
        Me.Text = "frmWEBcnx2"
        Me.tcDisplay.ResumeLayout(False)
        Me.tpData.ResumeLayout(False)
        Me.tpImage.ResumeLayout(False)
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtAge, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnImport As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents btnComplete As Button
    Friend WithEvents tcDisplay As TabControl
    Friend WithEvents tpData As TabPage
    Friend WithEvents tpImage As TabPage
    Friend WithEvents lbTasks As ComboBox
    Friend WithEvents webBrowser As WebBrowser
    Friend WithEvents picDrawing As PictureBox
    Friend WithEvents ckAutoFill As CheckBox
    Friend WithEvents txtFilter As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents ckIncComp As CheckBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblDays As Label
    Friend WithEvents txtAge As NumericUpDown
End Class
