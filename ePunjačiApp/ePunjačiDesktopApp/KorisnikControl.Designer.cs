namespace ePunjačiDesktopApp
{
    partial class KorisnikControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KorisnikControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewKorisnik = new System.Windows.Forms.DataGridView();
            this.JmbgKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImeKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrezimeKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BrojTelefona = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxBrojTelefona = new System.Windows.Forms.TextBox();
            this.textBoxPrezime = new System.Windows.Forms.TextBox();
            this.textBoxIme = new System.Windows.Forms.TextBox();
            this.textBoxJedinstveniMatičniBroj = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonObirši = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnik)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewKorisnik, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1311, 792);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewKorisnik
            // 
            this.dataGridViewKorisnik.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewKorisnik.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.JmbgKorisnika,
            this.ImeKorisnika,
            this.PrezimeKorisnika,
            this.BrojTelefona,
            this.Email});
            this.dataGridViewKorisnik.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewKorisnik.Location = new System.Drawing.Point(396, 3);
            this.dataGridViewKorisnik.Name = "dataGridViewKorisnik";
            this.dataGridViewKorisnik.RowHeadersWidth = 51;
            this.dataGridViewKorisnik.Size = new System.Drawing.Size(912, 786);
            this.dataGridViewKorisnik.TabIndex = 0;
            this.dataGridViewKorisnik.Text = "dataGridView1";
            this.dataGridViewKorisnik.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewKorisnik_CellClick);
            // 
            // JmbgKorisnika
            // 
            this.JmbgKorisnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JmbgKorisnika.HeaderText = "JMBG";
            this.JmbgKorisnika.MinimumWidth = 6;
            this.JmbgKorisnika.Name = "JmbgKorisnika";
            // 
            // ImeKorisnika
            // 
            this.ImeKorisnika.HeaderText = "Ime ";
            this.ImeKorisnika.MinimumWidth = 6;
            this.ImeKorisnika.Name = "ImeKorisnika";
            this.ImeKorisnika.Width = 125;
            // 
            // PrezimeKorisnika
            // 
            this.PrezimeKorisnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.PrezimeKorisnika.HeaderText = "Prezime";
            this.PrezimeKorisnika.MinimumWidth = 6;
            this.PrezimeKorisnika.Name = "PrezimeKorisnika";
            // 
            // BrojTelefona
            // 
            this.BrojTelefona.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojTelefona.HeaderText = "Broj Telefona";
            this.BrojTelefona.MinimumWidth = 6;
            this.BrojTelefona.Name = "BrojTelefona";
            // 
            // Email
            // 
            this.Email.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Email.HeaderText = "Email";
            this.Email.MinimumWidth = 6;
            this.Email.Name = "Email";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxEmail);
            this.panel1.Controls.Add(this.textBoxBrojTelefona);
            this.panel1.Controls.Add(this.textBoxPrezime);
            this.panel1.Controls.Add(this.textBoxIme);
            this.panel1.Controls.Add(this.textBoxJedinstveniMatičniBroj);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 786);
            this.panel1.TabIndex = 1;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(45, 580);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(480, 27);
            this.textBoxEmail.TabIndex = 3;
            // 
            // textBoxBrojTelefona
            // 
            this.textBoxBrojTelefona.Location = new System.Drawing.Point(45, 480);
            this.textBoxBrojTelefona.Name = "textBoxBrojTelefona";
            this.textBoxBrojTelefona.Size = new System.Drawing.Size(480, 27);
            this.textBoxBrojTelefona.TabIndex = 3;
            // 
            // textBoxPrezime
            // 
            this.textBoxPrezime.Location = new System.Drawing.Point(45, 380);
            this.textBoxPrezime.Name = "textBoxPrezime";
            this.textBoxPrezime.Size = new System.Drawing.Size(480, 27);
            this.textBoxPrezime.TabIndex = 3;
            // 
            // textBoxIme
            // 
            this.textBoxIme.Location = new System.Drawing.Point(45, 280);
            this.textBoxIme.Name = "textBoxIme";
            this.textBoxIme.Size = new System.Drawing.Size(480, 27);
            this.textBoxIme.TabIndex = 3;
            // 
            // textBoxJedinstveniMatičniBroj
            // 
            this.textBoxJedinstveniMatičniBroj.Location = new System.Drawing.Point(45, 180);
            this.textBoxJedinstveniMatičniBroj.Name = "textBoxJedinstveniMatičniBroj";
            this.textBoxJedinstveniMatičniBroj.Size = new System.Drawing.Size(480, 27);
            this.textBoxJedinstveniMatičniBroj.TabIndex = 3;
            this.textBoxJedinstveniMatičniBroj.TextChanged += new System.EventHandler(this.textBoxJedinstveniMatičniBroj_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(230, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Korisnik";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 550);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 450);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 20);
            this.label4.TabIndex = 2;
            this.label4.Text = "Broj telefona *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prezime *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 250);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "JMBG *";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(387, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.buttonObirši, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonIzmeni, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.buttonDodaj, 0, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 701);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(387, 85);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // buttonObirši
            // 
            this.buttonObirši.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonObirši.Image = ((System.Drawing.Image)(resources.GetObject("buttonObirši.Image")));
            this.buttonObirši.Location = new System.Drawing.Point(261, 3);
            this.buttonObirši.Name = "buttonObirši";
            this.buttonObirši.Size = new System.Drawing.Size(123, 79);
            this.buttonObirši.TabIndex = 0;
            this.buttonObirši.UseVisualStyleBackColor = true;
            this.buttonObirši.Click += new System.EventHandler(this.buttonObirši_Click);
            // 
            // buttonIzmeni
            // 
            this.buttonIzmeni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonIzmeni.Image = ((System.Drawing.Image)(resources.GetObject("buttonIzmeni.Image")));
            this.buttonIzmeni.Location = new System.Drawing.Point(132, 3);
            this.buttonIzmeni.Name = "buttonIzmeni";
            this.buttonIzmeni.Size = new System.Drawing.Size(123, 79);
            this.buttonIzmeni.TabIndex = 0;
            this.buttonIzmeni.UseVisualStyleBackColor = true;
            this.buttonIzmeni.Click += new System.EventHandler(this.buttonIzmeni_Click);
            // 
            // buttonDodaj
            // 
            this.buttonDodaj.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonDodaj.Image = ((System.Drawing.Image)(resources.GetObject("buttonDodaj.Image")));
            this.buttonDodaj.Location = new System.Drawing.Point(3, 3);
            this.buttonDodaj.Name = "buttonDodaj";
            this.buttonDodaj.Size = new System.Drawing.Size(123, 79);
            this.buttonDodaj.TabIndex = 0;
            this.buttonDodaj.UseVisualStyleBackColor = true;
            this.buttonDodaj.Click += new System.EventHandler(this.buttonDodaj_Click);
            // 
            // KorisnikControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "KorisnikControl";
            this.Size = new System.Drawing.Size(1311, 792);
            this.Load += new System.EventHandler(this.KorisnikControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewKorisnik)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewKorisnik;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn JmbgKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImeKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrezimeKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojTelefona;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonObirši;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxJedinstveniMatičniBroj;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textBoxBrojTelefona;
        private System.Windows.Forms.TextBox textBoxPrezime;
        private System.Windows.Forms.TextBox textBoxIme;
    }
}
