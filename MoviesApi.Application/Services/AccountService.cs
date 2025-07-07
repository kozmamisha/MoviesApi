using Microsoft.AspNetCore.Identity;
using MoviesApi.Core.Entities;
using MoviesApi.Persistence.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MoviesApi.Application.Services
{
    public class AccountService(AccountRepository accountRepository)
    {
        public void Register(string userName, string firstName, string password)
        {
            var account = new AccountEntity
            {
                UserName = userName,
                FirstName = firstName,
                Id = Guid.NewGuid()
            };

            var hashedPassword = new PasswordHasher<AccountEntity>().HashPassword(account, password);
            account.PasswordHash = hashedPassword;

            accountRepository.Add(account);
        }

        public void Login(string userName, string password)
        {
            var account = accountRepository.GetByUserName(userName);
            var result = new PasswordHasher<AccountEntity>()
                .VerifyHashedPassword(account, account.PasswordHash, password);

            if (result == PasswordVerificationResult.Success)
            {
                
            } else
            {
                throw new Exception("Unauthorized");
            }
        }
    }
}
