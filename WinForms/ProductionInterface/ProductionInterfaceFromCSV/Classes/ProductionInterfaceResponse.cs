using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionInterfaceFromCSV.Classes
{
    /// <summary>
    /// Properties that we receive back from a ProductionInterface request
    /// </summary>
    public class ProductionInterfaceResponse
    {
        /// <summary>
        /// Whether this API call was successful
        /// </summary>
        public bool Success { get; set; } = false;

        /// <summary>
        /// An error message returned by the call, if any
        /// </summary>
        public string ErrorMessage { get; set; } = String.Empty;

        /// <summary>
        /// The number of records that were attempted by the import.
        /// </summary>
        public int Attempted { get; set; } = 0;

        /// <summary>
        /// The number of records that were successfully added by the import.
        /// </summary>
        public int Successful { get; set; } = 0;

        /// <summary>
        /// The list of errors we received from the back end call, if any
        /// </summary>
        public List<ProductionInterfaceLogging> Logging { get; set; } = new List<ProductionInterfaceLogging>();
    }
}
