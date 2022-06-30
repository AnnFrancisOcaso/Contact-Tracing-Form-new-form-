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
    public partial class Contacttracingform : Form
    {
        public Contacttracingform()
        {
            InitializeComponent();
        }

        private void Submit_Click(object sender, EventArgs e)
        {
            StreamWriter file = new StreamWriter(@"C:\Users\Phenyang\source\repos\Contact Tracing Form_02\Record for contact tracing form.txt", true);
            file.WriteLine("Date: " + Datebttn.Text);
            file.WriteLine("Time: " + timebx.Text);
            file.WriteLine("Temperature: " + temperaturebx.Text);

            


            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
