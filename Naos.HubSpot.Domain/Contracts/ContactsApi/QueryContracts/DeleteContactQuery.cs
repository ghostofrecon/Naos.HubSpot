using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Contracts.ContactsApi.QueryModels
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteContactQuery
    {
        /// <summary>
        /// 
        /// </summary>
        public int Vid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vid"></param>
        public DeleteContactQuery(int vid)
        {
            this.Vid = vid;
        }
    }
}
