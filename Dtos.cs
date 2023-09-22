using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABL.Api.Models;

namespace VABL.Api
{
    public record LockerListDto(
        string semester,
        Locker[] l_list 
    );
}