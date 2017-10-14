using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void btnCalculate_Click(object sender, EventArgs e)
    {
        if (tbLength.Text.Length > 0 && tbWidth.Text.Length > 0)
        {
            double length = Double.Parse(tbLength.Text);
            double width = Double.Parse(tbWidth.Text);
            double footage = length * width;
            lblResult.Text = "Your lawn footage is " + footage;

            if (footage <= 400)
            {
                tbWeeklyFee.Text = "" + 35;
            }
            else if (footage > 400 && footage < 600)
            {
                tbWeeklyFee.Text = "" + 50;
            }
            else if (footage > 600 && footage < 1000)
            {
                tbWeeklyFee.Text = "" + 70;
            }
            else if (footage > 1000)
            {
                tbWeeklyFee.Text = "" + 100;
            }
        }
    }
    protected void btnCalculateTotal_Click(object sender, EventArgs e)
    {
        if (tbWeeklyFee.Text.Length > 0 && tbNumberWeeks.Text.Length > 0)
        {
            double WeeklyFee = Double.Parse(tbWeeklyFee.Text);
            double NumberWeeks = Double.Parse(tbNumberWeeks.Text);
            double NetDue = WeeklyFee * NumberWeeks;

            lblFinalResult.Text = "Your total comes to $" + NetDue;
        }
    }
    protected void btnCalculateWeeklyFee_Click(object sender, EventArgs e)
    {
        if (tbWeeklyFee.Text.Length > 0 && tbNumberWeeks.Text.Length > 0)
        {
            double WeeklyFee = Double.Parse(tbWeeklyFee.Text);
            double NumberWeeks = Double.Parse(tbNumberWeeks.Text);
            double NetDue = WeeklyFee * NumberWeeks;

            switch (ddlPayment.SelectedValue)
            {
                case "1":
                    lblTrueFinalResult.Text = "Your one payment will be " + NetDue;
                    break;
                case "2":
                    NetDue = NetDue / 2 + 5;
                    lblTrueFinalResult.Text = "Your two payments will be " + NetDue;
                    break;
                case "20":
                    NetDue = NetDue / 20 + 3;
                    lblTrueFinalResult.Text = "Your " + NumberWeeks +" payments will be " + NetDue;
                    break;
            }
        }
    }
}