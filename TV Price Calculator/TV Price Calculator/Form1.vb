Public Class Form1
    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        Dim intNumUnits As Integer = Val(txtNumUnits.Text)
        Dim intPrice As Integer

        If intNumUnits <= 0 Then
            MsgBox("Please input the number of units you wish to purchase.")
            txtNumUnits.Focus()
            Return
        End If

        Select Case cbxCategory.SelectedIndex
            Case 0
                intPrice = intNumUnits * 100
            Case 1
                intPrice = intNumUnits * 500
            Case 2
                intPrice = intNumUnits * 1000
            Case Else
                MsgBox("Please select a size category.")
                cbxCategory.Focus()
                Return
        End Select

        lstDisplay.Items.Add("You wish to purchase " & intNumUnits & " units.")
        lstDisplay.Items.Add("Your selected size category is " & cbxCategory.SelectedItem & ".")
        lstDisplay.Items.Add("The total price of your selection is $" & intPrice & ".")
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtNumUnits.Clear()
        cbxCategory.SelectedIndex = -1
        lstDisplay.Items.Clear()
        txtNumUnits.Focus()
    End Sub
End Class
