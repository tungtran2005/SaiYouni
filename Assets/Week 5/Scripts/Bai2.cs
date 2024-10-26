using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai2<T>  where T : IComparable<T>
{
    public T FindMax(T[] arr)
    {
        if(arr == null || arr.Length == 0)
        {
            Debug.Log("mang khong co phan tu nao hoac null");
        }
        T max = arr[0];
        foreach(T t in arr)
        {
            if(t.CompareTo(max) > 0) max = t;
        }
        return max;
    }
}
