Public Class Quiz
    Private Sub btnConfirm_Click(sender As Object, e As EventArgs) Handles btnConfirm.Click

        'Declare and initialize variables
        Dim Name As String
        Name = txtName.Text


        If (radRoses.Checked = True) Then
            lstOut.Items.Add(Name & "You have selected Roses.")
            lstOut.Items.Add("This means you think with your heart and know how to make a statement.")
            picRoses.Visible = True
        ElseIf (radTulips.Checked = True) Then
            lstOut.Items.Add(Name & "You have selected Tulips.")
            lstOut.Items.Add("This means that you are thoughtful and confident and are always coordinated.")
            picTulips.Visible = True
        ElseIf (radDaisies.Checked = True) Then
            lstOut.Items.Add(Name & "You have selected Daisies.")
            lstOut.Items.Add("This mean that you are an optimist who can find the good in any bad situation.")
            picDaisies.Visible = True
        ElseIf (radDaffodils.Checked = True) Then
            lstOut.Items.Add(Name & "You have selected Daffodils.")
            lstOut.Items.Add("This means that you are fun and laid-back and always put friends and family first.")
            picDaffodils.Visible = True
        ElseIf (radSunflowers.Checked = True) Then
            lstOut.Items.Add(Name & "You have selected Sunflowers.")
            lstOut.Items.Add("This means that you love to be around people and make new friends.")
            picSunflowers.Visible = True
        ElseIf (radLilies.Checked = True) Then
            lstOut.Items.Add(Name & "You have selected Lillies.")
            lstOut.Items.Add("This means that you are a heard worker and proud of all you accomplish.")
            picLillies.Visible = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        lstOut.Items.Clear()
        txtName.Clear()
        radRoses.Checked = False
        radTulips.Checked = False
        radDaisies.Checked = False
        radDaffodils.Checked = False
        radSunflowers.Checked = False
        radLilies.Checked = False
        picRoses.Visible = False
        picTulips.Visible = False
        picDaisies.Visible = False
        picDaffodils.Visible = False
        picSunflowers.Visible = False
        picLillies.Visible = False

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class