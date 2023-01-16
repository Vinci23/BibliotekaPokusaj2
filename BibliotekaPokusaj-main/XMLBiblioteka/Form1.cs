using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace XMLBiblioteka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnUnos_Click(object sender, EventArgs e)
        {
            UnosKorisnika frmUnos = new UnosKorisnika();
            frmUnos.Show();
        }

        private void btnUnosKnjige_Click(object sender, EventArgs e)
        {
            UnosKnjiga frmUnosKnjiga = new UnosKnjiga();
            frmUnosKnjiga.Show();
        }
    }
}
