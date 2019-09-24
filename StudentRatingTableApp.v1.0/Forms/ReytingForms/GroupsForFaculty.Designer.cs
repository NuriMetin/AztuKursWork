namespace StudentRatingTableApp.v1._0.Forms.ReytingForms
{
    partial class GroupsForFaculty
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
            this.label1 = new System.Windows.Forms.Label();
            this.dtgv_groups = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbx_session = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_groups)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbx_faculty
            // 
            this.cmbx_faculty.DisplayMember = "ID";
            this.cmbx_faculty.FormattingEnabled = true;
            this.cmbx_faculty.Location = new System.Drawing.Point(405, 86);
            this.cmbx_faculty.Name = "cmbx_faculty";
            this.cmbx_faculty.Size = new System.Drawing.Size(185, 21);
            this.cmbx_faculty.TabIndex = 21;
            this.cmbx_faculty.ValueMember = "ID";
            this.cmbx_faculty.SelectedIndexChanged += new System.EventHandler(this.cmbx_faculty_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label1.Location = new System.Drawing.Point(291, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 20;
            this.label1.Text = "Fakultəni seç";
            // 
            // dtgv_groups
            // 
            this.dtgv_groups.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv_groups.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_groups.Location = new System.Drawing.Point(13, 134);
            this.dtgv_groups.Name = "dtgv_groups";
            this.dtgv_groups.Size = new System.Drawing.Size(931, 374);
            this.dtgv_groups.TabIndex = 22;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(839, 39);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 40);
            this.btn_back.TabIndex = 23;
            this.btn_back.Text = "Geriyə";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.label2.Location = new System.Drawing.Point(12, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 25;
            this.label2.Text = "Semestri seç";
            // 
            // cmbx_session
            // 
            this.cmbx_session.FormattingEnabled = true;
            this.cmbx_session.Location = new System.Drawing.Point(126, 88);
            this.cmbx_session.Name = "cmbx_session";
            this.cmbx_session.Size = new System.Drawing.Size(115, 21);
            this.cmbx_session.TabIndex = 24;
            this.cmbx_session.SelectedIndexChanged += new System.EventHandler(this.Cmbx_session_SelectedIndexChanged);
            // 
            // GroupsForFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(956, 520);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbx_session);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dtgv_groups);
            this.Controls.Add(this.cmbx_faculty);
            this.Controls.Add(this.label1);
            this.Name = "GroupsForFaculty";
            this.Text = "GroupsForFaculty";
            this.Load += new System.EventHandler(this.GroupsForFaculty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_groups)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbx_faculty;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dtgv_groups;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbx_session;
    }
}