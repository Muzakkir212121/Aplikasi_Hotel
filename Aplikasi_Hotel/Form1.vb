Imports System.IO
Public Class Form1

    Private Sub UbahTeks(ByVal Teksbaru As String)
        TextBox1.Text = Teksbaru
    End Sub

    Private Sub CBJenis_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBJenis.SelectedIndexChanged
        Select Case CBJenis.Text
            Case "VIP"
                TXTHarga.Text = 750000
            Case "Kelas I"
                TXTHarga.Text = 500000
            Case "Kelas II"
                TXTHarga.Text = 300000
            Case "Kelas III"
                TXTHarga.Text = 150000
        End Select
    End Sub

    Private Sub TXTLama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTLama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TXTBiaya.Focus()

            Dim A, B, C As New Long
            A = Val(TXTHarga.Text)
            B = Val(TXTLama.Text)

            C = A * B
            TXTBiaya.Text = C
        End If
    End Sub

    Private Sub TXTBayar_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTBayar.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TXTKembalian.Focus()

            Dim D, C, F As New Long
            D = Val(TXTBayar.Text)
            C = Val(TXTBiaya.Text)

            F = D - C
            TXTKembalian.Text = F
        End If
    End Sub

    Private Sub TXTHarga_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTHarga.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TXTLama.Focus()

        End If
    End Sub

    Private Sub TXTBiaya_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTBiaya.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TXTBayar.Focus()
        End If
    End Sub

    Private Sub TXTNama_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNama.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TXTNomor.Focus()
        End If
    End Sub

    Private Sub TXTNomor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TXTNomor.KeyPress
        If e.KeyChar = Chr(13) Then
            Me.TXTAlamat.Focus()
        End If

    End Sub

    Private Sub BTClose_Click(sender As Object, e As EventArgs) Handles BTClose.Click
        Me.Close()
    End Sub

    Private Sub BTNew_Click(sender As Object, e As EventArgs) Handles BTNew.Click
        Me.TXTNama.Text = ""
        Me.TXTAlamat.Text = ""
        Me.TXTNomor.Text = ""
        Me.CBJenis.Text = ""
        Me.TXTHarga.Text = ""
        Me.TXTLama.Text = ""
        Me.TXTBiaya.Text = ""
        Me.TXTBayar.Text = ""
        Me.TXTKembalian.Text = ""
        Me.TXTNama.Focus()
    End Sub

    Private Sub BTNFoto_Click(sender As Object, e As EventArgs) Handles BTNFoto.Click
        Dim opf As New OpenFileDialog

        opf.Filter = "Choose Image (*.JPG; *.PNG; *GIF) |*jpg; *.png; *gif"

        If opf.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            FotoTamu.Image = Image.FromFile(opf.FileName)
        End If
    End Sub

    Private Sub btnCat_Click(sender As Object, e As EventArgs) Handles btnCat.Click
        Dim value As String = InputBox("Catatan")

        While value <> ""
            daftarCatatan.Items.Add(value)
            value = InputBox("Catatan")
        End While
    End Sub

    Private Sub BtnOwner_Click(sender As Object, e As EventArgs) Handles BtnOwner.Click
        UbahTeks("Melissa Owner")
    End Sub
End Class
