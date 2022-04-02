using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            int[] arr = new int[20];

            fill_array(arr);
            Console.WriteLine(print_array(arr));
            sort(arr, "min");
            Console.WriteLine(print_array(arr));

            fill_array(arr);
            Console.WriteLine(print_array(arr));
            sort(arr, "max");
            Console.WriteLine(print_array(arr));

            Console.ReadKey();
        }

        static void fill_array(int[] arr)
        {
            Random random = new Random();
            for (int i=0;i<arr.Length; i++)
            {
                arr[i]=random.Next(0,20);
            }
        }

        static string print_array(int[] arr)
        {
            Random random = new Random();
            string str = "";
            for (int i = 0; i < arr.Length; i++)
            {
                str = str + arr[i] + ",";
            }
            return str;
        }


        static int max_min(int[] arr,int a,string b="min")
        {
            int number = arr[a];
            int index = a;
            for(int i=a;i<arr.Length;i++)
            {
                if (b == "min")
                {
                    if (number > arr[i])
                    {
                        number = arr[i];
                        index = i;
                    }
                }
                if (b == "max")
                {
                    if (number < arr[i])
                    {
                        number = arr[i];
                        index = i;
                    }
                }
            }
            return index;
        }

        static void sort(int[] arr,string b="min")
        {
            int c;
            for(int i=0;i<arr.Length-1;i++)
            {
                int a = max_min(arr, i, b);

                c = arr[a];
                arr[a] = arr[i];
                arr[i] = c;

            }
        }

    }
}
