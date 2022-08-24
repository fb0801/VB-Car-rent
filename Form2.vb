Public Class Form2
    Dim cartype As String
    Dim carrentdate As Integer
    Dim carrentmonth As Integer
    Dim carrentweek As Integer
    Dim carrentcost As Integer
    Dim frm As Integer
    Dim strTextBox As Integer

    Public Sub New(ByVal strTextBox As String)
        InitializeComponent()
        firstname.Text = strTextBox

    End Sub


    Private Sub Form2_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load


    End Sub
    Private Sub Combo1day_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles Cbo1day.SelectedIndexChanged



    End Sub

    Private Sub Combo8carrentstartdate_SelectedIndexChanged(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Btnnext_Click(sender As System.Object, e As System.EventArgs) Handles BtnCalculate.Click

        cartype = Cbocartype.Text
        If (cartype = "Small") And (Chkday.Checked) Then
            carrentcost = 20
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Small") And (Chkweek.Checked) Then
            carrentcost = 80
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Small") And (Chkmonth.Checked) Then
            carrentcost = 240
            Lbldisplaycost.Text = carrentcost
        End If



        If (cartype = "Medium") And (Chkday.Checked) Then
            carrentcost = 25
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Medium") And (Chkweek.Checked) Then
            carrentcost = 100
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Medium") And (Chkmonth.Checked) Then
            carrentcost = 300
            Lbldisplaycost.Text = carrentcost
        End If



        If (cartype = "Mini Bus") And (Chkday.Checked) Then
            carrentcost = 35
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Mini Bus") And (Chkweek.Checked) Then
            carrentcost = 140
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Mini Bus") And (Chkmonth.Checked) Then
            carrentcost = 420
            Lbldisplaycost.Text = carrentcost
        End If



        If (cartype = "Sports") And (Chkday.Checked) Then
            carrentcost = 45
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Sports") And (Chkweek.Checked) Then
            carrentcost = 180
            Lbldisplaycost.Text = carrentcost
        End If

        If (cartype = "Sports") And (Chkmonth.Checked) Then
            carrentcost = 540
            Lbldisplaycost.Text = carrentcost
        End If


        If Day = "day" Then
            costday = 1
        ElseIf days = "week" Then
            costdays = 4
        ElseIf days = "months" Then
            costdays = 12
        End If
        cost = costdays = costsize * 1.2
        Lbldisplaycost.Text = "£" & cost


    End Sub

    Private Sub Btnnext_Click_1(sender As System.Object, e As System.EventArgs) Handles Btnnext.Click
        Form3.Show()

    End Sub

    Private Sub Btnsubmit_Click(sender As System.Object, e As System.EventArgs) Handles Btnsubmit.Click
        Form3.Show()
        Form2.firstname.Text = Me.displayname.Text﻿box

        Form3.displayname.Text = "firstname" & "lastname".text


    End Sub


    End Sub
End Class