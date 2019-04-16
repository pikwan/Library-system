<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Kemaskini
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Kemaskini))
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.A = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.K = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.DOB = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.KP = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.ID = New System.Windows.Forms.TextBox()
        Me.BC = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.NAMA = New System.Windows.Forms.TextBox()
        Me.STUDENTSBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New SJKC.DBDataSet()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.STUDENTSTableAdapter = New SJKC.DBDataSetTableAdapters.STUDENTSTableAdapter()
        Me.GetStudDetToolStrip = New System.Windows.Forms.ToolStrip()
        Me.GetStudDetToolStripButton = New System.Windows.Forms.ToolStripButton()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.STUDENTSBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GetStudDetToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(841, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(10, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(292, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(414, 33)
        Me.Label1.TabIndex = 17
        Me.Label1.Text = "KEMASKINI MAKLUMAT MURID"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(-4, 60)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(985, 12)
        Me.Panel1.TabIndex = 20
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(-4, -17)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(986, 79)
        Me.Panel2.TabIndex = 21
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(-3, 63)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(988, 492)
        Me.Panel3.TabIndex = 22
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.A)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.K)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.DOB)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.KP)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.ID)
        Me.GroupBox1.Controls.Add(Me.BC)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.NAMA)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(763, 258)
        Me.GroupBox1.TabIndex = 14
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'A
        '
        Me.A.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.A.Location = New System.Drawing.Point(432, 192)
        Me.A.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.A.Name = "A"
        Me.A.Size = New System.Drawing.Size(108, 32)
        Me.A.TabIndex = 25
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(340, 192)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(92, 25)
        Me.Label8.TabIndex = 24
        Me.Label8.Text = "AGAMA : "
        '
        'K
        '
        Me.K.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.K.Location = New System.Drawing.Point(92, 189)
        Me.K.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.K.Name = "K"
        Me.K.Size = New System.Drawing.Size(108, 32)
        Me.K.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 192)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(79, 25)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "KAUM : "
        '
        'DOB
        '
        Me.DOB.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DOB.Location = New System.Drawing.Point(161, 98)
        Me.DOB.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.DOB.Name = "DOB"
        Me.DOB.Size = New System.Drawing.Size(378, 32)
        Me.DOB.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 103)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(143, 25)
        Me.Label6.TabIndex = 20
        Me.Label6.Text = "TARIKH LAHIR : "
        '
        'KP
        '
        Me.KP.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.KP.Location = New System.Drawing.Point(103, 63)
        Me.KP.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.KP.Name = "KP"
        Me.KP.Size = New System.Drawing.Size(437, 32)
        Me.KP.TabIndex = 19
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 63)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 25)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "NO KP : "
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Label4.Location = New System.Drawing.Point(568, 22)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "ID MURID :"
        '
        'ID
        '
        Me.ID.Enabled = False
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ID.Location = New System.Drawing.Point(634, 22)
        Me.ID.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(114, 62)
        Me.ID.TabIndex = 17
        '
        'BC
        '
        Me.BC.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BC.Location = New System.Drawing.Point(161, 136)
        Me.BC.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.BC.Name = "BC"
        Me.BC.Size = New System.Drawing.Size(378, 32)
        Me.BC.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 141)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(151, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "NO SIJIL LAHIR : "
        '
        'NAMA
        '
        Me.NAMA.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.STUDENTSBindingSource, "NAMA", True))
        Me.NAMA.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NAMA.Location = New System.Drawing.Point(103, 26)
        Me.NAMA.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.NAMA.Name = "NAMA"
        Me.NAMA.Size = New System.Drawing.Size(437, 32)
        Me.NAMA.TabIndex = 13
        '
        'STUDENTSBindingSource
        '
        Me.STUDENTSBindingSource.DataMember = "STUDENTS"
        Me.STUDENTSBindingSource.DataSource = Me.DBDataSet
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 26)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "NAMA : "
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(872, 435)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(872, 301)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 33)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "BUANG"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(872, 132)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "TAMBAH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(872, 217)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'STUDENTSTableAdapter
        '
        Me.STUDENTSTableAdapter.ClearBeforeFill = True
        '
        'GetStudDetToolStrip
        '
        Me.GetStudDetToolStrip.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.GetStudDetToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.GetStudDetToolStripButton})
        Me.GetStudDetToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.GetStudDetToolStrip.Name = "GetStudDetToolStrip"
        Me.GetStudDetToolStrip.Size = New System.Drawing.Size(986, 25)
        Me.GetStudDetToolStrip.TabIndex = 23
        Me.GetStudDetToolStrip.Text = "GetStudDetToolStrip"
        '
        'GetStudDetToolStripButton
        '
        Me.GetStudDetToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.GetStudDetToolStripButton.Name = "GetStudDetToolStripButton"
        Me.GetStudDetToolStripButton.Size = New System.Drawing.Size(70, 22)
        Me.GetStudDetToolStripButton.Text = "getStudDet"
        '
        'Kemaskini
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 554)
        Me.Controls.Add(Me.GetStudDetToolStrip)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Margin = New System.Windows.Forms.Padding(2, 2, 2, 2)
        Me.Name = "Kemaskini"
        Me.Text = "Kemaskini"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.STUDENTSBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GetStudDetToolStrip.ResumeLayout(False)
        Me.GetStudDetToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Button1 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents A As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents K As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents DOB As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents KP As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents ID As TextBox
    Friend WithEvents BC As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents NAMA As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents STUDENTSBindingSource As BindingSource
    Friend WithEvents STUDENTSTableAdapter As DBDataSetTableAdapters.STUDENTSTableAdapter
    Friend WithEvents GetStudDetToolStrip As ToolStrip
    Friend WithEvents GetStudDetToolStripButton As ToolStripButton
End Class
