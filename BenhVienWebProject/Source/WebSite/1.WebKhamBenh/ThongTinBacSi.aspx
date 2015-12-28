<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ThongTinBacSi.aspx.cs" Inherits="ThongTinBacSi" Title="Untitled Page"EnableEventValidation="false" %>
<%@ Register Src="UserControl/UCNgayThangNam.ascx" TagName="UCNgayThangNam" TagPrefix="uc1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table border="0" cellpadding="0" cellspacing="0" style="width: 100%">
        <tr>
            <td colspan="2" style="height: 19px; text-align: center">
                &nbsp;</td>
        </tr>
        <tr>
            <td style="width: 23%; height: 23px">
                Danh sách khoa</td>
            <td style="height: 23px">
                <asp:DropDownList ID="DropDownList1" runat="server" AutoPostBack="True" DataSourceID="ObjectDataSource1"
                    DataTextField="Ten" DataValueField="Ma" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged"
                    Width="158px">
                </asp:DropDownList>
                <asp:ObjectDataSource ID="ObjectDataSource1" runat="server" SelectMethod="DanhSachKhoa"
                    TypeName="LibraryDKKB.ConTrol.KhoaControl"></asp:ObjectDataSource>
                </td>
        </tr>
    </table>
    &nbsp;&nbsp;
    <br />
    Danh sách Bác Sĩ&nbsp;
    <br />
    <br />
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" Width="409px">
        <Columns>
        <asp:TemplateField HeaderText="STT">
                <ItemTemplate><%# Container.DataItemIndex + 1 %></ItemTemplate>
            </asp:TemplateField> 

            <asp:BoundField DataField="Ten" HeaderText="Họ T&#234;n B&#225;c Si" SortExpression="Ten" />
            <asp:BoundField DataField="DiaChi" HeaderText="Địa Chỉ" SortExpression="DiaChi" />
            <asp:BoundField DataField="NgaySinh" HeaderText="Ng&#224;y Sinh" SortExpression="NgaySinh" />
        </Columns>
    </asp:GridView>
    <br />
    Có
    <asp:Label ID="Label1" runat="server" ForeColor="Red" Text="0" Width="5px"></asp:Label>
    Dữ Liệu<br />
    <asp:ObjectDataSource ID="ObjectDataSource2" runat="server" SelectMethod="ThongTinBacSiTrongKhoa"
        TypeName="LibraryDKKB.ConTrol.BacSiControl">
        <SelectParameters>
            <asp:ControlParameter ControlID="DropDownList1" Name="MaKhoa" PropertyName="SelectedValue"
                Type="Int32" />
        </SelectParameters>
    </asp:ObjectDataSource>
</asp:Content>

