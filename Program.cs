namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int balance = 100;
            int bet;
            Console.WriteLine("You have $100, how much would you like to bet?");
            bet = Convert.ToInt32(Console.ReadLine());
            if (bet > 100)
            {
                bet = 100;
            }
            Console.WriteLine("You have chosen to bet $" + bet );
            Console.WriteLine("Would you like to bet on doubles, 1/6 odds, winning x2 your bet back\nWould you like to bet on non doubles, 5/6 odds, winning half your bet back\n");












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
            Console.ReadLine();
        }
    }
}