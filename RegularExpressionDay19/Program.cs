namespace RegularExpressionDay19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Regular Expression Programs");
            Console.WriteLine("Please enter the option given below");           //Taking user input
            Console.WriteLine("1:Create first name\n2:Create last name");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)             //using switch case calling different method
            {
                case 1:
                    RegularExpression.fisrtName();
                    break;
                case 2:
                    RegularExpression.lastName();
                    break;
                default:
                    break;
            }
        }
    }
}