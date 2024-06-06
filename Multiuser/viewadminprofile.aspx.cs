using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Multiuser
{
    public partial class viewadminprofile : System.Web.UI.Page
    {
        connectioncls obj = new connectioncls();//testing with another name for object.no problem
        protected void Page_Load(object sender, EventArgs e)
        {
            //selecting each fields sepearetly by using scalar function repeatedly.because scalar can only get one value.we can use execute reader for multiple values.
            string selname = "select Admin_name,Admin_email from admin where Admin_Id=" + Session["userid"];//only take admin_name
            string name = obj.fn_scalar(selname);
            Label3.Text = name;
            string selem = "select Admin_email from admin where Admin_Id=" + Session["userid"];
            string em= obj.fn_scalar(selem);
            Label4.Text = em;
        }
    }
}