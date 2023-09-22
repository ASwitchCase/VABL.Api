using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABL.Api.Models;
using VABL.Api.Repositories;

namespace VABL.Api.Routes
{
    public static class LockerListRoute
    {
        public static RouteGroupBuilder MapLockerListRoutes(this IEndpointRouteBuilder routes){
            var group = routes.MapGroup("/lockerLists");
            group.MapGet("/", async (ILockerRepository repo)=>await repo.GetAllAsync());
            group.MapGet("/{id}",async (ILockerRepository repo,string id)=>await repo.GetAsync(id));
            group.MapPost("/",async (ILockerRepository repo, LockerListDto listDto)=>{
                LockerList newList = new(){
                    id = Guid.NewGuid().ToString(),
                    semester = listDto.semester,
                    l_list = listDto.l_list
                };
                await repo.AddAsync(newList);
            });
            group.MapPut("/{id}",async(ILockerRepository repo,LockerList newList,string id)=> await repo.UpdateAsync(id,newList));
            group.MapDelete("/{id}",async(ILockerRepository repo,string id)=>await repo.DeleteAsync(id));
            return group;
        }
    }
}