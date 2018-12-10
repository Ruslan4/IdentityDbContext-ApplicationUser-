using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BestLib.Models.Models;

namespace BestLibrary.DAL.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IRepository<ClientProfile> ClientProfiles { get; }
        //IRepository<Book> Books { get; }
        //IRepository<IssuanceOfBooks> IssuanceOfBooks { get; }
        //IRepository<CatalogBooks> CatalogBooks { get; }
        void Save();
    }
}
