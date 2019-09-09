using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductionInterface.Classes
{
    /// <summary>
    /// Properties that we receive back from a Login request
    /// </summary>
    public class LoginResponse
    {
        /// <summary>
        /// The APIKey that was generated for this login request
        /// </summary>
        public string APIKey { get; set; } = String.Empty;

        /// <summary>
        /// An error message returned by the call, if any
        /// </summary>
        public string ErrorMessage { get; set; } = String.Empty;

        /// <summary>
        /// Whether the call was successful
        /// </summary>
        public bool Success { get; set; } = false;
    }
}
