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

    public delegate void SendText(string text);
    public partial class Form2 : Form
    {
        public Form1 form1;
        public event SendText SendFrom2To1; 
        public Form2(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
            form1.SendFrom1To2+=(a)=>txtOutput.Text+=a+Environment.NewLine;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            SendFrom2To1?.Invoke(txtInput.Text);
            txtInput.Text = " ";
        }

    }
}
