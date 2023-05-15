



using Etickets.Models;

namespace eTickets.Data.Services
{
    public interface ICinemaService  
    {
        Task<IEnumerable<Cinema>> GetAllAsync();

        Task<Cinema> GetByIdAsync(int id);

        Task  AddAsync();

        Task<Cinema> UpdateAsync(int id, Cinema cinema);
        Task DeleteAsync(int id);

    }
}