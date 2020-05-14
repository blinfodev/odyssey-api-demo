using System;

namespace JsonDocumentCreator.Classes
{
    /// <summary>
    /// The key value pair instance that defines a field in the record
    /// </summary>
    public class RecordKeyValue
    {
        /// <summary>
        /// The name of the field
        /// </summary>
        public string Key { get; set; } = String.Empty;

        /// <summary>
        /// The value of the field
        /// </summary>
        public string Value { get; set; } = String.Empty;
    }
}
