using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// The format of data that /Record/Add or /Record/Update wants
    /// </summary>
    public class JsonDocumentModel
    {
        /// <summary>
        /// The table being referenced
        /// </summary>
        public string TableName { get; set; } = String.Empty;

        /// <summary>
        /// The APIKey being used
        /// </summary>
        public string APIKey { get; set; } = String.Empty;

        /// <summary>
        /// The CompanyID being used
        /// </summary>
        public string CompanyID { get; set; } = String.Empty;

        /// <summary>
        /// The list of KVP entries for this record
        /// </summary>
        public List<RecordKeyValue> ListOfFieldValues { get; set; } = new List<RecordKeyValue>();
    }
}
