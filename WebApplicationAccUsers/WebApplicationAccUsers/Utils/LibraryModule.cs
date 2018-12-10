using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Library.BIL.Interfaces;
using Library.BIL.Services;
using Ninject.Modules;

namespace WebApplicationAccUsers.Utils
{
    public class LibraryModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IUserService>().To<UserService>();
        }
    }
}