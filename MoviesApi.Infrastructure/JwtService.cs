using Microsoft.Extensions.Options;
using MoviesApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Infrastructure
{
    public class JwtService(IOptions<AuthSettings> options)
    {
        //public string GenerateToken(AccountEntity account)
        //{
        //    var jwtToken = new JwtSecurityToken(
        //        expires: DateTime.UtcNow);
        //}
    }
}
