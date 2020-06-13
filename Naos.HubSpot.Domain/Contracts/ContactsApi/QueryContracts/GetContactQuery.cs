// <copyright file="GetContactQuery.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Contracts.ContactsApi.QueryModels
{
    using System.Collections.Generic;
    using Naos.HubSpot.Domain.Contracts.ContactsApi.ModelEnums;
    using Naos.HubSpot.Domain.Contracts.ModelEnums;

    /// <summary>
    /// The query model for the GetContactProtocol.
    /// </summary>
    public class GetContactQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GetContactQuery"/> class.
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
        public GetContactQuery(string[] props, PropertyMode propertyMode = PropertyMode.value_and_history, FormSubmissionMode formSubmissionMode = FormSubmissionMode.all, bool showListMemberships = true)
        {
            this.properties = props;
            this.propertyMode = propertyMode.ToString();
            this.formSubmissionMode = formSubmissionMode.ToString();
            this.showListMemberships = showListMemberships;
        }

        /// <summary>
        /// private field for the properties array.
        /// </summary>
        private readonly string[] properties;

        /// <summary>
        /// private field for the property mode enum.
        /// </summary>
        private readonly string propertyMode;

        /// <summary>
        /// private field for the form submission mode enum.
        /// </summary>
        private readonly string formSubmissionMode;

        /// <summary>
        /// private field for the show list membership bool.
        /// </summary>
        private readonly bool showListMemberships;

    }
}
