using Common.Models.AdminModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FundooRepository.Interface
{
    public interface IAdminRepository
    {
        Task AddAdmin(AdminLoginModel adminLogin);
        Task<string> AdminLogin(AdminLoginModel adminLogin);
        List<AdminModel> GetList();
    }
}
