using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace today0706
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!!");

            int student1 = 0;
            int student2 = 0;
            //student1[0]

            // array -- collection of variables (memory cells) of the same type
            // int -- 10
            // [0][0][0][0][0][0][0][0][0][0]
            //  0  1  2  3  4  5  6  7  8  9
            // arr[0]
            //  
            int x = 1;

            Console.WriteLine("Pleasde tell me how many students in your class?");
            string studnets_in_class_string = Console.ReadLine();
            int num_of_students = Convert.ToInt32(studnets_in_class_string);
            int[] arr = new int[num_of_students]; // new arrays have all the cells equal to zero - 0

            //Console.WriteLine("arr[0] = " + arr[0]);
            //Console.WriteLine($"arr[0] = {arr[0]}");

            //Console.WriteLine($"arr[5] = {arr[5]}");

            //Console.WriteLine($"arr[5] = {arr[10]}"); // error

            //Console.WriteLine($"arr[9] = {arr[9]}"); // error

            //Console.WriteLine(arr); // print Int32[]

            //num_of_students = -1;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter the grade for student #{i + 1}:");
                string tx1 = Console.ReadLine();
                arr[ i ] = Convert.ToInt32(tx1);
            }


            //Console.WriteLine($"arr[0] = {arr[0]}");

            //Console.WriteLine($"arr[1] = {arr[1]}");

            //Console.WriteLine($"arr[2] = {arr[2]}"); 

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"arr [ #{i} ] = {arr[ i ]}");
                sum = sum + arr[ i ];
            }

            double avg = sum * 1.0 / arr.Length;

            Console.WriteLine($"sum of array is {sum}");

            Console.WriteLine($"avg of array is {avg}");

            Console.ReadLine();
        }
    }
}
