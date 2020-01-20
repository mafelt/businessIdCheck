using System;
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
                MessageBox.Show("Y-tunnuksen kirjoitusasu on oikein!", "Oikein", MessageBoxButtons.OK, MessageBoxIcon.None);
            } 
            else
            {
                MessageBox.Show(string.Join(Environment.NewLine, specification.ReasonsForDissatisfaction),"Virhe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
