using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields needed to make a request to the FetchDataViewData method.
    /// </summary>
    public class FetchDataViewRequest
    {
        /// <summary>
        /// This is the Company that you are logging into. 
        /// Your user that you are logging into Odyssey with must have access to this company. 
        /// You can fetch records from any company, based your query.
        /// </summary>
        public virtual string CompanyID { get; set; } = String.Empty;

        /// <summary>
        /// This identifies the name of the Data View to run. It must exist in the same company that you logged into.
        /// </summary>
        public string DataView { get; set; } = String.Empty;

        /// <summary>
        /// A list of DataViewParameter's that define the parameters you're passing to the dataview.
        /// </summary>
        public List<DataViewParameter> ParameterList { get; set; } = new List<DataViewParameter>();
    }
}
