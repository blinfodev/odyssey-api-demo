using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FetchDataSQL.Classes.Login
{
    /// <summary>
    /// Handles communication with the OODAPI during login procedures
    /// </summary>
    public static class LoginAPI
    {
        /// <summary>
        /// Attempts to get a temporary APIKey from the application given a username, password, and company and returns it
        /// </summary>
        /// <returns></returns>
        public static string LoginSync(string username, string password, string companyID)
        {
            try
            {
                Task<string> task = Task.Run<string>(async () => await LoginAsync(username, password, companyID));
                task.Wait();
                return task.Result;
            }
            catch (Exception e)
            {
                string httpError = "Error: " + e.Message + Environment.NewLine + "Please check your OODAPI URL";
                MessageBox.Show(httpError, "Error", MessageBoxButtons.OK);
                return "";
            }
        }

        /// <summary>
        /// Async. Attempts to get a temporary APIKey from the application given a username, password, and company and returns it
        /// </summary>
        /// <param name="requestBody"></param>
        /// <returns></returns>
        public static async Task<string> LoginAsync(string username, string password, string companyID)
        {
            using (var requestMessage = new HttpRequestMessage(HttpMethod.Post, SQLForm.APIURL + "/Login"))
            {
                requestMessage.Headers.TryAddWithoutValidation("Content-Type", "application/json");

                var loginData = new LoginRequest
                {
                    Username = username,
                    Password = password,
                    CompanyID = companyID
                };

                requestMessage.Content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");

                var responseMessage = await SQLForm.Client.SendAsync(requestMessage);
                if (responseMessage.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    // This is the raw content that was received. Usually, this is JSON, and you can parse it here
                    string responseString = await responseMessage.Content.ReadAsStringAsync();
                    LoginResponse loginResponse = JsonConvert.DeserializeObject<LoginResponse>(responseString);

                    if (!loginResponse.Success)
                    {
                        string httpError = "Error: " + loginResponse.ErrorMessage;
                        MessageBox.Show(httpError, "Error", MessageBoxButtons.OK);
                        return String.Empty;
                    }

                    return loginResponse.APIKey;
                }
                else
                {
                    // Show the error that the HTTP Request received
                    string httpError = "Error: " + responseMessage.ReasonPhrase;
                    MessageBox.Show(httpError, "Error", MessageBoxButtons.OK);
                    return String.Empty;
                }
            }
        }
    }
}
