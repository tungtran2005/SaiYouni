using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class RecursionPractice : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("Bai 1 : ")]
    public int input1 = 10;
    [Header("Bai 2 : ")]
    public int input2 = 10;
    [Header("Bai 3 : ")]
    public int input3 = 10;
    [Header("Bai 4 : ")]
    public int input4 = 10;
    [Header("Bai 5 : ")]
    public int input5A = 12;
    public int input5B = 10;
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        int output1 = this.BaiTap1(input1);
        Debug.Log("giai thua cua " + input1 + " la : " + output1);
        int output2 = this.BaiTap2(input2);
        Debug.Log("tong cac so tu 1 den " + input2 + " la : " + output2);
        int output3 = this.BaiTap3(input3);
        Debug.Log("so Fibonacci thu " + input3 + " la : " + output3);
        this.BaiTap4(input4); // Đếm ngược từ n về 1
        int output5 = this.BaiTap5(input5A, input5B);
        Debug.Log("uoc chung lon nhat cua " + input5A +" va " +input5B + " la : " + output5);
    }

    // Bài Tập 1: Tính Giai Thừa Của Một Số
    int BaiTap1(int n)
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính giai thừa của n
        if (n == 1) return 1;
        else return n * BaiTap1(n - 1);
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến N
    int BaiTap2(int n)
    {
        // Nhập số nguyên dương n từ bàn phím
        // Viết hàm đệ quy để tính tổng các số từ 1 đến n
        if (n == 1) return 1;
        else return n + BaiTap2(n - 1);
    }

    // Bài Tập 3: Chuỗi Fibonacci
    int BaiTap3(int n)
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để tính số Fibonacci thứ n
        if (n == 0) return 0;
        else if (n == 1) return 1;
        else return BaiTap3(n - 1) + BaiTap3(n - 2);
    }

    // Bài Tập 4: Đếm Ngược
    void BaiTap4(int n)
    {
        // Nhập số nguyên n từ bàn phím
        // Viết hàm đệ quy để đếm ngược từ n về 1
        if(n != 0)
        {
            Debug.Log(n);
            BaiTap4(n - 1);
        }
    }

    // Bài Tập 5: Tìm UCLN (Ước Chung Lớn Nhất)
    int BaiTap5(int a, int b)
    {
        // Nhập hai số nguyên a và b từ bàn phím
        // Viết hàm đệ quy để tìm UCLN của hai số theo thuật toán Euclid
        if (b == 0) return a;
        else return BaiTap5(b, a % b);
    }
}
