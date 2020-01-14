using System;
using System.Linq;
using System.Collections.Generic;
using System.Numerics;


namespace EvenFibNumbers
{
    class Program
    {

       static List<int> Fib(int n)
        {
            int a = 0;
            int b = 1;
            var List = new List<int>();

            for (int i = 0; i < n; i++)
            {
                int temp = a;
                a = b;
                b = temp + b;
                List.Add(a);
            }
            return List;
        }

        static List<int> ListEvenNumbers(int n)
        {
            
           var list = Fib(n);
           var evenList = new List<int>();

           for (int i = 0; i < list.Count; i++)
            {
               if(IsEvn(list.ElementAt(i)))
                {
                    evenList.Add(list.ElementAt(i));
                }
            }

            return evenList;
        }

        static bool IsEvn(int n)
        {
            if(n % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }

        }


        static void Main(string[] args)
        {

            var List = ListEvenNumbers(35);
            for (int i = 0; i < List.Count; i++)
            {
                Console.WriteLine(List[i]);
            }


            int result = 0;

            int fn_1 = 1;
            int fn_2 = 1;

            while(fn_1 <= 5000000)
            {
                if (fn_1 % 2 == 0)
                    result += fn_1;


                int fn_2aux = fn_1;
                fn_1 = fn_2 + fn_1;
                fn_2 = fn_2aux;
                
            }

            Console.WriteLine("The sum of even Fibonacci numbers less than 5000000 is {0} ", result);

        }
    }
}
