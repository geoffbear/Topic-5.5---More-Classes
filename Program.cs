namespace Topic_5._5___More_Classes
{
    internal class Program
    {
        static void Main(string[] args)
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
            Console.ReadLine();
        }
    }
}