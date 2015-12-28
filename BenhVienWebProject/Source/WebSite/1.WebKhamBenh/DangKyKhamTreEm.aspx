<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" CodeFile="DangKyKhamTreEm.aspx.cs" Inherits="DangKyKhamTreEm" %>
<%@ Register Src="UserControl/UCNgayThangNam.ascx" TagName="UCNgayThangNam" TagPrefix="uc1" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <div>
        &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp;&nbsp; <span style="font-size: 9pt; color: #006633">&nbsp;ĐĂNG KÝ CHO TRẺ EM<br />
        </span>
        <br />
        <br />
        <br />
        Ngày Đăng ký&nbsp;
        <uc1:UCNgayThangNam ID="UCNgayThangNam2" runat="server" />
        <br />
        <br />
        Họ Tên &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;
        <asp:TextBox ID="txtHotenTre" runat="server" Width="295px"></asp:TextBox>&nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtHotenTre"
            ErrorMessage="Nhập Trẻ Em"></asp:RequiredFieldValidator><br />
        <br />
        Ngày Sinh &nbsp;&nbsp; &nbsp; &nbsp;
        <uc1:UCNgayThangNam ID="UCNgayThangNam1" runat="server" />
        <br />
        <br />
        Địa Chỉ &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;
        <asp:TextBox ID="txtDiachi" runat="server"></asp:TextBox><br />
        <br />
        Phái &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp; &nbsp;<asp:RadioButton ID="ckNam"
            runat="server" GroupName="Nam" Text="Nam" Width="61px" Checked="True" />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp; &nbsp;<asp:RadioButton ID="ckNu"
            runat="server" GroupName="Nam" Text="Nữ" Width="57px" /><br />
        <br />
        Triệu chứng 
        <br />
        &nbsp;
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:TextBox ID="txtTCtreem" runat="server" Height="40px" Width="226px"></asp:TextBox>
        &nbsp; &nbsp;&nbsp;&nbsp; &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2"
            runat="server" ControlToValidate="txtTCtreem" ErrorMessage="Nhập Triệu Chứng"></asp:RequiredFieldValidator><br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        <asp:Label ID="Label1" runat="server" ForeColor="Red" Width="116px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
        &nbsp; &nbsp; &nbsp;<asp:Label ID="Label2" runat="server" ForeColor="Red" Width="101px"></asp:Label>
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;<br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <asp:Button ID="btDangKy" runat="server" OnClick="btDangKy_Click" Text="Đăng ký"
            Width="135px" /><br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;
        <br />
        <br />
        Số lượng người đã đăng ký :
        <asp:Label ID="lbsoluong" runat="server"></asp:Label></div>
</asp:Content>