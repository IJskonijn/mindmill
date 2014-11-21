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

        private void button1_Click(object sender, EventArgs e)
        {
            //authentication info
            Email = textBox1.Text;
            Pass = textBox2.Text;

            //profile info
            Fname = textBox3.Text;
            Lname = textBox4.Text;
            ProfilePic = pictureBox1.Image;

            if (Email.Length >= 5 && Pass.Length >= 5 && Fname.Length >= 1 && Lname.Length >= 1)
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
                        MessageBox.Show("This password does not contain a number", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
    }
}
