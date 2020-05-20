Public Class Form1
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txtA.Clear()
        txtB.Clear()
        txtC.Clear()
        lblA.Text = ""
        lblB.Text = ""
        lblC.Text = ""
        lblRevenue.Text = ""
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim valueA As Decimal
        Dim valueB As Decimal
        Dim valueC As Decimal
        Dim total As Decimal

        Try
            valueA = CDec(txtA.Text) * 15
            valueB = CDec(txtB.Text) * 12
            valueC = CDec(txtC.Text) * 9
            total = valueA + valueB + valueC

            lblA.Text = valueA.ToString("c")
            lblB.Text = valueB.ToString("c")
            lblC.Text = valueC.ToString("c")
            lblRevenue.Text = total.ToString("c")
        Catch
            MessageBox.Show("Please enter a number. Do not specify any other character.")
        End Try

    End Sub
End Class
