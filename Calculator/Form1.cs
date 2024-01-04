using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        int total = 0;
        char prevOperation = ' ';
        int plusClicked = 0;
        int minusClicked = 0;
        int multiplyClicked = 0;
        int divideClicked = 0;
        int equalClicked = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void calculate()
        {
            if (prevOperation == ' ')
            {
                total = Convert.ToInt32(lbldisplay.Text);
                lbldisplay.Text = "0";
            }
            else
            {
                if (prevOperation == '+')
                {
                    total = total + Convert.ToInt32(lbldisplay.Text);
                    lbldisplay.Text = "0";
                }
                if (prevOperation == '-')
                {
                    total = total - Convert.ToInt32(lbldisplay.Text);
                    lbldisplay.Text = "0";
                }
                if (prevOperation == '*')
                    {
                    total = total * Convert.ToInt32(lbldisplay.Text);
                    lbldisplay.Text = "0";
                }
                if (prevOperation == '/')
                {
                    total = total / Convert.ToInt32(lbldisplay.Text);
                    lbldisplay.Text = "0";
                }
            }
            if (plusClicked == 1)
            {
                prevOperation = '+';
                plusClicked = 0;
            }
            else if (minusClicked == 1)
            {
                prevOperation = '-';
                minusClicked = 0;
            }
            else if (multiplyClicked == 1)
            {
                prevOperation = '*';
                multiplyClicked=0;
            }
            else if (divideClicked == 1)
            {
                prevOperation = '/';
                divideClicked = 0;
            }
            else
            {
                prevOperation = ' ';
                equalClicked = 0;
                lbldisplay.Text = Convert.ToString(total);
            }
        }
        private void button19_Click(object sender, EventArgs e)
        {

        }
        

        

        
        private void cmdclr_Click(object sender, EventArgs e)
        {
            lbldisplay.Text = "0";
            total = 0;
            prevOperation = ' ';
            plusClicked = 0;
            minusClicked = 0;   
            multiplyClicked = 0;
            divideClicked += 0;
        }
        private void cmdequal_Click(object sender, EventArgs e)
        {
            equalClicked = 1;
            calculate();
        }
        private void cmdmul_Click(object sender, EventArgs e)
        {
            multiplyClicked = 1;
            calculate();
        }
        private void cmdadd_Click(object sender, EventArgs e)
        {
            plusClicked = 1;
            calculate();
        }
        private void cmdsub_Click(object sender, EventArgs e)
        {
            minusClicked = 1;
            calculate();
        }
        private void cmddiv_Click(object sender, EventArgs e)
        {
            divideClicked = 1;
            calculate();
        }
        private void cmdzero_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "0";
            else
                lbldisplay.Text += "0";
        }
        private void cmdone_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "1";
            else
                lbldisplay.Text += "1";

        }

        private void cmdtwo_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "2";
            else
                lbldisplay.Text += "2";
        }

        private void cmdthree_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "3";
            else
                lbldisplay.Text += "3";
        }
        private void cmdfour_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "4";
            else
                lbldisplay.Text += "4";
        }
       
        private void cmdfive_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "5";
            else
                lbldisplay.Text += "5";
        }

        private void cmdsix_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "6";
            else
                lbldisplay.Text += "6";
        }

        private void cmdseven_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "7";
            else
                lbldisplay.Text += "7";
        }

        private void cmdeight_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "8";
            else
                lbldisplay.Text += "8";
        }private void cmdnine_Click(object sender, EventArgs e)
        {
            if (lbldisplay.Text == "0")
                lbldisplay.Text = "9";
            else
                lbldisplay.Text += "9";
        }
    }
}
