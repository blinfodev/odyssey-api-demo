using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields needed to make a request to the FetchData4GL method.
    /// </summary>
    public class FetchDataABLRequest
    {
        /// <summary>
        /// This is the Company that you are logging into. 
        /// Your user that you are logging into Odyssey with must have access to this company. 
        /// You can fetch records from any company, based your query.
        /// </summary>
        public string CompanyID { get; set; } = String.Empty;

        /// <summary>
        /// The name of the Odyssey table from which you wish to return data.
        /// </summary>
        public string TableName { get; set; } = String.Empty;

        /// <summary>
        /// A fully formed and syntactically correct ABL where clause. 
        /// This should not include the sort criteria as that is specified separately.
        /// </summary>
        public string ABLQuery { get; set; } = String.Empty;

        /// <summary>
        /// A list of fields that define the order that the record will be returned. 
        /// This must conform to the ABL sort criteria.
        /// </summary>
        public string Sort { get; set; } = String.Empty;

        /// <summary>
        /// A comma-separated list of fields for which you are to receive data. 
        /// If left blank, all fields in the table will be included in the return data set. 
        /// If you specify only those fields that you want to see, the query will run faster and more efficiently.
        /// </summary>
        public string FieldList { get; set; } = String.Empty;
    }
}
