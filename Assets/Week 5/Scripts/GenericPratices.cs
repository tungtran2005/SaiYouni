using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericPratices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //Ở bài tập này bạn hãy tạo nhiều class riêng biệt nha
        //Mối script một class nhé
        Bai1<int> a1 = new();
        a1.data = 1;
        Bai1<string> b1 = new();
        b1.data = "hello";
        int[] arr = { 1, 2, 2, 6, 4, 5 };
        string[] arr2 = { "hello", "tungtran", "youni", "saigame" };
        Bai2<int> a2 = new();
        int max = a2.FindMax(arr);
        Debug.Log("max : " + max);
        Bai2<string> b2 = new();
        string max2 = b2.FindMax(arr2);
        Debug.Log("max2 : " + max2);
        //case test b3
        Bai3<string> bai3 = new();
        string a = "hello";
        string b = "goodbye";
        bai3.Swap(ref a,ref b);
        Debug.Log(a + b);
        //case test b4
        Bai4<int> a4 = new();
        a4.AddItem(1);
        a4.RemoveItem(2);
        a4.DisplayIteams();
        //case test b5
        Bai5<string> a5 = new();
        a5.Check(arr2, "hello");
    }

    // Update is called once per frame
    void Update() { }
}
