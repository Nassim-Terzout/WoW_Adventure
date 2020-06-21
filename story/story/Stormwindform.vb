Public Class Stormwindform
    Private Sub Letsgo3_Click(sender As Object, e As EventArgs) Handles Letsgo3.Click
        If Burningsteppes2.Checked = True Then
            Me.Hide()
            Deathwingending.Show()
            Deathwingending.endingtext.Text = "Well done " & Nameform0.pname.Text & ". After using the Stormwind potion and fighting with your army, you have managed to defeat Deathwing one of the greatest dragons to have ever exsisted! Northshire and nearby villages can now rest free of this beast thanks to your efforts."
        Else
            If Westfall.Checked = True Then
                Me.Hide()
                Westfallform.Show()
            End If
        End If
    End Sub

    Private Sub Stormwindexit_Click(sender As Object, e As EventArgs) Handles Stormwindexit.Click
        Me.Close()
    End Sub

    Private Sub mainmenustormwind_Click(sender As Object, e As EventArgs) Handles mainmenustormwind.Click
        Me.Hide()
        Mainform.Show()
    End Sub

    Private Sub Help_Click(sender As Object, e As EventArgs) Handles Help.Click
        If Helplabelstormwind.Visible = False Then
            Helplabelstormwind.Visible = True
        Else
            If Helplabelstormwind.Visible = True Then
                Helplabelstormwind.Visible = False
            End If
        End If
    End Sub
End Class