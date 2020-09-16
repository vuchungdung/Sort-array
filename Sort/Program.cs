using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Random r = new Random();
            for(int i = 0;i < arr.Length; i++)
            {
                arr[i] = r.Next(1,1000);
            }
            var watch = new System.Diagnostics.Stopwatch();
            watch.Start();
            MergeSort(arr, 0, arr.Length - 1);        
            watch.Stop();
            Console.WriteLine("Time: {0}", watch.ElapsedMilliseconds);
            Console.ReadKey();
        }
        public static void MergeSort(int[]arr,int left,int right)
        {
            if(left < right)
            {
                int mid = left + (right - left) / 2;
                MergeSort(arr, left, mid);
                MergeSort(arr, mid + 1, right);
                Merge(arr, left, right, mid);
            }
            
        }

        public static void Merge(int[]arr,int left,int right,int mid)
        {
            int i = left;
            int j = mid + 1;
            int k = 0;
            int[] tmp = new int[right - left + 1];

            while((i< mid+1) && (j < right + 1))
            {
                if(arr[i] <= arr[j])
                {
                    tmp[k] = arr[i];
                    i++;
                }
                else
                {
                    tmp[k] = arr[j];
                    j++;
                }
                k++;
            }
            while (i < mid+1)
            {
                tmp[k] = arr[i];
                i++;
                k++;
            }
            while(j< right + 1)
            {
                tmp[k] = arr[j];
                j++;
                k++;
            }
            i = left;
            for(k = 0; k < tmp.Length; k++)
            {
                arr[i] = tmp[k];
                i++;
            }
        }
    }
}
