using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ReservationAPIInfrastructure;
using ReservationAPIModels;

namespace ReservetionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResController : ControllerBase
    {
        private readonly IResvationService service;
        public ResController(IResvationService resvationService)
        {
            service = resvationService;
        }

        [HttpGet("{Id}")]
        public ReservationDTO Get(int Id)
        {
          return  service.GetResBkgNumber(Id);
        }
    }
}
