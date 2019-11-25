namespace StudentRatingTableApp.v1._0.Forms.ReytingForms
{
    partial class StudentRatingForm
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
            this.cmbx_faculty = new System.Windows.Forms.ComboBox();
            this.cmbx_session = new System.Windows.Forms.ComboBox();
            this.cmbx_profession = new System.Windows.Forms.ComboBox();
            this.cmbx_group = new System.Windows.Forms.ComboBox();
            this.dtgv_student_rating = new System.Windows.Forms.DataGridView();
            this.Session = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student_rating)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbx_faculty
            // 
            this.cmbx_faculty.FormattingEnabled = true;
            this.cmbx_faculty.Location = new System.Drawing.Point(223, 68);
            this.cmbx_faculty.Name = "cmbx_faculty";
            this.cmbx_faculty.Size = new System.Drawing.Size(121, 21);
            this.cmbx_faculty.TabIndex = 0;
            this.cmbx_faculty.SelectedIndexChanged += new System.EventHandler(this.cmbx_faculty_SelectedIndexChanged);
            // 
            // cmbx_session
            // 
            this.cmbx_session.FormattingEnabled = true;
            this.cmbx_session.Location = new System.Drawing.Point(56, 68);
            this.cmbx_session.Name = "cmbx_session";
            this.cmbx_session.Size = new System.Drawing.Size(121, 21);
            this.cmbx_session.TabIndex = 1;
            // 
            // cmbx_profession
            // 
            this.cmbx_profession.FormattingEnabled = true;
            this.cmbx_profession.Location = new System.Drawing.Point(389, 68);
            this.cmbx_profession.Name = "cmbx_profession";
            this.cmbx_profession.Size = new System.Drawing.Size(121, 21);
            this.cmbx_profession.TabIndex = 2;
            this.cmbx_profession.SelectedIndexChanged += new System.EventHandler(this.cmbx_profession_SelectedIndexChanged);
            // 
            // cmbx_group
            // 
            this.cmbx_group.FormattingEnabled = true;
            this.cmbx_group.Location = new System.Drawing.Point(564, 68);
            this.cmbx_group.Name = "cmbx_group";
            this.cmbx_group.Size = new System.Drawing.Size(121, 21);
            this.cmbx_group.TabIndex = 3;
            this.cmbx_group.SelectedIndexChanged += new System.EventHandler(this.cmbx_group_SelectedIndexChanged);
            // 
            // dtgv_student_rating
            // 
            this.dtgv_student_rating.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv_student_rating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_student_rating.Location = new System.Drawing.Point(35, 137);
            this.dtgv_student_rating.Name = "dtgv_student_rating";
            this.dtgv_student_rating.Size = new System.Drawing.Size(916, 392);
            this.dtgv_student_rating.TabIndex = 4;
            // 
            // Session
            // 
            this.Session.AutoSize = true;
            this.Session.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.Session.Location = new System.Drawing.Point(66, 24);
            this.Session.Name = "Session";
            this.Session.Size = new System.Drawing.Size(77, 24);
            this.Session.TabIndex = 5;
            this.Session.Text = "Session";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label2.Location = new System.Drawing.Point(219, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 24);
            this.label2.TabIndex = 6;
            this.label2.Text = "Faculty";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label3.Location = new System.Drawing.Point(385, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 24);
            this.label3.TabIndex = 7;
            this.label3.Text = "Profession";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.label4.Location = new System.Drawing.Point(560, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 24);
            this.label4.TabIndex = 8;
            this.label4.Text = "Group";
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(855, 24);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 31);
            this.btn_back.TabIndex = 21;
            this.btn_back.Text = "Geriyə";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // StudentRatingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(963, 541);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Session);
            this.Controls.Add(this.dtgv_student_rating);
            this.Controls.Add(this.cmbx_group);
            this.Controls.Add(this.cmbx_profession);
            this.Controls.Add(this.cmbx_session);
            this.Controls.Add(this.cmbx_faculty);
            this.Name = "StudentRatingForm";
            this.Text = "StudentRatingForm";
            this.Load += new System.EventHandler(this.StudentRatingForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student_rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_faculty;
        private System.Windows.Forms.ComboBox cmbx_session;
        private System.Windows.Forms.ComboBox cmbx_profession;
        private System.Windows.Forms.ComboBox cmbx_group;
        private System.Windows.Forms.DataGridView dtgv_student_rating;
        private System.Windows.Forms.Label Session;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_back;
    }
}