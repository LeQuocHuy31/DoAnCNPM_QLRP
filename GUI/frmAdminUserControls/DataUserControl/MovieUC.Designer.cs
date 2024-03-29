﻿namespace GUI.frmAdminUserControls.DataUserControl
{
    partial class MovieUC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel47 = new System.Windows.Forms.Panel();
            this.gpbTimTheoTen = new System.Windows.Forms.GroupBox();
            this.btnSearchMovie = new System.Windows.Forms.Button();
            this.txtSearchMovie = new System.Windows.Forms.TextBox();
            this.btnShowMovie = new System.Windows.Forms.Button();
            this.btnUpdateMovie = new System.Windows.Forms.Button();
            this.btnDeleteMovie = new System.Windows.Forms.Button();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvMovie = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnUpLoadPictureFilm = new System.Windows.Forms.Button();
            this.picFilm = new System.Windows.Forms.PictureBox();
            this.clbMovieGenre = new System.Windows.Forms.CheckedListBox();
            this.dtmMovieEnd = new System.Windows.Forms.DateTimePicker();
            this.dtmMovieStart = new System.Windows.Forms.DateTimePicker();
            this.txtMovieYear = new System.Windows.Forms.TextBox();
            this.txtMovieDirector = new System.Windows.Forms.TextBox();
            this.txtMovieProductor = new System.Windows.Forms.TextBox();
            this.txtMovieLength = new System.Windows.Forms.TextBox();
            this.lblMovieEndDate = new System.Windows.Forms.Label();
            this.lblMovieStartDate = new System.Windows.Forms.Label();
            this.lblMovieLength = new System.Windows.Forms.Label();
            this.txtMovieDesc = new System.Windows.Forms.TextBox();
            this.lblMovieYear = new System.Windows.Forms.Label();
            this.lblMovieGenre = new System.Windows.Forms.Label();
            this.lblMovieDirector = new System.Windows.Forms.Label();
            this.lblMovieProductor = new System.Windows.Forms.Label();
            this.lblMovieDesc = new System.Windows.Forms.Label();
            this.txtMovieName = new System.Windows.Forms.TextBox();
            this.lblMovieName = new System.Windows.Forms.Label();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.lblMovieID = new System.Windows.Forms.Label();
            this.panel47.SuspendLayout();
            this.gpbTimTheoTen.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).BeginInit();
            this.SuspendLayout();
            // 
            // panel47
            // 
            this.panel47.Controls.Add(this.gpbTimTheoTen);
            this.panel47.Controls.Add(this.btnShowMovie);
            this.panel47.Controls.Add(this.btnUpdateMovie);
            this.panel47.Controls.Add(this.btnDeleteMovie);
            this.panel47.Controls.Add(this.btnAddMovie);
            this.panel47.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel47.Location = new System.Drawing.Point(0, 280);
            this.panel47.Margin = new System.Windows.Forms.Padding(4);
            this.panel47.Name = "panel47";
            this.panel47.Size = new System.Drawing.Size(1548, 64);
            this.panel47.TabIndex = 10;
            // 
            // gpbTimTheoTen
            // 
            this.gpbTimTheoTen.Controls.Add(this.btnSearchMovie);
            this.gpbTimTheoTen.Controls.Add(this.txtSearchMovie);
            this.gpbTimTheoTen.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gpbTimTheoTen.Location = new System.Drawing.Point(1023, 1);
            this.gpbTimTheoTen.Name = "gpbTimTheoTen";
            this.gpbTimTheoTen.Size = new System.Drawing.Size(525, 60);
            this.gpbTimTheoTen.TabIndex = 9;
            this.gpbTimTheoTen.TabStop = false;
            this.gpbTimTheoTen.Text = "Tìm theo tên phim";
            // 
            // btnSearchMovie
            // 
            this.btnSearchMovie.Image = global::GUI.Properties.Resources.search_icon;
            this.btnSearchMovie.Location = new System.Drawing.Point(492, 25);
            this.btnSearchMovie.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearchMovie.Name = "btnSearchMovie";
            this.btnSearchMovie.Size = new System.Drawing.Size(27, 27);
            this.btnSearchMovie.TabIndex = 8;
            this.btnSearchMovie.UseVisualStyleBackColor = true;
            this.btnSearchMovie.Click += new System.EventHandler(this.btnSearchMovie_Click);
            // 
            // txtSearchMovie
            // 
            this.txtSearchMovie.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchMovie.Location = new System.Drawing.Point(6, 23);
            this.txtSearchMovie.Name = "txtSearchMovie";
            this.txtSearchMovie.Size = new System.Drawing.Size(480, 30);
            this.txtSearchMovie.TabIndex = 4;
            this.txtSearchMovie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtSearchMovie_KeyDown);
            // 
            // btnShowMovie
            // 
            this.btnShowMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowMovie.Location = new System.Drawing.Point(328, 4);
            this.btnShowMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnShowMovie.Name = "btnShowMovie";
            this.btnShowMovie.Size = new System.Drawing.Size(100, 57);
            this.btnShowMovie.TabIndex = 3;
            this.btnShowMovie.Text = "Xem";
            this.btnShowMovie.UseVisualStyleBackColor = true;
            this.btnShowMovie.Click += new System.EventHandler(this.btnShowMovie_Click);
            // 
            // btnUpdateMovie
            // 
            this.btnUpdateMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateMovie.Location = new System.Drawing.Point(220, 4);
            this.btnUpdateMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdateMovie.Name = "btnUpdateMovie";
            this.btnUpdateMovie.Size = new System.Drawing.Size(100, 57);
            this.btnUpdateMovie.TabIndex = 2;
            this.btnUpdateMovie.Text = "Sửa";
            this.btnUpdateMovie.UseVisualStyleBackColor = true;
            this.btnUpdateMovie.Click += new System.EventHandler(this.btnUpdateMovie_Click);
            // 
            // btnDeleteMovie
            // 
            this.btnDeleteMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteMovie.Location = new System.Drawing.Point(112, 4);
            this.btnDeleteMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteMovie.Name = "btnDeleteMovie";
            this.btnDeleteMovie.Size = new System.Drawing.Size(100, 57);
            this.btnDeleteMovie.TabIndex = 1;
            this.btnDeleteMovie.Text = "Xóa";
            this.btnDeleteMovie.UseVisualStyleBackColor = true;
            this.btnDeleteMovie.Click += new System.EventHandler(this.btnDeleteMovie_Click);
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddMovie.Location = new System.Drawing.Point(4, 4);
            this.btnAddMovie.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(100, 57);
            this.btnAddMovie.TabIndex = 0;
            this.btnAddMovie.Text = "Thêm";
            this.btnAddMovie.UseVisualStyleBackColor = true;
            this.btnAddMovie.Click += new System.EventHandler(this.btnAddMovie_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvMovie);
            this.panel1.Controls.Add(this.panel47);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1548, 638);
            this.panel1.TabIndex = 11;
            // 
            // dtgvMovie
            // 
            this.dtgvMovie.AllowUserToAddRows = false;
            this.dtgvMovie.AllowUserToDeleteRows = false;
            this.dtgvMovie.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgvMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvMovie.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dtgvMovie.Location = new System.Drawing.Point(0, 344);
            this.dtgvMovie.Margin = new System.Windows.Forms.Padding(4);
            this.dtgvMovie.Name = "dtgvMovie";
            this.dtgvMovie.ReadOnly = true;
            this.dtgvMovie.RowHeadersWidth = 51;
            this.dtgvMovie.Size = new System.Drawing.Size(1548, 294);
            this.dtgvMovie.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpLoadPictureFilm);
            this.panel2.Controls.Add(this.picFilm);
            this.panel2.Controls.Add(this.clbMovieGenre);
            this.panel2.Controls.Add(this.dtmMovieEnd);
            this.panel2.Controls.Add(this.dtmMovieStart);
            this.panel2.Controls.Add(this.txtMovieYear);
            this.panel2.Controls.Add(this.txtMovieDirector);
            this.panel2.Controls.Add(this.txtMovieProductor);
            this.panel2.Controls.Add(this.txtMovieLength);
            this.panel2.Controls.Add(this.lblMovieEndDate);
            this.panel2.Controls.Add(this.lblMovieStartDate);
            this.panel2.Controls.Add(this.lblMovieLength);
            this.panel2.Controls.Add(this.txtMovieDesc);
            this.panel2.Controls.Add(this.lblMovieYear);
            this.panel2.Controls.Add(this.lblMovieGenre);
            this.panel2.Controls.Add(this.lblMovieDirector);
            this.panel2.Controls.Add(this.lblMovieProductor);
            this.panel2.Controls.Add(this.lblMovieDesc);
            this.panel2.Controls.Add(this.txtMovieName);
            this.panel2.Controls.Add(this.lblMovieName);
            this.panel2.Controls.Add(this.txtMovieID);
            this.panel2.Controls.Add(this.lblMovieID);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1548, 280);
            this.panel2.TabIndex = 0;
            // 
            // btnUpLoadPictureFilm
            // 
            this.btnUpLoadPictureFilm.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpLoadPictureFilm.Location = new System.Drawing.Point(1120, 227);
            this.btnUpLoadPictureFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpLoadPictureFilm.Name = "btnUpLoadPictureFilm";
            this.btnUpLoadPictureFilm.Size = new System.Drawing.Size(127, 41);
            this.btnUpLoadPictureFilm.TabIndex = 56;
            this.btnUpLoadPictureFilm.Text = "Chọn hình ảnh";
            this.btnUpLoadPictureFilm.UseVisualStyleBackColor = true;
            this.btnUpLoadPictureFilm.Click += new System.EventHandler(this.btnUpLoadPictureFilm_Click);
            // 
            // picFilm
            // 
            this.picFilm.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picFilm.Location = new System.Drawing.Point(1091, 6);
            this.picFilm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picFilm.Name = "picFilm";
            this.picFilm.Size = new System.Drawing.Size(186, 217);
            this.picFilm.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picFilm.TabIndex = 55;
            this.picFilm.TabStop = false;
            // 
            // clbMovieGenre
            // 
            this.clbMovieGenre.CheckOnClick = true;
            this.clbMovieGenre.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.clbMovieGenre.FormattingEnabled = true;
            this.clbMovieGenre.Location = new System.Drawing.Point(147, 161);
            this.clbMovieGenre.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbMovieGenre.MultiColumn = true;
            this.clbMovieGenre.Name = "clbMovieGenre";
            this.clbMovieGenre.Size = new System.Drawing.Size(467, 100);
            this.clbMovieGenre.TabIndex = 54;
            // 
            // dtmMovieEnd
            // 
            this.dtmMovieEnd.CustomFormat = "dd/MM/yyyy";
            this.dtmMovieEnd.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieEnd.Location = new System.Drawing.Point(789, 88);
            this.dtmMovieEnd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmMovieEnd.Name = "dtmMovieEnd";
            this.dtmMovieEnd.Size = new System.Drawing.Size(201, 30);
            this.dtmMovieEnd.TabIndex = 53;
            // 
            // dtmMovieStart
            // 
            this.dtmMovieStart.CustomFormat = "dd/MM/yyyy";
            this.dtmMovieStart.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtmMovieStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtmMovieStart.Location = new System.Drawing.Point(789, 50);
            this.dtmMovieStart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtmMovieStart.Name = "dtmMovieStart";
            this.dtmMovieStart.Size = new System.Drawing.Size(201, 30);
            this.dtmMovieStart.TabIndex = 52;
            // 
            // txtMovieYear
            // 
            this.txtMovieYear.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieYear.Location = new System.Drawing.Point(788, 201);
            this.txtMovieYear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieYear.Name = "txtMovieYear";
            this.txtMovieYear.Size = new System.Drawing.Size(201, 29);
            this.txtMovieYear.TabIndex = 50;
            // 
            // txtMovieDirector
            // 
            this.txtMovieDirector.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieDirector.Location = new System.Drawing.Point(788, 165);
            this.txtMovieDirector.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieDirector.Name = "txtMovieDirector";
            this.txtMovieDirector.Size = new System.Drawing.Size(201, 29);
            this.txtMovieDirector.TabIndex = 49;
            // 
            // txtMovieProductor
            // 
            this.txtMovieProductor.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieProductor.Location = new System.Drawing.Point(788, 127);
            this.txtMovieProductor.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieProductor.Name = "txtMovieProductor";
            this.txtMovieProductor.Size = new System.Drawing.Size(201, 29);
            this.txtMovieProductor.TabIndex = 48;
            // 
            // txtMovieLength
            // 
            this.txtMovieLength.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieLength.Location = new System.Drawing.Point(789, 15);
            this.txtMovieLength.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieLength.Name = "txtMovieLength";
            this.txtMovieLength.Size = new System.Drawing.Size(201, 29);
            this.txtMovieLength.TabIndex = 47;
            // 
            // lblMovieEndDate
            // 
            this.lblMovieEndDate.AutoSize = true;
            this.lblMovieEndDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieEndDate.Location = new System.Drawing.Point(653, 91);
            this.lblMovieEndDate.Name = "lblMovieEndDate";
            this.lblMovieEndDate.Size = new System.Drawing.Size(92, 23);
            this.lblMovieEndDate.TabIndex = 44;
            this.lblMovieEndDate.Text = "Ngày KT:";
            // 
            // lblMovieStartDate
            // 
            this.lblMovieStartDate.AutoSize = true;
            this.lblMovieStartDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieStartDate.Location = new System.Drawing.Point(653, 54);
            this.lblMovieStartDate.Name = "lblMovieStartDate";
            this.lblMovieStartDate.Size = new System.Drawing.Size(94, 23);
            this.lblMovieStartDate.TabIndex = 42;
            this.lblMovieStartDate.Text = "Ngày KC:";
            // 
            // lblMovieLength
            // 
            this.lblMovieLength.AutoSize = true;
            this.lblMovieLength.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieLength.Location = new System.Drawing.Point(653, 18);
            this.lblMovieLength.Name = "lblMovieLength";
            this.lblMovieLength.Size = new System.Drawing.Size(109, 23);
            this.lblMovieLength.TabIndex = 35;
            this.lblMovieLength.Text = "Thời lượng:";
            // 
            // txtMovieDesc
            // 
            this.txtMovieDesc.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieDesc.Location = new System.Drawing.Point(147, 90);
            this.txtMovieDesc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieDesc.Multiline = true;
            this.txtMovieDesc.Name = "txtMovieDesc";
            this.txtMovieDesc.Size = new System.Drawing.Size(467, 67);
            this.txtMovieDesc.TabIndex = 46;
            // 
            // lblMovieYear
            // 
            this.lblMovieYear.AutoSize = true;
            this.lblMovieYear.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieYear.Location = new System.Drawing.Point(652, 204);
            this.lblMovieYear.Name = "lblMovieYear";
            this.lblMovieYear.Size = new System.Drawing.Size(85, 23);
            this.lblMovieYear.TabIndex = 41;
            this.lblMovieYear.Text = "Năm SX:";
            // 
            // lblMovieGenre
            // 
            this.lblMovieGenre.AutoSize = true;
            this.lblMovieGenre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieGenre.Location = new System.Drawing.Point(16, 161);
            this.lblMovieGenre.Name = "lblMovieGenre";
            this.lblMovieGenre.Size = new System.Drawing.Size(85, 23);
            this.lblMovieGenre.TabIndex = 40;
            this.lblMovieGenre.Text = "Thể loại:";
            // 
            // lblMovieDirector
            // 
            this.lblMovieDirector.AutoSize = true;
            this.lblMovieDirector.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieDirector.Location = new System.Drawing.Point(652, 168);
            this.lblMovieDirector.Name = "lblMovieDirector";
            this.lblMovieDirector.Size = new System.Drawing.Size(91, 23);
            this.lblMovieDirector.TabIndex = 39;
            this.lblMovieDirector.Text = "Đạo diễn:";
            // 
            // lblMovieProductor
            // 
            this.lblMovieProductor.AutoSize = true;
            this.lblMovieProductor.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieProductor.Location = new System.Drawing.Point(652, 130);
            this.lblMovieProductor.Name = "lblMovieProductor";
            this.lblMovieProductor.Size = new System.Drawing.Size(90, 23);
            this.lblMovieProductor.TabIndex = 38;
            this.lblMovieProductor.Text = "Sản xuất:";
            // 
            // lblMovieDesc
            // 
            this.lblMovieDesc.AutoSize = true;
            this.lblMovieDesc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieDesc.Location = new System.Drawing.Point(16, 90);
            this.lblMovieDesc.Name = "lblMovieDesc";
            this.lblMovieDesc.Size = new System.Drawing.Size(67, 23);
            this.lblMovieDesc.TabIndex = 37;
            this.lblMovieDesc.Text = "Mô tả:";
            // 
            // txtMovieName
            // 
            this.txtMovieName.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieName.Location = new System.Drawing.Point(147, 54);
            this.txtMovieName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieName.Name = "txtMovieName";
            this.txtMovieName.Size = new System.Drawing.Size(467, 29);
            this.txtMovieName.TabIndex = 51;
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieName.Location = new System.Drawing.Point(16, 57);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(94, 23);
            this.lblMovieName.TabIndex = 36;
            this.lblMovieName.Text = "Tên phim:";
            // 
            // txtMovieID
            // 
            this.txtMovieID.Font = new System.Drawing.Font("Times New Roman", 11F);
            this.txtMovieID.Location = new System.Drawing.Point(147, 16);
            this.txtMovieID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(467, 29);
            this.txtMovieID.TabIndex = 45;
            this.txtMovieID.TextChanged += new System.EventHandler(this.txtMovieID_TextChanged);
            // 
            // lblMovieID
            // 
            this.lblMovieID.AutoSize = true;
            this.lblMovieID.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold);
            this.lblMovieID.Location = new System.Drawing.Point(16, 18);
            this.lblMovieID.Name = "lblMovieID";
            this.lblMovieID.Size = new System.Drawing.Size(90, 23);
            this.lblMovieID.TabIndex = 43;
            this.lblMovieID.Text = "Mã phim:";
            // 
            // MovieUC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MovieUC";
            this.Size = new System.Drawing.Size(1548, 638);
            this.panel47.ResumeLayout(false);
            this.gpbTimTheoTen.ResumeLayout(false);
            this.gpbTimTheoTen.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvMovie)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picFilm)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel47;
        private System.Windows.Forms.Button btnShowMovie;
        private System.Windows.Forms.Button btnUpdateMovie;
        private System.Windows.Forms.Button btnDeleteMovie;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpLoadPictureFilm;
        private System.Windows.Forms.PictureBox picFilm;
        private System.Windows.Forms.CheckedListBox clbMovieGenre;
        private System.Windows.Forms.DateTimePicker dtmMovieEnd;
        private System.Windows.Forms.DateTimePicker dtmMovieStart;
        private System.Windows.Forms.TextBox txtMovieYear;
        private System.Windows.Forms.TextBox txtMovieDirector;
        private System.Windows.Forms.TextBox txtMovieProductor;
        private System.Windows.Forms.TextBox txtMovieLength;
        private System.Windows.Forms.Label lblMovieEndDate;
        private System.Windows.Forms.Label lblMovieStartDate;
        private System.Windows.Forms.Label lblMovieLength;
        private System.Windows.Forms.TextBox txtMovieDesc;
        private System.Windows.Forms.Label lblMovieYear;
        private System.Windows.Forms.Label lblMovieGenre;
        private System.Windows.Forms.Label lblMovieDirector;
        private System.Windows.Forms.Label lblMovieProductor;
        private System.Windows.Forms.Label lblMovieDesc;
        private System.Windows.Forms.TextBox txtMovieName;
        private System.Windows.Forms.Label lblMovieName;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Label lblMovieID;
        private System.Windows.Forms.DataGridView dtgvMovie;
        private System.Windows.Forms.TextBox txtSearchMovie;
        private System.Windows.Forms.Button btnSearchMovie;
        private System.Windows.Forms.GroupBox gpbTimTheoTen;
    }
}
