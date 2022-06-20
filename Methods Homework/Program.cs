using System;

namespace Methods_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Bolunme(21);
            Toplama(6, 140);
            TekEdedler(5, 25);


           int[] ededler = { 5, 15, 25, 50, 60 };
            ArraydaEdedler(ededler);

            int[] reqemler = { 5, 10, 20, 25, 30 };
            ArraydaCutler(reqemler);


            //Console.WriteLine("Hello World!");
        }
        









        //Verilmiş n - ədədinin 3-ə və 7-ə bölünüb-bölünməməsini tapın.
        static void Bolunme(int n)
        {
            if (n % 3 == 0 && n % 7 == 0)
            { 
                Console.WriteLine("bolunur");
            
            }
            else
            {
                Console.WriteLine("bolunmur");
            }
        }



        //n və m ədədləri verilir. Əgər n və m ədədləri hər ikisi cütdürsə n və m ədədlərinin cəmini hesablayın.
        static void Toplama(int n, int m)
        {
            if (n % 2 == 0 && m % 2 == 0)
            {
                Console.WriteLine(n + m);
            }
            else
            {
                Console.WriteLine("Cut Deyil");
            }
        }

        //Verilmis n ve m (n<m) ededleri arasindaki tek ededlerin cemini tapin.
        static void TekEdedler (int n, int m)
        { int sum = 0;
            for (int i=n; i<m; i ++)
                if (i % 2 == 0)
                {
                    sum += i;
                }
            Console.WriteLine(sum);
        }



        // Verilmish arrayin icindeki tek ededlerin cemini tapin.

        static void ArraydaEdedler(int[] array)
        {
            int sum = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 != 0)
                {
                    sum += array[i];
                }
            Console.WriteLine(sum);

        }

        //Verilmish arrayin icindeki cut ededlerin sayini tapin.

        static void ArraydaCutler(int[] array)
        {
            int a = 0;
            for (int i = 0; i < array.Length; i++)
                if (array[i] % 2 == 0)
                {
                    a++;
                }
            Console.WriteLine(a);
        }


    }
}
