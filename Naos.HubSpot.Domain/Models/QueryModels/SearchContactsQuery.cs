using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Models.QueryModels
{
    public class SearchContactsQuery
    {
        public string SearchQuery { get; set; }
        public string Count { get; set; }
        public string Property { get; set; }
        public string Sort { get; set; }
        public string Order { get; set; }
    }
}
