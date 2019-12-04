using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Content_Management_System
{
    public partial class Create : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Add_Page(object sender ,EventArgs e)
        {
            //the above add_page is related to our onclick funcion
            //firstly access from db
            PageDB db = new PageDB();

            //create a new page
            //here this page class is  to refer the class which we created;
            Page_Class new_http_page = new Page_Class();
            //set that student data now
            new_http_page.SetTitle(page_title.Text);
            new_http_page.SetBody(page_body.Text);
            new_http_page.SetAuthorNumber(author_number.Text);
            new_http_page.SetCreatedDate(DateTime.Now);

            //now this new page created to our database
            db.AddPage(new_http_page);
            //this add page is related to our db add page.

            Response.Redirect("HTTP_Page.aspx");

        }
    }
}