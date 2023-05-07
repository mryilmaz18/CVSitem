using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminYetenekler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_YetenekTableAdapter td = new
                DataSet1TableAdapters.Tbl_YetenekTableAdapter();
            Repeater1.DataSource = td.YetenekListesi();
            Repeater1.DataBind();
        }
    }
}