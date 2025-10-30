using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private int totalPrice;

        private void Form1_Load(object sender, EventArgs e)
        {
            cbProduct.Items.Add("Code1");
            cbProduct.Items.Add("Code2");
            cbProduct.Items.Add("Code3");

            cbProduct.Text = "Code1";
            tb_productName.Text = "Product1";
            tb_unitPrice.Text = "100";
            pb_productImage.Image = Image.FromFile("product1.jpg");

            UpdateTotal();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            cbProduct.Text = "Code1";
            tb_productName.Text = "Product1";
            tb_unitPrice.Text = "100";
            numQty.Value = 0;
            rb_cash.Checked = false;
            rb_visa.Checked = false;
            cb_freeDelivery.Checked = false;
            tb_total.Text = "0";
            lb_outputMessage.Text = string.Empty;
        }

        private void cbProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbProduct.Text == "Code1")
            {
                tb_productName.Text = "Product1";
                tb_unitPrice.Text = "100";
                pb_productImage.Image = Image.FromFile("product1.jpg");
            }
            else if (cbProduct.Text == "Code2")
            {
                tb_productName.Text = "Product2";
                tb_unitPrice.Text = "200";
                pb_productImage.Image = Image.FromFile("product2.jpg");
            }
            else if (cbProduct.Text == "Code3")
            {
                tb_productName.Text = "Product3";
                tb_unitPrice.Text = "300";
                pb_productImage.Image = Image.FromFile("product3.jpg");
            }

            UpdateTotal();
        }

        private void numQty_ValueChanged(object sender, EventArgs e)
        {
            UpdateTotal();
        }

        private void btn_order_Click(object sender, EventArgs e)
        {
            string str1 = "Payment is ";
            lb_outputMessage.Text = "You have ordered " + numQty.Value.ToString() +
                " units of " + tb_productName.Text +
                " with total cost equal to HK$" + tb_total.Text;

            if (rb_cash.Checked)
            {
                str1 += "Cash";
            }
            else if (rb_visa.Checked)
            {
                str1 += "Visa";
            }

            if (cb_freeDelivery.Checked)
            {
                str1 += " with free delivery.";
            }

            lb_outputMessage.Text += "\n" + str1;
            MessageBox.Show(lb_outputMessage.Text);
        }

        // 🔑 Helper method to avoid repeating calculation
        private void UpdateTotal()
        {
            int unitPrice = 0;
            int.TryParse(tb_unitPrice.Text, out unitPrice);

            totalPrice = (int)numQty.Value * unitPrice;
            tb_total.Text = totalPrice.ToString();
        }
    }
}
