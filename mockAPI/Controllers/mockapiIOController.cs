using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using mockAPI.DTO;
using mockAPI.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class mockapiIOController : ControllerBase
    {
        [HttpGet]
        public Task<mockapiIODTO> GetMockapiIO([FromServices] ImockapiIORepository repository)
        {
            return repository.ReturnMockapiIO();
        }
    }
}
