Public Class Form1

    Dim oneToNine() As String = {"එක", "දෙක", "තුන", "හතර", "පහ", "හය", "හත", "අට", "නවය"}
    Dim tenToTwenty() As String = {"දහය", "එකොළ", "දොළ", "දහතු", "දහහත", "පහළ", "දහස", "දහහ", "දහඅ", "දහන", "විස්"}
    Dim tenToNineteen() As String = {"එකොළොස්", "දොළොස්", "දහතුන්", "දහහත්", "පහළොස්", "දහසය", "දහහත්", "දහඅට", "දහනව"}
    Dim tens() As String = {"දහ", "විසි", "තිස්", "හතලිස්", "පනස්", "හැට", "හැත්තෑ", "අසූ", "අනූ"}
    Dim hundreds() As String = {"එක", "දෙ", "තුන්", "හාර", "පන්", "හය", "හත්", "අට", "නව"}
    Dim thousands() As String = {"එක්", "දෙ", "තුන්", "හතර", "පන්", "හය", "හත්", "අට", "නව", "දහ"}
    Dim extra10() As String = {"එකයි", "දෙකයි", "තුනයි", "හතරයි", "පහයි", "හයයි", "හතයි", "අටයි", "නවයයි"}
    Dim currencyBeforeCents As String
    Dim currencyCents As String
    Dim translationBeforeCents As String
    Dim translationCents As String
    Dim finalOutput As String


    'Function for translating cents to sinhala language (Maximum2 digits)

    Function translateCents(currencyCents As String) As String

        Dim final As String = Nothing

        If currencyCents = "" Or currencyCents = "00" Or currencyCents = "0" Then

            final = " ශත බිංදුවයි "

        ElseIf currencyCents.Length = 1 Then

            final = " ශත " + translateOnes(currencyCents)

        ElseIf currencyCents.Substring(0, 1) = "0" And currencyCents.Substring(1, 1) <> "0" Then

            final = " ශත " + translateOnes(currencyCents.Substring(1))

        ElseIf currencyCents.Substring(0, 1) = "1" Then

            final = " ශත " + translateTenTo19(currencyCents)

        Else

            final = " ශත " + translateTwentyTo99(currencyCents)

        End If

        Return final

    End Function



    'Function for translating 0 - 9 currency to sinhala language

    Public Function translateOnes(currencyBeforeCents As String) As String

        Dim final As String = Nothing

        Select Case currencyBeforeCents.Substring(0, 1)
            Case "0" : final = "බිංදුවයි"
            Case "1" : final = oneToNine(0) + "යි"
            Case "2" : final = oneToNine(1) + "යි"
            Case "3" : final = oneToNine(2) + "යි"
            Case "4" : final = oneToNine(3) + "යි"
            Case "5" : final = oneToNine(4) + "යි"
            Case "6" : final = oneToNine(5) + "යි"
            Case "7" : final = oneToNine(6) + "යි"
            Case "8" : final = oneToNine(7) + "යි"
            Case "9" : final = oneToNine(8) + "යි"
        End Select

        Return final

    End Function


    'Function for translating 10 - 19 currency to sinhala language

    Public Function translateTenTo19(currencyBeforeCents As String) As String

        Dim final As String = Nothing

        Select Case currencyBeforeCents
            Case "10" : final = tenToTwenty(0) + "යි"
            Case "11" : final = tenToTwenty(1) + "හයි"
            Case "12" : final = tenToTwenty(2) + "හයි"
            Case "13" : final = tenToTwenty(3) + "නයි"
            Case "14" : final = tenToTwenty(4) + "රයි"
            Case "15" : final = tenToTwenty(5) + "වයි"
            Case "16" : final = tenToTwenty(6) + "යයි"
            Case "17" : final = tenToTwenty(7) + "තයි"
            Case "18" : final = tenToTwenty(8) + "ටයි"
            Case "19" : final = tenToTwenty(9) + "වයයි"
        End Select

        Return final

    End Function



    'Function for translating 20 - 99 currency to sinhala language

    Public Function translateTwentyTo99(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim second As String = currencyBeforeCents.Substring(1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 2
        Dim y As Integer = 1

        If second.Equals("0") Then

            Select Case currencyBeforeCents
                Case "20" : secondWord = "විස්සයි"
                Case "30" : secondWord = "තිහයි"
                Case "40" : secondWord = "හතලිහයි"
                Case "50" : secondWord = "පනහයි"
                Case "60" : secondWord = "හැටයි"
                Case "70" : secondWord = "හැත්තෑවයි"
                Case "80" : secondWord = "අසූවයි"
                Case "90" : secondWord = "අනූවයි"
            End Select

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then
                    firstWord = tens(x - 1)
                End If

                x = x + 1

            End While

            While y < 10

                If second.Equals(Convert.ToString(y)) Then
                    secondWord = extra10(y - 1)
                End If

                y = y + 1

            End While

        End If

        final = firstWord & secondWord

        Return final

    End Function


    'Function for translating 100 - 999 currency to sinhala language

    Public Function translateHundredsTo999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = hundreds(x - 1) + "සිය "

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(0, 3) = "000" Then

            secondWord = ""

        ElseIf currencyBeforeCents.Substring(1, 2) = "00" Then

            secondWord = "යයි"

        ElseIf currencyBeforeCents.Substring(1, 1) = "1" Then

            secondWord = translateTenTo19(currencyBeforeCents.Substring(1, 2))

        Else

            secondWord = translateTwentyTo99(currencyBeforeCents.Substring(1, 2))

        End If

        final = firstWord & secondWord

        Return final

    End Function



    'Function for translating 1000 - 9999 currency to sinhala language

    Public Function translateOneThousandTo9999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = thousands(x - 1)

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(1, 3) = "000" Then

            secondWord = "දහසයි"

        Else

            secondWord = "දහස් "
            secondWord += translateHundredsTo999(currencyBeforeCents.Substring(1, 3))

        End If

        final = firstWord & secondWord

        Return final

    End Function


    'Function for translating 10,000 - 99,999 currency to sinhala language

    Public Function translateTenThousandTo99999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" Then

            Select Case currencyBeforeCents.Substring(0, 2)
                Case "11" : firstWord = tenToNineteen(0) + "දහ"
                Case "12" : firstWord = tenToNineteen(1) + "දහ"
                Case "13" : firstWord = tenToNineteen(2) + "දහ"
                Case "14" : firstWord = tenToNineteen(3) + "දහ"
                Case "15" : firstWord = tenToNineteen(4) + "දහ"
                Case "16" : firstWord = tenToNineteen(5) + "දහ"
                Case "17" : firstWord = tenToNineteen(6) + "දහ"
                Case "18" : firstWord = tenToNineteen(7) + "දහ"
                Case "19" : firstWord = tenToNineteen(8) + "දහ"
            End Select

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = tens(x - 1)

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(1, 4) = "0000" Then

            secondWord = "දහසයි"

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" And currencyBeforeCents.Substring(2, 3) = "000" Then

            secondWord = "සයි"

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" Then

            secondWord = "දහස් "
            secondWord += translateHundredsTo999(currencyBeforeCents.Substring(2, 3))

        Else

            secondWord += translateOneThousandTo9999(currencyBeforeCents.Substring(1, 4))

        End If

        final = firstWord & secondWord

        Return final

    End Function


    'Function for translating 100,000 - 999,999 currency to sinhala language

    Public Function translateOneLakhTo999999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = thousands(x - 1) + "ලක්ෂ"

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(1, 5) = "00000" Then

            secondWord = "සයයි"

        Else

            secondWord = "  "
            secondWord += translateTenThousandTo99999(currencyBeforeCents.Substring(1, 5))

        End If

        final = firstWord & secondWord

        Return final

    End Function



    'Function for translating 10,00,000 - 99,99,999 currency to sinhala language

    Public Function translateTenLakhTo9999999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" Then

            Select Case currencyBeforeCents.Substring(0, 2)
                Case "11" : firstWord = tenToNineteen(0) + " ලක්ෂ "
                Case "12" : firstWord = tenToNineteen(1) + " ලක්ෂ "
                Case "13" : firstWord = tenToNineteen(2) + " ලක්ෂ "
                Case "14" : firstWord = tenToNineteen(3) + " ලක්ෂ "
                Case "15" : firstWord = tenToNineteen(4) + " ලක්ෂ "
                Case "16" : firstWord = tenToNineteen(5) + " ලක්ෂ "
                Case "17" : firstWord = tenToNineteen(6) + " ලක්ෂ "
                Case "18" : firstWord = tenToNineteen(7) + " ලක්ෂ "
                Case "19" : firstWord = tenToNineteen(8) + " ලක්ෂ "
            End Select

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = tens(x - 1)

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(2, 5) = "00000" Then

            secondWord = "ලක්ෂසයයි"

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" Then

            secondWord += translateTenThousandTo99999(currencyBeforeCents.Substring(2, 5))

        Else

            secondWord = " "
            secondWord += translateOneLakhTo999999(currencyBeforeCents.Substring(1, 6))

        End If

        final = firstWord & secondWord

        Return final

    End Function



    'Function for translating 1,00,00,000 - 9,99,99,999 currency to sinhala language

    Public Function translateOneCroreTo99999999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = thousands(x - 1) + " කෝටි"

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(1, 7) = "0000000" Then

            secondWord = "යයි "

        Else

            secondWord = " "
            secondWord += translateTenLakhTo9999999(currencyBeforeCents.Substring(1, 7))

        End If

        final = firstWord & secondWord

        Return final

    End Function



    'Function for translating 10,00,00,000 - 99,99,99,999 currency to sinhala language

    Public Function translateTenCroreTo999999999(currencyBeforeCents As String) As String

        Dim first As String = currencyBeforeCents.Substring(0, 1)
        Dim firstWord As String = Nothing
        Dim secondWord As String = Nothing
        Dim final As String = Nothing

        Dim x As Integer = 1

        If first.Equals("0") Then

            firstWord = ""

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" Then

            Select Case currencyBeforeCents.Substring(0, 2)
                Case "11" : firstWord = tenToNineteen(0) + " කෝටි "
                Case "12" : firstWord = tenToNineteen(1) + " කෝටි "
                Case "13" : firstWord = tenToNineteen(2) + " කෝටි "
                Case "14" : firstWord = tenToNineteen(3) + " කෝටි "
                Case "15" : firstWord = tenToNineteen(4) + " කෝටි "
                Case "16" : firstWord = tenToNineteen(5) + " කෝටි "
                Case "17" : firstWord = tenToNineteen(6) + " කෝටි "
                Case "18" : firstWord = tenToNineteen(7) + " කෝටි "
                Case "19" : firstWord = tenToNineteen(8) + " කෝටි "
            End Select

        Else

            While x < 10

                If first.Equals(Convert.ToString(x)) Then

                    firstWord = tens(x - 1)

                End If

                x = x + 1

            End While

        End If


        If currencyBeforeCents.Substring(1, 8) = "00000000" Then

            secondWord = "කෝටියයි"

        ElseIf currencyBeforeCents.Substring(0, 1) = "1" And currencyBeforeCents.Substring(0, 2) <> "10" Then

            secondWord += translateTenLakhTo9999999(currencyBeforeCents.Substring(2, 7))

        Else

            secondWord = " "
            secondWord += translateOneCroreTo99999999(currencyBeforeCents.Substring(1, 8))

        End If

        final = firstWord & secondWord

        Return final

    End Function




    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles lblTranslate.Click

        If IsNumeric(txtCurrency.Text) Then

            Dim currencyText As String = txtCurrency.Text

            If currencyText.Contains(".") Then

                currencyBeforeCents = txtCurrency.Text.Split(".")(0)
                currencyCents = txtCurrency.Text.Split(".")(1)

            Else

                currencyBeforeCents = txtCurrency.Text
                currencyCents = Nothing

            End If

            translationCents = translateCents(currencyCents)

            If currencyBeforeCents.Length = 1 Then
                translationBeforeCents = translateOnes(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 2 And currencyBeforeCents.Substring(0, 1) = "1" Then
                translationBeforeCents = translateTenTo19(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 2 Then
                translationBeforeCents = translateTwentyTo99(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 3 Then
                translationBeforeCents = translateHundredsTo999(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 4 Then
                translationBeforeCents = translateOneThousandTo9999(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 5 Then
                translationBeforeCents = translateTenThousandTo99999(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 6 Then
                translationBeforeCents = translateOneLakhTo999999(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 7 Then
                translationBeforeCents = translateTenLakhTo9999999(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 8 Then
                translationBeforeCents = translateOneCroreTo99999999(currencyBeforeCents)

            ElseIf currencyBeforeCents.Length = 9 Then
                translationBeforeCents = translateTenCroreTo999999999(currencyBeforeCents)

            End If

            finalOutput = translationBeforeCents & translationCents

            lblTranslation.Text = finalOutput

        Else

            MsgBox("Please enter a valid currency between 0 to 99 crore !")
            txtCurrency.Text = Nothing
            lblTranslation.Text = Nothing

            currencyBeforeCents = Nothing
            currencyCents = Nothing
            translationBeforeCents = Nothing
            translationCents = Nothing
            finalOutput = Nothing

        End If

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles lblClear.Click

        txtCurrency.Text = Nothing
        lblTranslation.Text = Nothing

        currencyBeforeCents = Nothing
        currencyCents = Nothing
        translationBeforeCents = Nothing
        translationCents = Nothing
        finalOutput = Nothing

    End Sub

End Class
