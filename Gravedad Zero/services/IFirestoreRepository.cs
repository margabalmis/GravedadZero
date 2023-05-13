using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gravedad_Zero.services
{
    public interface IFirestoreRepository<T>
    {
        T Get(T record);
    }
}
