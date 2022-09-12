using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMasraf.Controllers
{


    public class AccountController : Controller
    {

        public ActionResult Login()
        {
        }

        [Authorize]
        public ActionResult Logout()
        {
        }
    }
}