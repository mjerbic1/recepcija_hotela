using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Recepcija_hotela
{
    public partial class FormIzbornik : Form
    {
        public FormIzbornik()
        {
            InitializeComponent();
        }
        private void formIzbornikRezervacije_Click(object sender, EventArgs e)
        {
            (new FormRezervacija()).Show();
            this.Hide();
        }
        private void formIzbornikPrijave_Click(object sender, EventArgs e)
        {
            (new Prijava()).Show();
            this.Hide();
        }

        private void formIzbornikOdjaviSe_Click(object sender, EventArgs e)
        {
            (new FormPrijaviSe()).Show();
            this.Hide();
        }
    }
}
