<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" CodeFile="DangKyKhamBenh.aspx.cs" Inherits="DangKyKhamBenh" EnableEventValidation="false"%>
<%@ Register Src="UserControl/UCNgayThangNam.ascx" TagName="UCNgayThangNam" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">



   <div style="text-align: left">
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; ĐĂNG KÝ KHÁM BỆNH<br />
       <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
           <tr>
               <td style="width: 18%; height: 30px">
        &nbsp;Chọn Ngày
               </td>
               <td style="width: 55%; height: 30px">
        <uc1:UCNgayThangNam ID="UCNgay" runat="server" />
               </td>
               <td style="width: 115px; height: 30px">
                   <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text=" SLượng ĐK"
                       Width="100px" /></td>
           </tr>
           <tr>
               <td colspan="3" style="height: 29px">
        Số lượng người đã đăng ký:<asp:Label ID="lbSoNguoi" runat="server" ForeColor="Red"></asp:Label>/
                   <asp:Label ID="lbSLNguoi" runat="server" Text="Label"></asp:Label>
                   &nbsp; &nbsp; &nbsp;<asp:Label ID="lbThongBaoDK" runat="server" ForeColor="Red"></asp:Label></td>
           </tr>
           <tr>
               <td style="width: 18%; height: 101px;" valign="top">
        Triệu Chứng 
               </td>
               <td colspan="2" style="height: 101px" valign="top">
        <asp:TextBox ID="txtTCnguoilon" runat="server" TextMode="MultiLine" Width="266px" Height="75px"></asp:TextBox>
                   <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTCnguoilon"
                       ErrorMessage="Không Được Để Trống."></asp:RequiredFieldValidator></td>
           </tr>
           <tr>
               <td style="width: 18%; height: 38px">
               </td>
               <td style="width: 55%; height: 38px">
                   &nbsp;<asp:HyperLink ID="HyperLink2" runat="server" NavigateUrl="~/DangKyKhamTreEm.aspx">Đăng Ký Khám Cho Trẻ Em</asp:HyperLink></td>
               <td style="width: 115px; height: 38px">
        <asp:Button ID="Button1" runat="server" Text="Đăng ký" OnClick="Button1_Click" /></td>
           </tr>
           <tr>
               <td style="height: 53px" colspan="2">
                   <asp:Label ID="lbSoDiKham" runat="server" ForeColor="Red"></asp:Label><br />
                   <asp:Label ID="lbThoiGian" runat="server"></asp:Label></td>
               <td style="width: 115px; height: 53px">
                   </td>
           </tr>
       </table>
        <br />
        <asp:Label ID="lbThongBao" runat="server"></asp:Label><br />
        <br />
       &nbsp; &nbsp;&nbsp;&nbsp;<br />
       &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
       <br />
        &nbsp;
        <br />
        &nbsp;<br />
        <br />
       &nbsp;<br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp;&nbsp;<br />
        <br />
        <br />
        &nbsp; &nbsp; &nbsp;<br />
        <br />
        &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp; &nbsp;
        &nbsp;<br />
        &nbsp; &nbsp;&nbsp;
    </div>

</asp:Content>