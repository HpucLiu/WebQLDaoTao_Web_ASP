using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    
    public partial class Login : System.Web.UI.Page
    {
        AccountDAO tkDAO = new AccountDAO();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btDangNhap_Click(object sender, EventArgs e)
        //{
        //    string username = txtUsername.Text;
        //    string password = txtPassword.Text;
        //    if (tkDAO.checkLogin(username,password))
        //    {
        //        Session["username"] = username;
        //        Response.Redirect("Default.aspx");
        //    }
        //    else
        //    {
        //        lbThongBao.Text = "Sai Tài Khoản hoặc Mật Khẩu! Nhập lại";
        //    }
        //}
        protected void btDangNhap_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            if (tkDAO.checkLogin(username, password)) //thanh cong
            {
                Session["username"] = username;
                Response.Redirect("Default.aspx");
            }
            else //that bai
            {
                lbThongBao.Text = " Đăng nhập thất bại do sai tên hoặc mật khẩu." ;
            }
        }
    }
}