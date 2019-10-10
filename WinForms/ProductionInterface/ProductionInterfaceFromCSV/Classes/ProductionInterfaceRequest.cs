using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionInterfaceFromCSV.Classes
{
    /// <summary>
    /// The properties to send to a production interface request
    /// </summary>
    public class ProductionInterfaceRequest
    {
        /// <summary>
        /// The CompanyID you're using this production interface with
        /// </summary>
        public string CompanyID { get; set; } = String.Empty;

        /// <summary>
        /// The ID of the production interface you're using
        /// </summary>
        public string InterfaceID { get; set; } = String.Empty;

        /// <summary>
        /// The ID of the import you're using in your production interface
        /// </summary>
        public string ImportID { get; set; } = String.Empty;

        /// <summary>
        /// The list of production records you're importing.
        /// </summary>
        public List<dynamic> DataList { get; set; } = new List<dynamic>();
    }
}
