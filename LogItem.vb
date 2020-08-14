Public Class LogItem
    Private _dateInfo As DateTime?
    Public Property dateInfo() As DateTime?
        Get
            Return _dateInfo
        End Get
        Set(ByVal value As DateTime?)
            _dateInfo = value
        End Set
    End Property
    Private _titre As String
    Public Property titre() As String
        Get
            Return _titre
        End Get
        Set(ByVal value As String)
            _titre = Trim(value)
        End Set
    End Property

    Private _texte As String
    Public Property texte() As String
        Get
            Return _texte
        End Get
        Set(ByVal value As String)
            _texte = Trim(value)
        End Set
    End Property

    Private Shared Function getLoggingPeriod(ByVal original As List(Of LogItem), ByVal startDate As DateTime, ByVal endDate As DateTime) As List(Of LogItem)
        Dim partList As New List(Of LogItem)
        For Each it As LogItem In original
            Dim curDate As DateTime = it.dateInfo.GetValueOrDefault(endDate)

            If greaterThenOrEqual(curDate, startDate) AndAlso lessThenOrEqual(curDate, endDate) Then
                partList.Add(it)
            End If
        Next

        Return partList

    End Function

    Public Shared Function createPeriodLog(ByVal original As List(Of LogItem), ByVal startDate As DateTime, ByVal endDate As DateTime) As List(Of LogItem)

        Dim periodList As List(Of LogItem) = getLoggingPeriod(original, startDate, endDate)

        Return periodList
    End Function

    Public Shared Function createErrorLog(ByVal original As List(Of LogItem)) As List(Of LogItem)
        Dim partList As New List(Of LogItem)

        For Each it As LogItem In original
            If it.texte.Contains("Conflit") Or it.texte.Contains("Exception") Then
                partList.Add(it)
            End If
        Next

        Return partList
    End Function

    Private Shared Function greaterThenOrEqual(ByVal firstDate As DateTime, ByVal secondDate As DateTime) As Boolean
        Dim first As DateTime = New DateTime(firstDate.Year, firstDate.Month, firstDate.Day)
        Dim second As DateTime = New DateTime(secondDate.Year, secondDate.Month, secondDate.Day)

        If (first - second).TotalDays >= 0 Then
            Return True
        End If


    End Function

    Private Shared Function lessThenOrEqual(ByVal firstDate As DateTime, ByVal secondDate As DateTime) As Boolean
        Dim first As DateTime = New DateTime(firstDate.Year, firstDate.Month, firstDate.Day)
        Dim second As DateTime = New DateTime(secondDate.Year, secondDate.Month, secondDate.Day)
        Dim x = (secondDate - firstDate).TotalDays

        If (second - first).TotalDays >= 0 Then
            Return True
        End If
    End Function
End Class

