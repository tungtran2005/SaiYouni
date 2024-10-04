using JetBrains.Annotations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using UnityEditor;
using UnityEngine;

public class IfStatementPractise : MonoBehaviour
{
    [Header("bai 1 : ")]
    public int input1 = 12;
    [Header("bai 2 :")]
    public int input2 = 13;
    [Header("bai 3 :")]
    public float input3 = 7f;
    [Header("bai 4 :")]
    public int input4A = 3;
    public int input4B =5;
    [Header("bai 5 :")]
    public int tienHienCo = 20000;
    public int giaSP = 25000;
    [Header("bai 6 :")]
    public int nam = 2024;
    [Header("bai 7 :")]
    public int tuoi = 19;
    [Header("bai 8 :")]
    public float diem = 9.5f;
    [Header("bai 9 :")]
    public int input9A = 3;
    public int input9B = 5;
    public int input9C = 8;
    [Header("bai 10 :")]
    public int gioLV = 45;
    public int luongCD = 25000;
    [Header("bai 11 :")]
    int age = 19;
    bool theTV = false;
    [Header("bai 12 :")]
    public float diemTB = 8.4f;
    [Header("bai 13 :")]
    public int soDien = 196;
    [Header("bai 14 :")]
    public int soNamLV = 7;
    public bool danhGiaTot = true;
    [Header("bai 15 :")]
    public int giaDon = 100000;
    [Header("bai 16 :")]
    public float thuNhap = 5000000f;
    [Header("bai 17 :")]
    public float toan = 7.3f;
    public float van = 8f;
    public float anh = 5.6f;
    [Header("bai 18 :")]
    int soHang = 99;
    bool remainingSpace = false;
    [Header("bai 19 :")]
    public int a = 11;
    [Header("bai 20 :")]
    public float diemTK = 9.5f;
    public bool HTBasic = true;
    public bool thuGT = true;
    private void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(input1); // Kiểm tra số dương, âm, hoặc bằng 0
        BaiTap2(input2); // Kiểm tra số chẵn hay lẻ
        BaiTap3(input3); // Kiểm tra điều kiện thi đỗ
        BaiTap4(input4A,input4B); // Tìm số lớn nhất trong hai số
        BaiTap5(tienHienCo,giaSP); // Kiểm tra điều kiện mua hàng
        BaiTap6(nam); // Kiểm tra năm nhuận
        BaiTap7(tuoi); // Tính giá vé xem phim
        BaiTap8(diem); // Kiểm tra học sinh xuất sắc
        BaiTap9(input9A, input9B, input9C); // So sánh ba số
        BaiTap10(gioLV, luongCD); // Tính tiền lương
        BaiTap11(age, theTV); // Kiểm tra điều kiện vào câu lạc bộ
        BaiTap12(diemTB); // Phân loại học sinh
        BaiTap13(soDien); // Tính tiền điện
        BaiTap14(soNamLV,danhGiaTot); // Kiểm tra điều kiện thăng chức
        BaiTap15(giaDon); // Kiểm tra điều kiện miễn phí vận chuyển
        BaiTap16(thuNhap); // Tính thuế thu nhập cá nhân
        BaiTap17(toan,van,anh); // Tính điểm trung bình của môn học
        BaiTap18(soHang,remainingSpace); // Kiểm tra điều kiện nhập hàng
        BaiTap19(a); // Tìm số lớn hơn 10
        BaiTap20(diemTK,HTBasic,thuGT); // Kiểm tra điều kiện đăng ký khóa học
    }

    // Bài Tập 1: Kiểm Tra Số Dương, Âm Hoặc Bằng 0
    public void BaiTap1(int a)
    {
        // Nhập một số từ bàn phím
        
        // Kiểm tra xem số đó là số dương, âm hay bằng 0
        if (a > 0)
        {
            Debug.Log(a + " la so duong ");
        }
        else if(a < 0)
        {
            Debug.Log(a + " la so am");
        }
        else
        {
            Debug.Log(a + " la so 0");
        }
        Debug.Log("======================================");
    }

    // Bài Tập 2: Kiểm Tra Số Chẵn Hay Lẻ
    void BaiTap2(int a)
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó là số chẵn hay lẻ
        if ( a % 2 == 0 )
        {
            Debug.Log("a = " + a + " la so so chan");
        }
        else
        {
            Debug.Log("a = " + a + " la so so le");
        }
        Debug.Log("======================================");
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Thi Đỗ
    void BaiTap3(float diemTB)
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra nếu điểm trung bình >= 5.0 thì học sinh đỗ, ngược lại thì trượt
        if ( diemTB >= 5)
        {
            Debug.Log("Do");
        }
        else
        {
            Debug.Log("truot");
        }
        Debug.Log("======================================");
    }

    // Bài Tập 4: Tìm Số Lớn Nhất Trong Hai Số
    void BaiTap4(int a, int b)
    {
        // Nhập hai số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong hai số đó
        if (a >= b)
        {
            Debug.Log("so lon nhat la : " + a);
        }
        else
        {
            Debug.Log("so lon nhat la : " + b);
        }
        Debug.Log("======================================");
    }

    // Bài Tập 5: Kiểm Tra Điều Kiện Mua Hàng
    void BaiTap5(int tienHienCo, int giaSP)
    {
        // Nhập số tiền hiện có và giá sản phẩm từ bàn phím
        // Kiểm tra xem người dùng có đủ tiền mua hàng không
        if( tienHienCo >= giaSP)
        {
            Debug.Log("nguoi dung du tien mua hang");
        }
        else
        {
            Debug.Log("nguoi dung khong du tien mua hang");
        }
        Debug.Log("======================================");
    }

    // Bài Tập 6: Kiểm Tra Năm Nhuận
    void BaiTap6(int nam)
    {
        // Nhập một năm từ bàn phím
        // Kiểm tra xem năm đó có phải là năm nhuận hay không
        if (((nam % 4 == 0) && (nam % 100 != 0)) || (nam % 400 == 0))
        {
            Debug.Log(nam + " la nam nhuan");
        }
        else
        {
            Debug.Log(nam + " khong phai nam nhuan");
        }
        Debug.Log("======================================");
    }

    // Bài Tập 7: Tính Giá Vé Xem Phim
    void BaiTap7(int age)
    {
        // Nhập tuổi của người mua vé từ bàn phím
        // Nếu người mua dưới 18 tuổi, giá vé là 50,000 đồng
        if (age < 18) Debug.Log("gia ve la 50,000");
        // Nếu người mua từ 18 tuổi trở lên, giá vé là 100,000 đồng
        else Debug.Log("gia ve la 100,000");
        Debug.Log("======================================");
    }

    // Bài Tập 8: Kiểm Tra Học Sinh Xuất Sắc
    void BaiTap8(float diem)
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Kiểm tra xem học sinh có đạt danh hiệu xuất sắc không (điểm trung bình >= 9.0)
        if (diem >= 9) Debug.Log("Hoc sinh dat danh hieu xuat sac");
        else Debug.Log("Hoc sinh khong dat danh hieu xuat sac");
        Debug.Log("======================================");
    }

    // Bài Tập 9: So Sánh Ba Số
    void BaiTap9(int a, int b, int c)
    {
        // Nhập ba số nguyên từ bàn phím
        // Kiểm tra và in ra số lớn nhất trong ba số đó
        if (a >= b && a >= c) Debug.Log("so lon nhat la : " + a);
        else if (b >= a && b >= c) Debug.Log("so lon nhat la : " + b);
        else Debug.Log("So lon nhat la : " + c);
        Debug.Log("======================================");
    }

    // Bài Tập 10: Tính Tiền Lương
    void BaiTap10(int gioLV,  int luongCD)
    {
        // Nhập số giờ làm việc và mức lương cố định từ bàn phím
        int tongLuong;
        // Nếu nhân viên làm trên 40 giờ, lương được tính thêm giờ
        if (gioLV > 40)
        {
            tongLuong = (40 * luongCD) + (gioLV - 40) * (2 * luongCD);
        }
        // Nếu làm dưới hoặc bằng 40 giờ, lương tính theo giờ cố định
        else
        {
            tongLuong = gioLV * luongCD;
        }
        Debug.Log("luong cua nv la : " + tongLuong);
        Debug.Log("======================================");
    }

    // Bài Tập 11: Kiểm Tra Điều Kiện Vào Câu Lạc Bộ
    void BaiTap11(int age, bool theTV)
    {
        // Nhập tuổi và kiểm tra xem người đó có thẻ thành viên hay không
        // Kiểm tra nếu trên 18 tuổi và có thẻ thành viên thì được vào câu lạc bộ
        if (age > 18 && theTV == true) Debug.Log("Duoc vao CLB");
        else Debug.Log("Khong duoc vao CLB");
        Debug.Log("======================================");
    }

    // Bài Tập 12: Phân Loại Học Sinh
    void BaiTap12(float diemTB)
    {
        // Nhập điểm trung bình của học sinh từ bàn phím
        // Phân loại học sinh theo thang điểm từ xuất sắc đến yếu
        if (diemTB >= 9) Debug.Log("hoc luc xuat sac");
        else if (diemTB >= 8) Debug.Log("hoc luc gioi");
        else if (diemTB >= 7) Debug.Log("hoc luc kha");
        else if (diemTB >= 5) Debug.Log("hoc luc trung binh");
        else Debug.Log("hoc luc yeu");
        Debug.Log("======================================");
    }

    // Bài Tập 13: Tính Tiền Điện
    void BaiTap13(int soDien = 19)
    {
        // Nhập số điện tiêu thụ từ bàn phím
        int tienDien;
        // Tính tiền điện theo công thức: <= 100 kWh: 1,500 đồng/kWh, >100 kWh: 2,000 đồng/kWh
        if (soDien <= 100) tienDien = 1500 * soDien;
        else tienDien = 100 * 1500 + (soDien - 100) * 2000;
        Debug.Log("tien dien la : " + tienDien);
        Debug.Log("======================================");
    }

    // Bài Tập 14: Kiểm Tra Điều Kiện Thăng Chức
    void BaiTap14(int soNamLV ,bool danhGiaTot)
    {
        // Nhập số năm làm việc và đánh giá công việc
        // Kiểm tra nếu số năm làm việc trên 5 năm và đánh giá tốt thì đủ điều kiện thăng chức
        if (soNamLV > 5 && danhGiaTot == true) Debug.Log("Du dieu kien thang chuc");
        else Debug.Log("khong du dieu kien thang chuc");
        Debug.Log("======================================");
    }

    // Bài Tập 15: Kiểm Tra Điều Kiện Miễn Phí Vận Chuyển
    void BaiTap15(int giaDon)
    {
        // Nhập giá trị đơn hàng từ bàn phím
        // Kiểm tra nếu giá trị đơn hàng >= 500,000 đồng thì được miễn phí vận chuyển
        if (giaDon >= 500000) Debug.Log("duoc mien phi van chuyen");
        else Debug.Log("khong duoc mien phi van chuyen");
        Debug.Log("======================================");
    }

    // Bài Tập 16: Tính Thuế Thu Nhập Cá Nhân
    void BaiTap16(float thuNhap)
    {
        // Nhập thu nhập từ bàn phím
        float thue;
        // Tính thuế thu nhập cá nhân dựa trên mức thu nhập
        if (thuNhap <= 10000000) thue = thuNhap * 0.05f;
        else if (thuNhap > 10000000 && thuNhap <= 20000000) thue = thuNhap * 0.1f;
        else thue = thuNhap * 0.2f;
        Debug.Log("thue thu nhap la : " + thue);
        Debug.Log("======================================");
    }

    // Bài Tập 17: Tính Điểm Trung Bình Của Môn Học
    void BaiTap17(float toan, float van, float anh)
    {
        // Nhập điểm của 3 bài kiểm tra từ bàn phím
        float diemTB = (toan + van + anh) / 3;
        // Tính điểm trung bình và kiểm tra xem học sinh có đạt yêu cầu hay không (>= 5.0)
        if (diemTB >= 5) Debug.Log("Dat yeu cau");
        else Debug.Log("khong dat yeu cau");
        Debug.Log("======================================");
    }

    // Bài Tập 18: Kiểm Tra Điều Kiện Nhập Hàng
    void BaiTap18(int soHang, bool remainingSpace)
    {
        // Nhập số lượng hàng hiện tại và kiểm tra khả năng nhập thêm hàng (dưới 100 và còn chỗ)
        if (soHang < 100 && remainingSpace == true) Debug.Log("co the nhap them hang");
        else Debug.Log("khong the nhap them hang");
        Debug.Log("======================================");
    }

    // Bài Tập 19: Tìm Số Lớn Hơn 10
    void BaiTap19(int a)
    {
        // Nhập một số từ bàn phím
        // Kiểm tra xem số đó có lớn hơn 10 hay không
        if (a > 10) Debug.Log(a + " lon hon 10");
        else Debug.Log(a + "khong lon hon 10");
        Debug.Log("======================================");
    }

    // Bài Tập 20: Kiểm Tra Điều Kiện Đăng Ký Khóa Học
    void BaiTap20(float diemTK, bool HTBasic, bool thuGT)
    {
        // Nhập điểm tổng kết và các điều kiện khác từ bàn phím
        // Kiểm tra xem học sinh có đủ điều kiện đăng ký khóa học nâng cao không
        if (diemTK >= 7 && HTBasic == true && thuGT == true) Debug.Log("du dieu kien tham gia khoa nang cao");
        else Debug.Log("khong du dieu kien tham gia khoa nang cao");
        Debug.Log("======================================");
    }
}
