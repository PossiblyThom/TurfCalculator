Public Class Invoice
    Private Sub WindowOpen() Handles Me.Load
        TBOutWidth.Text = ""
        TBOutLength.Text = ""
        TBOutArea.Text = ""
        TBOutRollsCost.Text = "2.50"
        TBOutRolls.Text = ""
        TBOutRollsWO.Text = ""
        TBOutCostWO.Text = ""
        TBOutTotalCost.Text = ""
    End Sub

    Private Sub BTNClose_Click(sender As Object, e As EventArgs) Handles BTNClose.Click
        Me.Close()
    End Sub
End Class