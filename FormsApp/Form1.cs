using FormsApp.ServiceRef;
using System;
using System.Windows.Forms;

namespace ClientView
{
    public partial class Form1 : Form
    {
        ServiceContractClient service = new ServiceContractClient();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(service);
            form2.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3(service);
            form3.Show();
        }
    }
}
