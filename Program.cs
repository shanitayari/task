using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApp3
{
    internal class Program//merge sort O(nlog(n))
    {
        static int[] mergeSort(int[] arr)//merge sort
        {
            if(arr.Length<=1)
                return arr;
            int mid=arr.Length/2;
            int[] leftArr=arr.Take(mid).ToArray();
            int[] rightArr=arr.Skip(mid).ToArray();
            return merge(mergeSort(leftArr),mergeSort(rightArr));
        }
        static int[] merge(int[] arr1,int[] arr2)//merge sorted arrays
        {
            int[] mergedArr=new int[arr1.Length+arr2.Length];
            int i=0;
            int j=0;
            int k=0;
            while(i<arr1.Length&&j<arr2.Length)
                if(arr1[i]<arr2[j])
                    mergedArr[k++]=arr1[i++];
                else
                    mergedArr[k++]=arr2[j++];
            while(i<arr1.Length)
                mergedArr[k++]=arr1[i++];
            while(j<arr2.Length)
                mergedArr[k++]=arr2[j++];
            return mergedArr;
        }
        static void Main(string[] args)
        {
            int[] arr={5,1,7,2,4,8,0};
            int[] sortedArr=mergeSort(arr);
            foreach(int num in sortedArr)
                Console.Write(num+" ");
        }
    }
}