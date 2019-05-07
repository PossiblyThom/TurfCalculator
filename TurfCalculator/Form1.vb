Public Class Form1
    'This block declares the necessary variables
    Dim _l As Decimal
    Dim _w As Decimal
    Dim _a As Decimal
    Dim _tempVar As Decimal
    Dim _tempVar2 As Int64
    Dim _costWo As Decimal
    Dim _totalRolls As Int64
    Dim _totalCost As Decimal

    'This subroutine performs the calculations
    Private Sub Calculate()
        Try 'This Try statement runs all the code for the calculations inside itself, and if any errors happen they are caught and
            'execution of the subroutine stops
            _l = TBInLength.Text 'Sets L to the value of the Length Input text box
            _w = TBInWidth.Text 'Sets W to the value of the Width Input text box
            _a = (_l * _w) 'Calculates the area by multiplying L and W
            Invoice.Show()
            Invoice.TBOutLength.Text = _l
            Invoice.TBOutWidth.Text = _w
            Invoice.TBOutArea.Text = _a
            _tempVar = (_a * 1.67) 'Sets the temporary variable to A multiplied by 1.67 - the number of rolls (not integral) required to cover the area
            _tempVar2 = Math.Ceiling(_tempVar) 'Rounds the number of rolls required (without the extra 10%) to the nearest integral value
            _costWo = _tempVar2 * 2.5 'Calculates the cost without the extra 10% for wastage
            Invoice.TBOutRollsWO.Text = _tempVar2
            Invoice.TBOutCostWO.Text = (_costWo.ToString("0.00")) 'Outputs the cost without the extra 10% and formats it like you would expect to see a currency
            _tempVar = _tempVar * 1.1 'Sets the temporary variable to the number of rolls +10% allowance for wastage
            _totalRolls = Math.Ceiling(_tempVar)  'Rounds the number of rolls +10% to the next integer and sets the _totalRolls variable to that value
            Invoice.TBOutRolls.Text = _totalRolls
            Invoice.TBOutRollsWO.Text = _totalRolls 'Outputs the total number of rolls required
            _totalCost = (_totalRolls * 2.5) 'Calculates the total cost of the rolls with the +10% wastage
            Invoice.TBOutTotalCost.Text = (_totalCost.ToString("0.00")) 'Outputs the cost with the +10% and formats it like you would expect to see a currency
        Catch ex As OverflowException 'This Catch statement is part of the Try statement. If an overflow exception happens,
            '                                 it shows the user a message and the subroutine execution stops.
            MessageBox.Show("A number got too big - try entering something smaller.")
            Exit Sub
        End Try
    End Sub

    'The following subroutine performs validation checks to ensure that a numeric value was entered
    Private Sub Validation(sender As Object, e As EventArgs) Handles Button.Click
        Dim lBool As Boolean
        Dim wBool As Boolean
        lBool = IsNumeric(TBInLength.Text) 'Performs a check to see if the value of the Length input text box is numeric. If so, LBool is set to True. If not, False.
        wBool = IsNumeric(TBInWidth.Text) 'Performs a check to see if the value of the Width input text box is numeric. If so, wBool is set to True. If not, False.
        If lBool = True Then
            If wBool = True Then
                Call Calculate() 'Calls the Calculate function
            Else
                MsgBox("Please enter a numeric value in Width") 'Displays an error message to the user
            End If
        Else
            MsgBox("Please enter a numeric value in Length") 'Displays an error message to the user
        End If
    End Sub

    Private Sub InvoiceClear(sender As Object, e As EventArgs)

    End Sub
End Class