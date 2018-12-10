using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestLib.Models.Models;
using BestLibrary.DAL.EF_Context;
using BestLibrary.DAL.Interfaces;

namespace BestLibrary.DAL.Repositories
{
    public class UserRepository : IRepository<ClientProfile>
    {
        private ApplicationDbContext db;

        public UserRepository(ApplicationDbContext context)
        {
            this.db = context;
        }

        public IEnumerable<ClientProfile> GetAll()
        {
            return db.ClientProfile.Include(o => o.Id);
        }

        public ClientProfile Get(int id)
        {
            return db.ClientProfile.Find(id);
        }

        public void Create(ClientProfile clientProfile)
        {
            db.ClientProfile.Add(clientProfile);
        }

        public void Update(ClientProfile clientProfile)
        {
            db.Entry(clientProfile).State = EntityState.Modified;
        }

        public IEnumerable<ClientProfile> Find(Func<ClientProfile, Boolean> predicate)
        {
            return db.ClientProfile.Include(o => o.Id).AsEnumerable().Where(predicate).ToList();
        }

        public void Delete(int id)
        {
            ClientProfile clientProfile = db.ClientProfile.Find(id);
            if (clientProfile != null)
                db.ClientProfile.Remove(clientProfile);
        }
    }
}
