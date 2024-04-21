using UserAccountBusinessLogic;


namespace UserAccountUi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Your UserID: ");
            string UserID = Console.ReadLine();

            Console.Write("Enter Your username: ");
            string UserName = Console.ReadLine();


            Console.Write("Enter Your password: ");
            string Password = Console.ReadLine();


            UserAccountService userService = new UserAccountService();
            bool result = userService.VerifyUserAccount(UserID, UserName, Password);

            if (result)
            {
                Console.WriteLine();
                Console.WriteLine("The Account has been Verified!");
            }

            else
            {
                Console.WriteLine("The was Not Found!Please Try Again.");
            }
        }
    }
}