Public Class Form1
    Private Sub TMRGen_Tick(sender As Object, e As EventArgs) Handles TMRGen.Tick
        REDCLR.Text = TBRed.Value
        BLUCLR.Text = TBBlu.Value
        GRNCLR.Text = TBGre.Value
        Dim red1, blue1, green1 As Integer
        red1 = REDCLR.Text
        green1 = GRNCLR.Text
        blue1 = BLUCLR.Text
        Me.BackColor = Color.FromArgb(red1, blue1, green1)
    End Sub
End Class
