using System;



namespace BankAccout
{
    class MainClass
    {
        class bank
        {
            double balance = 10000;
            public double _balance
            {
                get { return balance; }
                set { balance = value; }
            }
        }
        class bankFunction
        {
            bank i = new bank();
            string name;
            int account;
            double withDraw, deposit, totalBalance;

            public void FunctionOne()
            {
                Console.WriteLine("Enter Name Of The Depositor : ");
                name = Console.ReadLine();

                Console.WriteLine("Enter Account Number : ");
                account = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter Deposit Amount : ");
                deposit = int.Parse(Console.ReadLine());
                totalBalance = i._balance + deposit;

                Console.WriteLine("-----------------------------------\n");
                Console.WriteLine("Name of the depositor : {0}",name);
                Console.WriteLine("Account Number : {0}", account);
                Console.WriteLine("Total Balance amount in the account  : {0}",totalBalance);

            }

            public void functionTwo()
            {
                Console.WriteLine("Enter Account Name : ");
                name = Console.ReadLine();
                Console.WriteLine("Enter Account Number : ");
                account = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter Withdraw Amount : ");
                withDraw = double.Parse(Console.ReadLine());

                if(withDraw <= i._balance)
                {
                    totalBalance = i._balance - withDraw;
                    Console.WriteLine("--------------------------------\n");
                    Console.WriteLine("Account Name : {0}", name);
                    Console.WriteLine("Account Number : {0}", account);
                    Console.WriteLine("The new balance is : {0}", totalBalance);

                }
                else
                    Console.WriteLine("\n You Don't Have Enough");
            }

        }
        class Program
        {
            static void Main(string[] args)
            {
                char start;

                do
                {
                    bankFunction newAccount = new bankFunction();
                    int num;
                    Console.WriteLine("Please a Funtion");
                    Console.WriteLine("Press 1 for Deposit an Amount\nPress 2 for Withdraw an Amount");
                    num = int.Parse(Console.ReadLine());
                    switch (num)
                    {
                        case 1:
                            newAccount.FunctionOne();
                            break;
                        case 2:
                            newAccount.functionTwo();
                            break;
                        default:
                            Console.WriteLine("Invalid Selection");
                            break;

                    }
                    Console.WriteLine("Do you wamt to wamt to continue this program (y/n");
                    start = char.Parse(Console.ReadLine());
                        
                } while (start == 'y');

                Console.ReadKey();


            }



        }
    }
}