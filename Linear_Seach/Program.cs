using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Seach
{
    internal class Program
    {


        public static int BinaryMethod(int[] A,int n,int x)
        {
            int left, right, mid;
            left = 0;
            right = n - 1;

            while (left <= right)
            {
                mid = (left + right) / 2;
                if (A[mid] == x)
                {
                    return mid;
                }
                if (A[mid] < x)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }

            return -1;   
        }
        static void Main(string[] args)
        {
            int[] A = { 12, 22, 34, 23, 43, 54, 12, 34, 56 };
            int n = A.Length;
            Console.Write("Plase Enter Your Find Number :");
            int x = Convert.ToInt32(Console.ReadLine());
            int data = BinaryMethod(A,n,x);
            if(data < 0)
            {
                Console.WriteLine($"{x} Data Not Found");
            }
            else
            {
                Console.WriteLine(" Found Data : "+A[data]);
            }
            
            Console.ReadLine();



        }
    }
}
