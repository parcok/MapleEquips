using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MapleEquips.Forms
{
    public partial class NewCharacter : Form
    {
        public NewCharacter()
        {
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private Form1 mainForm = null;
        public NewCharacter(Form callingForm)
        {
            mainForm = callingForm as Form1;
            InitializeComponent();
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please enter a name.");
            }
            else if (comboBox1.SelectedIndex == 0) {
                MessageBox.Show("Please select a valid class.");
            } else // TODO valid character creation, need to make the object first
            {
                //this.mainForm.button1.Text = "Testing";
            }

        }
    }
}
