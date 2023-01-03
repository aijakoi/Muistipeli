using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.IO;
using testi2.Model;
using Newtonsoft.Json;

namespace testi2
{
    public partial class frmTilastot : Form
    {
        List<Tiedot> tiedot = new List<Tiedot>();
        private frmMuistipeli muistipeli;

        public frmTilastot(frmMuistipeli mp) // luodaan kutsu toiselle formille
        {
            InitializeComponent();

            muistipeli = mp;
            tiedot = mp.tiedot;

            BindingSource source = new BindingSource(); // asetetaan datagridviewin lähteeksi tiedot-lista
            source.DataSource = tiedot;
            dataGridView1.DataSource = source;




        }

        private void suljeLomakeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmTilastot_Load(object sender, EventArgs e)
        {

        }

        private void tiedotBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
