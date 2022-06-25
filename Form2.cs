using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Contact_Tracing_Form_02
{
    public partial class Listofrecordsform : Form
    {
        public Listofrecordsform()
        {
            InitializeComponent();
        }

        private void Backbttn_Click(object sender, EventArgs e)
        {
            Contacttracingform f1 = new Contacttracingform();
            f1.Show();
            this.Close();
        }

        private void Nextbttn_Click(object sender, EventArgs e)
        {
            Findspecificrecord f3 = new Findspecificrecord();
            f3.Show();
            this.Close();
        }
    }
}
