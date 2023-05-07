using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminHobiler : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_HobıTableAdapter td = new
                DataSet1TableAdapters.Tbl_HobıTableAdapter();
            Repeater1.DataSource = td.HobiListesi();
            Repeater1.DataBind();
        }
    }
}