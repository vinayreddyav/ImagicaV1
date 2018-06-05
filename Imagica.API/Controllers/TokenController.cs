using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using AutoMapper.Configuration;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Tralive.API.Application.Models;
using Microsoft.Extensions.Configuration;

namespace Tralive.API.Controllers
{
    [Produces("application/json")] 
    [Route("api/User")]
    public class TokenController : Controller
    {
        private Microsoft.Extensions.Configuration.IConfiguration _config;

        public TokenController(Microsoft.Extensions.Configuration.IConfiguration config)
        {
            _config = config;
        }

        //[AllowAnonymous]
        //[HttpPost]
        //public IActionResult Login([FromBody] User loginCredentials)
        //{
        //    if (loginCredentials == null)
        //        return Unauthorized();

        //    var claims = new[]
        //    {
        //        new Claim(JwtRegisteredClaimNames.Sub, loginCredentials.EmailId),
        //        new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString())
        //    };

        //    var token = new JwtSecurityToken
        //    (
        //        issuer: _config["Issuer"],
        //        audience: _config["Audience"],
        //        claims: claims,
        //        expires: DateTime.UtcNow.AddDays(60),
        //        notBefore: DateTime.UtcNow,
        //        signingCredentials: new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["SigningKey"])),
        //                SecurityAlgorithms.HmacSha256)
        //    );

        //    return Ok(new { token = new JwtSecurityTokenHandler().WriteToken(token) });

        //}
        ////return BadRequest();

        [AllowAnonymous]
        [HttpPost]
        public IActionResult CreateToken([FromBody]LoginModel login)
        {
            IActionResult response = Unauthorized();
            var user = Authenticate(login);

            if (user != null)
            {
                var tokenString = BuildToken(user);
                response = Ok(new { token = tokenString });
            }

            return response;
        }

        private string BuildToken(UserModel user)
        {
            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(_config["Jwt:Issuer"],
              _config["Jwt:Issuer"],
              //no need of timeout
              expires: DateTime.Now.AddYears(1),
              signingCredentials: creds);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        private UserModel Authenticate(LoginModel login)
        {
            UserModel user = null;

            
            if ((login.Email == "tralive@socgen.com" || login.Email == "admin@socgen.com") && login.Password == "Tralive@2018")
            {
                user = new UserModel { Name = "Administrator", Email = "tralive@socgen.com" };
            }
            
            return user;
        }

        public class LoginModel
        {
            public string Username { get; set; }
            public string Password { get; set; }
            public string Email { get; set; }
        }

        private class UserModel
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public DateTime Birthdate { get; set; }
        }

    }
}