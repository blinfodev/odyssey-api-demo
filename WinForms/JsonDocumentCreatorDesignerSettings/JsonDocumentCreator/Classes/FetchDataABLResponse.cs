using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields that will be returned from the FetchData4GL method.
    /// </summary>
    public class FetchDataABLResponse
    {
        /// <summary>
        /// The return value of the method will be the dataset of records fetched by the query.
        /// </summary>
        public DataSet DataSetOut { get; set; } = null;

        /// <summary>
        /// The number of records that were returned with this request.
        /// </summary>
        public int RecordCount { get; set; } = 0;

        /// <summary>
        /// Whether or not the request was successful.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// An error message from the call, if any exists.
        /// </summary>
        public string ErrorMessage { get; set; }
    }
}
