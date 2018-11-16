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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.btnAvslutt2 = New System.Windows.Forms.Button()
        Me.btnTilmeny = New System.Windows.Forms.Button()
        Me.txtBokstav = New System.Windows.Forms.TextBox()
        Me.btnSjekkbokstav = New System.Windows.Forms.Button()
        Me.txtLosningsOrd = New System.Windows.Forms.TextBox()
        Me.lblSvar = New System.Windows.Forms.Label()
        Me.btnBekreftord = New System.Windows.Forms.Button()
        Me.btnNullstill = New System.Windows.Forms.Button()
        Me.lblGjettetbokstav = New System.Windows.Forms.Label()
        Me.btnLyd = New System.Windows.Forms.Button()
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.PictureBox = New System.Windows.Forms.PictureBox()
        Me.Random = New System.Windows.Forms.Button()
        Me.imgOverskriftinput = New System.Windows.Forms.PictureBox()
        Me.imgOverskriftbokstav = New System.Windows.Forms.PictureBox()
        Me.imgBruktebokstaver = New System.Windows.Forms.PictureBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOverskriftinput, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgOverskriftbokstav, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgBruktebokstaver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnAvslutt2
        '
        Me.btnAvslutt2.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnAvslutt2.BackgroundImage = Global.Hangman.My.Resources.Resources.imgavslutt
        Me.btnAvslutt2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnAvslutt2.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnAvslutt2.FlatAppearance.BorderSize = 3
        Me.btnAvslutt2.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAvslutt2.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnAvslutt2.Location = New System.Drawing.Point(1090, 315)
        Me.btnAvslutt2.Name = "btnAvslutt2"
        Me.btnAvslutt2.Size = New System.Drawing.Size(160, 45)
        Me.btnAvslutt2.TabIndex = 5
        Me.btnAvslutt2.UseVisualStyleBackColor = False
        '
        'btnTilmeny
        '
        Me.btnTilmeny.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnTilmeny.BackgroundImage = Global.Hangman.My.Resources.Resources.imgmeny
        Me.btnTilmeny.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnTilmeny.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnTilmeny.FlatAppearance.BorderSize = 3
        Me.btnTilmeny.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTilmeny.ForeColor = System.Drawing.Color.Transparent
        Me.btnTilmeny.Location = New System.Drawing.Point(1090, 75)
        Me.btnTilmeny.Name = "btnTilmeny"
        Me.btnTilmeny.Size = New System.Drawing.Size(160, 45)
        Me.btnTilmeny.TabIndex = 6
        Me.btnTilmeny.UseVisualStyleBackColor = False
        '
        'txtBokstav
        '
        Me.txtBokstav.BackColor = System.Drawing.SystemColors.Menu
        Me.txtBokstav.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtBokstav.Cursor = System.Windows.Forms.Cursors.Cross
        Me.txtBokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtBokstav.Location = New System.Drawing.Point(602, 581)
        Me.txtBokstav.MaxLength = 1
        Me.txtBokstav.Name = "txtBokstav"
        Me.txtBokstav.Size = New System.Drawing.Size(75, 51)
        Me.txtBokstav.TabIndex = 7
        Me.txtBokstav.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtBokstav.Visible = False
        '
        'btnSjekkbokstav
        '
        Me.btnSjekkbokstav.BackgroundImage = Global.Hangman.My.Resources.Resources.Knapp_ok2
        Me.btnSjekkbokstav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnSjekkbokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSjekkbokstav.Location = New System.Drawing.Point(602, 642)
        Me.btnSjekkbokstav.Name = "btnSjekkbokstav"
        Me.btnSjekkbokstav.Size = New System.Drawing.Size(75, 51)
        Me.btnSjekkbokstav.TabIndex = 8
        Me.btnSjekkbokstav.UseVisualStyleBackColor = True
        Me.btnSjekkbokstav.Visible = False
        '
        'txtLosningsOrd
        '
        Me.txtLosningsOrd.BackColor = System.Drawing.SystemColors.Menu
        Me.txtLosningsOrd.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLosningsOrd.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLosningsOrd.Location = New System.Drawing.Point(820, 581)
        Me.txtLosningsOrd.MaxLength = 10
        Me.txtLosningsOrd.Name = "txtLosningsOrd"
        Me.txtLosningsOrd.Size = New System.Drawing.Size(430, 51)
        Me.txtLosningsOrd.TabIndex = 9
        '
        'lblSvar
        '
        Me.lblSvar.BackColor = System.Drawing.Color.Transparent
        Me.lblSvar.Font = New System.Drawing.Font("Viner Hand ITC", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSvar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.lblSvar.Location = New System.Drawing.Point(370, 462)
        Me.lblSvar.Name = "lblSvar"
        Me.lblSvar.Size = New System.Drawing.Size(600, 51)
        Me.lblSvar.TabIndex = 10
        '
        'btnBekreftord
        '
        Me.btnBekreftord.BackgroundImage = Global.Hangman.My.Resources.Resources.imgbekreft
        Me.btnBekreftord.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnBekreftord.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBekreftord.Location = New System.Drawing.Point(820, 642)
        Me.btnBekreftord.Name = "btnBekreftord"
        Me.btnBekreftord.Size = New System.Drawing.Size(196, 51)
        Me.btnBekreftord.TabIndex = 12
        Me.btnBekreftord.UseVisualStyleBackColor = True
        '
        'btnNullstill
        '
        Me.btnNullstill.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnNullstill.BackgroundImage = Global.Hangman.My.Resources.Resources.imgstartnytt
        Me.btnNullstill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnNullstill.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNullstill.Location = New System.Drawing.Point(1090, 235)
        Me.btnNullstill.Name = "btnNullstill"
        Me.btnNullstill.Size = New System.Drawing.Size(160, 45)
        Me.btnNullstill.TabIndex = 13
        Me.btnNullstill.UseVisualStyleBackColor = False
        '
        'lblGjettetbokstav
        '
        Me.lblGjettetbokstav.BackColor = System.Drawing.Color.Transparent
        Me.lblGjettetbokstav.Font = New System.Drawing.Font("Viner Hand ITC", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGjettetbokstav.ForeColor = System.Drawing.SystemColors.Menu
        Me.lblGjettetbokstav.Location = New System.Drawing.Point(305, 642)
        Me.lblGjettetbokstav.Name = "lblGjettetbokstav"
        Me.lblGjettetbokstav.Size = New System.Drawing.Size(166, 51)
        Me.lblGjettetbokstav.TabIndex = 17
        '
        'btnLyd
        '
        Me.btnLyd.BackColor = System.Drawing.SystemColors.ControlLight
        Me.btnLyd.BackgroundImage = Global.Hangman.My.Resources.Resources.imglydav
        Me.btnLyd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnLyd.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.btnLyd.FlatAppearance.BorderSize = 3
        Me.btnLyd.Font = New System.Drawing.Font("Viner Hand ITC", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLyd.Location = New System.Drawing.Point(1090, 155)
        Me.btnLyd.Name = "btnLyd"
        Me.btnLyd.Size = New System.Drawing.Size(160, 45)
        Me.btnLyd.TabIndex = 20
        Me.btnLyd.Tag = "av"
        Me.btnLyd.UseVisualStyleBackColor = False
        '
        'PictureBox
        '
        Me.PictureBox.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangmanstart
        Me.PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.PictureBox.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox.Name = "PictureBox"
        Me.PictureBox.Size = New System.Drawing.Size(1280, 720)
        Me.PictureBox.TabIndex = 21
        Me.PictureBox.TabStop = False
        '
        'Random
        '
        Me.Random.BackColor = System.Drawing.SystemColors.ControlLight
        Me.Random.BackgroundImage = Global.Hangman.My.Resources.Resources.imgtilfeldigord
        Me.Random.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Random.Font = New System.Drawing.Font("Viner Hand ITC", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Random.Location = New System.Drawing.Point(1054, 642)
        Me.Random.Name = "Random"
        Me.Random.Size = New System.Drawing.Size(196, 51)
        Me.Random.TabIndex = 23
        Me.Random.UseVisualStyleBackColor = False
        '
        'imgOverskriftinput
        '
        Me.imgOverskriftinput.BackColor = System.Drawing.Color.Transparent
        Me.imgOverskriftinput.BackgroundImage = Global.Hangman.My.Resources.Resources.imgskrivinnordtilfeldig
        Me.imgOverskriftinput.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgOverskriftinput.Location = New System.Drawing.Point(723, 532)
        Me.imgOverskriftinput.Name = "imgOverskriftinput"
        Me.imgOverskriftinput.Size = New System.Drawing.Size(536, 43)
        Me.imgOverskriftinput.TabIndex = 24
        Me.imgOverskriftinput.TabStop = False
        '
        'imgOverskriftbokstav
        '
        Me.imgOverskriftbokstav.BackColor = System.Drawing.Color.Transparent
        Me.imgOverskriftbokstav.BackgroundImage = CType(resources.GetObject("imgOverskriftbokstav.BackgroundImage"), System.Drawing.Image)
        Me.imgOverskriftbokstav.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgOverskriftbokstav.Location = New System.Drawing.Point(383, 532)
        Me.imgOverskriftbokstav.Name = "imgOverskriftbokstav"
        Me.imgOverskriftbokstav.Size = New System.Drawing.Size(314, 43)
        Me.imgOverskriftbokstav.TabIndex = 25
        Me.imgOverskriftbokstav.TabStop = False
        Me.imgOverskriftbokstav.Visible = False
        '
        'imgBruktebokstaver
        '
        Me.imgBruktebokstaver.BackColor = System.Drawing.Color.Transparent
        Me.imgBruktebokstaver.BackgroundImage = CType(resources.GetObject("imgBruktebokstaver.BackgroundImage"), System.Drawing.Image)
        Me.imgBruktebokstaver.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgBruktebokstaver.Location = New System.Drawing.Point(0, 642)
        Me.imgBruktebokstaver.Name = "imgBruktebokstaver"
        Me.imgBruktebokstaver.Size = New System.Drawing.Size(299, 43)
        Me.imgBruktebokstaver.TabIndex = 26
        Me.imgBruktebokstaver.TabStop = False
        Me.imgBruktebokstaver.Visible = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1280, 720)
        Me.Controls.Add(Me.imgBruktebokstaver)
        Me.Controls.Add(Me.imgOverskriftbokstav)
        Me.Controls.Add(Me.imgOverskriftinput)
        Me.Controls.Add(Me.Random)
        Me.Controls.Add(Me.btnLyd)
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
        CType(Me.imgOverskriftinput, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgOverskriftbokstav, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgBruktebokstaver, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents btnLyd As Button
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PictureBox As PictureBox
    Friend WithEvents Random As Button
    Friend WithEvents imgOverskriftinput As PictureBox
    Friend WithEvents imgOverskriftbokstav As PictureBox
    Friend WithEvents imgBruktebokstaver As PictureBox
End Class
