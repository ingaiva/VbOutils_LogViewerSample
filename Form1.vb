Public Class Form1
    Public curLog As List(Of LogItem)
    Private _filePath As String

    Private Sub ctrlLogItem_onNext() Handles ctrlLogItem.onNext
        Try
            If tv.SelectedNode IsNot Nothing AndAlso tv.Nodes.Count > 0 Then
                Dim nextIdx As Integer = tv.SelectedNode.Index + 1

                If tv.Nodes.Count > nextIdx Then tv.SelectedNode = tv.Nodes(nextIdx)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub ctrlLogItem_onPrevious() Handles ctrlLogItem.onPrevious
        Try
            If tv.SelectedNode IsNot Nothing AndAlso tv.Nodes.Count > 0 Then
                Dim previousIdx As Integer = tv.SelectedNode.Index - 1

                If previousIdx >= 0 Then tv.SelectedNode = tv.Nodes(previousIdx)
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Function getLogDirectory() As String
        Dim di As IO.DirectoryInfo
        Try
            di = New IO.DirectoryInfo(Application.StartupPath)
           
            For Each subDi As IO.DirectoryInfo In di.GetDirectories
                If subDi.Name = "LogEvent" Then
                    Return subDi.FullName
                End If
            Next
        Catch ex As Exception
        Finally
            di = Nothing
        End Try
        Return String.Empty
    End Function

    Private Sub tsmiOuvrir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiOuvrir.Click

        ofd.Filter = "Fichier Log (*.txt)|*.txt"
        ofd.FileName = "RapportSynchronisation.txt"
        If String.IsNullOrEmpty(ofd.InitialDirectory) Then
            Dim logDirectory As String = getLogDirectory()
            If String.IsNullOrEmpty(logDirectory) = False Then
                ofd.InitialDirectory = logDirectory
            End If
        End If

        If ofd.ShowDialog = Windows.Forms.DialogResult.OK Then
            loadFile(ofd.FileName)
        End If

    End Sub

    Private Function createLog(ByVal data As String) As List(Of LogItem)
        Dim log As New List(Of LogItem)

        Const leftDelimiter As String = "<<-"
        Const rightDelimiter As String = "->>"
        Const debutTitre As String = "Rapport de Synchronisation du"
        Const nextDate As String = "---"
        Try
            Dim reste As String = data

            While String.IsNullOrEmpty(reste) = False
                Dim idxLeft As Integer = reste.IndexOf(leftDelimiter)
                Dim idxRight As Integer = reste.IndexOf(rightDelimiter)
                Dim titreLog As String = String.Empty
                Dim texteLog As String = String.Empty
                Dim dt As Date? = Nothing
                If idxLeft >= 0 And idxRight >= 0 Then

                    titreLog = reste.Substring(idxLeft, idxRight + rightDelimiter.Length)
                    idxRight += rightDelimiter.Length

                    If idxRight <= reste.Length Then
                        reste = Trim(reste.Substring(idxRight))
                        Dim idxEnd As Integer = reste.IndexOf(leftDelimiter)
                        If idxEnd >= 0 Then
                            texteLog = reste.Substring(0, idxEnd)
                            reste = reste.Substring(idxEnd)
                        Else
                            texteLog = reste
                            reste = String.Empty
                        End If
                    Else
                        reste = String.Empty
                    End If
                Else
                    reste = String.Empty
                End If

                If String.IsNullOrEmpty(titreLog) = False Then
                    Dim idxDebut As Integer = titreLog.IndexOf(debutTitre)
                    If idxDebut >= 0 Then
                        Dim dtStr = titreLog.Substring(idxDebut + debutTitre.Length)
                        Dim idxEnd As Integer = dtStr.IndexOf(nextDate)
                        If idxEnd >= 0 Then
                            dtStr = Trim(dtStr.Substring(0, idxEnd))
                            Try
                                dt = CDate(dtStr)
                            Catch ex As Exception
                                dt = Nothing
                            End Try
                        End If
                    End If
                    Dim it As New LogItem
                    it.dateInfo = dt
                    it.titre = titreLog
                    it.texte = texteLog
                    log.Add(it)
                End If
            End While

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Return log

    End Function

    Public Sub loadFile(ByVal logFilePath As String)
        Dim reader As IO.StreamReader = Nothing
        Try
            tsmiNombreDeCaracteres.Text = "Nombre de caracteres: "
            tsmiNombreElementsDansLaListe.Text = "Nombre d'élements dans la liste: "

            tsmiTailleDuFichierOctets.Text = "Taille du fichier(Octets): "
            tsmiTailleDuFichierEnKo.Text = "Taille du fichier(Ko): "
            tsmiTailleFichierMo.Text = "Taille du fichier (Mo): "

            _filePath = logFilePath
            Me.Text = _filePath

            Dim fi As New IO.FileInfo(_filePath)
            If fi.Length > 0 Then
                reader = New IO.StreamReader(_filePath)
                Dim data As String = reader.ReadToEnd()
                reader.Close()
                reader.Dispose()
                '===              
                'decoupe:
                Dim log As List(Of LogItem) = createLog(data)

                curLog = log

                loadLog(log)

                If log IsNot Nothing AndAlso log.Count = 0 Then
                    Using frm As New frmText
                        frm.ShowDialog(data, "Impossible de decoder le fichier", _filePath)
                    End Using
                    _filePath = String.Empty
                    Me.Text = _filePath
                    curLog = Nothing
                End If
                '===Stat:
                tsmiNombreDeCaracteres.Text &= data.Length
                tsmiNombreElementsDansLaListe.Text &= log.Count
                tsmiTailleDuFichierOctets.Text &= fi.Length
                tsmiTailleDuFichierEnKo.Text &= Math.Round(fi.Length / 1024, 3)
                tsmiTailleFichierMo.Text &= Math.Round((fi.Length / 1024) / 1024, 3)
                '===

            End If

        Catch ex As Exception
            curLog = Nothing
            If reader IsNot Nothing Then
                reader.Close()
                reader.Dispose()
            End If

            MsgBox(ex.Message)

        End Try
    End Sub

    Public Sub loadLog(ByVal log As List(Of LogItem))
        Try
           
            createTreeview(log)

            If tv.Nodes.Count > 0 Then
                tv.SelectedNode = tv.Nodes(tv.Nodes.Count - 1)
            Else
                tv.SelectedNode = Nothing
                Me.ctrlLogItem.dataSource = Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    
    Public Sub createTreeview(ByVal log As List(Of LogItem))

        tv.Nodes.Clear()
        Try
            If log IsNot Nothing Then
                For Each it As LogItem In log
                    Dim node As New TreeNode
                    node.ImageKey = "about"

                    node.SelectedImageKey = node.ImageKey
                    node.Text = it.dateInfo.GetValueOrDefault.ToString("G") '& " " & it.titre
                    node.Tag = it
                    tv.Nodes.Add(node)
                Next

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ImgList.Images.Clear()
        ImgList.Images.Add("about", My.Resources.about)

        Me.Icon = My.Resources.holmes
        Me.ShowIcon = True

        Dim logFiledirectory As String = getLogDirectory()
        If IO.Directory.Exists(logFiledirectory) Then
            Dim logFilePath As String = IO.Path.Combine(logFiledirectory, "RapportSynchronisation.txt")
            If IO.File.Exists(logFilePath) Then
                Me.loadFile(logFilePath)
            End If
        Else
            Dim curDirectory As String = IO.Path.GetDirectoryName(Application.ExecutablePath)
            Dim logFilePath As String = IO.Path.Combine(curDirectory, "RapportSynchronisation.txt")
            If IO.File.Exists(logFilePath) Then
                Me.loadFile(logFilePath)
            End If
        End If

    End Sub

    Private Sub tv_AfterSelect(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeViewEventArgs) Handles tv.AfterSelect
        Try
            Dim node As TreeNode = tv.SelectedNode
            If node Is Nothing Then
                Me.ctrlLogItem.dataSource = Nothing
            Else
                If node.Tag IsNot Nothing AndAlso TypeOf node.Tag Is LogItem Then
                    Me.ctrlLogItem.dataSource = node.Tag
                End If

            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Private Sub tsmiRechercherUnePériode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRechercherUnePériode.Click
        If curLog Is Nothing Then
            MsgBox("Chargez le fichier Log")
            Exit Sub
        End If


        Dim debutDate As DateTime
        Dim finDate As DateTime

        Dim frm As New frmPeriode
        If frm.ShowDialog() <> Windows.Forms.DialogResult.OK Then
            Exit Sub
        Else
            If frm.dateDiff < 0 Then
                MsgBox("Selection incorrecte")
                Exit Sub
            End If
            debutDate = frm.debut
            finDate = frm.fin
        End If

        Dim periodLog As List(Of LogItem) = LogItem.createPeriodLog(curLog, debutDate, finDate)
        loadLog(periodLog)

    End Sub

    Private Sub tsmiRechargerLeFichier_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRechargerLeFichier.Click
        If String.IsNullOrEmpty(_filePath) = False AndAlso IO.File.Exists(_filePath) Then
            Try


                loadFile(_filePath)

            Catch ex As Exception

                MsgBox(ex.Message)
            End Try
        End If
    End Sub

   
    Private Sub tsmiRechercheErreurs_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tsmiRechercheErreurs.Click
        Dim errLog As List(Of LogItem) = LogItem.createErrorLog(curLog)
        loadLog(errLog)
    End Sub
End Class
