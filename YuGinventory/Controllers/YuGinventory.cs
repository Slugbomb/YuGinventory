using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using YuGinventory.Models;
using System.Web.Mvc;

namespace YuGinventory.Controllers
{
    public class YuGinventoryController : Microsoft.AspNetCore.Mvc.Controller
    {
        //private readonly YuGinventoryContext _context;

        // GET: /<controller>/
        public IActionResult Index(string id)
        {
            return View();
        }

        public int SearchUserId(String nameSearchStr)
        {
            var context = new YuGinventoryContext(); 
            var u = GetUserForName(nameSearchStr);
            if (u != null)
            {
                return u.ID;
            }
            return -1;
        }

        public void CreateUser(String userNameStr)
        {
            if (SearchUserId(userNameStr) == -1)
            {
                //Error for existing user with that name.
                return;
            }

            RedirectToAction("Create", "User", new { userName = userNameStr });
        }
    }
}