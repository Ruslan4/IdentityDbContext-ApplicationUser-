using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestLibrary.DAL.EF_Context;
using BestLibrary.DAL.Identity;
using BestLibrary.DAL.Interfaces;

namespace BestLibrary.DAL.Repositories
{
    public class IdentityUnitOfWork: IUnitOfWorkUser
    {
        private ApplicationDbContext db;

        public IdentityUnitOfWork()
        {
            db = new ApplicationDbContext();
        }

        

        public ApplicationUserManager UserManager => throw new NotImplementedException();

        public IClientManager ClientManager => throw new NotImplementedException();

        public ApplicationRoleManager RoleManager => throw new NotImplementedException();

        public async Task SaveAsync()
        {
            await db.SaveChangesAsync();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }
    }
}
