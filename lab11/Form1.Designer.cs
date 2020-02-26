namespace lab11
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.btnAuthor = new System.Windows.Forms.Button();
            this.btnBranch = new System.Windows.Forms.Button();
            this.btnBookCopies = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1038, 61);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book/Author Database Viewer Application";
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(211, 115);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(262, 43);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "View Book Table";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // btnAuthor
            // 
            this.btnAuthor.Location = new System.Drawing.Point(693, 115);
            this.btnAuthor.Name = "btnAuthor";
            this.btnAuthor.Size = new System.Drawing.Size(262, 43);
            this.btnAuthor.TabIndex = 2;
            this.btnAuthor.Text = "View Author Table";
            this.btnAuthor.UseVisualStyleBackColor = true;
            this.btnAuthor.Click += new System.EventHandler(this.btnAuthor_Click);
            // 
            // btnBranch
            // 
            this.btnBranch.Location = new System.Drawing.Point(211, 210);
            this.btnBranch.Name = "btnBranch";
            this.btnBranch.Size = new System.Drawing.Size(262, 43);
            this.btnBranch.TabIndex = 3;
            this.btnBranch.Text = "View Branch Table";
            this.btnBranch.UseVisualStyleBackColor = true;
            this.btnBranch.Click += new System.EventHandler(this.btnBranch_Click);
            // 
            // btnBookCopies
            // 
            this.btnBookCopies.Location = new System.Drawing.Point(693, 210);
            this.btnBookCopies.Name = "btnBookCopies";
            this.btnBookCopies.Size = new System.Drawing.Size(262, 43);
            this.btnBookCopies.TabIndex = 4;
            this.btnBookCopies.Text = "View BookCopies Table";
            this.btnBookCopies.UseVisualStyleBackColor = true;
            this.btnBookCopies.Click += new System.EventHandler(this.btnBookCopies_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 309);
            this.Controls.Add(this.btnBookCopies);
            this.Controls.Add(this.btnBranch);
            this.Controls.Add(this.btnAuthor);
            this.Controls.Add(this.btnBook);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Book/Author Database Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAuthor;
        private System.Windows.Forms.Button btnBranch;
        private System.Windows.Forms.Button btnBookCopies;
    }
}

