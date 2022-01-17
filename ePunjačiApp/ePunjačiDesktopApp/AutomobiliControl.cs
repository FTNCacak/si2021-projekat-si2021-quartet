using Business;
using Shered.BiznisInterfejsi;
using Shered.Modeli;
using System;
using System.Windows.Forms;

namespace ePunjačiDesktopApp
{
    public partial class AutomobiliControl : UserControl
    {
        private readonly IPriključciBusiness priključciBusiness;
        private readonly IKorisniciBusiness korisniciBusiness;
        private readonly IAutomobiliBusiness automobiliBusiness;
        public AutomobiliControl()
        {
            InitializeComponent();
            priključciBusiness = new PriključciBusiness();
            korisniciBusiness = new KorisniciBusiness();
            automobiliBusiness = new AutomobiliBusiness();
            buttonIzmeni.Enabled = false;
            buttonObriši.Enabled = false;
            dataGridViewAutomobili.Rows.Clear();
        }

        private void OsveziTabelu()
        {
            dataGridViewAutomobili.AutoGenerateColumns = false;
            dataGridViewAutomobili.Rows.Clear();
            foreach (var item in automobiliBusiness.SviAutomobili())
            {
                dataGridViewAutomobili.Rows.Add(
                    item.Broj_šasije, item.Id_priključka, item.JMBG_korisnika, item.Marka, item.Tip, item.Kapacitet_baterije
                    );
            }
        }


        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void AutomobiliControl_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void dataGridViewAutomobili_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewAutomobili.SelectedRows[0].Index;
                textBoxBtojŠasije.Text = dataGridViewAutomobili[0, row].Value.ToString();
                textBoxIdPrikljućka.Text = dataGridViewAutomobili[1, row].Value.ToString();
                textBoxJMBG.Text = dataGridViewAutomobili[2, row].Value.ToString();
                textBoxMarka.Text= dataGridViewAutomobili[3, row].Value.ToString();
                textBoxTip.Text= dataGridViewAutomobili[4, row].Value.ToString();
                textBoxKapacitetBaterije.Text= dataGridViewAutomobili[5, row].Value.ToString();
                buttonObriši.Enabled = true;
                buttonIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red u tabeli ");
            }
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    Automobil automobil = new Automobil
                    {
                        Broj_šasije = textBoxBtojŠasije.Text,
                        Id_priključka = textBoxIdPrikljućka.Text,
                        JMBG_korisnika = long.Parse(textBoxJMBG.Text),
                        Marka = textBoxMarka.Text,
                        Tip = textBoxTip.Text,
                        Kapacitet_baterije = int.Parse(textBoxKapacitetBaterije.Text)
                    };
                    if (automobiliBusiness.DodajAutomobil(automobil) == true)
                    {
                        MessageBox.Show("Uspešno ste dodali Automobil!");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Ne možete unesete podatke o Automobilu!");
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
            textBoxBtojŠasije.Text = "";
            textBoxIdPrikljućka.Text = "";
            textBoxJMBG.Text = "";
            textBoxMarka.Text = "";
            textBoxTip.Text = "";
            textBoxKapacitetBaterije.Text = "";
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewAutomobili.SelectedRows[0].Index;
                    string brojS = dataGridViewAutomobili[0, row].Value.ToString();
                    Automobil automobil = new Automobil
                    {
                        Broj_šasije = brojS,
                        Id_priključka = textBoxIdPrikljućka.Text,
                        JMBG_korisnika = long.Parse(textBoxJMBG.Text),
                        Marka = textBoxMarka.Text,
                        Tip = textBoxTip.Text,
                        Kapacitet_baterije = int.Parse(textBoxKapacitetBaterije.Text)
                    };

                    if (automobiliBusiness.IzmeniAutomobil(automobil))
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

        private void buttonObriši_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                int row = dataGridViewAutomobili.SelectedRows[0].Index;
                string brojS = dataGridViewAutomobili[0, row].Value.ToString();
                Automobil automobil = new Automobil
                {
                    Broj_šasije = brojS,
                    Id_priključka = textBoxIdPrikljućka.Text,
                    JMBG_korisnika = long.Parse(textBoxJMBG.Text),
                    Marka = textBoxMarka.Text,
                    Tip = textBoxTip.Text,
                    Kapacitet_baterije = int.Parse(textBoxKapacitetBaterije.Text)
                };
                if (automobiliBusiness.ObrišiAutomobil(automobil))
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
            long JMBG;
            int KapBat;
            if (textBoxBtojŠasije.Text == "" || textBoxIdPrikljućka.Text == "" || !long.TryParse(textBoxJMBG.Text, out JMBG) || textBoxMarka.Text == "" || textBoxTip.Text == "" ||!int.TryParse(textBoxKapacitetBaterije.Text, out KapBat))
            {
                throw new Exception("Morate popuniti sva polja!");
            }
            return true;
        }

        private void textBoxBtojŠasije_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
