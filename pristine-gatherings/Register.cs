using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;

namespace PristineGatherings
{
    public partial class Register : Form
    {
        private static string TxtBox1_InitialText = "E-mail";
        private static string TxtBox2_InitialText = "Password";
        private static string TxtBox3_InitialText = "First Name";
        private static string TxtBox4_InitialText = "Last Name";
        private String Email, Pass, Fname, Lname;
        private Image ProfilePic;
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

        public Register()
        {
            InitializeComponent();

            Emailbox.Text = TxtBox1_InitialText;
            Passbox.Text = TxtBox2_InitialText;
            Firstnamebox.Text = TxtBox3_InitialText;
            Lastnamebox.Text = TxtBox4_InitialText;
            this.MinimizeBox = false;
            this.MaximizeBox = false;
            //this.ControlBox = false;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;

            this.ShowDialog();
        }

        public void RegNewUser(String email, String password, String firstname, String lastname)
        {
            using (var db = new pristinedbEntities())
            {
                var user = new user { email = email, voornaam = firstname, achternaam = lastname, password = BCrypt.Net.BCrypt.HashPassword(password, 13) };
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
            this.closebutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.exitbuttonenter2));
            this.closebutton.Cursor = Cursors.Hand;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            this.closebutton.BackgroundImage = null;
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //authentication info
            Email = Emailbox.Text;
            Pass = Passbox.Text;

            //profile info
            Fname = Firstnamebox.Text;
            Lname = Lastnamebox.Text;
            ProfilePic = pictureBox1.Image;

            if (Email.Length >= 5 && Pass.Length >= 5 && Fname.Length >= 1 && Lname.Length >= 1 &&
                (Emailbox.Text != TxtBox1_InitialText || Passbox.Text != TxtBox2_InitialText || Lastnamebox.Text != TxtBox4_InitialText || Lastnamebox.Text != TxtBox4_InitialText))
            {
                if (IsValidEmail(Email))
                {
                    if (Pass.Any(c => char.IsDigit(c)))
                    {
                        RegNewUser(Email, Pass, Fname, Lname);
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
            this.Regbutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton2_enter));
            this.Regbutton.Cursor = Cursors.Hand;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            this.Regbutton.BackgroundImage = ((System.Drawing.Image)(Properties.Resources.smallbutton2));
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if (Emailbox.Text == TxtBox1_InitialText)
            {
                Emailbox.Clear();
                Emailbox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (Emailbox.Text == string.Empty)
            {
                Emailbox.Text = TxtBox1_InitialText;
                Emailbox.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            if (Passbox.Text == TxtBox2_InitialText)
            {
                Passbox.Clear();
                Passbox.PasswordChar = '*';
                Passbox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            if (Passbox.Text == string.Empty)
            {
                Passbox.PasswordChar = '\0';
                Passbox.Text = TxtBox2_InitialText;
                Passbox.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (Firstnamebox.Text == TxtBox3_InitialText)
            {
                Firstnamebox.Clear();
                Firstnamebox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            if (Firstnamebox.Text == string.Empty)
            {
                Firstnamebox.Text = TxtBox3_InitialText;
                Firstnamebox.ForeColor = System.Drawing.Color.LightGray;
            }
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            if (Lastnamebox.Text == TxtBox4_InitialText)
            {
                Lastnamebox.Clear();
                Lastnamebox.ForeColor = System.Drawing.Color.Black;
            }

        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            if (Lastnamebox.Text == string.Empty)
            {
                Lastnamebox.Text = TxtBox4_InitialText;
                Lastnamebox.ForeColor = System.Drawing.Color.LightGray;
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
                Email = Emailbox.Text;

                if (Email.Length > 5 && IsValidEmail(Email))
                {
                    var fileName = openFileDialog1.FileName;
                    System.IO.File.Copy(fileName, Path.Combine(Path.GetDirectoryName(fileName), upload + Email + ".jpg"), true);
                    pictureBox1.ImageLocation = upload + Email + ".jpg";
                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
                else
                {
                    MessageBox.Show("Please fill in an email address first", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
