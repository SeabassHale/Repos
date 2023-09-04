namespace Potato2
{
    class Program
    {
        static void Main()
        //Object Methods
        {

            Student student1 = new Student("Jim", "Business", 2.8);
            Student student2 = new Student("Pam", "Art", 3.6);

            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }

        /*
        static void Main()
            //Constructors in Classes
        {
            //Book.cs has been updated with the Constructor statement, so arguments can now be sent when creating new Book items.
            Book book1 = new Book("Harry Potter", "JK Rowling", 400);
            Book book2 = new Book("Lord of the Rings", "JRR Tolkien", 900);

        }
        */

        /*
        static void Main()
        //Classes and Objects
        {
            //Book class created, which has its own set of parameters.
            //Once class created, an object can be created within app, and individual elements of object assigned.
            
            Book book1 = new Book();
            
            book1.title = "Harry Potter";
            book1.author = "JK Rowling";
            book1.pages = 400;
            
            Book book2 = new Book();
            book2.title = "Lord of the Rings";
            book2.author = "JRR Tolkien";
            book2.pages = 900;
            

            Console.WriteLine(book1.title);
            Console.WriteLine(book1.author);
            Console.WriteLine(book1.pages);
            Console.WriteLine();

        }
        */

        /*
        static void Main()
        //Exception Handling and a basic division calculator
        {
            Start:
            try
            {
                Console.Write("Enter a number: ");
                decimal num1 = Convert.ToDecimal(Console.ReadLine());
                //Console.Write("Enter a symbol (* / + -): ");
                //string oper1 = Console.ReadLine();
                Console.Write("Enter another number: ");
                decimal num2 = Convert.ToDecimal(Console.ReadLine());

                Console.WriteLine(num1 / num2);

            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (FormatException e)
            {
                Console.WriteLine(e.Message);
                
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            goto Start;
            


        }
        */

        /*
        static void Main()
        {
            
            //2D Array - with testing of an inventory system (of sorts)
            int[,] numberGrid = {
                {1, 2 },
                {3, 4 },
                {5, 6 },
            };

            string[,] stringGrid = {
                {"Hose", "It's a length of hose" },
                {"Crisp packet", "It once housed some cheese and onion crisps" },
                {"Shoe", "It's an old shoe" },
            };

            int invItemNum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(stringGrid[invItemNum,0]);
            Console.WriteLine(stringGrid[invItemNum, 1]);
            
        }
        */

        /*
        static void Main()
        {
        //Power calculator
        static void Main()
        {
            Console.WriteLine(GetPow(4.5111234567890987456546513216546842165465524374725471M,3.211112347235526546513216546865459965213265468734211M));
        }

        static string GetPow(decimal baseNum, decimal powNum)
        {
            decimal result = 1;

            for (int i = 0; i < powNum; i++)
            {
                result *= baseNum;
            }
            string resInt = Convert.ToString(result);
            return resInt;
        }
        }*/
    }
}