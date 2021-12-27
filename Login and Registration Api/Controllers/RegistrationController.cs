using LoginRegistrationApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegistrationApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistrationRepo _Context;
        public RegistrationController(IRegistrationRepo context)
        {
            _Context = context;
        }
        [HttpGet]
        public async Task<ActionResult<List<Registration>>> Get()
        {
            return await _Context.GetAllUser();
        }
        [HttpGet("SingleUser")]
        public async Task<ActionResult<Registration>> GetUser(int Id)
        {
            return await _Context.GetSingleUser(Id);
        }
        [HttpPost("AddUser")]
        public async Task<ActionResult<List<Registration>>> Post(Registration registration)
        {
            return await _Context.AddUser(registration);
        }
        [HttpDelete("DeleteUser")]
        public async Task<ActionResult<List<Registration>>> Delete(int id)
        {
            return await _Context.DeleteUser(id);
        }
        [HttpPut("UpdateUser")]
        public async Task<ActionResult<Registration>> Update(Registration registration)
        {
          return await _Context.UpdateUser(registration);
        }
    }

}
