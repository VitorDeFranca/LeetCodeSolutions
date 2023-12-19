﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_MedianOfTwoSortedArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums1 = { 1, 3 };
            int[] nums2 = { 2 };

            Program program = new Program();
            program.FindMedianSortedArrays(nums1, nums2);

        }

        public double FindMedianSortedArrays(int[] nums1, int[] nums2)
        {
            double median = 0;
            int size1 = nums1.Length;
            int size2 = nums2.Length;
            int aux = size1;

            int[] nums3 = new int[size1 + size2];

            for (int i = 0; i < nums1.Length; i++)
            {
                nums3[i] = nums1[i];
            }

            for (int i = 0; i < nums2.Length; i++)
            {
                nums3[aux] = nums2[i];
                aux++;
            }

            MergeSort(nums3);

            int sizeNums3 = nums3.Length;

            if (sizeNums3 % 2 == 0)
            {
                double elemFrente = nums3[sizeNums3 / 2];
                double elemAtras = nums3[(sizeNums3 / 2) - 1];

                median = (elemFrente + elemAtras) / 2;
                return median;
            }

            median = nums3[sizeNums3 / 2];
            return median;
        }

        public static void MergeSort(int[] arr)
        {
            if (arr.Length <= 1)
                return;

            int mid = arr.Length / 2;

            int[] left = new int[mid];
            int[] right = new int[arr.Length - mid];

            for (int i = 0; i < mid; i++)
                left[i] = arr[i];

            for (int i = mid; i < arr.Length; i++)
                right[i - mid] = arr[i];

            MergeSort(left);
            MergeSort(right);

            Merge(arr, left, right);
        }

        public static void Merge(int[] arr, int[] left, int[] right)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    arr[k++] = left[i++];
                else
                    arr[k++] = right[j++];
            }

            while (i < left.Length)
                arr[k++] = left[i++];

            while (j < right.Length)
                arr[k++] = right[j++];
        }
    }
}
