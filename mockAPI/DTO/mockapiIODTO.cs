using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace mockAPI.DTO
{
    public struct mockapiIODTO
    {
        public Guid id { get; set; }
        public DateTime CreatedAt { get; set; }
        public string name { get; set; }
        public string avatar { get; set; }
    }
}
