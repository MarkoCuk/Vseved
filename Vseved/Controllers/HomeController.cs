using Vseved.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Vseved.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            if (User.IsInRole("Administrators"))
            {
                ViewBag.Administrator = "Administrator";
            }
            if (User.IsInRole("Teachers"))
            {
                ViewBag.Teacher = "Teacher";
            }
            if (User.IsInRole("Students"))
            {
                ViewBag.Student = "Student";
            }
            return View();
        }

        #region OBSOLETE
        //public ActionResult About()
        //{
        //    ViewBag.Message = "Your application description page.";

        //    return View();
        //}

        //public ActionResult Contact()
        //{
        //    #region IDENTITY
        //    var roleManager = new RoleManager<Microsoft.AspNet.Identity.EntityFramework.IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

        //    String roleStr = "Students";

        //    if (!roleManager.RoleExists(roleStr))
        //    {
        //        Debug.WriteLine("Creating new role! " + roleStr);
        //        var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //        role.Name = roleStr;
        //        roleManager.Create(role);
        //    }
        //    else
        //    {
        //        Debug.WriteLine("Role exists!");
        //    }

        //    //roleStr = "Administrators";

        //    //if (!roleManager.RoleExists(roleStr))
        //    //{
        //    //    Debug.WriteLine("Creating new role! " + roleStr);
        //    //    var role = new Microsoft.AspNet.Identity.EntityFramework.IdentityRole();
        //    //    role.Name = roleStr;
        //    //    roleManager.Create(role);
        //    //}
        //    //else
        //    //{
        //    //    Debug.WriteLine("Role exists!");
        //    //}


        //    var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(new ApplicationDbContext()));
        //    var RoleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

        //    var user = new ApplicationUser();
        //    roleStr = "Students";
        //    user.UserName = "student@school.com";
        //    var adminresult = UserManager.Create(user, "Student1#");

        //    if (adminresult.Succeeded)
        //    {
        //        var result = UserManager.AddToRole(user.Id, roleStr);
        //        Debug.WriteLine("Creating user " + user.UserName + " to " + roleStr);
        //    }

        //    //user = new ApplicationUser();
        //    //roleStr = "Teachers";
        //    //user.UserName = "teacher@school.com";
        //    //adminresult = UserManager.Create(user, "Teacher1#");

        //    //if (adminresult.Succeeded)
        //    //{
        //    //    var result = UserManager.AddToRole(user.Id, roleStr);
        //    //    Debug.WriteLine("Creating user " + user.UserName + " to " + roleStr);
        //    //}
        //    #endregion

        //    ViewBag.Message = "Your contact page.";

        //    return View();
        //}

        //public ActionResult Stuff(String input, String number)
        //{
        //    int result;

        //    if (!int.TryParse(number, out result))
        //    {
        //        return View();
        //    }

        //    ViewBag.Message = "Potatoes.";

        //    String test = "Krompir";

        //    Models.transfer tran = new Models.transfer();
        //    tran.stevilka = result;
        //    tran.beseda = input;

        //    List<String> sez = new List<String>();

        //    for (int i = 0; i < tran.stevilka; i++)
        //    {
        //        sez.Add("Beseda" + i);
        //    }

        //    tran.seznam = sez;

        //    return View(tran);
        //}
        #endregion
    }
}