namespace Recepcija_hotela
{
    partial class FormPrijaviSe
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
            this.buttonPrijava = new System.Windows.Forms.Button();
            this.labelKorIme = new System.Windows.Forms.Label();
            this.labelLozinka = new System.Windows.Forms.Label();
            this.textBoxKorIme = new System.Windows.Forms.TextBox();
            this.textBoxLozinka = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonPrijava
            // 
            this.buttonPrijava.Location = new System.Drawing.Point(175, 230);
            this.buttonPrijava.Name = "buttonPrijava";
            this.buttonPrijava.Size = new System.Drawing.Size(75, 23);
            this.buttonPrijava.TabIndex = 0;
            this.buttonPrijava.Text = "Prijavi se";
            this.buttonPrijava.UseVisualStyleBackColor = true;
            this.buttonPrijava.Click += new System.EventHandler(this.buttonPrijava_Click);
            // 
            // labelKorIme
            // 
            this.labelKorIme.AutoSize = true;
            this.labelKorIme.Location = new System.Drawing.Point(80, 76);
            this.labelKorIme.Name = "labelKorIme";
            this.labelKorIme.Size = new System.Drawing.Size(69, 13);
            this.labelKorIme.TabIndex = 1;
            this.labelKorIme.Text = "Krisničko ime";
            // 
            // labelLozinka
            // 
            this.labelLozinka.AutoSize = true;
            this.labelLozinka.Location = new System.Drawing.Point(80, 106);
            this.labelLozinka.Name = "labelLozinka";
            this.labelLozinka.Size = new System.Drawing.Size(44, 13);
            this.labelLozinka.TabIndex = 2;
            this.labelLozinka.Text = "Lozinka";
            // 
            // textBoxKorIme
            // 
            this.textBoxKorIme.Location = new System.Drawing.Point(175, 76);
            this.textBoxKorIme.Name = "textBoxKorIme";
            this.textBoxKorIme.Size = new System.Drawing.Size(100, 20);
            this.textBoxKorIme.TabIndex = 3;
            // 
            // textBoxLozinka
            // 
            this.textBoxLozinka.Location = new System.Drawing.Point(175, 106);
            this.textBoxLozinka.Name = "textBoxLozinka";
            this.textBoxLozinka.Size = new System.Drawing.Size(100, 20);
            this.textBoxLozinka.TabIndex = 4;
            // 
            // FormPrijaviSe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 294);
            this.Controls.Add(this.textBoxLozinka);
            this.Controls.Add(this.textBoxKorIme);
            this.Controls.Add(this.labelLozinka);
            this.Controls.Add(this.labelKorIme);
            this.Controls.Add(this.buttonPrijava);
            this.Name = "FormPrijaviSe";
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonPrijava;
        private System.Windows.Forms.Label labelKorIme;
        private System.Windows.Forms.Label labelLozinka;
        private System.Windows.Forms.TextBox textBoxKorIme;
        private System.Windows.Forms.TextBox textBoxLozinka;
    }
}

