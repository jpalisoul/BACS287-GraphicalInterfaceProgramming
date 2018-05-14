Public Class Form1
    Private Sub Navigate(ByVal address As String)
        If String.IsNullOrEmpty(address) Then Return
        If address.Equals("about:blank") Then Return
        If Not address.StartsWith("http://") And
            Not address.StartsWith("https://") Then
            address = "http://" & address
        End If

        Try
            WebBrowser1.Navigate(New Uri(address))
        Catch ex As System.UriFormatException
            Return
        End Try
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Empty
    End Sub

    Private Sub radMsg1_CheckedChanged(sender As Object, e As EventArgs) Handles radMsg1.CheckedChanged
        txtStyleExample.Text = "The 1st Demo Message"
    End Sub

    Private Sub radMsg2_CheckedChanged(sender As Object, e As EventArgs) Handles radMsg2.CheckedChanged
        txtStyleExample.Text = "The Middle Message you see"
    End Sub

    Private Sub radMsg3_CheckedChanged(sender As Object, e As EventArgs) Handles radMsg3.CheckedChanged
        txtStyleExample.Text = "The Last Demo Message"
    End Sub

    Private Sub chkBold_CheckedChanged(sender As Object, e As EventArgs) Handles chkBold.CheckedChanged
        If chkBold.Checked Then
            txtStyleExample.Font = New Font(txtStyleExample.Font, txtStyleExample.Font.Style Or FontStyle.Bold)
        Else
            txtStyleExample.Font = New Font(txtStyleExample.Font, txtStyleExample.Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub chkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles chkItalic.CheckedChanged
        If chkItalic.Checked Then
            txtStyleExample.Font = New Font(txtStyleExample.Font, txtStyleExample.Font.Style Or FontStyle.Italic)
        Else
            txtStyleExample.Font = New Font(txtStyleExample.Font, txtStyleExample.Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub chkUnderline_CheckedChanged(sender As Object, e As EventArgs) Handles chkUnderline.CheckedChanged
        If chkUnderline.Checked Then
            txtStyleExample.Font = New Font(txtStyleExample.Font, txtStyleExample.Font.Style Or FontStyle.Underline)
        Else
            txtStyleExample.Font = New Font(txtStyleExample.Font, txtStyleExample.Font.Style And Not FontStyle.Underline)
        End If
    End Sub

    Private Sub btnResetTextbox_Click(sender As Object, e As EventArgs) Handles btnResetTextbox.Click
        ' Set the font properties back to regular
        txtStyleExample.Font = New Font(txtStyleExample.Font, FontStyle.Regular)

        ' Turn all option buttons off
        radMsg1.Checked = False
        radMsg2.Checked = False
        radMsg3.Checked = False

        ' Turn all check boxes off
        chkBold.CheckState = False
        chkItalic.CheckState = False
        chkUnderline.CheckState = False

        ' Clear the textbox
        txtStyleExample.Text = ""

    End Sub

    Private Sub scrRed_Scroll(sender As Object, e As ScrollEventArgs) Handles scrRed.Scroll
        Me.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value)
        txtRed.Text = scrRed.Value
    End Sub

    Private Sub scrBlue_Scroll(sender As Object, e As ScrollEventArgs) Handles scrBlue.Scroll
        Me.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value)
        txtBlue.Text = scrBlue.Value
    End Sub

    Private Sub scrGreen_Scroll(sender As Object, e As ScrollEventArgs) Handles scrGreen.Scroll
        Me.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value)
        txtGreen.Text = scrGreen.Value
    End Sub

    Private Sub btnSetColor_Click(sender As Object, e As EventArgs) Handles btnSetColor.Click
        Dim MyDialog As New ColorDialog()
        ' Keeps the user from selecting a custom color.
        MyDialog.AllowFullOpen = False
        ' Allows the user to get help. (The default is false.)
        MyDialog.ShowHelp = True
        ' Sets the initial color select to the current text color,
        MyDialog.Color = Me.BackColor

        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = DialogResult.OK) Then
            Me.BackColor = MyDialog.Color
        End If

    End Sub

    Private Sub txtRed_TextChanged(sender As Object, e As EventArgs) Handles txtRed.TextChanged
        scrRed.Value = txtRed.Text
        Me.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value)
    End Sub

    Private Sub txtBlue_TextChanged(sender As Object, e As EventArgs) Handles txtBlue.TextChanged
        scrBlue.Value = txtBlue.Text
        Me.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value)
    End Sub

    Private Sub txtGreen_TextChanged(sender As Object, e As EventArgs) Handles txtGreen.TextChanged
        scrGreen.Value = txtGreen.Text
        Me.BackColor = Color.FromArgb(scrRed.Value, scrGreen.Value, scrBlue.Value)
    End Sub

    Private Sub btnMouseOver_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles btnMouseOver.MouseMove
        txtMouseWork.Text = "The Mouse passed over the button!"
    End Sub

    Private Sub btnMouseClear_Click(sender As Object, e As EventArgs) Handles btnMouseClear.Click
        txtMouseWork.Text = ""
    End Sub

    Private Sub drvFileWork_SelectedIndexChanged(sender As Object, e As EventArgs) Handles drvFileWork.SelectedIndexChanged
        dirFileWork.Path = drvFileWork.Drive
    End Sub

    Private Sub dirFileWork_SelectedIndexChanged(sender As Object, e As EventArgs) Handles dirFileWork.SelectedIndexChanged
        filFileWork.Path = dirFileWork.Path
    End Sub

    Private Sub filFileWork_SelectedIndexChanged(sender As Object, e As EventArgs) Handles filFileWork.SelectedIndexChanged
        lblFileWork.Text = filFileWork.Path & "\" & filFileWork.FileName
        picImageDisplay.Image = System.Drawing.Image.FromFile(lblFileWork.Text)
    End Sub

    Private Sub btnGo_Click(sender As Object, e As EventArgs) Handles btnGo.Click
        Navigate(txtURL.Text)
    End Sub

    Private Sub radURSA_CheckedChanged(sender As Object, e As EventArgs) Handles radURSA.CheckedChanged
        txtURL.Text = "URSA.unco.edu"
        Navigate(txtURL.Text)
    End Sub

    Private Sub radMCB_CheckedChanged(sender As Object, e As EventArgs) Handles radMCB.CheckedChanged
        txtURL.Text = "mcb.unco.edu"
        Navigate(txtURL.Text)
    End Sub

    Private Sub rad287_CheckedChanged(sender As Object, e As EventArgs) Handles rad287.CheckedChanged
        txtURL.Text = "mcbfaculty.unco.edu/lightfoot/bacs287"
        Navigate(txtURL.Text)
    End Sub

    Private Sub radMicrosoft_CheckedChanged(sender As Object, e As EventArgs) Handles radMicrosoft.CheckedChanged
        txtURL.Text = "msdn.microsoft.com/en-us/vstudio/hh388573.aspx"
        Navigate(txtURL.Text)
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
End Class
