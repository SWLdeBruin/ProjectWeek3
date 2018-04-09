using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ProjectWeek3
{
    public partial class Index : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public void RenderSjoerd()
        {
            Response.WriteFile("Index-Sjoerd.aspx");
        }

        public void RenderJasper()
        {
            Response.WriteFile("Index-Jasper.aspx");
        }
    }
}