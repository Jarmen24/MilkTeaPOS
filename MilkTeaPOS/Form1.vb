Public Class Form1
    Private currentBtn As PictureBox
    Private Sub ActivateButton(sender As Object)
        If sender IsNot Nothing Then
            currentBtn = CType(sender, PictureBox)

            currentBtn.BackColor = Color.FromArgb(64, 84, 104)
        End If
    End Sub

    Private Sub DisableButton()
        If currentBtn IsNot Nothing Then
            currentBtn.BackColor = Color.FromArgb(44, 62, 80)
        End If
    End Sub

    Private Sub buyBtn_Click(sender As Object, e As EventArgs) Handles buyBtn.Click
        DisableButton()
        ActivateButton(sender)
    End Sub

    Private Sub editBtn_Click(sender As Object, e As EventArgs) Handles editBtn.Click
        DisableButton()
        ActivateButton(sender)
    End Sub

    Private Sub prodBtn_Click(sender As Object, e As EventArgs) Handles prodBtn.Click
        DisableButton()
        ActivateButton(sender)
    End Sub

    Private Sub logsBtn_Click(sender As Object, e As EventArgs) Handles logsBtn.Click
        DisableButton()
        ActivateButton(sender)
    End Sub

    Private Sub analyticsBtn_Click(sender As Object, e As EventArgs) Handles analyticsBtn.Click
        DisableButton()
        ActivateButton(sender)
    End Sub


End Class
