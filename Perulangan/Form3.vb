Public Class Form3

    
    Dim angka1, angka2 As Integer
    Dim hasil As String
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        angka1 = Convert.ToInt64(angka1String.Text)
        angka2 = Convert.ToInt64(angka2String.Text)
        If operasi.Text = "Tambah" Then
            hasil = angka1 + angka2
        Else
            hasil = angka1 - angka2
        End If
        hasilBox.Text = hasil
    End Sub
End Class