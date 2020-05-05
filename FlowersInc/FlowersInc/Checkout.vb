Public Class Checkout
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click
        'Declare and initialize variables 
        Dim FirstName, LastName, Address, State, City, ZipCode As String

        FirstName = txtFirst.Text
        LastName = txtLast.Text
        Address = txtAddress.Text
        State = txtState.Text
        City = txtCity.Text
        ZipCode = txtZip.Text

        'Display summary of order to list box 
        lstCheckout.Items.Add(FirstName & ":" & "Thank you for purchasing from Flower's Inc.")
        lstCheckout.Items.Add("Your total is: " & FormatCurrency(Total, 2))
        lstCheckout.Items.Add("Your order is now being processed and will be shipped to: ")
        lstCheckout.Items.Add(FirstName & LastName)
        lstCheckout.Items.Add(Address & City & State & "," & ZipCode)

    End Sub

    'Exit application when user clicks exit
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Application.Exit()
    End Sub

    'Return to main menu when user click back to main menu
    Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
        Me.Close()
        MainMenu.Show()
    End Sub
End Class