using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COOKIE_6932077
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnConfirm_Click(object sender, EventArgs e)
        {
            Response.Cookies["ddlCategory"].Value = ddlCategory.SelectedValue;
            Response.Cookies["ddlSuplier"].Value = ddlSuplier.SelectedValue;
            Response.Cookies["strProduct"].Value = txtProduct.Text;
            Response.Cookies["strDescription"].Value = txtDescription.Text;
            Response.Cookies["strImage"].Value = txtImagen.Text;
            Response.Cookies["decPrice"].Value = txtPrice.Text;
            Response.Cookies["byNumberInStock"].Value = txtNumberInStock.Text;
            Response.Cookies["byReorderL evel"].Value = txtReorderLevel.Text;

            //go to page netx
            Response.Redirect("ProductConfirmCookies.aspx");
        }
    }
}