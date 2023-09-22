using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VABL.Api.Models
{
    public static class ModelExtentions
    {
        public static LockerListDto AsDto(this LockerList lockerList){
            return new LockerListDto(
                lockerList.semester,
                lockerList.l_list
            );
        }
    }
}