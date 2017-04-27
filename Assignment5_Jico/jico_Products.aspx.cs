using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Assignment5_Jico.SRProducts;

namespace Assignment5_Jico
{
    public partial class jico_Products1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SRProducts.Ijico_ProductsClient client = new Ijico_ProductsClient();
            GridView1.DataSource= client.ReturnProduct();
            GridView1.DataBind();
        }
    }
}