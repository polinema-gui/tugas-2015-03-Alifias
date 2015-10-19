Public Class Form3

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim matrix1 As New List(Of Integer)
        Dim matrix2 As New List(Of Integer)
        Dim data1 As String() = angka1String.Text.Split(" ")
        Dim data2 As String() = angka2String.Text.Split(" ")

        For Each d In data1
            matrix1.Add(Convert.ToInt64(d))
        Next
        For Each d In data2
            matrix2.Add(Convert.ToInt64(d))
        Next

        If operasi.Text = "Tambah" Then

            For i As Integer = 0 To data1.Length - 1
                Dim a As Integer
                a = matrix1.Item(i) + matrix2.Item(i)
                hasilBox.Text &= " " & a
            Next
        Else
            For i As Integer = 0 To data1.Length - 1
                Dim a As Integer
                a = matrix1.Item(i) - matrix2.Item(i)
                hasilBox.Text &= " " & a
            Next
        End If

    End Sub

    Private Sub hasilBox_TextChanged(sender As Object, e As EventArgs) Handles hasilBox.TextChanged

    End Sub
End Class