using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud
{
    public partial class showf : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!this.IsPostBack)
            {
                ADOLayer ad = new ADOLayer();
                var data = ad.GetallrecordsofF();
                GridView1.DataSource = data;
                GridView1.DataBind();
            }

        }
    }
}