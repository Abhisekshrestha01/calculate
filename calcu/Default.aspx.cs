using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Addition;
using addSub;

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
            float z = float.Parse(txt_z.Text);
            int a = Convert.ToInt32(txt_a.Text);
            int b = Convert.ToInt32(txt_b.Text);
            Adder obj = new Adder();
            float result1 = obj.Add(x, y);
            SibstractionClass obj1 = new SibstractionClass();
            result1 = obj1.SubRes(result1, z);
            addSubdiv obj2 = new addsubdiv();
            result1 = obj.Addsubdiv(result1, a);
            addsubdivmul obj = new addsubdivmul();
            result1 = obj.Addsubdivmul(result1, b);
            Label6.Text = result1.ToString();

        }
    }
}