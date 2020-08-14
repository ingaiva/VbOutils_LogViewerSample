<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ctrlItem
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ctrlItem))
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.btnUp = New System.Windows.Forms.Button
        Me.btnDown = New System.Windows.Forms.Button
        Me.txtDate = New System.Windows.Forms.TextBox
        Me.txtTitre = New System.Windows.Forms.RichTextBox
        Me.lblTitre = New System.Windows.Forms.Label
        Me.lblDate = New System.Windows.Forms.Label
        Me.textContainer = New System.Windows.Forms.Panel
        Me.txtTexte = New System.Windows.Forms.RichTextBox
        Me.lblTexte = New System.Windows.Forms.Label
        Me.bs = New System.Windows.Forms.BindingSource(Me.components)
        Me.DetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Panel1.SuspendLayout()
        Me.textContainer.SuspendLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.btnUp)
        Me.Panel1.Controls.Add(Me.btnDown)
        Me.Panel1.Controls.Add(Me.txtDate)
        Me.Panel1.Controls.Add(Me.txtTitre)
        Me.Panel1.Controls.Add(Me.lblTitre)
        Me.Panel1.Controls.Add(Me.lblDate)
        Me.Panel1.Controls.Add(Me.textContainer)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(468, 442)
        Me.Panel1.TabIndex = 1
        '
        'btnUp
        '
        Me.btnUp.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Image = CType(resources.GetObject("btnUp.Image"), System.Drawing.Image)
        Me.btnUp.Location = New System.Drawing.Point(436, 4)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(25, 25)
        Me.btnUp.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btnUp, "Précédent")
        Me.btnUp.UseVisualStyleBackColor = True
        '
        'btnDown
        '
        Me.btnDown.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Image = CType(resources.GetObject("btnDown.Image"), System.Drawing.Image)
        Me.btnDown.Location = New System.Drawing.Point(436, 29)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(25, 25)
        Me.btnDown.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnDown, "Suivant")
        Me.btnDown.UseVisualStyleBackColor = True
        '
        'txtDate
        '
        Me.txtDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtDate.BackColor = System.Drawing.SystemColors.Control
        Me.txtDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtDate.Location = New System.Drawing.Point(41, 13)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.ReadOnly = True
        Me.txtDate.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.txtDate.Size = New System.Drawing.Size(202, 13)
        Me.txtDate.TabIndex = 6
        '
        'txtTitre
        '
        Me.txtTitre.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTitre.BackColor = System.Drawing.SystemColors.Control
        Me.txtTitre.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTitre.Location = New System.Drawing.Point(41, 55)
        Me.txtTitre.Name = "txtTitre"
        Me.txtTitre.ReadOnly = True
        Me.txtTitre.Size = New System.Drawing.Size(411, 46)
        Me.txtTitre.TabIndex = 7
        Me.txtTitre.Text = ""
        '
        'lblTitre
        '
        Me.lblTitre.AutoSize = True
        Me.lblTitre.Location = New System.Drawing.Point(1, 55)
        Me.lblTitre.Name = "lblTitre"
        Me.lblTitre.Size = New System.Drawing.Size(31, 13)
        Me.lblTitre.TabIndex = 2
        Me.lblTitre.Text = "Titre:"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(1, 13)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(33, 13)
        Me.lblDate.TabIndex = 0
        Me.lblDate.Text = "Date:"
        '
        'textContainer
        '
        Me.textContainer.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.textContainer.Controls.Add(Me.txtTexte)
        Me.textContainer.Controls.Add(Me.lblTexte)
        Me.textContainer.Location = New System.Drawing.Point(0, 104)
        Me.textContainer.Margin = New System.Windows.Forms.Padding(0)
        Me.textContainer.Name = "textContainer"
        Me.textContainer.Padding = New System.Windows.Forms.Padding(1)
        Me.textContainer.Size = New System.Drawing.Size(467, 335)
        Me.textContainer.TabIndex = 11
        '
        'txtTexte
        '
        Me.txtTexte.BackColor = System.Drawing.SystemColors.Info
        Me.txtTexte.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtTexte.Dock = System.Windows.Forms.DockStyle.Fill
        Me.txtTexte.Location = New System.Drawing.Point(38, 1)
        Me.txtTexte.Name = "txtTexte"
        Me.txtTexte.ReadOnly = True
        Me.txtTexte.Size = New System.Drawing.Size(428, 333)
        Me.txtTexte.TabIndex = 11
        Me.txtTexte.Text = ""
        '
        'lblTexte
        '
        Me.lblTexte.AutoSize = True
        Me.lblTexte.Dock = System.Windows.Forms.DockStyle.Left
        Me.lblTexte.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTexte.Location = New System.Drawing.Point(1, 1)
        Me.lblTexte.Name = "lblTexte"
        Me.lblTexte.Size = New System.Drawing.Size(37, 13)
        Me.lblTexte.TabIndex = 10
        Me.lblTexte.Text = "Text:  "
        '
        'DetailsBindingSource
        '
        Me.DetailsBindingSource.DataSource = Me.bs
        '
        'ctrlItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.Panel1)
        Me.Name = "ctrlItem"
        Me.Size = New System.Drawing.Size(468, 442)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.textContainer.ResumeLayout(False)
        Me.textContainer.PerformLayout()
        CType(Me.bs, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnDown As System.Windows.Forms.Button
    Friend WithEvents btnUp As System.Windows.Forms.Button
    Friend WithEvents lblTitre As System.Windows.Forms.Label
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents txtTitre As System.Windows.Forms.RichTextBox 'TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents bs As System.Windows.Forms.BindingSource
    Friend WithEvents txtTexte As System.Windows.Forms.RichTextBox 'TextBox
    Friend WithEvents lblTexte As System.Windows.Forms.Label
    Friend WithEvents DetailsBindingSource As System.Windows.Forms.BindingSource
    'TextBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents textContainer As System.Windows.Forms.Panel 'SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel

End Class
