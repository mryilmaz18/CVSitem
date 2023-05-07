using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CVSite
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataSet1TableAdapters.TblHakkımdaTableAdapter dt = new DataSet1TableAdapters.TblHakkımdaTableAdapter();
            Repeater1.DataSource = dt.HakkımdaListele();
            Repeater1.DataBind();

            DataSet1TableAdapters.Tbl_DeneyimTableAdapter dl = new DataSet1TableAdapters.Tbl_DeneyimTableAdapter();
            Repeater2.DataSource = dl.DeneyimListesi();
            Repeater2.DataBind();

            DataSet1TableAdapters.Tbl_EgitimTableAdapter de = new DataSet1TableAdapters.Tbl_EgitimTableAdapter();
            Repeater3.DataSource = de.EgitimListesi();
            Repeater3.DataBind();

            DataSet1TableAdapters.Tbl_YetenekTableAdapter dy = new DataSet1TableAdapters.Tbl_YetenekTableAdapter();
            Repeater4.DataSource = dy.YetenekListesi();
            Repeater4.DataBind();

            DataSet1TableAdapters.Tbl_HobıTableAdapter dh = new DataSet1TableAdapters.Tbl_HobıTableAdapter();
            Repeater5.DataSource = dh.HobiListesi();
            Repeater5.DataBind();

            DataSet1TableAdapters.Tbl_SertifikaTableAdapter ds = new DataSet1TableAdapters.Tbl_SertifikaTableAdapter();
            Repeater6.DataSource = ds.SertifikaListesi();
            Repeater6.DataBind();

            DataSet1TableAdapters.TblHakkımdaTableAdapter dtA = new DataSet1TableAdapters.TblHakkımdaTableAdapter();
            Repeater7.DataSource = dtA.HakkımdaListele();
            Repeater7.DataBind();

        }
        
    }
}