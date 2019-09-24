namespace StudentRatingTableApp.v1._0.Forms
{
    partial class RatingForUniversityForm
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
            this.cmbxSession = new System.Windows.Forms.ComboBox();
            this.dtgv_rating_all = new System.Windows.Forms.DataGridView();
            this.btn_back = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_rating_all)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "Semestri seç";
            // 
            // cmbxSession
            // 
            this.cmbxSession.FormattingEnabled = true;
            this.cmbxSession.Location = new System.Drawing.Point(119, 24);
            this.cmbxSession.Name = "cmbxSession";
            this.cmbxSession.Size = new System.Drawing.Size(129, 21);
            this.cmbxSession.TabIndex = 15;
            this.cmbxSession.SelectedIndexChanged += new System.EventHandler(this.cmbxSession_SelectedIndexChanged);
            // 
            // dtgv_rating_all
            // 
            this.dtgv_rating_all.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dtgv_rating_all.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgv_rating_all.Location = new System.Drawing.Point(1, 67);
            this.dtgv_rating_all.Name = "dtgv_rating_all";
            this.dtgv_rating_all.Size = new System.Drawing.Size(799, 389);
            this.dtgv_rating_all.TabIndex = 17;
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(699, 12);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 33);
            this.btn_back.TabIndex = 18;
            this.btn_back.Text = "Geriyə";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // RatingForUniversityForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.dtgv_rating_all);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxSession);
            this.Name = "RatingForUniversityForm";
            this.Text = "RatingForUniversityForm";
            this.Load += new System.EventHandler(this.RatingForUniversityForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgv_rating_all)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbxSession;
        private System.Windows.Forms.DataGridView dtgv_rating_all;
        private System.Windows.Forms.Button btn_back;
    }
}