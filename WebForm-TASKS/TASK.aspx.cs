using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary30_11;

namespace WebForm_TASKS
{
    public partial class TASK : System.Web.UI.Page
    {
        Mather calc = new Mather();
        //int x;
        //double num1, num2;
        //protected string c;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void sub_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(first.Text);
            double x2 = Convert.ToDouble(second.Text);
            double re = calc.sub(x1, x2);
            Label4.Text = first.Text + " - " + second.Text + " =  ";
            Result.Text = Convert.ToString(re);
        }

        protected void Sum_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(first.Text);
            double x2 = Convert.ToDouble(second.Text);
            double re = calc.add(x1, x2);
            Label4.Text = first.Text + " + " + second.Text + " =  ";
            Result.Text = Convert.ToString(re);
            //num1+= Convert.ToDouble(first.Text);
            //Result.Text = Convert.ToString(num1);
            //first.Text = string.Empty;
            //c = "+";
        }

        protected void multip_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(first.Text);
            double x2 = Convert.ToDouble(second.Text);
            double re = calc.multi(x1, x2);
            Label4.Text = first.Text + " * " + second.Text + " =  ";
            Result.Text = Convert.ToString(re);
            //num1 = Convert.ToDouble(first.Text);
            //x = false;
        }

        protected void Divi_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(first.Text);
            double x2 = Convert.ToDouble(second.Text);
            double re = calc.div(x1, x2);
            Label4.Text = first.Text + " / " + second.Text + " =  ";
            Result.Text = Convert.ToString(re);
            //num1 = Convert.ToDouble(first.Text);
            //x = false;
        }

        protected void Mode_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(first.Text);
            double x2 = Convert.ToDouble(second.Text);
            double re = calc.mod(x1, x2);
            Label4.Text = first.Text + " % " + second.Text + " =  ";
            Result.Text = Convert.ToString(re);
            //num1 = Convert.ToDouble(first.Text);
            //x = false;
        }

        protected void Clear_Click(object sender, EventArgs e)
        {
            first.Text = string.Empty;
            second.Text = string.Empty;
            Label4.Text = string.Empty;
            Result.Text = string.Empty;
        }



        //protected void n1_Click(object sender, EventArgs e)
        //{

        //        first.Text += n1.Text;




        //}
    }
}