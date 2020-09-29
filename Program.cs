using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            

            int[] arr = {21,64 ,25 ,12 ,22, 11};
            int indexSmallest =  FindSmallest(arr);
            int largestNumber = FindLargest(arr);
            MoveFirstSmallest(arr,indexSmallest);
            Console.Write("\n");
            MoveFirstLargest(arr, largestNumber);

            Console.ReadKey();
        }
        static void MoveFirstSmallest(int[] arr, int indexSmallest)
        {
            int temp = arr[indexSmallest];
            arr[indexSmallest] = arr[0];
            arr[0] = temp;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " " );
            }

        }
        static void MoveFirstLargest(int[] arr, int largestNumber)
        {
            int temp = arr[largestNumber];
            arr[largestNumber] = arr[0];
            arr[0] = temp;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

        }



        static int FindSmallest(int[] arr)
        {
            int smallestNumber = arr[0];
            int indexSmallest = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < smallestNumber)
                {
                    smallestNumber = arr[i];
                    indexSmallest = i;
                }
            }
            Console.WriteLine("so nho nhat la " + smallestNumber);
            return indexSmallest;
        }
        static int FindLargest(int[] arr)
        {
            int indexLargest = 0;
            int largestNumber = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > largestNumber)
                {
                    largestNumber = arr[i];
                    indexLargest = i;
                }
            }
            Console.WriteLine("so lon nhat la " + largestNumber);
            return indexLargest;
        }
    }
}
