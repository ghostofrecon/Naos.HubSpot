// <copyright file="UrlStrategy.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Feature.ApiCommunicator.UriStrategies
{
    using System;
    using Naos.FluentUri;

    /// <summary>
    /// The base object that defines the Url Strategy 
    /// </summary>
    public static class UrlStrategy
    {
        /// <summary>
        /// The HubSpot API base URI.
        /// </summary>
        private static readonly Uri baseUri = new Uri("https://api.hubapi.com");

        /// <summary>
        /// Builds the access token URI.
        /// </summary>
        /// <returns>A <see cref="Uri"/> for the access token Uri.</returns>
        public static Uri BuildAccessTokenUri() => baseUri.AppendPathSegment("/oauth/v1/token");

        public static Uri BuildGetAllContactsUri(int count) => baseUri.AppendPathSegment($"/contacts/v1/lists/all/contacts/all?count={count}");
    }
}
