using ReservationAPIModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationAPIInfrastructure
{
    public interface IResvationService
    {
        public ReservationDTO GetResBkgNumber(int BkgNumber);
    }
}
