using System.Runtime.CompilerServices;

namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 100;
            string choice = "z";
            while (balance > 0 && choice != "Q")
            {
                Console.WriteLine("You have $" + balance +" , how much would you like to bet?");
                int bet = Convert.ToInt32(Console.ReadLine());
                if (bet > balance)
                {
                    bet = balance;
                }
                else if (bet <= 0)
                {
                    bet = 0;
                }
                Console.WriteLine("You have chosen to bet $" + bet);
                Console.WriteLine("(a). Would you like to bet on doubles, 1/6 odds, winning x2 your bet back.\n(b). Would you like to bet on non doubles, 5/6 odds, winning half your bet back.\n(c). Would you like to bet on an even sum, 1/2 odds, winning your bet back.\n(d). Would you like to bet on an odd sum, 1/2 odds, winning your bet back.");
                Console.WriteLine("(Or type 'Q' to quit)");
                choice = Console.ReadLine();
                if (choice == "a" || choice == "A")
                {
                    Die die1;
                    Die die2;
                    die1 = new Die();
                    die2 = new Die();
                    die1.RollDie();
                    Console.WriteLine(die1);
                    die1.DrawRoll();
                    die2.RollDie();
                    Console.WriteLine(die2);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if (die1.Roll == die2.Roll)
                    {
                        balance = balance + (bet * 2);
                        Console.WriteLine("You win!");
                        Console.WriteLine("Your new balance is $" + balance);
                    }

                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("You lose.");
                        Console.WriteLine("Your new balance is $" + balance);
                    }
                }
                if (choice == "b" || choice == "B")
                {
                    Die die1;
                    Die die2;
                    die1 = new Die();
                    die2 = new Die();
                    die1.RollDie();
                    Console.WriteLine(die1);
                    die1.DrawRoll();
                    die2.RollDie();
                    Console.WriteLine(die2);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if (die1.Roll != die2.Roll)
                    {
                        balance = balance + (bet / 2);
                        Console.WriteLine("You win!");
                        Console.WriteLine("Your new balance is $" + balance);
                    }

                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("You lose.");
                        Console.WriteLine("Your new balance is $" + balance);
                    }





                }
                if (choice == "c" || choice == "C")
                {
                    Die die1;
                    Die die2;
                    die1 = new Die();
                    die2 = new Die();
                    die1.RollDie();
                    Console.WriteLine(die1);
                    die1.DrawRoll();
                    die2.RollDie();
                    Console.WriteLine(die2);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if (die1.Roll + die2.Roll == 2 || die1.Roll + die2.Roll == 4 || die1.Roll + die2.Roll == 6 || die1.Roll + die2.Roll == 8 || die1.Roll + die2.Roll == 10 || die1.Roll + die2.Roll == 12)
                    {
                        balance = balance + bet;
                        Console.WriteLine("You win!");
                        Console.WriteLine("Your new balance is $" + balance);
                    }

                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("You lose.");
                        Console.WriteLine("Your new balance is $" + balance);
                    }





                }
                if (choice == "d" || choice == "D")
                {
                    Die die1;
                    Die die2;
                    die1 = new Die();
                    die2 = new Die();
                    die1.RollDie();
                    Console.WriteLine(die1);
                    die1.DrawRoll();
                    die2.RollDie();
                    Console.WriteLine(die2);
                    die2.DrawRoll();
                    Console.WriteLine();

                    if (die1.Roll + die2.Roll != 2 || die1.Roll + die2.Roll != 4 || die1.Roll + die2.Roll != 6 || die1.Roll + die2.Roll != 8 || die1.Roll + die2.Roll != 10 || die1.Roll + die2.Roll != 12)
                    {
                        balance = balance + bet;
                        Console.WriteLine("You win!");
                        Console.WriteLine("Your new balance is $" + balance);
                    }

                    else
                    {
                        balance = balance - bet;
                        Console.WriteLine("You lose.");
                        Console.WriteLine("Your new balance is $" + balance);
                    }


                }
                if (balance == 0)
                {
                    Console.WriteLine("Thank you for playing!");
                }
                //final
            }
        }
    }
}