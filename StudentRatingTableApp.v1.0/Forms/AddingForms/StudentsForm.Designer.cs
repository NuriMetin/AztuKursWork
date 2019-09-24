namespace StudentRatingTableApp.v1._0.Forms.AddingForms
{
    partial class StudentsForm
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
            this.lsbx_students = new System.Windows.Forms.ListBox();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_group = new System.Windows.Forms.ComboBox();
            this.cmbx_profession = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.grbx_subjects = new System.Windows.Forms.GroupBox();
            this.lbl_get_name = new System.Windows.Forms.Label();
            this.btn_pount_add = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txbx_exam_pount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txbx_enter_pount = new System.Windows.Forms.TextBox();
            this.cmbx_subject = new System.Windows.Forms.ComboBox();
            this.cmbx_session = new System.Windows.Forms.ComboBox();
            this.lbl_student_name = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbx_faculty = new System.Windows.Forms.ComboBox();
            this.grbx_subjects.SuspendLayout();
            this.SuspendLayout();
            // 
            // lsbx_students
            // 
            this.lsbx_students.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lsbx_students.FormattingEnabled = true;
            this.lsbx_students.ItemHeight = 20;
            this.lsbx_students.Location = new System.Drawing.Point(13, 111);
            this.lsbx_students.Name = "lsbx_students";
            this.lsbx_students.Size = new System.Drawing.Size(531, 404);
            this.lsbx_students.TabIndex = 26;
            this.lsbx_students.SelectedIndexChanged += new System.EventHandler(this.lsbx_students_SelectedIndexChanged);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(857, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 32);
            this.btn_back.TabIndex = 25;
            this.btn_back.Text = "Geriyə";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(409, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Qrupu seç";
            // 
            // cmbx_group
            // 
            this.cmbx_group.DisplayMember = "ID";
            this.cmbx_group.FormattingEnabled = true;
            this.cmbx_group.Location = new System.Drawing.Point(412, 54);
            this.cmbx_group.Name = "cmbx_group";
            this.cmbx_group.Size = new System.Drawing.Size(127, 21);
            this.cmbx_group.TabIndex = 20;
            this.cmbx_group.ValueMember = "ID";
            this.cmbx_group.SelectedIndexChanged += new System.EventHandler(this.cmbx_group_SelectedIndexChanged);
            // 
            // cmbx_profession
            // 
            this.cmbx_profession.DisplayMember = "ID";
            this.cmbx_profession.FormattingEnabled = true;
            this.cmbx_profession.Location = new System.Drawing.Point(200, 55);
            this.cmbx_profession.Name = "cmbx_profession";
            this.cmbx_profession.Size = new System.Drawing.Size(185, 21);
            this.cmbx_profession.TabIndex = 19;
            this.cmbx_profession.ValueMember = "ID";
            this.cmbx_profession.SelectedIndexChanged += new System.EventHandler(this.cmbx_profession_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(199, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "İxtisası seç";
            // 
            // grbx_subjects
            // 
            this.grbx_subjects.BackColor = System.Drawing.Color.Gainsboro;
            this.grbx_subjects.Controls.Add(this.lbl_get_name);
            this.grbx_subjects.Controls.Add(this.btn_pount_add);
            this.grbx_subjects.Controls.Add(this.label4);
            this.grbx_subjects.Controls.Add(this.label3);
            this.grbx_subjects.Controls.Add(this.label6);
            this.grbx_subjects.Controls.Add(this.txbx_exam_pount);
            this.grbx_subjects.Controls.Add(this.label5);
            this.grbx_subjects.Controls.Add(this.txbx_enter_pount);
            this.grbx_subjects.Controls.Add(this.cmbx_subject);
            this.grbx_subjects.Controls.Add(this.cmbx_session);
            this.grbx_subjects.Controls.Add(this.lbl_student_name);
            this.grbx_subjects.Location = new System.Drawing.Point(550, 50);
            this.grbx_subjects.Name = "grbx_subjects";
            this.grbx_subjects.Size = new System.Drawing.Size(399, 465);
            this.grbx_subjects.TabIndex = 27;
            this.grbx_subjects.TabStop = false;
            this.grbx_subjects.Text = "Fənlər";
            this.grbx_subjects.Visible = false;
            // 
            // lbl_get_name
            // 
            this.lbl_get_name.AutoSize = true;
            this.lbl_get_name.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_get_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.lbl_get_name.Location = new System.Drawing.Point(136, 40);
            this.lbl_get_name.Name = "lbl_get_name";
            this.lbl_get_name.Size = new System.Drawing.Size(0, 20);
            this.lbl_get_name.TabIndex = 31;
            // 
            // btn_pount_add
            // 
            this.btn_pount_add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pount_add.Location = new System.Drawing.Point(151, 396);
            this.btn_pount_add.Name = "btn_pount_add";
            this.btn_pount_add.Size = new System.Drawing.Size(106, 40);
            this.btn_pount_add.TabIndex = 30;
            this.btn_pount_add.Text = "Daxil et";
            this.btn_pount_add.UseVisualStyleBackColor = true;
            this.btn_pount_add.Click += new System.EventHandler(this.btn_pount_add_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label4.Location = new System.Drawing.Point(190, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 20);
            this.label4.TabIndex = 29;
            this.label4.Text = "Fənni seç";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label3.Location = new System.Drawing.Point(25, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 20);
            this.label3.TabIndex = 28;
            this.label3.Text = "Semestri seç";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label6.Location = new System.Drawing.Point(217, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "İmtahan balı";
            // 
            // txbx_exam_pount
            // 
            this.txbx_exam_pount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txbx_exam_pount.Location = new System.Drawing.Point(221, 315);
            this.txbx_exam_pount.Multiline = true;
            this.txbx_exam_pount.Name = "txbx_exam_pount";
            this.txbx_exam_pount.Size = new System.Drawing.Size(135, 34);
            this.txbx_exam_pount.TabIndex = 26;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label5.Location = new System.Drawing.Point(25, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 25;
            this.label5.Text = "Giriş balı";
            // 
            // txbx_enter_pount
            // 
            this.txbx_enter_pount.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.txbx_enter_pount.Location = new System.Drawing.Point(29, 315);
            this.txbx_enter_pount.Multiline = true;
            this.txbx_enter_pount.Name = "txbx_enter_pount";
            this.txbx_enter_pount.Size = new System.Drawing.Size(118, 34);
            this.txbx_enter_pount.TabIndex = 24;
            // 
            // cmbx_subject
            // 
            this.cmbx_subject.DisplayMember = "ID";
            this.cmbx_subject.FormattingEnabled = true;
            this.cmbx_subject.Location = new System.Drawing.Point(194, 185);
            this.cmbx_subject.Name = "cmbx_subject";
            this.cmbx_subject.Size = new System.Drawing.Size(176, 21);
            this.cmbx_subject.TabIndex = 23;
            this.cmbx_subject.ValueMember = "ID";
            this.cmbx_subject.SelectedIndexChanged += new System.EventHandler(this.cmbx_subject_SelectedIndexChanged);
            // 
            // cmbx_session
            // 
            this.cmbx_session.DisplayMember = "ID";
            this.cmbx_session.FormattingEnabled = true;
            this.cmbx_session.Location = new System.Drawing.Point(29, 185);
            this.cmbx_session.Name = "cmbx_session";
            this.cmbx_session.Size = new System.Drawing.Size(115, 21);
            this.cmbx_session.TabIndex = 21;
            this.cmbx_session.ValueMember = "ID";
            this.cmbx_session.SelectedIndexChanged += new System.EventHandler(this.cmbx_session_SelectedIndexChanged);
            // 
            // lbl_student_name
            // 
            this.lbl_student_name.AutoSize = true;
            this.lbl_student_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
            this.lbl_student_name.Location = new System.Drawing.Point(88, 41);
            this.lbl_student_name.Name = "lbl_student_name";
            this.lbl_student_name.Size = new System.Drawing.Size(0, 25);
            this.lbl_student_name.TabIndex = 0;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(108, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fakultəni seç";
            // 
            // cmbx_faculty
            // 
            this.cmbx_faculty.FormattingEnabled = true;
            this.cmbx_faculty.Location = new System.Drawing.Point(13, 55);
            this.cmbx_faculty.Name = "cmbx_faculty";
            this.cmbx_faculty.Size = new System.Drawing.Size(160, 21);
            this.cmbx_faculty.TabIndex = 28;
            this.cmbx_faculty.SelectedIndexChanged += new System.EventHandler(this.cmbx_faculty_SelectedIndexChanged);
            // 
            // StudentsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(961, 521);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cmbx_faculty);
            this.Controls.Add(this.grbx_subjects);
            this.Controls.Add(this.lsbx_students);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_group);
            this.Controls.Add(this.cmbx_profession);
            this.Controls.Add(this.label1);
            this.Name = "StudentsForm";
            this.Text = "Tələbə";
            this.Load += new System.EventHandler(this.AddPountForm_Load);
            this.grbx_subjects.ResumeLayout(false);
            this.grbx_subjects.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsbx_students;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_group;
        private System.Windows.Forms.ComboBox cmbx_profession;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox grbx_subjects;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txbx_exam_pount;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txbx_enter_pount;
        private System.Windows.Forms.ComboBox cmbx_subject;
        private System.Windows.Forms.ComboBox cmbx_session;
        private System.Windows.Forms.Label lbl_student_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_pount_add;
        private System.Windows.Forms.Label lbl_get_name;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbx_faculty;
    }
}