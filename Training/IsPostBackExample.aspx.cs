using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Training
{
    public partial class IsPostBackExample : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {
                bindddl();
            }
           
        }

        protected void bindddl()
        {
            ListItem li1 = new ListItem("Kolhapur");
            ddlCities.Items.Add(li1);

            ListItem li2 = new ListItem("Pune");
            ddlCities.Items.Add(li2);

            ListItem li3 = new ListItem("Mumbai");
            ddlCities.Items.Add(li3);

            ListItem li4 = new ListItem("Delhi");
            ddlCities.Items.Add(li4);
        }

    }
}