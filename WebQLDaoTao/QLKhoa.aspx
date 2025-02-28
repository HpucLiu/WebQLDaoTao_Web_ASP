<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="QLKhoa.aspx.cs" Inherits="WebQLDaoTao.QLKhoa" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="Main" runat="server">
    <h2> TRANG QUẢN TRỊ KHOA </h2>
    <div>
        <button type="button" class="btn btn-info btn-lg" style="margin-bottom: 5px;" data-toggle="modal" data-target="#modalOpenAddButton">Thêm mới</button>
        <!-- Modal -->
        <div class="modal fade" id="modalOpenAddButton" role="dialog">
            <div class="modal-dialog">

                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">THÊM MỚI KHOA</h4>
                    </div>
                    <div class="modal-body">
                        <div>
                            <div class="form-group">
                                <label>Mã Khoa</label>
                                <asp:TextBox ID="txtMaKH" CssClass="form-control" runat="server"></asp:TextBox>
                            </div>

                            <div class="form-group">
                                <label>Tên Khoa</label>
                                <asp:TextBox ID="txtTenKH" CssClass="form-control" runat="server" ControlToValidate="txtTenmh"></asp:TextBox>
                            </div>
                            <div class="form-group">
                                <asp:Button ID="btnThem" class="btn btn-success" OnClick="btnThem_Click" runat="server" Text="Thêm" />
                            </div>
                        </div>
                    </div>
                    <asp:ValidationSummary ID="vsKq" runat="server" ForeColor="#FF3300" Font-Size="Medium" />
                    <div class="modal-footer">
                        <button type="button" class="btn btn-danger" data-dismiss="modal">Huỷ</button>
                    </div>
                </div>
            </div>
        </div>
    </div>
<div class="modal fade" id="exampleModal" tabindex="-1" aria-labelledby="exampleModalLabel" aria-hidden="true">
  <div class="modal-dialog">
    <div class="modal-content">
      <div class="modal-header">
        <h1 class="modal-title fs-5" id="exampleModalLabel">Modal title</h1>
        <button type="button" class="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
      </div>
      <div class="modal-body">
        ...
      </div>
      <div class="modal-footer">
        <button type="button" class="btn btn-secondary" data-bs-dismiss="modal">Close</button>
        <button type="button" class="btn btn-primary">Save changes</button>
      </div>
    </div>
  </div>
</div>
    <asp:GridView ID="gvKhoa" runat="server" AutoGenerateColumns="False" DataSourceID="obsKhoa" CssClass="table table-bordered table-hover" DataKeyNames="MaKH">
        <Columns>
            <asp:BoundField DataField="TenKH" HeaderText="Tên Khoa" SortExpression="TenKH" />
            <asp:BoundField DataField="MaKH" HeaderText="Mã Khoa" SortExpression="MaKH" />
            <asp:CommandField ButtonType="Button" ShowDeleteButton="True" ShowEditButton="True" />
        </Columns>
    </asp:GridView>
    <asp:ObjectDataSource ID="obsKhoa" runat="server" DataObjectTypeName="WebQLDaoTao.Models.Khoa" DeleteMethod="Delete" InsertMethod="Insert" SelectMethod="getAll" TypeName="WebQLDaoTao.Models.KhoaDAO" UpdateMethod="Update">
        <UpdateParameters>
            <asp:Parameter Name="makh" Type="String" />
            <asp:Parameter Name="tenkh" Type="String" />
        </UpdateParameters>
    </asp:ObjectDataSource>
<hr />
</asp:Content>
