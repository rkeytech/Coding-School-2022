using FuelStation.Blazor.Shared;
using FuelStation.EF.Repositories;
using FuelStation.Model.Entities;
using Microsoft.AspNetCore.Mvc;

namespace FuelStation.Blazor.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UtilityController : ControllerBase
    {
        private readonly IEntityRepo<User> _userRepo;

        public UtilityController(IEntityRepo<User> userRepo)
        {
            _userRepo = userRepo;
        }

        [HttpPost("auth")]
        public async Task<UserAuthenticatedViewModel> Post(UserToAuthViewModel user)
        {
            var users = await _userRepo.GetAllAsync();
            var foundUser = users.SingleOrDefault(u => u.Username == user.Username && 
                                                      u.Password == user.Password);
            if (foundUser is not null)
            {
                return new UserAuthenticatedViewModel()
                {
                    Username = foundUser.Username,
                    EmployeeType = foundUser.Employee.EmployeeType
                };
            }
            return new UserAuthenticatedViewModel();
        }
    }
}
