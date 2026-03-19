using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace COOKIE_6932077
{
    public partial class ProductConfirmCookies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblCategory.Text = Request.Cookies["ddlCategory"].Value;
            lblSupplier.Text = Request.Cookies["ddlSuplier"].Value;
            lblProduct.Text = Request.Cookies["strProduct"].Value;
            txtDescription.Text = Request.Cookies["strDescription"].Value;
            lblImage.Text = Request.Cookies["strImage"].Value;

            // Convertir el precio a decimal y mostrarlo con formato de moneda
            decimal decPrice = Convert.ToDecimal(Request.Cookies["decPrice"].Value);
            LblPrice.Text = decPrice.ToString("c");

            // Recuperar stock y niveles
 
            lblNumberInStock.Text = Request.Cookies["byNumberInStock"].Value;
            lblNumberInStock.Text = Request.Cookies["byReorderLevel"].Value;
            lblNumberInOrder.Text = Request.Cookies["byReorderLevel"].Value;

            // Calcular y mostrar los valores totales
            byte bytNumberInstock = Convert.ToByte(Request.Cookies["byNumberInstock"].Value);
            byte bytReorderLevel = Convert.ToByte(Request.Cookies["byReorderLevel"].Value);

            decimal decValueInStock = decPrice * bytNumberInstock;
            decimal decValueOnOrder = decPrice * bytReorderLevel;

            // Mostrar totales con cultura de EE.UU. para asegurar el formato de moneda ($)
            lblNumberInStock.Text = decValueInStock.ToString("c", new System.Globalization.CultureInfo("en-US"));
            lblNumberInOrder.Text = decValueOnOrder.ToString("c", new System.Globalization.CultureInfo("en-US"));
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }
    }
}