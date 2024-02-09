Public Class Match_Strength_Detector
    Private loveLevels() As String = {"Dysfunctional", "Friend-Zone", "Fake", "Liking", "Crushing", "Unconditional Commitment", "Sacrificial Love"}
    Private LoveImages() As Image = {My.Resources.dysfunctional1, My.Resources.friendzone, My.Resources.fake, My.Resources.Liking, My.Resources.crushing, My.Resources.Unconditional, My.Resources.Sacrificial}
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnDetermineStrength.Click
        Dim strp1 As String = txtPerson1.Text.Trim
        Dim strp2 As String = txtPerson2.Text.Trim
        If strp1 = "" OrElse strp2 = "" Then
            MessageBox.Show("Please enter name for both inputs")
            Return
        End If
        lblPeopleMath.Text = strp1 & " + " & strp2
        lblPeopleMath.Visible = True

        Dim loveIndex As Integer = CalculateLoveIndex(strp1, strp2)
        lblMatchStrength.Text = FindMatchingText(loveIndex)
        lblMatchStrength.Visible = True
        picimage.Image = FindMatchingImage(loveIndex)
    End Sub

    Private Function CalculateLoveIndex(str1 As String, str2 As String) As Integer
        str1 = str1.ToLower
        str2 = str2.ToLower
        'Get ascii value for each char and sum up val.
        Dim total As Integer = GetStringAsciiSum(str1) + GetStringAsciiSum(str1)
        Return total
    End Function

    Private Function GetStringAsciiSum(str As String) As Integer
        Dim sum As Integer = 0
        'loop thro string
        For Each c As Char In str
            sum += Asc(c) 'The ascii val of c
        Next
        Return sum
    End Function

    Private Function FindMatchingText(num As Integer) As String
        Dim index As Integer = num Mod loveLevels.Length
        Return loveLevels(index)
    End Function

    Private Function FindMatchingImage(num As Integer) As Image
        Dim index As Integer = num Mod LoveImages.Length
        Return LoveImages(index)
    End Function
End Class
