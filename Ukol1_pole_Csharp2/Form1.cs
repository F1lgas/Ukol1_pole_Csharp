using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ukol1_pole_Csharp2
{
    public partial class Form1 : Form
    {
        public int[] pole;
        public Form1()
        {
            InitializeComponent();
        }

        private void generovani_Click(object sender, EventArgs e)
        {
            org_pole.Clear();
            seř_pole.Clear();

            try
            {
                int n1 = Convert.ToInt32(cisloN.Text);
                int n2 = 0;
                Random rnd = new Random();

                pole = new int[n1];

                while (n2 < n1)
                {
                    pole[n2] = rnd.Next(1, 50);
                    org_pole.Text += Convert.ToString(pole[n2]) + Environment.NewLine;
                    n2++;
                }

                n2 = 0;

                if (sestup.Checked == true)
                {
                    Array.Sort(pole);
                    Array.Reverse(pole);

                    while (n2 < n1)
                    {
                        seř_pole.Text += Convert.ToString(pole[n2]) + Environment.NewLine;
                        n2++;
                    }
                }

                if (vzestup.Checked == true)
                {
                    Array.Sort(pole);
                    while (n2 < n1)
                    {
                        seř_pole.Text += Convert.ToString(pole[n2]) + Environment.NewLine;
                        n2++;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Zadej kolik chceš generovat čísel!", "Error");
            }
        }
    }
}
