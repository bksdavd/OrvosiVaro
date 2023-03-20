namespace WindowsFormsApp1
{
    partial class NapiAdatokForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDatum = new System.Windows.Forms.DateTimePicker();
            this.btnBetolt = new System.Windows.Forms.Button();
            this.lbBetegek = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lbNev = new System.Windows.Forms.Label();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTaj = new System.Windows.Forms.TextBox();
            this.tbSzDatum = new System.Windows.Forms.TextBox();
            this.btnRendez = new System.Windows.Forms.Button();
            this.btnKeres = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbKeres = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dátum választása";
            // 
            // dtpDatum
            // 
            this.dtpDatum.Location = new System.Drawing.Point(17, 34);
            this.dtpDatum.Name = "dtpDatum";
            this.dtpDatum.Size = new System.Drawing.Size(200, 28);
            this.dtpDatum.TabIndex = 1;
            // 
            // btnBetolt
            // 
            this.btnBetolt.Location = new System.Drawing.Point(17, 132);
            this.btnBetolt.Name = "btnBetolt";
            this.btnBetolt.Size = new System.Drawing.Size(200, 39);
            this.btnBetolt.TabIndex = 2;
            this.btnBetolt.Text = "Adatok betöltése";
            this.btnBetolt.UseVisualStyleBackColor = true;
            this.btnBetolt.Click += new System.EventHandler(this.btnBetolt_Click);
            // 
            // lbBetegek
            // 
            this.lbBetegek.FormattingEnabled = true;
            this.lbBetegek.ItemHeight = 22;
            this.lbBetegek.Location = new System.Drawing.Point(17, 196);
            this.lbBetegek.Name = "lbBetegek";
            this.lbBetegek.Size = new System.Drawing.Size(200, 378);
            this.lbBetegek.TabIndex = 3;
            this.lbBetegek.SelectedIndexChanged += new System.EventHandler(this.lbBetegek_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(360, 444);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Születési dátum";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 310);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 22);
            this.label3.TabIndex = 5;
            this.label3.Text = "TAJ";
            // 
            // lbNev
            // 
            this.lbNev.AutoSize = true;
            this.lbNev.Location = new System.Drawing.Point(360, 196);
            this.lbNev.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbNev.Name = "lbNev";
            this.lbNev.Size = new System.Drawing.Size(42, 22);
            this.lbNev.TabIndex = 6;
            this.lbNev.Text = "Név";
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(365, 221);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(241, 28);
            this.tbNev.TabIndex = 7;
            // 
            // tbTaj
            // 
            this.tbTaj.Location = new System.Drawing.Point(365, 335);
            this.tbTaj.Name = "tbTaj";
            this.tbTaj.Size = new System.Drawing.Size(241, 28);
            this.tbTaj.TabIndex = 8;
            // 
            // tbSzDatum
            // 
            this.tbSzDatum.Location = new System.Drawing.Point(365, 469);
            this.tbSzDatum.Name = "tbSzDatum";
            this.tbSzDatum.Size = new System.Drawing.Size(241, 28);
            this.tbSzDatum.TabIndex = 9;
            // 
            // btnRendez
            // 
            this.btnRendez.Location = new System.Drawing.Point(257, 554);
            this.btnRendez.Name = "btnRendez";
            this.btnRendez.Size = new System.Drawing.Size(99, 39);
            this.btnRendez.TabIndex = 10;
            this.btnRendez.Text = "Rendezés";
            this.btnRendez.UseVisualStyleBackColor = true;
            this.btnRendez.Click += new System.EventHandler(this.btnRendez_Click);
            // 
            // btnKeres
            // 
            this.btnKeres.Location = new System.Drawing.Point(492, 554);
            this.btnKeres.Name = "btnKeres";
            this.btnKeres.Size = new System.Drawing.Size(99, 39);
            this.btnKeres.TabIndex = 11;
            this.btnKeres.Text = "Keresés";
            this.btnKeres.UseVisualStyleBackColor = true;
            this.btnKeres.Click += new System.EventHandler(this.btnKeres_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(421, 516);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 22);
            this.label4.TabIndex = 12;
            this.label4.Text = "TAJ";
            // 
            // tbKeres
            // 
            this.tbKeres.Location = new System.Drawing.Point(470, 513);
            this.tbKeres.Name = "tbKeres";
            this.tbKeres.Size = new System.Drawing.Size(205, 28);
            this.tbKeres.TabIndex = 13;
            // 
            // NapiAdatokForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 619);
            this.Controls.Add(this.tbKeres);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnKeres);
            this.Controls.Add(this.btnRendez);
            this.Controls.Add(this.tbSzDatum);
            this.Controls.Add(this.tbTaj);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.lbNev);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbBetegek);
            this.Controls.Add(this.btnBetolt);
            this.Controls.Add(this.dtpDatum);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "NapiAdatokForm";
            this.Text = "NapiAdatokForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDatum;
        private System.Windows.Forms.Button btnBetolt;
        private System.Windows.Forms.ListBox lbBetegek;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lbNev;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTaj;
        private System.Windows.Forms.TextBox tbSzDatum;
        private System.Windows.Forms.Button btnRendez;
        private System.Windows.Forms.Button btnKeres;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbKeres;
    }
}