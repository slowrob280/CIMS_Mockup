<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmWEBcnx
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmWEBcnx))
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
        Me.tcDisplay.SuspendLayout()
        Me.tpData.SuspendLayout()
        Me.tpImage.SuspendLayout()
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnImport
        '
        Me.btnImport.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnImport.Location = New System.Drawing.Point(10, 590)
        Me.btnImport.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnImport.Name = "btnImport"
        Me.btnImport.Size = New System.Drawing.Size(503, 53)
        Me.btnImport.TabIndex = 0
        Me.btnImport.Text = "Import"
        Me.btnImport.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(10, 648)
        Me.btnCancel.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(169, 45)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnComplete
        '
        Me.btnComplete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnComplete.AutoSize = True
        Me.btnComplete.Location = New System.Drawing.Point(352, 648)
        Me.btnComplete.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.btnComplete.Name = "btnComplete"
        Me.btnComplete.Size = New System.Drawing.Size(161, 45)
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
        Me.tcDisplay.Location = New System.Drawing.Point(9, 41)
        Me.tcDisplay.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tcDisplay.Name = "tcDisplay"
        Me.tcDisplay.SelectedIndex = 0
        Me.tcDisplay.Size = New System.Drawing.Size(967, 545)
        Me.tcDisplay.TabIndex = 3
        '
        'tpData
        '
        Me.tpData.Controls.Add(Me.webBrowser)
        Me.tpData.Location = New System.Drawing.Point(4, 29)
        Me.tpData.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpData.Name = "tpData"
        Me.tpData.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpData.Size = New System.Drawing.Size(959, 512)
        Me.tpData.TabIndex = 0
        Me.tpData.Text = "Data"
        Me.tpData.UseVisualStyleBackColor = True
        '
        'webBrowser
        '
        Me.webBrowser.Dock = System.Windows.Forms.DockStyle.Fill
        Me.webBrowser.Location = New System.Drawing.Point(2, 2)
        Me.webBrowser.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.webBrowser.MinimumSize = New System.Drawing.Size(15, 16)
        Me.webBrowser.Name = "webBrowser"
        Me.webBrowser.Size = New System.Drawing.Size(955, 508)
        Me.webBrowser.TabIndex = 0
        '
        'tpImage
        '
        Me.tpImage.Controls.Add(Me.picDrawing)
        Me.tpImage.Location = New System.Drawing.Point(4, 29)
        Me.tpImage.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpImage.Name = "tpImage"
        Me.tpImage.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.tpImage.Size = New System.Drawing.Size(959, 512)
        Me.tpImage.TabIndex = 1
        Me.tpImage.Text = "Drawing"
        Me.tpImage.UseVisualStyleBackColor = True
        '
        'picDrawing
        '
        Me.picDrawing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picDrawing.Dock = System.Windows.Forms.DockStyle.Fill
        Me.picDrawing.Location = New System.Drawing.Point(2, 2)
        Me.picDrawing.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.picDrawing.Name = "picDrawing"
        Me.picDrawing.Size = New System.Drawing.Size(955, 508)
        Me.picDrawing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDrawing.TabIndex = 0
        Me.picDrawing.TabStop = False
        '
        'lbTasks
        '
        Me.lbTasks.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbTasks.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest
        Me.lbTasks.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.lbTasks.DisplayMember = "erfrf"
        Me.lbTasks.FormattingEnabled = True
        Me.lbTasks.Location = New System.Drawing.Point(9, 10)
        Me.lbTasks.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.lbTasks.Name = "lbTasks"
        Me.lbTasks.Size = New System.Drawing.Size(968, 28)
        Me.lbTasks.TabIndex = 4
        '
        'ckAutoFill
        '
        Me.ckAutoFill.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.ckAutoFill.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckAutoFill.Location = New System.Drawing.Point(182, 648)
        Me.ckAutoFill.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ckAutoFill.Name = "ckAutoFill"
        Me.ckAutoFill.Size = New System.Drawing.Size(166, 45)
        Me.ckAutoFill.TabIndex = 5
        Me.ckAutoFill.Text = "Auto-Import"
        Me.ckAutoFill.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ckAutoFill.UseVisualStyleBackColor = True
        '
        'frmWEBcnx
        '
        Me.AcceptButton = Me.btnComplete
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(985, 699)
        Me.ControlBox = False
        Me.Controls.Add(Me.ckAutoFill)
        Me.Controls.Add(Me.btnImport)
        Me.Controls.Add(Me.lbTasks)
        Me.Controls.Add(Me.tcDisplay)
        Me.Controls.Add(Me.btnComplete)
        Me.Controls.Add(Me.btnCancel)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.MinimumSize = New System.Drawing.Size(546, 469)
        Me.Name = "frmWEBcnx"
        Me.Text = "frmWEBcnx"
        Me.tcDisplay.ResumeLayout(False)
        Me.tpData.ResumeLayout(False)
        Me.tpImage.ResumeLayout(False)
        CType(Me.picDrawing, System.ComponentModel.ISupportInitialize).EndInit()
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
End Class
