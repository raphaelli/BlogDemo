using System.Threading.Tasks;

namespace BlogDemo.Core.interfaces
{
    public interface IUnitOfWork
    {
        Task<bool> SaveAsync();
    }
}