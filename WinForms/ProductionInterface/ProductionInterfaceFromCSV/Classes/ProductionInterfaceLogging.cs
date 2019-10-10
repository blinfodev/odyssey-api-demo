using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionInterfaceFromCSV.Classes
{
    /// <summary>
    /// Log message that is returned from the production interface.
    /// </summary>
    public class ProductionInterfaceLogging
    {
        /// <summary>
        /// The type of error.
        /// </summary>
        public string ErrorType { get; set; } = String.Empty;

        /// <summary>
        /// The error text.
        /// </summary>
        public string TextString { get; set; } = string.Empty;

        /// <summary>
        /// The line number of the error.
        /// </summary>
        public string LineNumber { get; set; } = String.Empty;
    }
}
