using Microsoft.AspNetCore.Mvc;
using WebAppMasraf.Models;

namespace WebAppMasraf.Controllers
{
    public class UserController:Controller
    {
     
            private readonly Masraf_DBContext dbContext;

            public UserController(Masraf_DBContext dbContext)
            {
                this.dbContext = dbContext;
            }
            [HttpGet]
            public IActionResult Add()
            {
                return View();
            }
            [HttpPost]
            public async Task<IActionResult> Add(User addUserRequest)
            {
                var user = new User()
                {
                    UId = addUserRequest.UId,
                    UEmail = addUserRequest.UEmail,
                    UDateTime= addUserRequest.UDateTime,
                    UName = addUserRequest.UName,
                    UPasword = addUserRequest.UPasword,
                    UPhoneNumber = addUserRequest.UPhoneNumber,
                    USurname = addUserRequest.USurname,
                    UUserRole = addUserRequest.UUserRole,
                    UUserRoleId = addUserRequest.UUserRoleId,



                };
                await dbContext.Users.AddAsync(user);
                await dbContext.SaveChangesAsync();
                return RedirectToAction("Add");
            }
        }
    }