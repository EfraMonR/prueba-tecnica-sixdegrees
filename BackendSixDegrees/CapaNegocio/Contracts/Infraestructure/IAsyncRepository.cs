using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Contracts.Infraestructure
{
    public interface IAsyncRepository<T> where T : class
    {
        Task<IReadOnlyList<T>> ListAllAsync();
    }
}
