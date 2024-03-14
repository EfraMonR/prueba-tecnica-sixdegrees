using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Features.User.Queries.GetUsers
{
    public class ResponseGetUserVm
    {
        public decimal UsuID { get; set; }
        public string? Nombre { get; set; }
        public string? Apellido { get; set; }
    }
}
