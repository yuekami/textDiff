Imports System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If String.IsNullOrEmpty(Me.TextBox1.Text) OrElse String.IsNullOrEmpty(Me.TextBox2.Text) Then

            GoTo skip

        End If

        Dim str1 As StreamReader = New StreamReader(Me.TextBox1.Text)
        Dim txt1 As String = str1.ReadToEnd
        str1.Close()

        Dim str2 As StreamReader = New StreamReader(Me.TextBox2.Text)
        Dim txt2 As String = str2.ReadToEnd
        str2.Close()


        If txt1 = txt2 Then
            MessageBox.Show("同じファイルです")
        Else

            MessageBox.Show("中身違う")
        End If


skip:

    End Sub
End Class
