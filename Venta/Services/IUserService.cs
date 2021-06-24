using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Venta.Models.Request;
using Venta.Models.Response;

namespace Venta.Services
{
    public interface IUserService
    {
        UserResponse Auth(AuthRequest model);
    }
}
