using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bilgi_Yarismasi
{
    public partial class FrmBaslat : Form
    {
        public FrmBaslat()
        {
            InitializeComponent();
        }

        private void BtnYarismayaBasla_Click(object sender, EventArgs e)
        {
            FrmYarisma fr = new FrmYarisma();
            fr.Show();
            this.Hide();
        }

        private void FrmBaslat_Load(object sender, EventArgs e)
        {

        }
    }
}
