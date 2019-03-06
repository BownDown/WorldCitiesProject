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
    Dim strCitiesFromRussia(4, 120) As String
    Dim strCitiesFromPhilippines(4, 120) As String
    Dim strCitiesFromUK(4, 120) As String
    Dim strCitiesFromUSA(4, 120) As String
    Dim strCitiesFromArgentina(4, 120) As String


    Private Sub frmCities_Load(sender As Object,
                               e As EventArgs) Handles MyBase.Load
        ''Get files with file extension .wcf from data folder
        Dim fileCities As String() = System.IO.Directory.GetFiles("../Data",
                                                                  "*.wcf")
        Dim inttempFileLines As Integer = 0
        Dim strtempCityName As String = ""
        Dim strCountryName As String = ""
        Dim strTemp As String = ""
        Dim intPhilippinesCountArray As Integer = 0
        Dim intRussiaCountArray As Integer = 0
        Dim intUKCountArray As Integer = 0
        Dim intUSACountArray As Integer = 0
        Dim intArgentinaCountArray As Integer = 0

        For Each sFile As String In fileCities
            FileOpen(1, sFile, OpenMode.Input)
            Input(1, inttempFileLines)
            Input(1, strtempCityName)
            Input(1, strTemp)
            strCountryName = strTemp
            FileClose(1)
            Select Case strCountryName

                Case "Philippines"
                    FileOpen(1, sFile, OpenMode.Input)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 0) =
                        CStr(inttempFileLines)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 1) =
                        strtempCityName
                    strCitiesFromPhilippines(intPhilippinesCountArray, 2) =
                        strCountryName
                    Input(1, strTemp)
                    Input(1, strCitiesFromPhilippines(intPhilippinesCountArray,
                                                      3))
                    Input(1, strCitiesFromPhilippines(intPhilippinesCountArray,
                                                      4))
                    Dim i As Integer = 0
                    Dim p As Integer = 5
                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        Input(1, strTemp)
                        strCitiesFromPhilippines(intPhilippinesCountArray, p) =
                            strTemp
                        p += 1
                    Next i
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromPhilippines(intPhilippinesCountArray, 5) = strTemp
                    intPhilippinesCountArray += 1
                    FileClose(1)

                Case "Russia"
                    FileOpen(1, sFile, OpenMode.Input)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromRussia(intRussiaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromRussia(intRussiaCountArray, 1) = strtempCityName
                    strCitiesFromRussia(intRussiaCountArray, 2) = strCountryName
                    Input(1, strTemp)
                    Input(1, strCitiesFromRussia(intRussiaCountArray, 3))
                    Input(1, strCitiesFromRussia(intRussiaCountArray, 4))
                    Dim i As Integer = 0
                    Dim p As Integer = 5
                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        Input(1, strTemp)
                        strCitiesFromRussia(intRussiaCountArray, p) = strTemp
                        p += 1
                    Next i
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromRussia(intRussiaCountArray, 5) = strTemp
                    intRussiaCountArray += 1
                    FileClose(1)

                Case "United Kingdom"
                    FileOpen(1, sFile, OpenMode.Input)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromUK(intUKCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromUK(intUKCountArray, 1) = strtempCityName
                    strCitiesFromUK(intUKCountArray, 2) = strCountryName
                    Input(1, strTemp)
                    Input(1, strCitiesFromUK(intUKCountArray, 3))
                    Input(1, strCitiesFromUK(intUKCountArray, 4))
                    Dim i As Integer = 0
                    Dim p As Integer = 5
                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        Input(1, strTemp)
                        strCitiesFromUK(intUKCountArray, p) =
                            strTemp
                        p += 1
                    Next i
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromUK(intUKCountArray, 5) = strTemp
                    intUKCountArray += 1
                    FileClose(1)

                Case "United States"
                    FileOpen(1, sFile, OpenMode.Input)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromUSA(intUSACountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromUSA(intUSACountArray, 1) = strtempCityName
                    strCitiesFromUSA(intUSACountArray, 2) = strCountryName
                    Input(1, strTemp)
                    Input(1, strCitiesFromUSA(intUSACountArray, 3))
                    Input(1, strCitiesFromUSA(intUSACountArray, 4))
                    Dim i As Integer = 0
                    Dim p As Integer = 5
                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        Input(1, strTemp)
                        strCitiesFromUK(intUSACountArray, p) =
                            strTemp
                        p += 1
                    Next i
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromUSA(intUSACountArray, 5) = strTemp
                    intUSACountArray += 1
                    FileClose(1)

                Case "Argentina"
                    FileOpen(1, sFile, OpenMode.Input)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromArgentina(intArgentinaCountArray, 0) = CStr(inttempFileLines)
                    strCitiesFromArgentina(intArgentinaCountArray, 1) = strtempCityName
                    strCitiesFromArgentina(intArgentinaCountArray, 2) = strCountryName
                    Input(1, strTemp)
                    Input(1, strCitiesFromUSA(intArgentinaCountArray, 3))
                    Input(1, strCitiesFromUSA(intArgentinaCountArray, 4))
                    Dim i As Integer = 0
                    Dim p As Integer = 5
                    Dim intDescriptionSize = inttempFileLines - 1
                    For i = 8 To intDescriptionSize
                        Input(1, strTemp)
                        strCitiesFromArgentina(intArgentinaCountArray, p) =
                            strTemp
                        p += 1
                    Next i
                    Input(1, strTemp)
                    Input(1, strTemp)
                    strCitiesFromArgentina(intArgentinaCountArray, 5) = strTemp
                    intArgentinaCountArray += 1
                    FileClose(1)
            End Select

        Next

    End Sub
End Class
