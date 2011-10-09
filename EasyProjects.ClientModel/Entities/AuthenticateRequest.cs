using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EasyProjects.ClientModel.Entities
{
    public struct AuthenticateRequest
    {
        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>The username.</value>
        public string username { get; set; }

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>The password.</value>
        public string password { get; set; }
    }
}
