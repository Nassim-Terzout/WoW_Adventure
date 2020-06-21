Public Class Welcomeform
    Private Sub Letsgo_Click(sender As Object, e As EventArgs) Handles Letsgo.Click
        If BurningSteppes.Checked = True Then
            Me.Hide()
            Deathwingdeath1.Show()
        Else
            If Goldshire.Checked = True Then
                Me.Hide()
                Ch2Goldshire.Show()
                Ch2Goldshire.outputgoldshirech2.Text = Nameform0.pname.Text & ", you've made it to Goldshire. As you are speaking with a farmer and gathering supplies the farmer tells you about Deathwing, a dragon in the Burning Steppes being of possible threat. You must protect Northshire and nearby villages. What do you do?"
            End If

        End If
    End Sub

    Private Sub northshireexit_Click(sender As Object, e As EventArgs) Handles northshireexit.Click
        Me.Close()
    End Sub

    Private Sub Northshirerestart_Click(sender As Object, e As EventArgs) Handles Northshirerestart.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub Northshirehelp_Click(sender As Object, e As EventArgs) Handles Northshirehelp.Click
        If Helplabelnorthshire.Visible = False Then
            Helplabelnorthshire.Visible = True
        Else
            If Helplabelnorthshire.Visible = True Then
                Helplabelnorthshire.Visible = False
            End If
        End If
    End Sub
End Class