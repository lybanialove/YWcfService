using FormsApp.ServiceRef;
using System;
using System.Windows.Forms;


namespace ClientView
{
    public partial class Form2 : Form
    {
        ServiceContractClient service;

        public Form2(ServiceContractClient _service)
        {
            InitializeComponent();
            service = _service;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authorization request = new Authorization() { login = textBox1.Text, password = textBox2.Text};
            string s = service.Autorization(request).message;
            if (s == "Password or login not founded")
            {
                MessageBox.Show(s);
            }
            else
            {
                MessageBox.Show(s);
                Form4 form4 = new Form4(service);
                form4.Show();
            }
            
        }
    }
}

//Autorization autorization = new Autorization() { login = textBox1.Text, password = textBox2.Text };
//string s = sc.Autorization(autorization).message;
//if (s == "Password or login not founded")
//{
//    MessageBox.Show(s);
//}
//else
//{
//    MessageBox.Show(s);
//    Form3 form3 = new Form3(sc);
//    form3.Show();
//}