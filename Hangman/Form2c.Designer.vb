<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.btnAvslutt2 = New System.Windows.Forms.Button()
        Me.btnTilmeny = New System.Windows.Forms.Button()
        Me.txtBokstav = New System.Windows.Forms.TextBox()
        Me.btnSjekkbokstav = New System.Windows.Forms.Button()
        Me.txtLosningsOrd = New System.Windows.Forms.TextBox()
        Me.lblSvar = New System.Windows.Forms.Label()
        Me.btnBekreftord = New System.Windows.Forms.Button()
        Me.btnNullstill = New System.Windows.Forms.Button()
        Me.lblGjettetbokstav = New System.Windows.Forms.Label()
        Me.lblOverskriftinput = New System.Windows.Forms.Label()
        Me.lblOverskriftbokstav = New System.Windows.Forms.Label()
        Me.btnLyd = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.lblBruktebokstaver = New System.Windows.Forms.Label()
        Me.Random = New System.Windows.Forms.Button()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAvslutt2
        '
        Me.btnAvslutt2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAvslutt2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAvslutt2.FlatAppearance.BorderSize = 3
        Me.btnAvslutt2.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvslutt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAvslutt2.Location = New System.Drawing.Point(1105, 315)
        Me.btnAvslutt2.Name = "btnAvslutt2"
        Me.btnAvslutt2.Size = New System.Drawing.Size(150, 40)
        Me.btnAvslutt2.TabIndex = 5
        Me.btnAvslutt2.Text = "Avslutt"
        Me.btnAvslutt2.UseVisualStyleBackColor = False
        '
        'btnTilmeny
        '
        Me.btnTilmeny.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTilmeny.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTilmeny.FlatAppearance.BorderSize = 3
        Me.btnTilmeny.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilmeny.Location = New System.Drawing.Point(1105, 75)
        Me.btnTilmeny.Name = "btnTilmeny"
        Me.btnTilmeny.Size = New System.Drawing.Size(150, 40)
        Me.btnTilmeny.TabIndex = 6
        Me.btnTilmeny.Text = "Til meny"
        Me.btnTilmeny.UseVisualStyleBackColor = False
        '
        'txtBokstav
        '
        Me.txtBokstav.BackColor = System.Drawing.Color.Silver
        Me.txtBokstav.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBokstav.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtBokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBokstav.Location = New System.Drawing.Point(456, 586)
        Me.txtBokstav.MaxLength = 1
        Me.txtBokstav.Name = "txtBokstav"
        Me.txtBokstav.Size = New System.Drawing.Size(75, 51)
        Me.txtBokstav.TabIndex = 7
        Me.txtBokstav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBokstav.Visible = False
        '
        'btnSjekkbokstav
        '
        Me.btnSjekkbokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSjekkbokstav.Location = New System.Drawing.Point(456, 651)
        Me.btnSjekkbokstav.Name = "btnSjekkbokstav"
        Me.btnSjekkbokstav.Size = New System.Drawing.Size(75, 40)
        Me.btnSjekkbokstav.TabIndex = 8
        Me.btnSjekkbokstav.Text = "OK"
        Me.btnSjekkbokstav.UseVisualStyleBackColor = True
        Me.btnSjekkbokstav.Visible = False
        '
        'txtLosningsOrd
        '
        Me.txtLosningsOrd.BackColor = System.Drawing.Color.Silver
        Me.txtLosningsOrd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLosningsOrd.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLosningsOrd.Location = New System.Drawing.Point(789, 586)
        Me.txtLosningsOrd.MaxLength = 10
        Me.txtLosningsOrd.Name = "txtLosningsOrd"
        Me.txtLosningsOrd.Size = New System.Drawing.Size(196, 51)
        Me.txtLosningsOrd.TabIndex = 9
        '
        'lblSvar
        '
        Me.lblSvar.BackColor = System.Drawing.Color.Transparent
        Me.lblSvar.Font = New System.Drawing.Font("Viner Hand ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSvar.Location = New System.Drawing.Point(456, 459)
        Me.lblSvar.Name = "lblSvar"
        Me.lblSvar.Size = New System.Drawing.Size(287, 51)
        Me.lblSvar.TabIndex = 10
        '
        'btnBekreftord
        '
        Me.btnBekreftord.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBekreftord.Location = New System.Drawing.Point(789, 653)
        Me.btnBekreftord.Name = "btnBekreftord"
        Me.btnBekreftord.Size = New System.Drawing.Size(196, 40)
        Me.btnBekreftord.TabIndex = 12
        Me.btnBekreftord.Text = "Bekreft ord"
        Me.btnBekreftord.UseVisualStyleBackColor = True
        '
        'btnNullstill
        '
        Me.btnNullstill.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNullstill.Location = New System.Drawing.Point(1105, 155)
        Me.btnNullstill.Name = "btnNullstill"
        Me.btnNullstill.Size = New System.Drawing.Size(150, 40)
        Me.btnNullstill.TabIndex = 13
        Me.btnNullstill.Text = "Start på nytt"
        Me.btnNullstill.UseVisualStyleBackColor = True
        '
        'lblGjettetbokstav
        '
        Me.lblGjettetbokstav.BackColor = System.Drawing.Color.Transparent
        Me.lblGjettetbokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGjettetbokstav.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblGjettetbokstav.Location = New System.Drawing.Point(228, 589)
        Me.lblGjettetbokstav.Name = "lblGjettetbokstav"
        Me.lblGjettetbokstav.Size = New System.Drawing.Size(200, 51)
        Me.lblGjettetbokstav.TabIndex = 17
        '
        'lblOverskriftinput
        '
        Me.lblOverskriftinput.AutoSize = True
        Me.lblOverskriftinput.BackColor = System.Drawing.Color.Transparent
        Me.lblOverskriftinput.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverskriftinput.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.lblOverskriftinput.Location = New System.Drawing.Point(781, 534)
        Me.lblOverskriftinput.Name = "lblOverskriftinput"
        Me.lblOverskriftinput.Size = New System.Drawing.Size(479, 44)
        Me.lblOverskriftinput.TabIndex = 18
        Me.lblOverskriftinput.Text = "Skriv inn et ord eller velg et tilfeldig"
        Me.lblOverskriftinput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblOverskriftbokstav
        '
        Me.lblOverskriftbokstav.AutoSize = True
        Me.lblOverskriftbokstav.BackColor = System.Drawing.Color.Transparent
        Me.lblOverskriftbokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOverskriftbokstav.Location = New System.Drawing.Point(456, 534)
        Me.lblOverskriftbokstav.Name = "lblOverskriftbokstav"
        Me.lblOverskriftbokstav.Size = New System.Drawing.Size(287, 44)
        Me.lblOverskriftbokstav.TabIndex = 19
        Me.lblOverskriftbokstav.Text = "Skriv inn en bokstav"
        Me.lblOverskriftbokstav.Visible = False
        '
        'btnLyd
        '
        Me.btnLyd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLyd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLyd.FlatAppearance.BorderSize = 3
        Me.btnLyd.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLyd.Location = New System.Drawing.Point(1105, 235)
        Me.btnLyd.Name = "btnLyd"
        Me.btnLyd.Size = New System.Drawing.Size(150, 40)
        Me.btnLyd.TabIndex = 20
        Me.btnLyd.Text = "Lyd Av"
        Me.btnLyd.UseVisualStyleBackColor = False
        Me.btnLyd.Visible = False
        '
        'PictureBox
        '
        Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1280, 720)
        Me.PictureBox.TabIndex = 21
        Me.PictureBox.TabStop = False
        '
        'lblBruktebokstaver
        '
        Me.lblBruktebokstaver.BackColor = System.Drawing.Color.Transparent
        Me.lblBruktebokstaver.Font = New System.Drawing.Font("Viner Hand ITC", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBruktebokstaver.Location = New System.Drawing.Point(12, 592)
        Me.lblBruktebokstaver.Name = "lblBruktebokstaver"
        Me.lblBruktebokstaver.Size = New System.Drawing.Size(210, 40)
        Me.lblBruktebokstaver.TabIndex = 22
        Me.lblBruktebokstaver.Text = "Brukte bokstaver:"
        Me.lblBruktebokstaver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblBruktebokstaver.Visible = False
        '
        'Random
        '
        Me.Random.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Random.Location = New System.Drawing.Point(1040, 586)
        Me.Random.Name = "Random"
        Me.Random.Size = New System.Drawing.Size(196, 51)
        Me.Random.TabIndex = 23
        Me.Random.Text = "Tilfeldig ord"
        Me.Random.UseVisualStyleBackColor = True
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.Random)
        Me.Controls.Add(Me.lblBruktebokstaver)
        Me.Controls.Add(Me.lblOverskriftinput)
        Me.Controls.Add(Me.btnLyd)
        Me.Controls.Add(Me.lblOverskriftbokstav)
        Me.Controls.Add(Me.lblGjettetbokstav)
        Me.Controls.Add(Me.btnNullstill)
        Me.Controls.Add(Me.btnBekreftord)
        Me.Controls.Add(Me.lblSvar)
        Me.Controls.Add(Me.txtLosningsOrd)
        Me.Controls.Add(Me.btnSjekkbokstav)
        Me.Controls.Add(Me.txtBokstav)
        Me.Controls.Add(Me.btnTilmeny)
        Me.Controls.Add(Me.btnAvslutt2)
        Me.Controls.Add(Me.PictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form2"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAvslutt2 As Button
    Friend WithEvents btnTilmeny As Button
    Friend WithEvents txtBokstav As TextBox
    Friend WithEvents btnSjekkbokstav As Button
    Friend WithEvents txtLosningsOrd As TextBox
    Friend WithEvents lblSvar As Label
    Friend WithEvents btnBekreftord As Button
    Friend WithEvents btnNullstill As Button
    Friend WithEvents lblGjettetbokstav As Label
    Friend WithEvents lblOverskriftinput As Label
    Friend WithEvents lblOverskriftbokstav As Label
    Friend WithEvents btnLyd As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents lblBruktebokstaver As Label
    Friend WithEvents Random As Button
End Class
