using ASPCoreSample.Models;
using System.Collections.Generic;

namespace ASPCoreSample.Repository
{
    public interface IRepository<T> where T : BaseEntity
    {
        T FindByID(int id);
        IEnumerable<T> FindAll();
    }
}
