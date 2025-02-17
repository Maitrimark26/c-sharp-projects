using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATMapp
{
    internal class cardHolder
    {
        string cardNum;
        int pin;
        string firstName;
        string lastName;
        double balance;
        public cardHolder(string cardNum,int pin,string firstName,string lastName,double balance) {
        this.cardNum=cardNum;
        this.pin=pin;
        this.firstName = firstName;
        this.lastName = lastName;
        this.balance= balance;
        }
        public string getNum()
        {
            return cardNum; 
        }
        public int getPin()
        {
            return pin;
        }
        public string getFirstName()
        {
            return firstName;
        }
        public string getLastName()
        {
            return lastName;
        }
        public double getBalance()
        {
            return balance;
        }
        public void setNum(string cardNum)
        {
            this.cardNum = cardNum.Trim();
        }
        public void setPin(int newpin) {
            this.pin = newpin;
                }
        public void setFirstName(string firstName) {
            this.firstName = firstName.Trim();
        }
        public void setLastName(string lastName)
        {
            this.lastName = lastName.Trim();
        }
        public void setBalance(double newbalance)
        {
            this.balance = newbalance;
        }

        public static class ATM {
            public static void printOptions()
            {
                Console.WriteLine("Please choose from one of the options");
                Console.WriteLine("1.Deposit");
                Console.WriteLine("2.WithDraw");
                Console.WriteLine("3.Show Balance");
                Console.WriteLine("4.Exit");
            }
            public static void deposit(cardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you want to deposit");
                double depoit = Double.Parse(Console.ReadLine());
                currentUser.setBalance(currentUser.getBalance() + depoit);
                Console.WriteLine("Thankyou for your $$. Your new balance is " + currentUser.getBalance());

            }
            public static void withdraw(cardHolder currentUser)
            {
                Console.WriteLine("How much $$ would you want to withdraw");
                double withdaw = Double.Parse(Console.ReadLine());
                if (currentUser.getBalance() < withdaw)
                {
                    Console.WriteLine("Insufficient balance");
                }
                else
                {
                    currentUser.setBalance(currentUser.getBalance() - withdaw);
                    Console.WriteLine("You are good to go!!");
                    Console.WriteLine("Your current balance is " + currentUser.getBalance());
                }
            }

            public static void balance(cardHolder currentUser)
            {
                Console.WriteLine("Your current balance is " + currentUser.getBalance());
            }

        }

        static void Main(string[] args)
        {

            List<cardHolder> cardHolders = new List<cardHolder>();
            cardHolders.Add(new cardHolder("456789123145", 1234, "John", "Jesa", 150.34));
            cardHolders.Add(new cardHolder("456789123146", 4568, "Joe", "Tesa", 50.34));
            cardHolders.Add(new cardHolder("456789123143", 9632, "Rach", "Emma", 200.34));
            cardHolders.Add(new cardHolder("456789123141", 7894, "Mon", "Osmo", 1560.34));
            cardHolders.Add(new cardHolder("456789123144", 2589, "Ross", "Jett", 154150.34));

            Console.WriteLine("Wecome to ATM");
            Console.WriteLine("Please insert your debit card");
            string debitCardNum = "";
            cardHolder currentUser1;

            while (true)
            {
                try
                {
                    debitCardNum=Console.ReadLine();
                    currentUser1=cardHolders.FirstOrDefault(a=>a.cardNum==debitCardNum);
                    if(currentUser1 != null)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Card not recognized");
                    }
                }
                catch
                {
                    Console.WriteLine("Card not recognized. Please try again");
                }
            }



            Console.WriteLine("Please enter your pin");
            int userPin=0;
            

            while (true)
            {
                try
                {
                    userPin = int.Parse(Console.ReadLine());
                    
                    if (currentUser1.getPin() ==userPin)
                    {
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Incorrect pin.Please try agin ");
                    }
                }
                catch
                {
                    Console.WriteLine("Incorrect pin.Please try agin ");
                }
            }

            Console.WriteLine("Welcome "+currentUser1.getFirstName());
            int option = 0;
            do
            {
                ATM.printOptions();
                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch
                {

                }

                if(option == 1)
                {
                    ATM.deposit(currentUser1);
                }
                else if(option == 2)
                {
                    ATM.withdraw(currentUser1);
                }
                else if(option == 3)
                {
                    ATM.balance(currentUser1);
                }
                else if (option == 4)
                {
                    break;
                }
                else
                {
                    option = 0;
                }
            }
            while (option != 4);
            Console.WriteLine("Thank you ! have a nice day");

        }
    }
}
