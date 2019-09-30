using BussinessManager.Interface;
using Common.Models.AdminModels;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    public class AdminManager : IAdmin
    {
        private readonly IAdminRepository adminRepository;
        
        public AdminManager(IAdminRepository adminRepository)
        {
            this.adminRepository = adminRepository;
        }
        public Task AddAdminAsync(AdminLoginModel adminLogin)
        {
            try
            {
                 var result = this.adminRepository.AddAdmin(adminLogin);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public async Task<string> AdminLoginAsync(AdminLoginModel adminLogin)
        {
            try
            {
                var result = await this.adminRepository.AdminLogin(adminLogin);
                return result;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
        public List<AdminModel> GetAllListAsync()
        {
            try
            {
                var list = new List<AdminModel>();
                var result = this.adminRepository.GetList();
                foreach (var item in result)
                {
                    list.Add(item);
                }
                return list;
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
