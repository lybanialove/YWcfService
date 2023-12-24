using FormsApp.ServiceRef;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ClientView
{
    public partial class Form4 : Form
    {
        ServiceContractClient service;
        List<Product> products;
        int sum = 0;       

        public Form4(ServiceContractClient _service)
        {
            InitializeComponent();
            service = _service;
            products = new List<Product>();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OrderFood order = new OrderFood() { adress = textBox1.Text, products = products.ToArray() };
            service.OrderFood(order);
            MessageBox.Show("You order is successful!");
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            
              
        }

        private void listBox2_DoubleClick(object sender, EventArgs e)
        {
            string s = listBox2.SelectedItem.ToString();
            string[] vs = s.Split(' ');
            
            Product product = new Product() { name = vs[0], price = int.Parse(vs[1]) };
            products.Add(product);
            listBox1.Items.Clear();
            sum = 0;
            foreach (var pr in products)
            {
                listBox1.Items.Add($"{pr.name} {pr.price} {pr.manufacturer}");
                sum += pr.price;
            }
                   

            label1.Text = sum.ToString();

        }

        private void listBox1_DoubleClick(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            products.RemoveAt(i);
            listBox1.Items.Clear();
            sum = 0;
            foreach (var pr in products)
            {
                listBox1.Items.Add($"{pr.name} {pr.price} {pr.manufacturer}");
                sum -= pr.price;
            }
            sum *= -1;
            label1.Text = sum.ToString();
        }


        private void label1_Click(object sender, EventArgs e)
        {
            label1.Text = sum.ToString();
        }
    }
}
