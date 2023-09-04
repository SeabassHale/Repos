//using TestIdea.Movement;

internal class Program
{
    public class Movement
    {
        public string Movemnt(string x)
        {
            {
                X = x;
            }

            string X = Console.ReadLine();
            return X;
            //return direction;


        }
    }

    public static void Main(string[] args)
    {
        Console.WriteLine("Hello. Please pick a direction");
        var x = "";
        //var x = Movement.Movemnt();
        Movement(x);
        Console.WriteLine($"You walk in direction {x}");
        Console.ReadLine();
    }
}