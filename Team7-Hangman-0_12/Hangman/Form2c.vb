Imports System.IO

Public Class Form2

    Dim losningsOrd As String
    Dim bokstav As Char
    Dim letterpos As Integer = 0
    Dim feilTeller As Integer = 0
    Dim temp As New System.Text.StringBuilder
    Dim tavle As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.tavle)
    Dim tap As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.tap)
    Dim click1 As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.click1)
    Dim clap As Media.SoundPlayer = New Media.SoundPlayer(My.Resources.clap)

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Avsnittene under gjør det mulig å ha transparant "button" med bilde som bakgrunn.
        btnTilmeny.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnTilmeny.FlatAppearance.BorderSize = 0
        btnTilmeny.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnTilmeny.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnTilmeny.BackColor = Color.Transparent

        btnLyd.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnLyd.FlatAppearance.BorderSize = 0
        btnLyd.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLyd.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLyd.BackColor = Color.Transparent

        btnNullstill.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnNullstill.FlatAppearance.BorderSize = 0
        btnNullstill.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnNullstill.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnNullstill.BackColor = Color.Transparent

        btnAvslutt2.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnAvslutt2.FlatAppearance.BorderSize = 0
        btnAvslutt2.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnAvslutt2.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnAvslutt2.BackColor = Color.Transparent

        btnBekreftord.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnBekreftord.FlatAppearance.BorderSize = 0
        btnBekreftord.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBekreftord.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBekreftord.BackColor = Color.Transparent

        Random.FlatStyle = Windows.Forms.FlatStyle.Flat
        Random.FlatAppearance.BorderSize = 0
        Random.FlatAppearance.MouseDownBackColor = Color.Transparent
        Random.FlatAppearance.MouseOverBackColor = Color.Transparent
        Random.BackColor = Color.Transparent

        btnSjekkbokstav.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnSjekkbokstav.FlatAppearance.BorderSize = 0
        btnSjekkbokstav.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnSjekkbokstav.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnSjekkbokstav.BackColor = Color.Transparent
    End Sub

    Private Declare Function HideCaret Lib "user32.dll" (ByVal hwnd As Int32) As Int32

    'Skjuler tekstmarkør i inputboks for bokstav når den får fokus
    Private Sub txtBokstav2_TextChanged(sender As Object, e As EventArgs) Handles txtBokstav.GotFocus
        Call HideCaret(txtBokstav.Handle)
    End Sub

    'avslutter spillet
    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt2.Click
        Try
            click1.Play()
        Catch ex As Exception
        End Try
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

    'tilbake til meny
    Private Sub btnTilmeny_Click(sender As Object, e As EventArgs) Handles btnTilmeny.Click
        Try
            click1.Play()
        Catch ex As Exception
        End Try
        Form1.Tellere.bakteller = 1
        Form1.Tellere.lydteller = 1
        Form1.Show()
        Me.Close()
    End Sub

    'Tillater kun bokstaver i feltet for inntasting av bokstaver
    Private Sub txtBokstav_KeyPress(sender As Object, e As KeyPressEventArgs) _
                              Handles txtBokstav.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'Tillater kun bokstaver i feltet for inntasting av løsningsord
    Private Sub txtLosningsord_KeyPress(sender As Object, e As KeyPressEventArgs) _
                              Handles txtLosningsOrd.KeyPress
        If Not (Asc(e.KeyChar) = 8) Then
            Dim allowedChars As String = "abcdefghijklmnopqrstuvwxyzæøå"
            If Not allowedChars.Contains(e.KeyChar.ToString.ToLower) Then
                e.KeyChar = ChrW(0)
                e.Handled = True
            End If
        End If
    End Sub

    'lar brukeren trykke enter for å sende bokstav
    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtBokstav.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call btnSjekkbokstav.PerformClick()
        End If
    End Sub

    'Sjekker inntastet bokstav mot bokstaver i løsningsord og skriver eventuelt rett bokstav i ordet eller legger til et steg på hangman
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnSjekkbokstav.Click
        Try
            click1.Play()
        Catch ex As Exception
        End Try

        bokstav = txtBokstav.Text
        Dim lengdeOrd As Integer = losningsOrd.Length()

        If txtBokstav.Text = "" Then
            MsgBox("Skriv inn en bokstav")
            txtBokstav.Select()
        Else
            If losningsOrd.Contains(bokstav) = False Then
                If lblGjettetbokstav.Text.Contains(bokstav) Then

                Else
                    lblGjettetbokstav.Text &= bokstav
                    feilTeller = feilTeller + 1
                    Try
                        tavle.Play()
                    Catch ex As Exception
                    End Try
                End If
            Else
                letterpos = 0
                Do While InStr(letterpos + 1, losningsOrd, bokstav) > 0
                    letterpos = InStr(letterpos + 1, losningsOrd, bokstav)
                    Mid(lblSvar.Text, letterpos, 1) = bokstav
                Loop
            End If

            'Sjekker antal feil. Om antall feil er større enn 6 er spillet tapt. Om antall feil er under 6 sjekkes det om alle bokstaver er funnet,
            'og i såfall er spillet vunnet. Endrer bakgrunn etter hvor mange feil man har.
            If lblSvar.Text.Contains("-") And feilTeller = 6 Then
                Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman5
                Try
                    tap.Play()
                Catch ex As Exception
                End Try
                MsgBox("Du tapte! Ordet var " & "" & losningsOrd)
                btnBekreftord.Show()
                Random.Show()
                txtLosningsOrd.Show()
                imgOverskriftinput.Show()
                imgOverskriftbokstav.Hide()
                txtBokstav.Hide()
                btnSjekkbokstav.Hide()
                imgBruktebokstaver.Hide()
                txtLosningsOrd.Text = Nothing
                txtBokstav.Text = Nothing
                losningsOrd = Nothing
                bokstav = Nothing
                lblSvar.Text = ""
                lblGjettetbokstav.Text = ""
                feilTeller = 0
                Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangmanstart
            ElseIf lblSvar.Text.Contains("-") Then
                If feilTeller = 1 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0
                ElseIf feilTeller = 2 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman1
                ElseIf feilTeller = 3 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman2
                ElseIf feilTeller = 4 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman3
                ElseIf feilTeller = 5 Then
                    Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman4
                End If
            Else
                Try
                    clap.Play()
                Catch ex As Exception
                End Try
                MsgBox("Du vant!")
                btnBekreftord.Show()
                Random.Show()
                txtLosningsOrd.Show()
                imgOverskriftinput.Show()
                imgOverskriftbokstav.Hide()
                txtBokstav.Hide()
                btnSjekkbokstav.Hide()
                imgBruktebokstaver.Hide()
                txtLosningsOrd.Text = Nothing
                txtBokstav.Text = Nothing
                losningsOrd = Nothing
                bokstav = Nothing
                lblSvar.Text = ""
                lblGjettetbokstav.Text = ""
                feilTeller = 0
                Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangman0
            End If
            txtBokstav.Text = ""
            txtBokstav.Select()
        End If
    End Sub

    'Velger et tilfeldig et fra ordlisten(tekstfil) og legger til antall streker lik lengden på ordet i lblSvar
    Private Sub Random_Click(sender As Object, e As EventArgs) Handles Random.Click
        Try
            click1.Play()
        Catch ex As Exception
        End Try

        'Txt filer lagret i resources er lagret som byte arrays, og kan derfor ikke leses av direkte.
        'Filen må splittes for å få hver linje lesbar.
        Dim ord() As String = My.Resources.ordliste_random.Split(Environment.NewLine)

        Dim rnd As New Random()
        Dim selectedIndex = rnd.Next(1, ord.Length)
        Dim selectedName = ord(selectedIndex)

        'usnylig tegn dukker opp foran ord fra listen. klarte ikke å finne ut hvorfor, så den ble fjernet ved hjelp av linjen under
        selectedName = selectedName.Remove(0, 1)

        txtLosningsOrd.Text = selectedName
        losningsOrd = txtLosningsOrd.Text
        lblSvar.Text = ""
        txtLosningsOrd.Hide()
        btnBekreftord.Hide()
        imgOverskriftbokstav.Show()
        txtBokstav.Show()
        btnSjekkbokstav.Show()
        Random.Hide()
        imgOverskriftinput.Hide()
        imgBruktebokstaver.Show()

        Dim streker As String = ""
        For counter As Integer = 1 To losningsOrd.Length
            streker = streker + "-"
        Next

        lblSvar.Text = streker
        txtBokstav.Select()
    End Sub

    'Henter det inntastede ordet og lagrer det, og lager en string med antall "-" lik løsningsordet som skrives til lblSvar.
    'Om ordet er under tre bokstaver vil en varselboks vises.
    Private Sub btnBekreftord_Click(sender As Object, e As EventArgs) Handles btnBekreftord.Click
        Try
            click1.Play()
        Catch ex As Exception
        End Try
        If txtLosningsOrd.Text.Length() < 3 Then
            MsgBox("Ordet må være på minst 3 bokstaver")
        Else
            losningsOrd = txtLosningsOrd.Text
            lblSvar.Text = ""
            txtLosningsOrd.Hide()
            Random.Hide()
            btnBekreftord.Hide()
            imgOverskriftinput.Hide()
            imgOverskriftbokstav.Show()
            txtBokstav.Show()
            btnSjekkbokstav.Show()

            Dim temp As New System.Text.StringBuilder
            For Each Character As Char In losningsOrd
                temp.Append("-")
            Next

            lblSvar.Text = temp.ToString
            txtBokstav.Select()
            imgBruktebokstaver.Show()
        End If
    End Sub

    'Tømmer alle felt og setter løsningsord og bokstav til null og bakgrunnen til start.
    'Viser knapp for bekreft ord og tekstboks for inntasting av løsningsord og overskriften til denne.
    'Skjuler knapp for bekreft bokstav og tekstboks for inntasting av bokstav og overskriften til denne
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles btnNullstill.Click

        Try
            click1.Play()
        Catch ex As Exception
        End Try




        btnBekreftord.Show()
        Random.Show()
        txtLosningsOrd.Show()
        imgOverskriftinput.Show()
        imgOverskriftbokstav.Hide()
        txtBokstav.Hide()
        btnSjekkbokstav.Hide()
        imgBruktebokstaver.Hide()
        txtLosningsOrd.Text = Nothing
        txtBokstav.Text = Nothing
        lblSvar.Text = ""
        losningsOrd = Nothing
        bokstav = Nothing
        lblGjettetbokstav.Text = ""
        feilTeller = 0
        Me.PictureBox.BackgroundImage = Global.Hangman.My.Resources.Resources.Hangmanstart

    End Sub

    'Slår av og på lyder ved å sette lydvariabler til en tom lydfil eller tilbake til orginal.
    'Bytter også bakgrunnsbilde på lydknapp avhenging av om lyden er av eller på.
    'Sjekker også hvilket tema som er aktivit og endrer knapper tilsvarende tema.
    'Temafunksjonen er slått av ved at knappen For valg av tema er "hidden" og "disabled"
    Private Sub btnLyd_Click(sender As Object, e As EventArgs) Handles btnLyd.Click
        txtBokstav.Select()
        If Form1.Tellere.lydteller = 1 Then
            If Form1.Tellere.bakteller = 1 Then
                btnLyd.BackgroundImage = My.Resources.imglydpaa
                Form1.Tellere.lydteller = Form1.Tellere.lydteller + 1
                click1 = Nothing
                tap = Nothing
                clap = Nothing
                tavle = Nothing
            ElseIf Form1.Tellere.bakteller = 2 Then
                btnLyd.BackgroundImage = My.Resources.Knapp2_0_lyd_på
                Form1.Tellere.lydteller = Form1.Tellere.lydteller + 1
                click1 = Nothing
                tap = Nothing
                clap = Nothing
                tavle = Nothing
            End If
        ElseIf Form1.Tellere.lydteller = 2 Then
            If Form1.Tellere.bakteller = 1 Then
                btnLyd.BackgroundImage = My.Resources.imglydav
                Form1.Tellere.lydteller = 1
                click1 = New Media.SoundPlayer(My.Resources.click1)
                tap = New Media.SoundPlayer(My.Resources.tap)
                clap = New Media.SoundPlayer(My.Resources.clap)
                tavle = New Media.SoundPlayer(My.Resources.tavle)
            ElseIf Form1.Tellere.bakteller = 2 Then
                btnLyd.BackgroundImage = My.Resources.Knapp2_0_lyd_av
                Form1.Tellere.lydteller = 1
                click1 = New Media.SoundPlayer(My.Resources.click1)
                tap = New Media.SoundPlayer(My.Resources.tap)
                clap = New Media.SoundPlayer(My.Resources.clap)
                tavle = New Media.SoundPlayer(My.Resources.tavle)
            End If
        End If
    End Sub

End Class