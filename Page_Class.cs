using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Diagnostics;

namespace Content_Management_System
{
    public class Page_Class
    {
        //these are the private string delcare to get the values for fields

        private string Title;
        private string Body;
        private string AuthorNumber;
        private DateTime Created_Date;

        public string GetTitle()
        {
            return Title;
        }
        public string GetBody()
        {
            return Body;
        }
        public string GetAuthorNumber()
        {
            return AuthorNumber;
        }
        //public string GetAuthorNumber()
        //{
        //    return AuthorName;
        //}
        public DateTime GetCreatedDate()
        {
            return Created_Date;
        }
        //in above lines of code we simply get the values now we have to set it

        public void SetTitle(string value)
        {
            Title = value;

        }
        public void SetBody(string value)
        {
            Body = value;
        }
        public void SetAuthorNumber(string value)
        {
            AuthorNumber = value;
        }
        //public void SetAuthorName(string value)
        //{
        //    AuthorName = value;
        //}
        public void SetCreatedDate(DateTime value)
        {
            Created_Date = value;
        }





    }
}