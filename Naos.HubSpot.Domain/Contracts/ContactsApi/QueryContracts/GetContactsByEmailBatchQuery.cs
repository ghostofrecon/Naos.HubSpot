using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Contracts.ContactsApi.QueryModels
{
    using Naos.HubSpot.Domain.Contracts.ContactsApi.ModelEnums;
    using Naos.HubSpot.Domain.Contracts.ModelEnums;

    /// <summary>
    /// Represents the query required to get multiple contacts by email.
    /// </summary>
    public class GetContactsByEmailBatchQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactsByEmailBatchQuery"/> class.
        ///   </summary>
        /// <param name="props">
        ///     By default, all valued properties will be included. If you include the "property" parameter,
        ///     then the returned data will only include the property or properties that you request. You can
        ///     include this parameter multiple times to specify multiple properties. The lastmodifieddate and
        ///     associatedcompanyid will always be included, even if not specified. Keep in mind that only
        ///     properties that have a value will be included in the response, even if specified in the URL.</param>
        /// <param name="propertyMode">
        ///     One of “value_only” or “value_and_history” to specify if the current value for a property
        ///     should be fetched, or the value and all the historical values for that property. Default
        ///     is “value_and_history”.
        /// </param>
        /// <param name="formSubmissionMode">
        ///     One of “all,” “none,” “newest,” “oldest” to specify which form submissions should be fetched.
        ///     Default is “all.”
        /// </param>
        /// <param name="showListMemberships">
        ///     Boolean "true" or "false" to indicate whether current list memberships should be fetched for the contact.
        ///     Default is true.
        /// </param>
        public GetContactsByEmailBatchQuery(string[] props, PropertyMode propertyMode = PropertyMode.value_and_history, FormSubmissionMode formSubmissionMode = ModelEnums.FormSubmissionMode.all, bool showListMemberships = true)
        {
            this.Properties = props;
            this.PropertyMode = propertyMode;
            this.FormSubmissionMode = formSubmissionMode.ToString();
            this.ShowListMemberships = showListMemberships;
        }

        /// <summary>
        /// Gets or sets private field for the properties array.
        /// </summary>
        public string[] Properties { get;set; }

        /// <summary>
        /// Gets or sets public field for the property mode enum.
        /// </summary>
        public PropertyMode PropertyMode { get;set; }

        /// <summary>
        /// Gets or sets private field for the form submission mode enum.
        /// </summary>
        public string FormSubmissionMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether private field for the show list membership bool.
        /// </summary>
        public bool ShowListMemberships { get; set; }

        
    }
}
