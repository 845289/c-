using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;

namespace WebApplication1
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!this.IsPostBack)
            {
                ADOlayer a1 = new ADOlayer();
                var stlist = a1.GetAllRecords();
                GridView1.DataSource = stlist;
                GridView1.DataBind();
            }

        }
        public static void Getdata()
        {

        }
    }
}