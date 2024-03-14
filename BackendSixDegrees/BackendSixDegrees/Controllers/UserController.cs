using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CapaNegocio.Features.User.Queries.GetUsers;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BackendSixDegrees.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [Route("GetUsers")]
        [HttpGet]
        public async Task<ActionResult<ResponseGetUserVm>> GetUsers()
        {
            try
            {
                var response = await _mediator.Send(new GetUserQuery());
                return Ok(response);
            }
            catch (Exception ex)
            {
               return BadRequest($"Error al procesar la solicitud: {ex.Message}");
            }
        }
    }
}
