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
    protected void btnSize_Click(object sender, EventArgs e)
    {
        int odd = 0;
        int size = Int32.Parse(tbNumberTiles.Text);
        string checkerBoardHTML = "<table>";
        int rowCount = 0;
        int cellCount;

        //for even sized boards
        if (size % 2 == 0)
        {
            //creates the rows
            while (rowCount < size)
            {
                //populates the rows
                checkerBoardHTML += "<tr>";
                cellCount = 0;
                while (cellCount < size)
                {
                    //goes every other row
                    //switches the if/else statements to make appropriate board
                    if (rowCount % 2 == 1)
                    {
                        if (odd % 2 == 1)
                        {
                            checkerBoardHTML += "<td></td>";
                        }
                        else
                        {
                            checkerBoardHTML += "<td class='odd'></td>";
                        }
                        odd += 1;
                    }
                    else
                    {
                        if (odd % 2 == 1)
                        {
                            checkerBoardHTML += "<td class='odd'></td>";
                        }
                        else
                        {
                            checkerBoardHTML += "<td></td>";
                        }
                        odd += 1;
                    }
                    cellCount += 1;
                }
                rowCount += 1;
                checkerBoardHTML += "</tr>";
            }
            checkerBoardHTML += "</table>";
            CheckerBoard.InnerHtml = checkerBoardHTML;
        }
        //for odd sized boards
        else
        {
            //creates the rows
            while (rowCount < size)
            {
                //populates the rows
                checkerBoardHTML += "<tr>";
                cellCount = 0;
                while (cellCount < size)
                {
                    if (odd % 2 == 1)
                    {
                        checkerBoardHTML += "<td class='odd'></td>";
                    }
                    else
                    {
                        checkerBoardHTML += "<td></td>";
                    }
                    cellCount += 1;
                    odd += 1;
                }
                rowCount += 1;
                checkerBoardHTML += "</tr>";
            }
            checkerBoardHTML += "</table>";
            CheckerBoard.InnerHtml = checkerBoardHTML;
        }
    }
}