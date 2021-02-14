namespace Recepcija_hotela
{
    partial class FormIzbornik
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
            this.formIzbornikRezervacije = new System.Windows.Forms.Button();
            this.formIzbornikPrijave = new System.Windows.Forms.Button();
            this.formIzbornikSteta = new System.Windows.Forms.Button();
            this.formIzbornikIzvjesca = new System.Windows.Forms.Button();
            this.formIzbornikNarudzbe = new System.Windows.Forms.Button();
            this.formIzbornikKorRacuni = new System.Windows.Forms.Button();
            this.formIzbornikOdjaviSe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // formIzbornikRezervacije
            // 
            this.formIzbornikRezervacije.Location = new System.Drawing.Point(145, 12);
            this.formIzbornikRezervacije.Name = "formIzbornikRezervacije";
            this.formIzbornikRezervacije.Size = new System.Drawing.Size(140, 32);
            this.formIzbornikRezervacije.TabIndex = 0;
            this.formIzbornikRezervacije.Text = "Rezervacije";
            this.formIzbornikRezervacije.UseVisualStyleBackColor = true;
            this.formIzbornikRezervacije.Click += new System.EventHandler(this.formIzbornikRezervacije_Click);
            // 
            // formIzbornikPrijave
            // 
            this.formIzbornikPrijave.Location = new System.Drawing.Point(145, 43);
            this.formIzbornikPrijave.Name = "formIzbornikPrijave";
            this.formIzbornikPrijave.Size = new System.Drawing.Size(140, 33);
            this.formIzbornikPrijave.TabIndex = 1;
            this.formIzbornikPrijave.Text = "Prijave";
            this.formIzbornikPrijave.UseVisualStyleBackColor = true;
            this.formIzbornikPrijave.Click += new System.EventHandler(this.formIzbornikPrijave_Click);
            // 
            // formIzbornikSteta
            // 
            this.formIzbornikSteta.Location = new System.Drawing.Point(145, 93);
            this.formIzbornikSteta.Name = "formIzbornikSteta";
            this.formIzbornikSteta.Size = new System.Drawing.Size(140, 34);
            this.formIzbornikSteta.TabIndex = 2;
            this.formIzbornikSteta.Text = "Šteta";
            this.formIzbornikSteta.UseVisualStyleBackColor = true;
            // 
            // formIzbornikIzvjesca
            // 
            this.formIzbornikIzvjesca.Location = new System.Drawing.Point(145, 127);
            this.formIzbornikIzvjesca.Name = "formIzbornikIzvjesca";
            this.formIzbornikIzvjesca.Size = new System.Drawing.Size(140, 34);
            this.formIzbornikIzvjesca.TabIndex = 3;
            this.formIzbornikIzvjesca.Text = "Izvješća";
            this.formIzbornikIzvjesca.UseVisualStyleBackColor = true;
            // 
            // formIzbornikNarudzbe
            // 
            this.formIzbornikNarudzbe.Location = new System.Drawing.Point(145, 176);
            this.formIzbornikNarudzbe.Name = "formIzbornikNarudzbe";
            this.formIzbornikNarudzbe.Size = new System.Drawing.Size(140, 33);
            this.formIzbornikNarudzbe.TabIndex = 4;
            this.formIzbornikNarudzbe.Text = "Narudžbe";
            this.formIzbornikNarudzbe.UseVisualStyleBackColor = true;
            // 
            // formIzbornikKorRacuni
            // 
            this.formIzbornikKorRacuni.Location = new System.Drawing.Point(145, 206);
            this.formIzbornikKorRacuni.Name = "formIzbornikKorRacuni";
            this.formIzbornikKorRacuni.Size = new System.Drawing.Size(140, 30);
            this.formIzbornikKorRacuni.TabIndex = 5;
            this.formIzbornikKorRacuni.Text = "Korisnički računi";
            this.formIzbornikKorRacuni.UseVisualStyleBackColor = true;
            // 
            // formIzbornikOdjaviSe
            // 
            this.formIzbornikOdjaviSe.Location = new System.Drawing.Point(158, 269);
            this.formIzbornikOdjaviSe.Name = "formIzbornikOdjaviSe";
            this.formIzbornikOdjaviSe.Size = new System.Drawing.Size(109, 36);
            this.formIzbornikOdjaviSe.TabIndex = 6;
            this.formIzbornikOdjaviSe.Text = "Odjavi se";
            this.formIzbornikOdjaviSe.UseVisualStyleBackColor = true;
            this.formIzbornikOdjaviSe.Click += new System.EventHandler(this.formIzbornikOdjaviSe_Click);
            // 
            // FormIzbornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 336);
            this.Controls.Add(this.formIzbornikOdjaviSe);
            this.Controls.Add(this.formIzbornikKorRacuni);
            this.Controls.Add(this.formIzbornikNarudzbe);
            this.Controls.Add(this.formIzbornikIzvjesca);
            this.Controls.Add(this.formIzbornikSteta);
            this.Controls.Add(this.formIzbornikPrijave);
            this.Controls.Add(this.formIzbornikRezervacije);
            this.Name = "FormIzbornik";
            this.Text = "Izbornik";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button formIzbornikRezervacije;
        private System.Windows.Forms.Button formIzbornikPrijave;
        private System.Windows.Forms.Button formIzbornikSteta;
        private System.Windows.Forms.Button formIzbornikIzvjesca;
        private System.Windows.Forms.Button formIzbornikNarudzbe;
        private System.Windows.Forms.Button formIzbornikKorRacuni;
        private System.Windows.Forms.Button formIzbornikOdjaviSe;
    }
}