using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ORPractice : MonoBehaviour
{
    // Start is called before the first frame update
    [Header("bai 1 : ")]
    public bool coVe = false;
    public bool vip = false;
    public bool dcMoi = false;
    [Header("bai 2 : ")]
    public bool nhat = false;
    public bool nhi = false;
    public bool ba = false;
    [Header("bai 3 : ")]
    public bool thuNhapOnDinh = false;
    public bool taiSanTheChap = false;
    public bool coNguoiBaoLanh = false;
    [Header("bai 4 : ")]
    public bool thanhTichXuatSac = false;
    public bool hoatDongNgoaiKhoaTot = false;
    public bool giaDinhKhoKhan = false;
    [Header("bai 5 : ")]
    public bool emailHopLe = false;
    public bool soDienThoaiXacThuc = false;
    public bool daDkQuaWed = false;
    [Header("bai 6 : ")]
    public bool coBangLai = false;
    public bool dangKiXeHopLe = false;
    public bool coBaoHiemXe = false;
    [Header("bai 7 : ")]
    public bool quanTriVien = false;
    public bool quyenTuyCapTuQuanLy = false;
    public bool coMaXacThuc = false;
    [Header("bai 8 : ")]
    public bool coThuGioiThieu = false;
    public bool hoanThanhKTDauVao = false;
    public bool coKinhNghiemLienQuan = false;
    [Header("bai 9 : ")]
    public bool coMaKhuyenMai = false;
    public bool laThanhVienVip = false;
    public bool trongTGMienPhi = false;
    [Header("bai 10 : ")]
    public bool chiTieuTrenMucYK = false;
    public bool khachHangThanThiet = false;
    public bool coKhuyenMai = false;
    void Start()
    {
        // Gọi từng bài tập để kiểm tra kết quả.
        BaiTap1(coVe,vip,dcMoi); // Kiểm tra vé vào cửa
        BaiTap2(nhat,nhi,ba); // Điều kiện trúng thưởng
        BaiTap3(thuNhapOnDinh, taiSanTheChap, coNguoiBaoLanh); // Kiểm tra điều kiện vay tiền
        BaiTap4(thanhTichXuatSac,hoatDongNgoaiKhoaTot,giaDinhKhoKhan); // Điều kiện nhận học bổng
        BaiTap5(emailHopLe,soDienThoaiXacThuc,daDkQuaWed); // Kiểm tra đăng ký sự kiện
        BaiTap6(coBangLai,dangKiXeHopLe,coBaoHiemXe); // Điều kiện lái xe
        BaiTap7(quanTriVien,quyenTuyCapTuQuanLy,coMaXacThuc); // Kiểm tra quyền truy cập tài liệu
        BaiTap8(coThuGioiThieu,hoanThanhKTDauVao,coKinhNghiemLienQuan); // Kiểm tra điều kiện tham gia khóa học
        BaiTap9(coMaKhuyenMai,laThanhVienVip,trongTGMienPhi); // Điều kiện tải ứng dụng miễn phí
        BaiTap10(chiTieuTrenMucYK,khachHangThanThiet,coKhuyenMai); // Điều kiện sử dụng dịch vụ đặc biệt
    }

    // Bài Tập 1: Kiểm Tra Vé Vào Cửa
    void BaiTap1(bool coVe, bool vip, bool dcMoi)
    {
        // Kiểm tra xem người dùng có thể vào sự kiện nếu có vé hợp lệ, là thành viên VIP, hoặc được mời
        if(coVe == true ||  vip == true || dcMoi == true)
        {
            Debug.Log("nguoi dung co the vao su kien");
        }
        else
        {
            Debug.Log("nguoi dung khong the vao su kien");
        }
    }

    // Bài Tập 2: Điều Kiện Trúng Thưởng
    void BaiTap2(bool nhat, bool nhi, bool ba)
    {
        // Kiểm tra xem người dùng có trúng thưởng nếu số vé của họ trúng giải nhất, nhì, hoặc ba
        if(nhat == true || nhi == true || ba == true)
        {
            Debug.Log("nguoi dung co trung thuong");
        }
        else
        {
            Debug.Log("nguoi dung khong trung thuong");
        }
    }

    // Bài Tập 3: Kiểm Tra Điều Kiện Vay Tiền
    void BaiTap3(bool thuNhapOnDinh, bool taiSanTheChap, bool coNguoiBaoLanh)
    {
        // Kiểm tra xem người dùng có đủ điều kiện vay tiền nếu có thu nhập ổn định, tài sản thế chấp, hoặc người bảo lãnh
        if(thuNhapOnDinh == true||taiSanTheChap == true|| coNguoiBaoLanh == true)
        {
            Debug.Log("nguoi dung du dieu kien vay");
        }
        else
        {
            Debug.Log("nguoi dung khong du dieu kien vay");
        }
    }

    // Bài Tập 4: Điều Kiện Nhận Học Bổng
    void BaiTap4(bool thanhTichXuatSac, bool hoatDongNgoaiKhoaTot, bool giaDinhkhoKhan)
    {
        // Kiểm tra xem học sinh có nhận được học bổng nếu có thành tích học tập xuất sắc, hoạt động ngoại khóa tốt, hoặc gia đình khó khăn
        if (thanhTichXuatSac == true || hoatDongNgoaiKhoaTot == true || giaDinhKhoKhan == true)
        {
            Debug.Log("hoc sinh duoc nhan hoc bong");
        }
        else
        {
            Debug.Log("hoc sinh khong duoc nhan hoc bong");
        }
    }

    // Bài Tập 5: Kiểm Tra Đăng Ký Sự Kiện
    void BaiTap5(bool emailHopLe, bool soDienThoaiXacThuc, bool daDkQuaWed)
    {
        // Kiểm tra xem người dùng có thể đăng ký sự kiện nếu có email hợp lệ, số điện thoại xác thực, hoặc đã đăng ký qua trang web
        if(emailHopLe == true|| soDienThoaiXacThuc == true ||  daDkQuaWed == true)
        {
            Debug.Log("nguoi dung co the dang ky su kien");
        }
        else
        {
            Debug.Log("nguoi dung khong the dang ky su kien");
        }
    }

    // Bài Tập 6: Điều Kiện Lái Xe
    void BaiTap6(bool coBangLai, bool dangKiXeHopLe, bool coBaoHiemXe)
    {
        // Kiểm tra xem người dùng có thể lái xe nếu có bằng lái, đã đăng ký xe hợp lệ, hoặc có bảo hiểm xe
        if (coBangLai == true || dangKiXeHopLe == true || coBaoHiemXe == true)
        {
            Debug.Log("nguoi dung co the lai xe");
        }
        else
        {
            Debug.Log("nguoi dung khong the lai xe");
        }
    }

    // Bài Tập 7: Kiểm Tra Quyền Truy Cập Tài Liệu
    void BaiTap7(bool quanTriVien, bool quyenTuyCapTuQuanLy, bool coMaXacThuc)
    {
        // Kiểm tra xem người dùng có quyền truy cập tài liệu nếu là quản trị viên, được cấp quyền truy cập từ quản lý, hoặc có mã xác thực
        if(quanTriVien == true || quyenTuyCapTuQuanLy == true || coMaXacThuc == true)
        {
            Debug.Log("nguoi dung co quyen truy cap tai lieu");
        }
        else
        {
            Debug.Log("nguoi dung khong co quyen truy cap tai lieu");
        }
    }

    // Bài Tập 8: Kiểm Tra Điều Kiện Tham Gia Khóa Học
    void BaiTap8(bool coThuGioiThieu, bool hoanThanhKTDauVao, bool coKinhNghiemLienQuan)
    {
        // Kiểm tra xem học sinh có thể tham gia khóa học đặc biệt nếu có thư giới thiệu từ giáo viên, đã hoàn thành bài kiểm tra đầu vào, hoặc có kinh nghiệm liên quan
        if(coThuGioiThieu == true || hoanThanhKTDauVao == true || coKinhNghiemLienQuan == true)
        {
            Debug.Log("hoc sinh co the tham gia khoa hoc dac biet");
        }
        else
        {
            Debug.Log("hoc sinh khong the tham gia khao hoc dac biet");
        }
    }

    // Bài Tập 9: Điều Kiện Tải Ứng Dụng Miễn Phí
    void BaiTap9(bool coMaKhuyenMai, bool laThanhVienVip, bool trongTGMienPhi)
    {
        // Kiểm tra xem người dùng có thể tải ứng dụng miễn phí nếu có mã khuyến mãi, là thành viên VIP, hoặc ứng dụng đang trong thời gian miễn phí
        if(coMaKhuyenMai ==  true || laThanhVienVip == true || trongTGMienPhi == true)
        {
            Debug.Log("nguoi dung duoc tai ung dung mien phi");
        }
        else
        {
            Debug.Log("nguoi dung khong duoc tai ung dung mien phi");
        }
    }

    // Bài Tập 10: Điều Kiện Sử Dụng Dịch Vụ Đặc Biệt
    void BaiTap10(bool chiTieuTrenMucYK, bool khachHangThanThiet, bool coKhuyenMai)
    {
        // Kiểm tra xem khách hàng có thể sử dụng dịch vụ đặc biệt nếu đã chi tiêu trên mức yêu cầu, là khách hàng thân thiết, hoặc có chương trình khuyến mãi
        if(chiTieuTrenMucYK == true || khachHangThanThiet == true || coKhuyenMai == true)
        {
            Debug.Log("khach hang co the su dung dich vu dac biet");
        }
        else
        {
            Debug.Log("khach hang khong the su dung dich vu dac biet");
        }
    }
}
