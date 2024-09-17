using Ecommerce.Domain.Entities;

namespace Ecommerce.Application.Interfaces.Repositories
{
    public interface IStadiumRepository
    {
        Task<List<Stadium>> GetStadiumByCityAsync(string cityName);
    }
}
