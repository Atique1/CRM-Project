using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebService.Models;
using WebService.Processors;

namespace WebService.Controllers
{
    public class ContactsController : ApiController
    {
        [HttpPost]
        [Route("SaveContact")]

        // POST api/values
        public bool SaveContact(Contact contact)
        {
            return ContactProcessor.ProcessContact(contact);
        }

        
    }
}
