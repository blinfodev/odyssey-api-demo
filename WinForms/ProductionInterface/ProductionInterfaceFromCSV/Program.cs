using Newtonsoft.Json;
using ProductionInterfaceFromCSV.Classes;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ProductionInterfaceFromCSV
{
    class Program
    {
        /// <summary>
        /// Instantiate this once during the lifetime of your application to talk to the REST API
        /// </summary>
        public static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// This is the location to your OODAPI. In the B&L Cloud, this should be in the format https://api.blinfo.com/company
        /// If you're on-premise, the OODAPI is located where you would type Odyssey.aspx. For example, if you access Odyssey at https://myserver/odyssey.aspx, your OODAPI would be located at https://myserver/OODAPI
        /// *** Put your API URL here
        /// </summary>
        public static string APIURL = "https://api.blinfo.com/company";

        /// <summary>
        /// The is the fully URL to the ProductionInterface endpoint in the OODAPI
        /// </summary>
        public static string ProductionURL = APIURL + "/ProductionInterface";

        /// <summary>
        /// The ID of the company you're using or testing on
        /// *** Put your CompanyID here
        /// </summary>
        public static string CompanyID = "TEST";

        /// <summary>
        /// The API Key for this application/user. You can generate a key in the "Manage API Keys" screen in the Users master
        /// *** Put your API Key here
        /// </summary>
        public static string APIKey = "XXXX-XXXX-XXXX";

        static void Main(string[] args)
        {
            /*****************
                Step 1 - Construct our production interface structure
            *****************/

            // This is the name of the Production Interface you have created
            // *** Put your ProductionInterface name here
            string productionInterfaceName = "PINTF";

            // This is the name of the Proudction Import you've created in your Production Interface
            // *** Put your ProductionInterface Import name here
            string productionImportName = "33-STD";

            // This is the object you'll pass to the API that contains the production data
            ProductionInterfaceRequest productionData = new ProductionInterfaceRequest
            {
                CompanyID = CompanyID,
                InterfaceID = productionInterfaceName,
                ImportID = productionImportName
            };

            /*****************
                Step 2 - Read production data from a CSV
            *****************/

            // The path to and the filename of the CSV file
            // As coded right now, this will find a file named ProductionData.csv in the current Visual Studio solution directory
            string solutionRoot = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            string csvLocation = Path.Combine(solutionRoot, "ProductionData.csv");

            if (!File.Exists(csvLocation))
            {
                Console.WriteLine("Error: Could not locate the production CSV file.");
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
                return;
            }

            // All the lines in the file
            string[] records = File.ReadAllLines(csvLocation);

            if (records.Length == 0)
            {
                Console.WriteLine("Error: The production CSV file contained no records to import.");
                Console.WriteLine("Press enter to exit");
                Console.ReadLine();
                return;
            }

            // ** Important! We're starting at the _second row_ because our first row has header information
            // If your CSV file does not contain header information, you would start at 0, instead of 1
            int startingIndex = 1;

            for (int index = startingIndex; index < records.Length; index++)
            {
                // Get all the fields in the CSV by splitting on comma
                string[] productionFields = records[index].Split(',');

                // Add production data here for each line in the CSV
                // Please note that this is hard-coded in your application, and dependends on what fields are in your CSV
                // You can define any field you wish in this list, and I've added an example of sending a field named "UserDefined" with a value of "Anything"
                // You can send in UDF's this way, either hard-coded, or from your CSV
                // *** Put your ProductionInterface data structure
                productionData.DataList.Add(new
                {
                    ShopOrder = productionFields[0],
                    Operation = productionFields[1],
                    Product = productionFields[2],
                    ShiftDate = productionFields[3],
                    Quantity = productionFields[4],
                    Hours = productionFields[5],
                    Tool = productionFields[6],
                    ShiftName = productionFields[7],
                    UserDefined = "Anything"
                });
            }

            /*****************
                Step 3 - Call the API ProductionInterface method
            *****************/

            // Run the API Request
            // Note that since the request is asynchronous, we're running this inside a task and awaiting its response
            Task<ProductionInterfaceResponse> task = Task.Run<ProductionInterfaceResponse>(async () => await ProdAsync(productionData));
            task.Wait();

            // This is the response from the API itself
            ProductionInterfaceResponse prodResponse = task.Result;

            /*****************
                Step 4 - Process the API response data
            *****************/

            // The request failed
            if (!prodResponse.Success)
            {
                Console.WriteLine("Error: The API returned an error message: " + prodResponse.ErrorMessage);
            }

            Console.WriteLine("The production interface call attempted to process " + prodResponse.Attempted + " records and was successful for " + prodResponse.Successful + " records.");
            Console.WriteLine("If any errors were reported for specific production transactions, they will be listed below.");
            foreach (var logMessage in prodResponse.Logging)
            {
                Console.WriteLine("Production record import error:");
                Console.WriteLine("Error Type: " + logMessage.ErrorType);
                Console.WriteLine("Line Number: " + logMessage.LineNumber);
                Console.WriteLine("Message: " + logMessage.TextString);
                Console.WriteLine("");
            }

            Console.WriteLine("Press enter to exit");
            Console.ReadLine();
            return;
        }

        /// <summary>
        /// Async. Runs the production interface request.
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        public static async Task<ProductionInterfaceResponse> ProdAsync(ProductionInterfaceRequest requestBody)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, APIURL + "/ProductionInterface"))
            {
                requestMessage.Headers.TryAddWithoutValidation("X-API-Key", APIKey);
                requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                requestMessage.Content = new StringContent(JsonConvert.SerializeObject(requestBody), Encoding.UTF8, "application/json");

                var responseMessage = await Client.SendAsync(requestMessage);
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // This is the raw content that was received. Usually, this is JSON, and you can parse it here
                    string responseString = await responseMessage.Content.ReadAsStringAsync();
                    var prodResponse = JsonConvert.DeserializeObject<ProductionInterfaceResponse>(responseString);

                    return prodResponse;
                }
                else
                {
                    // Show the error that the HTTP Request received
                    return new ProductionInterfaceResponse
                    {
                        Success = false,
                        ErrorMessage = responseMessage.ReasonPhrase
                    };
                }
            }
        }
    }
}
