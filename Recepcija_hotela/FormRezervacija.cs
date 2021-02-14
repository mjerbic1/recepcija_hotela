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
    public partial class FormRezervacija : Form
    {
        public FormRezervacija()
        {
            InitializeComponent();
        }

        private void buttonFormRezervacijaOdustani_Click(object sender, EventArgs e)
        {
            (new FormIzbornik()).Show();
            this.Hide();
        }
    }
}
