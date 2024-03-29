﻿namespace pa6
{
    partial class frmMain
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
            this.Title = new System.Windows.Forms.Label();
            this.titleboxData = new System.Windows.Forms.TextBox();
            this.Author = new System.Windows.Forms.Label();
            this.authorboxData = new System.Windows.Forms.TextBox();
            this.genreboxData = new System.Windows.Forms.TextBox();
            this.Genre = new System.Windows.Forms.Label();
            this.Availability = new System.Windows.Forms.Label();
            this.copiesboxData = new System.Windows.Forms.TextBox();
            this.ISBN = new System.Windows.Forms.Label();
            this.isbnboxData = new System.Windows.Forms.TextBox();
            this.Length = new System.Windows.Forms.Label();
            this.lengthboxData = new System.Windows.Forms.TextBox();
            this.lstBooks = new System.Windows.Forms.ListBox();
            this.picBox = new System.Windows.Forms.PictureBox();
            this.bRent = new System.Windows.Forms.Button();
            this.bReturn = new System.Windows.Forms.Button();
            this.bNew = new System.Windows.Forms.Button();
            this.bEdit = new System.Windows.Forms.Button();
            this.bDelete = new System.Windows.Forms.Button();
            this.bExit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(477, 12);
            this.Title.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(103, 45);
            this.Title.TabIndex = 0;
            this.Title.Text = "Title:";
            // 
            // titleboxData
            // 
            this.titleboxData.Location = new System.Drawing.Point(485, 62);
            this.titleboxData.Margin = new System.Windows.Forms.Padding(5);
            this.titleboxData.Name = "titleboxData";
            this.titleboxData.Size = new System.Drawing.Size(319, 52);
            this.titleboxData.TabIndex = 1;
            // 
            // Author
            // 
            this.Author.AutoSize = true;
            this.Author.Location = new System.Drawing.Point(477, 134);
            this.Author.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Author.Name = "Author";
            this.Author.Size = new System.Drawing.Size(135, 45);
            this.Author.TabIndex = 2;
            this.Author.Text = "Author:";
            this.Author.Click += new System.EventHandler(this.Author_Click);
            // 
            // authorboxData
            // 
            this.authorboxData.Location = new System.Drawing.Point(485, 184);
            this.authorboxData.Margin = new System.Windows.Forms.Padding(5);
            this.authorboxData.Name = "authorboxData";
            this.authorboxData.Size = new System.Drawing.Size(319, 52);
            this.authorboxData.TabIndex = 3;
            // 
            // genreboxData
            // 
            this.genreboxData.Location = new System.Drawing.Point(485, 293);
            this.genreboxData.Margin = new System.Windows.Forms.Padding(5);
            this.genreboxData.Name = "genreboxData";
            this.genreboxData.Size = new System.Drawing.Size(319, 52);
            this.genreboxData.TabIndex = 4;
            // 
            // Genre
            // 
            this.Genre.AutoSize = true;
            this.Genre.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Genre.Location = new System.Drawing.Point(477, 243);
            this.Genre.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Genre.Name = "Genre";
            this.Genre.Size = new System.Drawing.Size(120, 45);
            this.Genre.TabIndex = 5;
            this.Genre.Text = "Genre:";
            // 
            // Availability
            // 
            this.Availability.AutoSize = true;
            this.Availability.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Availability.Location = new System.Drawing.Point(477, 360);
            this.Availability.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Availability.Name = "Availability";
            this.Availability.Size = new System.Drawing.Size(126, 45);
            this.Availability.TabIndex = 6;
            this.Availability.Text = "Copies:";
            // 
            // copiesboxData
            // 
            this.copiesboxData.Location = new System.Drawing.Point(485, 412);
            this.copiesboxData.Margin = new System.Windows.Forms.Padding(5);
            this.copiesboxData.Name = "copiesboxData";
            this.copiesboxData.Size = new System.Drawing.Size(319, 52);
            this.copiesboxData.TabIndex = 7;
            // 
            // ISBN
            // 
            this.ISBN.AutoSize = true;
            this.ISBN.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ISBN.Location = new System.Drawing.Point(482, 469);
            this.ISBN.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ISBN.Name = "ISBN";
            this.ISBN.Size = new System.Drawing.Size(115, 45);
            this.ISBN.TabIndex = 8;
            this.ISBN.Text = "ISBN:";
            // 
            // isbnboxData
            // 
            this.isbnboxData.Location = new System.Drawing.Point(485, 519);
            this.isbnboxData.Margin = new System.Windows.Forms.Padding(5);
            this.isbnboxData.Name = "isbnboxData";
            this.isbnboxData.Size = new System.Drawing.Size(319, 52);
            this.isbnboxData.TabIndex = 9;
            this.isbnboxData.TextChanged += new System.EventHandler(this.TextBox1_TextChanged);
            // 
            // Length
            // 
            this.Length.AutoSize = true;
            this.Length.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Length.Location = new System.Drawing.Point(482, 583);
            this.Length.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Length.Name = "Length";
            this.Length.Size = new System.Drawing.Size(133, 45);
            this.Length.TabIndex = 10;
            this.Length.Text = "Length:";
            // 
            // lengthboxData
            // 
            this.lengthboxData.Location = new System.Drawing.Point(485, 633);
            this.lengthboxData.Margin = new System.Windows.Forms.Padding(5);
            this.lengthboxData.Name = "lengthboxData";
            this.lengthboxData.Size = new System.Drawing.Size(319, 52);
            this.lengthboxData.TabIndex = 11;
            // 
            // lstBooks
            // 
            this.lstBooks.FormattingEnabled = true;
            this.lstBooks.ItemHeight = 45;
            this.lstBooks.Location = new System.Drawing.Point(12, 12);
            this.lstBooks.Name = "lstBooks";
            this.lstBooks.Size = new System.Drawing.Size(388, 634);
            this.lstBooks.TabIndex = 12;
            this.lstBooks.SelectedIndexChanged += new System.EventHandler(this.LstBooks_SelectedIndexChanged);
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(840, 12);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(397, 616);
            this.picBox.TabIndex = 13;
            this.picBox.TabStop = false;
            // 
            // bRent
            // 
            this.bRent.Location = new System.Drawing.Point(883, 634);
            this.bRent.Name = "bRent";
            this.bRent.Size = new System.Drawing.Size(137, 67);
            this.bRent.TabIndex = 14;
            this.bRent.Text = "Rent";
            this.bRent.UseVisualStyleBackColor = true;
            // 
            // bReturn
            // 
            this.bReturn.Location = new System.Drawing.Point(1054, 634);
            this.bReturn.Name = "bReturn";
            this.bReturn.Size = new System.Drawing.Size(137, 67);
            this.bReturn.TabIndex = 15;
            this.bReturn.Text = "Return";
            this.bReturn.UseVisualStyleBackColor = true;
            // 
            // bNew
            // 
            this.bNew.Location = new System.Drawing.Point(265, 716);
            this.bNew.Name = "bNew";
            this.bNew.Size = new System.Drawing.Size(135, 65);
            this.bNew.TabIndex = 16;
            this.bNew.Text = "New";
            this.bNew.UseVisualStyleBackColor = true;
            // 
            // bEdit
            // 
            this.bEdit.Location = new System.Drawing.Point(425, 717);
            this.bEdit.Name = "bEdit";
            this.bEdit.Size = new System.Drawing.Size(145, 64);
            this.bEdit.TabIndex = 17;
            this.bEdit.Text = "Edit";
            this.bEdit.UseVisualStyleBackColor = true;
            // 
            // bDelete
            // 
            this.bDelete.Location = new System.Drawing.Point(603, 717);
            this.bDelete.Name = "bDelete";
            this.bDelete.Size = new System.Drawing.Size(138, 65);
            this.bDelete.TabIndex = 18;
            this.bDelete.Text = "Delete";
            this.bDelete.UseVisualStyleBackColor = true;
            // 
            // bExit
            // 
            this.bExit.Location = new System.Drawing.Point(771, 716);
            this.bExit.Name = "bExit";
            this.bExit.Size = new System.Drawing.Size(136, 64);
            this.bExit.TabIndex = 19;
            this.bExit.Text = "Exit";
            this.bExit.UseVisualStyleBackColor = true;
            this.bExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(20F, 45F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 814);
            this.Controls.Add(this.bExit);
            this.Controls.Add(this.bDelete);
            this.Controls.Add(this.bEdit);
            this.Controls.Add(this.bNew);
            this.Controls.Add(this.bReturn);
            this.Controls.Add(this.bRent);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.lstBooks);
            this.Controls.Add(this.lengthboxData);
            this.Controls.Add(this.Length);
            this.Controls.Add(this.isbnboxData);
            this.Controls.Add(this.ISBN);
            this.Controls.Add(this.copiesboxData);
            this.Controls.Add(this.Availability);
            this.Controls.Add(this.Genre);
            this.Controls.Add(this.genreboxData);
            this.Controls.Add(this.authorboxData);
            this.Controls.Add(this.Author);
            this.Controls.Add(this.titleboxData);
            this.Controls.Add(this.Title);
            this.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmMain";
            this.Text = "Audio Book Rental";
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.TextBox titleboxData;
        private System.Windows.Forms.Label Author;
        private System.Windows.Forms.TextBox authorboxData;
        private System.Windows.Forms.TextBox genreboxData;
        private System.Windows.Forms.Label Genre;
        private System.Windows.Forms.Label Availability;
        private System.Windows.Forms.TextBox copiesboxData;
        private System.Windows.Forms.Label ISBN;
        private System.Windows.Forms.TextBox isbnboxData;
        private System.Windows.Forms.Label Length;
        private System.Windows.Forms.TextBox lengthboxData;
        private System.Windows.Forms.ListBox lstBooks;
        private System.Windows.Forms.PictureBox picBox;
        private System.Windows.Forms.Button bRent;
        private System.Windows.Forms.Button bReturn;
        private System.Windows.Forms.Button bNew;
        private System.Windows.Forms.Button bEdit;
        private System.Windows.Forms.Button bDelete;
        private System.Windows.Forms.Button bExit;
    }
}