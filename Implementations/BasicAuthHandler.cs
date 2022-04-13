using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using System.Text;
using System.Text.Encodings.Web;

namespace EyeExamApi.Implementations
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        /// <summary>
        /// The index of the basic auth header token after "basic ".
        /// </summary>
        private const int TOKEN_START_INDEX = 6;

        public BasicAuthHandler(IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock) : base(options, logger, encoder, clock)
        {
        }


        /// <summary>
        /// Dummy custom auth handler, because minimal APIs regressed in this a bit.
        /// </summary>
        /// <returns></returns>
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            return await Task.Run(() =>
            {
                var header = Request.Headers["Authorization"].ToString();
                if (header?.Length > 0 && header.Contains("basic", StringComparison.InvariantCultureIgnoreCase))
                {
                    var authToken = header.Substring(TOKEN_START_INDEX).Trim();
                    var creds = Encoding.UTF8.GetString(Convert.FromBase64String(authToken)).Split(':');
                    if (creds.Length == 2 && creds.First() == "testy" && creds.Last() == "mcTestFace")
                    {
                        var claimsPrincipal = new ClaimsPrincipal(
                            new ClaimsIdentity(new List<Claim>()
                            {
                                new Claim(ClaimTypes.Role, "User")
                            }, "Basic")
                        );

                        return AuthenticateResult.Success(
                            new AuthenticationTicket(claimsPrincipal, Scheme.Name)
                        );
                    }
                }

                Response.StatusCode = StatusCodes.Status401Unauthorized;
                return AuthenticateResult.Fail("Invalid Authorization Header");
            });
        }
    }
}
