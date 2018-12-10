using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.BIL.Interfaces
{
    //воспользуюсь абстрактной фабрикой, которую будет представлять интерфейс IServiceCreator.
    public interface IServiceCreator
    {
        IUserService CreateUserService();
    }
}
