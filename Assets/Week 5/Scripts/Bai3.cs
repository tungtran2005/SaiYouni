using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bai3<T>
{
    public void Swap(ref T a, ref T b)
    {
        T temp = a;
        a = b;
        b = temp;
    }
}
