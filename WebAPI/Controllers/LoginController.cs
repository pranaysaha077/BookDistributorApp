using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        public LoginController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        [HttpPost]
        public IActionResult Login([FromBody] Login login)
        {
            if (!(login.UserName == _configuration["JwtAuth:UserName"]
                && login.Password == _configuration["jwtAuth:Password"])) return Unauthorized();

            var userClaims = new List<Claim>();

            if (login.Role?.ToLower() is "admin" or "user")
            {
                userClaims.Add(new Claim(ClaimTypes.Role, login.Role));
            }
            return Ok(new JWTResponse
            {
                Token = new JwtSecurityTokenHandler().WriteToken(
                    new JwtSecurityToken(

                            issuer: _configuration["JwtAuth:Issuer"],
                            audience: _configuration["JwtAuth:Issuer"],
                            claims: userClaims,
                            expires: DateTime.Now.AddMinutes(5),
                            signingCredentials: new SigningCredentials(
                                key: new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JwtAuth:Key"])),
                        algorithm: SecurityAlgorithms.HmacSha256)
                        ))
            });

        }
    }
}
