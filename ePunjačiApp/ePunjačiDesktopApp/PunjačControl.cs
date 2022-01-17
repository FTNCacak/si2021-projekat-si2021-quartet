using Business;
using Shered.BiznisInterfejsi;
using Shered.Modeli;
using System;
using System.Windows.Forms;

namespace ePunjačiDesktopApp
{
    public partial class PunjačControl : UserControl
    {
        private readonly IPriključciBusiness priključciBusiness;
        private readonly IPunjačiBusiness punjačiBusiness;
        private readonly IBazneStaniceBusiness bazneStaniceBusiness;
        public PunjačControl()
        {
            InitializeComponent();
            priključciBusiness = new PriključciBusiness();
            punjačiBusiness = new PunjačiBusiness();
            bazneStaniceBusiness = new BazneStaniceBusiness();
            buttonIzmeni.Enabled = false;
            buttonObirši.Enabled = false;
            dataGridViewPunjači.Rows.Clear();
        }
        private void OsveziTabelu()
        {
            dataGridViewPunjači.AutoGenerateColumns = false;
            dataGridViewPunjači.Rows.Clear();
            foreach (var item in punjačiBusiness.SviPunjači())
            {
                foreach (var item2 in bazneStaniceBusiness.SveBazneStanice())
                {
                    if (item.Id_bazne_stanice == item2.Id_stanice)
                    {
                        dataGridViewPunjači.Rows.Add(
                            item.Id_punj, item.Snaga, item.Id_bazne_stanice, item2.Naziv, item2.Adresa
                                );
                    }
                }
            }
        }
        private void PunjačControl_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void dataGridViewPunjači_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewPunjači.SelectedRows[0].Index;
                textBoxIdPunj.Text = dataGridViewPunjači[0, row].Value.ToString();
                textBoxSnaga.Text = dataGridViewPunjači[1, row].Value.ToString();
                textBoxIdBaznaStanica.Text = dataGridViewPunjači[2, row].Value.ToString();
                buttonObirši.Enabled = true;
                buttonIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red u tabeli ");
            }
        }

        private void textBoxSnaga_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    Punjač punjač = new Punjač
                    {
                        Id_punj = textBoxIdPunj.Text,
                        Snaga = int.Parse(textBoxSnaga.Text),
                        Id_bazne_stanice = textBoxIdBaznaStanica.Text
                    };
                    if (punjačiBusiness.DodajPunjač(punjač) == true)
                    {
                        MessageBox.Show("Uspešno ste uneli Punjač!");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Ne možete unesete podatke o Punjaču!");
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
            textBoxIdPunj.Text = "";
            textBoxSnaga.Text = "";
            textBoxIdBaznaStanica.Text = "";
        }

        private void buttonIzmeni_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    int row = dataGridViewPunjači.SelectedRows[0].Index;
                    string punjId = dataGridViewPunjači[0, row].Value.ToString();
                    Punjač punjač = new Punjač
                    {
                        Id_punj = punjId,
                        Snaga = int.Parse(textBoxSnaga.Text),
                        Id_bazne_stanice = textBoxIdBaznaStanica.Text,
                    };

                    if (punjačiBusiness.IzmeniPunjač(punjač))
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
                    int row = dataGridViewPunjači.SelectedRows[0].Index;
                    string punjId = dataGridViewPunjači[0, row].Value.ToString();
                    Punjač punjač = new Punjač
                    {
                        Id_punj = punjId,
                        Snaga = int.Parse(textBoxSnaga.Text),
                        Id_bazne_stanice = textBoxIdBaznaStanica.Text,
                    };
                    if (punjačiBusiness.ObrišiPunjač(punjač))
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
            int snaga;

            if (textBoxIdPunj.Text == "" || (!int.TryParse(textBoxSnaga.Text, out snaga) || textBoxIdBaznaStanica.Text == ""))
            {
                throw new Exception("Morate popuniti sva polja!");
            }
            return true;
        }
    }
}
