using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Sort : MonoBehaviour
{
    public int[] GenerateRandomArray(int length, int minValue, int maxValue)
    {
        int[] randomArray = new int[length];
        for (int i = 0; i < length; i++)
        {
            randomArray[i] = Random.Range(minValue, maxValue);
        }
        return randomArray;
    }
    //----------------------Edit below --------------------
    // Sort Algorithm 1 : Bubble Sort
    public void BubbleSort(int[] array)
    {
        int temp;
        for (int i = 0; i < array.Length - 1; i++)
        {
            for (int j = 0; j < array.Length - 1 - i; j++)
            {
                if (array[j] > array[j + 1])
                {
                    temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
    // Sort Algorithm 2 : Selection Sort
    public void SelectionSort(int[] array)
    {
        for (int i = 0; i < array.Length - 1; i++)
        {
            int minIndex = i;
            for (int j = i + 1; j < array.Length; j++)
            {
                if (array[j] < array[minIndex])
                {
                    minIndex = j;
                }
            }
            if (minIndex != i)
            {
                int temp = array[i];
                array[i] = array[minIndex];
                array[minIndex] = temp;
            }
        }
    }
    // Sort Algorithm 3
    public void InsertionSort(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int key = array[i];
            int j = i - 1;
            while (j >= 0 && array[j] > key)
            {
                array[j + 1] = array[j];
                j--;
            }
            array[j + 1] = key;
        }
    }

    // Sort Algorithm 4 : Counting Sort
    public void CountingSort(int[] array)
    {
        int max = array.Max();
        int[] count = new int[max + 1];

        for (int i = 0; i < array.Length; i++)
        {
            count[array[i]]++;
        }

        for (int i = 1; i <= max; i++)
        {
            count[i] += count[i - 1];
        }

        int[] sortedArray = new int[array.Length];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            sortedArray[count[array[i]] - 1] = array[i];
            count[array[i]]--;
        }

        for (int i = 0; i < array.Length; i++)
        {
            array[i] = sortedArray[i];
        }
    }
    // Sort Algorithm 5 : Quick Sort
    public void QuickSort(int[] array, int l, int r)
    {
        int pivot = array[l];
        int i = l;
        int j = r;
        while (i <= j)
        {
            while (array[i] < pivot)
            {
                i++;
            }
            while (array[j] > pivot)
            {
                j--;
            }
            if (i <= j)
            {
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
                i++;
                j--;
            }
        }
        if (l < j)
        {
            QuickSort(array, l, j);
        }
        if (r > i)
        {
            QuickSort(array, i, r);
        }
    }
    //----------------------Edit above --------------------
    public void ReadArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log("Element " + i + ": " + array[i]);
        }
    }

    void Start()
    {
        int[] randomNumbers = GenerateRandomArray(10, 1, 100);
        //----------------------Edit below --------------------
        //Insert Algorithm here
        QuickSort(randomNumbers, 0, randomNumbers.Length - 1);
        //----------------------Edit above --------------------
        ReadArray(randomNumbers);
    }
}
