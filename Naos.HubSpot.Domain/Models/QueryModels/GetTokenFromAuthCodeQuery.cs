// <copyright file="GetTokenFromAuthCodeQuery.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>

namespace Naos.HubSpot.Domain.Models.QueryModels
{
    using System.Text;

    /// <summary>
    ///     The model that represents the post model for getting the access token.
    /// </summary>
    public class GetTokenFromAuthCodeQuery
    {
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly string redirectUri;
        private readonly string code;

        /// <summary>
        ///     Initializes a new instance of the <see cref="GetTokenFromAuthCodeQuery"/> class.
        /// </summary>
        /// <param name="clientId">
        ///     The Client ID of your app.
        /// </param>
        /// <param name="clientSecret">
        ///     The Client Secret of your app.
        /// </param>
        /// <param name="redirectUri">
        ///     The redirect URI that was used when the user authorized your app. This must exactly match the redirect_uri used
        ///     when initiating the OAuth 2.0 connection.
        /// </param>
        /// <param name="authcode">
        ///     The code parameter returned to your redirect URI when the user authorized your app.
        /// </param>
        public GetTokenFromAuthCodeQuery(string clientId, string clientSecret, string redirectUri, string authcode)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.redirectUri = redirectUri;
            this.code = authcode;
        }

        /// <summary>
        ///     Overrides the ToString method to generate the query string.
        /// </summary>
        /// <returns>
        ///     The query string with the options selected.
        /// </returns>
        public override string ToString()
        {
            var sb = new StringBuilder("?");
            sb.Append("grant_type=code");
            sb.Append($"&client_id={this.clientId}");
            sb.Append($"&client_secret={this.clientSecret}");
            sb.Append($"&redirect_uri={this.redirectUri}");
            sb.Append($"&code={this.code}");
            return sb.ToString();
        }
    }
}
