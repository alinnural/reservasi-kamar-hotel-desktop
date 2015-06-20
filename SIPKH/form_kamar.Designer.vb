<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class form_kamar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(form_kamar))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtIdtype = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtHarga = New System.Windows.Forms.TextBox()
        Me.btnSimpantype = New System.Windows.Forms.Button()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.btnTambahtype = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cmbType = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtJum = New System.Windows.Forms.TextBox()
        Me.btnSimpankamar = New System.Windows.Forms.Button()
        Me.btnTambahkamar = New System.Windows.Forms.Button()
        Me.txtLantai = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(174, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Tambah Type Kamar"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(76, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Id Type Kamar"
        '
        'txtIdtype
        '
        Me.txtIdtype.Location = New System.Drawing.Point(120, 123)
        Me.txtIdtype.Name = "txtIdtype"
        Me.txtIdtype.Size = New System.Drawing.Size(100, 20)
        Me.txtIdtype.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(20, 164)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(31, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Type"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(20, 201)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(36, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Harga"
        '
        'txtHarga
        '
        Me.txtHarga.Location = New System.Drawing.Point(120, 198)
        Me.txtHarga.Name = "txtHarga"
        Me.txtHarga.Size = New System.Drawing.Size(100, 20)
        Me.txtHarga.TabIndex = 7
        '
        'btnSimpantype
        '
        Me.btnSimpantype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpantype.Image = CType(resources.GetObject("btnSimpantype.Image"), System.Drawing.Image)
        Me.btnSimpantype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpantype.Location = New System.Drawing.Point(203, 236)
        Me.btnSimpantype.Name = "btnSimpantype"
        Me.btnSimpantype.Size = New System.Drawing.Size(93, 33)
        Me.btnSimpantype.TabIndex = 12
        Me.btnSimpantype.Text = "Simpan"
        Me.btnSimpantype.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpantype.UseVisualStyleBackColor = True
        '
        'txtType
        '
        Me.txtType.Location = New System.Drawing.Point(120, 159)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(100, 20)
        Me.txtType.TabIndex = 14
        '
        'btnTambahtype
        '
        Me.btnTambahtype.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahtype.Image = CType(resources.GetObject("btnTambahtype.Image"), System.Drawing.Image)
        Me.btnTambahtype.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahtype.Location = New System.Drawing.Point(99, 236)
        Me.btnTambahtype.Name = "btnTambahtype"
        Me.btnTambahtype.Size = New System.Drawing.Size(101, 33)
        Me.btnTambahtype.TabIndex = 15
        Me.btnTambahtype.Text = "Tambah"
        Me.btnTambahtype.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambahtype.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(12, 236)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(84, 33)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Batal"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Lucida Bright", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(334, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Tambah Kamar"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(344, 123)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(64, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Type Kamar"
        '
        'cmbType
        '
        Me.cmbType.FormattingEnabled = True
        Me.cmbType.Location = New System.Drawing.Point(437, 120)
        Me.cmbType.Name = "cmbType"
        Me.cmbType.Size = New System.Drawing.Size(100, 21)
        Me.cmbType.TabIndex = 9
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(344, 167)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(40, 13)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Jumlah"
        '
        'txtJum
        '
        Me.txtJum.Location = New System.Drawing.Point(437, 164)
        Me.txtJum.Name = "txtJum"
        Me.txtJum.Size = New System.Drawing.Size(100, 20)
        Me.txtJum.TabIndex = 11
        '
        'btnSimpankamar
        '
        Me.btnSimpankamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSimpankamar.Image = CType(resources.GetObject("btnSimpankamar.Image"), System.Drawing.Image)
        Me.btnSimpankamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnSimpankamar.Location = New System.Drawing.Point(525, 236)
        Me.btnSimpankamar.Name = "btnSimpankamar"
        Me.btnSimpankamar.Size = New System.Drawing.Size(96, 33)
        Me.btnSimpankamar.TabIndex = 13
        Me.btnSimpankamar.Text = "Simpan"
        Me.btnSimpankamar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnSimpankamar.UseVisualStyleBackColor = True
        '
        'btnTambahkamar
        '
        Me.btnTambahkamar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahkamar.Image = CType(resources.GetObject("btnTambahkamar.Image"), System.Drawing.Image)
        Me.btnTambahkamar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTambahkamar.Location = New System.Drawing.Point(421, 236)
        Me.btnTambahkamar.Name = "btnTambahkamar"
        Me.btnTambahkamar.Size = New System.Drawing.Size(100, 33)
        Me.btnTambahkamar.TabIndex = 16
        Me.btnTambahkamar.Text = "Tambah"
        Me.btnTambahkamar.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnTambahkamar.UseVisualStyleBackColor = True
        '
        'txtLantai
        '
        Me.txtLantai.Location = New System.Drawing.Point(437, 204)
        Me.txtLantai.Name = "txtLantai"
        Me.txtLantai.Size = New System.Drawing.Size(100, 20)
        Me.txtLantai.TabIndex = 17
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(345, 207)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(36, 13)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Lantai"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Image = CType(resources.GetObject("Button1.Image"), System.Drawing.Image)
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(334, 236)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(85, 33)
        Me.Button1.TabIndex = 20
        Me.Button1.Text = "Batal"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(625, 25)
        Me.Panel1.TabIndex = 22
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.MediumTurquoise
        Me.Panel2.Location = New System.Drawing.Point(0, 321)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(624, 22)
        Me.Panel2.TabIndex = 23
        '
        'form_kamar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(625, 342)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtLantai)
        Me.Controls.Add(Me.btnTambahkamar)
        Me.Controls.Add(Me.btnTambahtype)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.btnSimpankamar)
        Me.Controls.Add(Me.btnSimpantype)
        Me.Controls.Add(Me.txtJum)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbType)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtHarga)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtIdtype)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "form_kamar"
        Me.Text = "form_kamar"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtIdtype As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtHarga As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpantype As System.Windows.Forms.Button
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents btnTambahtype As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents cmbType As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtJum As System.Windows.Forms.TextBox
    Friend WithEvents btnSimpankamar As System.Windows.Forms.Button
    Friend WithEvents btnTambahkamar As System.Windows.Forms.Button
    Friend WithEvents txtLantai As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
End Class
