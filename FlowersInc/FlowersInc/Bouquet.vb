'Declare module to hold global variables so they can be used across all forms 
Module Globals
    Public flowers, accents, containers As Double 
    Public Total, Tax, FinalTax As Double
End Module



Public Class Bouquet
    Private Sub btnConfirm2_Click(sender As Object, e As EventArgs) Handles btnConfirm2.Click
        'Decalre variables
        Dim flowers, accents, containers As Double
        Dim quantity As Integer
        Dim type As String

        'Initialize the variables and display to list box          
        flowers = 0
        accents = 0
        containers = 0
        quantity = CInt(txtQuantity.Text)
        type = txtType.Text
        lstTotal2.Items.Add("You have selected the following items:")

        'Check the type of flowers
        If (type = "Roses") Then
            lstTotal2.Items.Add("Roses - $2.80/Flower")
            flowers = flowers + 2.25
        End If

        If (type = "Daisies") Then
            lstTotal2.Items.Add("Daisies - $2.00/Flower")
            flowers = flowers + 2.0
        End If

        If (type = "Hydrangeas") Then
            lstTotal2.Items.Add("Haydrangeas - $5.00/Flower")
            flowers = flowers + 5.0
        End If

        If (type = "Lillies") Then
            lstTotal2.Items.Add("Lillies - $3.00/Flower")
            flowers = flowers + 3.0
        End If

        'Check for accents that are selected 
        If (chkMini.Checked = True) Then
            lstTotal2.Items.Add("Mini Spray Roses - $2.65")
            accents = accents + 2.65
        End If
        If (chkBabys.Checked = True) Then
            lstTotal2.Items.Add("Baby's Breath - $1.50")
            accents = accents + 1.5
        End If
        If (chkLeather.Checked = True) Then
            lstTotal2.Items.Add("Leather Leaf Fern - $1.25")
            accents = accents + 1.25
        End If

        'Check for containers that are selected 
        If (radVase.Checked = True) Then
            lstTotal2.Items.Add("Vase - $6.00")
            containers = containers + 6.0
        End If
        If (radMason.Checked = True) Then
            lstTotal2.Items.Add("Mason Jar - $4.00")
            containers = containers + 4.0
        End If
        If (radBasket.Checked = True) Then
            lstTotal2.Items.Add("Basket - $8.00")
            containers = containers + 8.0
        End If



        'Declare and initialize total, tax varaibles and display to list box 
        Const Tax As Double = 0.08875
        Dim SubTotal As Double
        SubTotal = (flowers * quantity) + (accents + containers)
        FinalTax = (SubTotal * Tax)
        Total = SubTotal + FinalTax
        lstTotal2.Items.Add("SubTotal: " & FormatCurrency(SubTotal, 2))
        lstTotal2.Items.Add("Tax: " & FormatCurrency(FinalTax, 2))
        lstTotal2.Items.Add("Total: " & FormatCurrency(Total, 2))

    End Sub

    'Go to checkout form 
    Private Sub btnCheckout_Click(sender As Object, e As EventArgs) Handles btnCheckout.Click
        Me.Close()
        Checkout.Show()
    End Sub

    'Clear all items from list box 
    Private Sub btnClear2_Click(sender As Object, e As EventArgs) Handles btnClear2.Click
        txtType.Clear()
        txtQuantity.Clear()
        chkMini.Checked = False
        chkBabys.Checked = False
        chkLeather.Checked = False
        radVase.Checked = False
        radMason.Checked = False
        radBasket.Checked = False
        lstTotal2.Items.Clear()

    End Sub
End Class