using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using addsubdivmul;
using Addition;

namespace calcu
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            float x = float.Parse(txt_x.Text);
            float y = float.Parse(txt_y.Text);
            int z = Convert.ToInt32(txt_z.Text);
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            Adder obj = new Adder();
            float result1 = obj.Add(x, y);
            addsub obj1 = new addsub();
            float result1 = obj1.Addsub(result1, z);
            addsubdiv obj2 = new addsubdiv();
            float result1 = obj.Addsubdiv(result1, a);
            addsubdivmul obj = new addsubdivmul();
            float result1 = obj.Addsubdivmul(result1, b);
            Label6.Text = result1.ToString();

        }
    }
}