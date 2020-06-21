Public Class Ch2Goldshire
    Private Sub Letsgo2_Click(sender As Object, e As EventArgs) Handles Letsgo2.Click
        If Stormwind.Checked = True Then
            Me.Hide()
            Stormwindform.Show()
            Stormwindform.outputstormwind.Text = Nameform0.pname.Text & " you've just reached the gates of Stormwind. The leader of Stormwind is calling your name. He says he is worried about Deathwing in the Burning Steppes and needs your help to take him down. He gathers his army, hands you a powerful potion and leaves you in charge. " & Nameform0.pname.Text & ", what should you do?"
        Else
            If eastvale.Checked = True Then
                Me.Hide()
                Eastvaledeath.Show()
            End If
        End If
    End Sub

    Private Sub goldshireexit_Click(sender As Object, e As EventArgs) Handles goldshireexit.Click
        Me.Close()
    End Sub

    Private Sub goldshirerestart_Click(sender As Object, e As EventArgs) Handles goldshirerestart.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub goldshirehelp_Click(sender As Object, e As EventArgs) Handles goldshirehelp.Click
        If Helplabelgoldshire.Visible = False Then
            Helplabelgoldshire.Visible = True
        Else
            If Helplabelgoldshire.Visible = True Then
                Helplabelgoldshire.Visible = False
            End If
        End If
    End Sub
End Class