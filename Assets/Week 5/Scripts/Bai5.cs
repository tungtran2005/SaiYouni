using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai5<T>
{
    public virtual void Check(List<T> list, T item)
    {
        bool found = false;
        foreach (T i in list)
        {
            if (i.Equals(item))
            {
                Debug.Log("Có phần tử " + i + " trong danh sách");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Debug.Log("Không có phần tử " + item + " trong danh sách");
        }
    }

    public virtual void Check(T[] arr, T item)
    {
        bool found = false;
        foreach (T i in arr)
        {
            if (i.Equals(item))
            {
                Debug.Log("Có phần tử " + i + " trong mảng");
                found = true;
                break;
            }
        }
        if (!found)
        {
            Debug.Log("Không có phần tử " + item + " trong mảng");
        }
    }
}
