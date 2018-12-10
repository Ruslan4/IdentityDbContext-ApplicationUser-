using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestLib.Models.Models;
using BestLibrary.DAL.EF_Context;
using BestLibrary.DAL.Interfaces;

namespace BestLibrary.DAL.Repositories
{
    public class ClientManager : IClientManager
    {
        public ApplicationDbContext Database { get; set; }
        public ClientManager(ApplicationDbContext db)
        {
            Database = db;
        }

        public void Create(ClientProfile item)
        {
            Database.ClientProfile.Add(item);
            Database.SaveChanges();
        }

        public void Dispose()
        {
            Database.Dispose();
        }
    }
}
