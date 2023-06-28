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
            AdministracijaIStatistika admstat = new AdministracijaIStatistika();
            admstat.Show();
        }

        private void btProdaja_Naplata_Click(object sender, EventArgs e)
        {
            Prodaja_Naplata prodnap = new Prodaja_Naplata();
            prodnap.Show();
        }

        private void PocetniEkran_Load(object sender, EventArgs e)
        {
            AdministracijaIStatistika admstat = new AdministracijaIStatistika();
            Prodaja_Naplata prodnap = new Prodaja_Naplata();
            admstat.SetEnglishLang();
            prodnap.SetEnglishLang();
        }

        private void srb_Click(object sender, EventArgs e)
        {
            AdministracijaIStatistika admstat = new AdministracijaIStatistika();
            Prodaja_Naplata prodnap = new Prodaja_Naplata();
            admstat.SetSerbianLang();
            prodnap.SetSerbianLang();
            this.Text = "Aplikacija za trgovinu";
            btAdministracijaStatistika.Text = "Administracija/Statistika";
            btProdaja_Naplata.Text = "Prodaja/Naplata";
        }

        private void eng_Click(object sender, EventArgs e)
        {
            AdministracijaIStatistika admstat = new AdministracijaIStatistika();
            Prodaja_Naplata prodnap = new Prodaja_Naplata();
            admstat.SetEnglishLang();
            prodnap.SetEnglishLang();
            this.Text = "Application for marketplace";
            btAdministracijaStatistika.Text = "Administration/Statistics";
            btProdaja_Naplata.Text = "Selling/Billing";
        }

    }
}
