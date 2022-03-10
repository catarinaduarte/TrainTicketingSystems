Public Class Form1

    Dim num1, num2 As Decimal
    Dim operan As Integer
    Dim opranselected As Boolean = False
    Const Braga = 29
    Const CBraga = 35
    Const Bragach = 14
    Const CBragach = 20
    Const Porto = 23
    Const CPorto = 29
    Const Portoch = 11
    Const CPortoch = 17
    Const Coimbra = 15
    Const CCoimbra = 21
    Const Coimbrach = 7
    Const CCoimbrach = 13
    Const Faro = 30
    Const CFaro = 36
    Const Faroch = 15
    Const CFaroch = 21
    Const Tax = 13
    Dim TotalCost As Double

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "8"
        Else
            LblDisplay.Text = "8"
        End If
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "9"
        Else
            LblDisplay.Text = "9"
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "4"
        Else
            LblDisplay.Text = "4"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "5"
        Else
            LblDisplay.Text = "5"
        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "6"
        Else
            LblDisplay.Text = "6"
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "2"
        Else
            LblDisplay.Text = "2"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "3"
        Else
            LblDisplay.Text = "3"
        End If
    End Sub

    Private Sub Button0_Click(sender As Object, e As EventArgs) Handles Button0.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "0"
        Else
            LblDisplay.Text = "0"
        End If
    End Sub

    Private Sub ButtonPlus_Click(sender As Object, e As EventArgs) Handles ButtonPlus.Click
        num1 = LblDisplay.Text
        LblDisplay.Text = "0"
        opranselected = True
        operan = 1
    End Sub

    Private Sub ButtonLess_Click(sender As Object, e As EventArgs) Handles ButtonLess.Click
        num1 = LblDisplay.Text
        LblDisplay.Text = "0"
        opranselected = True
        operan = 2
    End Sub

    Private Sub ButtonMulti_Click(sender As Object, e As EventArgs) Handles ButtonMulti.Click
        num1 = LblDisplay.Text
        LblDisplay.Text = "0"
        opranselected = True
        operan = 3
    End Sub

    Private Sub ButtonDiv_Click(sender As Object, e As EventArgs) Handles ButtonDiv.Click
        num1 = LblDisplay.Text
        LblDisplay.Text = "0"
        opranselected = True
        operan = 5
    End Sub

    Private Sub ButtonPerc_Click(sender As Object, e As EventArgs) Handles ButtonPerc.Click
        num1 = LblDisplay.Text
        LblDisplay.Text = "0"
        opranselected = True
        operan = 4
    End Sub

    Private Sub ButtonPoint_Click(sender As Object, e As EventArgs) Handles ButtonPoint.Click
        If InStr(LblDisplay.Text, ".") = 0 Then

        End If
        LblDisplay.Text = LblDisplay.Text + "."
    End Sub

    Private Sub ButtonC_Click(sender As Object, e As EventArgs) Handles ButtonC.Click
        LblDisplay.Text = ""
        LblDisplay.Text = "0"
    End Sub

    Private Sub ButtonEqual_Click(sender As Object, e As EventArgs) Handles ButtonEqual.Click
        If opranselected = True Then
            num2 = LblDisplay.Text
            If operan = 1 Then
                LblDisplay.Text = num1 + num2
            ElseIf operan = 2 Then
                LblDisplay.Text = num1 - num2
            ElseIf operan = 3 Then
                LblDisplay.Text = num1 * num2
            ElseIf operan = 4 Then
                LblDisplay.Text = num1 Mod num2
            Else
                If num2 = "0" Then
                    LblDisplay.Text = "Error!"
                Else
                    LblDisplay.Text = num1 / num2
                End If


            End If
            opranselected = False
        End If
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "7"
        Else
            LblDisplay.Text = "7"
        End If
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ComboBox6.Items.Add("Braga")
        ComboBox6.Items.Add("Porto")
        ComboBox6.Items.Add("Coimbra")
        ComboBox6.Items.Add("Faro")

    End Sub

    Private Sub ButtonTotal_Click(sender As Object, e As EventArgs) Handles BtnTotal.Click
        'Faro=============================Turistica========================

        If ComboBox6.Text = "Faro" And rbStandard.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Faro)
            TotalCost = (Faro * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + Faro)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))



        ElseIf ComboBox6.Text = "Faro" And rbStandard.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Faroch)
            TotalCost = (Faroch * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + Faroch)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

            '============Ida e Volta=============

        ElseIf ComboBox6.Text = "Faro" And rbStandard.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Faro)
            TotalCost = (2 * (Faro * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + Faro))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Faro" And rbStandard.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Faroch)
            TotalCost = (2 * (Faroch * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + Faroch))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If

        '============================= Conforto============================

        If ComboBox6.Text = "Faro" And Rbconf.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CFaro)
            TotalCost = (CFaro * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + CFaro)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))


        ElseIf ComboBox6.Text = "Faro" And Rbconf.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CFaroch)
            TotalCost = (CFaroch) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + CFaroch)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

            '============Ida e Volta=============
        ElseIf ComboBox6.Text = "Faro" And Rbconf.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CFaro)
            TotalCost = (2 * (CFaro * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + CFaro))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Faro" And Rbconf.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CFaroch)
            TotalCost = (2 * (CFaroch * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + CFaroch))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If

        'Coimbra=============================Turistica========================

        If ComboBox6.Text = "Coimbra" And rbStandard.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Coimbra)
            TotalCost = (Coimbra * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + Coimbra)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))



        ElseIf ComboBox6.Text = "Coimbra" And rbStandard.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Coimbrach)
            TotalCost = (Coimbrach * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + Coimbrach)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

            '============Ida e Volta=============

        ElseIf ComboBox6.Text = "Coimbra" And rbStandard.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Coimbra)
            TotalCost = (2 * (Coimbra * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + Coimbra))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Coimbra" And rbStandard.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Coimbrach)
            TotalCost = (2 * (Coimbrach) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + Coimbrach))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If

        '============================= Conforto============================

        If ComboBox6.Text = "Coimbra" And Rbconf.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CCoimbra)
            TotalCost = (CCoimbra * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + CCoimbra)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))


        ElseIf ComboBox6.Text = "Coimbra" And Rbconf.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CCoimbrach)
            TotalCost = (CCoimbrach * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + CCoimbrach)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

            '============Ida e Volta=============
        ElseIf ComboBox6.Text = "Coimbra" And Rbconf.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CCoimbra)
            TotalCost = (2 * (CCoimbra * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + CCoimbra))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Coimbra" And Rbconf.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CCoimbrach)
            TotalCost = (2 * (CCoimbrach * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + CCoimbrach))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If




        'Porto=============================Turistica========================

        If ComboBox6.Text = "Porto" And rbStandard.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Porto)
            TotalCost = (Porto * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + Porto)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))



        ElseIf ComboBox6.Text = "Porto" And rbStandard.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Portoch)
            TotalCost = (Portoch * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + Portoch)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))



            '============Ida e Volta=============
        ElseIf ComboBox6.Text = "Porto" And rbStandard.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Porto)
            TotalCost = (2 * (Porto * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + Porto))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Porto" And rbStandard.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Portoch)
            TotalCost = (2 * (Portoch * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + Portoch))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If
        '============================= Conforto============================

        If ComboBox6.Text = "Porto" And Rbconf.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CPorto)
            TotalCost = (CPorto * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + CPorto)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))


        ElseIf ComboBox6.Text = "Porto" And Rbconf.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CPortoch)
            TotalCost = (CPortoch * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + CPortoch)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

            '============Ida e Volta=============
        ElseIf ComboBox6.Text = "Porto" And Rbconf.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CPorto)
            TotalCost = (2 * (CPorto * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + CPorto))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Porto" And Rbconf.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CPortoch)
            TotalCost = (2 * (CPortoch * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + CPortoch))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If
        'BRAGA=============================Turistica========================

        If ComboBox6.Text = "Braga" And rbStandard.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Braga)
            TotalCost = (Braga * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + Braga)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))


        ElseIf ComboBox6.Text = "Braga" And rbStandard.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(Bragach)
            TotalCost = (Bragach * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + Bragach)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))
            '============Ida e Volta=============
        ElseIf ComboBox6.Text = "Braga" And rbStandard.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Braga)
            TotalCost = (2 * (Braga * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + Braga))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Braga" And rbStandard.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * Bragach)
            TotalCost = (2 * (Bragach * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + Bragach))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = rbStandard.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        End If
        '============================= Conforto============================

        If ComboBox6.Text = "Braga" And Rbconf.Checked And rbSingle.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CBraga)
            TotalCost = (CBraga * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost + CBraga)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))


        ElseIf ComboBox6.Text = "Braga" And Rbconf.Checked And rbSingle.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(CBragach)
            TotalCost = (CBragach * Tax) / 100
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(TotalCost - TotalCost + CBragach)
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbSingle.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))
            '============Ida e Volta=============
        ElseIf ComboBox6.Text = "Braga" And Rbconf.Checked And rbReturn.Checked And rbAdultYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CBraga)
            TotalCost = (2 * (CBraga * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost * 2)
            lblTotal.Text = FormatCurrency(2 * (TotalCost + CBraga))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblAdult.Text = rbAdultYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))

        ElseIf ComboBox6.Text = "Braga" And Rbconf.Checked And rbReturn.Checked And rbChildYes.Checked Then
            lblSubTotal.Text = FormatCurrency(2 * CBragach)
            TotalCost = (2 * (CBragach * Tax) / 100)
            lblTax.Text = FormatCurrency(TotalCost - TotalCost)
            lblTotal.Text = FormatCurrency(2 * (TotalCost - TotalCost + CBragach))
            LblPrice.Text = lblTotal.Text
            LblFrom.Text = "Lisboa"
            LblTo.Text = ComboBox6.Text
            lblClasse.Text = Rbconf.Text
            LblTicket.Text = rbReturn.Text
            LblChild.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            LblAdult.Text = rbChildYes.Text
            lblRoute.Text = "Intercidades"
            lblDate1.Text = Today()
            lblTime.Text = TimeOfDay
            lblRefNo.Text = (Str(Int(Rnd() * 32654)))



        End If
    End Sub

    Private Sub BtnClear_Click(sender As Object, e As EventArgs) Handles BtnClear.Click
        lblClasse.Text = ""
        LblTicket.Text = ""
        LblAdult.Text = ""
        LblChild.Text = ""
        LblFrom.Text = ""
        LblTo.Text = ""
        LblPrice.Text = ""
        lblRefNo.Text = ""
        lblDate1.Text = ""
        lblTime.Text = ""
        lblRoute.Text = ""
    End Sub

    Private Sub BtnReset_Click(sender As Object, e As EventArgs) Handles BtnReset.Click
        lblClasse.Text = ""
        LblTicket.Text = ""
        LblAdult.Text = ""
        LblChild.Text = ""
        LblFrom.Text = ""
        LblTo.Text = ""
        LblPrice.Text = ""
        lblRefNo.Text = ""
        lblDate1.Text = ""
        lblTime.Text = ""
        lblRoute.Text = ""
        lblSubTotal.Text = ""
        lblTotal.Text = ""
        lblTax.Text = ""
        ComboBox6.Text = ""

        If TypeOf rbAdultYes Is RadioButton Then
            CType(rbAdultYes, RadioButton).Checked = False
        End If

        If TypeOf rbChildYes Is RadioButton Then
            CType(rbChildYes, RadioButton).Checked = False
        End If

        If TypeOf rbReturn Is RadioButton Then
            CType(rbReturn, RadioButton).Checked = False
        End If

        If TypeOf rbSingle Is RadioButton Then
            CType(rbSingle, RadioButton).Checked = False
        End If

        If TypeOf rbStandard Is RadioButton Then
            CType(rbStandard, RadioButton).Checked = False
        End If

        If TypeOf Rbconf Is RadioButton Then
            CType(Rbconf, RadioButton).Checked = False
        End If
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Application.Exit()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If LblDisplay.Text <> "0" Then
            LblDisplay.Text += "1"
        Else
            LblDisplay.Text = "1"
        End If
    End Sub
End Class

