using System;
using System.Data.SqlClient;
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

public partial class ThongTinBacSi : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        DataService._ConnectionString = ConfigurationManager.ConnectionStrings["QLConnectionString"].ConnectionString;
        Label1.Text = GridView1.Rows.Count.ToString();
        
    }
    protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
    {
        int m = int.Parse(DropDownList1.SelectedValue.ToString());
        List<BacSiInfo> arr = new List<BacSiInfo>();
        BacSiControl bsctr = new BacSiControl();
        arr=bsctr.ThongTinBacSiTrongKhoa(m);
        Label1.Text = arr.Count.ToString();
        GridView1.DataSource = arr;
        GridView1.DataBind();


    }
}
