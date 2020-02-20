using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace projectfri
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void update(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int tid = int.Parse(TextBox1.Text);
           // string tname = TextBox2.Text;
           // string tlocation = TextBox3.Text;
            string techdomain = TextBox4.Text;
           // string StartDate = TextBox5.Text;
            ad.updatedata(tid, techdomain);
        }
    }
}