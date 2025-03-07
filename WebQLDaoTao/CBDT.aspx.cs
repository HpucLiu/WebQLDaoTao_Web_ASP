using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebQLDaoTao.Models;

namespace WebQLDaoTao
{
    public partial class CBDTPage : System.Web.UI.Page
    {
        AccountDAO tkDAO = new AccountDAO();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Response.Redirect("Login.aspx");
            }
            else
            {
                string username = (string)Session["username"];
                if (tkDAO.findByUsername(username).VaiTro != "cb")
                {
                    Response.Redirect("TuChoi.aspx");
                }
            }
        }
    }
}