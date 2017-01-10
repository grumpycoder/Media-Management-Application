using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace MediaApp
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        // Add New Publisher Button
        protected void Button1_OnClick(object sender, EventArgs e)
        {
           Response.Redirect("AddNewPublisher.aspx");
        }

        // Search for Media/Publisher Button
        protected void Button2_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("SearchForMediaPublisher.aspx");
        }

        // Add New Media Button
        protected void Button3_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("AddNewMedia.aspx");
        }

        
    } // end class
}