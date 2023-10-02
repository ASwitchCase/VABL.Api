using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using VABL.Api.Repositories;

namespace VABL.Api.Routes
{
    public static class UserRoutes
    {
        public static RouteGroupBuilder MapUserListRoutes(this IEndpointRouteBuilder routes){
            var group = routes.MapGroup("/users");

            group.MapGet("/",async (IUserRepository repo) => await repo.GetAllAsync() );

            return group;
        }
    }
}