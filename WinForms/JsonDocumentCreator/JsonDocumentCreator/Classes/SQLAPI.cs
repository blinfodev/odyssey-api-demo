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
    /// Handles communication with the OODAPI during FetchDataSQL procedures
    /// </summary>
    public static class SQLAPI
    {
        /// <summary>
        /// FetchDataSQL Sync
        /// </summary>
        /// <returns></returns>
        public static FetchDataSQLResponse FetchDataSQLSync(string companyID, string sqlQuery, int page, int batchSize)
        {
            try
            {
                var task = Task.Run<FetchDataSQLResponse>(async () => await FetchDataSQLAsync(companyID, sqlQuery, page, batchSize));
                task.Wait();
                return task.Result;
            }
            catch (Exception e)
            {
                string errorMessage = "Error: " + e.Message + Environment.NewLine + "Please check your OODAPI URL";
                MessageBox.Show(errorMessage, "Error", MessageBoxButtons.OK);
                return new FetchDataSQLResponse
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
        public static async Task<FetchDataSQLResponse> FetchDataSQLAsync(string companyID, string sqlQuery, int page, int batchSize)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, JsonCreatorForm.APIURL + "/FetchData/SQL"))
            {
                requestMessage.Headers.TryAddWithoutValidation("X-API-Key", JsonCreatorForm.APIKEY);
                requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                var sqlData = new FetchDataSQLRequest
                {
                    CompanyID = companyID,
                    SQLQuery = sqlQuery,
                    Page = page,
                    BatchSize = batchSize
                };

                requestMessage.Content = new StringContent(JsonConvert.SerializeObject(sqlData), Encoding.UTF8, "application/json");

                var responseMessage = await JsonCreatorForm.Client.SendAsync(requestMessage);
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // This is the raw content that was received. Usually, this is JSON, and you can parse it here
                    string responseString = await responseMessage.Content.ReadAsStringAsync();
                    var response = JsonConvert.DeserializeObject<FetchDataSQLResponse>(responseString);

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
                    return new FetchDataSQLResponse
                    {
                        Success = false,
                        ErrorMessage = responseMessage.ReasonPhrase
                    };
                }
            }
        }
    }
}
