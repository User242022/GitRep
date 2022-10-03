using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesertFishing
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.ForegroundColor = ConsoleColor.Yellow;

            int[] array;
            int size;
            Console.WriteLine("Enter array size: ");
            size = Convert.ToInt32(Console.ReadLine());
            array = new int[size];
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine("Enter array[" + i + "]: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            Program method = new Program();
            method.Arrayout(array);

            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("\nElement [" + i + "] duplicates with elemnt [" + j + "] = " + array[j]);
                    }
                }

            }



            string[] array1;
            Console.Write("\nEnter string array size: ");
            size = Convert.ToInt32(Console.ReadLine());
            array1 = new string[size];

            Console.WriteLine(" ");



            for (int i = 0; i < size; i++)
            {
                Console.Write("Enter string array[" + i + "]: ");
                array1[i] = Console.ReadLine();
            }

            method.String_array_out(array1);




            for(int i=0; i<array1.Length; i++)
            {
                string str= array1[i];
                int a = str.Length;
                Console.WriteLine("Your [" + i + "] word: " + array1[i] + "    Letter count = " + a);
            }

            Console.Write("\nEnter first letter of word to find: ");
            Char ch = Convert.ToChar(Console.ReadLine());
            for(int i=0; i<array1.Length; i++)
            {
                string str = array1[i];
                int a = str.Length;
                if (ch == str[0])
                {
                    Console.WriteLine("Your word: " + array1[i] + "    Letter count = " + a);
                }
            }

            array1 = method.String_array_append(array1);
            method.String_array_out(array1);
            method.String_array_out(method.String_array_delete_last(array1));

            DateTime dt = DateTime.Now;

            Console.ReadLine();
        }

        public void Arrayout(int[] array_value)
        {
            Console.Write("\nYour array: ");

            for (int i = 0; i < array_value.Length; i++)
            {
                Console.Write(array_value[i] + " ");
            }
            Console.WriteLine(" ");
        }

        public void String_array_out(string[] array_value)
        {
            Console.Write("\nYour string array: ");

            for (int i = 0; i < array_value.Length; i++)
            {
                Console.Write(array_value[i] + " ");
            }
            Console.WriteLine("\n ");
        }


        public string[] String_array_delete_last(string[] array_value)
        {
            string[] array = new string[array_value.Length-1];
             for(int i = 0; i<array.Length; i++)
            {
                array[i] = array_value[i]; 
            }
             return array;
        }

        public string[] String_array_append(string[] array_value)
        {
            int a = array_value.Length;
            string[] array_value_append = new string[a+1];
            for(int i = 0; i < a; i++)
            {
                array_value_append[i] = array_value[i];
            }
            Console.Write("\nEnter string value to append: ");
            array_value_append[array_value_append.Length-1] = Console.ReadLine();
            return array_value_append;
        }

    }
}
