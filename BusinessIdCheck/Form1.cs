using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusinessIdCheck
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCheck_Click(object sender, EventArgs e)
        {
            BusinessIdSpecification specification = new BusinessIdSpecification();
            if (specification.IsSatisfiedBy(inputTextBox.Text))
            {
                MessageBox.Show("Y-tunnukset kirjoitusasu on oikein!", "Oikein", MessageBoxButtons.OK, MessageBoxIcon.None);
            } 
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, specification.ReasonsForDissatisfaction),"Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
