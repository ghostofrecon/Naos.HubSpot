using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Models.QueryModels
{
    /// <summary>
    /// The class that represents the query information for the update contact by email operation.
    /// </summary>
    public class UpdateContactByEmailQuery
    {
        /// <summary>
        /// Gets or sets the email of the contact to update.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateContactByEmailQuery"/> class.
        /// </summary>
        /// <param name="email">The email of the contact to update.</param>
        public UpdateContactByEmailQuery(string email)
        {
            this.Email = email;
        }
    }
}
