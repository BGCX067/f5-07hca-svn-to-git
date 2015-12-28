using System;
using System.Data;
using System.Configuration;
using System.Collections.Generic;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using LibraryDKKB;
using LibraryDKKB.Info;
using LibraryDKKB.ConTrol;
public partial class XemLichTrucBacSi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataService._ConnectionString = ConfigurationManager.ConnectionStrings["QLConnectionString"].ConnectionString;

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        List<LichTrucInfo> arr = new List<LichTrucInfo>();
        // nfldjfljdfljd;f 10-8
        LichTrucControl ltruc = new LichTrucControl();
        LichTrucInfo info = new LichTrucInfo();
       arr= ltruc.DanhSachBacSiTrucTrongNgay(UCNgayThangNam1.NgayThang);
       GridView1.DataSource = arr;
       GridView1.DataBind();




    }
}
