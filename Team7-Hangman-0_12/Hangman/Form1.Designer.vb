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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnLyd = New System.Windows.Forms.Button()
        Me.btnBakgrunn = New System.Windows.Forms.Button()
        Me.btnAvslutt = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLyd
        '
        Me.btnLyd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLyd.BackgroundImage = Global.Hangman.My.Resources.Resources.imglydav
        Me.btnLyd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLyd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLyd.FlatAppearance.BorderSize = 3
        Me.btnLyd.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLyd.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnLyd.Location = New System.Drawing.Point(1090, 155)
        Me.btnLyd.Name = "btnLyd"
        Me.btnLyd.Size = New System.Drawing.Size(160, 45)
        Me.btnLyd.TabIndex = 2
        Me.btnLyd.UseVisualStyleBackColor = False
        '
        'btnBakgrunn
        '
        Me.btnBakgrunn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBakgrunn.BackgroundImage = Global.Hangman.My.Resources.Resources.imgbakgrunn
        Me.btnBakgrunn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBakgrunn.Enabled = False
        Me.btnBakgrunn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBakgrunn.FlatAppearance.BorderSize = 3
        Me.btnBakgrunn.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBakgrunn.Location = New System.Drawing.Point(1090, 235)
        Me.btnBakgrunn.Name = "btnBakgrunn"
        Me.btnBakgrunn.Size = New System.Drawing.Size(160, 45)
        Me.btnBakgrunn.TabIndex = 3
        Me.btnBakgrunn.TabStop = False
        Me.btnBakgrunn.UseVisualStyleBackColor = False
        Me.btnBakgrunn.Visible = False
        '
        'btnAvslutt
        '
        Me.btnAvslutt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAvslutt.BackgroundImage = Global.Hangman.My.Resources.Resources.imgavslutt
        Me.btnAvslutt.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAvslutt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAvslutt.FlatAppearance.BorderSize = 3
        Me.btnAvslutt.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvslutt.Location = New System.Drawing.Point(1090, 315)
        Me.btnAvslutt.Name = "btnAvslutt"
        Me.btnAvslutt.Size = New System.Drawing.Size(160, 45)
        Me.btnAvslutt.TabIndex = 4
        Me.btnAvslutt.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStart.BackgroundImage = CType(resources.GetObject("btnStart.BackgroundImage"), System.Drawing.Image)
        Me.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.BorderSize = 3
        Me.btnStart.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnStart.Location = New System.Drawing.Point(1090, 75)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(160, 45)
        Me.btnStart.TabIndex = 5
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = Global.Hangman.My.Resources.Resources.imgspilleregler
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(726, 403)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(478, 305)
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.bakgrunn
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnAvslutt)
        Me.Controls.Add(Me.btnBakgrunn)
        Me.Controls.Add(Me.btnLyd)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLyd As Button
    Friend WithEvents btnBakgrunn As Button
    Friend WithEvents btnAvslutt As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox1 As PictureBox
End Class
