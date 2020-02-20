using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectfri
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sbyid(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int tid = int.Parse(TextBox1.Text);
            
            var data=ad.getstu(tid);
            GridView1.DataSource = data;
            GridView1.DataBind();
            
           

        }
    }
}