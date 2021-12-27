using LoginRegistrationApi.Model;
using Microsoft.AspNetCore.Mvc;

namespace LoginRegistrationApi.Services
{
    public class RegistrationRepository : IRegistrationRepo
    {
        private readonly DataContext _Context;
        public RegistrationRepository(DataContext context)
        {
            _Context = context;
        }
        public async Task<ActionResult<List<Registration>>> GetAllUser()
        {
            return await _Context.Registrations.ToListAsync();
        }public async Task<ActionResult<Registration>> GetSingleUser(int Id)
        {
            return await _Context.Registrations.FindAsync(Id);
        }
        public async Task<ActionResult<List<Registration>>> AddUser(Registration registration)
        {
            _Context.Registrations.Add(registration);
            await _Context.SaveChangesAsync();
            return await _Context.Registrations.ToListAsync();
        }
        public async Task<ActionResult<Registration>> UpdateUser(Registration request)
        {
            var user = await _Context.Registrations.FindAsync(request.Id);
                user.Name = request.Name;
                user.UserName = request.UserName;
                user.Email = request.Email;
                user.MobileNo = request.MobileNo;   
                user.Password = request.Password;
                user.Address = request.Address;
            await _Context.SaveChangesAsync();
            return user;
        }
        public async Task<ActionResult<List<Registration>>> DeleteUser(int Id)
        {
            var user = await _Context.Registrations.FindAsync(Id);
            if (user == null)
                Console.WriteLine("Bad Request");
            _Context.Registrations.Remove(user);
            await _Context.SaveChangesAsync();
            return await _Context.Registrations.ToListAsync();
        }
    }
}
