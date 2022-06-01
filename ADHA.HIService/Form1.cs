using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADHA.HIService
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AddNewPatient_Click(object sender, EventArgs e)
        {
            AddPatient addPatient = new AddPatient();
            addPatient.Show();
        }
    }
}
