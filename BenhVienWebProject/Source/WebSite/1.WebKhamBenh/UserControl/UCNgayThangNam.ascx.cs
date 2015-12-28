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

public partial class UserControl_UCNgayThangNam : System.Web.UI.UserControl
{
    private string _ngay;
    private DateTime _NgayThang;

    

    public string Ngay
    {
        get { return cbngay.Text; }
        set { cbngay.Text = value; }
    }


    private string _thang;

    public string Thang
    {
        get { return cbthang.Text; }
        set { cbthang.Text = value; }
    }


    private string _nam;

    public string Nam
    {
        get { return cbnam.Text; }
        set { cbnam.Text = value; }
    }

    
    void TaoNgay()
    {
        int i;
        for (i = 1; i <= 31; i++)        
            cbngay.Items.Add(i.ToString());
        for (i = 1; i <= 12; i++)
             cbthang.Items.Add(i.ToString());
        int nam=DateTime.Now.Year;
        for (i=nam - 40;i<= nam ; i++)
             cbnam.Items.Add(i.ToString());
         cbngay.Text = DateTime.Now.Day.ToString();
         cbthang.Text = DateTime.Now.Month.ToString();
         cbnam.Text = DateTime.Now.Year.ToString();

    }
    public DateTime NgayThang
    {
        get
        {


            int _Ngay = int.Parse(cbngay.SelectedItem.Text);
            int _Thang = int.Parse(cbthang.SelectedItem.Text);
            int _Nam = int.Parse(cbnam.SelectedItem.Text);
            try
            {
                DateTime tam = new DateTime(_Nam, _Thang, _Ngay);
                NgayThang = tam;
            }
            catch
            {
                _NgayThang = DateTime.Now;
            }
            return _NgayThang;
        }
        set { _NgayThang = value; }
    }
    protected void Page_Load(object sender, EventArgs e)
    {
            if(!IsPostBack)
             {
                 TaoNgay();
             }
    }

   
}
