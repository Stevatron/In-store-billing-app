using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsProjekat
{
    public partial class PocetniEkran : Form
    {
        public PocetniEkran()
        {
            InitializeComponent();
            MaximizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void btAdministracijaStatistika_Click(object sender, EventArgs e)
        {
            AdministracijaIStatistika forma1 = new AdministracijaIStatistika();
            forma1.Show();

        }

        private void btProdaja_Naplata_Click(object sender, EventArgs e)
        {
            Prodaja_Naplata forma2 = new Prodaja_Naplata();
            forma2.Show();
        }

        private void PocetniEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
