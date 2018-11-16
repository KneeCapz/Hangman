Public Class Form1

    Dim bakgrunnsmusikk As New Media.SoundPlayer(My.Resources.intro)

    'klasse med tellere som kan refereres til i både form1 og form2
    Public Class Tellere
        Public Shared bakteller As Integer = 1
        Public Shared lydteller As Integer = 1
    End Class

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Avsnittene under gjør det mulig å ha transparant "button" med bilde som bakgrunn
        btnStart.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnStart.FlatAppearance.BorderSize = 0
        btnStart.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnStart.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnStart.BackColor = Color.Transparent

        btnLyd.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnLyd.FlatAppearance.BorderSize = 0
        btnLyd.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnLyd.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnLyd.BackColor = Color.Transparent

        btnAvslutt.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnAvslutt.FlatAppearance.BorderSize = 0
        btnAvslutt.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnAvslutt.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnAvslutt.BackColor = Color.Transparent

        btnBakgrunn.FlatStyle = Windows.Forms.FlatStyle.Flat
        btnBakgrunn.FlatAppearance.BorderSize = 0
        btnBakgrunn.FlatAppearance.MouseDownBackColor = Color.Transparent
        btnBakgrunn.FlatAppearance.MouseOverBackColor = Color.Transparent
        btnBakgrunn.BackColor = Color.Transparent

        'kjører bakgrunnsmusikk i loop
        bakgrunnsmusikk.PlayLooping()
    End Sub

    'avslutter spillet
    Private Sub btnAvslutt_Click(sender As Object, e As EventArgs) Handles btnAvslutt.Click
        Dim avslutt As Integer
        avslutt = MsgBox("Er du sikker på at du vil avslutte?", MsgBoxStyle.YesNo, "Avslutt")
        Select Case avslutt
            Case MsgBoxResult.Yes
                Close()
        End Select
    End Sub

    'Skifter mellom to bakgrunner / tema --- Disabled ---
    Private Sub btnBakgrunn_Click(sender As Object, e As EventArgs) Handles btnBakgrunn.Click

        If Tellere.bakteller = 1 Then
            Tellere.bakteller = Tellere.bakteller + 1

            btnStart.BackgroundImage = My.Resources.Knapp2_0_start_spill
            btnLyd.BackgroundImage = My.Resources.Knapp2_0_lyd_av
            btnAvslutt.BackgroundImage = My.Resources.Knapp2_0_avslutt
            btnBakgrunn.BackgroundImage = My.Resources.Knapp2_0_bytt_bakgrunn

            Form2.btnTilmeny.BackgroundImage = My.Resources.Knapp2_0_til_meny
            Form2.btnLyd.BackgroundImage = My.Resources.Knapp2_0_lyd_av
            Form2.btnNullstill.BackgroundImage = My.Resources.Knapp2_0_start_på_nytt
            Form2.btnAvslutt2.BackgroundImage = My.Resources.Knapp2_0_avslutt
            Form2.btnBekreftord.BackgroundImage = My.Resources.Knapp2_0_bekreft_ord
            Form2.Random.BackgroundImage = My.Resources.Knapp2_0_tilfeldig_ord
            Form2.btnSjekkbokstav.BackgroundImage = My.Resources.Knapp2_0_ok
            Form2.imgOverskriftinput.BackgroundImage = My.Resources.Tekst2_0_Skriv_inn_ord_tilfeldig
            Form2.imgOverskriftbokstav.BackgroundImage = My.Resources.Tekst2_0_Skriv_inn_bokstav
            Form2.imgBruktebokstaver.BackgroundImage = My.Resources.Tekst2_0_Brukte_bokstaver
        ElseIf Tellere.bakteller = 2 Then
            Tellere.bakteller = 1

            btnStart.BackgroundImage = My.Resources.imgstartspill
            btnLyd.BackgroundImage = My.Resources.imglydav
            btnAvslutt.BackgroundImage = My.Resources.imgavslutt
            btnBakgrunn.BackgroundImage = My.Resources.imgbakgrunn

            Form2.btnTilmeny.BackgroundImage = My.Resources.imgmeny
            Form2.btnLyd.BackgroundImage = My.Resources.imglydav
            Form2.btnNullstill.BackgroundImage = My.Resources.imgstartnytt
            Form2.btnAvslutt2.BackgroundImage = My.Resources.imgavslutt
            Form2.btnBekreftord.BackgroundImage = My.Resources.imgbekreft
            Form2.Random.BackgroundImage = My.Resources.imgtilfeldigord
            Form2.btnSjekkbokstav.BackgroundImage = My.Resources.Knapp_ok2
            Form2.imgOverskriftinput.BackgroundImage = My.Resources.imgskrivinnordtilfeldig
            Form2.imgOverskriftbokstav.BackgroundImage = My.Resources.imgskrivbokstav
            Form2.imgBruktebokstaver.BackgroundImage = My.Resources.imgbruktebokstaver
        End If

    End Sub

    'Lukker menyskjema(form1) og åpner spillskjema(form2)
    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        bakgrunnsmusikk.Stop()
        Form1.Tellere.bakteller = 1
        Form1.Tellere.lydteller = 1
        Form2.Show()
        Me.Close()
    End Sub

    'Slår av og på bakgrunnslyd og bytter bakgrunnsbilde til knappen avhenging om lyden er av eller på.
    'Sjekker også hvilket tema som er aktivit og endrer knapper tilsvarende tema.
    'Temafunksjonen er slått av ved at knappen For valg av tema er "hidden" og "disabled"
    Private Sub btnLyd_Click(sender As Object, e As EventArgs) Handles btnLyd.Click
        If Tellere.lydteller = 1 Then
            If Tellere.bakteller = 1 Then
                btnLyd.BackgroundImage = My.Resources.imglydpaa
                Tellere.lydteller = Tellere.lydteller + 1
                bakgrunnsmusikk.Stop()
            ElseIf Tellere.bakteller = 2 Then
                btnLyd.BackgroundImage = My.Resources.Knapp2_0_lyd_på
                Tellere.lydteller = Tellere.lydteller + 1
                bakgrunnsmusikk.Stop()
            End If
        ElseIf Tellere.lydteller = 2 Then
            If Tellere.bakteller = 1 Then
                btnLyd.BackgroundImage = My.Resources.imglydav
                Tellere.lydteller = 1
                bakgrunnsmusikk.Play()
            ElseIf Tellere.bakteller = 2 Then
                btnLyd.BackgroundImage = My.Resources.Knapp2_0_lyd_av
                Tellere.lydteller = 1
                bakgrunnsmusikk.Play()
            End If
        End If
    End Sub
End Class
