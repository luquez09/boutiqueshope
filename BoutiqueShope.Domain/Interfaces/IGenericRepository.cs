using System.Threading.Tasks;
using BoutiqueShope.CrossCutting;

namespace BoutiqueShope.Domain.Interfaces
{
    public interface IGenericRepository<T>
    {
        Task<Response<T>> GetAllAsync();
        Task<Response<T>> GetByIdAsync(int id);
        Task<Response<T>> InsertAsync(T entity);
        Task<Response<T>> UpdateAsync(T entity);
        Task<Response<T>> DeleteAsync(int id);
    }
}
