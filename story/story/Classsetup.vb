Public Class Classetup
    Private Sub Randomname_Click(sender As Object, e As EventArgs) Handles ClassRandomizer.Click
        Dim intuppernumber As Integer = 10

        Dim r As New Random

        Dim intRandomnumber

        intRandomnumber = r.Next(intuppernumber)

        Select Case intRandomnumber

            Case 0

                pClass.Text = "Mage"

            Case 1

                pClass.Text = "Shaman"

            Case 2

                pClass.Text = "Druid"

            Case 3

                pClass.Text = "Rogue"

            Case 4

                pClass.Text = "Paladin"

            Case 5

                pClass.Text = "Priest"

            Case 6

                pClass.Text = "Hunter"

            Case 7

                pClass.Text = "Warlock"


            Case 8

                pClass.Text = "Warrior"

        End Select
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Owta.Click
        If LCase(pClass.Text) = "priest" Or LCase(pClass.Text) = "rogue" Or LCase(pClass.Text) = "paladin" Or LCase(pClass.Text) = "warlock" Or LCase(pClass.Text) = "warrior" Or LCase(pClass.Text) = "hunter" Or LCase(pClass.Text) = "druid" Or LCase(pClass.Text) = "shaman" Or LCase(pClass.Text) = "mage" Then
            Me.Hide()
            Welcomeform.Show()
            Welcomeform.textforchp1.Text = "You are " & Nameform0.pname.Text & " a " & Me.pClass.Text & " located in Northshire. You must scavenge supplies for the people of Northshire. Where do you go? "
        Else
            classwarn.Visible = True
        End If
    End Sub

    Private Sub backbuttoncs_Click(sender As Object, e As EventArgs) Handles backbuttoncs.Click
        Me.Hide()
        Nameform0.Show()
    End Sub
End Class