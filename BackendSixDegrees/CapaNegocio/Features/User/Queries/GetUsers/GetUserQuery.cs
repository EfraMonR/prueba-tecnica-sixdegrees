using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio.Features.User.Queries.GetUsers
{
    public class GetUserQuery : IRequest<List<ResponseGetUserVm>>
    {
    }
}
