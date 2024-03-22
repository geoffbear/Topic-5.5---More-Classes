using System.Runtime.CompilerServices;

namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 100;
            Console.WriteLine("You have $100, how much would you like to bet?");
            int bet = Convert.ToInt32(Console.ReadLine());
            if (bet > 100)
            {
                bet = 100;
            }
            Console.WriteLine("You have chosen to bet $" + bet );
            Console.WriteLine("(a). Would you like to bet on doubles, 1/6 odds, winning x2 your bet back.\n(b). Would you like to bet on non doubles, 5/6 odds, winning half your bet back.\n(c). Would you like to bet on an even sum, 1/2 odds, winning your bet back.\n(d). Would you like to bet on an odd sum, 1/2 odds, winning your bet back.");
            string choice = Console.ReadLine();
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

                if (die1 == die2)
                {
                    Console.WriteLine("You win!");

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
            }
        }
    }
}