namespace Firebase.BookClient.PL
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
            this.grbBook = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.gridBook = new System.Windows.Forms.DataGridView();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.lblKeyword = new System.Windows.Forms.Label();
            this.grbCtlBook = new System.Windows.Forms.GroupBox();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.txtBookPrice = new System.Windows.Forms.TextBox();
            this.lblBookPrice = new System.Windows.Forms.Label();
            this.txtBookAuthor = new System.Windows.Forms.TextBox();
            this.lblBookAuthor = new System.Windows.Forms.Label();
            this.txtBookName = new System.Windows.Forms.TextBox();
            this.lblBookName = new System.Windows.Forms.Label();
            this.txtBookCode = new System.Windows.Forms.TextBox();
            this.lblBookCode = new System.Windows.Forms.Label();
            this.grbBook.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).BeginInit();
            this.grbCtlBook.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbBook
            // 
            this.grbBook.Controls.Add(this.btnSearch);
            this.grbBook.Controls.Add(this.gridBook);
            this.grbBook.Controls.Add(this.txtKeyword);
            this.grbBook.Controls.Add(this.lblKeyword);
            this.grbBook.Location = new System.Drawing.Point(14, 13);
            this.grbBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbBook.Name = "grbBook";
            this.grbBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbBook.Size = new System.Drawing.Size(553, 228);
            this.grbBook.TabIndex = 0;
            this.grbBook.TabStop = false;
            this.grbBook.Text = "Books";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(456, 19);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 34);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // gridBook
            // 
            this.gridBook.AllowUserToAddRows = false;
            this.gridBook.AllowUserToDeleteRows = false;
            this.gridBook.AllowUserToResizeColumns = false;
            this.gridBook.AllowUserToResizeRows = false;
            this.gridBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridBook.Location = new System.Drawing.Point(19, 60);
            this.gridBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gridBook.MultiSelect = false;
            this.gridBook.Name = "gridBook";
            this.gridBook.ReadOnly = true;
            this.gridBook.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.gridBook.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gridBook.Size = new System.Drawing.Size(512, 148);
            this.gridBook.TabIndex = 0;
            this.gridBook.SelectionChanged += new System.EventHandler(this.gridBook_SelectionChanged);
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(99, 23);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(339, 23);
            this.txtKeyword.TabIndex = 12;
            // 
            // lblKeyword
            // 
            this.lblKeyword.AutoSize = true;
            this.lblKeyword.Location = new System.Drawing.Point(16, 26);
            this.lblKeyword.Name = "lblKeyword";
            this.lblKeyword.Size = new System.Drawing.Size(57, 16);
            this.lblKeyword.TabIndex = 11;
            this.lblKeyword.Text = "Keyword";
            // 
            // grbCtlBook
            // 
            this.grbCtlBook.Controls.Add(this.btDelete);
            this.grbCtlBook.Controls.Add(this.btUpdate);
            this.grbCtlBook.Controls.Add(this.btAdd);
            this.grbCtlBook.Controls.Add(this.txtBookPrice);
            this.grbCtlBook.Controls.Add(this.lblBookPrice);
            this.grbCtlBook.Controls.Add(this.txtBookAuthor);
            this.grbCtlBook.Controls.Add(this.lblBookAuthor);
            this.grbCtlBook.Controls.Add(this.txtBookName);
            this.grbCtlBook.Controls.Add(this.lblBookName);
            this.grbCtlBook.Controls.Add(this.txtBookCode);
            this.grbCtlBook.Controls.Add(this.lblBookCode);
            this.grbCtlBook.Location = new System.Drawing.Point(15, 251);
            this.grbCtlBook.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCtlBook.Name = "grbCtlBook";
            this.grbCtlBook.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grbCtlBook.Size = new System.Drawing.Size(552, 153);
            this.grbCtlBook.TabIndex = 1;
            this.grbCtlBook.TabStop = false;
            this.grbCtlBook.Text = "Controls";
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(455, 105);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 34);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(455, 65);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 34);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(455, 25);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 34);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // txtBookPrice
            // 
            this.txtBookPrice.Location = new System.Drawing.Point(98, 116);
            this.txtBookPrice.Name = "txtBookPrice";
            this.txtBookPrice.Size = new System.Drawing.Size(339, 23);
            this.txtBookPrice.TabIndex = 7;
            // 
            // lblBookPrice
            // 
            this.lblBookPrice.AutoSize = true;
            this.lblBookPrice.Location = new System.Drawing.Point(15, 119);
            this.lblBookPrice.Name = "lblBookPrice";
            this.lblBookPrice.Size = new System.Drawing.Size(67, 16);
            this.lblBookPrice.TabIndex = 6;
            this.lblBookPrice.Text = "Book Price";
            // 
            // txtBookAuthor
            // 
            this.txtBookAuthor.Location = new System.Drawing.Point(98, 87);
            this.txtBookAuthor.Name = "txtBookAuthor";
            this.txtBookAuthor.Size = new System.Drawing.Size(339, 23);
            this.txtBookAuthor.TabIndex = 5;
            // 
            // lblBookAuthor
            // 
            this.lblBookAuthor.AutoSize = true;
            this.lblBookAuthor.Location = new System.Drawing.Point(15, 90);
            this.lblBookAuthor.Name = "lblBookAuthor";
            this.lblBookAuthor.Size = new System.Drawing.Size(77, 16);
            this.lblBookAuthor.TabIndex = 4;
            this.lblBookAuthor.Text = "Book Author";
            // 
            // txtBookName
            // 
            this.txtBookName.Location = new System.Drawing.Point(98, 58);
            this.txtBookName.Name = "txtBookName";
            this.txtBookName.Size = new System.Drawing.Size(339, 23);
            this.txtBookName.TabIndex = 3;
            // 
            // lblBookName
            // 
            this.lblBookName.AutoSize = true;
            this.lblBookName.Location = new System.Drawing.Point(15, 61);
            this.lblBookName.Name = "lblBookName";
            this.lblBookName.Size = new System.Drawing.Size(72, 16);
            this.lblBookName.TabIndex = 2;
            this.lblBookName.Text = "Book Name";
            // 
            // txtBookCode
            // 
            this.txtBookCode.Location = new System.Drawing.Point(98, 29);
            this.txtBookCode.Name = "txtBookCode";
            this.txtBookCode.Size = new System.Drawing.Size(339, 23);
            this.txtBookCode.TabIndex = 1;
            // 
            // lblBookCode
            // 
            this.lblBookCode.AutoSize = true;
            this.lblBookCode.Location = new System.Drawing.Point(15, 32);
            this.lblBookCode.Name = "lblBookCode";
            this.lblBookCode.Size = new System.Drawing.Size(68, 16);
            this.lblBookCode.TabIndex = 0;
            this.lblBookCode.Text = "Book Code";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 418);
            this.Controls.Add(this.grbCtlBook);
            this.Controls.Add(this.grbBook);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "BOOK";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grbBook.ResumeLayout(false);
            this.grbBook.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridBook)).EndInit();
            this.grbCtlBook.ResumeLayout(false);
            this.grbCtlBook.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbBook;
        private System.Windows.Forms.DataGridView gridBook;
        private System.Windows.Forms.GroupBox grbCtlBook;
        private System.Windows.Forms.Label lblBookCode;
        private System.Windows.Forms.TextBox txtBookPrice;
        private System.Windows.Forms.Label lblBookPrice;
        private System.Windows.Forms.TextBox txtBookAuthor;
        private System.Windows.Forms.Label lblBookAuthor;
        private System.Windows.Forms.TextBox txtBookName;
        private System.Windows.Forms.Label lblBookName;
        private System.Windows.Forms.TextBox txtBookCode;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label lblKeyword;
    }
}

