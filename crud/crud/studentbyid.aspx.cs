using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud
{
    public partial class studentbyid : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int sid = int.Parse(TextBox1.Text);
           var data= ad.getstu(sid);
            GridView1.DataSource = data;
            GridView1.DataBind();
        }
    }
}