Public Class Doutput

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Close_Click(sender As Object, e As EventArgs) Handles CloseB.Click
        Me.Hide()
        OverA.Text = ""
        OverB.Text = ""
        OverC.Text = ""
        OverV.Text = ""
        Vent.Text = ""
        WrT.Text = ""
        ArT.Text = ""
        HrT.Text = ""
        DsT.Text = ""

        Me.Close()
    End Sub

    Private Sub Doutput_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click

    End Sub

    Private Sub Label46_Click(sender As Object, e As EventArgs) Handles Label46.Click

    End Sub
End Class