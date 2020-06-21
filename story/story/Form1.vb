Public Class Mainform
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Startbutton.Click
        Me.Hide()
        Nameform0.Show()


    End Sub

    Private Sub Instructionslabelf1_Click(sender As Object, e As EventArgs) Handles Instructionslabelf1.Click
        Me.Hide()
        Instructionsf1.Show()

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub
End Class
