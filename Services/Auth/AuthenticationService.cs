using sampleAPI.IServices.Auth;
using sampleAPI.Utilities;


namespace sampleAPI.Services.Auth
{
    public class AuthService: IAuthService
    {
        private Authentication _authUtility;
        public AuthService(Authentication authUtility)
        {
            _authUtility = authUtility;
        }
        public object GenerateToken(int id)
        {
           var token = _authUtility.GenerateNewToken(id);
            return new { Token = token};
        }
    }
}
