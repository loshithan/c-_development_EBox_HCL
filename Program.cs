namespace AccountDetails
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter User Details(HolderName,Account Number,IFSC code,Contact Number)");
            string[] strArr = Console.ReadLine().Split(",").ToArray();
            Console.WriteLine("Enter Account Type");
            string ch = Console.ReadLine();

            if (ch == "saving")
            {
                Console.WriteLine("Enter Interest Rate");
                 double intRate = double.Parse(Console.ReadLine());

                SavingAccount savingAccount = new SavingAccount(strArr[0], Int64.Parse(strArr[1]), strArr[2], Int64.Parse(strArr[3]),intRate);
                savingAccount.Display();
                
            }
            else if(ch == "current")
            {
                Console.WriteLine("Enter organization Name");
                string orgName = Console.ReadLine();
                Console.WriteLine("Enter TIN number");
                long tinNum = Int64.Parse(Console.ReadLine());

                CurrentAccount currentAccount = new CurrentAccount(strArr[0], Int64.Parse(strArr[1]), strArr[2], Int64.Parse(strArr[3]),orgName,tinNum);
                currentAccount.Display();

            }
            else
            {
                Console.WriteLine("Enter valid Account Type");
            }

        }
    }
}