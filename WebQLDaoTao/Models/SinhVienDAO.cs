﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WebQLDaoTao.Models
{
    public class SinhVienDAO
    {
        //phuong thuc doc tat ca sinh vien
        public List<SinhVien> getAll()
        {
            List<SinhVien> dsSinhVien = new List<SinhVien>();
            //1.Mo ket noi CSDL
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("select * from SinhVien", conn);
            //3.thuc thi ket qua;
            SqlDataReader dr = cmd.ExecuteReader();
            //4.xu ly ket qua tra ve
            while (dr.Read())
            {
                //tao doi tuong sinhvien
                SinhVien sv = new SinhVien
                {
                    MaSV = dr["MaSV"].ToString(),
                    HoSV = dr["Hosv"].ToString(),
                    TenSV = dr["Tensv"].ToString(),
                    GioiTinh = Boolean.Parse(dr["gioitinh"].ToString()),
                    NgaySinh = DateTime.Parse(dr["ngaysinh"].ToString()),
                    NoiSinh = dr["noisinh"].ToString(),
                    DiaChi = dr["diachi"].ToString(),
                    MaKH = dr["Makh"].ToString()
                };

                //add vao dsSinhVien
                dsSinhVien.Add(sv);
            }
            return dsSinhVien;
        }
        //phuong thuc cập nhật thông tin sinh vien vao CSDL
        public int Update(SinhVien sv)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("update sinhvien set hosv=@hosv, tensv=@tensv, gioitinh=@gioitinh, ngaysinh = @ngaysinh, noisinh = @noisinh, diachi = @diachi, makh = @makh where masv = @masv", conn);
            cmd.Parameters.AddWithValue("@masv", sv.MaSV);
            cmd.Parameters.AddWithValue("@hosv", sv.HoSV);
            cmd.Parameters.AddWithValue("@tensv", sv.TenSV);
            cmd.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
            cmd.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
            cmd.Parameters.AddWithValue("@noisinh", sv.NoiSinh);
            cmd.Parameters.AddWithValue("@diachi", sv.DiaChi);
            cmd.Parameters.AddWithValue("@makh", sv.MaKH);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }
        //phuong thuc xoá SV
        public int Delete(SinhVien sv)
        {
            //1.Mo ket noi CSDL
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            //2.tao truy van
            SqlCommand cmd = new SqlCommand("delete from sinhvien where masv=@masv", conn);
            cmd.Parameters.AddWithValue("@masv", sv.MaSV);
            //3.thuc thi ket qua;
            return cmd.ExecuteNonQuery();
        }
        //.....
        public int Insert(SinhVien sv)
        {
            SqlConnection conn = new
            SqlConnection(ConfigurationManager.ConnectionStrings["WebQLDaoTao_ConStr"].ConnectionString);
            conn.Open();
            SqlCommand cmd = new SqlCommand("insert into sinhvien (masv, hosv, tensv, gioitinh,ngaysinh, noisinh, diachi, makh) values(@masv, @hosv, @tensv, @gioitinh, @ngaysinh, @noisinh, @diachi, @makh)", conn);
            cmd.Parameters.AddWithValue("@masv", sv.MaSV);
            cmd.Parameters.AddWithValue("@hosv", sv.HoSV);
            cmd.Parameters.AddWithValue("@tensv", sv.TenSV);
            cmd.Parameters.AddWithValue("@gioitinh", sv.GioiTinh);
            cmd.Parameters.AddWithValue("@ngaysinh", sv.NgaySinh);
            cmd.Parameters.AddWithValue("@noisinh", sv.NoiSinh);
            cmd.Parameters.AddWithValue("@diachi", sv.DiaChi);
            cmd.Parameters.AddWithValue("@makh", sv.MaKH);
            return cmd.ExecuteNonQuery();
        }
    }
}