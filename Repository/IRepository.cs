using ASPCoreSample.Models;
using System.Collections.Generic;

namespace ASPCoreSample.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        IEnumerable<T> FindAll();
    }
}
