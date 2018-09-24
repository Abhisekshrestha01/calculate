using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using addsubdivmul;

namespace calcu
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(txt_x.Text);
            int y = Convert.ToInt32(txt_y.Text);
            int z = Convert.ToInt32(txt_z.Text);
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            adder obj = new adder();
            addsub obj = new addsub();
            addsubdiv obj = new addsubdiv();
            addsubdivmul obj = new addsubdivmul();

            addsubdivmul obj = new addsubdivmul();
            Label6.Text = 

        }
    }
}