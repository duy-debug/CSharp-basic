using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_1
{
    public class SinhVien
    {
        #region biến lớp
        // khai báo biến lớp
        private int maSV;
        private string tenSV;
        private float diemThiDH;
        #endregion
        #region constructor
        // khai báo constructor
        // gán giá trị mặc định cho đối tượng
        public SinhVien()
        {
            this.maSV = 0;
            this.tenSV = "No name";
            this.diemThiDH = 0;
        }
        // khai báo constructor
        // khởi tạo giá trị cho đối tượng do người dùng truyền vào
        public SinhVien(int maSV, string tenSV, float diemThiDH)
        {
            this.maSV = maSV;
            this.tenSV = tenSV;
            this.diemThiDH = diemThiDH;
        }
        #endregion
        #region Properties
        // khai báo Properties để có thể truy xuất sửa đổi dữ liệu:
        public string TenSV
        {
            get { return tenSV; } // Trả về giá trị của `tenSV`(đọc)
            set { tenSV = value; } // Gán giá trị mới cho `tenSV(ghi)
        }
        public int MaSV
        {
            get { return maSV; } // Trả về giá trị của `maSV`(đọc)
            set { maSV = value; } // Gán giá trị mới cho `maSV`(ghi)
        }
        public float DiemThiDH
        {
            get { return diemThiDH; }
            set { diemThiDH = value;}
        }
        #endregion
        #region các phương thức
        // Phương thức Tostring
        public override string ToString()
        {
            return this.MaSV + "\t" + this.TenSV;  
        }
        //support method
        // kiểm tra điều kiện nhập sinh viên mới 
        private bool CheckDiemThiDH()
        {
            return (this.diemThiDH - 21 >= 0);
        }
        //service method (xuât thông tin)
        public void XuatThongTin()
        {
            if(CheckDiemThiDH()==false)
                Console.WriteLine("Điểm thi DH < 21, cần kiêm tra  lại hồ sơ sinh viên này ");
            else
                Console.WriteLine(ToString());
        }
        #endregion
    }
}
