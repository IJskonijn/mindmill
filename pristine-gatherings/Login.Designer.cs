namespace PristineGatherings
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
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
            this.namebox = new System.Windows.Forms.TextBox();
            this.passbox = new System.Windows.Forms.TextBox();
            this.loginlabel = new System.Windows.Forms.Label();
            this.closebutton = new System.Windows.Forms.Button();
            this.namelabel = new System.Windows.Forms.Label();
            this.passlabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.registerbutton = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // namebox
            // 
            this.namebox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.namebox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.namebox.ForeColor = System.Drawing.Color.LightGray;
            this.namebox.Location = new System.Drawing.Point(40, 81);
            this.namebox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.namebox.Name = "namebox";
            this.namebox.Size = new System.Drawing.Size(133, 22);
            this.namebox.TabIndex = 2;
            this.namebox.Enter += new System.EventHandler(this.textBox1_Enter);
            this.namebox.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // passbox
            // 
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.passbox.ForeColor = System.Drawing.Color.LightGray;
            this.passbox.Location = new System.Drawing.Point(40, 133);
            this.passbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(133, 22);
            this.passbox.TabIndex = 3;
            this.passbox.Enter += new System.EventHandler(this.textBox2_Enter);
            this.passbox.Leave += new System.EventHandler(this.textBox2_Leave);
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.BackColor = System.Drawing.Color.Transparent;
            this.loginlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.loginlabel.ForeColor = System.Drawing.Color.White;
            this.loginlabel.Location = new System.Drawing.Point(80, 37);
            this.loginlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(70, 26);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "Login";
            // 
            // closebutton
            // 
            this.closebutton.BackColor = System.Drawing.Color.Transparent;
            this.closebutton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.closebutton.FlatAppearance.BorderSize = 0;
            this.closebutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.closebutton.ForeColor = System.Drawing.Color.White;
            this.closebutton.Location = new System.Drawing.Point(184, 2);
            this.closebutton.Name = "closebutton";
            this.closebutton.Size = new System.Drawing.Size(27, 33);
            this.closebutton.TabIndex = 1;
            this.closebutton.Text = "X";
            this.closebutton.UseVisualStyleBackColor = false;
            this.closebutton.Click += new System.EventHandler(this.button2_Click);
            this.closebutton.MouseEnter += new System.EventHandler(this.button2_MouseEnter);
            this.closebutton.MouseLeave += new System.EventHandler(this.button2_MouseLeave);
            // 
            // namelabel
            // 
            this.namelabel.BackColor = System.Drawing.Color.White;
            this.namelabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namelabel.ForeColor = System.Drawing.Color.White;
            this.namelabel.Location = new System.Drawing.Point(29, 72);
            this.namelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.namelabel.Name = "namelabel";
            this.namelabel.Size = new System.Drawing.Size(153, 42);
            this.namelabel.TabIndex = 2;
            this.namelabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // passlabel
            // 
            this.passlabel.BackColor = System.Drawing.Color.White;
            this.passlabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.passlabel.Location = new System.Drawing.Point(29, 124);
            this.passlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.passlabel.Name = "passlabel";
            this.passlabel.Size = new System.Drawing.Size(153, 41);
            this.passlabel.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(50, 171);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.MaximumSize = new System.Drawing.Size(112, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 179);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.MaximumSize = new System.Drawing.Size(12, 13);
            this.label5.MinimumSize = new System.Drawing.Size(12, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 10;
            // 
            // loginbutton
            // 
            this.loginbutton.BackgroundImage = global::PristineGatherings.Properties.Resources.smallbutton;
            this.loginbutton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.loginbutton.FlatAppearance.BorderSize = 0;
            this.loginbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.ForeColor = System.Drawing.Color.White;
            this.loginbutton.Location = new System.Drawing.Point(29, 208);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(153, 39);
            this.loginbutton.TabIndex = 4;
            this.loginbutton.Text = "LOGIN";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.button1_Click);
            this.loginbutton.MouseEnter += new System.EventHandler(this.button1_MouseEnter);
            this.loginbutton.MouseLeave += new System.EventHandler(this.button1_MouseLeave);
            // 
            // registerbutton
            // 
            this.registerbutton.AutoSize = true;
            this.registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.registerbutton.ForeColor = System.Drawing.Color.White;
            this.registerbutton.Location = new System.Drawing.Point(81, 256);
            this.registerbutton.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(61, 17);
            this.registerbutton.TabIndex = 11;
            this.registerbutton.Text = "Register";
            this.registerbutton.Click += new System.EventHandler(this.label6_Click);
            this.registerbutton.MouseEnter += new System.EventHandler(this.label6_MouseEnter);
            this.registerbutton.MouseLeave += new System.EventHandler(this.label6_MouseLeave);
            // 
            // Form2
            // 
            this.AcceptButton = this.loginbutton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.CancelButton = this.closebutton;
            this.ClientSize = new System.Drawing.Size(212, 280);
            this.Controls.Add(this.registerbutton);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.loginlabel);
            this.Controls.Add(this.passbox);
            this.Controls.Add(this.namebox);
            this.Controls.Add(this.closebutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.namelabel);
            this.Controls.Add(this.passlabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button closebutton;
        private System.Windows.Forms.TextBox namebox;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Label namelabel;
        private System.Windows.Forms.Label passlabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label registerbutton;

    }
}