Imports System.Data.OleDb
Public Class Form1
    Dim baglanti As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Onyxia\Desktop\Database1.accdb")
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        baglanti.Open()
        Dim komut As New OleDbCommand("select *from giris where kullanici='" & TextBox1.Text & "' and sifre='" & TextBox2.Text & "'", baglanti)
        Dim reader As OleDbDataReader = komut.ExecuteReader

        Try
            If reader.Read() = True Then
                MessageBox.Show("Giriş Başarılı")

            Else
                MessageBox.Show("Giriş Başarısız")
            End If
        Catch ex As Exception

        Finally
            baglanti.Close()
        End Try





    End Sub

    Private Sub closeBtn_Click(sender As Object, e As EventArgs) Handles closeBtn.Click
        Application.Exit()
    End Sub


End Class
