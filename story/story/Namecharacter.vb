Public Class Nameform0
    Private Sub Randomname_Click(sender As Object, e As EventArgs) Handles Randomname.Click
        Dim intuppernumber As Integer = 6

        Dim r As New Random

        Dim intRandomnumber

        intRandomnumber = r.Next(intuppernumber)

        Select Case intRandomnumber

            Case 0

                pname.Text = "Anduinn"

            Case 1

                pname.Text = "Jaina"

            Case 2

                pname.Text = "Thrall"

            Case 3

                pname.Text = "Garrosh"

            Case 4

                pname.Text = "Vilerra"

            Case 5

                pname.Text = "Ragnaros"

        End Select

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Nameinstructions.Click

    End Sub

    Private Sub Nextbuttonname_Click(sender As Object, e As EventArgs) Handles Nextbuttonname.Click
        If pname.Text = "" Then
            Enterwarn.Visible = True
        Else
            Me.Hide()
            Classetup.Show()
        End If
    End Sub
End Class