﻿using ReservationAPIInfrastructure;
using ReservationAPIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationAPIServices
{
    public class ReservationService : IResvationService
    {
        public ReservationDTO GetResBkgNumber(int BkgNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                Amount = (new Random()).Next(10000),
                BkgDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckoutDate = DateTime.Now.Date.AddDays(37),
                ReservationNumber = BkgNumber

            };
        }
    }
}
