﻿namespace Naos.HubSpot.Domain.Models.ResponseModels
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteContactResponse
    {
        /// <summary>
        /// 
        /// </summary>
        public long Vid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public bool Deleted { get; set; }

        /// <summary>
        /// 
        /// </summary>
        public string Reason { get; set; }
    }
}