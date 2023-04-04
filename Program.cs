using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Task1();
            Task2();
            Task3();
            Task4();
        }
        public static void Task1()
        {
            Console.WriteLine("Vvedite a:");
            double operand1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Vvedite arifmeticheskiy operator");
            string sign = Console.ReadLine();
            Console.WriteLine("Vvedite b:");
            double operand2 = Convert.ToDouble(Console.ReadLine());
            double result;

            switch (sign)
            {
                case "+":
                    result = operand1 + operand2;
                    Console.WriteLine("=" + result);
                    break;

                case "-":
                    result = operand1 - operand2;
                    Console.WriteLine("=" + result);
                    break;

                case "*":
                    result = operand1 * operand2;
                    Console.WriteLine("=" + result);
                    break;

                case "/":
                    if (operand2 == 0)
                    {
                        Console.WriteLine("Delenie no nol' nedopustimo!");
                    }
                    else
                    {
                        result = operand1 / operand2;
                        Console.WriteLine("=" + Math.Round(result, 2));
                    }
                    break;

                default:
                    Console.WriteLine("Nedopustimiy operator");
                    break;
            }
        }
        public static void Task2()
        {
            Console.WriteLine("Vvedite chislo:");
            string chislo = Console.ReadLine();
            int chisloitog = int.Parse(chislo);
            if (chisloitog > 100)
            {
                Console.WriteLine("Chislo ne vxodit v promegutok 0-100");
            }
            else if (chisloitog >= 0 && chisloitog <= 14)
            {
                Console.WriteLine("Chislo v promegutke 0-14");
            }
            else if (chisloitog >= 15 && chisloitog <= 35)
            {
                Console.WriteLine("Chislo v promegutke 15-35");
            }
            else if (chisloitog >= 36 && chisloitog <= 50)
            {
                Console.WriteLine("Chislo v promegutke 36-50");
            }
            else if (chisloitog >= 51 && chisloitog <= 100)
            {
                Console.WriteLine("Chislo v promegutke 51-100");
            }

        }
        public static void Task3()
        {
            Console.WriteLine("Vvedite slovo:");
            string slovoitog = Console.ReadLine();

            if (slovoitog == "погода")
            {
                Console.WriteLine("weather");
            }
            else if (slovoitog == "солнце")
            {
                Console.WriteLine("sun");
            }
            else if (slovoitog == "дождь")
            {
                Console.WriteLine("rain");
            }
            else if (slovoitog == "снег")
            {
                Console.WriteLine("snow");
            }
            else if (slovoitog == "снежинка")
            {
                Console.WriteLine("snowflake");
            }
            else if (slovoitog == "лёд")
            {
                Console.WriteLine("ice");
            }
            else if (slovoitog == "град")
            {
                Console.WriteLine("hail");
            }
            else if (slovoitog == "радуга")
            {
                Console.WriteLine("rainbow");
            }
            else if (slovoitog == "небо")
            {
                Console.WriteLine("sky");
            }
            else if (slovoitog == "облако")
            {
                Console.WriteLine("cloud");
            }
            else
                Console.WriteLine("Slovo ne naydeno");
        }

        public static void Task4()
        {
            Console.WriteLine("Vvedite chislo:");
            string chislo = Console.ReadLine();
            int chisloitog = int.Parse(chislo);
            if (chisloitog % 2 == 0)
            {
                Console.WriteLine("Chislo chetnoe");
            }
            else
            {
                Console.WriteLine("Chislo nechetnoe");
            }
        }



    }
}



