

Public Class ctrlItem
    Public Event onPrevious()
    Public Event onNext()


    Private Sub btnUp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUp.Click
        RaiseEvent onPrevious()
    End Sub

    Private Sub btnDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDown.Click
        RaiseEvent onNext()
    End Sub

    Private WithEvents _dataSource As LogItem

    Public Property dataSource() As LogItem
        Get
            Return _dataSource
        End Get
        Set(ByVal value As LogItem)
            _dataSource = value

            If _dataSource IsNot Nothing Then
                bs.DataSource = _dataSource
                Me.txtDate.Text = _dataSource.dateInfo.GetValueOrDefault.ToString("G")
                Me.txtTexte.Text = _dataSource.texte
                Me.txtTitre.Text = _dataSource.titre

                btnDown.Visible = True
                btnUp.Visible = True
            Else
                Me.txtDate.Text = String.Empty
                Me.txtTexte.Text = String.Empty
                Me.txtTitre.Text = String.Empty

                bs.DataSource = GetType(LogItem)


                btnDown.Visible = False
                btnUp.Visible = False


            End If

        End Set
    End Property


End Class
