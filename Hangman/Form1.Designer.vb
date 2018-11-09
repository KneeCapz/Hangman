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
        Me.btnLyd = New System.Windows.Forms.Button()
        Me.btnBakgrunn = New System.Windows.Forms.Button()
        Me.btnAvslutt = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblRegler = New System.Windows.Forms.Label()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLyd
        '
        Me.btnLyd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLyd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLyd.FlatAppearance.BorderSize = 3
        Me.btnLyd.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLyd.Location = New System.Drawing.Point(1105, 155)
        Me.btnLyd.Name = "btnLyd"
        Me.btnLyd.Size = New System.Drawing.Size(150, 40)
        Me.btnLyd.TabIndex = 2
        Me.btnLyd.Text = "Musikk av"
        Me.btnLyd.UseVisualStyleBackColor = False
        '
        'btnBakgrunn
        '
        Me.btnBakgrunn.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnBakgrunn.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnBakgrunn.FlatAppearance.BorderSize = 3
        Me.btnBakgrunn.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBakgrunn.Location = New System.Drawing.Point(1105, 235)
        Me.btnBakgrunn.Name = "btnBakgrunn"
        Me.btnBakgrunn.Size = New System.Drawing.Size(150, 40)
        Me.btnBakgrunn.TabIndex = 3
        Me.btnBakgrunn.Text = "Bytt bakgrunn"
        Me.btnBakgrunn.UseVisualStyleBackColor = False
        Me.btnBakgrunn.Visible = False
        '
        'btnAvslutt
        '
        Me.btnAvslutt.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAvslutt.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAvslutt.FlatAppearance.BorderSize = 3
        Me.btnAvslutt.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvslutt.Location = New System.Drawing.Point(1105, 315)
        Me.btnAvslutt.Name = "btnAvslutt"
        Me.btnAvslutt.Size = New System.Drawing.Size(150, 40)
        Me.btnAvslutt.TabIndex = 4
        Me.btnAvslutt.Text = "Avslutt"
        Me.btnAvslutt.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnStart.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnStart.FlatAppearance.BorderSize = 3
        Me.btnStart.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(1105, 75)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(150, 40)
        Me.btnStart.TabIndex = 5
        Me.btnStart.Text = "Start spill"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblRegler
        '
        Me.lblRegler.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.lblRegler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblRegler.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRegler.ForeColor = System.Drawing.Color.Black
        Me.lblRegler.Location = New System.Drawing.Point(720, 411)
        Me.lblRegler.Name = "lblRegler"
        Me.lblRegler.Size = New System.Drawing.Size(277, 172)
        Me.lblRegler.TabIndex = 6
        Me.lblRegler.Text = "Skriv inn et hemmelig ord" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "på maks 10 bokstaver. La en" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "annen komme fram til orde" &
    "t" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ved å gjette bokstaver. Om" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "en gjetter feil bokstav 5" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "ganger er spillet over" &
    "."
        Me.lblRegler.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.bakgrunn
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.lblRegler)
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
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnLyd As Button
    Friend WithEvents btnBakgrunn As Button
    Friend WithEvents btnAvslutt As Button
    Friend WithEvents btnStart As Button
    Friend WithEvents lblRegler As Label
    Friend WithEvents BindingSource1 As BindingSource
End Class
