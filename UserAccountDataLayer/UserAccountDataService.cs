using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UserAccountModel;

namespace UserAccountDataServices
{
    public class UserAccountDataService
    {
        List<UserAccount> dummyUsers = new List<UserAccount>();

        public UserAccountDataService()
        {
            CreateDummyData();
        }

        private void CreateDummyData()
        {

            UserAccount user1 = new UserAccount { UserID = "BN-0-00258-2022", UserName = "VanessaRamos", Password = "2003" };
            UserAccount user2 = new UserAccount { UserID = "BN-0-00259-2022", UserName = "VeronicaRamos", Password = "2004" };
            UserAccount user3 = new UserAccount { UserID = "BN-0-00260-2022", UserName = "ValetinRamos", Password = "2005" };

            dummyUsers.Add(user1);
            dummyUsers.Add(user2);
            dummyUsers.Add(user3);
        }

        public UserAccount GetUser(string userID, string userName, string password)
        {
            UserAccount foundUser = new UserAccount();

            foreach (var dummy in dummyUsers)
            {
                if (userID == dummy.UserID && userName == dummy.UserName && password == dummy.Password)
                {
                    foundUser = dummy;
                }
            }

            return foundUser;
        }
    }
}
