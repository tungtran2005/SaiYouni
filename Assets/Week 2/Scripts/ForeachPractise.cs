using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ForeachPractise : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(); // In tất cả các phần tử trong mảng
        BaiTap2(); // Tính tổng các phần tử trong mảng
        BaiTap3(); // Tìm phần tử lớn nhất trong mảng
        BaiTap4(); // Đếm số lượng số chẵn trong mảng
        BaiTap5(); // In tất cả các chuỗi trong danh sách
        BaiTap6(); // Tìm chuỗi dài nhất trong danh sách
        BaiTap7(); // Tính tổng các số lẻ trong mảng
        BaiTap8(); // In các số chẵn trong mảng
        BaiTap9(); // Kiểm tra sự tồn tại của một phần tử trong mảng
        BaiTap10(); // Đếm số phần tử âm trong mảng
        BaiTap11(); // In các số lớn hơn 10 trong mảng
        BaiTap12(); // Tìm chuỗi có độ dài ngắn nhất trong danh sách
        BaiTap13(); // Nhân đôi tất cả các phần tử trong mảng
        BaiTap14(); // Tìm số lớn thứ hai trong mảng
        BaiTap15(); // Tìm chuỗi bắt đầu bằng chữ cái A
        BaiTap16(); // Kiểm tra danh sách có chứa chuỗi "Hello" không
        BaiTap17(); // In tất cả các phần tử âm trong mảng
        BaiTap18(); // Đếm số lần xuất hiện của một phần tử trong mảng
        BaiTap19(); // Tạo danh sách mới từ các phần tử lớn hơn 10
        BaiTap20(); // In các chuỗi có độ dài lớn hơn 5 ký tự
    }

    // Bài Tập 1: In Tất Cả Các Phần Tử Trong Mảng
    void BaiTap1()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[3] { 1,2, 3 };
        // Sử dụng foreach để in tất cả các phần tử trong mảng
        foreach(int i in a)
        {
            Debug.Log(i);
        }
    }
    // Bài Tập 2: Tính Tổng Các Phần Tử Trong Mảng
    void BaiTap2()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[3] { 1, 2, 3 };
        // Sử dụng foreach để tính tổng tất cả các phần tử trong mảng
        int sum = 0;
        foreach(int i in a)
        {
            sum += i;
        }
        Debug.Log(sum);
    }

    // Bài Tập 3: Tìm Phần Tử Lớn Nhất Trong Mảng
    void BaiTap3()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[5] { 3, 2, 6, 9, 1 };
        // Sử dụng foreach để tìm phần tử lớn nhất trong mảng
        int max = a[0];
        foreach(int i in a)
        {
            if(i > max) max = i;
        }
        Debug.Log(max);
    }

    // Bài Tập 4: Đếm Số Lượng Số Chẵn Trong Mảng
    void BaiTap4()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[10] { 3, 2, 4, 6, 9, 1, 5, 7, 8 , 12};
        // Sử dụng foreach để đếm số lượng phần tử chẵn trong mảng
        int dem = 0;
        foreach (int i in a)
        {
            if(i % 2 == 0) dem++;
        }
        Debug.Log("so phan tu chan trong mang la : " + dem);
    }

    // Bài Tập 5: In Tất Cả Các Chuỗi Trong Danh Sách
    void BaiTap5()
    {
        // Tạo một danh sách các chuỗi
        string[] animals = new string[6] { "Duck", "Wolf", "Lion", "Cat", "Dog", "Elephant" };
        // Sử dụng foreach để in tất cả các chuỗi trong danh sách
        foreach(string s in animals)
        {
            Debug.Log(s);
        }
    }

    // Bài Tập 6: Tìm Chuỗi Dài Nhất Trong Danh Sách
    void BaiTap6()
    {
        // Tạo một danh sách các chuỗi
        string[] animals = new string[6] { "Duck", "Wolf", "Lion", "Cat", "Dog", "Elephant" };
        // Sử dụng foreach để tìm chuỗi dài nhất trong danh sách
        string sMax = animals[0];
        int max = sMax.Length;
        foreach (string s in animals)
        {
            if(s.Length > max)
            {
                sMax = s;
                max = s.Length;
            }
        }
        Debug.Log("chuoi dai nhat La : " + sMax);
    }

    // Bài Tập 7: Tính Tổng Các Số Lẻ Trong Mảng
    void BaiTap7()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[10] { 3, 2, 4, 6, 9, 1, 5, 7, 8, 12 };
        // Sử dụng foreach để tính tổng tất cả các số lẻ trong mảng
        int sum = 0;
        foreach (int i in a)
        {
            if(i % 2 == 1)
            {
                sum += i;
            }
        }
        Debug.Log("tong cac so le trong mang : " + sum);
    }

    // Bài Tập 8: In Các Số Chẵn Trong Mảng
    void BaiTap8()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[10] { 3, 2, 4, 6, 9, 1, 5, 7, 8, 12 };
        // Sử dụng foreach để in tất cả các số chẵn trong mảng
        foreach (int i in a)
        {
            if(i % 2 == 0) Debug.Log(i);
        }
    }

    // Bài Tập 9: Kiểm Tra Sự Tồn Tại Của Một Phần Tử Trong Mảng
    void BaiTap9()
    {
        // Tạo một mảng số nguyên và một phần tử cần kiểm tra
        int[] a = new int[10] { 3, 2, 4, 6, 9, 1, 5, 7, 8, 12 };
        int number = 0;
        bool check = false;
        // Sử dụng foreach để kiểm tra xem phần tử đó có tồn tại trong mảng không
        foreach (int i in a)
        {
            if(i ==  number) check = true;
        }
        if (check == true) Debug.Log("co so " + number + "trong mang");
        else Debug.Log("khong co so " + number + "trong mang");

    }

    // Bài Tập 10: Đếm Số Phần Tử Âm Trong Mảng
    void BaiTap10()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[5] { -3, 4, 6, -7, 8, };
        int dem = 0;
        // Sử dụng foreach để đếm số lượng các phần tử âm trong mảng
        foreach (int i in a)
        {
            if (i < 0) dem++;
        }
        Debug.Log("so phan tu am trong mang la : " + dem);
    }

    // Bài Tập 11: In Các Số Lớn Hơn 10 Trong Mảng
    void BaiTap11()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[10] { 1, 5, 2, 3, 4, 13, 17, 67, 22, 54 };
        // Sử dụng foreach để in các số lớn hơn 10 trong mảng
        foreach (int i in a)
        {
            if (i > 10) Debug.Log(i);
        }
    }

    // Bài Tập 12: Tìm Chuỗi Có Độ Dài Ngắn Nhất Trong Danh Sách
    void BaiTap12()
    {
        // Tạo một danh sách các chuỗi
        string[] animals = new string[5] { "Duck", "Wolf", "Lion", "Cat", "Elephant" };
        string sMin = animals[0];
        int min = sMin.Length;
        // Sử dụng foreach để tìm chuỗi có độ dài ngắn nhất trong danh sách
        foreach (string s in animals)
        {
            if (s.Length < min) min = s.Length;
        }
        Debug.Log("chuoi ngan nhat la : " + sMin);
    }

    // Bài Tập 13: Nhân Đôi Tất Cả Các Phần Tử Trong Mảng
    void BaiTap13()
    {
        // Tạo một mảng số nguyên
        int[] n = new int[5] { 1, 2, 3, 4, 5 };
        // Sử dụng foreach để nhân đôi tất cả các phần tử trong mảng
        Debug.Log("Gia tri cua cac phan tu cua mang sau khi nhan doi la : ");
        foreach (int i in n)
        {
            Debug.Log(i * 2);
        }
    }

    // Bài Tập 14: Tìm Số Lớn Thứ Hai Trong Mảng
    void BaiTap14()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[5] { 3, 7, 1, 9, 4 };
        int max = int.MinValue;
        int secondMax = int.MinValue;

        // Sử dụng foreach để tìm phần tử lớn thứ hai trong mảng
        foreach (int i in a)
        {
            if (i > max)
            {
                secondMax = max;
                max = i;
            }
            else if (i > secondMax && i != max)
            {
                secondMax = i;
            }
        }
        Debug.Log("so lon thu hai trong mang la : " + secondMax);
    }

    // Bài Tập 15: Tìm Chuỗi Bắt Đầu Bằng Chữ Cái A
    void BaiTap15()
    {
        // Tạo một danh sách các chuỗi
        string[] animals = new string[6] { "Alligator ", "Wolf", "Albatross", "Cat", "Ant ", "Elephant" };
        // Sử dụng foreach để tìm và in các chuỗi bắt đầu bằng chữ cái 'A'
        foreach (string animal in animals)
        {
            if (animal[0] == 'A') Debug.Log(animal);
        }
    }

    // Bài Tập 16: Kiểm Tra Xem Danh Sách Có Chứa Một Chuỗi Cụ Thể Không
    void BaiTap16()
    {
        // Tạo một danh sách các chuỗi
        string[] greeting = new string[4] { "Good morning", "Good afternoon", "Good evening", "Hello" };
        bool check = false;
        // Sử dụng foreach để kiểm tra xem danh sách có chứa chuỗi "Hello" hay không
        foreach (string s in greeting)
        {
            if (s.Equals("Hello")) check = true;
        }
        if (check == true) Debug.Log("mang co chuoi Hello");
        else Debug.Log("mang khong co chuoi Hello");
    }

    // Bài Tập 17: In Tất Cả Các Phần Tử Âm Trong Mảng
    void BaiTap17()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[5] { -3, 4, 6, -7, 8, };
        // Sử dụng foreach để in ra tất cả các phần tử âm trong mảng
        foreach (int i in a)
        {
            if (i < 0) Debug.Log(i);
        }
    }

    // Bài Tập 18: Đếm Số Lần Xuất Hiện Của Một Phần Tử Trong Mảng
    void BaiTap18()
    {
        // Tạo một mảng số nguyên và một phần tử cụ thể
        int[] a = new int[8] { -3, 4, 6, -7, 8, -3, 5,-3};
        int target = -3; 
        int dem = 0;
        // Sử dụng foreach để đếm số lần xuất hiện của phần tử cụ thể đó trong mảng
        foreach (int i in a)
        {
            if (i == target) dem++;
        }
        Debug.Log("so lan xuat hien cua " +  target + "trong mang la : " + dem);
    }

    // Bài Tập 19: Tạo Một Danh Sách Mới Từ Các Phần Tử Lớn Hơn 10 Trong Mảng
    void BaiTap19()
    {
        // Tạo một mảng số nguyên
        int[] a = new int[10] { 1, 5, 2, 3, 4, 13, 17, 67, 22, 54 };
        List<int> list = new List<int>();
        // Sử dụng foreach để tạo một danh sách mới chứa các phần tử có giá trị lớn hơn 10
        foreach (int i in a)
        {
            if (i > 10)
            {
                list.Add(i);
            }
        }
    }

    // Bài Tập 20: In Các Chuỗi Có Độ Dài Lớn Hơn 5 Ký Tự
    void BaiTap20()
    {
        // Tạo một danh sách các chuỗi
        string[] animals = new string[6] { "Alligator ", "Wolf", "Albatross", "Cat", "Ant ", "Elephant" };
        // Sử dụng foreach để in các chuỗi có độ dài lớn hơn 5 ký tự
        foreach (string animal in animals)
        {
            if (animal.Length > 5) Debug.Log(animal);
        }
    }

}
