using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class AdminSertifikalar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.Tbl_SertifikaTableAdapter td = new
                DataSet1TableAdapters.Tbl_SertifikaTableAdapter();
            Repeater1.DataSource = td.SertifikaListesi();
            Repeater1.DataBind();
        }
    }
}