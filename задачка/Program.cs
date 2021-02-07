using System;

namespace задачка
{
    class Program
    {
        static void Main(string[] args)
        {

            int hStart = 1;// int.Parse(Console.ReadLine());
            int hEnd = 10;// int.Parse(Console.ReadLine());
            int vStart = 1;// int.Parse(Console.ReadLine());
            int vEnd = 10;// int.Parse(Console.ReadLine());
            int x = hStart;
            int y = vStart;
            int max = hEnd * vEnd;
            int length = 0;
            int a = hEnd;
            int b = vEnd;
            int d = hEnd - hStart + 1;
            int maxCount = max;

            //Console.WriteLine(x);
            //Console.WriteLine(y);
            //Console.WriteLine(max);
            //Console.WriteLine(length);
            //Console.WriteLine(a);
            //Console.WriteLine(b);
            //Console.WriteLine(d);
            //Console.WriteLine(maxCount);

            while (maxCount >= 1)
            {
                length++;
                maxCount = maxCount / 10;
            }
            //Console.WriteLine(length);
            //Console.WriteLine(maxCount);

            for (int i = 0; i < length; i++)
            {
                Console.Write(" ");
                
            }

                Console.Write(" |");

            x = hStart;
            while (x <= hEnd)
            {
                int longLine = x;
                int countLine = 0;
                while (longLine >= 1)
                {
                    countLine++;
                    longLine = longLine / 10;
                }

                for (int i = 0; i <= length - countLine; i++)
                {
                    Console.Write(" ");
                }
                Console.Write(x);
                x++;
            }
            Console.WriteLine();

            for (int i = 0; i <= length; i++)
            {
                Console.Write("-");
            }
            Console.Write("+");

            for (int Line = 1; Line <= d * (length + 1); Line++)
            {
                Console.Write("-");
            }

            Console.WriteLine();
            x = hStart;
            while (x <= vEnd)
            {
                while (vStart <= vEnd)
                {
                    int LongLine = vStart;
                    int countLongLine = 0;
                    while (LongLine >= 1)
                    {
                        countLongLine++;
                        LongLine = LongLine / 10;
                    }

                    for (int i = 0; i <= length - countLongLine; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.Write(vStart + "|");

                    x = hStart;
                    while (x <= hEnd)
                    {
                        int product = vStart * x;
                        int LineLong = product;
                        int countLong = 0;
                        while (LongLine >= 1)
                        {
                            countLong++;
                            LineLong = LineLong / (d + 1);
                        }

                        for (int i = 0; i <= length - countLong; i++)
                        {
                            Console.Write(" ");
                        }

                        Console.Write(product);
                        x++;
                    }
                    Console.WriteLine();
                    vStart++;
                }

            }
            Console.ReadLine();
        }
    }
}
