using System;

namespace MyLoops
{
    class Program
    {
        static void Main(string[] args)
        {
            //int x = 0;
            //int a = 2;

            //do
            //{
            //    Console.WriteLine("**********");
            //    x = x + 1;

            //}
            //while (x < a);



            //for (int i = 1; i < 10; i++)
            //{
            //    if (i < 5)
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);
            //}



            //int i = 1;
            //for (; i < 10;)
            //{
            //    Console.Write("*\n");
            //    i++;
            //}


            /* HomeWork # 1 ==================================================================*/
            /*
             *  *****
             *  *****
             *  
             */

            //int x = 0;
            //Console.Write("Enter number of lines: ");
            //int a = int.Parse(Console.ReadLine());

            //int y = 0;
            //Console.Write("Enter number of columns: ");
            //int b = int.Parse(Console.ReadLine());


            //while (x < a)
            //{
            //    while (y < b)
            //    {
            //        Console.Write("*");
            //        y = y + 1;
            //    }

            //    Console.WriteLine();
            //    x++;
            //    y = 0;
            //}

            /* End # 1 ===============================================================================*/

            /* HomeWork # 2 ==========================================================================*/
            /*
             *   *
             *   * *
             *   * * * 
             * 
             */

            //int x = 0;
            //Console.Write("Enter the length of the triangle: ");
            //int a = int.Parse(Console.ReadLine());

            //while (x < a)
            //{
            //    int y = 0;
            //    while (y < x + 1)
            //    {
            //        Console.Write("*");
            //        y++;
            //    }

            //    Console.WriteLine();
            //    x++;

            //}

            /* End # 2 ===============================================================================*/

            /* HomeWork # 3 ==========================================================================*/

            /*
             *       *
             *     * *
             *   * * *
             *
             */

            //int y = 0;
            //Console.Write("Enter the length of the triangle: ");
            //int a = int.Parse(Console.ReadLine());

            //while (y < a)
            //{
            //    int x = 0;
            //    while (x < a)
            //    {
            //        if (x < a - y - 1)
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        x++;
            //    }

            //    Console.WriteLine();
            //    y++;

            //}


            /* End # 3 ===============================================================================*/

            /* HomeWork # 4 ==========================================================================*/

            /*
             *   * * *
             *   * *
             *   * 
             *
             */

            //int y = 0;
            //Console.Write("Enter the length of the triangle: ");
            //int a = int.Parse(Console.ReadLine());

            //while (y < a)
            //{
            //    int x = 0;
            //    while (x < a - y)
            //    {
            //        Console.Write("*");
            //        x++;
            //    }

            //    Console.WriteLine();
            //    y++;
            //}

            /* End # 4 ===============================================================================*/

            /* HomeWork # 5 ==========================================================================*/

            /*
             *   * * *
             *     * *
             *       * 
             *
             */

            //int y = 0;
            //Console.Write("Enter the length of the triangle: ");
            //int a = int.Parse(Console.ReadLine());

            //while (y < a)
            //{
            //    int x = 0;
            //    while (x < a)
            //    {
            //        if (x < y )
            //        {
            //            Console.Write(" ");
            //        }
            //        else
            //        {
            //            Console.Write("*");
            //        }
            //        x++;
            //    }

            //    Console.WriteLine();
            //    y++;

            //}

            /* End # 5 ===============================================================================*/

            /* HomeWork # 6 ==========================================================================*/

            /*
             *        *
             *      * * *
             *    * * * * * 
             *
             */

            //int y = 0;
            //Console.Write("Enter the height of the Christmas Tree: ");
            //int a = int.Parse(Console.ReadLine());

            //while (y < a)
            //{
            //    int x = 0;
            //    while (x < a + a)
            //    {
            //        if ((x >= a - y - 1) && (x <= a + y - 1))
            //        {
            //            Console.Write("*");
            //        }
            //        else
            //        {
            //            Console.Write(" ");
            //        }
            //        x++;
            //    }

            //    Console.WriteLine();
            //    y++;

            //}

            /* End # 6 ===============================================================================*/

            /* HomeWork # 7 ==========================================================================*/

            /*
             *        *
             *      * * *
             *    * * * * * 
             *      * * *
             *        *
             */

            //int y = 0;
            //Console.Write("Enter the half diagonal: ");
            //int a = int.Parse(Console.ReadLine());

            //while (y < a + a)
            //{
            //    int x = 0;
            //    while (x < a + a)
            //    {
            //        if (y < a)
            //        {
            //            if ((x >= a - y - 1) && (x <= a + y - 1))
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }                 
            //        }
            //        else 
            //        {
            //            if ((x >= - a + y + 1) && (x <= a + a + a - y - 3))
            //            {
            //                Console.Write("*");
            //            }
            //            else
            //            {
            //                Console.Write(" ");
            //            }                        
            //        }

            //        x++;

            //    }

            //    Console.WriteLine();
            //    y++;

            //}

            /* End # 7 ===============================================================================*/

            /* HomeWork # 8 ==========================================================================*/

            /* 
             *  "Таблица Пифагора"
             *  
             *   | 1 2 3
             * --+--------
             * 1 | 1 2 3
             * 2 | 2 4 6
             * 3 | 3 6 9
             * 
             * 
             */


