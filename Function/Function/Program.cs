using System;

namespace Function
{
    class Program
    {
        static void PrintLine()
        {
            int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                Console.Write("*");
            }

        }
        static void PrintSquare(int x)
        {
            //int x = int.Parse(Console.ReadLine());

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static void PrintRectangle(int x, int y)
        {
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }

        static int ReadLine()
        {
            Console.WriteLine("Put some value: ");
            int result = int.Parse(Console.ReadLine());
            return result;              
        }

        /* Домашня робота #1 (калькулятор через функцию) ==================================================== */

        static int Number()
        {
            Console.WriteLine("Enter the value: ");
            int result = int.Parse(Console.ReadLine());
            return result;
        }
        static string _operator()
        {
            Console.WriteLine("Enter the sign: ");
            string result = Console.ReadLine();
            return result;
        }

        static void Calculator(int a, int b, string sign)
        {
            int result = 0;

            if (sign == "+")
            {
                result = a + b;               
            }
            else if (sign == "-")
            {
                result = a - b;                
            }
            else if (sign == "*")
            {
                result = a * b;                
            }
            else if(sign == "/")
            {
                result = a / b;                
            }
            
            Console.WriteLine("The result is: ");
            Console.WriteLine(result);
        }

        /* Домашня робота #1 (калькулятор через функцию) ==================================================== */

        static void TablePythagoras(int firstHor, int lastHor, int firstVer, int lastVer)
        {
            //Console.Write("Enter first Horizontal number: ");
            //firstHor = int.Parse(Console.ReadLine());
            //Console.Write("Enter last Horizontal number: ");
            //lastHor = int.Parse(Console.ReadLine());

            //Console.WriteLine();

            //Console.Write("Enter first Vertical number: ");
            //firstVer = int.Parse(Console.ReadLine());
            //Console.Write("Enter last Vertical number: ");
            //lastVer = int.Parse(Console.ReadLine());
            //Console.WriteLine();

            int deltaHor = lastHor - firstHor + 1;
            int deltaVer = lastVer - firstVer + 1;

            // количество циф в максимальном числе таблицы...........
            int num = lastHor * lastVer;
            int NumDigitMax = 0;
            while (num > 0)
            {
                NumDigitMax++;
                num = num / 10;
            }
            // количество циф в максимальном числе таблицы...........

            int y = 0;
            while (y < deltaVer + 2)
            {
                int x = 0;
                while (x < deltaHor + 1)
                {
                    if ((y == 0) && (x == 0))
                    {
                        for (int i = 0; i < NumDigitMax + 1; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write("|");
                    }
                    else if ((y == 0) && (x > 0))
                    {
                        int NumDigit = 0;
                        int k = firstHor + x - 1;
                        while (k > 0)
                        {
                            NumDigit++;
                            k = k / 10;
                        }
                        for (int i = 0; i < NumDigitMax + 1 - NumDigit; i++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(firstHor + x - 1);

                    }

                    // конец 1 строчки таблицы----------------------------------------

                    if ((y == 1) && (x == 0))
                    {
                        for (int i = 0; i < NumDigitMax + 1; i++)
                        {
                            Console.Write("-");
                        }
                        Console.Write("+");
                    }
                    else if ((y == 1) && (x > 0))
                    {
                        for (int i = 0; i < NumDigitMax + 1; i++)
                        {
                            Console.Write("-");
                        }
                    }

                    ////конец 2 стрчки таблицы----------------------------------------

                    if ((y > 1) && (x == 0))
                    {
                        int NumDigit = 0;
                        int k = firstVer + y - 2;
                        while (k > 0)
                        {
                            NumDigit++;
                            k = k / 10;
                        }
                        for (int i = 0; i < NumDigitMax + 1 - NumDigit; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(firstVer + y - 2);
                        Console.Write("|");
                    }
                    else if ((y > 1) && (x > 0))
                    {
                        int NumDigit = 0;
                        int k = (firstHor + x - 1) * (firstVer + y - 2);
                        while (k > 0)
                        {
                            NumDigit++;
                            k = k / 10;
                        }
                        for (int i = 0; i < NumDigitMax + 1 - NumDigit; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write((firstHor + x - 1) * (firstVer + y - 2));
                    }

                    x++;

                }

                y++;
                Console.WriteLine();
            }

            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            //PrintLine();
            //Console.WriteLine();

            //while (true)
            //{
            //    int y = int.Parse(Console.ReadLine());
            //    PrintSquare(y);
            //    Console.WriteLine();

            //    int a = int.Parse(Console.ReadLine());
            //    int b = int.Parse(Console.ReadLine());
            //    PrintRectangle(a,b);
            //}  

            //PrintRectangle(ReadLine(), ReadLine());



            /* Домашня робота #1 (калькулятор через функцию) ==================================================== */
            //Console.WriteLine("Calculator");
            //Calculator(Number(), Number(), _operator());
            //Console.WriteLine();
            //Console.WriteLine();


            /* Домашня робота #2 (таблица Пифагора через функцию) ==================================================== */
            Console.WriteLine("TablePythagoras");
            Console.WriteLine();
            Console.Write("Enter first Horizontal number: ");
            int firstHor = int.Parse(Console.ReadLine());
            Console.Write("Enter last Horizontal number: ");
            int lastHor = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter first Vertical number: ");
            int firstVer = int.Parse(Console.ReadLine());
            Console.Write("Enter last Vertical number: ");
            int lastVer = int.Parse(Console.ReadLine());
            Console.WriteLine();
            
            TablePythagoras(firstHor, lastHor, firstVer, lastVer);




        }
    }
}
