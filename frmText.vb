Public Class frmText

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.Close()
    End Sub

    Public Overloads Function showDialog(ByVal txt As String, ByVal infoTxt As String, ByVal windowTitle As String) As DialogResult
        Me.rTxt.Text = txt
        Me.lblTitre.Text = infoTxt
        Me.Text = windowTitle
        Me.Icon = My.Resources.aboutIco
        Me.ShowIcon = True
        Return MyBase.ShowDialog
    End Function
End Class