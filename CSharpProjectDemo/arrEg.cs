using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdvCSharp
{
    class arrEg
    {
        public void arrayDemo()
        {
            //SINGLE DIMENSIONAL..............
            Console.WriteLine("SINGLE DIMENSIONAL ARRAY");
            Console.WriteLine("=========================");
            int[] singlearr = new int[5];  //lazy initialization
            singlearr[0] = 1;
            singlearr[3] = 4;

            int[] singlearr1 = { 1, 2, 3, 4, 5 };
            for (int i = 0; i < singlearr.Length; i++)
            {
                Console.WriteLine(singlearr[i]);
            }
            for (int i = 0; i < singlearr1.Length; i++)
            {
                Console.WriteLine(singlearr1[i]);
            }
            //USER INPUT.............
            Console.WriteLine("Enter the elements ");
            int[] userarr = new int[5];
            for (int i = 0; i < userarr.Length; i++)
            {
                userarr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("The elements entered are ");
            for (int i = 0; i < userarr.Length; i++)
            {
                Console.WriteLine(userarr[i]);
            }

            //TWODIMENSIONAL......
            Console.WriteLine("Two DIMENSIONAL ARRAY");
            Console.WriteLine("=========================");
            int[,] twoarr = new int[3, 3];
            int[,] twoarr1 = { { 1, 1, 1 }, { 2, 2, 2 }, { 3, 3, 3 } };
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    twoarr[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("The entered elements are ");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(twoarr[i, j] + "  ");
                }
                Console.WriteLine();
            }


            //JAGGED ARRAY
            Console.WriteLine("Jagged ARRAY");
            Console.WriteLine("============");
            int[][] jarray = new int[3][];
            jarray[0] = new int[] { 1, 2, 3 };
            jarray[1] = new int[] { 4, 6, 8, 10 };
            jarray[2] = new int[] { 3, 7 };

            Console.WriteLine("Enter the elements");

            for (int i = 0; i < jarray.Length; i++)
            {
                for (int j = 0; j < jarray[i].Length; j++)
                {
                    Console.Write(jarray[i][j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("Give the input:");
            int[][] jarray1 = new int[4][];
            jarray1[0] = new int[2];
            jarray1[1] = new int[3];
            jarray1[2] = new int[2];
            jarray1[3] = new int[4];

            for (int i = 0; i < jarray1.Length; i++)
            {
                for (int j = 0; j < jarray1[i].Length; j++)
                {
                    jarray1[i][j] = int.Parse(Console.ReadLine());
                }
            }
            for (int i = 0; i < jarray1.Length; i++)
            {
                for (int j = 0; j < jarray1[i].Length; j++)
                {
                    Console.Write(jarray1[i][j] + "  ");
                }
                Console.WriteLine();
            }


        }
    }
}
