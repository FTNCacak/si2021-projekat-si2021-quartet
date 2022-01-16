namespace ePunjačiDesktopApp
{
    partial class PriključciControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriključciControl));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridViewPriključci = new System.Windows.Forms.DataGridView();
            this.IdPriključka = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indikator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdPunjača = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snaga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxIndikator = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxIdPunjača = new System.Windows.Forms.TextBox();
            this.textBoxIdPriključka = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.buttonObriši = new System.Windows.Forms.Button();
            this.buttonIzmeni = new System.Windows.Forms.Button();
            this.buttonDodaj = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriključci)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridViewPriključci, 1, 0);
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
            // dataGridViewPriključci
            // 
            this.dataGridViewPriključci.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewPriključci.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IdPriključka,
            this.Indikator,
            this.IdPunjača,
            this.Snaga});
            this.dataGridViewPriključci.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewPriključci.Location = new System.Drawing.Point(396, 3);
            this.dataGridViewPriključci.Name = "dataGridViewPriključci";
            this.dataGridViewPriključci.RowHeadersWidth = 51;
            this.dataGridViewPriključci.Size = new System.Drawing.Size(912, 786);
            this.dataGridViewPriključci.TabIndex = 0;
            this.dataGridViewPriključci.Text = "dataGridView1";
            this.dataGridViewPriključci.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewPriključci_CellClick);
            // 
            // IdPriključka
            // 
            this.IdPriključka.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdPriključka.HeaderText = "Id Priključka ";
            this.IdPriključka.MinimumWidth = 6;
            this.IdPriključka.Name = "IdPriključka";
            this.IdPriključka.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Indikator
            // 
            this.Indikator.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Indikator.HeaderText = "Indikator";
            this.Indikator.MinimumWidth = 6;
            this.Indikator.Name = "Indikator";
            this.Indikator.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // IdPunjača
            // 
            this.IdPunjača.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.IdPunjača.HeaderText = "Id Punjača";
            this.IdPunjača.MinimumWidth = 6;
            this.IdPunjača.Name = "IdPunjača";
            this.IdPunjača.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // Snaga
            // 
            this.Snaga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Snaga.HeaderText = "Snaga";
            this.Snaga.MinimumWidth = 6;
            this.Snaga.Name = "Snaga";
            this.Snaga.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.comboBoxIndikator);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBoxIdPunjača);
            this.panel1.Controls.Add(this.textBoxIdPriključka);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.tableLayoutPanel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(387, 786);
            this.panel1.TabIndex = 1;
            // 
            // comboBoxIndikator
            // 
            this.comboBoxIndikator.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxIndikator.FormattingEnabled = true;
            this.comboBoxIndikator.Items.AddRange(new object[] {
            "True",
            "False"});
            this.comboBoxIndikator.Location = new System.Drawing.Point(45, 380);
            this.comboBoxIndikator.Name = "comboBoxIndikator";
            this.comboBoxIndikator.Size = new System.Drawing.Size(151, 28);
            this.comboBoxIndikator.TabIndex = 5;
            this.comboBoxIndikator.SelectedIndexChanged += new System.EventHandler(this.comboBoxIndikator_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(220, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(105, 28);
            this.label4.TabIndex = 4;
            this.label4.Text = "Priključak";
            // 
            // textBoxIdPunjača
            // 
            this.textBoxIdPunjača.Location = new System.Drawing.Point(45, 530);
            this.textBoxIdPunjača.Name = "textBoxIdPunjača";
            this.textBoxIdPunjača.Size = new System.Drawing.Size(480, 27);
            this.textBoxIdPunjača.TabIndex = 3;
            // 
            // textBoxIdPriključka
            // 
            this.textBoxIdPriključka.Location = new System.Drawing.Point(45, 230);
            this.textBoxIdPriključka.Name = "textBoxIdPriključka";
            this.textBoxIdPriključka.Size = new System.Drawing.Size(480, 27);
            this.textBoxIdPriključka.TabIndex = 3;
            this.textBoxIdPriključka.TextChanged += new System.EventHandler(this.textBoxIdPriključka_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 500);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Id Punjača *";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 350);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Indikator *";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 200);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Id Priključka *";
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
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.buttonObriši, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonIzmeni, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.buttonDodaj, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 701);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(387, 85);
            this.tableLayoutPanel3.TabIndex = 0;
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
            this.buttonIzmeni.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonIzmeni.BackgroundImage")));
            this.buttonIzmeni.Dock = System.Windows.Forms.DockStyle.Fill;
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
            // PriključciControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "PriključciControl";
            this.Size = new System.Drawing.Size(1311, 792);
            this.Load += new System.EventHandler(this.PriključciControl_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewPriključci)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.DataGridView dataGridViewPriključci;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPriključka;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indikator;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdPunjača;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snaga;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxIdPunjača;
        private System.Windows.Forms.TextBox textBoxIdPriključka;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button buttonObriši;
        private System.Windows.Forms.Button buttonIzmeni;
        private System.Windows.Forms.Button buttonDodaj;
        private System.Windows.Forms.ComboBox comboBoxIndikator;
        private System.Windows.Forms.Label label4;
    }
}
