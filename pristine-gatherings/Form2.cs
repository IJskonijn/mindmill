using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PristineGatherings
{
    public partial class Form2 : Form
    {

        private String User;
        private String Pass;
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if(email.Contains(".")){
                    return addr.Address == email;
                }
                else
                {
                    return false;
                }
            }
            catch
            {
                return false;
            }
        }

        public Form2()
        {
            InitializeComponent();

            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0 && textBox2.TextLength > 0)
            {
                User = textBox1.Text;
                Pass = textBox2.Text;

                if (IsValidEmail(User))
                {
                    MessageBox.Show("henk = true");
                    this.Dispose();
                }
                else
                {
                    MessageBox.Show("Not a email adress.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            else
            {
                MessageBox.Show("You didn't fill in all the required values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
