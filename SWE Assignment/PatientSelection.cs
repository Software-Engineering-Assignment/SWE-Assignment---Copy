using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SWE_Assignment
{
    public partial class PatientSelection : Form
    {
        public PatientSelection()
        {
            InitializeComponent();

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 1");
            f9.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 2");
            f9.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 3");
            f9.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 4");
            f9.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 5");
            f9.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 6");
            f9.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 7");
            f9.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
            PatientMenu f9 = new PatientMenu("BedSide 8");
            f9.Show();
        }
    }
}
