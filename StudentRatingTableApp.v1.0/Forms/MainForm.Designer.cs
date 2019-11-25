namespace StudentRatingTableApp.v1._0
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.btn_admin_login = new System.Windows.Forms.Button();
            this.txbx_admin_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbx_admin_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label1.Location = new System.Drawing.Point(134, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(523, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tələbə Reytinq Cədvəli Avtomatlaşdırılmış İnformasiya Sistemi";
            // 
            // btn_admin_login
            // 
            this.btn_admin_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_login.Location = new System.Drawing.Point(679, 361);
            this.btn_admin_login.Name = "btn_admin_login";
            this.btn_admin_login.Size = new System.Drawing.Size(90, 32);
            this.btn_admin_login.TabIndex = 9;
            this.btn_admin_login.Text = "Daxil ol";
            this.btn_admin_login.UseVisualStyleBackColor = true;
            this.btn_admin_login.Click += new System.EventHandler(this.btn_admin_login_Click);
            // 
            // txbx_admin_password
            // 
            this.txbx_admin_password.Location = new System.Drawing.Point(616, 300);
            this.txbx_admin_password.Name = "txbx_admin_password";
            this.txbx_admin_password.Size = new System.Drawing.Size(153, 20);
            this.txbx_admin_password.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MintCream;
            this.label2.Location = new System.Drawing.Point(543, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Parol";
            // 
            // txbx_admin_username
            // 
            this.txbx_admin_username.Location = new System.Drawing.Point(616, 262);
            this.txbx_admin_username.Name = "txbx_admin_username";
            this.txbx_admin_username.Size = new System.Drawing.Size(153, 20);
            this.txbx_admin_username.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.MintCream;
            this.label3.Location = new System.Drawing.Point(492, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Username";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.BackgroundImage = global::StudentRatingTableApp.v1._0.Properties.Resources._2018_12_2414_38_06_5c20b69833588;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_admin_login);
            this.Controls.Add(this.txbx_admin_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbx_admin_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            //this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_admin_login;
        private System.Windows.Forms.TextBox txbx_admin_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbx_admin_username;
        private System.Windows.Forms.Label label3;
    }
}

