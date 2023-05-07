using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminEğitimler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_EgitimTableAdapter td = new
                DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            Repeater1.DataSource = td.EgitimListesi();
            Repeater1.DataBind();
        }
    }
}