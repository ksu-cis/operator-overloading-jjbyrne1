using System;

namespace VectorMath
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fun with vectors");

            Vector3 one = new Vector3(3, 4, 5);
            Vector3 two = new Vector3(4, 8, 0);

            Console.WriteLine($"Static method Add: {Vector3.Add(one, two)}");

            Console.WriteLine($"Object method Add: {one.Add(two)}");

            Console.WriteLine($"Operator Additon: {one + two}");

            Console.WriteLine($"Operator Subtraction: {one - two}");

            Console.WriteLine($"Scalar Multiplication: {2 * one}");

            Console.WriteLine($"Scalar Multiplication: {two * 2}");

            Console.WriteLine($"Should not be equal: {one == two}");

            Console.WriteLine($"Should be equal: {one == new Vector3(3,4,5)}");

            Console.WriteLine($"Preincrement: {++one}");

            Console.WriteLine($"Postincrement: {one++}");

            Console.WriteLine($"Magnitude: {~one}");

            if(one) Console.WriteLine($"{one} is Truthy");
            else Console.WriteLine($"{one} is Falsy");

            if (Vector3.Zero) Console.WriteLine($"{Vector3.Zero} is Truthy");
            else Console.WriteLine($"{Vector3.Zero} is Falsy");
        }
    }
}
