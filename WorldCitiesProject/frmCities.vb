﻿'==============================================================================
'Project:         World Cities Project
'Title:           World Cities
'File Name:       
'Date Completed:  
'
'Authors:         Louie Escalera, Linda Lim, Elizabeth Robinson, Neil Wiborg
'Class:           CS 115 Section C
'
'Description: This is collective code done by everyone. The programs first
'loads the data that was made into .wcf files and loads that data to a string 
'where user first selects that country and cities form that country pop up in
' radCities where the user selects the that city where it load the description
' and pic by that is associated by that city.
'                 
'==============================================================================
Option Explicit On
Option Strict On
Public Class frmCities


    ''strCountryArray(i,p) i = hold the country placement
    ''p = the data
    ''strCountry(i,0) holds line count
    ''strCountry(i,1) holds city name
    ''strCountry(i,2) hold country where city is from
    ''strCountry(i,3) holds population
    ''strCountry(i,4) holds countryAnnualRainfall
    ''strCountry(i,5) holds Image Name
    ''strCountry(i,6+) hold description

    Dim strCitiesFromArgentina(10, 120) As String
    Dim strCitiesFromBangladesh(10, 120) As String
    Dim strCitiesFromBrazil(10, 120) As String
    Dim strCitiesFromCanada(10, 120) As String
    Dim strCitiesFromChina(10, 120) As String
    Dim strCitiesFromIndia(10, 120) As String
    Dim strCitiesFromIndonesia(10, 120) As String
    Dim strCitiesFromJapan(10, 120) As String
    Dim strCitiesFromMexico(10, 120) As String
    Dim strCitiesFromNigeria(10, 120) As String
    Dim strCitiesFromPakistan(10, 120) As String
    Dim strCitiesFromPhilippines(10, 120) As String
    Dim strCitiesFromRussia(10, 120) As String
    Dim strCitiesFromUK(10, 120) As String
    Dim strCitiesFromUSA(10, 120) As String


    Private Sub frmCities_Load(sender As Object,
                               e As EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------
        'DESCRIPTION:             
        ''Get files with file extension .wcf from data folder
        'then categorize the city by  country then stores their information by
        'into an array
        '----------------------------------------------------------------------
        Dim fileCities As String() = System.IO.Directory.GetFiles("../Data",
                                                                  "*.wcf")
        Dim inttempFileLines As Integer = 0
        Dim strtempCityName As String = ""
        Dim strCountryName As String = ""

        Dim intArgentinaCountArray As Integer = 0
        Dim intBangladeshCountArray As Integer = 0
        Dim intBrazilCountArray As Integer = 0
        Dim intCanadaCountArray As Integer = 0
        Dim intChinaCountArray As Integer = 0
        Dim intIndiaCountArray As Integer = 0
        Dim intIndonesiaCountArray As Integer = 0
        Dim intJapanCountArray As Integer = 0
        Dim intMexicoCountArray As Integer = 0
        Dim intNigeriaCountArray As Integer = 0
        Dim intPakistanCountArray As Integer = 0
        Dim intPhilippinesCountArray As Integer = 0
        Dim intRussiaCountArray As Integer = 0
        Dim intUKCountArray As Integer = 0
        Dim intUSACountArray As Integer = 0

        For Each sFile As String In fileCities
            FileOpen(1, sFile, OpenMode.Input)
            inttempFileLines = CInt(LineInput(1))
            strtempCityName = LineInput(1)
            LineInput(1)
            strCountryName = LineInput(1)
            Dim i As Integer = 0
            Dim p As Integer = 5
            Select Case strCountryName

                Case "Philippines"
                    strCitiesFromPhilippines(intPhilippinesCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 1) =
                        strtempCityName
                    strCitiesFromPhilippines(intPhilippinesCountArray, 2) =
                        strCountryName

                    strCitiesFromPhilippines(intPhilippinesCountArray, 3) =
                        LineInput(1)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromPhilippines(intPhilippinesCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 5) = 
                        LineInput(1)
                    intPhilippinesCountArray += 1

                Case "Russia"
                    strCitiesFromRussia(intRussiaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromRussia(intRussiaCountArray, 1) =
                        strtempCityName
                    strCitiesFromRussia(intRussiaCountArray, 2) =
                        strCountryName
                    strCitiesFromRussia(intRussiaCountArray, 3) = LineInput(1)
                    strCitiesFromRussia(intRussiaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromRussia(intRussiaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromRussia(intRussiaCountArray, 5) = LineInput(1)
                    intRussiaCountArray += 1

                Case "United Kingdom"

                    strCitiesFromUK(intUKCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromUK(intUKCountArray, 1) =
                        strtempCityName
                    strCitiesFromUK(intUKCountArray, 2) = strCountryName
                    strCitiesFromUK(intUKCountArray, 3) = LineInput(1)
                    strCitiesFromUK(intUKCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromUK(intUKCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromUK(intUKCountArray, 5) = LineInput(1)
                    intUKCountArray += 1

                Case "United States"

                    strCitiesFromUSA(intUSACountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromUSA(intUSACountArray, 1) = strtempCityName
                    strCitiesFromUSA(intUSACountArray, 2) = strCountryName
                    strCitiesFromUSA(intUSACountArray, 3) = LineInput(1)
                    strCitiesFromUSA(intUSACountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromUSA(intUSACountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromUSA(intUSACountArray, 5) = LineInput(1)
                    intUSACountArray += 1

                Case "Argentina"
                    strCitiesFromArgentina(intArgentinaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromArgentina(intArgentinaCountArray, 1) =
                        strtempCityName
                    strCitiesFromArgentina(intArgentinaCountArray, 2) =
                        strCountryName
                    strCitiesFromArgentina(intArgentinaCountArray, 3) =
                        LineInput(1)
                    strCitiesFromArgentina(intArgentinaCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromArgentina(intArgentinaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromArgentina(intArgentinaCountArray, 5) =
                        LineInput(1)
                    intArgentinaCountArray += 1

                Case "Bangladesh"

                    strCitiesFromBangladesh(intBangladeshCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromBangladesh(intBangladeshCountArray, 1) =
                        strtempCityName
                    strCitiesFromBangladesh(intBangladeshCountArray, 2) =
                        strCountryName
                    strCitiesFromBangladesh(intBangladeshCountArray, 3) =
                        LineInput(1)
                    strCitiesFromBangladesh(intBangladeshCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromBangladesh(intBangladeshCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromBangladesh(intBangladeshCountArray, 5) =
                        LineInput(1)
                    intBangladeshCountArray += 1


                Case "Brazil"

                    strCitiesFromBrazil(intBrazilCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromBrazil(intBrazilCountArray, 1) =
                        strtempCityName
                    strCitiesFromBrazil(intBrazilCountArray, 2) =
                        strCountryName
                    strCitiesFromBrazil(intBrazilCountArray, 3) =
                        LineInput(1)
                    strCitiesFromBrazil(intBrazilCountArray, 4) =
                        LineInput(1)


                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromBrazil(intBrazilCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromBrazil(intBrazilCountArray, 5) =
                        LineInput(1)
                    intBrazilCountArray += 1


                Case "Canada"

                    strCitiesFromCanada(intCanadaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromCanada(intCanadaCountArray, 1) =
                        strtempCityName
                    strCitiesFromCanada(intCanadaCountArray, 2) =
                        strCountryName
                    strCitiesFromCanada(intCanadaCountArray, 3) =
                        LineInput(1)
                    strCitiesFromCanada(intCanadaCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromCanada(intCanadaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromCanada(intCanadaCountArray, 5) = LineInput(1)
                    intCanadaCountArray += 1

                Case "China"

                    strCitiesFromChina(intChinaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromChina(intChinaCountArray, 1) =
                        strtempCityName
                    strCitiesFromChina(intChinaCountArray, 2) =
                        strCountryName
                    strCitiesFromChina(intChinaCountArray, 3) =
                        LineInput(1)
                    strCitiesFromChina(intChinaCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromChina(intChinaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromChina(intChinaCountArray, 5) =
                        LineInput(1)
                    intChinaCountArray += 1

                Case "India"

                    strCitiesFromIndia(intIndiaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromIndia(intIndiaCountArray, 1) =
                        strtempCityName
                    strCitiesFromIndia(intIndiaCountArray, 2) =
                        strCountryName
                    strCitiesFromIndia(intIndiaCountArray, 3) =
                        LineInput(1)
                    strCitiesFromIndia(intIndiaCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromIndia(intIndiaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromIndia(intIndiaCountArray, 5) =
                        LineInput(1)
                    intIndiaCountArray += 1


                Case "Indonesia"

                    strCitiesFromIndonesia(intIndonesiaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromIndonesia(intIndonesiaCountArray, 1) =
                        strtempCityName
                    strCitiesFromIndonesia(intIndonesiaCountArray, 2) =
                        strCountryName
                    strCitiesFromIndonesia(intIndonesiaCountArray, 3) =
                        LineInput(1)
                    strCitiesFromIndonesia(intIndonesiaCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromIndonesia(intIndonesiaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromIndonesia(intIndonesiaCountArray, 5) =
                        LineInput(1)
                    intIndonesiaCountArray += 1

                Case "Japan"

                    strCitiesFromJapan(intJapanCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromJapan(intJapanCountArray, 1) =
                        strtempCityName
                    strCitiesFromJapan(intJapanCountArray, 2) =
                        strCountryName
                    strCitiesFromJapan(intJapanCountArray, 3) =
                        LineInput(1)
                    strCitiesFromJapan(intJapanCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromJapan(intJapanCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromJapan(intJapanCountArray, 5) =
                        LineInput(1)
                    intJapanCountArray += 1

                Case "Mexico"
                    strCitiesFromMexico(intMexicoCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromMexico(intMexicoCountArray, 1) =
                        strtempCityName
                    strCitiesFromMexico(intMexicoCountArray, 2) =
                        strCountryName
                    strCitiesFromMexico(intMexicoCountArray, 3) =
                        LineInput(1)
                    strCitiesFromMexico(intMexicoCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromMexico(intMexicoCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromMexico(intMexicoCountArray, 5) =
                        LineInput(1)
                    intMexicoCountArray += 1

                Case "Nigeria"
                    strCitiesFromNigeria(intNigeriaCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromNigeria(intNigeriaCountArray, 1) =
                        strtempCityName
                    strCitiesFromNigeria(intNigeriaCountArray, 2) =
                        strCountryName
                    strCitiesFromNigeria(intNigeriaCountArray, 3) =
                        LineInput(1)
                    strCitiesFromNigeria(intNigeriaCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromNigeria(intNigeriaCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromNigeria(intNigeriaCountArray, 5) =
                        LineInput(1)
                    intNigeriaCountArray += 1
                Case "Pakistan"
                    strCitiesFromPakistan(intPakistanCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromPakistan(intPakistanCountArray, 1) =
                        strtempCityName
                    strCitiesFromPakistan(intPakistanCountArray, 2) =
                        strCountryName
                    strCitiesFromPakistan(intPakistanCountArray, 3) =
                        LineInput(1)
                    strCitiesFromPakistan(intPakistanCountArray, 4) =
                        LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromPakistan(intPakistanCountArray, p) =
                            LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromPakistan(intPakistanCountArray, 5) =
                        LineInput(1)
                    intPakistanCountArray += 1


            End Select
            FileClose(1)


        Next

    End Sub

    Private Sub btnExit_Click(sender As Object,
                              e As EventArgs) Handles btnExit.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    DESC
        '                
        '                
        '                
        '                
        '----------------------------------------------------------------------
        Close()
    End Sub

    Private Sub lstCountries_Click(sender As Object,
                                   e As EventArgs) Handles lstCountries.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    DESC
        '                
        '                
        '                
        '                
        '----------------------------------------------------------------------
        radCity1.Checked = False
        radCity2.Checked = False
        radCity3.Checked = False
        radCity4.Checked = False
        radCity5.Checked = False
        radCity6.Checked = False
        radCity7.Checked = False
        radCity8.Checked = False
        radCity9.Checked = False
        radCity10.Checked = False
        rtbInformation.Text = ""

        Select Case lstCountries.SelectedItem.ToString()
            Case "Argentina"
                radCity1.Text = strCitiesFromArgentina(0, 1)
                radCity2.Text = strCitiesFromArgentina(1, 1)
                radCity3.Text = strCitiesFromArgentina(2, 1)
                radCity4.Text = strCitiesFromArgentina(3, 1)
                radCity5.Text = strCitiesFromArgentina(4, 1)
                radCity6.Text = strCitiesFromArgentina(5, 1)
                radCity7.Text = strCitiesFromArgentina(6, 1)
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Bengladesh"
                radCity1.Text = ""
                radCity2.Text = ""
                radCity3.Text = ""
                radCity4.Text = ""
                radCity5.Text = ""
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Brazil"
                radCity1.Text = strCitiesFromBrazil(0, 1)
                radCity2.Text = strCitiesFromBrazil(1, 1)
                radCity3.Text = strCitiesFromBrazil(2, 1)
                radCity4.Text = strCitiesFromBrazil(3, 1)
                radCity5.Text = strCitiesFromBrazil(4, 1)
                radCity6.Text = strCitiesFromBrazil(5, 1)
                radCity7.Text = strCitiesFromBrazil(6, 1)
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Canada"
                radCity1.Text = strCitiesFromCanada(0, 1)
                radCity2.Text = strCitiesFromCanada(1, 1)
                radCity3.Text = strCitiesFromCanada(2, 1)
                radCity4.Text = strCitiesFromCanada(3, 1)
                radCity5.Text = strCitiesFromCanada(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "China"
                radCity1.Text = strCitiesFromChina(0, 1)
                radCity2.Text = strCitiesFromChina(1, 1)
                radCity3.Text = strCitiesFromChina(2, 1)
                radCity4.Text = strCitiesFromChina(3, 1)
                radCity5.Text = strCitiesFromChina(4, 1)
                radCity6.Text = strCitiesFromChina(5, 1)
                radCity7.Text = strCitiesFromChina(6, 1)
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "India"
                radCity1.Text = ""
                radCity2.Text = ""
                radCity3.Text = ""
                radCity4.Text = ""
                radCity5.Text = ""
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Indonesia"
                radCity1.Text = strCitiesFromIndonesia(0, 1)
                radCity2.Text = strCitiesFromIndonesia(1, 1)
                radCity3.Text = strCitiesFromIndonesia(2, 1)
                radCity4.Text = strCitiesFromIndonesia(3, 1)
                radCity5.Text = strCitiesFromIndonesia(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Japan"
                radCity1.Text = strCitiesFromJapan(0, 1)
                radCity2.Text = strCitiesFromJapan(1, 1)
                radCity3.Text = strCitiesFromJapan(2, 1)
                radCity4.Text = strCitiesFromJapan(3, 1)
                radCity5.Text = strCitiesFromJapan(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Mexico"
                radCity1.Text = strCitiesFromMexico(0, 1)
                radCity2.Text = strCitiesFromMexico(1, 1)
                radCity3.Text = strCitiesFromMexico(2, 1)
                radCity4.Text = strCitiesFromMexico(3, 1)
                radCity5.Text = strCitiesFromMexico(4, 1)
                radCity6.Text = strCitiesFromMexico(5, 1)
                radCity7.Text = strCitiesFromMexico(6, 1)
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Nigeria"
                radCity1.Text = strCitiesFromNigeria(0, 1)
                radCity2.Text = strCitiesFromNigeria(1, 1)
                radCity3.Text = strCitiesFromNigeria(2, 1)
                radCity4.Text = strCitiesFromNigeria(3, 1)
                radCity5.Text = strCitiesFromNigeria(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Pakistan"
                radCity1.Text = strCitiesFromPakistan(0, 1)
                radCity2.Text = strCitiesFromPakistan(1, 1)
                radCity3.Text = strCitiesFromPakistan(2, 1)
                radCity4.Text = strCitiesFromPakistan(3, 1)
                radCity5.Text = strCitiesFromPakistan(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Philippines"
                radCity1.Text = strCitiesFromPhilippines(0, 1)
                radCity2.Text = strCitiesFromPhilippines(1, 1)
                radCity3.Text = strCitiesFromPhilippines(2, 1)
                radCity4.Text = strCitiesFromPhilippines(3, 1)
                radCity5.Text = strCitiesFromPhilippines(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "Russia"
                radCity1.Text = strCitiesFromRussia(0, 1)
                radCity2.Text = strCitiesFromRussia(1, 1)
                radCity3.Text = strCitiesFromRussia(2, 1)
                radCity4.Text = strCitiesFromRussia(3, 1)
                radCity5.Text = strCitiesFromRussia(4, 1)
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case "United Kingdom"
                radCity1.Text = strCitiesFromUK(0, 1)
                radCity2.Text = strCitiesFromUK(1, 1)
                radCity3.Text = strCitiesFromUK(2, 1)
                radCity4.Text = strCitiesFromUK(3, 1)
                radCity5.Text = strCitiesFromUK(4, 1)
                radCity6.Text = strCitiesFromUK(5, 1)
                radCity7.Text = strCitiesFromUK(6, 1)
                radCity8.Text = strCitiesFromUK(7, 1)
                radCity9.Text = ""
                radCity10.Text = ""
            Case "United States"
                radCity1.Text = strCitiesFromUSA(0, 1)
                radCity2.Text = strCitiesFromUSA(1, 1)
                radCity3.Text = strCitiesFromUSA(2, 1)
                radCity4.Text = strCitiesFromUSA(3, 1)
                radCity5.Text = strCitiesFromUSA(4, 1)
                radCity6.Text = strCitiesFromUSA(5, 1)
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
            Case Else
                radCity1.Text = ""
                radCity2.Text = ""
                radCity3.Text = ""
                radCity4.Text = ""
                radCity5.Text = ""
                radCity6.Text = ""
                radCity7.Text = ""
                radCity8.Text = ""
                radCity9.Text = ""
                radCity10.Text = ""
        End Select
    End Sub

    Private Sub radCity1_Click(sender As Object, 
                               e As EventArgs) Handles radCity1.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity1 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(0)
        '----------------------------------------------------------------------
        'DESCRIPTION:    Clicking on radCity1 will show the cities pictures
        '                assigned to the radio button from lstCountries.
        '                
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then

            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(0, 5))
                    End If
                Case "Bangladesh"
                    If strCitiesFromBangladesh(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(0, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(0, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(0, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(0, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(0, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(0, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(0, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(0, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(0, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(0, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(0, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(0, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(0, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(0, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(0, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub

    Private Sub radCity2_Click(sender As Object,
                               e As EventArgs) Handles radCity2.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity2 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(1)
        '----------------------------------------------------------------------
        'DESCRIPTION:    Clicking on radCity2 will show the cities pictures
        '                assigned to the radio button from lstCountries.
        '                
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(1, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(1, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(1, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(1, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(1, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(1, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(1, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(1, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(1, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(1, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(1, 5) <> "" Then
                        picCities.BackgroundImage = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(1, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(1, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(1, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(1, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(1, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(1, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub

    Private Sub radCity3_Click(sender As Object,
                               e As EventArgs) Handles radCity3.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity3 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(2)
        '----------------------------------------------------------------------
        'DESCRIPTION:    Clicking on radCity3 will show the cities pictures
        '                assigned to the radio button from lstCountries.
        '                
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(3, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(3, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(3, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(3, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(3, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(3, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(3, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(3, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(3, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(3, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(3, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(3, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(3, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(3, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(3, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(3, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub

    Private Sub radCity4_Click(sender As Object,
                               e As EventArgs) Handles radCity4.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity4 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(3)
        '----------------------------------------------------------------------
        'DESCRIPTION:    Clicking on radCity4 will show the cities pictures
        '                assigned to the radio button from lstCountries.
        '                              
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(4, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(4, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(4, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(4, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(4, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(4, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(4, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(4, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(4, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(4, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(4, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(4, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(4, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(4, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(4, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub
    Private Sub radCity5_Click(sender As Object,
                               e As EventArgs) Handles radCity5.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity5 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(4)
        '----------------------------------------------------------------------
        'DESCRIPTION:    When selected will display the pictures and text
        '                of selected cities designated to radCity5.
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(4, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(4, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(4, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(4, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(4, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(4, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(4, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(4, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(4, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(4, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(4, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(4, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(4, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(4, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(4, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(4, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub
    Private Sub radCity6_Click(sender As Object,
                               e As EventArgs) Handles radCity6.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity6 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(5)
        '----------------------------------------------------------------------
        'DESCRIPTION:    When selected will display the pictures and text
        '                of selected cities designated to radCity6.
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(5, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(5, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(5, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(5, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(5, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(5, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(5, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(5, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(5, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(5, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(5, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(5, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(5, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(5, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(5, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(5, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub
    Private Sub radCity7_Click(sender As Object,
                               e As EventArgs) Handles radCity7.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity7 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(6)
        '----------------------------------------------------------------------
        'DESCRIPTION:    When selected will display the pictures and text
        '                of selected cities designated to radCity7.
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(6, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(6, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(6, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(6, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(6, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(6, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(6, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(6, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(6, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(6, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(6, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(6, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(6, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(6, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(6, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(6, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub
    Private Sub radCity8_Click(sender As Object,
                               e As EventArgs) Handles radCity8.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity8 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(7)
        '----------------------------------------------------------------------
        'DESCRIPTION:    When selected will display the pictures and text
        '                of selected cities designated to radCity8.
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(7, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(7, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(7, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(7, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(7, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(7, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(7, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(7, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(7, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(7, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(7, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(7, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromRussia(7, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(7, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(7, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(7, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub
    Private Sub radCity9_Click(sender As Object,
                               e As EventArgs) Handles radCity9.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity9 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(8)
        '----------------------------------------------------------------------
        'DESCRIPTION:    When selected will display the pictures and text
        '                of selected cities designated to radCity9.
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(8, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(8, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(8, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(8, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(8, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(8, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(8, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(8, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(8, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(8, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(8, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(8, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(8, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(8, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(8, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(8, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub
    Private Sub radCity10_Click(sender As Object,
                                e As EventArgs) Handles radCity10.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when radCity10 is clicked. Sends index to CityData
        '                sub to fill the rtbInformation with city data.
        'CALLS:          sCityData
        '                
        '                
        '----------------------------------------------------------------------
        sCityData(9)
        '----------------------------------------------------------------------
        'DESCRIPTION:    When selected will display the pictures and text
        '                of selected cities designated to radCity10.
        '                
        '----------------------------------------------------------------------
        If lstCountries.SelectedItem IsNot Nothing Then
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    If strCitiesFromArgentina(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromArgentina(9, 5))
                    End If

                Case "Bangladesh"
                    If strCitiesFromBangladesh(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(9, 5))
                    End If
                Case "Brazil"
                    If strCitiesFromBrazil(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromBrazil(9, 5))
                    End If
                Case "Canada"
                    If strCitiesFromCanada(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromCanada(9, 5))
                    End If
                Case "China"
                    If strCitiesFromChina(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromChina(9, 5))
                    End If
                Case "India"
                    If strCitiesFromIndia(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndia(9, 5))
                    End If
                Case "Indonesia"
                    If strCitiesFromIndonesia(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromIndonesia(9, 5))
                    End If
                Case "Japan"
                    If strCitiesFromJapan(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromJapan(9, 5))
                    End If
                Case "Mexico"
                    If strCitiesFromMexico(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromMexico(9, 5))
                    End If
                Case "Nigeria"
                    If strCitiesFromNigeria(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromNigeria(9, 5))
                    End If
                Case "Pakistan"
                    If strCitiesFromPakistan(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromPakistan(9, 5))
                    End If
                Case "Philippines"
                    If strCitiesFromPhilippines(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" &
                            strCitiesFromPhilippines(9, 5))
                    End If
                Case "Russia"
                    If strCitiesFromRussia(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromRussia(9, 5))
                    End If
                Case "United Kingdom"
                    If strCitiesFromUK(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUK(9, 5))
                    End If
                Case "United States"
                    If strCitiesFromUSA(9, 5) <> "" Then
                        picCities.Image = Image.
                            FromFile("..\data\" & strCitiesFromUSA(9, 5))
                    End If
                Case Else
                    picCities.Image = Nothing
            End Select
        End If
    End Sub

    Private Sub sCityData(ByVal intCityIndex As Integer)
        '----------------------------------------------------------------------
        'DESCRIPTION:    Runs when a radCity radio button is clicked. Fills
        '                rtbInformation with the current city information.
        'CALLED BY:      radCity1_Click, radCity2_Click, radCity3_Click, 
        '                radCity4_Click
        '                
        '----------------------------------------------------------------------
        Dim i As Integer = 6
        If lstCountries.SelectedItem IsNot Nothing Then
            'In case a radCity button is clicked without a country selected
            Select Case lstCountries.SelectedItem.ToString()
                Case "Argentina"
                    rtbInformation.Text =
            "Country: " + strCitiesFromArgentina(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromArgentina(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromArgentina(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromArgentina(intCityIndex, i) = Nothing
                        rtbInformation.
                            Text += strCitiesFromArgentina(intCityIndex, i)
                        i += 1
                    Loop

                Case "Bengladesh"
                    rtbInformation.Text =
            "Country: " + strCitiesFromBangladesh(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromBangladesh(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromBangladesh(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromBangladesh(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromBangladesh(intCityIndex, i)
                        i += 1
                    Loop

                Case "Brazil"
                    rtbInformation.Text =
            "Country: " + strCitiesFromBrazil(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromBrazil(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromBrazil(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromBrazil(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromBrazil(intCityIndex, i)
                        i += 1
                    Loop

                Case "Canada"
                    rtbInformation.Text =
            "Country: " + strCitiesFromCanada(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromCanada(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromCanada(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromCanada(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromCanada(intCityIndex, i)
                        i += 1
                    Loop

                Case "China"
                    rtbInformation.Text =
            "Country: " + strCitiesFromChina(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromChina(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromChina(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromChina(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromChina(intCityIndex, i)
                        i += 1
                    Loop

                Case "India"
                    rtbInformation.Text =
            "Country: " + strCitiesFromIndia(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromIndia(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromIndia(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromIndia(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromIndia(intCityIndex, i)
                        i += 1
                    Loop

                Case "Indonesia"
                    rtbInformation.Text =
            "Country: " + strCitiesFromIndonesia(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromIndonesia(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromIndonesia(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromIndonesia(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromIndonesia(intCityIndex, i)
                        i += 1
                    Loop

                Case "Japan"
                    rtbInformation.Text =
            "Country: " + strCitiesFromJapan(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromJapan(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromJapan(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromJapan(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromJapan(intCityIndex, i)
                        i += 1
                    Loop

                Case "Mexico"
                    rtbInformation.Text =
            "Country: " + strCitiesFromMexico(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromMexico(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromMexico(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromMexico(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromMexico(intCityIndex, i)
                        i += 1
                    Loop

                Case "Nigeria"
                    rtbInformation.Text =
            "Country: " + strCitiesFromNigeria(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromNigeria(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromNigeria(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromNigeria(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromNigeria(intCityIndex, i)
                        i += 1
                    Loop

                Case "Pakistan"
                    rtbInformation.Text =
            "Country: " + strCitiesFromPakistan(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromPakistan(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromPakistan(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromPakistan(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromPakistan(intCityIndex, i)
                        i += 1
                    Loop

                Case "Philippines"
                    rtbInformation.Text =
            "Country: " + strCitiesFromPhilippines(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromPhilippines(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromPhilippines(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromPhilippines(intCityIndex,
                                                      i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromPhilippines(intCityIndex, i)
                        i += 1
                    Loop

                Case "Russia"
                    rtbInformation.Text =
            "Country: " + strCitiesFromRussia(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromRussia(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromRussia(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromRussia(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromRussia(intCityIndex, i)
                        i += 1
                    Loop

                Case "United Kingdom"
                    rtbInformation.Text =
            "Country: " + strCitiesFromUK(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromUK(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromUK(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromUK(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromUK(intCityIndex, i)
                        i += 1
                    Loop

                Case "United States"
                    rtbInformation.Text =
            "Country: " + strCitiesFromUSA(intCityIndex, 2) + Chr(13) +
            "Population: " + strCitiesFromUSA(intCityIndex, 3) +
            Chr(13) + "Annual Average Rainfall: " +
            strCitiesFromUSA(intCityIndex, 4) + Chr(13) + Chr(13)
                    Do Until strCitiesFromUSA(intCityIndex, i) = Nothing
                        rtbInformation.Text +=
                            strCitiesFromUSA(intCityIndex, i)
                        i += 1
                    Loop

            End Select
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object,
                               e As EventArgs) Handles btnReset.Click
        '======================================================================
        'When btnReset is selected it clears the image from picCities and 
        'the Text from'rtbInformation.deselected all the radial buttons
        '======================================================================
        picCities.Image = Nothing
        picCities.BackgroundImage = Nothing
        rtbInformation.Text = ""
        radCity1.Checked = False
        radCity2.Checked = False
        radCity3.Checked = False
        radCity4.Checked = False
        radCity5.Checked = False
        radCity6.Checked = False
        radCity7.Checked = False
        radCity8.Checked = False
        radCity9.Checked = False
        radCity10.Checked = False
    End Sub

    Private Sub chkItalic_Click(sender As Object,
                                e As EventArgs) Handles chkItalic.Click
        '======================================================================
        'When selected, this will allow all the text in rtbInformation to be 
        'in italics. When unselected, the text in rtbInformation will be no 
        'longer in italics.
        '======================================================================
        If chkItalic.Checked Then
            rtbInformation.Font = New Font(rtbInformation.Font, rtbInformation.
                                           Font.Style Or FontStyle.Italic)
        Else
            rtbInformation.Font = New Font(rtbInformation.Font, rtbInformation.
                                           Font.Style And Not FontStyle.Italic)
        End If
    End Sub

    Private Sub chkBold_Click(sender As Object,
                              e As EventArgs) Handles chkBold.Click

        '======================================================================
        'When selected, this will allow all the text in rtbInformation to be 
        'in bold. When unselected, the text in rtbInformation will be no 
        'longer bolded.
        '======================================================================

        If chkBold.Checked Then
            rtbInformation.Font = New Font(rtbInformation.Font, rtbInformation.
                                           Font.Style Or FontStyle.Bold)
        Else
            rtbInformation.Font = New Font(rtbInformation.Font, rtbInformation.
                                           Font.Style And Not FontStyle.Bold)
        End If
    End Sub

    Private Sub chkUnderline_Click(sender As Object,
                                   e As EventArgs) Handles chkUnderline.Click

        '======================================================================
        'When selected, this will allow all the text in rtbInformation to be 
        'underlined.When unselected, the text in rtbInformation will no 
        'longer be underlined.
        '======================================================================

        If chkUnderline.Checked Then
            rtbInformation.Font = New Font(rtbInformation.Font, rtbInformation.
                                           Font.Style Or FontStyle.Underline)
        Else
            rtbInformation.Font = New Font(rtbInformation.Font, rtbInformation.
                                           Font.Style And Not FontStyle.Underline)
        End If
    End Sub
End Class
