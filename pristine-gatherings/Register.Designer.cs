namespace PristineGatherings
{
    partial class Register
    {
        /// <summary>
        /// Required designer variable..
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Emailbox = new System.Windows.Forms.TextBox();
            this.Passbox = new System.Windows.Forms.TextBox();
            this.Firstnamebox = new System.Windows.Forms.TextBox();
            this.Lastnamebox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.firstnamelabel = new System.Windows.Forms.Label();
            this.lastnamelabel = new System.Windows.Forms.Label();
            this.Regbutton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Emailbox
            // 
            this.Emailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Emailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Emailbox.ForeColor = System.Drawing.Color.LightGray;
            this.Emailbox.Location = new System.Drawing.Point(40, 89);
            this.Emailbox.Name = "Emailbox";
            this.Emailbox.Size = new System.Drawing.Size(133, 22);
            this.Emailbox.TabIndex = 2;
            this.Emailbox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.Emailbox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // Passbox
            // 
            this.Passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Passbox.ForeColor = System.Drawing.Color.LightGray;
            this.Passbox.Location = new System.Drawing.Point(40, 139);
            this.Passbox.Name = "Passbox";
            this.Passbox.Size = new System.Drawing.Size(133, 22);
            this.Passbox.TabIndex = 3;
            this.Passbox.Enter += new System.EventHandler(this.textBox2_Enter);
            this.Passbox.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // Firstnamebox
            // 
            this.Firstnamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Firstnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Firstnamebox.ForeColor = System.Drawing.Color.LightGray;
            this.Firstnamebox.Location = new System.Drawing.Point(40, 189);
            this.Firstnamebox.Name = "Firstnamebox";
            this.Firstnamebox.Size = new System.Drawing.Size(133, 22);
            this.Firstnamebox.TabIndex = 4;
            this.Firstnamebox.Enter += new System.EventHandler(this.textBox3_Enter);
            this.Firstnamebox.Leave += new System.EventHandler(this.textBox3_Leave);
            // 
            // Lastnamebox
            // 
            this.Lastnamebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Lastnamebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Lastnamebox.ForeColor = System.Drawing.Color.LightGray;
            this.Lastnamebox.Location = new System.Drawing.Point(40, 239);
            this.Lastnamebox.Name = "Lastnamebox";
            this.Lastnamebox.Size = new System.Drawing.Size(133, 22);
            this.Lastnamebox.TabIndex = 5;
            this.Lastnamebox.Enter += new System.EventHandler(this.textBox4_Enter);
            this.Lastnamebox.Leave += new System.EventHandler(this.textBox4_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(69, 278);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Profile picture";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Location = new System.Drawing.Point(184, 3);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(27, 33);
            this.closebutton.TabIndex = 0;
            this.closebutton.Text = "X";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.button2_Click);
            this.closebutton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.closebutton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Photo Files|*.jpg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(70, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 26);
            this.label3.TabIndex = 1;
            this.label3.Text = "Register";
            // 
            // emaillabel
            // 
            this.emaillabel.BackColor = System.Drawing.Color.White;
            this.emaillabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.emaillabel.ForeColor = System.Drawing.Color.White;
            this.emaillabel.Location = new System.Drawing.Point(30, 80);
            this.emaillabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(153, 42);
            this.emaillabel.TabIndex = 11;
            this.emaillabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passlabel
            // 
            this.passlabel.BackColor = System.Drawing.Color.White;
            this.passlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passlabel.ForeColor = System.Drawing.Color.White;
            this.passlabel.Location = new System.Drawing.Point(30, 130);
            this.passlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(153, 42);
            this.passlabel.TabIndex = 12;
            this.passlabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // firstnamelabel
            // 
            this.firstnamelabel.BackColor = System.Drawing.Color.White;
            this.firstnamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.firstnamelabel.ForeColor = System.Drawing.Color.White;
            this.firstnamelabel.Location = new System.Drawing.Point(30, 180);
            this.firstnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.firstnamelabel.Name = "firstnamelabel";
            this.firstnamelabel.Size = new System.Drawing.Size(153, 42);
            this.firstnamelabel.TabIndex = 13;
            this.firstnamelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lastnamelabel
            // 
            this.lastnamelabel.BackColor = System.Drawing.Color.White;
            this.lastnamelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lastnamelabel.ForeColor = System.Drawing.Color.White;
            this.lastnamelabel.Location = new System.Drawing.Point(30, 229);
            this.lastnamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lastnamelabel.Name = "lastnamelabel";
            this.lastnamelabel.Size = new System.Drawing.Size(153, 42);
            this.lastnamelabel.TabIndex = 14;
            this.lastnamelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Regbutton
            // 
            this.Regbutton.BackgroundImage = global::PristineGatherings.Properties.Resources.smallbutton2;
            this.Regbutton.FlatAppearance.BorderSize = 0;
            this.Regbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Regbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regbutton.ForeColor = System.Drawing.Color.White;
            this.Regbutton.Location = new System.Drawing.Point(30, 418);
            this.Regbutton.Name = "Regbutton";
            this.Regbutton.Size = new System.Drawing.Size(153, 39);
            this.Regbutton.TabIndex = 7;
            this.Regbutton.Text = "REGISTER";
            this.Regbutton.UseVisualStyleBackColor = true;
            this.Regbutton.Click += new System.EventHandler(this.button1_Click);
            this.Regbutton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.Regbutton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(67, 298);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(85, 77);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(30, 392);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.MaximumSize = new System.Drawing.Size(12, 13);
            this.label7.MinimumSize = new System.Drawing.Size(12, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(12, 13);
            this.label7.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(53, 384);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.MaximumSize = new System.Drawing.Size(112, 28);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 16;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.NavajoWhite;
            this.ClientSize = new System.Drawing.Size(214, 478);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.Regbutton);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Lastnamebox);
            this.Controls.Add(this.Firstnamebox);
            this.Controls.Add(this.Passbox);
            this.Controls.Add(this.Emailbox);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.passlabel);
            this.Controls.Add(this.firstnamelabel);
            this.Controls.Add(this.lastnamelabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Emailbox;
        private System.Windows.Forms.TextBox Passbox;
        private System.Windows.Forms.TextBox Firstnamebox;
        private System.Windows.Forms.TextBox Lastnamebox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Regbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label firstnamelabel;
        private System.Windows.Forms.Label lastnamelabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}