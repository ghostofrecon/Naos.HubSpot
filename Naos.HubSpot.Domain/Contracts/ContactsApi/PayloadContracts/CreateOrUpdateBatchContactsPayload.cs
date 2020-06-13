using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naos.HubSpot.Domain.Contracts.ContactsApi.PayloadContracts
{
    using Naos.HubSpot.Domain.Contracts.ContactsApi.QueryModels;

    public class CreateOrUpdateBatchContactsPayload
    {
        /// <summary>
        /// 
        /// </summary>
        public IEnumerable<CreateOrUpdateContactPayload> Contacts { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="contacts"></param>
        public CreateOrUpdateBatchContactsPayload(IEnumerable<CreateOrUpdateContactPayload> contacts)
        {
            Contacts = contacts;
        }
    }
}
