using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace University29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter Number-> ");

                arr[i] = Convert.ToInt16(Console.ReadLine());

            }

            Program Obj = new Program();

            Console.WriteLine("-------Array Before Sorting------------");

            Obj.printarray(arr);

            Console.WriteLine("-----------------------------------------");

            int max = Obj.findMax(arr);

            Console.WriteLine("Maximum Value=> " + max);

            int min = Obj.findmin(arr);

            Console.WriteLine("Minimum Value=> " + min);

            Obj.sort(arr);

            Console.WriteLine("---------------Array After Sorting---------------");

            Obj.printarray(arr);

            Console.WriteLine("-----------------------------------------------------");

            Console.Read();
        }

        public int findMax(int[] x)
        {
            int max = x[0];

            int i;

            for (i = 1; i < 10; i++)
            {
                if (x[i] > max)
                    max = x[i];
            }

            return max;
        }

        public int findmin(int[] x)
        {
            int min = x[0];

            int i;

            for (i = 1; i < 10; i++)
            {
                if (x[i] < min)
                    min = x[i];
            }

            return min;
        }

        public void printarray(int[] x)
        {
            int i;

            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(Convert.ToString(x[i]));
            }
        }

        public void sort(int[] x)
        {
            int i, j, temp;

            for (i = 0; i < 10; i++)

                for (j = 0; j < 9 - i; j++)

                    if (x[j] > x[j + 1])
                    {
                        temp = x[j];
                        x[j] = x[j + 1];
                        x[j + 1] = temp;
                    }
        }
    }
}
