using BussinessManager.Interface;
using Common.Models;
using FundooRepository.Interface;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BussinessManager.Manager
{
    public class AccountManager : IAccount
    {
        private readonly IAccountRepository accountRepository;
        public AccountManager() { }
        public AccountManager(IAccountRepository accountRepository)
        {
            this.accountRepository = accountRepository;
        }
        public async Task<string> RegistrationAsync(UserModel userModels)
        {
            try
            {
                await this.accountRepository.CreateAsync(userModels);
                return "USER ADDED SUCCESSFULLY";
            }
            catch(Exception e)
            {
                throw new Exception(e.Message);
            }
           
        }
        public async Task<string> LoginAsync(LoginModel loginModel)
        {
            var result = await this.accountRepository.LoginAsync(loginModel);
            return result;
        }
    }
}
