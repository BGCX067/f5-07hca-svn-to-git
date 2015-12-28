using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using LibraryDKKB;
using LibraryDKKB.Info;
using LibraryDKKB.ConTrol;
public partial class DangKyKhamTreEm : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if ((int)Session["Login"] == 0)
            Response.Redirect("~/DangNhap.aspx");
        if ((string)Session["LoaiNguoiDung"] == "Bac si")
            Response.Redirect("~/KhongCoChucNang.aspx");

    }
    protected void btDangKy_Click(object sender, EventArgs e)
    {

        
        // kiem tra so luong nguoi da dang ky trong ngay
        PhieuDangKyControl pdkctr = new PhieuDangKyControl();
        int SluongDK = pdkctr.DemSLBenhNhanDKTrongNgay(UCNgayThangNam2.NgayThang);
        ThamSoControl tsctr = new ThamSoControl();
        ThamSoInfo tsinfo = new ThamSoInfo();
        tsinfo=tsctr.spLayThongTinBangThamSoCoMa(1);
        int SLDKToiDa = tsinfo.GiaTri;
        if (SluongDK > SLDKToiDa)
        {
            // khong cho dang ky
            Label1.Text = "So Luong DK Vuot Muc cho Phep,Chon Ngay Khac Di";
            return;
        }
        Label1.Text = "";
        int MaNguoiLon;
        int MaTK = (int)Session["MaTK"];
        NguoiLonControl nglonctr = new NguoiLonControl();
        MaNguoiLon = nglonctr.MaBenhNhanKhiBietMaTK(MaTK);
        
        //dang ky cho tre em
       
        // lay ma nguoi lon dang online= ma nguoi lon
      //  int MaBenhNhan = 3;
        BenhNhanControl ctrBN = new BenhNhanControl();
        BenhNhanInfo infoBN = new BenhNhanInfo();
        infoBN.Ten = txtHotenTre.Text;
        infoBN.NgaySinh = UCNgayThangNam1.NgayThang;
        infoBN.DiaChi = txtDiachi.Text;
        if (ckNam.Checked == true)
            infoBN.Phai = "Nam";
        else
            infoBN.Phai = "Nu";
        ctrBN.ThemThongTinBenhNhan(infoBN);       


        //nhap cac thong tin
        //luu xuong bang benh nhan

        //lay ma tre em vua moi luu= ma benh nhan

        //lay ma nguoi lon= ma nguoi lon dang Online
        TreEmControl ctrTE = new TreEmControl();
        TreEmInfo infoTE = new TreEmInfo();

        //int MaNguoiLon = 3;       
        infoBN = ctrBN.ThongTinBenhNhanVuaThem();
        infoTE.MaBenhNhan = infoBN.Ma;
        infoTE.MaNguoiLon = MaNguoiLon;
        ctrTE.ThemTreEm(infoTE);
       // lb.Text = "Them Thanh Cong Benh Nhan Tre Em";
        // luu xuong bang tre em

        //luu xuong bang Dang ky
        PhieuDangKyControl ctrpdk = new PhieuDangKyControl();
        PhieuDangKyInfo infopdk = new PhieuDangKyInfo();
        infopdk.MaBenhNhan = MaNguoiLon;
        infopdk.Ngay = UCNgayThangNam2.NgayThang;
        infopdk.TrieuChung = txtTCtreem.Text;
        ctrpdk.sp_ThemPhieuDangKy(infopdk);
       int soluong = ctrpdk.DemSLBenhNhanDKTrongNgay(infopdk.Ngay);
       lbsoluong .Text = soluong.ToString();
       Label2.Text = "Them Thanh Cong Dang ky ";
    
    }
}
