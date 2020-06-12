namespace Naos.HubSpot.Domain.Operations
{
    using Naos.Protocol.Domain;

    /// <summary>
    /// Gets the continue access token from HubSpot API.
    /// </summary>
    public class ContinueAccessTokenOp : VoidOperationBase
    {
        /// <summary>
        /// Gets or sets the continue access token provided by the HubSpot API.
        /// </summary>
        public string ContinueAccessToken { get; set; }
    }
}
