namespace Operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable declaration
            int x, y, a, b;

            // Assigment operator
            x = 3;
            y = 2;
            a = 1;
            b = 0;

            // There area many mathematical operators ...

            // Addition operator
            x = 3 + 4;
            
            // Subtraction operator
            x = 4 - 3;

            // Division operator
            x = 10 / 5;

            // Order of operations using parenthesis
            x = (x + y) * (a - b);

            // Equality operator
            if (x == y)
            {
            }

            // Greater than operator
            if (x > y);
            {
            }

            // Less than operator
            if (x < y) ;
            {
            }

            // Greater or equal operator
            if (x >= y) ;
            {
            }

            // Less of equal operator
            if (x <= y) ;
            {
            }

            // There two "conditional" operators as well that can
            // be used to expand / enhance an evaluation ...
            // ... and they can be combined together multiple times.

            // Conditional AND operator
            if ((x > y) && (a > b)
            {
            }

            // Conditional OR operator
            if ((x > y) || (a > b)
            {
            }

            // Alse, here's the in-line conditional operator we
            // learned about in the previous lesson ...
            string message = (x == 1) ? "Car" : "Boat";

            // Member acces and Method invocation
            Console.WriteLine("Hi");
        }
    }
}
