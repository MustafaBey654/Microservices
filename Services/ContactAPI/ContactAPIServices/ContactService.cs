﻿using CantactAPIModels;
using ContactAPI.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactAPIServices
{

    public class ContactService : IContactService
    {
        public ContactDTO GetContactById(int Id)
        {
            return new ContactDTO()
            {
                Id = Id,
                FirstName = "Salih",
                LastName = "Gültekin"
            };
        }
    }
}
