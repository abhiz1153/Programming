using Common.Models;
using System.Threading.Tasks;

namespace BussinessManager.Interface
{
    public interface IAccount
    {
        Task<string> RegistrationAsync(UserModel userModels);
        Task<string> LoginAsync(LoginModel loginModel);
    }
}
