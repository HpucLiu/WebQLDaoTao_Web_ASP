using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class AccountDAO
    {
        //public bool checkLogin(string username, string password)
        //{
        //    bool kq = false;
        //    SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
        //    conn.Open();
        //    SqlCommand cmd = new SqlCommand("select * from accounts where user=@user and pass=@pass", conn);
        //    cmd.Parameters.AddWithValue("@user", username);
        //    cmd.Parameters.AddWithValue("@pass", password);
        //    SqlDataReader dr = cmd.ExecuteReader();
        //    if (dr.Read())
        //        kq = true;
        //    return kq;
        //}
        public bool checkLogin(string username, string password)
        {
            bool kq = false;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString); conn.Open();
            SqlCommand cmd = new SqlCommand(" select* from taikhoan where tendangnhap=@tendangnhap and matkhau=@matkhau", conn);
            cmd.Parameters.AddWithValue("@tendangnhap ", username);
            cmd.Parameters.AddWithValue("@matkhau ", password);
            SqlDataReader rd = cmd.ExecuteReader();
            if (rd.Read())
                kq = true; //success
            return kq;
        }
        public Account findByUsername(string username)
        {
            Account tk = null;
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from  taikhoan where tendangnhap=@tendangnhap", conn);
            cmd.Parameters.AddWithValue("@tendangnhap", username);
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
                tk = new Account
                {
                    TenDangNhap = dr["tendangnhap"].ToString(),
                    MatKhau = dr["matkhau"].ToString(),
                    VaiTro = dr["vaitro"].ToString()
                };
            return tk;


        }
    }
}