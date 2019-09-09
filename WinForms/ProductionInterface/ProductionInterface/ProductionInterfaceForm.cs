using Newtonsoft.Json;
using ProductionInterface.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductionInterface
{
    public partial class ProductionInterfaceForm : Form
    {
        /// <summary>
        /// The URL to your OODAPI
        /// This is typically the location to your Odyssey page, with "/OODAPI"
        /// </summary>
        public static string APIUrl { get; set; } = "http://server-rd/odyssey/oodapi";

        /// <summary>
        /// The ID of the user you're logging in as, if you need to login to obtain an APIKey.
        /// </summary>
        public static string UserID { get; set; } = "";

        /// <summary>
        /// The password of the user you're logging in as, if you need to login to obtain an APIKey.
        /// </summary>
        public static string Password { get; set; } = "";

        /// <summary>
        /// The ID of the company you're using
        /// </summary>
        public static string CompanyID { get; set; } = "ODSY";

        /// <summary>
        /// Instantiate this once during the lifetime of your application to talk to the REST API
        /// </summary>
        public static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// The APIKey that we will use for requests to the OODAPI
        /// If you don't have one, you may also uses the /Login procedure to generate one dynamically
        /// </summary>
        public static string APIKey { get; set; } = String.Empty;

        public ProductionInterfaceForm()
        {
            InitializeComponent();
            this.Load += this.OnLoad;            
        }

        private void OnLoad(object sender, EventArgs e)
        {
            this.RunProductionImport();
            this.Close();
        }

        public void RunProductionImport()
        {
            // Step 1 - Login as a valid user and get a temporary API Key
            ProductionInterfaceForm.APIKey = LoginSync(ProductionInterfaceForm.UserID, ProductionInterfaceForm.Password, ProductionInterfaceForm.CompanyID);

            if (String.IsNullOrEmpty(ProductionInterfaceForm.APIKey))
            {
                // Don't continue if we have a bad API Key
                return;
            }

            // Step 2 - Construct our production data
            string productionInterfaceName = "PINTF";
            string productionImportName = "33-STD";

            ProductionInterfaceRequest productionData = new ProductionInterfaceRequest
            {
                CompanyID = ProductionInterfaceForm.CompanyID,
                InterfaceID = productionInterfaceName,
                ImportID = productionImportName
            };

            // Add production data here
            productionData.DataList.Add(new
            {
                ShopOrder = "562973-1",
                Operation = "MOLD",
                Product = "R4512",
                ShiftDate = "07/26/2019",
                Quantity = "7",
                Hours = "2",
                Tool = "R4512",
                ShiftName = "1"
            });

            // .. Add as much production data as you need
            productionData.DataList.Add(new
            {
                ShopOrder = "562973-1",
                Operation = "MOLD",
                Product = "R4512",
                ShiftDate = "07/26/2019",
                Quantity = "8",
                Hours = "3",
                Tool = "R4512",
                ShiftName = "1"
            });

            // Step 3 - Send our production data to the OODAPI
            ProductionInterfaceResponse prodResponse = ProdSync(productionData);

            MessageBox.Show($"Production Interface complete. {Environment.NewLine} Added {prodResponse.Successful} records.");
        }

        /// <summary>
        /// Attempts to get a temporary APIKey from the application given a username, password, and company and returns it
        /// </summary>
        /// <returns></returns>
        public string LoginSync(string username, string password, string companyID)
        {
            Task<string> task = Task.Run<string>(async () => await LoginAsync(username, password, companyID));
            task.Wait();
            return task.Result;
        }

        /// <summary>
        /// Async. Attempts to get a temporary APIKey from the application given a username, password, and company and returns it
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        public async Task<string> LoginAsync(string username, string password, string companyID)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, APIUrl + "/Login"))
            {
                requestMessage.Headers.TryAddWithoutValidation("X-API-Key", ProductionInterfaceForm.APIKey);
                requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                var loginData = new
                {
                    Username = username,
                    Password = password,
                    CompanyID = companyID
                };

                requestMessage.Content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

                var responseMessage = await Client.SendAsync(requestMessage);
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // This is the raw content that was received. Usually, this is JSON, and you can parse it here
                    string responseString = await responseMessage.Content.ReadAsStringAsync();
                    LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseString);

                    if (!loginResponse.Success)
                    {
                        MessageBox.Show("Error: " + loginResponse.ErrorMessage);
                        return String.Empty;
                    }

                    return loginResponse.APIKey;
                }
                else
                {
                    // Show the error that the HTTP Request received
                    MessageBox.Show("Error: " + responseMessage.ReasonPhrase);
                    return String.Empty;
                }
            }
        }

        /// <summary>
        /// Runs the production interface request.
        /// </summary>
        /// <returns></returns>
        public ProductionInterfaceResponse ProdSync(ProductionInterfaceRequest requestBody)
        {
            Task<ProductionInterfaceResponse> task = Task.Run(async () => await ProdAsync(requestBody));
            task.Wait();
            return task.Result;
        }

        /// <summary>
        /// Async. Runs the production interface request.
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        public async Task<ProductionInterfaceResponse> ProdAsync(ProductionInterfaceRequest requestBody)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, APIUrl + "/ProductionInterface"))
            {
                requestMessage.Headers.TryAddWithoutValidation("X-API-Key", ProductionInterfaceForm.APIKey);
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
