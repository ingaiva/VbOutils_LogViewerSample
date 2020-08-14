<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmText
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmText))
        Me.rTxt = New System.Windows.Forms.RichTextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnOk = New System.Windows.Forms.Button()
        Me.lblTitre = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'rTxt
        '
        Me.rTxt.Dock = System.Windows.Forms.DockStyle.Fill
        Me.rTxt.Location = New System.Drawing.Point(0, 17)
        Me.rTxt.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.rTxt.Name = "rTxt"
        Me.rTxt.Size = New System.Drawing.Size(621, 276)
        Me.rTxt.TabIndex = 0
        Me.rTxt.Text = ""
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnOk)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel1.Location = New System.Drawing.Point(0, 293)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(621, 31)
        Me.Panel1.TabIndex = 1
        '
        'btnOk
        '
        Me.btnOk.Dock = System.Windows.Forms.DockStyle.Right
        Me.btnOk.Image = CType(resources.GetObject("btnOk.Image"), System.Drawing.Image)
        Me.btnOk.Location = New System.Drawing.Point(577, 0)
        Me.btnOk.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(44, 31)
        Me.btnOk.TabIndex = 5
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblTitre.Location = New System.Drawing.Point(0, 0)
        Me.lblTitre.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(0, 17)
        Me.lblTitre.TabIndex = 2
        '
        'frmText
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 324)
        Me.Controls.Add(Me.rTxt)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.lblTitre)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmText"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents rTxt As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents lblTitre As System.Windows.Forms.Label
End Class
