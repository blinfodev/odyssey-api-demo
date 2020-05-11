using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// Makes requests to /FetchData/DatView
    /// </summary>
    public class FetchDataViewAPI
    {
        /// <summary>
        /// FetchDataSQL Sync
        /// </summary>
        /// <returns></returns>
        public static FetchDataViewResponse FetchDataViewSync(string companyID, string dataView, List<DataViewParameter> parameters)
        {
            try
            {
                var task = Task.Run<FetchDataViewResponse>(async () => await FetchDataViewAsync(companyID, dataView, parameters));
                task.Wait();
                return task.Result;
            }
            catch (Exception e)
            {
                string errorMessage = "Error: " + e.Message + Environment.NewLine + "Please check your OODAPI URL";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK);
                return new FetchDataViewResponse
                {
                    Success = false,
                    ErrorMessage = errorMessage
                };
            }
        }

        /// <summary>
        /// FetchDataSQL Async
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        public static async Task<FetchDataViewResponse> FetchDataViewAsync(string companyID, string dataView, List<DataViewParameter> parameters)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, JsonCreatorForm.APIURL + "/FetchData/DataView"))
            {
                requestMessage.Headers.TryAddWithoutValidation("X-API-Key", JsonCreatorForm.APIKEY);
                requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                var sqlData = new FetchDataViewRequest
                {
                    CompanyID = companyID,
                    DataView = dataView,
                    ParameterList = parameters
                };

                requestMessage.Content = new StringContent(JsonConvert.SerializeObject(sqlData), Encoding.UTF8, "application/json");

                var responseMessage = await JsonCreatorForm.Client.SendAsync(requestMessage);
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // This is the raw content that was received. Usually, this is JSON, and you can parse it here
                    string responseString = await responseMessage.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<FetchDataViewResponse>(responseString);

                    if (!response.Success)
                    {
                        string httpError = "Error: " + response.ErrorMessage;
                        MessageBox.Show(httpError, "Error", MessageBoxButtons.OK);
                        return response;
                    }

                    return response;
                }
                else
                {
                    // Show the error that the HTTP Request received
                    string httpError = "Error: " + responseMessage.ReasonPhrase;
                    MessageBox.Show(httpError, "Error", MessageBoxButtons.OK);
                    return new FetchDataViewResponse
                    {
                        Success = false,
                        ErrorMessage = responseMessage.ReasonPhrase
                    };
                }
            }
        }
    }
}
