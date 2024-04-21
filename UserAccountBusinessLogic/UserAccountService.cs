using UserAccountDataServices;


namespace UserAccountBusinessLogic
{
    public class UserAccountService
    {
        public bool VerifyUserAccount(string userID, string userName, string password)
        {
            UserAccountDataService dataService = new UserAccountDataService();
            var result = dataService.GetUser(userID, userName, password);

            return result.UserID != null;
            return result.UserName != null;
            return result.Password != null;


        }
    }
}