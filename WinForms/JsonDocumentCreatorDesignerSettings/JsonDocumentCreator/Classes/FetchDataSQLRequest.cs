using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields needed to make a request to the FetchDataSQL method.
    /// </summary>
    public class FetchDataSQLRequest
    {
        /// <summary>
        /// This is the Company that you are logging into. 
        /// Your user that you are logging into Odyssey with must have access to this company. 
        /// You can fetch records from any company, based your query.
        /// </summary>
        public string CompanyID { get; set; } = String.Empty;

        /// <summary>
        /// This is a fully formed and fully qualified SQL query that conforms to SQL-92 syntax. 
        /// The tables specified and the field specified in the SQL statement must exist as defined in the database in order for the query to work.
        /// </summary>
        public string SQLQuery { get; set; } = String.Empty;

        /// <summary>
        /// If you only want to return a subset of records, you can identify which page of records to return. 
        /// If this is 0, then all records from the database table specified in the SQL query are returned.
        /// </summary>
        public int Page { get; set; } = 0;

        /// <summary>
        /// This specifies the number or records to return for each page. If you wish to return all records, this should be set to zero.
        /// </summary>
        public int BatchSize { get; set; } = 1;
    }

}
