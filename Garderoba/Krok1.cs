using OfficeOpenXml.FormulaParsing.Excel.Functions.Text;
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
    public partial class Krok1 : Form
    {
        public Krok1()
        {
            InitializeComponent();
        }

        private void buttonContinue_Click(object sender, EventArgs e)
        {
            if ((radioButtonSpecialDay.Checked || radioButtonCasual.Checked) && (radioButtonCold.Checked || radioButtonWarm.Checked))
            {
                (new Krok2()).Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Nie zaznaczyłeś wszystkiego co trzeba:(");
            }
            
        }

    }
}
