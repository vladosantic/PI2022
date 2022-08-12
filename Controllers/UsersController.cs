using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PI2022.Models;

namespace PI2022.Controllers
{
    public class UsersController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;

        public UsersController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }
        public async Task<IActionResult> Index()
        {
            var users = await _userManager.Users.ToListAsync();
            var userRolesViewModel = new List<Users>();
            foreach (IdentityUser user in users)
            {
                var thisViewModel = new Users();
                thisViewModel.UserName = user.UserName;
                thisViewModel.Email = user.Email;
                thisViewModel.PhoneNumber = user.PhoneNumber;
                userRolesViewModel.Add(thisViewModel);
            }
            return View(userRolesViewModel);
        }
    }
}
