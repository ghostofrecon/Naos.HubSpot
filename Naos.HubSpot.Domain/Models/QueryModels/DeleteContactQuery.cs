using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Models.QueryModels
{
    /// <summary>
    /// 
    /// </summary>
    public class DeleteContactQuery
    {
        /// <summary>
        /// 
        /// </summary>
        public string Vid { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="vid"></param>
        public DeleteContactQuery(string vid)
        {
            this.Vid = vid;
        }
    }
}
