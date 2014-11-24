using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PristineGatherings
{
    public partial class Login : Form
    {
        private static string TxtBox1_InitialText = "E-mail";
        private static string TxtBox2_InitialText = "Password";
        private string user, pass;
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

        public Login(Form1 main)
        {
            InitializeComponent();

            namebox.Text = TxtBox1_InitialText;
            passbox.Text = TxtBox2_InitialText;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.ShowIcon = false;
            //this.FormBorderStyle = FormBorderStyle.None;
            this.ShowInTaskbar = false;

            this.Main = main;

            this.ShowDialog();
        }

        private void FuncLogin(String username, String password) 
        {
            using (var db = new pristinedbEntities())
            {
                var query = from u in db.user
                            where u.email == username
                            orderby u.email
                            select u;

                List<PristineGatherings.user> results = query.ToList();
                if(results.Count == 1)
                {
                    if (BCrypt.Net.BCrypt.Verify(password, results[0].password))
                    {
                        Console.WriteLine("It works! U logged in!");
                    }
                }
            } 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(namebox.TextLength > 0 && passbox.TextLength > 0 && (namebox.Text != TxtBox1_InitialText || passbox.Text != TxtBox2_InitialText))
            {
                user = namebox.Text;
                pass = passbox.Text;

                if (IsValidEmail(user))
                {
                    FuncLogin(user, pass);
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
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton_enter));
            this.loginbutton.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.loginbutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitbuttonclick));
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitbuttonenter));
            this.closebutton.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.closebutton.BackgroundImage = null;
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (namebox.Text == TxtBox1_InitialText)
            {
                namebox.Clear();
                namebox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (namebox.Text == string.Empty)
            {
                namebox.Text = TxtBox1_InitialText;
                namebox.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (passbox.Text == TxtBox2_InitialText)
            {
                passbox.Clear();
                passbox.PasswordChar = '*';
                passbox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (passbox.Text == string.Empty)
            {
                passbox.PasswordChar = '\0';
                passbox.Text = TxtBox2_InitialText;
                passbox.ForeColor = System.Drawing.Color.LightGray;
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
            this.registerbutton.Cursor = Cursors.Hand;
            registerbutton.BackColor = System.Drawing.Color.FromArgb(189, 235, 253);
        }

        private void label6_MouseLeave(object sender, EventArgs e)
        {
            registerbutton.BackColor = System.Drawing.Color.LightSkyBlue;
        }
    }
}
