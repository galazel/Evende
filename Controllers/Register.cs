using Evende.Model;
using Evende.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evende.Controllers
{
    public partial class Register : UserControl
    {
        private CustomerService service = new CustomerService();
        public Register()
        {
            InitializeComponent();
        }
        private void back_register_label_LinkClicked(object sender, EventArgs e)
        {
            LandingPageStates.panelName = "back";
            ((LandingPage)this.ParentForm).SetSplitPanel();
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            CustomerModel customerModel = new CustomerModel();
            customerModel.FirstName = firstName_textBox.Text;
            customerModel.LastName = lastName_textBox.Text;
            customerModel.CustomerAddress = customerAdd_textBox.Text;
            customerModel.ContactNumber = contactNum_textBox.Text;
            customerModel.PasswordHash = HashPassword(password_textBox.Text);
            customerModel.Email = email_textBox.Text;
            service.AddCustomer(customerModel);
            ClearBox();


        }
        public void ClearBox()
        {
            firstName_textBox.Text = string.Empty;
            lastName_textBox.Text = string.Empty;
            customerAdd_textBox.Text = string.Empty;
            contactNum_textBox.Text = string.Empty;
            password_textBox.Text = string.Empty;
            email_textBox.Text = string.Empty;
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha = SHA256.Create())
            {
                byte[] bytes = sha.ComputeHash(Encoding.UTF8.GetBytes(password));
                StringBuilder sb = new StringBuilder();
                foreach (byte b in bytes)
                    sb.Append(b.ToString("x2"));
                return sb.ToString();
            }
        }

    }
}
