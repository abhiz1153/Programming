using Common.Models;
using Microsoft.AspNetCore.Identity;
using System.Threading.Tasks;

namespace FundooRepository.Interface
{
    public interface IAccountRepository
    {
        Task CreateAsync(UserModel usedrModel);
        Task LoginAsync(LoginModel loginModel);
        Task<bool> CheckPasswordAsync(string email,string password);
        Task<IdentityUser> FindByEmailAsync(string email);
    }
}
