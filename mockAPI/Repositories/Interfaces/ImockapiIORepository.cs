using mockAPI.DTO;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockAPI.Repositories.Interfaces
{
    public interface ImockapiIORepository
    {
        [Get("/api/teste-amcom-1")]
        Task<mockapiIODTO> ReturnMockapiIO();
    }
}
