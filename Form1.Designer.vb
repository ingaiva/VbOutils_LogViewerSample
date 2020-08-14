<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer
        Me.tv = New System.Windows.Forms.TreeView
        Me.ImgList = New System.Windows.Forms.ImageList(Me.components)
        Me.ctrlLogItem = New ParamLogViewer.ctrlItem
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip
        Me.tsmiFichier = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiOuvrir = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiRechercherUnePériode = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiRechargerLeFichier = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiStatistique = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTailleDuFichierOctets = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTailleDuFichierEnKo = New System.Windows.Forms.ToolStripMenuItem
        Me.tsmiTailleFichierMo = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmiNombreDeCaracteres = New System.Windows.Forms.ToolStripMenuItem
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator
        Me.tsmiNombreElementsDansLaListe = New System.Windows.Forms.ToolStripMenuItem
        Me.ofd = New System.Windows.Forms.OpenFileDialog
        Me.tsmiRechercheErreurs = New System.Windows.Forms.ToolStripMenuItem
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 24)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.SplitContainer1.Panel1.Controls.Add(Me.tv)
        Me.SplitContainer1.Panel1.Padding = New System.Windows.Forms.Padding(2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ctrlLogItem)
        Me.SplitContainer1.Size = New System.Drawing.Size(736, 542)
        Me.SplitContainer1.SplitterDistance = 245
        Me.SplitContainer1.TabIndex = 0
        '
        'tv
        '
        Me.tv.Dock = System.Windows.Forms.DockStyle.Fill
        Me.tv.FullRowSelect = True
        Me.tv.HideSelection = False
        Me.tv.ImageIndex = 0
        Me.tv.ImageList = Me.ImgList
        Me.tv.ItemHeight = 26
        Me.tv.Location = New System.Drawing.Point(2, 2)
        Me.tv.Name = "tv"
        Me.tv.SelectedImageIndex = 0
        Me.tv.Size = New System.Drawing.Size(241, 538)
        Me.tv.TabIndex = 0
        '
        'ImgList
        '
        Me.ImgList.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit
        Me.ImgList.ImageSize = New System.Drawing.Size(24, 24)
        Me.ImgList.TransparentColor = System.Drawing.Color.Transparent
        '
        'ctrlLogItem
        '
        Me.ctrlLogItem.dataSource = Nothing
        Me.ctrlLogItem.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ctrlLogItem.Location = New System.Drawing.Point(0, 0)
        Me.ctrlLogItem.Name = "ctrlLogItem"
        Me.ctrlLogItem.Size = New System.Drawing.Size(487, 542)
        Me.ctrlLogItem.TabIndex = 0
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiFichier, Me.tsmiStatistique})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(736, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'tsmiFichier
        '
        Me.tsmiFichier.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiOuvrir, Me.tsmiRechercherUnePériode, Me.tsmiRechercheErreurs, Me.tsmiRechargerLeFichier})
        Me.tsmiFichier.Name = "tsmiFichier"
        Me.tsmiFichier.Size = New System.Drawing.Size(50, 20)
        Me.tsmiFichier.Text = "Fichier"
        '
        'tsmiOuvrir
        '
        Me.tsmiOuvrir.Image = CType(resources.GetObject("tsmiOuvrir.Image"), System.Drawing.Image)
        Me.tsmiOuvrir.Name = "tsmiOuvrir"
        Me.tsmiOuvrir.Size = New System.Drawing.Size(266, 22)
        Me.tsmiOuvrir.Text = "Ouvrir"
        '
        'tsmiRechercherUnePériode
        '
        Me.tsmiRechercherUnePériode.Image = CType(resources.GetObject("tsmiRechercherUnePériode.Image"), System.Drawing.Image)
        Me.tsmiRechercherUnePériode.Name = "tsmiRechercherUnePériode"
        Me.tsmiRechercherUnePériode.Size = New System.Drawing.Size(266, 22)
        Me.tsmiRechercherUnePériode.Text = "Rechercher une période"
        '
        'tsmiRechargerLeFichier
        '
        Me.tsmiRechargerLeFichier.Image = CType(resources.GetObject("tsmiRechargerLeFichier.Image"), System.Drawing.Image)
        Me.tsmiRechargerLeFichier.Name = "tsmiRechargerLeFichier"
        Me.tsmiRechargerLeFichier.Size = New System.Drawing.Size(266, 22)
        Me.tsmiRechargerLeFichier.Text = "Recharger le fichier"
        '
        'tsmiStatistique
        '
        Me.tsmiStatistique.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmiTailleDuFichierOctets, Me.tsmiTailleDuFichierEnKo, Me.tsmiTailleFichierMo, Me.ToolStripSeparator1, Me.tsmiNombreDeCaracteres, Me.ToolStripSeparator2, Me.tsmiNombreElementsDansLaListe})
        Me.tsmiStatistique.Name = "tsmiStatistique"
        Me.tsmiStatistique.Size = New System.Drawing.Size(70, 20)
        Me.tsmiStatistique.Text = "Statistique"
        '
        'tsmiTailleDuFichierOctets
        '
        Me.tsmiTailleDuFichierOctets.Name = "tsmiTailleDuFichierOctets"
        Me.tsmiTailleDuFichierOctets.Size = New System.Drawing.Size(235, 22)
        Me.tsmiTailleDuFichierOctets.Text = "Taille du fichier(Octets)"
        '
        'tsmiTailleDuFichierEnKo
        '
        Me.tsmiTailleDuFichierEnKo.Name = "tsmiTailleDuFichierEnKo"
        Me.tsmiTailleDuFichierEnKo.Size = New System.Drawing.Size(235, 22)
        Me.tsmiTailleDuFichierEnKo.Text = "Taille du fichier (Ko)"
        '
        'tsmiTailleFichierMo
        '
        Me.tsmiTailleFichierMo.Name = "tsmiTailleFichierMo"
        Me.tsmiTailleFichierMo.Size = New System.Drawing.Size(235, 22)
        Me.tsmiTailleFichierMo.Text = "Taille du fichier (Mo)"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(232, 6)
        '
        'tsmiNombreDeCaracteres
        '
        Me.tsmiNombreDeCaracteres.Name = "tsmiNombreDeCaracteres"
        Me.tsmiNombreDeCaracteres.Size = New System.Drawing.Size(235, 22)
        Me.tsmiNombreDeCaracteres.Text = "Nombre de caracteres"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(232, 6)
        '
        'tsmiNombreElementsDansLaListe
        '
        Me.tsmiNombreElementsDansLaListe.Name = "tsmiNombreElementsDansLaListe"
        Me.tsmiNombreElementsDansLaListe.Size = New System.Drawing.Size(235, 22)
        Me.tsmiNombreElementsDansLaListe.Text = "Nombre d'élements dans la liste"
        '
        'tsmiRechercheErreurs
        '
        Me.tsmiRechercheErreurs.Image = CType(resources.GetObject("tsmiRechercheErreurs.Image"), System.Drawing.Image)
        Me.tsmiRechercheErreurs.Name = "tsmiRechercheErreurs"
        Me.tsmiRechercheErreurs.Size = New System.Drawing.Size(266, 22)
        Me.tsmiRechercheErreurs.Text = "Rechercher les éléments avec erreurs"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(736, 566)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Fichier log"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.ResumeLayout(False)
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents tv As System.Windows.Forms.TreeView
    Friend WithEvents ctrlLogItem As ctrlItem
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents tsmiFichier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiNombreDeCaracteres As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiOuvrir As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ofd As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ImgList As System.Windows.Forms.ImageList
    Friend WithEvents tsmiRechercherUnePériode As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiTailleDuFichierEnKo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiNombreElementsDansLaListe As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiTailleDuFichierOctets As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiStatistique As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents tsmiTailleFichierMo As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRechargerLeFichier As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmiRechercheErreurs As System.Windows.Forms.ToolStripMenuItem

End Class
