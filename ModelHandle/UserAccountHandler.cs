using ModelDatabase;
using ModelDatabase.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModelHandle
{
    public class UserAccountHandler: ApplicationDbContext
    {
       public UserAccount FindUser(string UserName)
        {
            UserAccount result = UserAccount.Where(user => user.UserName == UserName).FirstOrDefault();
            return result;
        }
        public async Task<bool> CreateUser(UserAccount user)
        {
            try
            {
                await UserAccount.AddAsync(user);
                await SaveChangesAsync();
            }
            catch(Exception err)
            {
                Console.WriteLine(err);
                return false;
            }
            return true;
        }
        
    }
}
