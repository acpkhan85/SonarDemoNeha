using mysql.Domain.Entities;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace mysql.Application.Contracts.Persistence
{
    public interface ICategoryRepository : IAsyncRepository<Category>
    {
        Task<List<Category>> GetCategoriesWithEvents(bool includePassedEvents);
        Task<Category> AddCategory(Category category);
    }
}
