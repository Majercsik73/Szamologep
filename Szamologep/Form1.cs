using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Szamologep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool ujszame = true;

        private void egy_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "1";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "1";
                ujszame = true;
            }
        }

        private void ketto_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "2";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "2";
                ujszame = true;
            }
        }

        private void harom_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "3";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "3";
                ujszame = true;
            }
        }

        private void nulla_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "0";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "0";
                ujszame = true;
            }
        }

        private void negy_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "4";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "4";
                ujszame = true;
            }
        }

        private void ot_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "5";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "5";
                ujszame = true;
            }
        }

        private void hat_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "6";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "6";
                ujszame = true;
            }
        }

        private void het_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "7";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "7";
                ujszame = true;
            }
        }

        private void nyolc_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "8";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "8";
                ujszame = true;
            }
        }

        private void kilenc_Click(object sender, EventArgs e)
        {
            if (ujszame) Lbevitel.Text += "9";
            else
            {
                Lbevitel.Text = "";
                Lbevitel.Text = "9";
                ujszame = true;
            }
        }

        double a = 0;
        double b = 0;
        double c = 0;
        double d = 0;
        double f = 0;
        double g = 0;
        bool eloszorszamol = true;
        double j = 0;

        private void clear_Click(object sender, EventArgs e)
        {
            Lbevitel.Text = "";
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            f = 0;
            g = 0;
            eloszorszamol = true;
            j = 0;
            ujszame = true;

        }

        public void plusz_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            eloszorszamol = true;
            a = Convert.ToDouble(Lbevitel.Text);
            Lbevitel.Text = "";
        }

        private void minusz_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            eloszorszamol = true;
            b = Convert.ToDouble(Lbevitel.Text);
            Lbevitel.Text = "";
        }

        private void szor_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            eloszorszamol = true;
            c = Convert.ToDouble(Lbevitel.Text);
            Lbevitel.Text = "";
        }

        private void oszt_Click(object sender, EventArgs e)
        {
            a = 0;
            b = 0;
            c = 0;
            d = 0;
            eloszorszamol = true;
            d = Convert.ToDouble(Lbevitel.Text);
            Lbevitel.Text = "";
        }

        private void egyenlo_Click(object sender, EventArgs e)
        {
            if (eloszorszamol) EloszorSzamol();
            
            else TovabbiSzamol();

            ujszame = false;
        }

        private void EloszorSzamol()
        {
            f = Convert.ToDouble(Lbevitel.Text);
            Lbevitel.Text = "";
            if (a != 0)
            {
                g = a + f;
                Lbevitel.Text = g.ToString();
            }
            else if (b != 0)
            {
                g = b - f;
                Lbevitel.Text = g.ToString();
            }
            else if (c != 0)
            {
                g = c * f;
                Lbevitel.Text = g.ToString();
            }
            else
            {
                g = d / f;
                Lbevitel.Text = g.ToString();
            }
            eloszorszamol = false;
        }

        private void TovabbiSzamol()
        {
            j = Convert.ToDouble(Lbevitel.Text);
            if (a != 0)
            {
                g = j + f;
                Lbevitel.Text = g.ToString();
            }
            else if (b != 0)
            {
                g = j - f;
                Lbevitel.Text = g.ToString();
            }
            else if (c != 0)
            {
                g = j * f;
                Lbevitel.Text = g.ToString();
            }
            else
            {
                g = j / f;
                Lbevitel.Text = g.ToString();
            }
        }

        private void Belojel_Click(object sender, EventArgs e)
        {
            if (Lbevitel.Text == "") Lbevitel.Text += "-";

            else if (Lbevitel.Text == "-") Lbevitel.Text = "";
        }

        private void Btizedes_Click(object sender, EventArgs e)
        {
            if (Lbevitel.Text == "") Lbevitel.Text += "0,";

            else Lbevitel.Text += ",";
        }
    }
}
