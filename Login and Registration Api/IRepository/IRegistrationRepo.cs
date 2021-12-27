using LoginRegistrationApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegistrationApi.IRepository
{
    public interface IRegistrationRepo
    {
        public Task<ActionResult<List<Registration>>> GetAllUser();
        public Task<ActionResult<Registration>> GetSingleUser(int Id);
        public Task<ActionResult<List<Registration>>> AddUser(Registration registration);
        public Task<ActionResult<List<Registration>>> DeleteUser(int Id);
        Task<ActionResult<Registration>> UpdateUser(Registration request);
    }
}
