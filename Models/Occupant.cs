using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABL.Api.Models
{
    public class Occupant
    {
        public required string sid {get; set;}
        public required string name {get; set;}
        public required string phone {get; set;}
        public required string email {get; set;}
    }
}