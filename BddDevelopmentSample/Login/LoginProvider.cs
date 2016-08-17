using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BddDevelopmentSample.Models;

namespace BddDevelopmentSample.Login
{
    public class LoginProvider : ILoginProvider
    {
        public void Login(LoginModel model)
        {
            if (model.Username == "Test")
            {
                model.Message = "Success";
            }
            else if (model.Username == "Invalid usename") {
                model.Message = "Invalid Username";
            }
        }
    }
}