using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Garderoba
{
    public partial class Start : Form
    {
        public Start()
        {
            InitializeComponent();
        }

        private void btnRozpocznij_Click(object sender, EventArgs e)
        {
            (new Krok1()).Show();            
            this.Hide();
        }
    }
}
