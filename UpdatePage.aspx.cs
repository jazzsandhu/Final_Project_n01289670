using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Content_Management_System
{
    public partial class UpdatePage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            if (!Page.IsPostBack)
            {
                PageDB db = new PageDB();
                ShowPageInfo(db);
                Debug.WriteLine("showwwwwwwwwww");

            }
            

        }
        protected void Update_Page(object sender, EventArgs e)
        {
            PageDB db = new PageDB();
             bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if(valid)
            {
                Debug.WriteLine("grab the info from here");
                Page_Class new_page = new Page_Class();
                //this is way to set the data
                new_page.SetTitle(pageTitle.Text);
                new_page.SetBody(page_body.Text);
                new_page.SetAuthorNumber(author_number.Text);

                //now want this value into the database
                try
                {
                    db.UpdatePage(Int32.Parse(pageid), new_page);
                    Response.Redirect("Details_of_page.aspx?pageid=" + pageid);
                }
                catch
                {

                }

            }
            if (!valid)
            {
                Debug.WriteLine("ERRORRRRRRRRRRRRRR" + pageid);
            }


        }

        //this is function for show the information in our filed so that they can update it/
       
        protected void ShowPageInfo(PageDB db)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            if (valid)
            {
                Page_Class page_record = db.FindPage(Int32.Parse(pageid));

                page_title.InnerHtml += page_record.GetTitle();
                pageTitle.Text += page_record.GetTitle();
                page_body.Text += page_record.GetBody();
                author_number.Text += page_record.GetAuthorNumber();

            }
            
            if (!valid)
            {
                Debug.WriteLine("may b check here" + pageid);
                
            }
        }
    }
}