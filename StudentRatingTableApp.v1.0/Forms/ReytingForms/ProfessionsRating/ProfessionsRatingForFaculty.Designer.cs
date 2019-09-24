namespace StudentRatingTableApp.v1._0.Forms.ReytingForms.ProfessionsRating
{
    partial class ProfessionsRatingForFaculty
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
            this.dtgv_student_rating = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_faculty = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbx_session = new System.Windows.Forms.ComboBox();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student_rating)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgv_student_rating
            // 
            this.dtgv_student_rating.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv_student_rating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_student_rating.Location = new System.Drawing.Point(40, 110);
            this.dtgv_student_rating.Name = "dtgv_student_rating";
            this.dtgv_student_rating.Size = new System.Drawing.Size(946, 383);
            this.dtgv_student_rating.TabIndex = 41;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(339, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 40;
            this.label2.Text = "Fakultəni seç";
            // 
            // cmbx_faculty
            // 
            this.cmbx_faculty.FormattingEnabled = true;
            this.cmbx_faculty.Location = new System.Drawing.Point(453, 65);
            this.cmbx_faculty.Name = "cmbx_faculty";
            this.cmbx_faculty.Size = new System.Drawing.Size(161, 21);
            this.cmbx_faculty.TabIndex = 39;
            this.cmbx_faculty.SelectedIndexChanged += new System.EventHandler(this.cmbx_faculty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(54, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 38;
            this.label1.Text = "Sessiyanı seç";
            // 
            // cmbx_session
            // 
            this.cmbx_session.FormattingEnabled = true;
            this.cmbx_session.Location = new System.Drawing.Point(173, 65);
            this.cmbx_session.Name = "cmbx_session";
            this.cmbx_session.Size = new System.Drawing.Size(145, 21);
            this.cmbx_session.TabIndex = 37;
            // 
            // btn_back
            // 
            this.btn_back.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.btn_back.Location = new System.Drawing.Point(866, 44);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(90, 39);
            this.btn_back.TabIndex = 42;
            this.btn_back.Text = "Geriyə";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click_1);
            // 
            // ProfessionsRatingForFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1027, 523);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dtgv_student_rating);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_faculty);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbx_session);
            this.Name = "ProfessionsRatingForFaculty";
            this.Text = "ProfessionsRatingForFaculty";
            this.Load += new System.EventHandler(this.ProfessionsRatingForFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_student_rating)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dtgv_student_rating;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_faculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbx_session;
        private System.Windows.Forms.Button btn_back;
    }
}