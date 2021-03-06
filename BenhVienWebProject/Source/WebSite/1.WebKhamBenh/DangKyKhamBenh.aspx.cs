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


public partial class DangKyKhamBenh : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataService._ConnectionString = ConfigurationManager.ConnectionStrings["QLConnectionString"].ConnectionString;
        
        if ((int)Session["Login"] == 0)
            Response.Redirect("~/DangNhap.aspx");
        if ((string)Session["LoaiNguoiDung"] == "Bac si")
              Response.Redirect("~/KhongCoChucNang.aspx");
        ThamSoControl tsctr= new ThamSoControl();
        ThamSoInfo tsinfo = new ThamSoInfo();
        tsinfo = tsctr.spLayThongTinBangThamSoCoMa(1);// so nguoi dang ky toi da
        lbSLNguoi.Text = tsinfo.GiaTri.ToString();
        PhieuDangKyControl pdkctr = new PhieuDangKyControl();
        //if (!IsPostBack)

        DateTime ngaytam = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
        {
            int sl = pdkctr.DemSLBenhNhanDKTrongNgay(ngaytam);
            lbSoNguoi.Text = sl.ToString();
            
        }

       
       
    }
   
 
    protected void Button1_Click(object sender, EventArgs e)
    {

        // lay ma benh nhan tu ma dang nhap ma tai khoan
        int MaNguoiLon;
        int MaTK = (int)Session["MaTK"];
        NguoiLonControl nglonctr = new NguoiLonControl();
        MaNguoiLon = nglonctr.MaBenhNhanKhiBietMaTK(MaTK);
        // luu vao phieu dang ky
        PhieuDangKyControl pdkctr = new PhieuDangKyControl();
        PhieuDangKyInfo pdkinf = new PhieuDangKyInfo();
        pdkinf.MaBenhNhan = MaNguoiLon;
        pdkinf.Ngay = UCNgay.NgayThang;
        pdkinf.TrieuChung = txtTCnguoilon.Text;
        // them phieu dang ky
        try
        {
            pdkctr.sp_ThemPhieuDangKy(pdkinf);
            // lay ma phieu dang ky len
           // int SoTT = pdkctr.LayMaPhieuDangKyTuMaBenhNhan(MaNguoiLon, pdkinf.Ngay);
             int SoTT = pdkctr.DemSLBenhNhanDKTrongNgay(UCNgay.NgayThang);
            lbSoDiKham.Text = "Số đi khám bệnh là :" + SoTT.ToString();
            int SoLuongNguoi = int.Parse(lbSoNguoi.Text);

        }
        catch
        {

        }
       
    }

    protected void btDangKy_Click(object sender, EventArgs e)
    {
    }
       
    protected void Button2_Click(object sender, EventArgs e)
    {
        //lay do luong phieu dang ky trong ngay
        PhieuDangKyControl pdkctr = new PhieuDangKyControl();
        DateTime ngay= UCNgay.NgayThang;
        DateTime ngayhientai = DateTime.Now;
        

        //if (DateTime.Compare(ngay ,ngayhientai)==-1)
        //{
        //    lbThongBaoDK.Text = "Ngay Dang ky Phai la ngay tuong lai";
        //    btDK.Enabled = false;
        //    return;        //}

      
         int sl=pdkctr.DemSLBenhNhanDKTrongNgay(ngay);
         lbSoNguoi.Text = sl.ToString();
        // hoi xem so luong nguoi dang ky co nho hon so luong nguoi toi da ko
         if (sl < int.Parse(lbSLNguoi.Text))
         {
             // moi cho dang ky
             //lbThongBaoDK.Text = " Dang Ky Thanh Cong";
         }
         else
         {
             lbThongBaoDK.Text = " Het Cho Dang ky, Chon Ngay khac Di";
         }


    }
    /*
    protected void btDK_Click(object sender, EventArgs e)
    {
        // lay ma benh nhan tu ma dang nhap ma tai khoan
        int MaNguoiLon;
        int MaTK=(int)Session["MaTK"];
        NguoiLonControl nglonctr = new NguoiLonControl();
        MaNguoiLon = nglonctr.MaBenhNhanKhiBietMaTK(MaTK);
        // luu vao phieu dang ky
        PhieuDangKyControl pdkctr = new PhieuDangKyControl();
        PhieuDangKyInfo pdkinf = new PhieuDangKyInfo();
        pdkinf.MaBenhNhan = MaNguoiLon;
        pdkinf.Ngay = UCNgay.NgayThang;
        pdkinf.TrieuChung = txtTCnguoilon.Text;
        // them phieu dang ky
        try
        {
            pdkctr.sp_ThemPhieuDangKy(pdkinf);
            // lay ma phieu dang ky len
             int SoTT=pdkctr.LayMaPhieuDangKyTuMaBenhNhan(MaNguoiLon, pdkinf.Ngay);
             lbSoDiKham.Text = "Số đi khám bệnh là :" + SoTT.ToString();
             int SoLuongNguoi = int.Parse(lbSoNguoi.Text);

        }
        catch
        {

        }


    }
     */
}
