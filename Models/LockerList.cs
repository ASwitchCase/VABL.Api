using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABL.Api.Models
{
    public class LockerList
    {
        public required string id { get; set;}
        public required string semester { get; set; }
        public required Locker[] l_list { get; set; }
    }
}