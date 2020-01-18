Public Class RGIT_annual_asset_depreciation_App

    'Declaration of variables Globally'
    Dim cost, salvageVal, usefulLife As Double

    Private Sub btnDisplay_Click(sender As Object, e As EventArgs) Handles btnDisplay.Click

        'Clearing lstDdb and lstSyd respectivley'
        lstDdb.Items.Clear()
        lstSyd.Items.Clear()

        'Code to validate whether the selected number is between 10 and 35 and prompt the user to try again if not'
        If Not IsNumeric(cmbUsefulLife.Text) Then
            MessageBox.Show("That was not a valid useful life, please try selecting between 3 years and 20 years", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        ElseIf cmbUsefulLife.Text < 3 Or cmbUsefulLife.Text > 20 Then
            MessageBox.Show("That was not a valid useful life, please try selecting between 3 years and 20 years", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Assignment of information to variables passed into text boxes'
            usefulLife = cmbUsefulLife.Text
        End If

        'Code to validate whether cost entry was numeric or not and prompt user to try again'
        If Not IsNumeric(txtCost.Text) Then
            MessageBox.Show("That was not a valid entry of cost, please try again", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Assignment of information to variables passed into text boxes'
            cost = txtCost.Text
        End If

        'Code to validate whether cost entry was numeric or not and prompt user to try again'
        If Not IsNumeric(txtSalvage.Text) Then
            MessageBox.Show("That was not a valid entry of what the salvage value might be, please try again", "User error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'Assignment of information to variables passed into text boxes'
            salvageVal = txtSalvage.Text
        End If

        'placing first line of information into lstDdb and lstSyd respectivley'
        lstDdb.Items.Add("Year               Depreciation")
        lstSyd.Items.Add("Year               Depreciation")

        'iterating through a range of numbers and calculating desired output and printing it into the respective list boxes'
        For i As Double = 1 To usefulLife
            lstDdb.Items.Add(i & "                    " & String.Format("{0:0.00}", Math.Round(Financial.DDB(cost, salvageVal, usefulLife, i), 3)))
        Next
        For j As Double = 1 To usefulLife
            lstSyd.Items.Add(j & "                    " & String.Format("{0:0.00}", Math.Round(Financial.SYD(cost, salvageVal, usefulLife, j), 3)))
        Next

    End Sub

    Private Sub txtCost_TextChanged(sender As Object, e As EventArgs) Handles txtCost.TextChanged

        'code to allow enter button to be used as a click event for btnDisplay'
        AcceptButton = btnDisplay

    End Sub

    Private Sub txtSalvage_TextChanged(sender As Object, e As EventArgs) Handles txtSalvage.TextChanged

        'code to allow enter button to be used as a click event for btnDisplay'
        AcceptButton = btnDisplay

    End Sub

    Private Sub cmbUsefulLife_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUsefulLife.SelectedIndexChanged

        'code to allow enter button to be used as a click event for btnDisplay'
        AcceptButton = btnDisplay

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        'code to close the application'
        Me.Close()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
