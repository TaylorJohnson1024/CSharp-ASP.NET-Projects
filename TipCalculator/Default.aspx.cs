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
    protected void btnCalculateTip_Click(object sender, EventArgs e)
    {
        if (tbBill.Text.Length > 0)
        {
            double bill = Double.Parse(tbBill.Text);
            double tip;

            switch(rblTipPercentage.SelectedValue)
            {
                case "0%":
                    tip = bill * 0;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
                case "5%":
                    tip = bill * 0.05;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
                case "10%":
                    tip = bill * 0.10;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
                case "15%":
                    tip = bill * 0.15;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
                case "18%":
                    tip = bill * 0.18;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
                case "20%":
                    tip = bill * 0.20;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
                case "25%":
                    tip = bill * 0.25;
                    tip = Math.Round(tip, 2);
                    bill = bill + tip;
                    lblTipAmount.Text = "Your suggested tip is " + tip;
                    lblTotalAmount.Text = "Your total amount comes to " + bill;
                    break;
            }
        }
    }
}