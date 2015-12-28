<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="XemLichTrucBacSi.aspx.cs" Inherits="XemLichTrucBacSi" Title="Untitled Page"  EnableEventValidation="false"%>

<%@ Register Src="UserControl/UCNgayThangNam.ascx" TagName="UCNgayThangNam" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td colspan="3" style="height: 13px; text-align: center">
                <span style="font-size: 16pt; color: #669966">Thông Tin Lịch Trực Bác Sĩ<br />
                </span>
            </td>
        </tr>
        <tr>
            <td style="width: 19%; height: 13px">
                Ngày</td>
            <td colspan="2" style="height: 13px">
                <uc1:UCNgayThangNam ID="UCNgayThangNam1" runat="server" />
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Xem" /></td>
        </tr>
        <tr>
            <td style="width: 19%; height: 13px">
            </td>
            <td colspan="2" style="height: 13px; text-align: center">
                Danh Sách Bác Sỉ Trực Trong Ngày<br />
            </td>
        </tr>
        <tr>
            <td colspan="3" style="height: 13px; text-align: center">
                <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                    <Columns>
                        <asp:BoundField DataField="TenBSi" HeaderText="TenBSi" SortExpression="TenBSi" />
                        <asp:BoundField DataField="MaBacSi" HeaderText="MaBacSi" SortExpression="MaBacSi" />
                        <asp:BoundField DataField="Phong" HeaderText="Phong" SortExpression="Phong" />
                        <asp:BoundField DataField="GioBatDau" HeaderText="GioBatDau" SortExpression="GioBatDau" />
                        <asp:BoundField DataField="Ngay" HeaderText="Ngay" SortExpression="Ngay" />
                        <asp:BoundField DataField="GioKetThuc" HeaderText="GioKetThuc" SortExpression="GioKetThuc" />
                        <asp:HyperLinkField DataNavigateUrlFields="MaBacSi" DataNavigateUrlFormatString="~/ChiTietBacSi.aspx"
                            HeaderText="Xem Chi Tiết" Text="Xem" />
                    </Columns>
                </asp:GridView>
                &nbsp;
            </td>
        </tr>
        <tr>
            <td style="width: 19%; height: 13px">
            </td>
            <td style="width: 237px; height: 13px">
            </td>
            <td style="width: 31%; height: 13px">
            </td>
        </tr>
    </table>
</asp:Content>

