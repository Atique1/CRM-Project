using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebService.Models;
using WebService.Repositories;

namespace WebService.Processors
{
    public class ContactProcessor
    {
        public static bool ProcessContact(Contact contact)
        {
            // processing, formating, validating

            return ContactRepositories.AddContactToDB(contact);
        }
    }
}