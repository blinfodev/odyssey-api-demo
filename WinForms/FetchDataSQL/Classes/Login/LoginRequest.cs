using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchDataSQL.Classes.Login
{
    /// <summary>
    /// This request encapsulates properties used when logging in.
    /// </summary>
    public class LoginRequest
    {
        /// <summary>
        /// The username of the user you're logging in for.
        /// </summary>
        public string Username { get; set; } = String.Empty;

        /// <summary>
        /// The password of the user you're logging in for.
        /// </summary>
        public string Password { get; set; } = String.Empty;

        /// <summary>
        /// The CompanyID of the company you're logging into
        /// </summary>
        public string CompanyID { get; set; } = String.Empty;
    }
}
