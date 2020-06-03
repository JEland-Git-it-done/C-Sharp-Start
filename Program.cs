using System;

namespace Chapter1
{
    class Program
    {
        int total_cycle_count;
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int total_cycle_count = 3;
            Console.WriteLine(total_cycle_count);
            Console.WriteLine(total_cycle_count + 3);
            System.Console.WriteLine("The total number of cycles is {0}", total_cycle_count);
            string var1 = "this";
            int var2 = 2;
            System.Console.WriteLine("Using embeded variables like {0} is useful for debugging dynamic text like var{1}, and you cant declare variables inside of the string argument", var1, var2);
            System.Console.WriteLine($"Using embeded variables can be implemented using a seperate syntax, like showing the above variables by making brackets as such {var1} , {var2}");

            int newvr1 = 500;
            System.Console.WriteLine("Using the inbuilt features, variables can be printed as normal variables like: {0} or as specially formatted variables like: {0:C}", newvr1);
            Datatypes();

            // This is a regular comment
            /*
             * Similar to a multi line comment in java, the syntax is the same
             * */
        }

        static void Datatypes()
        {

        }
    }

    class CardGame
    {
        static void Main()
        {
            Dealer theDealer = new Dealer();
            Player player1 = new Player();
            Player player2 = new Player();
            Player player3 = new Player();

        }
    }
    class Dealer
    {
        string firstName = "Bobby";
        string lastName = "Bobbington";
        //alternate implementation
        void PrintName()
        {
            Console.WriteLine($"{firstName}, {lastName}");
            Player thePlayer;
            thePlayer = new Player();
            Console.WriteLine(GetName());


        }

        private string GetName()
        {
            return (firstName + lastName);
        }
        private string GetLastName()
        {
            return lastName;

        }

    }
    class Player
    {
        string Name;
    }
}
