using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABL.Api.Models
{
    public class Locker
    {
        public required string lockerId {get; set;}
        public Occupant? occupant {get; set;}

    }
}