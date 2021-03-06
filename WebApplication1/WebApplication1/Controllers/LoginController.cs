﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login   
        public ActionResult Login()
        {
            return View();
        }
        [AllowAnonymous]
        public ActionResult Index_Emp()
        {
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<ActionResult> Index_Emp(UserLogin datos)
        {
            if (ModelState.IsValid)
            {
                if (datos.login_Cli() == true)
                {
                    Session["C_USER"] = datos.C_USER;
                    return View();  
                }
                else
                {

                    return View("Login");
                }

            }
            else
            {
                return View("Login");
            }
        }
    
 

    }
}