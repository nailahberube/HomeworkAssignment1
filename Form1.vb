Public Class frmNumbers
    Private Sub lblInstructions_TextChanged(sender As Object, e As EventArgs) Handles lblInstructions.TextChanged

    End Sub

    Private Sub lblFrench_Invisible(sender As Object, e As EventArgs) Handles MyBase.Load
        lblFrench.Visible = False


    End Sub

    Private Sub lblFrench_Visible(sender As Object, e As EventArgs) Handles btnOne.Click, btnTwo.Click, btnThree.Click, btnFour.Click, btnFive.Click
        lblFrench.Text = "Un"
        lblFrench.Text = "Deux"
        lblFrench.Text = "Trois"
        lblFrench.Text = "Quatre"
        lblFrench.Text = "Cinq"

    End Sub

    Private Sub Close_Form(sender As Object, e As EventArgs) Handles btnExit.Click

        Application.Exit()

    End Sub

    Private Sub lblFrench_TextChanged(sender As Object, e As EventArgs) Handles lblFrench.TextChanged

    End Sub
End Class
