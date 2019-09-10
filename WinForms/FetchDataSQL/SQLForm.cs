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

namespace FetchDataSQL
{
    public partial class SQLForm : Form
    {
        /// <summary>
        /// Instantiate this once during the lifetime of your application to talk to the REST API
        /// </summary>
        public static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// The location of the OODAPI
        /// </summary>
        public static string APIURL { get; set; } = String.Empty;

        /// <summary>
        /// The APIKey to make the SQL call with
        /// </summary>
        public static string APIKEY { get; set; } = String.Empty;

        /// <summary>
        /// Loads the SQLForm
        /// </summary>
        public SQLForm()
        {
            this.InitializeComponent();
            this.Setup();
        }

        /// <summary>
        /// Handles clicking the "Find" button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FindButton_Click(object sender, EventArgs e)
        {
            this.FindButton.Text = "Loading...";
            this.ResultsDataGridView.DataSource = null;

            if (String.IsNullOrEmpty(this.APIKeyTextbox.Text))
            {
                // Login to get the key
                string apiKey = Classes.Login.LoginAPI.LoginSync(this.UsernameTextbox.Text, this.PasswordTextbox.Text, this.CompanyIDTextbox.Text);
                if (String.IsNullOrEmpty(apiKey))
                {
                    this.ResetFind();
                    return;
                }

                this.APIKeyTextbox.Text = apiKey;
                APIKEY = apiKey;
            }

            int iPage = 1;
            int iBatch = 0;

            if (Int32.TryParse(this.PageNUD.Value.ToString(), out int iPageTmp))
            {
                iPage = iPageTmp;
            }

            if (Int32.TryParse(this.BatchSizeNUD.Value.ToString(), out int iBatchTmp))
            {
                iBatch = iBatchTmp;
            }

            // Perform the find
            var sqlResponse = Classes.FetchDataSQL.SQLAPI.FetchDataSQLSync(this.CompanyIDTextbox.Text, this.SQLQueryTextbox.Text, iPage, iBatch);
            if (sqlResponse.Success && sqlResponse.DataSetOut != null && sqlResponse.DataSetOut.Tables.Count > 0)
            {
                this.ResultsDataGridView.DataSource = sqlResponse.DataSetOut.Tables[0];
                this.ResetFind();
            }
            else if (sqlResponse.Success) 
            {
                MessageBox.Show("No records found.");
                this.ResetFind();
            }

            this.ResetFind();
        }

        #region WinForms UI/UX Methods

        /// <summary>
        /// Sets up WinForms events and helpers
        /// </summary>
        private void Setup()
        {
            this.URLTextbox.GotFocus += OnFocusTextboxURL;
            this.APIKeyTextbox.GotFocus += OnFocusTextboxAPI;
            this.CompanyIDTextbox.GotFocus += OnFocusTextboxCompany;
            this.UsernameTextbox.GotFocus += OnFocusTextboxUser;
            this.PasswordTextbox.GotFocus += OnFocusTextboxPass;

            this.URLTextbox.TextChanged += OnTextChanged;
            this.OnTextChanged(this, EventArgs.Empty); // trigger the change to populate the APIURL

            this.APIKeyTextbox.TextChanged += OnTextChangedAPIKey;
            this.OnTextChangedAPIKey(this, EventArgs.Empty); // trigger the change to populate the APIURL
        }

        /// <summary>
        /// Highlight text when we focus the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFocusTextboxURL(object sender, EventArgs e)
        {
            // Fire async so mouse up propagates
            BeginInvoke((Action)delegate
            {
                this.URLTextbox.SelectAll();
            });
        }


        /// <summary>
        /// Highlight text when we focus the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFocusTextboxAPI(object sender, EventArgs e)
        {
            // Fire async so mouse up propagates
            BeginInvoke((Action)delegate
            {
                this.APIKeyTextbox.SelectAll();
            });
        }

        /// <summary>
        /// Highlight text when we focus the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFocusTextboxCompany(object sender, EventArgs e)
        {
            // Fire async so mouse up propagates
            BeginInvoke((Action)delegate
            {
                this.CompanyIDTextbox.SelectAll();
            });
        }

        /// <summary>
        /// Highlight text when we focus the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFocusTextboxUser(object sender, EventArgs e)
        {
            // Fire async so mouse up propagates
            BeginInvoke((Action)delegate
            {
                this.UsernameTextbox.SelectAll();
            });
        }

        /// <summary>
        /// Highlight text when we focus the textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnFocusTextboxPass(object sender, EventArgs e)
        {
            // Fire async so mouse up propagates
            BeginInvoke((Action)delegate
            {
                this.PasswordTextbox.SelectAll();
            });
        }

        /// <summary>
        /// Handles when the user changes the URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChanged(object sender, EventArgs e)
        {
            APIURL = this.URLTextbox.Text;
        }

        /// <summary>
        /// Handles when the user changes the APIKey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnTextChangedAPIKey(object sender, EventArgs e)
        {
            APIKEY = this.APIKeyTextbox.Text;
        }

        /// <summary>
        /// Resets the find button text
        /// </summary>
        private void ResetFind()
        {
            this.FindButton.Text = "Find       ";
        }

        #endregion
    }
}
