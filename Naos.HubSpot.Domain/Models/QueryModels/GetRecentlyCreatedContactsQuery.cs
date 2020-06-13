using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Models.QueryModels
{
    using Naos.HubSpot.Domain.Models.ModelEnums;

    /// <summary>
    /// Represents the query parameters required to get recently created contacts.
    /// </summary>
    public class GetRecentlyCreatedContactsQuery
    {
        /// <summary>
        /// Gets the  parameter that lets you specify the amount of contacts to return in your API call. The default for this parameter (if it isn't specified) is 20 contacts. The maximum amount of contacts you can have returned to you via this parameter is 100.
        /// </summary>
        public string Count { get; private set; }


        /// <summary>
        /// Gets or sets the time offset.
        /// </summary>
        /// <value>
        /// The time offset.
        /// </value>
        public string TimeOffset { get; set; }

        /// <summary>
        /// Gets used to page through the contacts. Every call to this endpoint will return a vid-offset value. This value is used in the VidOffset parameter of the next call to get the next page of contacts.
        /// </summary>
        public int VidOffset { get; private set; }

        /// <summary>
        /// Gets by default, only a few standard properties will be included in the response data. If you include the 'property' parameter, then you will instead get the specified property in the response. This parameter may be included multiple times to specify multiple properties. NOTE: Contacts only store data for properties with a value, so records with no value for a property will not include that property, even if the property is specified in the request URL.
        /// </summary>

        public string[] Property { get; private set; }

        /// <summary>
        /// Gets one of “value_only” or “value_and_history” to specify if the current value for a property should be fetched, or the value and all the historical values for that property. Default is “value_only”.
        /// </summary>

        public string PropertyMode { get; private set; }

        /// <summary>
        /// Gets one of “all”, “none”, “newest”, “oldest” to specify which form submissions should be fetched. Default is “newest”.
        /// </summary>
        public string FormSubmissionMode { get; private set; }

        /// <summary>
        /// Gets a value indicating whether boolean "true" or "false" to indicate whether current list memberships should be fetched for the contact. Default is false.
        /// </summary>
        public bool ShowListMemberships { get; private set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="GetRecentlyCreatedContactsQuery"/> class.
        /// </summary>
        /// <param name="count">The number of records to receive default is 20, max is 100.</param>
        /// <param name="vidOffset">The vid offset of the previous call if any.  This will return a new "page" of contacts.</param>
        /// <param name="property">The names of the properties to return in the response.</param>
        /// <param name="propertyMode">Determines whether the history of the properties are returned along with the values or just the values.</param>
        /// <param name="formSubmissionMode">Designates which form submission should be fetched.  The default is "newest".</param>
        /// <param name="showListMemberships">Indicates whether or not the response will contain all list memberships for each contact.</param>
        public GetRecentlyCreatedContactsQuery(
            string timeOffset, 
            int count = 20,
            int vidOffset = 0,
            string[] property = null,
            PropertyMode propertyMode = ModelEnums.PropertyMode.value_and_history,
            FormSubmissionMode formSubmissionMode = ModelEnums.FormSubmissionMode.all,
            bool showListMemberships = true)
        {
            this.Count = count.ToString();
            this.VidOffset = vidOffset;
            this.TimeOffset = timeOffset;
            this.Property = property;
            this.PropertyMode = propertyMode.ToString();
            this.FormSubmissionMode = formSubmissionMode.ToString();
            this.ShowListMemberships = showListMemberships;
        }
    }
    }
}
