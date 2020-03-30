Imports Newtonsoft.Json

Module Module1

    Sub Main()
        ' *** REQUIRED FIELD
        ' Place the base path to your Odyssey API here, without a trailing slash
        Dim BaseAPILocation = "https://api.blinfo.com/company"

        ' *** REQUIRED FIELD
        ' Place your Odyssey API Key here
        Dim APIKey = ""

        ' *** REQUIRED FIELD
        ' The CompanyID used to authenticate your request to the API
        Dim APIKeyCompanyID = ""

        ' *** REQUIRED FIELD
        ' The SQL Query to perform on the API
        ' This test call gets a Product, joins its Customer to it, then joins the first Shipto it finds for that Customer
        Dim SQLQuery = "SELECT TOP 1 Products.Product, Customer.Coname, topShipTo.ShipToName FROM Products LEFT OUTER JOIN Customer on Customer.Customer = Products.Customer LEFT OUTER JOIN (SELECT DISTINCT Customer, Coname as ShipToName  FROM ShipTo) topShipTo on topShipTo.Customer = Customer.Customer"

        Dim sqlRequester = New FetchDataSQL()
        Dim requestBody = New FetchDataSQLRequest With {
            .SQLQuery = SQLQuery,
            .APIKey = APIKey,
            .CompanyID = APIKeyCompanyID,
            .BatchSize = 0,
            .Page = 1
        }

        Dim responseBody = sqlRequester.RunQuery(BaseAPILocation, requestBody)

        If responseBody Is Nothing Then
            ' If we received Null from the RunQuery method, it failed completely
            ' It is responsible for displaying an error in that case, so return here and no not continue
            Return
        End If

        If Not responseBody.Success Then
            MsgBox("Error calling the API. Error Message: " + Environment.NewLine + Environment.NewLine + responseBody.ErrorMessage)
            Return
        End If


        If responseBody.DataSetOut Is Nothing Then
            MsgBox("The API call was successful but no data set was returned.")
            Return
        End If

        If responseBody.DataSetOut.Tables.Count = 0 Then
            MsgBox("No tables were returned.")
            Return
        End If


        If responseBody.DataSetOut.Tables(0).Rows.Count = 0 Then
            MsgBox("No rows were returned.")
            Return
        End If

        ' We know we have one or more records
        Dim responseRow = responseBody.DataSetOut.Tables(0).Rows(0)

        ' Here you can reference any field that is returned from your SQL query
        Dim productName = responseRow("Product")
        Dim customerName = responseRow("Coname")
        Dim shipToName = responseRow("ShipToName")
        MsgBox("Product: " + productName + Environment.NewLine + Environment.NewLine + " Customer Name: " + customerName + Environment.NewLine + Environment.NewLine + " Ship to name: " + shipToName)
    End Sub

    ' This class is designed to make the HTTP requests to the API
    ' This class was created so that your main function, and other functions, do not have to format the request to the API 
    ' or deal with the HTTP request and response parsing
    Public Class FetchDataSQL
        Public Function RunQuery(ByVal apiLocation As String, ByVal requestBody As FetchDataSQLRequest) As FetchDataSQLResponse
            ' Create a reference to the "HTTP" object, which makes the request to the API
            ' Set the content type to tell the API to return JSON data, and pass your APIKey in the HTTP headers
            Dim http As Object
            http = CreateObject("WinHttp.WinHttprequest.5.1")

            Dim RequestType = "POST"
            http.Open(RequestType, apiLocation + "/FetchData/SQL", False)
            http.setRequestHeader("Content-Type", "application/json")

            If requestBody.APIKey IsNot Nothing And requestBody.APIKey.Length > 0 Then
                http.setRequestHeader("X-API-Key", requestBody.APIKey)
            End If

            http.send(JsonConvert.SerializeObject(requestBody))
            Dim statusCode = http.Status

            If statusCode = "404" Then
                MsgBox("Could not locate your Odyssey API. Please confirm the URL you have entered.")
                Return Nothing
            End If

            If statusCode <> "200" Then
                MsgBox("The HTTP request failed. Status Code: " + statusCode)
                Return Nothing
            End If

            If http.responseText Is Nothing Or http.responseText.Length = 0 Then
                MsgBox("There was not a valid response from the HTTP request. The responseText property was empty or missing.")
                Return Nothing
            End If

            Dim responseBody = JsonConvert.DeserializeObject(Of FetchDataSQLResponse)(http.responseText)

            If responseBody Is Nothing Then
                MsgBox("The response from the API could not be converted into a FetchDataSQLResponse.")
                Return Nothing
            End If

            Return responseBody
        End Function
    End Class

    ' This class encapsulates all data sent to the Odyssey API when performing an SQL request
    Public Class FetchDataSQLRequest
        ' The APIKey used to authenticate your request to the API
        Public APIKey As String

        ' This Is a fully formed And fully qualified SQL query that conforms to SQL-92 syntax. 
        ' The tables specified And the field specified in the SQL statement must exist as defined in the database in order for the query to work.
        Public SQLQuery As String

        ' If you only want to return a subset of records, you can identify which page of records to return. 
        ' If this Is 0, then all records from the database table specified in the SQL query are returned.
        Public Page As Integer

        ' This specifies the number Or records to return for each page. If you wish to return all records, this should be set to zero.
        Public BatchSize As Integer

        ' This is the Company that you are validating your API request with
        ' You can fetch records from any company, based your query, but this is used to ensure a valid APIKey/CompanyID combination
        ' This can be ignored if using an APIKey which was generated for a specific company
        ' This is requied if using an APIKey which was generated for 'any company'
        Public CompanyID As String
    End Class

    ' This class encapsulates all data returned from the Odyssey API when performing an SQL request
    Public Class FetchDataSQLResponse
        ' The dataset of records returned by the query
        Public DataSetOut As DataSet

        ' Whether or not the API request was successful
        Public Success As Boolean

        ' The error returned by the API, if any exists
        Public ErrorMessage As String
    End Class

End Module
