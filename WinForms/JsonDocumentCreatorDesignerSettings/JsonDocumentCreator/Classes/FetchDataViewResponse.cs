using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields that will be returned from the FetchDataViewData method.
    /// </summary>
    public class FetchDataViewResponse
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

        /// <summary>
        /// The number of records that were returned with this request.
        /// </summary>
        public int RecordCount { get; set; } = 0;
    }
}
