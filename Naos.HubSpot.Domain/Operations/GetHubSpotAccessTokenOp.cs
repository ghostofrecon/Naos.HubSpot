namespace Naos.HubSpot.Domain.Operations
{
    using System;
    using Naos.HubSpot.Domain.Models;
    using Naos.Protocol.Domain;
    using OBeautifulCode.Assertion.Recipes;

    /// <summary>
    /// This gets the HubSpot access key from the API using the
    /// user-provided access code.
    /// </summary>
    public class GetHubSpotAccessTokenOp : ReturningOperationBase<string>
    {
    }
}
