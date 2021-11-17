Public Class Form1

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles twetip.Click 'twenty percent tip
        Dim subtotal As Decimal
        Decimal.TryParse(subtext.Text, subtotal)
        Dim tip As Decimal 'declares as needed

        tip = (subtotal * 0.2)
        Dim fc = (subtotal + tip)

        'tells the strings to go display on the labels
        'Convert tipTotal to string 
        tip = Convert.ToString(tip)
        fc = Convert.ToString(fc)




        'Chnage the text to a currency string
        tipam.Text = tip.ToString("C2")
        tc.Text = fc.ToString("C2")
    End Sub

    Private Sub fiftip_Click(sender As Object, e As EventArgs) Handles fiftip.Click '15 percent tip
        Dim subtotal As Decimal
        Decimal.TryParse(subtext.Text, subtotal)
        Dim tip As Decimal 'declares as needed
        tip = (subtotal * 0.15)
        Dim fc = (subtotal + tip)

        'tells the strings to go display on the labels
        'Convert tipTotal to string 
        tip = Convert.ToString(tip)
        fc = Convert.ToString(fc)




        'Chnage the text to a currency string
        tipam.Text = tip.ToString("C2")
        tc.Text = fc.ToString("C2")
    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub custpi_Click(sender As Object, e As EventArgs) Handles custpi.Click
        Dim subtotal As Decimal
        Decimal.TryParse(subtext.Text, subtotal)
        Dim tip As Decimal
        Dim custip = Val(cusam.Text)

        tip = (subtotal * custip)
        Dim fc = (subtotal + tip)

        'tells the strings to go display on the labels
        'Convert tipTotal to string 
        tip = Convert.ToString(tip)
        fc = Convert.ToString(fc)




        'Chnage the text to a currency string
        tipam.Text = tip.ToString("C2")
        tc.Text = fc.ToString("C2")
    End Sub

    Private Sub ex_Click(sender As Object, e As EventArgs) Handles ex.Click
        Me.Close()
    End Sub
End Class
