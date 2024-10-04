using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ForPractise : MonoBehaviour
{
    public int input12 = 10;
    public int input13 = 10;
    public int input14 = 10;
    public int input16 = 7;
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1();
        BaiTap2();
        BaiTap3();
        BaiTap4(); 
        BaiTap5(); 
        BaiTap6(); 
        BaiTap7(); 
        BaiTap8(); 
        BaiTap9(); 
        BaiTap10(); 
        BaiTap11(); 
        BaiTap12(input12);
        BaiTap13(input13); 
        BaiTap14(input14);
        BaiTap15();
        BaiTap16(input16); 
        BaiTap17(); 
        BaiTap18(); 
        BaiTap19(); 
        BaiTap20();
    }

    // Bài Tập 1: In Các Số Từ 1 Đến 100
    void BaiTap1()
    {
        for (int i = 1; i <= 100; i++)
        {
            Debug.Log(i);       
        }
    }

    // Bài Tập 2: Tính Tổng Các Số Từ 1 Đến 50
    void BaiTap2()
    {
        int sum = 0;
        for (int i = 1; i <= 5; i++)
        {
            sum += i;
        }
        Debug.Log("tong cac so tu 1 den 50 : " + sum);
    }

    // Bài Tập 3: In Các Số Chẵn Từ 1 Đến 100
    void BaiTap3()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0) Debug.Log(i);
        }
    }

    // Bài Tập 4: Tính Tích Các Số Từ 1 Đến 10
    void BaiTap4()
    {
        int tich = 1;
        for (int i = 1; i <= 10; i++)
        {
            tich *= i;
        }
        Debug.Log("tich cac so tu 1 den 10 la : " +  tich);
    }

    // Bài Tập 5: Tìm Số Lớn Nhất Trong Một Mảng
    void BaiTap5()
    {
        int[] a = new int[7] {5 , 1, 2, 4, 6, 7, 3};
        int max = a[0];
        for ( int i = 0; i < a.Length; i++)
        {
            if (a[i] > max) max = a[i];
        }
        Debug.Log("so lon nhat trong mang : " +  max);
    }

    // Bài Tập 6: Tính Tổng Các Số Lẻ Từ 1 Đến 100
    void BaiTap6()
    {
        int tongLe = 0;
        for ( int i = 1; i <= 100; i++)
        {
            if (i % 2 == 1) tongLe += i;
        }
        Debug.Log("tong cac so le tu 1 den 100 : " +  tongLe);
    }

    // Bài Tập 7: Đảo Ngược Chuỗi
    void BaiTap7()
    {
        string s = "Tung";
        char[] sArr = s.ToCharArray();
        for ( int i = 0; i < s.Length / 2; i++)
        {
            char temp = s[i];
            sArr[i] = sArr[s.Length - 1 - i];
            sArr[s.Length - 1 - i] = temp;
        }
        s = new string(sArr);
        Debug.Log("chuoi dao nguoc la : " + s);
    }

    // Bài Tập 8: In Ra Bảng Cửu Chương
    void BaiTap8()
    {
        int n = UnityEngine.Random.Range(1, 11);
        for (int i = 1; i <= 10; i++)
        {
            Debug.Log(n + " * " + i + " = " + (n * i));
        }
    }

    // Bài Tập 9: Đếm Các Số Nguyên Dương Trong Mảng
    void BaiTap9()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int dem = 0;
        for (int i = 0; i < a.Length; i++)
        {
            if (a[i] > 0) dem++;
        }
        Debug.Log("so so nguyend duong trong mang la : " +  dem);
    }

    // Bài Tập 10: In Tam Giác Số
    void BaiTap10()
    {
        for (int i = 1; i <= 5; i++)
        {
            string s = "";
            for (int j=1; j <= i; j++)
            {
                s += j;
            }
            Debug.Log(s);
        }
    }

    // Bài Tập 11: Tìm Phần Tử Nhỏ Nhất Trong Mảng
    void BaiTap11()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int min = a[0];
        for (int i=0; i<a.Length; i++)
        {
            if(a[i] < min) min = a[i];
        }
        Debug.Log("phan tu nho nhat mang la : " +  min);
    }

    // Bài Tập 12: In Dãy Fibonacci
    void BaiTap12(int n)
    {
        int a = 0;
        int b = 1;
        for (int i = 0;i < n; i++)
        {
            Debug.Log(a);
            int next = a + b;
            a = b;
            b = next;
        }
    }

    // Bài Tập 13: Tính Giai Thừa Của Một Số
    void BaiTap13(int n)
    {
        int giaiThua = 1;
        for(int i = 1; i <= n; i++)
        {
            giaiThua *= i;
        }
        Debug.Log("giai thua cua " + n + " la : " +  giaiThua);

    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14(int n)
    {
        for (int i = n; i >= 1; i--)
        {
            Debug.Log(i);
        }
    }

    // Bài Tập 15: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap15()
    {
        int[] a = new int[6] { 1, 2, 12, 23, 44, 24 };
        int sum = 0;
        for(int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        Debug.Log("tong cac phan tu trong mang : " + sum);
    }

    // Bài Tập 16: Kiểm Tra Số Nguyên Tố
    void BaiTap16(int n)
    {
        bool check = true;
        if (n < 2)
        {
            check = false; 
        }
        for (int i = 2; i < Mathf.Sqrt(n); i++)
        {
            if(n % i == 0)
            {
                check = false;
                break;
            }
        }
        if (check == true) Debug.Log(n + " la so nguyen to");
        else Debug.Log(n + " khong phai so nguyen to");

    }

    // Bài Tập 17: In Ra Dãy Số Chia Hết Cho 3
    void BaiTap17()
    {
        for (int i = 1; i <= 100; i++)
        {
            if (i % 3 == 0) Debug.Log(i);
        }
    }

    // Bài Tập 18: Tìm Tổng Các Số Chẵn Trong Mảng
    void BaiTap18()
    {
        int[] a = new int[6] { 1, 2, 12, 23, 44, 24 };
        int tongChan = 0;
        for (int i=0; i < a.Length; i++)
        {
            if (a[i] % 2 == 0) tongChan += a[i];
        }
        Debug.Log("tong cac phan tu chan : " + tongChan);
    }

    // Bài Tập 19: Tính Trung Bình Cộng Của Mảng
    void BaiTap19()
    {
        int[] a = new int[7] { 5, 1, 2, 4, 6, 7, 3 };
        int sum = 0;
        for (int i = 0; i < a.Length; i++)
        {
            sum += a[i];
        }
        float TBC = (float)sum/a.Length;
        Debug.Log("trung binh cong : " +  TBC);
    }

    // Bài Tập 20: Đếm Số Ký Tự Hoa Trong Chuỗi
    void BaiTap20()
    {
        string s = "TranVanTung";
        int dem = 0;
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' &&  s[i] <= 'Z')
            {
                dem++;
            }
        }
        Debug.Log("so ki tu hoa la : " + dem);
    }
}
