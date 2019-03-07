'==============================================================================
'Project:         World Cities Project
'Title:           World Cities
'File Name:       
'Date Completed:  
'
'Authors:         Louie Escalera, Linda Lim, Elizabeth Robinson, Neil Wiborg
'Class:           CS 115 Section C
'
'Description:     
'                 
'                 
'                 
'                 
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

    Dim strCitiesFromArgentina(4, 120) As String
    Dim strCitiesFromBangladesh(4, 120) As String
    Dim strCitiesFromBrazil(4, 120) As String
    Dim strCitiesFromCanada(4, 120) As String
    Dim strCitiesFromChina(4, 120) As String
    Dim strCitiesFromIndia(4, 120) As String
    Dim strCitiesFromIndonesia(4, 120) As String
    Dim strCitiesFromJapan(4, 120) As String
    Dim strCitiesFromMexico(4, 120) As String
    Dim strCitiesFromNigeria(4, 120) As String
    Dim strCitiesFromPakistan(4, 120) As String
    Dim strCitiesFromPhilippines(4, 120) As String
    Dim strCitiesFromRussia(4, 120) As String
    Dim strCitiesFromUK(4, 120) As String
    Dim strCitiesFromUSA(4, 120) As String


    Private Sub frmCities_Load(sender As Object,
                               e As EventArgs) Handles MyBase.Load
        '----------------------------------------------------------------------
        'DESCRIPTION:    DESC
        '                
        '                
        '                
        '                
        '----------------------------------------------------------------------
        ''Get files with file extension .wcf from data folder
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
                    strCitiesFromPhilippines(intPhilippinesCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 1) = strtempCityName
                    strCitiesFromPhilippines(intPhilippinesCountArray, 2) = strCountryName

                    strCitiesFromPhilippines(intPhilippinesCountArray, 3) = LineInput(1)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromPhilippines(intPhilippinesCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 5) = LineInput(1)
                    intPhilippinesCountArray += 1

                Case "Russia"

                    strCitiesFromRussia(intRussiaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromRussia(intRussiaCountArray, 1) = strtempCityName
                    strCitiesFromRussia(intRussiaCountArray, 2) = strCountryName
                    strCitiesFromRussia(intRussiaCountArray, 3) = LineInput(1)
                    strCitiesFromRussia(intRussiaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromRussia(intRussiaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromRussia(intRussiaCountArray, 5) = LineInput(1)
                    intRussiaCountArray += 1

                Case "United Kingdom"

                    strCitiesFromUK(intUKCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromUK(intUKCountArray, 1) = strtempCityName
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

                    strCitiesFromUSA(intUSACountArray, 0) = CStr(inttempFileLines)
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
                    intUKCountArray += 1

                Case "Argentina"
                    strCitiesFromArgentina(intArgentinaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromArgentina(intArgentinaCountArray, 1) = strtempCityName
                    strCitiesFromArgentina(intArgentinaCountArray, 2) = strCountryName
                    strCitiesFromArgentina(intArgentinaCountArray, 3) = LineInput(1)
                    strCitiesFromArgentina(intArgentinaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromArgentina(intArgentinaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromArgentina(intArgentinaCountArray, 5) = LineInput(1)
                    intArgentinaCountArray += 1

                Case "Bangladesh"

                    strCitiesFromBangladesh(intBangladeshCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromBangladesh(intBangladeshCountArray, 1) = strtempCityName
                    strCitiesFromBangladesh(intBangladeshCountArray, 2) = strCountryName
                    strCitiesFromBangladesh(intBangladeshCountArray, 3) = LineInput(1)
                    strCitiesFromBangladesh(intBangladeshCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromBangladesh(intBangladeshCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromBangladesh(intBangladeshCountArray, 5) = LineInput(1)
                    intBangladeshCountArray += 1


                Case "Brazil"

                    strCitiesFromBrazil(intBrazilCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromBrazil(intBrazilCountArray, 1) = strtempCityName
                    strCitiesFromBrazil(intBrazilCountArray, 2) = strCountryName
                    strCitiesFromBrazil(intBrazilCountArray, 3) = LineInput(1)
                    strCitiesFromBrazil(intBrazilCountArray, 4) = LineInput(1)


                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromBrazil(intBrazilCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromBrazil(intBrazilCountArray, 5) = LineInput(1)
                    intBrazilCountArray += 1


                Case "Canada"

                    strCitiesFromCanada(intCanadaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromCanada(intCanadaCountArray, 1) = strtempCityName
                    strCitiesFromCanada(intCanadaCountArray, 2) = strCountryName
                    strCitiesFromCanada(intCanadaCountArray, 3) = LineInput(1)
                    strCitiesFromCanada(intCanadaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromCanada(intCanadaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromCanada(intCanadaCountArray, 5) = LineInput(1)
                    intCanadaCountArray += 1

                Case "China"

                    strCitiesFromChina(intChinaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromChina(intChinaCountArray, 1) = strtempCityName
                    strCitiesFromChina(intChinaCountArray, 2) = strCountryName
                    strCitiesFromChina(intChinaCountArray, 3) = LineInput(1)
                    strCitiesFromChina(intChinaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromChina(intChinaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromChina(intChinaCountArray, 5) = LineInput(1)
                    intChinaCountArray += 1

                Case "India"

                    strCitiesFromIndia(intIndiaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromIndia(intIndiaCountArray, 1) = strtempCityName
                    strCitiesFromIndia(intIndiaCountArray, 2) = strCountryName
                    strCitiesFromIndia(intIndiaCountArray, 3) = LineInput(1)
                    strCitiesFromIndia(intIndiaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromIndia(intIndiaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromIndia(intIndiaCountArray, 5) = LineInput(1)
                    intIndiaCountArray += 1


                Case "Indonesia"

                    strCitiesFromIndonesia(intIndonesiaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromIndonesia(intIndonesiaCountArray, 1) = strtempCityName
                    strCitiesFromIndonesia(intIndonesiaCountArray, 2) = strCountryName
                    strCitiesFromIndonesia(intIndonesiaCountArray, 3) = LineInput(1)
                    strCitiesFromIndonesia(intIndonesiaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromIndonesia(intIndonesiaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromIndonesia(intIndonesiaCountArray, 5) = LineInput(1)
                    intIndonesiaCountArray += 1

                Case "Japan"

                    strCitiesFromJapan(intJapanCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromJapan(intJapanCountArray, 1) = strtempCityName
                    strCitiesFromJapan(intJapanCountArray, 2) = strCountryName
                    strCitiesFromJapan(intJapanCountArray, 3) = LineInput(1)
                    strCitiesFromJapan(intJapanCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromJapan(intJapanCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromJapan(intJapanCountArray, 5) = LineInput(1)
                    intJapanCountArray += 1

                Case "Mexico"
                    strCitiesFromMexico(intMexicoCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromMexico(intMexicoCountArray, 1) = strtempCityName
                    strCitiesFromMexico(intMexicoCountArray, 2) = strCountryName
                    strCitiesFromMexico(intMexicoCountArray, 3) = LineInput(1)
                    strCitiesFromMexico(intMexicoCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromMexico(intMexicoCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromMexico(intMexicoCountArray, 5) = LineInput(1)
                    intMexicoCountArray += 1

                Case "Nigeria"
                    strCitiesFromNigeria(intNigeriaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromNigeria(intNigeriaCountArray, 1) = strtempCityName
                    strCitiesFromNigeria(intNigeriaCountArray, 2) = strCountryName
                    strCitiesFromNigeria(intNigeriaCountArray, 3) = LineInput(1)
                    strCitiesFromNigeria(intNigeriaCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromNigeria(intNigeriaCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromNigeria(intNigeriaCountArray, 5) = LineInput(1)
                    intNigeriaCountArray += 1
                Case "Pakistan"
                    strCitiesFromPakistan(intPakistanCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromPakistan(intPakistanCountArray, 1) = strtempCityName
                    strCitiesFromPakistan(intPakistanCountArray, 2) = strCountryName
                    strCitiesFromPakistan(intPakistanCountArray, 3) = LineInput(1)
                    strCitiesFromPakistan(intPakistanCountArray, 4) = LineInput(1)

                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        strCitiesFromPakistan(intPakistanCountArray, p) = LineInput(1)
                        p += 1
                    Next i
                    LineInput(1)
                    strCitiesFromPakistan(intPakistanCountArray, 5) = LineInput(1)
                    intPakistanCountArray += 1


            End Select
            FileClose(1)


        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    DESC
        '                
        '                
        '                
        '                
        '----------------------------------------------------------------------
        Close()
    End Sub

    Private Sub lstCountries_Click(sender As Object, e As EventArgs) Handles lstCountries.Click
        '----------------------------------------------------------------------
        'DESCRIPTION:    DESC
        '                
        '                
        '                
        '                
        '----------------------------------------------------------------------
        Select Case lstCountries.SelectedItem.ToString()
            Case "Philippines"
                radCity1.Text = strCitiesFromPhilippines(0, 1)
                radCity2.Text = strCitiesFromPhilippines(1, 1)
                radCity3.Text = strCitiesFromPhilippines(2, 1)
                radCity4.Text = strCitiesFromPhilippines(3, 1)
            Case "United Kingdom"
                radCity1.Text = strCitiesFromUK(0, 1)
                radCity2.Text = strCitiesFromUK(1, 1)
                radCity3.Text = strCitiesFromUK(2, 1)
                radCity4.Text = strCitiesFromUK(3, 1)
            Case "Russia"
                radCity1.Text = strCitiesFromRussia(0, 1)
                radCity2.Text = strCitiesFromRussia(1, 1)
                radCity3.Text = strCitiesFromRussia(2, 1)
                radCity4.Text = strCitiesFromRussia(3, 1)
            Case "United States"
                radCity1.Text = strCitiesFromUSA(0, 1)
                radCity2.Text = strCitiesFromUSA(1, 1)
                radCity3.Text = strCitiesFromUSA(2, 1)
                radCity4.Text = strCitiesFromUSA(3, 1)
        End Select
    End Sub

    Private Function fCityData() As String
        '----------------------------------------------------------------------
        'DESCRIPTION:    Selecting a radCity will run this function
        '                Needs a return
        '                
        '                
        '                
        '----------------------------------------------------------------------
    End Function
End Class
