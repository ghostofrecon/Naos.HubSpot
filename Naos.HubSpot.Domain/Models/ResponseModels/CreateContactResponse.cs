namespace Naos.HubSpot.Domain.Models.ResponseModels
{
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using Naos.HubSpot.Domain.Models.ModelEnums;


    /// <summary>
    /// 
    /// </summary>
    public class CreateNewContactResponse
    {

        /// <summary>
        /// 
        /// </summary>
        public IdentityProfile[] IdentityProfiles { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public Properties Properties { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public object[] FormSubmissions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public long Vid { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class Address
    {
        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }


        /// <summary>
        /// 
        /// </summary>
        public Version[] Versions { get; set; }
    }

    /// <summary>
    /// 
    /// </summary>
    public partial class Version
    {
        /// <summary>
        /// 
        /// </summary>
        public long Timestamp { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Selected { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SourceLabel { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public SourceType SourceType { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string SourceId { get; set; }
    }
}