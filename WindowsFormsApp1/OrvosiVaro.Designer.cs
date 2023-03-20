namespace WindowsFormsApp1
{
    partial class Form1
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
            this.lbVarakozo = new System.Windows.Forms.ListBox();
            this.btnFelvesz = new System.Windows.Forms.Button();
            this.btnBehiv = new System.Windows.Forms.Button();
            this.btnBetegSzam = new System.Windows.Forms.Button();
            this.btnNapi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 23);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Várakozók";
            // 
            // lbVarakozo
            // 
            this.lbVarakozo.FormattingEnabled = true;
            this.lbVarakozo.ItemHeight = 16;
            this.lbVarakozo.Location = new System.Drawing.Point(11, 41);
            this.lbVarakozo.Margin = new System.Windows.Forms.Padding(2);
            this.lbVarakozo.Name = "lbVarakozo";
            this.lbVarakozo.Size = new System.Drawing.Size(114, 244);
            this.lbVarakozo.TabIndex = 1;
            // 
            // btnFelvesz
            // 
            this.btnFelvesz.Location = new System.Drawing.Point(145, 207);
            this.btnFelvesz.Margin = new System.Windows.Forms.Padding(2);
            this.btnFelvesz.Name = "btnFelvesz";
            this.btnFelvesz.Size = new System.Drawing.Size(140, 22);
            this.btnFelvesz.TabIndex = 2;
            this.btnFelvesz.Text = "Beteg Felvétele";
            this.btnFelvesz.UseVisualStyleBackColor = true;
            this.btnFelvesz.Click += new System.EventHandler(this.btnFelvesz_Click);
            // 
            // btnBehiv
            // 
            this.btnBehiv.Location = new System.Drawing.Point(145, 233);
            this.btnBehiv.Margin = new System.Windows.Forms.Padding(2);
            this.btnBehiv.Name = "btnBehiv";
            this.btnBehiv.Size = new System.Drawing.Size(140, 22);
            this.btnBehiv.TabIndex = 3;
            this.btnBehiv.Text = "Beteg Behívása";
            this.btnBehiv.UseVisualStyleBackColor = true;
            this.btnBehiv.Click += new System.EventHandler(this.btnBehiv_Click);
            // 
            // btnBetegSzam
            // 
            this.btnBetegSzam.Location = new System.Drawing.Point(145, 263);
            this.btnBetegSzam.Margin = new System.Windows.Forms.Padding(2);
            this.btnBetegSzam.Name = "btnBetegSzam";
            this.btnBetegSzam.Size = new System.Drawing.Size(140, 22);
            this.btnBetegSzam.TabIndex = 4;
            this.btnBetegSzam.Text = "Betegek száma";
            this.btnBetegSzam.UseVisualStyleBackColor = true;
            this.btnBetegSzam.Click += new System.EventHandler(this.btnBetegSzam_Click);
            // 
            // btnNapi
            // 
            this.btnNapi.Location = new System.Drawing.Point(145, 355);
            this.btnNapi.Margin = new System.Windows.Forms.Padding(2);
            this.btnNapi.Name = "btnNapi";
            this.btnNapi.Size = new System.Drawing.Size(140, 22);
            this.btnNapi.TabIndex = 5;
            this.btnNapi.Text = "Napi adatok";
            this.btnNapi.UseVisualStyleBackColor = true;
            this.btnNapi.Click += new System.EventHandler(this.btnNapi_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(578, 449);
            this.Controls.Add(this.btnNapi);
            this.Controls.Add(this.btnBetegSzam);
            this.Controls.Add(this.btnBehiv);
            this.Controls.Add(this.btnFelvesz);
            this.Controls.Add(this.lbVarakozo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lbVarakozo;
        private System.Windows.Forms.Button btnFelvesz;
        private System.Windows.Forms.Button btnBehiv;
        private System.Windows.Forms.Button btnBetegSzam;
        private System.Windows.Forms.Button btnNapi;
    }
}

