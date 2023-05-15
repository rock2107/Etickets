﻿using Etickets.Models;
using System.Linq.Expressions;

namespace Etickets.Data.Services
{
    public interface IActorService
    {
        Task<IEnumerable<Actor>> GetAllAsync();

        Task<Actor> GetByIdAsync(int id );
      
        Task AddAsync(Actor actor);

       Task< Actor> UpdateAsync(int id,Actor newActor);
       Task  DeleteAsync(int id);
 
    }
}
