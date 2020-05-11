using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields that will be returned from the FetchDataSQL method.
    /// </summary>
    public class FetchDataSQLResponse
    {
        /// <summary>
        /// Whether or not the request was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// An error message from the call, if any exists.
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// The dataset returned from the SQL query.
        /// </summary>
        public DataSet DataSetOut { get; set; } = null;
    }
}
