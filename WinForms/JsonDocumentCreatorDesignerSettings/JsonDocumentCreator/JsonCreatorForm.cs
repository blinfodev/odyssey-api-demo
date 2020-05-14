using JsonDocumentCreator.Classes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JsonDocumentCreator
{
    public partial class JsonCreatorForm : Form
    {
        /// <summary>
        /// Instantiate this once during the lifetime of your application to talk to the REST API
        /// </summary>
        public static readonly HttpClient Client = new HttpClient();

        /// <summary>
        /// The URL to the API
        /// </summary>
        public static string APIURL { get; set; } = String.Empty;

        /// <summary>
        /// The API Key to use for this API
        /// </summary>
        public static string APIKEY { get; set; } = String.Empty;

        public JsonCreatorForm()
        {
            InitializeComponent();
            this.URLTextBox.TextChanged += URLTextBox_TextChanged;
            this.APIKeyTextbox.TextChanged += APIKeyTextbox_TextChanged;
        }

        /// <summary>
        /// Validates the form
        /// </summary>
        /// <returns></returns>
        private bool ValidateForm()
        {
            if (String.IsNullOrEmpty(APIKEY))
            {
                MessageBox.Show("You must enter an APIKey");
                return false;
            }

            if (this.URLTextBox.Text == "https://api.blinfo.com/company" || String.IsNullOrEmpty(APIURL))
            {
                MessageBox.Show("You must enter a valid API URL");
                return false;
            }

            if (String.IsNullOrEmpty(this.CompanyIDTextbox.Text))
            {
                MessageBox.Show("You must enter a Company ID");
                return false;
            }

            return true;
        }

        /// <summary>
        /// Generates the JSON doc for this DataView query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateDataViewDocument_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            if (String.IsNullOrEmpty(this.DataViewNameTextbox.Text))
            {
                MessageBox.Show("You must enter the name of the Data View to query on");
                return;
            }

            var parameters = new List<DataViewParameter>();
            if (!String.IsNullOrEmpty(this.Param1FieldName.Text))
            {
                parameters.Add(new DataViewParameter()
                {
                    FieldName = this.Param1FieldName.Text,
                    Operator = this.Param1Operator.Text,
                    ParameterValue = this.Param1Value.Text
                });
            }

            if (!String.IsNullOrEmpty(this.Param2FieldName.Text))
            {
                parameters.Add(new DataViewParameter()
                {
                    FieldName = this.Param2FieldName.Text,
                    Operator = this.Param2Operator.Text,
                    ParameterValue = this.Param2Value.Text
                });
            }

            if (!String.IsNullOrEmpty(this.Param3FieldName.Text))
            {
                parameters.Add(new DataViewParameter()
                {
                    FieldName = this.Param3FieldName.Text,
                    Operator = this.Param3Operator.Text,
                    ParameterValue = this.Param3Value.Text
                });
            }

            var dvResponse = Classes.FetchDataViewAPI.FetchDataViewSync(this.CompanyIDTextbox.Text, this.DataViewNameTextbox.Text, parameters);

            bool successful = dvResponse?.Success ?? false;
            if (successful && dvResponse.DataSetOut?.Tables.Count > 0)
            {
                if (dvResponse.DataSetOut.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the DataView query. No JSON document could be created.");
                }
                else
                {
                    this.SaveJsonFromRow(dvResponse.DataSetOut.Tables[0].TableName, dvResponse.DataSetOut.Tables[0].Rows[0]);
                }
            }
            else
            {
                string errorMessage = $"The ABL query could not be performed. {dvResponse?.ErrorMessage ?? "An unknown error has occurred."}";
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Generates the JSON doc for this ABL query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GenerateABLButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            if (String.IsNullOrEmpty(this.ABLQueryTextbox.Text))
            {
                MessageBox.Show("You must enter an ABL Query");
                return;
            }

            if (String.IsNullOrEmpty(this.ABLTableNameTextbox.Text))
            {
                MessageBox.Show("You must enter an ABL Table Name");
                return;
            }


            var ablResponse = Classes.ABLAPI.FetchDataABLSync(this.CompanyIDTextbox.Text, this.ABLQueryTextbox.Text, this.ABLFieldListTextbox.Text, this.ABLSortTextbox.Text, this.ABLTableNameTextbox.Text);

            bool successful = ablResponse?.Success ?? false;
            if (successful && ablResponse.DataSetOut?.Tables.Count > 0)
            {
                if (ablResponse.DataSetOut.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the ABL query. No JSON document could be created.");
                }
                else
                {
                    this.SaveJsonFromRow(this.ABLTableNameTextbox.Text, ablResponse.DataSetOut.Tables[0].Rows[0]);
                }
            }
            else
            {
                string errorMessage = $"The ABL query could not be performed. {ablResponse?.ErrorMessage ?? "An unknown error has occurred."}";
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Generates the JSON doc for this SQL query
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SQlGenerateButton_Click(object sender, EventArgs e)
        {
            if (!ValidateForm())
            {
                return;
            }

            if (String.IsNullOrEmpty(this.SQLQueryTextbox.Text))
            {
                MessageBox.Show("You must enter an SQL Query");
                return;
            }

            if (String.IsNullOrEmpty(this.SQLTableName.Text))
            {
                MessageBox.Show("You must enter the name of the table to create the JSON document for");
                return;
            }

            var sqlResponse = Classes.SQLAPI.FetchDataSQLSync(this.CompanyIDTextbox.Text, this.SQLQueryTextbox.Text, 1, 0);

            bool successful = sqlResponse?.Success ?? false;
            if (successful && sqlResponse.DataSetOut?.Tables.Count > 0)
            {
                if (sqlResponse.DataSetOut.Tables[0].Rows.Count == 0)
                {
                    MessageBox.Show("No records found for the SQL query. No JSON document could be created.");
                }
                else
                {
                    this.SaveJsonFromRow(this.SQLTableName.Text, sqlResponse.DataSetOut.Tables[0].Rows[0]);
                }
            }
            else
            {
                string errorMessage = $"The SQL query could not be performed. {sqlResponse?.ErrorMessage ?? "An unknown error has occurred."}";
                MessageBox.Show(errorMessage);
            }
        }

        /// <summary>
        /// Allows a user to save the JSON that results from the given tableName and DataRow
        /// </summary>
        /// <param name="tableName"></param>
        /// <param name="dr"></param>
        private void SaveJsonFromRow(string tableName, DataRow dr)
        {
            if (String.IsNullOrEmpty(tableName) || dr?.Table == null)
            {
                MessageBox.Show("Invalid data passed to SaveJsonFromRow. Unable to generate JSON document.");
                return;
            }

            // If fetching from a data view, remove fully qualified table name
            if (tableName.ToLower().Contains("maindb_") || tableName.ToLower().Contains("startupdb_"))
            {
                tableName = tableName.ToLower().Replace("maindb_", "");
                tableName = tableName.ToLower().Replace("startupdb_", "");
            }

            var outgoingModel = new JsonDocumentModel()
            {
                CompanyID = this.CompanyIDTextbox.Text,
                APIKey = APIKEY,
                TableName = tableName
            };

            foreach (DataColumn dc in dr.Table.Columns)
            {
                if (!dc.ColumnName.StartsWith("z_"))
                {
                    string fieldName = dc.ColumnName;

                    // If fetching from a data view, remove fully qualified table name
                    if (fieldName.ToLower().Contains("maindb_") || fieldName.ToLower().Contains("startupdb_"))
                    {
                        fieldName = fieldName.ToLower().Replace("maindb_" + tableName.ToLower() + "_", "");
                        fieldName = fieldName.ToLower().Replace("startupdb_" + tableName.ToLower() + "_", "");
                    }

                    outgoingModel.ListOfFieldValues.Add(new RecordKeyValue()
                    {
                        Key = fieldName
                    });
                }
            }

            var designerSettings = new DesignerSettings()
            {
                DocumentType = 0
            };

            var dsDesign = new DesignerSettingsDesign()
            {
                NodeType = 2,
                SourceType = "Input",
                InputOrColulmnName = "Root"
            };

            dsDesign.Children.Add(new DesingerSettingsDesignChild()
            {
                NodeName = "TableName",
                NodeType = 3,
                SourceType = "Static",
                NodeWriteSettings = tableName
            });

            dsDesign.Children.Add(new DesingerSettingsDesignChild()
            {
                NodeName = "CompanyID",
                NodeType = 3,
                SourceType = "Static",
                NodeWriteSettings = CompanyIDTextbox.Text
            });

            dsDesign.Children.Add(new DesingerSettingsDesignChild()
            {
                NodeName = "Broker",
                NodeType = 3,
                SourceType = "Static",
                NodeWriteSettings = String.Empty
            });

            // List<DesignChildChildren>
            var fieldValuesNode = new DesingerSettingsDesignChild()
            {
                NodeName = "ListOfFieldValues",
                NodeType = 1,
                SourceType = "None"
            };

            var dsInput = new DesignerSettingsInput()
            {
                Name = "Root"
            };

            // Populate children into the filedValuesNode from the data columns in the dataset
            foreach (DataColumn dc in dr.Table.Columns)
            {
                if (!dc.ColumnName.StartsWith("z_"))
                {
                    string fieldName = dc.ColumnName;

                    // If fetching from a data view, remove fully qualified table name
                    if (fieldName.ToLower().Contains("maindb_") || fieldName.ToLower().Contains("startupdb_"))
                    {
                        fieldName = fieldName.ToLower().Replace("maindb_" + tableName.ToLower() + "_", "");
                        fieldName = fieldName.ToLower().Replace("startupdb_" + tableName.ToLower() + "_", "");
                    }

                    fieldValuesNode.Children.Add(new DesignChildChildren() {
                        NodeType = 3,
                        SourceType = "None",
                        Children = new List<ChildrenChild>()
                        {
                            new ChildrenChild()
                            {
                                NodeName = "Key",
                                NodeType = 3,
                                SourceType = "Static",
                                NodeWriteSettings = fieldName
                            },
                            new ChildrenChild()
                            {
                                NodeName = "Value",
                                NodeType = 3,
                                SourceType = "Column",
                                InputOrColumnName = fieldName
                            }
                        }
                    });

                    dsInput.Columns.Add(new DesignerSettingsInputColumn()
                    {
                        Name = fieldName,
                        DataType = 130,
                        Length = 255,
                        Precision = 0,
                        Scale = 0,
                        CodePage = 0
                    });
                }
            }

            designerSettings.Inputs.Add(dsInput);
            dsDesign.Children.Add(fieldValuesNode);
            designerSettings.Design.Add(dsDesign);

            using (var sfd = new SaveFileDialog())
            {
                sfd.Filter = "json files (*.json)|*.json|All files (*.*)|*.*";
                sfd.FilterIndex = 1;

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(outgoingModel, Formatting.Indented));
                    File.WriteAllText(sfd.FileName.Replace(".json", "") + "_designer.json" , JsonConvert.SerializeObject(designerSettings, Formatting.Indented));
                    MessageBox.Show($"Created two files. \r\n{sfd.FileName} \r\nand {sfd.FileName.Replace(".json", "") + "_designer.json"}");
                }
            }
        }

        /// <summary>
        /// Handles the click of the 'About' Menu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnClickAboutMenu(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://gitlab.com/odyssey-api/odyssey-api-demo/-/tree/master/WinForms/JsonDocumentCreatorDesignerSettings");
        }

        private void OnClickExitMenu(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Handles the change of the APIKey textbox to keep track of the current APIKey
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void APIKeyTextbox_TextChanged(object sender, EventArgs e)
        {
            APIKEY = this.APIKeyTextbox.Text;
        }

        /// <summary>
        /// Handles the change of the URL textbox to keep track of the current URL
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void URLTextBox_TextChanged(object sender, EventArgs e)
        {
            APIURL = this.URLTextBox.Text;
        }
    }
}
