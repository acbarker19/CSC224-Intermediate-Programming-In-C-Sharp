namespace program5
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label customerIDLabel;
            System.Windows.Forms.Label nameLabel;
            System.Windows.Forms.Label addressLabel;
            System.Windows.Forms.Label cityLabel;
            System.Windows.Forms.Label stateLabel;
            System.Windows.Forms.Label zipCodeLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.expDataSet = new program5.ExpDataSet();
            this.csc224AlecCustomersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.csc224AlecCustomersTableAdapter = new program5.ExpDataSetTableAdapters.csc224AlecCustomersTableAdapter();
            this.tableAdapterManager = new program5.ExpDataSetTableAdapters.TableAdapterManager();
            this.csc224AlecStatesTableAdapter = new program5.ExpDataSetTableAdapters.csc224AlecStatesTableAdapter();
            this.csc224AlecCustomersBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.csc224AlecCustomersBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.customerIDTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.cityTextBox = new System.Windows.Forms.TextBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.csc224AlecStatesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.zipCodeTextBox = new System.Windows.Forms.TextBox();
            this.fillByCustomerIDToolStrip = new System.Windows.Forms.ToolStrip();
            this.customerIDToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.customerIDToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.fillByCustomerIDToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCancelItem = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fillByAllCustomersToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.stateToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.stateToolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.stateToolStripButton = new System.Windows.Forms.ToolStripButton();
            customerIDLabel = new System.Windows.Forms.Label();
            nameLabel = new System.Windows.Forms.Label();
            addressLabel = new System.Windows.Forms.Label();
            cityLabel = new System.Windows.Forms.Label();
            stateLabel = new System.Windows.Forms.Label();
            zipCodeLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.expDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224AlecCustomersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224AlecCustomersBindingNavigator)).BeginInit();
            this.csc224AlecCustomersBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csc224AlecStatesBindingSource)).BeginInit();
            this.fillByCustomerIDToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Location = new System.Drawing.Point(12, 142);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new System.Drawing.Size(136, 25);
            customerIDLabel.TabIndex = 1;
            customerIDLabel.Text = "Customer ID:";
            // 
            // nameLabel
            // 
            nameLabel.AutoSize = true;
            nameLabel.Location = new System.Drawing.Point(12, 179);
            nameLabel.Name = "nameLabel";
            nameLabel.Size = new System.Drawing.Size(74, 25);
            nameLabel.TabIndex = 3;
            nameLabel.Text = "Name:";
            // 
            // addressLabel
            // 
            addressLabel.AutoSize = true;
            addressLabel.Location = new System.Drawing.Point(12, 216);
            addressLabel.Name = "addressLabel";
            addressLabel.Size = new System.Drawing.Size(97, 25);
            addressLabel.TabIndex = 5;
            addressLabel.Text = "Address:";
            // 
            // cityLabel
            // 
            cityLabel.AutoSize = true;
            cityLabel.Location = new System.Drawing.Point(12, 253);
            cityLabel.Name = "cityLabel";
            cityLabel.Size = new System.Drawing.Size(55, 25);
            cityLabel.TabIndex = 7;
            cityLabel.Text = "City:";
            // 
            // stateLabel
            // 
            stateLabel.AutoSize = true;
            stateLabel.Location = new System.Drawing.Point(12, 290);
            stateLabel.Name = "stateLabel";
            stateLabel.Size = new System.Drawing.Size(68, 25);
            stateLabel.TabIndex = 9;
            stateLabel.Text = "State:";
            // 
            // zipCodeLabel
            // 
            zipCodeLabel.AutoSize = true;
            zipCodeLabel.Location = new System.Drawing.Point(716, 290);
            zipCodeLabel.Name = "zipCodeLabel";
            zipCodeLabel.Size = new System.Drawing.Size(105, 25);
            zipCodeLabel.TabIndex = 11;
            zipCodeLabel.Text = "Zip Code:";
            // 
            // expDataSet
            // 
            this.expDataSet.DataSetName = "ExpDataSet";
            this.expDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // csc224AlecCustomersBindingSource
            // 
            this.csc224AlecCustomersBindingSource.DataMember = "csc224AlecCustomers";
            this.csc224AlecCustomersBindingSource.DataSource = this.expDataSet;
            // 
            // csc224AlecCustomersTableAdapter
            // 
            this.csc224AlecCustomersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.csc224AlecCustomersTableAdapter = this.csc224AlecCustomersTableAdapter;
            this.tableAdapterManager.csc224AlecStatesTableAdapter = this.csc224AlecStatesTableAdapter;
            this.tableAdapterManager.UpdateOrder = program5.ExpDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // csc224AlecStatesTableAdapter
            // 
            this.csc224AlecStatesTableAdapter.ClearBeforeFill = true;
            // 
            // csc224AlecCustomersBindingNavigator
            // 
            this.csc224AlecCustomersBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.csc224AlecCustomersBindingNavigator.BindingSource = this.csc224AlecCustomersBindingSource;
            this.csc224AlecCustomersBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.csc224AlecCustomersBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.csc224AlecCustomersBindingNavigator.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.csc224AlecCustomersBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.bindingNavigatorCancelItem,
            this.csc224AlecCustomersBindingNavigatorSaveItem});
            this.csc224AlecCustomersBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.csc224AlecCustomersBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.csc224AlecCustomersBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.csc224AlecCustomersBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.csc224AlecCustomersBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.csc224AlecCustomersBindingNavigator.Name = "csc224AlecCustomersBindingNavigator";
            this.csc224AlecCustomersBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.csc224AlecCustomersBindingNavigator.Size = new System.Drawing.Size(1103, 42);
            this.csc224AlecCustomersBindingNavigator.TabIndex = 0;
            this.csc224AlecCustomersBindingNavigator.Text = "bindingNavigator1";
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
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(71, 36);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
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
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(46, 36);
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
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 42);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 39);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 42);
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
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // csc224AlecCustomersBindingNavigatorSaveItem
            // 
            this.csc224AlecCustomersBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.csc224AlecCustomersBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("csc224AlecCustomersBindingNavigatorSaveItem.Image")));
            this.csc224AlecCustomersBindingNavigatorSaveItem.Name = "csc224AlecCustomersBindingNavigatorSaveItem";
            this.csc224AlecCustomersBindingNavigatorSaveItem.Size = new System.Drawing.Size(46, 36);
            this.csc224AlecCustomersBindingNavigatorSaveItem.Text = "Save Data";
            this.csc224AlecCustomersBindingNavigatorSaveItem.Click += new System.EventHandler(this.csc224AlecCustomersBindingNavigatorSaveItem_Click_1);
            // 
            // customerIDTextBox
            // 
            this.customerIDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224AlecCustomersBindingSource, "CustomerID", true));
            this.customerIDTextBox.Location = new System.Drawing.Point(154, 139);
            this.customerIDTextBox.Name = "customerIDTextBox";
            this.customerIDTextBox.ReadOnly = true;
            this.customerIDTextBox.Size = new System.Drawing.Size(121, 31);
            this.customerIDTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            this.nameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224AlecCustomersBindingSource, "Name", true));
            this.nameTextBox.Location = new System.Drawing.Point(154, 176);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(937, 31);
            this.nameTextBox.TabIndex = 4;
            // 
            // addressTextBox
            // 
            this.addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224AlecCustomersBindingSource, "Address", true));
            this.addressTextBox.Location = new System.Drawing.Point(154, 213);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(937, 31);
            this.addressTextBox.TabIndex = 6;
            // 
            // cityTextBox
            // 
            this.cityTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224AlecCustomersBindingSource, "City", true));
            this.cityTextBox.Location = new System.Drawing.Point(154, 250);
            this.cityTextBox.Name = "cityTextBox";
            this.cityTextBox.Size = new System.Drawing.Size(937, 31);
            this.cityTextBox.TabIndex = 8;
            // 
            // stateComboBox
            // 
            this.stateComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.csc224AlecCustomersBindingSource, "State", true));
            this.stateComboBox.DataSource = this.csc224AlecStatesBindingSource;
            this.stateComboBox.DisplayMember = "StateName";
            this.stateComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Location = new System.Drawing.Point(154, 287);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(376, 33);
            this.stateComboBox.TabIndex = 10;
            this.stateComboBox.ValueMember = "StateCode";
            // 
            // csc224AlecStatesBindingSource
            // 
            this.csc224AlecStatesBindingSource.DataMember = "csc224AlecStates";
            this.csc224AlecStatesBindingSource.DataSource = this.expDataSet;
            // 
            // zipCodeTextBox
            // 
            this.zipCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.csc224AlecCustomersBindingSource, "ZipCode", true));
            this.zipCodeTextBox.Location = new System.Drawing.Point(827, 287);
            this.zipCodeTextBox.Name = "zipCodeTextBox";
            this.zipCodeTextBox.Size = new System.Drawing.Size(264, 31);
            this.zipCodeTextBox.TabIndex = 12;
            // 
            // fillByCustomerIDToolStrip
            // 
            this.fillByCustomerIDToolStrip.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.fillByCustomerIDToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customerIDToolStripLabel,
            this.customerIDToolStripTextBox,
            this.fillByCustomerIDToolStripButton,
            this.toolStripSeparator1,
            this.fillByAllCustomersToolStripButton,
            this.toolStripSeparator2,
            this.stateToolStripLabel,
            this.stateToolStripTextBox,
            this.stateToolStripButton});
            this.fillByCustomerIDToolStrip.Location = new System.Drawing.Point(0, 42);
            this.fillByCustomerIDToolStrip.Name = "fillByCustomerIDToolStrip";
            this.fillByCustomerIDToolStrip.Size = new System.Drawing.Size(1103, 42);
            this.fillByCustomerIDToolStrip.TabIndex = 13;
            this.fillByCustomerIDToolStrip.Text = "fillByCustomerIDToolStrip";
            // 
            // customerIDToolStripLabel
            // 
            this.customerIDToolStripLabel.Name = "customerIDToolStripLabel";
            this.customerIDToolStripLabel.Size = new System.Drawing.Size(153, 36);
            this.customerIDToolStripLabel.Text = "Customer ID:";
            // 
            // customerIDToolStripTextBox
            // 
            this.customerIDToolStripTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.customerIDToolStripTextBox.Name = "customerIDToolStripTextBox";
            this.customerIDToolStripTextBox.Size = new System.Drawing.Size(100, 42);
            // 
            // fillByCustomerIDToolStripButton
            // 
            this.fillByCustomerIDToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByCustomerIDToolStripButton.Name = "fillByCustomerIDToolStripButton";
            this.fillByCustomerIDToolStripButton.Size = new System.Drawing.Size(166, 36);
            this.fillByCustomerIDToolStripButton.Text = "Get Customer";
            this.fillByCustomerIDToolStripButton.Click += new System.EventHandler(this.fillByCustomerIDToolStripButton_Click);
            // 
            // bindingNavigatorCancelItem
            // 
            this.bindingNavigatorCancelItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bindingNavigatorCancelItem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCancelItem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.bindingNavigatorCancelItem.Name = "bindingNavigatorCancelItem";
            this.bindingNavigatorCancelItem.Size = new System.Drawing.Size(94, 36);
            this.bindingNavigatorCancelItem.Text = "Cancel";
            this.bindingNavigatorCancelItem.Click += new System.EventHandler(this.bindingNavigatorCancelItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 42);
            // 
            // fillByAllCustomersToolStripButton
            // 
            this.fillByAllCustomersToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByAllCustomersToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("fillByAllCustomersToolStripButton.Image")));
            this.fillByAllCustomersToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.fillByAllCustomersToolStripButton.Name = "fillByAllCustomersToolStripButton";
            this.fillByAllCustomersToolStripButton.Size = new System.Drawing.Size(210, 36);
            this.fillByAllCustomersToolStripButton.Text = "Get All Customers";
            this.fillByAllCustomersToolStripButton.Click += new System.EventHandler(this.fillByAllCustomersToolStripButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 42);
            // 
            // stateToolStripLabel
            // 
            this.stateToolStripLabel.Name = "stateToolStripLabel";
            this.stateToolStripLabel.Size = new System.Drawing.Size(136, 36);
            this.stateToolStripLabel.Text = "State Code:";
            // 
            // stateToolStripTextBox
            // 
            this.stateToolStripTextBox.Name = "stateToolStripTextBox";
            this.stateToolStripTextBox.Size = new System.Drawing.Size(75, 50);
            // 
            // stateToolStripButton
            // 
            this.stateToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.stateToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("stateToolStripButton.Image")));
            this.stateToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.stateToolStripButton.Name = "stateToolStripButton";
            this.stateToolStripButton.Size = new System.Drawing.Size(142, 44);
            this.stateToolStripButton.Text = "Fill By State";
            this.stateToolStripButton.Click += new System.EventHandler(this.stateToolStripButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1103, 340);
            this.Controls.Add(this.fillByCustomerIDToolStrip);
            this.Controls.Add(customerIDLabel);
            this.Controls.Add(this.customerIDTextBox);
            this.Controls.Add(nameLabel);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(addressLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(cityLabel);
            this.Controls.Add(this.cityTextBox);
            this.Controls.Add(stateLabel);
            this.Controls.Add(this.stateComboBox);
            this.Controls.Add(zipCodeLabel);
            this.Controls.Add(this.zipCodeTextBox);
            this.Controls.Add(this.csc224AlecCustomersBindingNavigator);
            this.Name = "Form1";
            this.Text = "Customer Maintenance";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.expDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224AlecCustomersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.csc224AlecCustomersBindingNavigator)).EndInit();
            this.csc224AlecCustomersBindingNavigator.ResumeLayout(false);
            this.csc224AlecCustomersBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.csc224AlecStatesBindingSource)).EndInit();
            this.fillByCustomerIDToolStrip.ResumeLayout(false);
            this.fillByCustomerIDToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ExpDataSet expDataSet;
        private System.Windows.Forms.BindingSource csc224AlecCustomersBindingSource;
        private ExpDataSetTableAdapters.csc224AlecCustomersTableAdapter csc224AlecCustomersTableAdapter;
        private ExpDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator csc224AlecCustomersBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton csc224AlecCustomersBindingNavigatorSaveItem;
        private ExpDataSetTableAdapters.csc224AlecStatesTableAdapter csc224AlecStatesTableAdapter;
        private System.Windows.Forms.TextBox customerIDTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.TextBox cityTextBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.TextBox zipCodeTextBox;
        private System.Windows.Forms.BindingSource csc224AlecStatesBindingSource;
        private System.Windows.Forms.ToolStrip fillByCustomerIDToolStrip;
        private System.Windows.Forms.ToolStripLabel customerIDToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox customerIDToolStripTextBox;
        private System.Windows.Forms.ToolStripButton fillByCustomerIDToolStripButton;
        private System.Windows.Forms.ToolStripButton bindingNavigatorCancelItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton fillByAllCustomersToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel stateToolStripLabel;
        private System.Windows.Forms.ToolStripTextBox stateToolStripTextBox;
        private System.Windows.Forms.ToolStripButton stateToolStripButton;
    }
}

