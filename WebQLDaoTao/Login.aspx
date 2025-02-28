<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebQLDaoTao.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
<div class="panel panel-info">
        <div class="panel-heading">
            ĐĂNG NHẬP HỆ THỐNG
        </div>
        <div class="panel-body">
            <div class="form-horizontal">
                <div class="form-group">
                    <label class="control-label col-sm-3" for="email">
                        Tên đăng nhập:</label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtUsername" runat="server"  CssClass="form-control" placeholder="Enter username"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <label class="control-label col-sm-3" for="pwd"> Mật khẩu </label>
                    <div class="col-sm-9">
                        <asp:TextBox ID="txtPassword" runat="server" TextMode="Password" CssClass="form-control" placeholder="Enter password"></asp:TextBox>
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Button ID="btDangNhap" runat="server" Text="Đăng nhập" CssClass="btn btn-success" OnClick="btDangNhap_Click" />
                    </div>
                </div>
                <div class="form-group">
                    <div class="col-sm-offset-2 col-sm-10">
                        <asp:Label ID="lbThongBao" runat="server" Text="" ForeColor="#cc3300"></asp:Label>
                    </div>
                </div>
            </div>
        </div>
      </div>
    </asp:Content>
