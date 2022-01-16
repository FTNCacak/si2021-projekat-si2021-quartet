using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using Shered.BiznisInterfejsi;
using Business;
using Shered.Modeli;

namespace ePunjačiDesktopApp
{
    public partial class BazneStaniceControl : UserControl
    {
        private readonly IBazneStaniceBusiness bazneStaniceBusiness;
        public BazneStaniceControl()
        {
            InitializeComponent();
            bazneStaniceBusiness = new BazneStaniceBusiness();
            buttonIzmeni.Enabled = false;
            buttonObiši.Enabled = false;
            dataGridViewBazneStanice.Rows.Clear();
        }
        
         private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        private void OsveziTabelu()
        {
            dataGridViewBazneStanice.AutoGenerateColumns = false;
            dataGridViewBazneStanice.Rows.Clear();
            foreach (var item in bazneStaniceBusiness.SveBazneStanice())
            {
                dataGridViewBazneStanice.Rows.Add(
                    item.Id_stanice, item.Naziv, item.Adresa
                    );
            }
        }   
        private void BazneStaniceControl_Load(object sender, EventArgs e)
        {
                    OsveziTabelu();
        }

        private void dataGridViewBazneStanice_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewBazneStanice.SelectedRows[0].Index;
                textBoxIdStanice.Text = dataGridViewBazneStanice[0, row].Value.ToString();
                textBoxNaziv.Text = dataGridViewBazneStanice[1, row].Value.ToString();
                textBoxAdresa.Text = dataGridViewBazneStanice[2, row].Value.ToString();
                buttonObiši.Enabled = true;
                buttonIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red u tabeli ");
            }
        }

        private void textBoxIdStanice_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    BaznaStanica baznaStanica = new BaznaStanica
                    {
                        Id_stanice = textBoxIdStanice.Text,
                        Naziv = textBoxNaziv.Text,
                        Adresa = textBoxAdresa.Text
                    };
                    if (bazneStaniceBusiness.DodajBaznaStanica(baznaStanica) == true)
                    {
                        MessageBox.Show("Uspešno ste uneli Baznu stanicu!");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Ne možete unesete podatke o Baznoj stanici!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void SetInput()
        {
            textBoxIdStanice.Text = "";
            textBoxNaziv.Text = "";
            textBoxAdresa.Text = "";
        }
        private bool Validacija()
        {
            

            if (textBoxIdStanice.Text == "" || textBoxNaziv.Text == "" || textBoxAdresa.Text == "")
            {
                throw new Exception("Morate popuniti sva polja!");
            }
            return true;
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewBazneStanice.SelectedRows[0].Index;
                    string baz = dataGridViewBazneStanice[0, row].Value.ToString();
                    BaznaStanica  bs = new BaznaStanica
                    {
                        Id_stanice= baz,
                        Naziv = textBoxNaziv.Text,
                        Adresa = textBoxAdresa.Text,
                    };

                    if (bazneStaniceBusiness.IzmeniBaznaStanica(bs))
                    {
                        MessageBox.Show("Uspesno ste izvrsili promenu!");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Greska!!!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonObiši_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewBazneStanice.SelectedRows[0].Index;
                    string baz = dataGridViewBazneStanice[0, row].Value.ToString();
                    BaznaStanica bs = new BaznaStanica
                    {
                        Id_stanice = baz,
                        Naziv = textBoxNaziv.Text,
                        Adresa = textBoxAdresa.Text,
                    };
                    if (bazneStaniceBusiness.ObrišiBaznaStanica(baz))
                    {
                        MessageBox.Show("Uspesno ste obrisali podtke! ");
                        OsveziTabelu();
                    }
                    else
                    {
                        MessageBox.Show("Greska!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
