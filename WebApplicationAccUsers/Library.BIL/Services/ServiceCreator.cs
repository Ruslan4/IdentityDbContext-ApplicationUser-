using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestLibrary.DAL.EF_Context;
using Library.BIL.Interfaces;
using BestLibrary.DAL.Repositories;

namespace Library.BIL.Services
{
    public class ServiceCreator : IServiceCreator
    {
        public IUserService CreateUserService()
        {
            var context = new ApplicationDbContext();
            return new UserService(new IdentityUnitOfWork());
        }
    }
}
