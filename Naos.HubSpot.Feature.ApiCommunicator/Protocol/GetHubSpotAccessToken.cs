namespace Naos.HubSpot.Feature.ApiCommunicator.Protocol
{
    using System.Threading.Tasks;
    using Naos.FluentUri;
    using Naos.HubSpot.Domain.Contracts.ContactsApi.ResponseContracts;
    using Naos.HubSpot.Domain.Operations;
    using Naos.HubSpot.Domain.Protocols;
    using Naos.HubSpot.Feature.ApiCommunicator.UriStrategies;

    /// <summary>
    /// Protocol managing the Access Token state.
    /// </summary>
    public class GetHubSpotAccessToken : IProtocolHubSpotAccessKeys
    {
        private readonly object lockState = new object();
        private TokenResponse state;

        /// <summary>
        /// Gets the access token from HubSpot.
        /// </summary>
        /// <param name="operation">The parameter object for getting an access token from HubSpot.</param>
        /// <returns>The access token.</returns>
        public string Execute(GetHubSpotAccessTokenOp operation)
        {
            lock (this.lockState)
            {
                if (!string.IsNullOrEmpty(this.state.access_token))
                {
                    return this.state.access_token;
                }
            }

            // Generate the URI using the URI protocol.
            // Pass in the strategy object that generates the correct URI.

            var uri = UrlStrategy.BuildAccessTokenUri();
            var resp = uri.Get<TokenResponse>();
            this.state = resp;
            return this.state.access_token;

        }

        /// <summary>
        /// Saves the new access key to state.
        /// </summary>
        /// <param name="operation">The token response object.</param>
        public void Execute(ContinueAccessTokenOp operation)
        {

            lock (this.lockState)
            {
                this.state.access_token = operation.ContinueAccessToken;
            }
        }

        /// <summary>
        /// Returns the task that returns the access_token.
        /// </summary>
        /// <param name="operation">The object that contains the params for the token protocol.</param>
        /// <returns>
        ///     A <see cref="Task"/> representing the asynchronous operation.
        /// </returns>
        public Task<string> ExecuteAsync(GetHubSpotAccessTokenOp operation)
        {
            return Task.Factory.StartNew(() => this.Execute(operation));
        }

        /// <summary>
        /// Returns the token update task.
        /// </summary>
        /// <param name="operation">Represents the parameter object for the protocol.</param>
        /// <returns>A <see cref="Task"/> representing the asynchronous operation.</returns>
        public Task ExecuteAsync(ContinueAccessTokenOp operation)
        {
            return Task.Factory.StartNew(() => this.Execute(operation));
        }
    }
}
