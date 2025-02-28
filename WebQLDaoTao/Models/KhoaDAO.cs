using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class KhoaDAO
    {
        public List<Khoa> getAll()
        {
            List<Khoa> dsKhoa = new List<Khoa>();
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("select * from Khoa", conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                //tao doi tuong Khoa
                Khoa kh = new Khoa
                {
                    MaKH = dr["MaKH"].ToString(),
                    TenKH = dr["TenKH"].ToString()
                };
                //add vao dsKhoa
                dsKhoa.Add(kh);
            }
            return dsKhoa;

        }
        public int Update(string makh, string tenkh)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("update khoa set tenkh=@tenkh where makh=@makh", conn);
            cmd.Parameters.AddWithValue("@tenkh", tenkh);
            cmd.Parameters.AddWithValue("@makh", makh);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }
        public int Delete(Khoa kh)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("delete from khoa where makh=@makh", conn);
            cmd.Parameters.AddWithValue("@makh", kh.MaKH);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }
        public int Insert(Khoa kh)
        {
            //1.Mo ket noi CSDL

            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("insert into khoa (makh, tenkh) values (@makh,@tenkh)", conn);
            cmd.Parameters.AddWithValue("@makh", kh.MaKH);
            cmd.Parameters.AddWithValue("@tenkh", kh.TenKH);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }
        //tim khoa theo ma
        public Khoa findById(string makh)
        {
            Khoa kq = null;
            //1.Mo ket noi CSDL
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("select * from Khoa where makh=@makh", conn);
            cmd.Parameters.AddWithValue("@makh", makh);
            //3.thuc thi ket qua;
            SqlDataReader dr = cmd.ExecuteReader();
            //4.xu ly ket qua tra ve
            if (dr.Read())
            {
                //tao doi tuong mon hoc
                kq = new Khoa
                {
                    MaKH = dr["MaKH"].ToString(),
                    TenKH = dr["TenKH"].ToString()
                };
            }
            return kq;
        }
        //....
    }
}