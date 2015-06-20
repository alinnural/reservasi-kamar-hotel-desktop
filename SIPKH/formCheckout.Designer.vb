<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class formCheckout
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
        Me.dateCheckout = New System.Windows.Forms.DateTimePicker()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtIdkamar = New System.Windows.Forms.TextBox()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dateCheckIn = New System.Windows.Forms.DateTimePicker()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnCheckout = New System.Windows.Forms.Button()
        Me.txtIdtransaksi = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dateCheckout
        '
        Me.dateCheckout.Location = New System.Drawing.Point(296, 113)
        Me.dateCheckout.Name = "dateCheckout"
        Me.dateCheckout.Size = New System.Drawing.Size(137, 20)
        Me.dateCheckout.TabIndex = 82
        '
        'txtAlamat
        '
        Me.txtAlamat.Location = New System.Drawing.Point(139, 49)
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(100, 20)
        Me.txtAlamat.TabIndex = 77
        '
        'txtIdkamar
        '
        Me.txtIdkamar.Location = New System.Drawing.Point(139, 79)
        Me.txtIdkamar.Name = "txtIdkamar"
        Me.txtIdkamar.Size = New System.Drawing.Size(100, 20)
        Me.txtIdkamar.TabIndex = 80
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(139, 17)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(100, 20)
        Me.txtNama.TabIndex = 76
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(280, 118)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(10, 13)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "-"
        '
        'dateCheckIn
        '
        Me.dateCheckIn.Location = New System.Drawing.Point(139, 113)
        Me.dateCheckIn.Name = "dateCheckIn"
        Me.dateCheckIn.Size = New System.Drawing.Size(137, 20)
        Me.dateCheckIn.TabIndex = 81
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(19, 52)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 75
        Me.Label5.Text = "Alamat"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(19, 86)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 13)
        Me.Label2.TabIndex = 78
        Me.Label2.Text = "Nomor Kamar"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(19, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 74
        Me.Label4.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(19, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(46, 13)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Tanggal"
        '
        'btnCheckout
        '
        Me.btnCheckout.Location = New System.Drawing.Point(358, 154)
        Me.btnCheckout.Name = "btnCheckout"
        Me.btnCheckout.Size = New System.Drawing.Size(75, 23)
        Me.btnCheckout.TabIndex = 84
        Me.btnCheckout.Text = "Check Out"
        Me.btnCheckout.UseVisualStyleBackColor = True
        '
        'txtIdtransaksi
        '
        Me.txtIdtransaksi.Location = New System.Drawing.Point(385, 17)
        Me.txtIdtransaksi.Name = "txtIdtransaksi"
        Me.txtIdtransaksi.Size = New System.Drawing.Size(100, 20)
        Me.txtIdtransaksi.TabIndex = 86
        '
        'formCheckout
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(504, 203)
        Me.Controls.Add(Me.txtIdtransaksi)
        Me.Controls.Add(Me.btnCheckout)
        Me.Controls.Add(Me.dateCheckout)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtIdkamar)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.dateCheckIn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "formCheckout"
        Me.Text = " "
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dateCheckout As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtAlamat As System.Windows.Forms.TextBox
    Friend WithEvents txtIdkamar As System.Windows.Forms.TextBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents dateCheckIn As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnCheckout As System.Windows.Forms.Button
    Friend WithEvents txtIdtransaksi As System.Windows.Forms.TextBox
End Class
