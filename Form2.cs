using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        private void Listbttn_Click(object sender, EventArgs e)
        {
            StreamReader reader = new StreamReader(@"C:\Users\Phenyang\source\repos\Contact Tracing Form_02\Record for contact tracing form.txt");

            while (!reader.EndOfStream)
            {
                String line = reader.ReadLine();
                MessageBox.Show(line);
            }
        }
    }
}
