using Common.Models.AdminModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Interface
{
    public interface IAdmin
    {
         Task AddAdminAsync(AdminLoginModel adminLogin);
        Task<string> AdminLoginAsync(AdminLoginModel adminLogin);
        List<AdminModel> GetAllListAsync();
    }
}
