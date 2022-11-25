using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace sampleAPI.IServices.Auth
{
    public interface IAuthService
    {
        object GenerateToken(int id);
    }
}
