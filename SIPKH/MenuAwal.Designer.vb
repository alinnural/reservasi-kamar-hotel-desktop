<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuAwal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.AkunToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsUbahData = New System.Windows.Forms.ToolStripMenuItem()
        Me.KeluarToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblIdpeg = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.tabPegawai = New System.Windows.Forms.TabPage()
        Me.btnTambahpegawai = New System.Windows.Forms.Button()
        Me.btnHapuspegawai = New System.Windows.Forms.Button()
        Me.btnRefreshpegawai = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnCaripegawai = New System.Windows.Forms.Button()
        Me.dgvPegawai = New System.Windows.Forms.DataGridView()
        Me.txtCaripegawai = New System.Windows.Forms.TextBox()
        Me.tabFasilitas = New System.Windows.Forms.TabPage()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnTambah = New System.Windows.Forms.Button()
        Me.btnRefreshfasilitas = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnCarifasilitas = New System.Windows.Forms.Button()
        Me.dgvFasilitas = New System.Windows.Forms.DataGridView()
        Me.txtCarifasilitas = New System.Windows.Forms.TextBox()
        Me.tabKamar = New System.Windows.Forms.TabPage()
        Me.btnHapuskamar = New System.Windows.Forms.Button()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnRefreshkamar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCarikamar = New System.Windows.Forms.Button()
        Me.dgvKamar = New System.Windows.Forms.DataGridView()
        Me.txtCarikamar = New System.Windows.Forms.TextBox()
        Me.tabCheckout = New System.Windows.Forms.TabPage()
        Me.btnRefreshout = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCariout = New System.Windows.Forms.Button()
        Me.dgvKamarout = New System.Windows.Forms.DataGridView()
        Me.txtCariin = New System.Windows.Forms.TextBox()
        Me.tabCheckin = New System.Windows.Forms.TabPage()
        Me.btnRefreshin = New System.Windows.Forms.Button()
        Me.btnCariin = New System.Windows.Forms.Button()
        Me.txtCari = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvKamarin = New System.Windows.Forms.DataGridView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.lblStatus = New System.Windows.Forms.Label()
        Me.tabLaporan = New System.Windows.Forms.TabPage()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.db_hotelDataSet = New SIPKH.db_hotelDataSet()
        Me.tbl_transaksiBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tbl_transaksiTableAdapter = New SIPKH.db_hotelDataSetTableAdapters.tbl_transaksiTableAdapter()
        Me.MenuStrip1.SuspendLayout()
        Me.tabPegawai.SuspendLayout()
        CType(Me.dgvPegawai, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFasilitas.SuspendLayout()
        CType(Me.dgvFasilitas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabKamar.SuspendLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCheckout.SuspendLayout()
        CType(Me.dgvKamarout, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabCheckin.SuspendLayout()
        CType(Me.dgvKamarin, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.tabLaporan.SuspendLayout()
        CType(Me.db_hotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.tbl_transaksiBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AkunToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(697, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'AkunToolStripMenuItem
        '
        Me.AkunToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsUbahData, Me.KeluarToolStripMenuItem})
        Me.AkunToolStripMenuItem.Name = "AkunToolStripMenuItem"
        Me.AkunToolStripMenuItem.Size = New System.Drawing.Size(47, 20)
        Me.AkunToolStripMenuItem.Text = "Akun"
        '
        'tsUbahData
        '
        Me.tsUbahData.Name = "tsUbahData"
        Me.tsUbahData.Size = New System.Drawing.Size(129, 22)
        Me.tsUbahData.Text = "Ubah Data"
        '
        'KeluarToolStripMenuItem
        '
        Me.KeluarToolStripMenuItem.Name = "KeluarToolStripMenuItem"
        Me.KeluarToolStripMenuItem.Size = New System.Drawing.Size(129, 22)
        Me.KeluarToolStripMenuItem.Text = "Keluar"
        '
        'lblIdpeg
        '
        Me.lblIdpeg.AutoSize = True
        Me.lblIdpeg.Location = New System.Drawing.Point(10, 390)
        Me.lblIdpeg.Name = "lblIdpeg"
        Me.lblIdpeg.Size = New System.Drawing.Size(32, 13)
        Me.lblIdpeg.TabIndex = 6
        Me.lblIdpeg.Text = "admx"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Location = New System.Drawing.Point(120, 390)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(39, 13)
        Me.lblNama.TabIndex = 7
        Me.lblNama.Text = "Label3"
        '
        'tabPegawai
        '
        Me.tabPegawai.Controls.Add(Me.btnTambahpegawai)
        Me.tabPegawai.Controls.Add(Me.btnHapuspegawai)
        Me.tabPegawai.Controls.Add(Me.btnRefreshpegawai)
        Me.tabPegawai.Controls.Add(Me.Label5)
        Me.tabPegawai.Controls.Add(Me.btnCaripegawai)
        Me.tabPegawai.Controls.Add(Me.dgvPegawai)
        Me.tabPegawai.Controls.Add(Me.txtCaripegawai)
        Me.tabPegawai.Location = New System.Drawing.Point(4, 22)
        Me.tabPegawai.Name = "tabPegawai"
        Me.tabPegawai.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPegawai.Size = New System.Drawing.Size(689, 333)
        Me.tabPegawai.TabIndex = 4
        Me.tabPegawai.Text = "Pegawai"
        Me.tabPegawai.UseVisualStyleBackColor = True
        '
        'btnTambahpegawai
        '
        Me.btnTambahpegawai.Location = New System.Drawing.Point(519, 6)
        Me.btnTambahpegawai.Name = "btnTambahpegawai"
        Me.btnTambahpegawai.Size = New System.Drawing.Size(75, 23)
        Me.btnTambahpegawai.TabIndex = 20
        Me.btnTambahpegawai.Text = "Tambah"
        Me.btnTambahpegawai.UseVisualStyleBackColor = True
        '
        'btnHapuspegawai
        '
        Me.btnHapuspegawai.Location = New System.Drawing.Point(425, 6)
        Me.btnHapuspegawai.Name = "btnHapuspegawai"
        Me.btnHapuspegawai.Size = New System.Drawing.Size(75, 23)
        Me.btnHapuspegawai.TabIndex = 19
        Me.btnHapuspegawai.Text = "Hapus"
        Me.btnHapuspegawai.UseVisualStyleBackColor = True
        '
        'btnRefreshpegawai
        '
        Me.btnRefreshpegawai.Location = New System.Drawing.Point(613, 6)
        Me.btnRefreshpegawai.Name = "btnRefreshpegawai"
        Me.btnRefreshpegawai.Size = New System.Drawing.Size(57, 23)
        Me.btnRefreshpegawai.TabIndex = 18
        Me.btnRefreshpegawai.Text = "Refresh"
        Me.btnRefreshpegawai.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 3)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cari"
        '
        'btnCaripegawai
        '
        Me.btnCaripegawai.Location = New System.Drawing.Point(149, 3)
        Me.btnCaripegawai.Name = "btnCaripegawai"
        Me.btnCaripegawai.Size = New System.Drawing.Size(37, 23)
        Me.btnCaripegawai.TabIndex = 17
        Me.btnCaripegawai.Text = "Cari"
        Me.btnCaripegawai.UseVisualStyleBackColor = True
        '
        'dgvPegawai
        '
        Me.dgvPegawai.AllowUserToAddRows = False
        Me.dgvPegawai.AllowUserToDeleteRows = False
        Me.dgvPegawai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPegawai.Location = New System.Drawing.Point(0, 32)
        Me.dgvPegawai.Name = "dgvPegawai"
        Me.dgvPegawai.ReadOnly = True
        Me.dgvPegawai.Size = New System.Drawing.Size(689, 298)
        Me.dgvPegawai.TabIndex = 14
        '
        'txtCaripegawai
        '
        Me.txtCaripegawai.Location = New System.Drawing.Point(42, 3)
        Me.txtCaripegawai.Name = "txtCaripegawai"
        Me.txtCaripegawai.Size = New System.Drawing.Size(100, 20)
        Me.txtCaripegawai.TabIndex = 16
        '
        'tabFasilitas
        '
        Me.tabFasilitas.Controls.Add(Me.btnHapus)
        Me.tabFasilitas.Controls.Add(Me.btnTambah)
        Me.tabFasilitas.Controls.Add(Me.btnRefreshfasilitas)
        Me.tabFasilitas.Controls.Add(Me.Label4)
        Me.tabFasilitas.Controls.Add(Me.btnCarifasilitas)
        Me.tabFasilitas.Controls.Add(Me.dgvFasilitas)
        Me.tabFasilitas.Controls.Add(Me.txtCarifasilitas)
        Me.tabFasilitas.Location = New System.Drawing.Point(4, 22)
        Me.tabFasilitas.Name = "tabFasilitas"
        Me.tabFasilitas.Padding = New System.Windows.Forms.Padding(3)
        Me.tabFasilitas.Size = New System.Drawing.Size(689, 333)
        Me.tabFasilitas.TabIndex = 3
        Me.tabFasilitas.Text = "Fasilitas"
        Me.tabFasilitas.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(422, 6)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(75, 23)
        Me.btnHapus.TabIndex = 20
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnTambah
        '
        Me.btnTambah.Location = New System.Drawing.Point(519, 6)
        Me.btnTambah.Name = "btnTambah"
        Me.btnTambah.Size = New System.Drawing.Size(75, 23)
        Me.btnTambah.TabIndex = 19
        Me.btnTambah.Text = "Tambah"
        Me.btnTambah.UseVisualStyleBackColor = True
        '
        'btnRefreshfasilitas
        '
        Me.btnRefreshfasilitas.Location = New System.Drawing.Point(613, 6)
        Me.btnRefreshfasilitas.Name = "btnRefreshfasilitas"
        Me.btnRefreshfasilitas.Size = New System.Drawing.Size(57, 23)
        Me.btnRefreshfasilitas.TabIndex = 18
        Me.btnRefreshfasilitas.Text = "Refresh"
        Me.btnRefreshfasilitas.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 3)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 15)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Cari"
        '
        'btnCarifasilitas
        '
        Me.btnCarifasilitas.Location = New System.Drawing.Point(149, 3)
        Me.btnCarifasilitas.Name = "btnCarifasilitas"
        Me.btnCarifasilitas.Size = New System.Drawing.Size(37, 23)
        Me.btnCarifasilitas.TabIndex = 17
        Me.btnCarifasilitas.Text = "Cari"
        Me.btnCarifasilitas.UseVisualStyleBackColor = True
        '
        'dgvFasilitas
        '
        Me.dgvFasilitas.AllowUserToAddRows = False
        Me.dgvFasilitas.AllowUserToDeleteRows = False
        Me.dgvFasilitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvFasilitas.Location = New System.Drawing.Point(0, 32)
        Me.dgvFasilitas.Name = "dgvFasilitas"
        Me.dgvFasilitas.ReadOnly = True
        Me.dgvFasilitas.Size = New System.Drawing.Size(689, 298)
        Me.dgvFasilitas.TabIndex = 14
        '
        'txtCarifasilitas
        '
        Me.txtCarifasilitas.Location = New System.Drawing.Point(42, 3)
        Me.txtCarifasilitas.Name = "txtCarifasilitas"
        Me.txtCarifasilitas.Size = New System.Drawing.Size(100, 20)
        Me.txtCarifasilitas.TabIndex = 16
        '
        'tabKamar
        '
        Me.tabKamar.Controls.Add(Me.btnHapuskamar)
        Me.tabKamar.Controls.Add(Me.btnAdd)
        Me.tabKamar.Controls.Add(Me.btnRefreshkamar)
        Me.tabKamar.Controls.Add(Me.Label3)
        Me.tabKamar.Controls.Add(Me.btnCarikamar)
        Me.tabKamar.Controls.Add(Me.dgvKamar)
        Me.tabKamar.Controls.Add(Me.txtCarikamar)
        Me.tabKamar.Location = New System.Drawing.Point(4, 22)
        Me.tabKamar.Name = "tabKamar"
        Me.tabKamar.Padding = New System.Windows.Forms.Padding(3)
        Me.tabKamar.Size = New System.Drawing.Size(689, 333)
        Me.tabKamar.TabIndex = 2
        Me.tabKamar.Text = "Kamar"
        Me.tabKamar.UseVisualStyleBackColor = True
        '
        'btnHapuskamar
        '
        Me.btnHapuskamar.Location = New System.Drawing.Point(413, 6)
        Me.btnHapuskamar.Name = "btnHapuskamar"
        Me.btnHapuskamar.Size = New System.Drawing.Size(75, 23)
        Me.btnHapuskamar.TabIndex = 20
        Me.btnHapuskamar.Text = "Hapus"
        Me.btnHapuskamar.UseVisualStyleBackColor = True
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(518, 6)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 19
        Me.btnAdd.Text = "Tambah"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnRefreshkamar
        '
        Me.btnRefreshkamar.Location = New System.Drawing.Point(613, 6)
        Me.btnRefreshkamar.Name = "btnRefreshkamar"
        Me.btnRefreshkamar.Size = New System.Drawing.Size(57, 23)
        Me.btnRefreshkamar.TabIndex = 18
        Me.btnRefreshkamar.Text = "Refresh"
        Me.btnRefreshkamar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 3)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(29, 15)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Cari"
        '
        'btnCarikamar
        '
        Me.btnCarikamar.Location = New System.Drawing.Point(149, 3)
        Me.btnCarikamar.Name = "btnCarikamar"
        Me.btnCarikamar.Size = New System.Drawing.Size(37, 23)
        Me.btnCarikamar.TabIndex = 17
        Me.btnCarikamar.Text = "Cari"
        Me.btnCarikamar.UseVisualStyleBackColor = True
        '
        'dgvKamar
        '
        Me.dgvKamar.AllowUserToAddRows = False
        Me.dgvKamar.AllowUserToDeleteRows = False
        Me.dgvKamar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKamar.Location = New System.Drawing.Point(0, 32)
        Me.dgvKamar.Name = "dgvKamar"
        Me.dgvKamar.ReadOnly = True
        Me.dgvKamar.Size = New System.Drawing.Size(689, 298)
        Me.dgvKamar.TabIndex = 14
        '
        'txtCarikamar
        '
        Me.txtCarikamar.Location = New System.Drawing.Point(42, 3)
        Me.txtCarikamar.Name = "txtCarikamar"
        Me.txtCarikamar.Size = New System.Drawing.Size(100, 20)
        Me.txtCarikamar.TabIndex = 16
        '
        'tabCheckout
        '
        Me.tabCheckout.Controls.Add(Me.btnRefreshout)
        Me.tabCheckout.Controls.Add(Me.Label2)
        Me.tabCheckout.Controls.Add(Me.btnCariout)
        Me.tabCheckout.Controls.Add(Me.dgvKamarout)
        Me.tabCheckout.Controls.Add(Me.txtCariin)
        Me.tabCheckout.Location = New System.Drawing.Point(4, 22)
        Me.tabCheckout.Name = "tabCheckout"
        Me.tabCheckout.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCheckout.Size = New System.Drawing.Size(689, 333)
        Me.tabCheckout.TabIndex = 1
        Me.tabCheckout.Text = "Check Out"
        Me.tabCheckout.UseVisualStyleBackColor = True
        '
        'btnRefreshout
        '
        Me.btnRefreshout.Location = New System.Drawing.Point(613, 6)
        Me.btnRefreshout.Name = "btnRefreshout"
        Me.btnRefreshout.Size = New System.Drawing.Size(57, 23)
        Me.btnRefreshout.TabIndex = 13
        Me.btnRefreshout.Text = "Refresh"
        Me.btnRefreshout.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 3)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Cari"
        '
        'btnCariout
        '
        Me.btnCariout.Location = New System.Drawing.Point(149, 3)
        Me.btnCariout.Name = "btnCariout"
        Me.btnCariout.Size = New System.Drawing.Size(37, 23)
        Me.btnCariout.TabIndex = 12
        Me.btnCariout.Text = "Cari"
        Me.btnCariout.UseVisualStyleBackColor = True
        '
        'dgvKamarout
        '
        Me.dgvKamarout.AllowUserToAddRows = False
        Me.dgvKamarout.AllowUserToDeleteRows = False
        Me.dgvKamarout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKamarout.Location = New System.Drawing.Point(0, 32)
        Me.dgvKamarout.Name = "dgvKamarout"
        Me.dgvKamarout.ReadOnly = True
        Me.dgvKamarout.Size = New System.Drawing.Size(689, 298)
        Me.dgvKamarout.TabIndex = 9
        '
        'txtCariin
        '
        Me.txtCariin.Location = New System.Drawing.Point(42, 3)
        Me.txtCariin.Name = "txtCariin"
        Me.txtCariin.Size = New System.Drawing.Size(100, 20)
        Me.txtCariin.TabIndex = 11
        '
        'tabCheckin
        '
        Me.tabCheckin.Controls.Add(Me.btnRefreshin)
        Me.tabCheckin.Controls.Add(Me.btnCariin)
        Me.tabCheckin.Controls.Add(Me.txtCari)
        Me.tabCheckin.Controls.Add(Me.Label1)
        Me.tabCheckin.Controls.Add(Me.dgvKamarin)
        Me.tabCheckin.Location = New System.Drawing.Point(4, 22)
        Me.tabCheckin.Name = "tabCheckin"
        Me.tabCheckin.Padding = New System.Windows.Forms.Padding(3)
        Me.tabCheckin.Size = New System.Drawing.Size(689, 333)
        Me.tabCheckin.TabIndex = 0
        Me.tabCheckin.Text = "Check In"
        Me.tabCheckin.UseVisualStyleBackColor = True
        '
        'btnRefreshin
        '
        Me.btnRefreshin.Location = New System.Drawing.Point(613, 6)
        Me.btnRefreshin.Name = "btnRefreshin"
        Me.btnRefreshin.Size = New System.Drawing.Size(57, 23)
        Me.btnRefreshin.TabIndex = 5
        Me.btnRefreshin.Text = "Refresh"
        Me.btnRefreshin.UseVisualStyleBackColor = True
        '
        'btnCariin
        '
        Me.btnCariin.Location = New System.Drawing.Point(149, 3)
        Me.btnCariin.Name = "btnCariin"
        Me.btnCariin.Size = New System.Drawing.Size(37, 23)
        Me.btnCariin.TabIndex = 4
        Me.btnCariin.Text = "Cari"
        Me.btnCariin.UseVisualStyleBackColor = True
        '
        'txtCari
        '
        Me.txtCari.Location = New System.Drawing.Point(42, 3)
        Me.txtCari.Name = "txtCari"
        Me.txtCari.Size = New System.Drawing.Size(100, 20)
        Me.txtCari.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 3)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(29, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Cari"
        '
        'dgvKamarin
        '
        Me.dgvKamarin.AllowUserToAddRows = False
        Me.dgvKamarin.AllowUserToDeleteRows = False
        Me.dgvKamarin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvKamarin.Location = New System.Drawing.Point(0, 32)
        Me.dgvKamarin.Name = "dgvKamarin"
        Me.dgvKamarin.ReadOnly = True
        Me.dgvKamarin.Size = New System.Drawing.Size(689, 298)
        Me.dgvKamarin.TabIndex = 0
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.tabCheckin)
        Me.TabControl1.Controls.Add(Me.tabCheckout)
        Me.TabControl1.Controls.Add(Me.tabKamar)
        Me.TabControl1.Controls.Add(Me.tabFasilitas)
        Me.TabControl1.Controls.Add(Me.tabPegawai)
        Me.TabControl1.Controls.Add(Me.tabLaporan)
        Me.TabControl1.Location = New System.Drawing.Point(0, 28)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(697, 359)
        Me.TabControl1.TabIndex = 1
        '
        'lblStatus
        '
        Me.lblStatus.AutoSize = True
        Me.lblStatus.Location = New System.Drawing.Point(51, 390)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(66, 13)
        Me.lblStatus.TabIndex = 8
        Me.lblStatus.Text = "administrator"
        '
        'tabLaporan
        '
        Me.tabLaporan.Controls.Add(Me.ReportViewer1)
        Me.tabLaporan.Location = New System.Drawing.Point(4, 22)
        Me.tabLaporan.Name = "tabLaporan"
        Me.tabLaporan.Padding = New System.Windows.Forms.Padding(3)
        Me.tabLaporan.Size = New System.Drawing.Size(689, 333)
        Me.tabLaporan.TabIndex = 5
        Me.tabLaporan.Text = "Laporan"
        Me.tabLaporan.UseVisualStyleBackColor = True
        '
        'ReportViewer1
        '
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.tbl_transaksiBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "SIPKH.Report1.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(689, 333)
        Me.ReportViewer1.TabIndex = 0
        '
        'db_hotelDataSet
        '
        Me.db_hotelDataSet.DataSetName = "db_hotelDataSet"
        Me.db_hotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tbl_transaksiBindingSource
        '
        Me.tbl_transaksiBindingSource.DataMember = "tbl_transaksi"
        Me.tbl_transaksiBindingSource.DataSource = Me.db_hotelDataSet
        '
        'tbl_transaksiTableAdapter
        '
        Me.tbl_transaksiTableAdapter.ClearBeforeFill = True
        '
        'MenuAwal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(697, 412)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblIdpeg)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "MenuAwal"
        Me.Text = "MenuAwal"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabPegawai.ResumeLayout(False)
        Me.tabPegawai.PerformLayout()
        CType(Me.dgvPegawai, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFasilitas.ResumeLayout(False)
        Me.tabFasilitas.PerformLayout()
        CType(Me.dgvFasilitas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabKamar.ResumeLayout(False)
        Me.tabKamar.PerformLayout()
        CType(Me.dgvKamar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCheckout.ResumeLayout(False)
        Me.tabCheckout.PerformLayout()
        CType(Me.dgvKamarout, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabCheckin.ResumeLayout(False)
        Me.tabCheckin.PerformLayout()
        CType(Me.dgvKamarin, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.tabLaporan.ResumeLayout(False)
        CType(Me.db_hotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.tbl_transaksiBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents AkunToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsUbahData As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents KeluarToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lblIdpeg As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents tabPegawai As System.Windows.Forms.TabPage
    Friend WithEvents btnTambahpegawai As System.Windows.Forms.Button
    Friend WithEvents btnHapuspegawai As System.Windows.Forms.Button
    Friend WithEvents btnRefreshpegawai As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents btnCaripegawai As System.Windows.Forms.Button
    Friend WithEvents dgvPegawai As System.Windows.Forms.DataGridView
    Friend WithEvents txtCaripegawai As System.Windows.Forms.TextBox
    Friend WithEvents tabFasilitas As System.Windows.Forms.TabPage
    Friend WithEvents btnHapus As System.Windows.Forms.Button
    Friend WithEvents btnTambah As System.Windows.Forms.Button
    Friend WithEvents btnRefreshfasilitas As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnCarifasilitas As System.Windows.Forms.Button
    Friend WithEvents dgvFasilitas As System.Windows.Forms.DataGridView
    Friend WithEvents txtCarifasilitas As System.Windows.Forms.TextBox
    Friend WithEvents tabKamar As System.Windows.Forms.TabPage
    Friend WithEvents btnHapuskamar As System.Windows.Forms.Button
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnRefreshkamar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCarikamar As System.Windows.Forms.Button
    Friend WithEvents dgvKamar As System.Windows.Forms.DataGridView
    Friend WithEvents txtCarikamar As System.Windows.Forms.TextBox
    Friend WithEvents tabCheckout As System.Windows.Forms.TabPage
    Friend WithEvents btnRefreshout As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnCariout As System.Windows.Forms.Button
    Friend WithEvents dgvKamarout As System.Windows.Forms.DataGridView
    Friend WithEvents txtCariin As System.Windows.Forms.TextBox
    Friend WithEvents tabCheckin As System.Windows.Forms.TabPage
    Friend WithEvents btnRefreshin As System.Windows.Forms.Button
    Friend WithEvents btnCariin As System.Windows.Forms.Button
    Friend WithEvents txtCari As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgvKamarin As System.Windows.Forms.DataGridView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents tabLaporan As System.Windows.Forms.TabPage
    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents tbl_transaksiBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents db_hotelDataSet As SIPKH.db_hotelDataSet
    Friend WithEvents tbl_transaksiTableAdapter As SIPKH.db_hotelDataSetTableAdapters.tbl_transaksiTableAdapter
End Class
