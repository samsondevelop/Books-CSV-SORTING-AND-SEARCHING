namespace Books_List_App
{
    partial class Form1
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
            this.datagridBooks = new System.Windows.Forms.DataGridView();
            this.TextBook = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Seller = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchaser = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Purchase_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sale_Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rating = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).BeginInit();
            this.SuspendLayout();
            // 
            // datagridBooks
            // 
            this.datagridBooks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridBooks.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TextBook,
            this.Subject,
            this.Seller,
            this.Purchaser,
            this.Purchase_Price,
            this.Sale_Price,
            this.Rating});
            this.datagridBooks.Location = new System.Drawing.Point(13, 31);
            this.datagridBooks.Name = "datagridBooks";
            this.datagridBooks.Size = new System.Drawing.Size(775, 407);
            this.datagridBooks.TabIndex = 0;
            this.datagridBooks.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // TextBook
            // 
            this.TextBook.HeaderText = "TextBook";
            this.TextBook.Name = "TextBook";
            // 
            // Subject
            // 
            this.Subject.HeaderText = "Subject";
            this.Subject.Name = "Subject";
            // 
            // Seller
            // 
            this.Seller.HeaderText = "Seller";
            this.Seller.Name = "Seller";
            // 
            // Purchaser
            // 
            this.Purchaser.HeaderText = "Purchaser";
            this.Purchaser.Name = "Purchaser";
            // 
            // Purchase_Price
            // 
            this.Purchase_Price.HeaderText = "Purchase Price";
            this.Purchase_Price.Name = "Purchase_Price";
            // 
            // Sale_Price
            // 
            this.Sale_Price.HeaderText = "Sale Price";
            this.Sale_Price.Name = "Sale_Price";
            // 
            // Rating
            // 
            this.Rating.HeaderText = "Rating";
            this.Rating.Name = "Rating";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(183, 20);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "textbook",
            "subject",
            "rating"});
            this.comboBox1.Location = new System.Drawing.Point(13, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.datagridBooks);
            this.Name = "Form1";
            this.Text = "Book App";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datagridBooks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView datagridBooks;
        private System.Windows.Forms.DataGridViewTextBoxColumn TextBook;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn Seller;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchaser;
        private System.Windows.Forms.DataGridViewTextBoxColumn Purchase_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sale_Price;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rating;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}

