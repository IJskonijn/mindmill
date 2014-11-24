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
        private static string TxtBox1_InitialText = "E-mail";
        private static string TxtBox2_InitialText = "Password";
        private string user;
        private string pass;
        private Form1 Main;
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

        public Form2(Form1 main)
        {
            InitializeComponent();

            textBox1.Text = TxtBox1_InitialText;
            textBox2.Text = TxtBox2_InitialText;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.ShowIcon = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

            this.Main = main;

            this.ShowDialog();
        }

        private void Login() 
        {
            using (var db = new pristinedbEntities())
            {
                var query = from u in db.user
                            where u.email == this.user
                            orderby u.email
                            select u;

                List<PristineGatherings.user> results = query.ToList();
                if(results.Count == 1)
                {
                    if (BCrypt.Net.BCrypt.Verify(user, results[0].password))
                    {
                        Console.WriteLine("It works! U logged in!");
                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.TextLength > 0 && textBox2.TextLength > 0 && (textBox1.Text != TxtBox1_InitialText || textBox2.Text != TxtBox2_InitialText))
            {
                user = textBox1.Text;
                pass = textBox2.Text;

                if (IsValidEmail(user))
                {
                    Login();
                    MessageBox.Show("henk = true");
                    this.Dispose();
                }
                else
                {
                    //MessageBox.Show("Not a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label5.Image = Properties.Resources.iconerror;
                    label4.Text = "Not a valid email address";
                }
            }
            else
            {
                //MessageBox.Show("You didn't fill in all the required values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label5.Image = Properties.Resources.iconerror;
                label4.Text = "You didn't fill in all the required values";
            }         
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton_enter));
            this.button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitbuttonclick));
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitbuttonenter));
            this.button2.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = null;
            this.button2.BackColor = System.Drawing.Color.Transparent;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (textBox1.Text == TxtBox1_InitialText)
            {
                textBox1.Clear();
                textBox1.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == string.Empty)
            {
                textBox1.Text = TxtBox1_InitialText;
                textBox1.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (textBox2.Text == TxtBox2_InitialText)
            {
                textBox2.Clear();
                textBox2.PasswordChar = '*';
                textBox2.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (textBox2.Text == string.Empty)
            {
                textBox2.PasswordChar = '\0';
                textBox2.Text = TxtBox2_InitialText;
                textBox2.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {
            // DO something, registreren ofzo
            Main.ShowRegister();
            //this.Dispose();
        }

        private void label6_MouseEnter(object sender, EventArgs e)
        {
            this.label6.Cursor = Cursors.Hand;
            label6.BackColor = System.Drawing.Color.FromArgb(189, 235, 253);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            label6.BackColor = System.Drawing.Color.LightSkyBlue;
        }
    }
}
