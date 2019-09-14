using Common.Models;
using FundooRepository.DBContext;
using FundooRepository.Interface;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;
using System.Linq;
using Microsoft.IdentityModel.Tokens;
using System.Security.Claims;
using System;
using System.IdentityModel.Tokens.Jwt;

namespace FundooRepository.Repository
{
    public class AccountRepository : IAccountRepository
    {
        private readonly UserContext userContext;
        public AccountRepository(UserContext userContext)
        {
            this.userContext = userContext;
        }
        public Task CreateAsync(UserModel userModels)
        {
            UserModel userDBModel = new UserModel()
           
            {               
                FirstName = userModels.FirstName,
                LastName = userModels.LastName,
                Email = userModels.Email,              
                City = userModels.City,
                Password = userModels.Password
            };
            userContext.Register.Add(userDBModel);
            return Task.Run(()=>userContext.SaveChanges());
        }
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var result = await this.FindByEmailAsync(loginModel.Email);
            if (result != null && await this.CheckPasswordAsync(loginModel.Email, loginModel.Password))
            {
                try
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                       {
                           new Claim("Email", result.Email)
                       }),
                        Expires = DateTime.UtcNow.AddDays(1),
                        //  SigningCredentials =  new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(this.appsettings.JWT_Secret)),SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    var token = tokenHandler.WriteToken(securityToken);
                    //   var cacheKey = loginModels.Email;
                    return token;
                }
                catch (Exception e)
                {
                    throw new Exception(e.Message);
                }

            }
            return "invalid email or password";

        }
        public  Task<bool> CheckPasswordAsync(string email,string password)
        {
            bool result = userContext.Register.Where(p => p.Password == password && p.Email == email).SingleOrDefault().Password != null ? true : false;
            return Task.Run(() => result);
        }
        public Task<IdentityUser> FindByEmailAsync(string email)
        {
            UserModel user = userContext.Register.Where(r => r.Email == email).SingleOrDefault();
            IdentityUser identityUser = new IdentityUser()
            {
                Email = user.Email
            };
            return Task.Run(() => identityUser);
        }

        Task IAccountRepository.LoginAsync(LoginModel loginModel)
        {
            throw new NotImplementedException();
        }
    }
}