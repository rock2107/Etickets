using Etickets.Models;
using Microsoft.EntityFrameworkCore;


namespace Etickets.Data.Services
{
    public class ActorService : IActorService
    {
        private readonly AppDbContext _context;
        public ActorService(AppDbContext context)
        {
            _context = context;
           


        }

        public async Task AddAsync(Actor actor)
        {
           await _context.Actors.AddAsync(actor);
          await  _context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var Results = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
          _context.Actors.Remove(Results);
            await _context.SaveChangesAsync();
        }

        public async Task<IEnumerable<Actor>>GetAllAsync()
        {
            var result = await _context.Actors.ToListAsync();
            return result;
        }

        public async Task<Actor> GetByIdAsync(int id)
        {
       var  Results = await _context.Actors.FirstOrDefaultAsync(x => x.Id == id);
            return Results ;


        }

        public async Task<Actor> UpdateAsync(int Id, Actor newActor)
        {
            _context.Update(newActor);
            await _context.SaveChangesAsync();
            return newActor;
        }
         
        
    }
}
