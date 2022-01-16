using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ePunjačiDesktopApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // pomocna forma poziv 
            BazneStaniceControl bazneStaniceControl = new BazneStaniceControl();
            // dodela default
            bazneStaniceControl.Dock = DockStyle.Fill;
            // prikaz glavnog desaign dela
            panelPrikaz.Controls.Clear();
            // dodavanje u glavni deo
            panelPrikaz.Controls.Add(bazneStaniceControl);
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            PunjačControl punjačControl = new PunjačControl();
            punjačControl.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(punjačControl);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            PriključciControl priključciControl = new PriključciControl();
            priključciControl.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(priključciControl);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // pomocna forma poziv 
            KorisnikControl korisnikControl = new KorisnikControl();
            // dodela default
            korisnikControl.Dock = DockStyle.Fill;
            // prikaz glavnog desaign dela
            panelPrikaz.Controls.Clear();
            // dodavanje u glavni deo
            panelPrikaz.Controls.Add(korisnikControl);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            AutomobiliControl automobiliControl = new AutomobiliControl();
            automobiliControl.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(automobiliControl);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InformacijeControl informacijeControl = new InformacijeControl();
            informacijeControl.Dock = DockStyle.Fill;
            panelPrikaz.Controls.Clear();
            panelPrikaz.Controls.Add(informacijeControl);
        }
    }
}
