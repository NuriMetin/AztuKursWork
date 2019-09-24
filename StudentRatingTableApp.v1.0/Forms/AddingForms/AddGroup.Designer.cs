namespace StudentRatingTableApp.v1._0.Forms.AddingForms
{
    partial class AddGroup
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
            this.label3 = new System.Windows.Forms.Label();
            this.cmbx_profession = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txbx_group_name = new System.Windows.Forms.TextBox();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_faculty = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbx_department = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(142, 231);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 20);
            this.label3.TabIndex = 23;
            this.label3.Text = "İxtisası seç";
            // 
            // cmbx_profession
            // 
            this.cmbx_profession.FormattingEnabled = true;
            this.cmbx_profession.Location = new System.Drawing.Point(271, 230);
            this.cmbx_profession.Name = "cmbx_profession";
            this.cmbx_profession.Size = new System.Drawing.Size(240, 21);
            this.cmbx_profession.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(640, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 21;
            this.label1.Text = "Qrup adı";
            // 
            // txbx_group_name
            // 
            this.txbx_group_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.txbx_group_name.Location = new System.Drawing.Point(619, 158);
            this.txbx_group_name.Multiline = true;
            this.txbx_group_name.Name = "txbx_group_name";
            this.txbx_group_name.Size = new System.Drawing.Size(117, 42);
            this.txbx_group_name.TabIndex = 20;
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(635, 217);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(87, 40);
            this.btn_add.TabIndex = 19;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(127, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fakultəni seç";
            // 
            // cmbx_faculty
            // 
            this.cmbx_faculty.FormattingEnabled = true;
            this.cmbx_faculty.Location = new System.Drawing.Point(271, 129);
            this.cmbx_faculty.Name = "cmbx_faculty";
            this.cmbx_faculty.Size = new System.Drawing.Size(240, 21);
            this.cmbx_faculty.TabIndex = 17;
            this.cmbx_faculty.SelectedIndexChanged += new System.EventHandler(this.cmbx_faculty_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(123, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 20);
            this.label4.TabIndex = 25;
            this.label4.Text = "Kafedranı seç";
            // 
            // cmbx_department
            // 
            this.cmbx_department.FormattingEnabled = true;
            this.cmbx_department.Location = new System.Drawing.Point(271, 179);
            this.cmbx_department.Name = "cmbx_department";
            this.cmbx_department.Size = new System.Drawing.Size(240, 21);
            this.cmbx_department.TabIndex = 24;
            this.cmbx_department.SelectedIndexChanged += new System.EventHandler(this.cmbx_department_SelectedIndexChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(894, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 42);
            this.btn_back.TabIndex = 26;
            this.btn_back.Text = "Geriyə";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // AddGroup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(994, 525);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbx_department);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbx_profession);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbx_group_name);
            this.Controls.Add(this.btn_add);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_faculty);
            this.Name = "AddGroup";
            this.Text = "AddGroup";
            this.Load += new System.EventHandler(this.AddGroup_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbx_profession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbx_group_name;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_faculty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbx_department;
        private System.Windows.Forms.Button btn_back;
    }
}