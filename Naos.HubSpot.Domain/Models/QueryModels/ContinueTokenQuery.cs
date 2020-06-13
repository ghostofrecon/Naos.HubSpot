// <copyright file="ContinueTokenBodyModel.cs" company="Naos Project">
//    Copyright (c) Naos Project 2019. All rights reserved.
// </copyright>
namespace Naos.HubSpot.Domain.QueryModels
{
    using System.Text;

    /// <summary>
    /// The model defining the post object for for the GetAccessToken protocol.
    /// </summary>
    public class ContinueTokenQuery
    {
        private readonly string clientId;
        private readonly string clientSecret;
        private readonly string refreshToken;

        /// <summary>
        /// Initializes a new instance of the <see cref="ContinueTokenQuery"/> class.
        /// </summary>
        /// <param name="clientId">The client ID of the application.</param>
        /// <param name="clientSecret">The client secret of the application.</param>
        /// <param name="refreshToken">The user's refresh token.</param>
        public ContinueTokenQuery(string clientId, string clientSecret, string refreshToken)
        {
            this.clientId = clientId;
            this.clientSecret = clientSecret;
            this.refreshToken = refreshToken;
        }

        /// <summary>
        /// Overrides the ToString method to generate the query string.
        /// </summary>
        /// <returns>The query string representing the object.</returns>
        public override string ToString()
        {
            var sb = new StringBuilder("?");
            sb.Append("grant_type=code");
            sb.Append($"client_id={this.clientId}");
            sb.Append($"client_secret={this.clientSecret}");
            sb.Append($"refresh_token={this.refreshToken}");
            return sb.ToString();
        }
    }
}
