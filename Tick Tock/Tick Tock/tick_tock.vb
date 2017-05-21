Public Class frmBomb
    Dim code = "nosplode"

    Private Sub frmBomb_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtCountDown.Text = "30"
        tmrDeath.Enabled = True
    End Sub

    Private Sub tmrDeath_Tick(sender As Object, e As EventArgs) Handles tmrDeath.Tick
        txtCountDown.Text = (CDbl(txtCountDown.Text) - 0.1).ToString("N1")
        If txtCountDown.txt = (0).ToString("N1") Then
            tmrDeath.Enabled = False
            MessageBox.Show("Death, The bomb has gone off!")
        End If
    End Sub

    Private Sub btnCheck_Click(sender As Object, e As EventArgs) Handles btnCheck.Click
        If txtPassword.Text = code Then
            MessageBox.Show("Hooray, Password Accepted!")
            tmrDeath.Enabled = False
        Else
            txtPassword.Clear()
            txtPassword.Focus()
        End If
    End Sub
End Class