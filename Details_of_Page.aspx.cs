using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;

namespace Content_Management_System
{
    public partial class Details_of_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            PageDB db = new PageDB();
            ShowPageInfo(db);

        }
        protected void ShowPageInfo(PageDB db)
        {
            Debug.WriteLine("i am trying to show the page");
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;

            Debug.WriteLine("the page validitiy is "+valid+" and the page id is "+pageid);
            if (valid)
            {
                Page_Class page_record = db.FindPage(Int32.Parse(pageid));

                page_header_title.InnerHtml += page_record.GetTitle();
                page_title.InnerHtml += page_record.GetTitle();
                page_body.InnerHtml += page_record.GetBody();
                author_number.InnerHtml += page_record.GetAuthorNumber();
                created_date.InnerHtml += page_record.GetCreatedDate().ToString("yyyy/mm/dd");

            }
            
            if (!valid)
            {
                
            }
        }
        protected void Delete_Page(object sender,EventArgs e)
        {
            bool valid = true;
            string pageid = Request.QueryString["pageid"];
            if (String.IsNullOrEmpty(pageid)) valid = false;
            PageDB db = new PageDB();
            if (valid)
            {
                db.DeletePage(Int32.Parse(pageid));
                Response.Redirect("HTTP_Page.aspx");
            }
        }
    }
}