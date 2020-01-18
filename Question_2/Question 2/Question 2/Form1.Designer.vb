<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RGIT_annual_asset_depreciation_App
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
        Me.lblAssetCost = New System.Windows.Forms.Label()
        Me.lblSalvageValue = New System.Windows.Forms.Label()
        Me.lblUsefulLife = New System.Windows.Forms.Label()
        Me.lblDepreciationSchedules = New System.Windows.Forms.Label()
        Me.lblDdb = New System.Windows.Forms.Label()
        Me.lblSyd = New System.Windows.Forms.Label()
        Me.lstDdb = New System.Windows.Forms.ListBox()
        Me.lstSyd = New System.Windows.Forms.ListBox()
        Me.txtCost = New System.Windows.Forms.TextBox()
        Me.txtSalvage = New System.Windows.Forms.TextBox()
        Me.cmbUsefulLife = New System.Windows.Forms.ComboBox()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblAssetCost
        '
        Me.lblAssetCost.AutoSize = True
        Me.lblAssetCost.Location = New System.Drawing.Point(80, 81)
        Me.lblAssetCost.Name = "lblAssetCost"
        Me.lblAssetCost.Size = New System.Drawing.Size(118, 25)
        Me.lblAssetCost.TabIndex = 0
        Me.lblAssetCost.Text = "Asset cost:"
        '
        'lblSalvageValue
        '
        Me.lblSalvageValue.AutoSize = True
        Me.lblSalvageValue.Location = New System.Drawing.Point(44, 182)
        Me.lblSalvageValue.Name = "lblSalvageValue"
        Me.lblSalvageValue.Size = New System.Drawing.Size(154, 25)
        Me.lblSalvageValue.TabIndex = 2
        Me.lblSalvageValue.Text = "Salvage value:"
        '
        'lblUsefulLife
        '
        Me.lblUsefulLife.AutoSize = True
        Me.lblUsefulLife.Location = New System.Drawing.Point(91, 288)
        Me.lblUsefulLife.Name = "lblUsefulLife"
        Me.lblUsefulLife.Size = New System.Drawing.Size(113, 25)
        Me.lblUsefulLife.TabIndex = 4
        Me.lblUsefulLife.Text = "Useful life:"
        '
        'lblDepreciationSchedules
        '
        Me.lblDepreciationSchedules.AutoSize = True
        Me.lblDepreciationSchedules.Location = New System.Drawing.Point(563, 81)
        Me.lblDepreciationSchedules.Name = "lblDepreciationSchedules"
        Me.lblDepreciationSchedules.Size = New System.Drawing.Size(237, 25)
        Me.lblDepreciationSchedules.TabIndex = 6
        Me.lblDepreciationSchedules.Text = "Depreciation schedules"
        '
        'lblDdb
        '
        Me.lblDdb.AutoSize = True
        Me.lblDdb.Location = New System.Drawing.Point(609, 176)
        Me.lblDdb.Name = "lblDdb"
        Me.lblDdb.Size = New System.Drawing.Size(272, 25)
        Me.lblDdb.TabIndex = 7
        Me.lblDdb.Text = "Double-declining balances:"
        '
        'lblSyd
        '
        Me.lblSyd.AutoSize = True
        Me.lblSyd.Location = New System.Drawing.Point(974, 182)
        Me.lblSyd.Name = "lblSyd"
        Me.lblSyd.Size = New System.Drawing.Size(244, 25)
        Me.lblSyd.TabIndex = 9
        Me.lblSyd.Text = "Sum-of-the-year's digits:"
        '
        'lstDdb
        '
        Me.lstDdb.FormattingEnabled = True
        Me.lstDdb.ItemHeight = 25
        Me.lstDdb.Location = New System.Drawing.Point(614, 210)
        Me.lstDdb.Name = "lstDdb"
        Me.lstDdb.Size = New System.Drawing.Size(316, 279)
        Me.lstDdb.TabIndex = 8
        '
        'lstSyd
        '
        Me.lstSyd.FormattingEnabled = True
        Me.lstSyd.ItemHeight = 25
        Me.lstSyd.Location = New System.Drawing.Point(979, 210)
        Me.lstSyd.Name = "lstSyd"
        Me.lstSyd.Size = New System.Drawing.Size(316, 279)
        Me.lstSyd.TabIndex = 10
        '
        'txtCost
        '
        Me.txtCost.Location = New System.Drawing.Point(204, 75)
        Me.txtCost.Name = "txtCost"
        Me.txtCost.Size = New System.Drawing.Size(178, 31)
        Me.txtCost.TabIndex = 1
        '
        'txtSalvage
        '
        Me.txtSalvage.Location = New System.Drawing.Point(204, 176)
        Me.txtSalvage.Name = "txtSalvage"
        Me.txtSalvage.Size = New System.Drawing.Size(178, 31)
        Me.txtSalvage.TabIndex = 3
        '
        'cmbUsefulLife
        '
        Me.cmbUsefulLife.FormattingEnabled = True
        Me.cmbUsefulLife.Items.AddRange(New Object() {"3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15", "16", "17", "18", "19", "20"})
        Me.cmbUsefulLife.Location = New System.Drawing.Point(204, 280)
        Me.cmbUsefulLife.Name = "cmbUsefulLife"
        Me.cmbUsefulLife.Size = New System.Drawing.Size(178, 33)
        Me.cmbUsefulLife.TabIndex = 5
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(49, 409)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(229, 80)
        Me.btnDisplay.TabIndex = 11
        Me.btnDisplay.Text = "&Display depreciation schedules"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(298, 409)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(135, 80)
        Me.btnExit.TabIndex = 12
        Me.btnExit.Text = "&Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'RGIT_annual_asset_depreciation_App
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1395, 611)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.cmbUsefulLife)
        Me.Controls.Add(Me.txtSalvage)
        Me.Controls.Add(Me.txtCost)
        Me.Controls.Add(Me.lstSyd)
        Me.Controls.Add(Me.lstDdb)
        Me.Controls.Add(Me.lblSyd)
        Me.Controls.Add(Me.lblDdb)
        Me.Controls.Add(Me.lblDepreciationSchedules)
        Me.Controls.Add(Me.lblUsefulLife)
        Me.Controls.Add(Me.lblSalvageValue)
        Me.Controls.Add(Me.lblAssetCost)
        Me.Name = "RGIT_annual_asset_depreciation_App"
        Me.Text = "RGIT annual asset depreciation App."
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAssetCost As Label
    Friend WithEvents lblSalvageValue As Label
    Friend WithEvents lblUsefulLife As Label
    Friend WithEvents lblDepreciationSchedules As Label
    Friend WithEvents lblDdb As Label
    Friend WithEvents lblSyd As Label
    Friend WithEvents lstDdb As ListBox
    Friend WithEvents lstSyd As ListBox
    Friend WithEvents txtCost As TextBox
    Friend WithEvents txtSalvage As TextBox
    Friend WithEvents cmbUsefulLife As ComboBox
    Friend WithEvents btnDisplay As Button
    Friend WithEvents btnExit As Button
End Class
