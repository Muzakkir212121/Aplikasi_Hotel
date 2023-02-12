<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.TXTAlamat = New System.Windows.Forms.TextBox()
        Me.TXTNomor = New System.Windows.Forms.TextBox()
        Me.TXTNama = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.TXTBiaya = New System.Windows.Forms.TextBox()
        Me.TXTLama = New System.Windows.Forms.TextBox()
        Me.TXTHarga = New System.Windows.Forms.TextBox()
        Me.CBJenis = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.BTClose = New System.Windows.Forms.Button()
        Me.BTNew = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TXTKembalian = New System.Windows.Forms.TextBox()
        Me.TXTBayar = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.BTNFoto = New System.Windows.Forms.Button()
        Me.btnCat = New System.Windows.Forms.Button()
        Me.daftarCatatan = New System.Windows.Forms.ListBox()
        Me.FotoTamu = New System.Windows.Forms.PictureBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.BtnOwner = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        CType(Me.FotoTamu, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox1.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox1.Controls.Add(Me.TXTAlamat)
        Me.GroupBox1.Controls.Add(Me.TXTNomor)
        Me.GroupBox1.Controls.Add(Me.TXTNama)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(374, 223)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "[DATA PEMESANAN]"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DateTimePicker1.Location = New System.Drawing.Point(142, 178)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(88, 23)
        Me.DateTimePicker1.TabIndex = 7
        '
        'TXTAlamat
        '
        Me.TXTAlamat.Location = New System.Drawing.Point(143, 106)
        Me.TXTAlamat.Multiline = True
        Me.TXTAlamat.Name = "TXTAlamat"
        Me.TXTAlamat.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TXTAlamat.Size = New System.Drawing.Size(208, 61)
        Me.TXTAlamat.TabIndex = 6
        '
        'TXTNomor
        '
        Me.TXTNomor.Location = New System.Drawing.Point(143, 65)
        Me.TXTNomor.Name = "TXTNomor"
        Me.TXTNomor.Size = New System.Drawing.Size(208, 23)
        Me.TXTNomor.TabIndex = 5
        '
        'TXTNama
        '
        Me.TXTNama.Location = New System.Drawing.Point(143, 26)
        Me.TXTNama.Name = "TXTNama"
        Me.TXTNama.Size = New System.Drawing.Size(208, 23)
        Me.TXTNama.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 176)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tanggal Booking"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 107)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 68)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(89, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nomor Telepon"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(103, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama Pemesanan"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox2.Controls.Add(Me.TXTBiaya)
        Me.GroupBox2.Controls.Add(Me.TXTLama)
        Me.GroupBox2.Controls.Add(Me.TXTHarga)
        Me.GroupBox2.Controls.Add(Me.CBJenis)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(397, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(394, 222)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "[BOOKING PRICE]"
        '
        'TXTBiaya
        '
        Me.TXTBiaya.Location = New System.Drawing.Point(155, 164)
        Me.TXTBiaya.Name = "TXTBiaya"
        Me.TXTBiaya.Size = New System.Drawing.Size(213, 23)
        Me.TXTBiaya.TabIndex = 7
        '
        'TXTLama
        '
        Me.TXTLama.Location = New System.Drawing.Point(155, 117)
        Me.TXTLama.Name = "TXTLama"
        Me.TXTLama.Size = New System.Drawing.Size(213, 23)
        Me.TXTLama.TabIndex = 6
        '
        'TXTHarga
        '
        Me.TXTHarga.Location = New System.Drawing.Point(155, 73)
        Me.TXTHarga.Name = "TXTHarga"
        Me.TXTHarga.Size = New System.Drawing.Size(213, 23)
        Me.TXTHarga.TabIndex = 5
        '
        'CBJenis
        '
        Me.CBJenis.FormattingEnabled = True
        Me.CBJenis.Items.AddRange(New Object() {"VIP", "Kelas I", "Keas II", "Kelas III"})
        Me.CBJenis.Location = New System.Drawing.Point(156, 31)
        Me.CBJenis.Name = "CBJenis"
        Me.CBJenis.Size = New System.Drawing.Size(212, 23)
        Me.CBJenis.TabIndex = 4
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(23, 167)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(102, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Biaya Sewa Kamar"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(23, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Lama Menginap"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(23, 75)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(114, 15)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Harga Sewa Per Hari"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(23, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(69, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Jenis Kamar"
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox3.Controls.Add(Me.BTClose)
        Me.GroupBox3.Controls.Add(Me.BTNew)
        Me.GroupBox3.Location = New System.Drawing.Point(405, 434)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(394, 66)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "[NAVIGASI]"
        '
        'BTClose
        '
        Me.BTClose.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BTClose.Location = New System.Drawing.Point(235, 22)
        Me.BTClose.Name = "BTClose"
        Me.BTClose.Size = New System.Drawing.Size(75, 33)
        Me.BTClose.TabIndex = 1
        Me.BTClose.Text = "&CLOSE"
        Me.BTClose.UseVisualStyleBackColor = False
        '
        'BTNew
        '
        Me.BTNew.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.BTNew.Location = New System.Drawing.Point(86, 22)
        Me.BTNew.Name = "BTNew"
        Me.BTNew.Size = New System.Drawing.Size(75, 33)
        Me.BTNew.TabIndex = 0
        Me.BTNew.Text = "&NEW"
        Me.BTNew.UseVisualStyleBackColor = False
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.SystemColors.GradientInactiveCaption
        Me.GroupBox4.Controls.Add(Me.TXTKembalian)
        Me.GroupBox4.Controls.Add(Me.TXTBayar)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(398, 239)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(392, 123)
        Me.GroupBox4.TabIndex = 3
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "[PEMBAYARAN]"
        '
        'TXTKembalian
        '
        Me.TXTKembalian.Location = New System.Drawing.Point(151, 87)
        Me.TXTKembalian.Name = "TXTKembalian"
        Me.TXTKembalian.Size = New System.Drawing.Size(160, 23)
        Me.TXTKembalian.TabIndex = 3
        '
        'TXTBayar
        '
        Me.TXTBayar.Location = New System.Drawing.Point(151, 40)
        Me.TXTBayar.Name = "TXTBayar"
        Me.TXTBayar.Size = New System.Drawing.Size(160, 23)
        Me.TXTBayar.TabIndex = 2
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(48, 90)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(63, 15)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Kembalian"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(38, 43)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(77, 15)
        Me.Label9.TabIndex = 0
        Me.Label9.Text = "Jumlah Bayar"
        '
        'BTNFoto
        '
        Me.BTNFoto.Location = New System.Drawing.Point(11, 339)
        Me.BTNFoto.Name = "BTNFoto"
        Me.BTNFoto.Size = New System.Drawing.Size(90, 23)
        Me.BTNFoto.TabIndex = 5
        Me.BTNFoto.Text = "Upload KTP"
        Me.BTNFoto.UseVisualStyleBackColor = True
        '
        'btnCat
        '
        Me.btnCat.Location = New System.Drawing.Point(12, 476)
        Me.btnCat.Name = "btnCat"
        Me.btnCat.Size = New System.Drawing.Size(88, 24)
        Me.btnCat.TabIndex = 7
        Me.btnCat.Text = "Catatan"
        Me.btnCat.UseVisualStyleBackColor = True
        '
        'daftarCatatan
        '
        Me.daftarCatatan.FormattingEnabled = True
        Me.daftarCatatan.ItemHeight = 15
        Me.daftarCatatan.Location = New System.Drawing.Point(106, 377)
        Me.daftarCatatan.Name = "daftarCatatan"
        Me.daftarCatatan.Size = New System.Drawing.Size(282, 124)
        Me.daftarCatatan.TabIndex = 8
        '
        'FotoTamu
        '
        Me.FotoTamu.Location = New System.Drawing.Point(106, 242)
        Me.FotoTamu.Name = "FotoTamu"
        Me.FotoTamu.Size = New System.Drawing.Size(279, 120)
        Me.FotoTamu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.FotoTamu.TabIndex = 9
        Me.FotoTamu.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(470, 378)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(43, 15)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Admin"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(549, 375)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(163, 23)
        Me.TextBox1.TabIndex = 11
        Me.TextBox1.Text = "Isikan Nama Penginput"
        '
        'BtnOwner
        '
        Me.BtnOwner.Location = New System.Drawing.Point(549, 405)
        Me.BtnOwner.Name = "BtnOwner"
        Me.BtnOwner.Size = New System.Drawing.Size(103, 23)
        Me.BtnOwner.TabIndex = 12
        Me.BtnOwner.Text = "Ganti Owner"
        Me.BtnOwner.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.MenuBar
        Me.ClientSize = New System.Drawing.Size(811, 530)
        Me.Controls.Add(Me.BtnOwner)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.FotoTamu)
        Me.Controls.Add(Me.daftarCatatan)
        Me.Controls.Add(Me.btnCat)
        Me.Controls.Add(Me.BTNFoto)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Aplikasi Pemesanan Hotel"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.FotoTamu, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents TXTAlamat As TextBox
    Friend WithEvents TXTNomor As TextBox
    Friend WithEvents TXTNama As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents TXTBiaya As TextBox
    Friend WithEvents TXTLama As TextBox
    Friend WithEvents TXTHarga As TextBox
    Friend WithEvents CBJenis As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents BTClose As Button
    Friend WithEvents BTNew As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TXTKembalian As TextBox
    Friend WithEvents TXTBayar As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents BTNFoto As Button
    Friend WithEvents btnCat As Button
    Friend WithEvents daftarCatatan As ListBox
    Friend WithEvents FotoTamu As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents BtnOwner As Button
End Class
