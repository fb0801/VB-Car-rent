Public Class Form1
    Dim yes As Integer
    Dim No As Integer

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Btn1.Click
        If vbYes Then Form2.Show()
    End Sub

    Private Sub Form1_Click(sender As Object, e As System.EventArgs) Handles Me.Click
        If MsgBox("Before using this application are you above 17 years old to rent a car?", vbYesNo) Then
            'was clicked
        Else
            'was not clicked 

        End If

    End Sub

    Private Sub Form1_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load



    End Sub

    Private Sub Btn2_Click(sender As System.Object, e As System.EventArgs) Handles Btn2.Click
        If vbNo Then Me.Close()
    End Sub
End Class
