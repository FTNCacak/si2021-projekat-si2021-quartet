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
    public partial class KorisnikControl : UserControl
    {
        private readonly IKorisniciBusiness korisniciBusiness;
        private readonly IAutomobiliBusiness automobiliBusiness;
        public KorisnikControl()
        {
            InitializeComponent();
            korisniciBusiness = new KorisniciBusiness();
            automobiliBusiness = new AutomobiliBusiness();
            buttonIzmeni.Enabled = false;
            buttonObirši.Enabled = false;
            dataGridViewKorisnik.Rows.Clear();
        }
        private void OsveziTabelu()
        {
            dataGridViewKorisnik.AutoGenerateColumns = false;
            dataGridViewKorisnik.Rows.Clear();
            foreach (var item in korisniciBusiness.SviKorisnici())
            {
                dataGridViewKorisnik.Rows.Add(
                    item.JMBG, item.Ime, item.Prezime, item.Broj_telefona, item.Email
                    );
            }
        }
        private void KorisnikControl_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void dataGridViewKorisnik_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewKorisnik.SelectedRows[0].Index;
                textBoxJedinstveniMatičniBroj.Text = dataGridViewKorisnik[0, row].Value.ToString();
                textBoxIme.Text = dataGridViewKorisnik[1, row].Value.ToString();
                textBoxPrezime.Text = dataGridViewKorisnik[2, row].Value.ToString();
                textBoxBrojTelefona.Text = dataGridViewKorisnik[3, row].Value.ToString();
                textBoxEmail.Text = dataGridViewKorisnik[4, row].Value.ToString();
                buttonObirši.Enabled = true;
                buttonIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red u tabeli ");
            }
        }

        private void textBoxJedinstveniMatičniBroj_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetInput()
        {
            textBoxJedinstveniMatičniBroj.Text = "";
            textBoxIme.Text = "";
            textBoxPrezime.Text = "";
            textBoxBrojTelefona.Text = "";
            textBoxEmail.Text = "";
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    Korisnik korisnik= new Korisnik
                    {
                        JMBG = long.Parse(textBoxJedinstveniMatičniBroj.Text),
                        Ime = textBoxIme.Text,
                        Prezime = textBoxPrezime.Text,
                        Broj_telefona = textBoxBrojTelefona.Text,
                        Email = textBoxEmail.Text,
                    };
                    if (korisniciBusiness.DodajKorisnik(korisnik) == true)
                    {
                        MessageBox.Show("Uspešno ste dodali Korisnika!");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Ne možete unesete podatke o Korisniku!");
                    }
               }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewKorisnik.SelectedRows[0].Index;
                    long jmbg = Convert.ToInt64(dataGridViewKorisnik[0, row].Value.ToString());
                Korisnik korisnik = new Korisnik
                    {
                        JMBG= jmbg,
                        Ime =textBoxIme.Text,
                        //JMBG_korisnika = long.Parse(textBoxJMBG.Text),
                        Prezime = textBoxPrezime.Text,
                        Broj_telefona = textBoxBrojTelefona.Text,
                        Email= textBoxEmail.Text
                    };

                    if (korisniciBusiness.IzmeniKorisnik(korisnik))
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

        private void buttonObirši_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewKorisnik.SelectedRows[0].Index;
                    long jmbg = Convert.ToInt64(dataGridViewKorisnik[0, row].Value.ToString());
                    Korisnik korisnik = new Korisnik
                    { 
                        JMBG = jmbg,
                        Ime = textBoxIme.Text,
                        //JMBG_korisnika = long.Parse(textBoxJMBG.Text),
                        Prezime = textBoxPrezime.Text,
                        Broj_telefona = textBoxBrojTelefona.Text,
                        Email = textBoxEmail.Text
                    };
                    if (korisniciBusiness.ObrišiKorisnik(jmbg))
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
        private bool Validacija()
        {
            long jmngKorisnika;

            if (!long.TryParse(textBoxJedinstveniMatičniBroj.Text, out jmngKorisnika) || textBoxIme.Text == "" || textBoxPrezime.Text == "" || textBoxBrojTelefona.Text == "")
            {
                throw new Exception("Morate popuniti sva polja!");
            }
            return true;
        }
    }
}
