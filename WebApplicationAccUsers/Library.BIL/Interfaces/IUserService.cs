using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Library.BIL.DTO;
using Library.BIL.Infrastructure;

namespace Library.BIL.Interfaces
{
    public interface IUserService
    {
        Task<OperationDetails> Create(ClientProfileDto clientProfileDto);
        Task<ClaimsIdentity> Authenticate(ClientProfileDto clientProfileDto);
        Task SetInitialData(ClientProfileDto adminDto, List<string> roles);
    }
}
