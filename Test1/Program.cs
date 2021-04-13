using System;

namespace Test1 {
    class Program
    {
        static void Main(string[] args)
        {
            /*Console.Write("Введите свое имя: ");
            string name = Console.ReadLine();       // вводим имя
            Console.WriteLine($"Привет {name}");    // выводим имя на консоль

            var hello = "Hell to World";
            var c = 20;

            Console.WriteLine(c.GetType().ToString());
            Console.WriteLine(hello.GetType().ToString());

            for (int i = 0; i < 10; i += 2)
            {
                Console.WriteLine($"i = {i}");
            }
            
            int[,] mass = new int[2,2];
            for (int i = 0; i<2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    mass[i, j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(mass[i,j]);
                }
                Console.WriteLine();
            }*/
            User us1 = new User();
            User us2 = new User(); 
            User us3 = new User(); 
            User us4 = new User(); 
            User us5 = new User();
            User.Disp();
            Console.ReadKey(); 
        }
        static int Factorial(int x)
        {
            int result;
            if (x == 0)
            {
                return 1;
            }
            else
            {
                result =  Factorial(x - 1) * x; ;
            }
            return result;
        }
    }
    class User {
        private static int count = 0;   
        public User() {
            count++;
        }
        
        public static void Disp()
        {
            Console.WriteLine($"Столько обьектов создано {count}");
        }
    }
}
