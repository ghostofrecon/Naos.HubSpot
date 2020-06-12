// <copyright file="TokenResponse.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Models.ResponseModels
{
    using System.Security.Permissions;

    /// <summary>
    /// The model representing the return of a token request.
    /// </summary>
    public class TokenResponse
    {
        /// <summary>
        /// Gets or sets the access token retrieved from the HubSpot.
        /// </summary>
        // access_token
        // ReSharper disable once InconsistentNaming
        public string access_token { get; set; }

        /// <summary>
        /// Gets or sets the refresh token retrieved from HubSpot.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string refresh_token { get; set; }

        /// <summary>
        /// Gets or sets the expiration time frame of the access_token.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public string expires_on { get; set; }
    }
}
