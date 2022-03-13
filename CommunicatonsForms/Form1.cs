using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CommunicatonsForms
{

    public partial class Form1 : Form
    {
        public event SendText SendFrom1To2;
        public Form1()
        {
            InitializeComponent();
            
        }


        private void btnSender_Click(object sender, EventArgs e)
        {
            SendFrom1To2?.Invoke(txtInput.Text);
            txtInput.Text = " ";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(this);
            form2.SendFrom2To1 += (b) => txtOutput.Text += b+Environment.NewLine;
            form2.Show();
        }
    }
}
