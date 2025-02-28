using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    public partial class QLSinhVien : System.Web.UI.Page
    {
        SinhVienDAO svDAO = new SinhVienDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void btThem_Click(object sender, EventArgs e)
        {
            string masv = txtMaSV.Text;
            string hosv = txtHoSv.Text;
            string tensv = txtTenSV.Text;
            Boolean gioitinh = rdNam.Checked ? true : false;
            DateTime ngaysinh = DateTime.Parse(txtNgaysinh.Text);
            string noisinh = txtNoiSinh.Text;
            string diachi = txtDiaChi.Text;
            string makh = ddlMaKhoa.SelectedValue;
            SinhVien sv = new SinhVien { MaSV = masv, HoSV = hosv, TenSV = tensv, GioiTinh = gioitinh, NgaySinh = ngaysinh, NoiSinh = noisinh, DiaChi = diachi, MaKH = makh };
            svDAO.Insert(sv);
            gvsinhvien.DataBind();
        }

        protected void gvsinhvien_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}