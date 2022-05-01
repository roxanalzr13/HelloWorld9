using System;

namespace HelloWorld9
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Introduceti primul numar a = ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Introduceti al doilea numar b = ");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("a={0}, b={1}", a, b);
            int c = a; a = b; b = c;
            Console.Write("Dupa interschimbare a={0}, b={1}", a, b); ;
        }
    }
}
