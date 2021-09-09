using System.Collections.Generic;

namespace WebAPI.Repositories
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
    }
}
