using System;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// This class contains all the fields needed to form a complete Data View Parameter.
    /// </summary>
    public class DataViewParameter
    {
        /// <summary>
        /// The fully qualified fieldname (including the database name and the table name)
        /// e.g. maindb.orderitem.customer
        /// </summary>
        public string FieldName { get; set; } = String.Empty;

        /// <summary>
        /// The operator you are using in this parameter.
        /// </summary>
        public string Operator { get; set; } = String.Empty;

        /// <summary>
        /// The value of the parameter you are passing to the data view.
        /// </summary>
        public string ParameterValue { get; set; } = String.Empty;
    }
}
