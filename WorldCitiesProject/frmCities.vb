Public Class frmCities


    ''CountryArray(i,p) i = hold the country placement
    ''p = the data
    ''Country(i,0) holds line count
    ''country(i,1)  holds city name
    ''country(i,2) hold country where city is from
    ''country(i,3) holds population
    ''country(i,4) holds countryAnnualRainfall
    ''Country(i,5) holds Image Name
    ''Country(i,6+) hold description
    Dim strCitiesFromRussia(,) As String
    Dim strCitiesFromPhilippines(4, 80) As String
    Dim strCitiesFromUK(,) As String

    Private Sub frmCities_Load(sender As Object,
                               e As EventArgs) Handles MyBase.Load
        Dim fileCities As String() = System.IO.Directory.GetFiles("../Data",
                                                                  "*.wcf")
        Dim inttempFileLines As Integer
        Dim strtempCityName As String = ""
        Dim strCountryName As String = ""
        Dim strTemp As String = ""
        Dim intPhilippinesCountArray As Integer = 0
        Dim intRussiaCountArray As Integer = 0
        Dim intUKCountArray As Integer = 0



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
                    strCitiesFromPhilippines(intPhilippinesCountArray, 5) =
                        strTemp
                    intPhilippinesCountArray += 1
                    FileClose(1)
            End Select

        Next

    End Sub
End Class
