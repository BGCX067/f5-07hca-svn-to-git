<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="DangKyTaiKhoan.aspx.cs" Inherits="DangKyTaiKhoan" Title="Untitled Page" %>

<%@ Register Src="UserControl/UCDangKyTaiKhoan.ascx" TagName="UCDangKyTaiKhoan" TagPrefix="uc1" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    &nbsp;<uc1:UCDangKyTaiKhoan ID="UCDangKyTaiKhoan1" runat="server" OnLoad="UCDangKyTaiKhoan1_Load" />
</asp:Content>

