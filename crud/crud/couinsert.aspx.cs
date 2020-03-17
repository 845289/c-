using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace crud
{
    public partial class couinsert : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ADOLayer ad = new ADOLayer();
            int cid = int.Parse(TextBox1.Text);
            string cname = TextBox2.Text;
            int nfs = int.Parse(TextBox3.Text);

            ad.insertrowofc(cid, cname, nfs);

        }
    }
}