            //int y = 0;

            //int a = 3;
            //int b = 3;

            //while (y < b + 2)
            //{
            //    int x = 0;
            //    while (x < a + 2)
            //    {
            //        if ((y == 0) && (x == 0))
            //        {
            //            Console.Write(" |");
            //        }
            //        else if ((y == 0) && (x < a + 1))
            //        {
            //            Console.Write(" ");   
            //            Console.Write(x);                                             
            //        }

            //        // конец 1 стрчки таблицы----------------------------------------

            //        if ((y == 1) && (x == 0))
            //        {
            //            Console.Write("-");
            //        }
            //        else if ((y == 1) && (x == 1))
            //        {
            //            Console.Write("+");
            //        }
            //        else if ((y == 1) && (x > 1))
            //        {
            //            Console.Write("--");
            //        }

            //        //конец 2 стрчки таблицы----------------------------------------

            //        if ((y > 1) && (x == 0))
            //        {
            //            Console.Write(y - 1);
            //        }
            //        else if ((y > 1) && (x == 1))
            //        {
            //            Console.Write("|");
            //        }
            //        else if ((y > 1) && (x > 1))
            //        {
            //            Console.Write(" ");
            //            Console.Write((y-1)*(x-1));
            //        }

            //        x++;

            //    }

            //    y++;
            //    Console.WriteLine();
            //}

            //Console.WriteLine();



            /* End # 8 ===============================================================================*/

            /* HomeWork # 9 ==========================================================================*/

            /* 
             *  "Таблица Пифагора"
             *  
             *   | 1  2  3  4
             * --+------------
             * 1 | 1  2  3  4
             * 2 | 2  4  6  8
             * 3 | 3  6  9 12
             * 
             * 
             */

            //int y = 0;

            //int Hor = 10;
            //int Ver = 15;

            //// количество циф в максимальном числе таблицы...........
            //int num = Hor * Ver;
            //int NumDigitMax = 0;
            //while (num > 0)
            //{
            //    NumDigitMax++;
            //    num = num / 10;
            //}
            //// количество циф в максимальном числе таблицы...........

            //while (y < Ver + 2)
            //{
            //    int x = 0;
            //    while (x < Hor + 2)
            //    {
            //        if ((y == 0) && (x == 0))
            //        {
            //            for (int i = 0; i < NumDigitMax + 1; i++) 
            //            {
            //                Console.Write(" ");
            //            }
            //            Console.Write("|");
            //        }
            //        else if ((y == 0) && (x < Hor + 1))
            //        {
            //            int NumDigit = 0;
            //            int k = x;
            //            while (k > 0)
            //            {
            //                NumDigit++;
            //                k = k / 10;
            //            }
            //            for (int i = 0; i < NumDigitMax + 1 - NumDigit; i++)
            //            {
            //                Console.Write(" ");
            //            }
            //            Console.Write(x);
            //        }

            //        // конец 1 стрчки таблицы----------------------------------------

            //        if ((y == 1) && (x == 0))
            //        {
            //            for (int i = 0; i < NumDigitMax + 1; i++)
            //            {
            //                Console.Write("-");
            //            }
            //            Console.Write("+");
            //        }                   
            //        else if ((y == 1) && (x > 1))
            //        {
            //            for (int i = 0; i < NumDigitMax + 1; i++)
            //            {
            //                Console.Write("-");
            //            }
            //        }

            //        ////конец 2 стрчки таблицы----------------------------------------

            //        if ((y > 1) && (x == 0))
            //        {
            //            int NumDigit = 0;
            //            int k = y - 1;
            //            while (k > 0)
            //            {
            //                NumDigit++;
            //                k = k / 10;
            //            }
            //            for (int i = 0; i < NumDigitMax + 1 - NumDigit; i++)
            //            {
            //                Console.Write(" ");
            //            }

            //            Console.Write(y - 1);
            //            Console.Write("|");
            //        }                   
            //        else if ((y > 1) && (x > 1))
            //        {
            //            int NumDigit = 0;
            //            int k = (y - 1) * (x - 1);
            //            while (k > 0)
            //            {
            //                NumDigit++;
            //                k = k / 10;
            //            }
            //            for (int i = 0; i < NumDigitMax + 1 - NumDigit; i++)
            //            {
            //                Console.Write(" ");
            //            }

            //            Console.Write((y - 1) * (x - 1));
            //        }

            //        x++;

            //    }

            //    y++;
            //    Console.WriteLine();
            //}

            //Console.WriteLine();

            /* End # 9 ===============================================================================*/

            /* HomeWork # 10 ==========================================================================*/

            /* 
             *  firstHor = int.Parse(Console.Read());
             *  lastHor = int.Parse(Console.Read());
             *  
             *  firstVer = int.Parse(Console.Read());
             *  lastVer = int.Parse(Console.Read());
             *  
             *
             *  
             *   | 1  2  3  4
             * --+------------
             * 1 | 1  2  3  4
             * 2 | 2  4  6  8
             * 3 | 3  6  9 12
             * 
             * 
             */

            

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
                        int k = firstVer + y -2;
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


            /* End # 10 ===============================================================================*/




        }
    }
}
