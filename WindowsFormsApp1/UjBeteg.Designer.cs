namespace WindowsFormsApp1
{
    partial class UjBeteg
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMentes = new System.Windows.Forms.Button();
            this.tbNev = new System.Windows.Forms.TextBox();
            this.tbTaj = new System.Windows.Forms.TextBox();
            this.dtpSzDatum = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Név";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 104);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "TAJ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 172);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Születési dátum";
            // 
            // btnMentes
            // 
            this.btnMentes.Location = new System.Drawing.Point(46, 253);
            this.btnMentes.Margin = new System.Windows.Forms.Padding(2);
            this.btnMentes.Name = "btnMentes";
            this.btnMentes.Size = new System.Drawing.Size(176, 52);
            this.btnMentes.TabIndex = 3;
            this.btnMentes.Text = "Mentés";
            this.btnMentes.UseVisualStyleBackColor = true;
            this.btnMentes.Click += new System.EventHandler(this.btnMentes_Click);
            // 
            // tbNev
            // 
            this.tbNev.Location = new System.Drawing.Point(46, 43);
            this.tbNev.Margin = new System.Windows.Forms.Padding(2);
            this.tbNev.Name = "tbNev";
            this.tbNev.Size = new System.Drawing.Size(51, 22);
            this.tbNev.TabIndex = 4;
            // 
            // tbTaj
            // 
            this.tbTaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbTaj.Location = new System.Drawing.Point(46, 122);
            this.tbTaj.Margin = new System.Windows.Forms.Padding(2);
            this.tbTaj.Name = "tbTaj";
            this.tbTaj.Size = new System.Drawing.Size(176, 30);
            this.tbTaj.TabIndex = 5;
            this.tbTaj.Validated += new System.EventHandler(this.tbTaj_Validated);
            // 
            // dtpSzDatum
            // 
            this.dtpSzDatum.Location = new System.Drawing.Point(46, 189);
            this.dtpSzDatum.Margin = new System.Windows.Forms.Padding(2);
            this.dtpSzDatum.Name = "dtpSzDatum";
            this.dtpSzDatum.Size = new System.Drawing.Size(176, 22);
            this.dtpSzDatum.TabIndex = 6;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // UjBeteg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(307, 450);
            this.Controls.Add(this.dtpSzDatum);
            this.Controls.Add(this.tbTaj);
            this.Controls.Add(this.tbNev);
            this.Controls.Add(this.btnMentes);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Name = "UjBeteg";
            this.Text = "UjBeteg";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMentes;
        private System.Windows.Forms.TextBox tbNev;
        private System.Windows.Forms.TextBox tbTaj;
        private System.Windows.Forms.DateTimePicker dtpSzDatum;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}