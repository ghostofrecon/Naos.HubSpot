// <copyright file="GetHubSpotContactOp.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Operations
{
    using System;
    using Naos.HubSpot.Domain.Models;
    using Naos.HubSpot.Domain.Models.ModelEnums;
    using Naos.HubSpot.Domain.Models.QueryModels;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// Operation that gets a HubSpot contact.
    /// </summary>
    public class GetHubSpotContactOp : ReturningOperationBase<Contact>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetHubSpotContactOp"/> class.
        /// </summary>
        /// <param name="email">
        ///     The email address for the contact you're searching for.
        /// </param>
        /// <param name="vid">
        ///     Unique identifier for a particular contact. In HubSpot's contact system, contact ID's are called "vid", as you can see in the API output below.
        /// </param>
        /// <param name="properties">
        ///     By default, all valued properties will be included. If you include the "property" parameter, then the returned data will only include the property
        ///     or properties that you request. You can include this parameter multiple times to specify multiple properties. The lastmodifieddate and associatedcompanyid will always be
        ///     included, even if not specified. Keep in mind that only properties that have a value will be included in the response, even if specified in the URL.
        /// </param>
        /// <param name="propertyMode">
        ///     One of “value_only” or “value_and_history” to specify if the current value for a property should be fetched,
        ///     or the value and all the historical values for that property. Default is “value_and_history”.
        /// </param>
        /// <param name="formSubmissionMode">
        ///     One of “all”, “none”, “newest”, “oldest” to specify which form submissions should be fetched. Default is “all”.
        /// </param>
        /// <param name="showListMembership">
        ///     Boolean "true" or "false" to indicate whether current list memberships should be fetched for the contact. Default is true.
        /// </param>
        public GetHubSpotContactOp(
            string email,
            string vid,
            string[] properties,
            PropertyMode propertyMode = PropertyMode.value_and_history,
            FormSubmissionMode formSubmissionMode = FormSubmissionMode.all,
            bool showListMembership = true)
        {
            (string.IsNullOrWhiteSpace(email) && string.IsNullOrWhiteSpace(vid)).MustForArg(
                FormattableString.Invariant($"Both {nameof(email)} and {nameof(vid)} cannot be null"));
            this.Email = email;
            this.Vid = vid;
            this.FormSubmissionMode = formSubmissionMode;
            this.ShowListMembership = showListMembership;
            this.Properties = properties;
            this.PropertyMode = propertyMode;
            this.Query = new GetContactQuery(this.Vid);

        }

        /// <summary>
        /// The query model of the 
        /// </summary>
        public GetAllContactsQuery Query { get; set; }

        /// <summary>
        /// Gets the email property.
        /// </summary>
        public string Email { get; private set; }

        /// <summary>
        /// Gets the Vid Property.
        /// </summary>
        public string Vid { get; private set; }

        /// <summary>
        /// Gets or sets the properties that will be included in the response.
        /// </summary>
        public string[] Properties { get; set; }

        /// <summary>
        /// Gets or sets the form submission mode.
        /// </summary>
        public FormSubmissionMode FormSubmissionMode { get; set; }

        /// <summary>
        /// Gets or sets the property mode that will define the properties returned in the response.
        /// </summary>
        public PropertyMode PropertyMode { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the property that shows whether or not the list memberships of the contact will be shown.
        /// </summary>
        public bool ShowListMembership { get; set; }
    }
}
