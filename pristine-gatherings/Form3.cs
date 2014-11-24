using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace PristineGatherings
{
    public partial class Form3 : Form
    {
        private static string TxtBox1_InitialText = "E-mail";
        private static string TxtBox2_InitialText = "Password";
        private static string TxtBox3_InitialText = "First Name";
        private static string TxtBox4_InitialText = "Last Name";
        private String Email, Pass, Fname, Lname;
        private Image ProfilePic;
        private Form1 Main;
        bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                if (email.Contains("."))
                {
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

        public Form3()
        {
            InitializeComponent();

            textBox1.Text = TxtBox1_InitialText;
            textBox2.Text = TxtBox2_InitialText;
            textBox3.Text = TxtBox3_InitialText;
            textBox4.Text = TxtBox4_InitialText;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.ShowDialog();
        }

        public void RegNewUser()
        {
            using (var db = new pristinedbEntities())
            {
                var user = new user { email = Email, voornaam = Fname, achternaam = Lname, password = BCrypt.Net.BCrypt.HashPassword(Pass, 13) };
                db.user.Add(user);
                db.SaveChanges();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitbuttonenter2));
            this.button2.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.button2.BackgroundImage = null;
            this.button2.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //authentication info
            Email = textBox1.Text;
            Pass = textBox2.Text;

            //profile info
            Fname = textBox3.Text;
            Lname = textBox4.Text;
            ProfilePic = pictureBox1.Image;

            if (Email.Length >= 5 && Pass.Length >= 5 && Fname.Length >= 1 && Lname.Length >= 1 &&
                (textBox1.Text != TxtBox1_InitialText || textBox2.Text != TxtBox2_InitialText || textBox4.Text != TxtBox4_InitialText || textBox4.Text != TxtBox4_InitialText))
            {
                if (IsValidEmail(Email))
                {
                    if (Pass.Any(c => char.IsDigit(c)))
                    {
                        RegNewUser();
                        MessageBox.Show("henk = true");
                        this.Dispose();
                    }
                    else
                    {
                        //MessageBox.Show("This password does not contain a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label7.Image = Properties.Resources.iconerror;
                        label8.Text = "This password does not contain a number";
                    }
                }
                else
                {
                    //MessageBox.Show("Not a valid email address.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    label7.Image = Properties.Resources.iconerror;
                    label8.Text = "Not a valid email address";
                }

                
            }
            else
            {
                //MessageBox.Show("You didn't fill in all the required values.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label7.Image = Properties.Resources.iconerror;
                label8.Text = "You didn't fill in all the required values";
            }
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton2_enter));
            this.button1.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.button1.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton2));
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

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == TxtBox3_InitialText)
            {
                textBox3.Clear();
                textBox3.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (textBox3.Text == string.Empty)
            {
                textBox3.Text = TxtBox3_InitialText;
                textBox3.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (textBox4.Text == TxtBox4_InitialText)
            {
                textBox4.Clear();
                textBox4.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (textBox4.Text == string.Empty)
            {
                textBox4.Text = TxtBox4_InitialText;
                textBox4.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "";
            string upload = Application.StartupPath + @"\Upload\";

            if (!Directory.Exists(upload)) 
            { 
                Directory.CreateDirectory(upload); 
            }

            if (openFileDialog1.ShowDialog() == DialogResult.OK) 
            {
                var fileName = openFileDialog1.FileName;
                System.IO.File.Copy(fileName, Path.Combine(Path.GetDirectoryName(fileName), upload + "profile.jpg"), true);
                pictureBox1.ImageLocation = upload + "profile.jpg";
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
