using AutoMapper;
using CapaNegocio.Contracts.Infraestructure;
using Entidades.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CapaNegocio.Features.User.Queries.GetUsers
{
    public class GetUserQueryHandler : IRequestHandler<GetUserQuery, List<ResponseGetUserVm>>
    {
        private readonly IAsyncRepository<Usuario> _repository;
        private readonly IMapper _mapper;

        public GetUserQueryHandler(IMapper mapper, IAsyncRepository<Usuario> repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<ResponseGetUserVm>> Handle(GetUserQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var allUsers = (await _repository.ListAllAsync());
                return _mapper.Map<List<ResponseGetUserVm>>(allUsers);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
