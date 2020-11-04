namespace Dynamic_Media_List
{
    partial class formMediaList
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
            this.btnMovie = new System.Windows.Forms.RadioButton();
            this.btnShow = new System.Windows.Forms.RadioButton();
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.lblYear = new System.Windows.Forms.Label();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.lblDuration = new System.Windows.Forms.Label();
            this.txtEpisodes = new System.Windows.Forms.TextBox();
            this.lblEpisodes = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnErase = new System.Windows.Forms.Button();
            this.btnEmpty = new System.Windows.Forms.Button();
            this.lstTitles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnMovie
            // 
            this.btnMovie.AutoSize = true;
            this.btnMovie.Location = new System.Drawing.Point(13, 12);
            this.btnMovie.Name = "btnMovie";
            this.btnMovie.Size = new System.Drawing.Size(54, 17);
            this.btnMovie.TabIndex = 0;
            this.btnMovie.TabStop = true;
            this.btnMovie.Text = "Movie";
            this.btnMovie.UseVisualStyleBackColor = true;
            this.btnMovie.CheckedChanged += new System.EventHandler(this.btnMovie_CheckedChanged);
            // 
            // btnShow
            // 
            this.btnShow.AutoSize = true;
            this.btnShow.Location = new System.Drawing.Point(65, 12);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(69, 17);
            this.btnShow.TabIndex = 1;
            this.btnShow.TabStop = true;
            this.btnShow.Text = "TV Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.CheckedChanged += new System.EventHandler(this.btnShow_CheckedChanged);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(9, 41);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(27, 13);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Title";
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(64, 38);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(150, 20);
            this.txtTitle.TabIndex = 3;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(64, 64);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(150, 20);
            this.txtYear.TabIndex = 5;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Location = new System.Drawing.Point(9, 67);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(29, 13);
            this.lblYear.TabIndex = 4;
            this.lblYear.Text = "Year";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(64, 90);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(150, 20);
            this.txtDuration.TabIndex = 7;
            // 
            // lblDuration
            // 
            this.lblDuration.AutoSize = true;
            this.lblDuration.Location = new System.Drawing.Point(9, 93);
            this.lblDuration.Name = "lblDuration";
            this.lblDuration.Size = new System.Drawing.Size(47, 13);
            this.lblDuration.TabIndex = 6;
            this.lblDuration.Text = "Duration";
            // 
            // txtEpisodes
            // 
            this.txtEpisodes.Location = new System.Drawing.Point(64, 116);
            this.txtEpisodes.Name = "txtEpisodes";
            this.txtEpisodes.Size = new System.Drawing.Size(150, 20);
            this.txtEpisodes.TabIndex = 9;
            // 
            // lblEpisodes
            // 
            this.lblEpisodes.AutoSize = true;
            this.lblEpisodes.Location = new System.Drawing.Point(9, 119);
            this.lblEpisodes.Name = "lblEpisodes";
            this.lblEpisodes.Size = new System.Drawing.Size(50, 13);
            this.lblEpisodes.TabIndex = 8;
            this.lblEpisodes.Text = "Episodes";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 142);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(202, 23);
            this.btnAdd.TabIndex = 10;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnErase
            // 
            this.btnErase.Location = new System.Drawing.Point(12, 172);
            this.btnErase.Name = "btnErase";
            this.btnErase.Size = new System.Drawing.Size(95, 23);
            this.btnErase.TabIndex = 11;
            this.btnErase.Text = "Erase";
            this.btnErase.UseVisualStyleBackColor = true;
            this.btnErase.Click += new System.EventHandler(this.btnErase_Click);
            // 
            // btnEmpty
            // 
            this.btnEmpty.Location = new System.Drawing.Point(119, 172);
            this.btnEmpty.Name = "btnEmpty";
            this.btnEmpty.Size = new System.Drawing.Size(95, 23);
            this.btnEmpty.TabIndex = 12;
            this.btnEmpty.Text = "Empty List";
            this.btnEmpty.UseVisualStyleBackColor = true;
            this.btnEmpty.Click += new System.EventHandler(this.btnEmpty_Click);
            // 
            // lstTitles
            // 
            this.lstTitles.FormattingEnabled = true;
            this.lstTitles.Location = new System.Drawing.Point(12, 202);
            this.lstTitles.Name = "lstTitles";
            this.lstTitles.Size = new System.Drawing.Size(202, 212);
            this.lstTitles.TabIndex = 13;
            // 
            // formMediaList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(227, 422);
            this.Controls.Add(this.lstTitles);
            this.Controls.Add(this.btnEmpty);
            this.Controls.Add(this.btnErase);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEpisodes);
            this.Controls.Add(this.lblEpisodes);
            this.Controls.Add(this.txtDuration);
            this.Controls.Add(this.lblDuration);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.lblYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnMovie);
            this.Name = "formMediaList";
            this.Text = "Media List";
            this.Load += new System.EventHandler(this.formMediaList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton btnMovie;
        private System.Windows.Forms.RadioButton btnShow;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.Label lblDuration;
        private System.Windows.Forms.TextBox txtEpisodes;
        private System.Windows.Forms.Label lblEpisodes;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnErase;
        private System.Windows.Forms.Button btnEmpty;
        private System.Windows.Forms.ListBox lstTitles;
    }
}

