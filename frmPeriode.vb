Public Class frmPeriode


    Public Property debut() As DateTime
        Get
            Return Me.debutCalendar.SelectionStart

        End Get
        Set(ByVal value As DateTime)
            Me.debutCalendar.SelectionStart = value


        End Set
    End Property


    Public Property fin() As DateTime
        Get
            Return Me.finCalendar.SelectionStart

        End Get
        Set(ByVal value As DateTime)
            Me.finCalendar.SelectionStart = value
        End Set
    End Property

    Public ReadOnly Property dateDiff() As Integer
        Get
            Dim diff As Int16 = 0
            Dim ts As TimeSpan = Me.fin.Subtract(Me.debut)
            Return ts.Days

        End Get
    End Property

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        Me.DialogResult = Windows.Forms.DialogResult.OK
    End Sub

    Private Sub frmPeriode_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.fin = Date.Now
        Me.debut = Date.Now.AddDays(-7)
    End Sub
End Class