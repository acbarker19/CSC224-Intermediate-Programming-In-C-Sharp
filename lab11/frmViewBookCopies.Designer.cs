namespace lab11
{
    partial class frmViewBookCopies
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewBookCopies));
            System.Windows.Forms.Label bookIDLabel;
            System.Windows.Forms.Label branchIDLabel;
            System.Windows.Forms.Label numCopiesLabel;
            this.label1 = new System.Windows.Forms.Label();
            this.collegeDataSet = new lab11.CollegeDataSet();
            this.bookCopiesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookCopiesTableAdapter = new lab11.CollegeDataSetTableAdapters.BookCopiesTableAdapter();
            this.tableAdapterManager = new lab11.CollegeDataSetTableAdapters.TableAdapterManager();
            this.bookCopiesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bookCopiesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.bookIDTextBox = new System.Windows.Forms.TextBox();
            this.branchIDTextBox = new System.Windows.Forms.TextBox();
            this.numCopiesTextBox = new System.Windows.Forms.TextBox();
            bookIDLabel = new System.Windows.Forms.Label();
            branchIDLabel = new System.Windows.Forms.Label();
            numCopiesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopiesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopiesBindingNavigator)).BeginInit();
            this.bookCopiesBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(217, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "View Book Copies";
            // 
            // collegeDataSet
            // 
            this.collegeDataSet.DataSetName = "CollegeDataSet";
            this.collegeDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bookCopiesBindingSource
            // 
            this.bookCopiesBindingSource.DataMember = "BookCopies";
            this.bookCopiesBindingSource.DataSource = this.collegeDataSet;
            // 
            // bookCopiesTableAdapter
            // 
            this.bookCopiesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.AuthorTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BookCopiesTableAdapter = this.bookCopiesTableAdapter;
            this.tableAdapterManager.BookTableAdapter = null;
            this.tableAdapterManager.BranchTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = lab11.CollegeDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // bookCopiesBindingNavigator
            // 
            this.bookCopiesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bookCopiesBindingNavigator.BindingSource = this.bookCopiesBindingSource;
            this.bookCopiesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bookCopiesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bookCopiesBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.bookCopiesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bookCopiesBindingNavigatorSaveItem});
            this.bookCopiesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bookCopiesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bookCopiesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bookCopiesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bookCopiesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bookCopiesBindingNavigator.Name = "bookCopiesBindingNavigator";
            this.bookCopiesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bookCopiesBindingNavigator.Size = new System.Drawing.Size(800, 42);
            this.bookCopiesBindingNavigator.TabIndex = 1;
            this.bookCopiesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 19);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 32);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(46, 36);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bookCopiesBindingNavigatorSaveItem
            // 
            this.bookCopiesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bookCopiesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bookCopiesBindingNavigatorSaveItem.Image")));
            this.bookCopiesBindingNavigatorSaveItem.Name = "bookCopiesBindingNavigatorSaveItem";
            this.bookCopiesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bookCopiesBindingNavigatorSaveItem.Text = "Save Data";
            this.bookCopiesBindingNavigatorSaveItem.Click += new System.EventHandler(this.bookCopiesBindingNavigatorSaveItem_Click);
            // 
            // bookIDLabel
            // 
            bookIDLabel.AutoSize = true;
            bookIDLabel.Location = new System.Drawing.Point(72, 168);
            bookIDLabel.Name = "bookIDLabel";
            bookIDLabel.Size = new System.Drawing.Size(93, 25);
            bookIDLabel.TabIndex = 2;
            bookIDLabel.Text = "Book ID:";
            // 
            // bookIDTextBox
            // 
            this.bookIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopiesBindingSource, "BookID", true));
            this.bookIDTextBox.Location = new System.Drawing.Point(213, 165);
            this.bookIDTextBox.Name = "bookIDTextBox";
            this.bookIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.bookIDTextBox.TabIndex = 3;
            // 
            // branchIDLabel
            // 
            branchIDLabel.AutoSize = true;
            branchIDLabel.Location = new System.Drawing.Point(72, 205);
            branchIDLabel.Name = "branchIDLabel";
            branchIDLabel.Size = new System.Drawing.Size(112, 25);
            branchIDLabel.TabIndex = 4;
            branchIDLabel.Text = "Branch ID:";
            // 
            // branchIDTextBox
            // 
            this.branchIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopiesBindingSource, "BranchID", true));
            this.branchIDTextBox.Location = new System.Drawing.Point(213, 202);
            this.branchIDTextBox.Name = "branchIDTextBox";
            this.branchIDTextBox.Size = new System.Drawing.Size(100, 31);
            this.branchIDTextBox.TabIndex = 5;
            // 
            // numCopiesLabel
            // 
            numCopiesLabel.AutoSize = true;
            numCopiesLabel.Location = new System.Drawing.Point(72, 242);
            numCopiesLabel.Name = "numCopiesLabel";
            numCopiesLabel.Size = new System.Drawing.Size(135, 25);
            numCopiesLabel.TabIndex = 6;
            numCopiesLabel.Text = "Num Copies:";
            // 
            // numCopiesTextBox
            // 
            this.numCopiesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bookCopiesBindingSource, "NumCopies", true));
            this.numCopiesTextBox.Location = new System.Drawing.Point(213, 239);
            this.numCopiesTextBox.Name = "numCopiesTextBox";
            this.numCopiesTextBox.Size = new System.Drawing.Size(100, 31);
            this.numCopiesTextBox.TabIndex = 7;
            // 
            // frmViewBookCopies
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(bookIDLabel);
            this.Controls.Add(this.bookIDTextBox);
            this.Controls.Add(branchIDLabel);
            this.Controls.Add(this.branchIDTextBox);
            this.Controls.Add(numCopiesLabel);
            this.Controls.Add(this.numCopiesTextBox);
            this.Controls.Add(this.bookCopiesBindingNavigator);
            this.Controls.Add(this.label1);
            this.Name = "frmViewBookCopies";
            this.Text = "frmViewBookCopies";
            this.Load += new System.EventHandler(this.frmViewBookCopies_Load);
            ((System.ComponentModel.ISupportInitialize)(this.collegeDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopiesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCopiesBindingNavigator)).EndInit();
            this.bookCopiesBindingNavigator.ResumeLayout(false);
            this.bookCopiesBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private CollegeDataSet collegeDataSet;
        private System.Windows.Forms.BindingSource bookCopiesBindingSource;
        private CollegeDataSetTableAdapters.BookCopiesTableAdapter bookCopiesTableAdapter;
        private CollegeDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bookCopiesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bookCopiesBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox bookIDTextBox;
        private System.Windows.Forms.TextBox branchIDTextBox;
        private System.Windows.Forms.TextBox numCopiesTextBox;
    }
}