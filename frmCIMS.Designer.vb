<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmCIMS
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCIMS))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblCustomer = New System.Windows.Forms.Label()
        Me.lblCustID = New System.Windows.Forms.Label()
        Me.lblShipTo = New System.Windows.Forms.Label()
        Me.lblL = New System.Windows.Forms.Label()
        Me.lblW = New System.Windows.Forms.Label()
        Me.lblD = New System.Windows.Forms.Label()
        Me.lblWidth = New System.Windows.Forms.Label()
        Me.lblLength = New System.Windows.Forms.Label()
        Me.dgvPrint = New System.Windows.Forms.DataGridView()
        Me.clmPct = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.clmInk = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ckWEBcnx = New System.Windows.Forms.CheckBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(940, 828)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'lblCustomer
        '
        Me.lblCustomer.BackColor = System.Drawing.Color.White
        Me.lblCustomer.Enabled = False
        Me.lblCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCustomer.Location = New System.Drawing.Point(171, 160)
        Me.lblCustomer.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustomer.Name = "lblCustomer"
        Me.lblCustomer.Size = New System.Drawing.Size(314, 30)
        Me.lblCustomer.TabIndex = 1
        '
        'lblCustID
        '
        Me.lblCustID.BackColor = System.Drawing.Color.Yellow
        Me.lblCustID.Enabled = False
        Me.lblCustID.Location = New System.Drawing.Point(100, 240)
        Me.lblCustID.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblCustID.Name = "lblCustID"
        Me.lblCustID.Size = New System.Drawing.Size(352, 24)
        Me.lblCustID.TabIndex = 2
        '
        'lblShipTo
        '
        Me.lblShipTo.BackColor = System.Drawing.Color.White
        Me.lblShipTo.Enabled = False
        Me.lblShipTo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.125!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblShipTo.Location = New System.Drawing.Point(618, 162)
        Me.lblShipTo.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblShipTo.Name = "lblShipTo"
        Me.lblShipTo.Size = New System.Drawing.Size(263, 26)
        Me.lblShipTo.TabIndex = 3
        '
        'lblL
        '
        Me.lblL.BackColor = System.Drawing.Color.Yellow
        Me.lblL.Enabled = False
        Me.lblL.Location = New System.Drawing.Point(397, 359)
        Me.lblL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblL.Name = "lblL"
        Me.lblL.Size = New System.Drawing.Size(74, 23)
        Me.lblL.TabIndex = 4
        '
        'lblW
        '
        Me.lblW.BackColor = System.Drawing.Color.Yellow
        Me.lblW.Enabled = False
        Me.lblW.Location = New System.Drawing.Point(397, 407)
        Me.lblW.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblW.Name = "lblW"
        Me.lblW.Size = New System.Drawing.Size(74, 23)
        Me.lblW.TabIndex = 5
        '
        'lblD
        '
        Me.lblD.BackColor = System.Drawing.Color.Yellow
        Me.lblD.Enabled = False
        Me.lblD.Location = New System.Drawing.Point(397, 455)
        Me.lblD.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblD.Name = "lblD"
        Me.lblD.Size = New System.Drawing.Size(74, 23)
        Me.lblD.TabIndex = 6
        '
        'lblWidth
        '
        Me.lblWidth.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblWidth.Enabled = False
        Me.lblWidth.Location = New System.Drawing.Point(698, 360)
        Me.lblWidth.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblWidth.Name = "lblWidth"
        Me.lblWidth.Size = New System.Drawing.Size(74, 23)
        Me.lblWidth.TabIndex = 7
        '
        'lblLength
        '
        Me.lblLength.BackColor = System.Drawing.Color.WhiteSmoke
        Me.lblLength.Enabled = False
        Me.lblLength.Location = New System.Drawing.Point(698, 408)
        Me.lblLength.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblLength.Name = "lblLength"
        Me.lblLength.Size = New System.Drawing.Size(74, 23)
        Me.lblLength.TabIndex = 9
        '
        'dgvPrint
        '
        Me.dgvPrint.AllowUserToDeleteRows = False
        Me.dgvPrint.ColumnHeadersHeight = 30
        Me.dgvPrint.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.dgvPrint.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.clmPct, Me.clmInk})
        Me.dgvPrint.Enabled = False
        Me.dgvPrint.Location = New System.Drawing.Point(218, 618)
        Me.dgvPrint.Margin = New System.Windows.Forms.Padding(2)
        Me.dgvPrint.Name = "dgvPrint"
        Me.dgvPrint.ReadOnly = True
        Me.dgvPrint.RowHeadersVisible = False
        Me.dgvPrint.RowTemplate.Height = 20
        Me.dgvPrint.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvPrint.Size = New System.Drawing.Size(294, 170)
        Me.dgvPrint.TabIndex = 10
        '
        'clmPct
        '
        Me.clmPct.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None
        Me.clmPct.HeaderText = "% Cov."
        Me.clmPct.MinimumWidth = 70
        Me.clmPct.Name = "clmPct"
        Me.clmPct.ReadOnly = True
        Me.clmPct.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmPct.Width = 70
        '
        'clmInk
        '
        Me.clmInk.HeaderText = "Ink"
        Me.clmInk.MinimumWidth = 224
        Me.clmInk.Name = "clmInk"
        Me.clmInk.ReadOnly = True
        Me.clmInk.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.clmInk.Width = 224
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(423, 284)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(89, 30)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "WEBcnx"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ckWEBcnx
        '
        Me.ckWEBcnx.Appearance = System.Windows.Forms.Appearance.Button
        Me.ckWEBcnx.AutoSize = True
        Me.ckWEBcnx.Location = New System.Drawing.Point(297, 284)
        Me.ckWEBcnx.Margin = New System.Windows.Forms.Padding(2)
        Me.ckWEBcnx.Name = "ckWEBcnx"
        Me.ckWEBcnx.Size = New System.Drawing.Size(121, 30)
        Me.ckWEBcnx.TabIndex = 11
        Me.ckWEBcnx.Text = "WEBcnx Spec"
        Me.ckWEBcnx.UseVisualStyleBackColor = True
        Me.ckWEBcnx.Visible = False
        '
        'frmCIMS
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(940, 828)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.ckWEBcnx)
        Me.Controls.Add(Me.dgvPrint)
        Me.Controls.Add(Me.lblLength)
        Me.Controls.Add(Me.lblWidth)
        Me.Controls.Add(Me.lblD)
        Me.Controls.Add(Me.lblW)
        Me.Controls.Add(Me.lblL)
        Me.Controls.Add(Me.lblShipTo)
        Me.Controls.Add(Me.lblCustID)
        Me.Controls.Add(Me.lblCustomer)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "frmCIMS"
        Me.Text = "Spec Maintenance (Integration Mockup)"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPrint, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents lblCustomer As Label
    Friend WithEvents lblCustID As Label
    Friend WithEvents lblShipTo As Label
    Friend WithEvents lblL As Label
    Friend WithEvents lblW As Label
    Friend WithEvents lblD As Label
    Friend WithEvents lblWidth As Label
    Friend WithEvents lblLength As Label
    Friend WithEvents dgvPrint As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents ckWEBcnx As CheckBox
    Friend WithEvents clmPct As DataGridViewTextBoxColumn
    Friend WithEvents clmInk As DataGridViewTextBoxColumn
End Class
