using System;

namespace Switch
{
    class Switch
    {
        static void Main(string[] args)
        {
            var rand = new Random();
            var omikuji = rand.Next(1, 6);

            switch (omikuji)
            {
                case 1:
                    Console.WriteLine("大吉");
                    break;
                case 2:
                    Console.WriteLine("中吉");
                    break;
                case 3:
                    Console.WriteLine("小吉");
                    break;
                case 4:
                    Console.WriteLine("吉");
                    break;
                case 5:
                    Console.WriteLine("凶");
                    break;
                default:
                    Console.WriteLine("大凶");
                    break;
            }
        }
    }
}
