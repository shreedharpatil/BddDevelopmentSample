using BddDevelopmentSample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BddDevelopmentSample.Login
{
    public interface ILoginProvider
    {
        void Login(LoginModel model);
    }
}
