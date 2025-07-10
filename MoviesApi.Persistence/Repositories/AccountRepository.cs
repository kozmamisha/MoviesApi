using MoviesApi.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static MoviesApi.Core.Entities.AccountEntity;

namespace MoviesApi.Persistence.Repositories
{
    public class AccountRepository
    {
        private static IDictionary<string, AccountEntity> Accounts { get; set; } = new Dictionary<string, AccountEntity>();

        public void Add(AccountEntity account)
        {
            Accounts[account.UserName] = account;
        }

        public AccountEntity? GetByUserName(string userName)
        {
            Accounts.TryGetValue(userName, out var account);
            return account;
        }

        public ICollection<Permission> GetPermissionByUserName(string userNameValue)
        {
            return GetByUserName(userNameValue).Permissions;
        }
    }
}
