using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Drawing;
using System.Windows.Forms;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //check if cookie exists
        if (!IsPostBack && Request.Cookies["BackgroundColor"] != null)
        {
            BodyTag.Style["background-color"] = Request.Cookies["BackgroundColor"].Value;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        BodyTag.Style["background-color"] = DropDownList1.SelectedValue;

        //setting a cookie;
        //name: backgroundcolor
        //Value: dynamic; comes from the dropdownlist
        //Expiration time: 1 hour
        //new HttpCookie("cookie2", DropDownList1.SelectedValue); //shorter method
        HttpCookie cookie = new HttpCookie("BackgroundColor");
        cookie.Value = DropDownList1.SelectedValue;
        cookie.Expires = DateTime.Now.AddHours(1);
        Response.SetCookie(cookie);
    }
}