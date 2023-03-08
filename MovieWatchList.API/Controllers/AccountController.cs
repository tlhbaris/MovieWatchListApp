//using Microsoft.AspNetCore.Http;
//using Microsoft.AspNetCore.Identity;
//using Microsoft.AspNetCore.Identity.UI.V4.Pages.Account.Manage.Internal;
//using Microsoft.AspNetCore.Mvc;
//using MovieWatchList.Business.Concrete;
//using MovieWatchList.Entities;

//namespace MovieWatchList.API.Controllers
//{
//    [Route("api/[controller]")]
//    [ApiController]
//    public class AccountController : ControllerBase
//    {
//        private readonly UserManager<User> _userManager;
//        private readonly RoleManager<IdentityRole> _roleManager;
//        private readonly IConfiguration _configuration;

//        public AccountController(
//            UserManager<User> userManager,
//            RoleManager<IdentityRole> roleManager,
//            IConfiguration configuration)
//        {
//            _userManager = userManager;
//            _roleManager = roleManager;
//            _configuration = configuration;
//        }



//        [HttpGet]
//        [Route("[action]")]
//        public async Task<IActionResult> ChangePassword(ChangePassword changePassword)
//        {

//            // Şu anda oturum açmış kullanıcının kimliği

//            var currentUserId = User.Claims.ToList()
//                .FirstOrDefault(x => x.Type == "id").Value ;


//            var user =await _userManager.FindByNameAsync(currentUserId);

//            await _userManager.ChangePasswordAsync(user, changePassword.CurrentPassword, changePassword.NewPassword);
//            return Ok();



//        }

//    }
//}
