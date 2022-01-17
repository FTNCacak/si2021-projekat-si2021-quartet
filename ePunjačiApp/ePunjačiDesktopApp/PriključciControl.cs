using Business;
using Shered.BiznisInterfejsi;
using Shered.Modeli;
using System;
using System.Windows.Forms;

namespace ePunjačiDesktopApp
{
    public partial class PriključciControl : UserControl
    {
        private readonly IPriključciBusiness priključciBusiness;
        public PriključciControl()
        {
            InitializeComponent();
            priključciBusiness = new PriključciBusiness(); ;
            buttonIzmeni.Enabled = false;
            buttonObriši.Enabled = false;
            dataGridViewPriključci.Rows.Clear();
        }

        private void PriključciControl_Load(object sender, EventArgs e)
        {
            OsveziTabelu();
        }

        private void dataGridViewPriključci_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int row = dataGridViewPriključci.SelectedRows[0].Index;
                textBoxIdPriključka.Text = dataGridViewPriključci[0, row].Value.ToString();
                comboBoxIndikator.SelectedItem = dataGridViewPriključci[1, row].Value.ToString();
                textBoxIdPunjača.Text = dataGridViewPriključci[2, row].Value.ToString();
                buttonObriši.Enabled = true;
                buttonIzmeni.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Morate selektovati red u tabeli ");
            }

        }
        private void OsveziTabelu()
        {
            dataGridViewPriključci.AutoGenerateColumns = false;
            dataGridViewPriključci.Rows.Clear();
            foreach (var item in priključciBusiness.SviPriključci())
            {
                foreach (var item2 in item.ListPunjač)
                {
                    if (item.Id_punjača == item2.Id_punj)
                    {
                        string uslov = item.Indikator ? "True" : "False";
                        Console.WriteLine(item.Id_prik + " " + item.Id_punjača + " " + uslov + " " + item2.Snaga);
                        dataGridViewPriključci.Rows.Add(item.Id_prik, uslov, item.Id_punjača, item2.Snaga);
                    }
                }
            }
        }

        private void textBoxIdPriključka_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxIndikator_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private bool Validacija()
        {
            if (textBoxIdPriključka.Text == "" || textBoxIdPunjača.Text == "")
            {
                throw new Exception("Morate popuniti sva polja");
            }
            return true;
        }
        private void SetInput()
        {
            textBoxIdPriključka.Text = "";
            textBoxIdPunjača.Text = "";
        }
        private void buttonDodaj_Click(object sender, EventArgs e)
        {
            try
            {
                if (Validacija())
                {
                    if (comboBoxIndikator.SelectedItem.ToString() == "True")
                    {
                        Priključak priključak = new Priključak
                        {
                            Id_prik = textBoxIdPriključka.Text,
                            Indikator = true,
                            Id_punjača = textBoxIdPunjača.Text
                        };
                        if (priključciBusiness.DodajPriključak(priključak) == true)
                        {
                            MessageBox.Show("Uspešno ste dodali prikljucak!");
                            OsveziTabelu();
                            SetInput();
                        }
                        else
                        {
                            MessageBox.Show("Greska!");
                        }
                    }
                    else
                    {
                        Priključak priključak = new Priključak
                        {
                            Id_prik = textBoxIdPriključka.Text,
                            Indikator = false,
                            Id_punjača = textBoxIdPunjača.Text
                        };
                        if (priključciBusiness.DodajPriključak(priključak) == true)
                        {
                            MessageBox.Show("Uspešno ste dodali prikljucak!");
                            OsveziTabelu();
                            SetInput();
                        }
                        else
                        {
                            MessageBox.Show("Greska!");
                        }
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
                    if (comboBoxIndikator.SelectedItem.ToString() == "True")
                    {
                        int row = dataGridViewPriključci.SelectedRows[0].Index;

                        Priključak priključak = new Priključak
                        {
                            Id_prik = textBoxIdPriključka.Text,
                            Indikator = true,
                            Id_punjača = textBoxIdPunjača.Text
                        };

                        if (priključciBusiness.IzmeniPriključak(priključak))
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
                    else
                    {
                        int row = dataGridViewPriključci.SelectedRows[0].Index;

                        Priključak priključak = new Priključak
                        {
                            Id_prik = textBoxIdPriključka.Text,
                            Indikator = false,
                            Id_punjača = textBoxIdPunjača.Text
                        };

                        if (priključciBusiness.IzmeniPriključak(priključak))
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
                    Priključak priključak = new Priključak
                    {
                        Id_prik = textBoxIdPriključka.Text,
                        Indikator = true,
                        Id_punjača = textBoxIdPunjača.Text

                    };

                    if (priključciBusiness.ObrišiPriključak(priključak))
                    {
                        MessageBox.Show("Uspesno ste obrisali ");
                        OsveziTabelu();
                        SetInput();
                    }
                    else
                    {
                        MessageBox.Show("Podatak je vezan sa drugim tabelama");
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
