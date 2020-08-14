<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPeriode
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPeriode))
        Me.debutCalendar = New System.Windows.Forms.MonthCalendar
        Me.finCalendar = New System.Windows.Forms.MonthCalendar
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.btnOk = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'debutCalendar
        '
        Me.debutCalendar.Location = New System.Drawing.Point(0, 19)
        Me.debutCalendar.MaxSelectionCount = 1
        Me.debutCalendar.Name = "debutCalendar"
        Me.debutCalendar.ShowToday = False
        Me.debutCalendar.ShowTodayCircle = False
        Me.debutCalendar.TabIndex = 0
        '
        'finCalendar
        '
        Me.finCalendar.Location = New System.Drawing.Point(199, 19)
        Me.finCalendar.MaxSelectionCount = 1
        Me.finCalendar.Name = "finCalendar"
        Me.finCalendar.ShowTodayCircle = False
        Me.finCalendar.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(152, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Date de début de la recherche"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(196, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 13)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Date de fin de la recherche"
        '
        'btnOk
        '
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(347, 186)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(33, 23)
        Me.btnOk.TabIndex = 4
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'frmPeriode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(387, 213)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.finCalendar)
        Me.Controls.Add(Me.debutCalendar)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmPeriode"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents debutCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents finCalendar As System.Windows.Forms.MonthCalendar
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnOk As System.Windows.Forms.Button
End Class
