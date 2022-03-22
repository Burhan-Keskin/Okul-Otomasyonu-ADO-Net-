using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADO_OKUL_Form
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void aDRESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Adres adres = new Adres();
            adres.Show();
            this.Show();

        
        }

        private void öĞRENCİToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form Ogrenci = new Form1();
            Ogrenci.Show();
            this.Show();
        }
    }
}
