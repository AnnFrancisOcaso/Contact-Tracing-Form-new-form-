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
    public partial class Findspecificrecord : Form
    {
        public Findspecificrecord()
        {
            InitializeComponent();
        }

        private void Back2bttn_Click(object sender, EventArgs e)
        {
            Listofrecordsform f2 = new Listofrecordsform();
            f2.Show();
            this.Close();
        }

        private void Exitbttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
