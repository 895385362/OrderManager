using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Joker.BLL;

namespace Joker.web
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Info_staffBLL infoStaffBLL = new Info_staffBLL();
            infoStaffBLL.GetList("");
        }
    }       
}