<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SenaraiPelawat
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SenaraiPelawat))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.ListBox4 = New System.Windows.Forms.ListBox()
        Me.PELAWATBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DBDataSet = New SJKC.DBDataSet()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.PELAWATTableAdapter = New SJKC.DBDataSetTableAdapters.PELAWATTableAdapter()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        CType(Me.PELAWATBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.White
        Me.Button1.Font = New System.Drawing.Font("Showcard Gothic", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(872, 437)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(101, 41)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "KEMBALI"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(357, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(255, 33)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "SENARAI PELAWAT"
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.White
        Me.Button4.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(737, 290)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(96, 33)
        Me.Button4.TabIndex = 11
        Me.Button4.Text = "BUANG"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.White
        Me.Button3.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(737, 216)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(96, 33)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "EDIT"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.White
        Me.Button2.Font = New System.Drawing.Font("Showcard Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(737, 144)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(96, 33)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "TAMBAH"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(842, 12)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(128, 117)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 13
        Me.PictureBox2.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(128, 117)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 12
        Me.PictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(209, Byte), Integer), CType(CType(3, Byte), Integer), CType(CType(11, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(1, 64)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(983, 12)
        Me.Panel1.TabIndex = 14
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(244, Byte), Integer), CType(CType(220, Byte), Integer), CType(CType(6, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-1, -15)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(988, 79)
        Me.Panel2.TabIndex = 15
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(12, Byte), Integer), CType(CType(100, Byte), Integer), CType(CType(186, Byte), Integer))
        Me.Panel3.Controls.Add(Me.ListBox4)
        Me.Panel3.Controls.Add(Me.ListBox3)
        Me.Panel3.Controls.Add(Me.ListBox2)
        Me.Panel3.Controls.Add(Me.ListBox1)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Controls.Add(Me.Button1)
        Me.Panel3.Controls.Add(Me.Button4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Button3)
        Me.Panel3.Location = New System.Drawing.Point(-1, 71)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(985, 491)
        Me.Panel3.TabIndex = 16
        '
        'ListBox4
        '
        Me.ListBox4.DataSource = Me.PELAWATBindingSource
        Me.ListBox4.DisplayMember = "ORIGIN"
        Me.ListBox4.FormattingEnabled = True
        Me.ListBox4.Location = New System.Drawing.Point(555, 81)
        Me.ListBox4.Name = "ListBox4"
        Me.ListBox4.Size = New System.Drawing.Size(118, 368)
        Me.ListBox4.TabIndex = 28
        '
        'PELAWATBindingSource
        '
        Me.PELAWATBindingSource.DataMember = "PELAWAT"
        Me.PELAWATBindingSource.DataSource = Me.DBDataSetBindingSource
        '
        'DBDataSetBindingSource
        '
        Me.DBDataSetBindingSource.DataSource = Me.DBDataSet
        Me.DBDataSetBindingSource.Position = 0
        '
        'DBDataSet
        '
        Me.DBDataSet.DataSetName = "DBDataSet"
        Me.DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ListBox3
        '
        Me.ListBox3.DataSource = Me.PELAWATBindingSource
        Me.ListBox3.DisplayMember = "PMAJIKAN"
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Location = New System.Drawing.Point(345, 81)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(212, 368)
        Me.ListBox3.TabIndex = 27
        '
        'ListBox2
        '
        Me.ListBox2.DataSource = Me.PELAWATBindingSource
        Me.ListBox2.DisplayMember = "PNAMA"
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Location = New System.Drawing.Point(97, 81)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(251, 368)
        Me.ListBox2.TabIndex = 26
        '
        'ListBox1
        '
        Me.ListBox1.DataSource = Me.PELAWATBindingSource
        Me.ListBox1.DisplayMember = "ID"
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(34, 81)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(64, 368)
        Me.ListBox1.TabIndex = 25
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.White
        Me.Panel4.Controls.Add(Me.Label2)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Controls.Add(Me.Label5)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Location = New System.Drawing.Point(34, 64)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(638, 21)
        Me.Panel4.TabIndex = 32
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(21, 0)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(18, 13)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(165, 0)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 19
        Me.Label3.Text = "Nama"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(554, 0)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 21
        Me.Label5.Text = "Negeri"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(396, 0)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(45, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Syarikat"
        '
        'PELAWATTableAdapter
        '
        Me.PELAWATTableAdapter.ClearBeforeFill = True
        '
        'SenaraiPelawat
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(984, 561)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel3)
        Me.Name = "SenaraiPelawat"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SenaraiPelawat"
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        CType(Me.PELAWATBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents ListBox4 As ListBox
    Friend WithEvents ListBox3 As ListBox
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DBDataSetBindingSource As BindingSource
    Friend WithEvents DBDataSet As DBDataSet
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents PELAWATBindingSource As BindingSource
    Friend WithEvents PELAWATTableAdapter As DBDataSetTableAdapters.PELAWATTableAdapter
End Class
