using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment1GUI
{
    public partial class Home : UserControl
    {
        public Home()
        {
            InitializeComponent();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            bool citizen = citizenBox.Checked;
            int age_INT = Convert.ToInt32(ageTextBox.Text);
            int resident_INT = Convert.ToInt32(residentTextBox.Text);
            int terms_INT = Convert.ToInt32(termsTextBox.Text);
            bool rebelled = rebelledBox.Checked;


            if (citizen && (age_INT >= 1985) && (resident_INT >= 14) && (terms_INT < 2) && !(rebelled))
            {
                MessageBox.Show("You Are Eligible To Be President!!!");
            }

            else
            {
                MessageBox.Show("SORRY!! You Can't Be President!!!");
            }
        }
    }
}
