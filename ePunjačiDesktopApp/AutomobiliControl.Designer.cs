namespace ePunjačiDesktopApp
{
    partial class AutomobiliControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutomobiliControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewAutomobili = new System.Windows.Forms.DataGridView();
            this.BrojŠasije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPriključka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JMBGKorisnika = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Marka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KapacitetBaterije = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxKapacitetBaterije = new System.Windows.Forms.TextBox();
            this.textBoxTip = new System.Windows.Forms.TextBox();
            this.textBoxMarka = new System.Windows.Forms.TextBox();
            this.textBoxJMBG = new System.Windows.Forms.TextBox();
            this.textBoxIdPrikljućka = new System.Windows.Forms.TextBox();
            this.textBoxBtojŠasije = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonObriši = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomobili)).BeginInit();
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
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewAutomobili, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1311, 792);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // dataGridViewAutomobili
            // 
            this.dataGridViewAutomobili.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAutomobili.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BrojŠasije,
            this.IdPriključka,
            this.JMBGKorisnika,
            this.Marka,
            this.Tip,
            this.KapacitetBaterije});
            this.dataGridViewAutomobili.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewAutomobili.Location = new System.Drawing.Point(396, 3);
            this.dataGridViewAutomobili.Name = "dataGridViewAutomobili";
            this.dataGridViewAutomobili.RowHeadersWidth = 51;
            this.dataGridViewAutomobili.Size = new System.Drawing.Size(912, 786);
            this.dataGridViewAutomobili.TabIndex = 0;
            this.dataGridViewAutomobili.Text = "dataGridView1";
            this.dataGridViewAutomobili.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewAutomobili_CellClick);
            // 
            // BrojŠasije
            // 
            this.BrojŠasije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.BrojŠasije.HeaderText = "Broj šasije";
            this.BrojŠasije.MinimumWidth = 6;
            this.BrojŠasije.Name = "BrojŠasije";
            // 
            // IdPriključka
            // 
            this.IdPriključka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdPriključka.HeaderText = "Id priključka";
            this.IdPriključka.MinimumWidth = 6;
            this.IdPriključka.Name = "IdPriključka";
            // 
            // JMBGKorisnika
            // 
            this.JMBGKorisnika.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.JMBGKorisnika.HeaderText = "JMBG korisnika";
            this.JMBGKorisnika.MinimumWidth = 6;
            this.JMBGKorisnika.Name = "JMBGKorisnika";
            // 
            // Marka
            // 
            this.Marka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Marka.HeaderText = "Marka";
            this.Marka.MinimumWidth = 6;
            this.Marka.Name = "Marka";
            // 
            // Tip
            // 
            this.Tip.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Tip.HeaderText = "Tip";
            this.Tip.MinimumWidth = 6;
            this.Tip.Name = "Tip";
            // 
            // KapacitetBaterije
            // 
            this.KapacitetBaterije.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.KapacitetBaterije.HeaderText = "Kapacitet baterije  ";
            this.KapacitetBaterije.MinimumWidth = 6;
            this.KapacitetBaterije.Name = "KapacitetBaterije";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.textBoxKapacitetBaterije);
            this.panel1.Controls.Add(this.textBoxTip);
            this.panel1.Controls.Add(this.textBoxMarka);
            this.panel1.Controls.Add(this.textBoxJMBG);
            this.panel1.Controls.Add(this.textBoxIdPrikljućka);
            this.panel1.Controls.Add(this.textBoxBtojŠasije);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
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
            // textBoxKapacitetBaterije
            // 
            this.textBoxKapacitetBaterije.Location = new System.Drawing.Point(45, 670);
            this.textBoxKapacitetBaterije.Name = "textBoxKapacitetBaterije";
            this.textBoxKapacitetBaterije.Size = new System.Drawing.Size(480, 27);
            this.textBoxKapacitetBaterije.TabIndex = 3;
            this.textBoxKapacitetBaterije.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxTip
            // 
            this.textBoxTip.Location = new System.Drawing.Point(45, 570);
            this.textBoxTip.Name = "textBoxTip";
            this.textBoxTip.Size = new System.Drawing.Size(480, 27);
            this.textBoxTip.TabIndex = 3;
            this.textBoxTip.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxMarka
            // 
            this.textBoxMarka.Location = new System.Drawing.Point(45, 470);
            this.textBoxMarka.Name = "textBoxMarka";
            this.textBoxMarka.Size = new System.Drawing.Size(480, 27);
            this.textBoxMarka.TabIndex = 3;
            this.textBoxMarka.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxJMBG
            // 
            this.textBoxJMBG.Location = new System.Drawing.Point(45, 370);
            this.textBoxJMBG.Name = "textBoxJMBG";
            this.textBoxJMBG.Size = new System.Drawing.Size(480, 27);
            this.textBoxJMBG.TabIndex = 3;
            this.textBoxJMBG.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxIdPrikljućka
            // 
            this.textBoxIdPrikljućka.Location = new System.Drawing.Point(45, 270);
            this.textBoxIdPrikljućka.Name = "textBoxIdPrikljućka";
            this.textBoxIdPrikljućka.Size = new System.Drawing.Size(480, 27);
            this.textBoxIdPrikljućka.TabIndex = 3;
            this.textBoxIdPrikljućka.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // textBoxBtojŠasije
            // 
            this.textBoxBtojŠasije.Location = new System.Drawing.Point(45, 170);
            this.textBoxBtojŠasije.Name = "textBoxBtojŠasije";
            this.textBoxBtojŠasije.Size = new System.Drawing.Size(480, 27);
            this.textBoxBtojŠasije.TabIndex = 3;
            this.textBoxBtojŠasije.TextChanged += new System.EventHandler(this.textBoxBtojŠasije_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(225, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 28);
            this.label8.TabIndex = 2;
            this.label8.Text = "Automobil";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(45, 640);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Kapacitet baterije *";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 540);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tip *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 440);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 2;
            this.label5.Text = "Marka *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 340);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "JMBG korisnika *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Id priključka *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Broj šasij *";
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
            this.tableLayoutPanel2.Controls.Add(this.buttonObriši, 2, 0);
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
            // buttonObriši
            // 
            this.buttonObriši.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonObriši.Image = ((System.Drawing.Image)(resources.GetObject("buttonObriši.Image")));
            this.buttonObriši.Location = new System.Drawing.Point(261, 3);
            this.buttonObriši.Name = "buttonObriši";
            this.buttonObriši.Size = new System.Drawing.Size(123, 79);
            this.buttonObriši.TabIndex = 0;
            this.buttonObriši.UseVisualStyleBackColor = true;
            this.buttonObriši.Click += new System.EventHandler(this.buttonObriši_Click);
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
            // AutomobiliControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "AutomobiliControl";
            this.Size = new System.Drawing.Size(1311, 792);
            this.Load += new System.EventHandler(this.AutomobiliControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAutomobili)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TextBox textBoxIdPrikljućka;
        private System.Windows.Forms.TextBox textBoxBtojŠasije;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonObriši;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.TextBox textBoxKapacitetBaterije;
        private System.Windows.Forms.TextBox textBoxTip;
        private System.Windows.Forms.TextBox textBoxMarka;
        private System.Windows.Forms.TextBox textBoxJMBG;
        private System.Windows.Forms.DataGridView dataGridViewAutomobili;
        private System.Windows.Forms.DataGridViewTextBoxColumn BrojŠasije;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPriključka;
        private System.Windows.Forms.DataGridViewTextBoxColumn JMBGKorisnika;
        private System.Windows.Forms.DataGridViewTextBoxColumn Marka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tip;
        private System.Windows.Forms.DataGridViewTextBoxColumn KapacitetBaterije;
    }
}
