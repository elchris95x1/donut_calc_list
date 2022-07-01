namespace _3333_LaraC_Lab06
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
            this.mainMenuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addDonutTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeDonutTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearAllDonutTypeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.displayDonutTypeCountToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.numberOfDonutsTextbox = new System.Windows.Forms.TextBox();
            this.calculateButton = new System.Windows.Forms.Button();
            this.selectTypeComboBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.displayDonutListButton = new System.Windows.Forms.Button();
            this.clearDonutListButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalDonutsSoldLabel = new System.Windows.Forms.Label();
            this.averageDonutsSoldLabel = new System.Windows.Forms.Label();
            this.totalDonutsSalesLabel = new System.Windows.Forms.Label();
            this.mainMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainMenuStrip
            // 
            this.mainMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.mainMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.mainMenuStrip.Name = "mainMenuStrip";
            this.mainMenuStrip.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.mainMenuStrip.Size = new System.Drawing.Size(346, 24);
            this.mainMenuStrip.TabIndex = 0;
            this.mainMenuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(93, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDonutTypeToolStripMenuItem,
            this.removeDonutTypeToolStripMenuItem,
            this.clearAllDonutTypeToolStripMenuItem,
            this.displayDonutTypeCountToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.toolsToolStripMenuItem.Text = "&Tools";
            // 
            // addDonutTypeToolStripMenuItem
            // 
            this.addDonutTypeToolStripMenuItem.Name = "addDonutTypeToolStripMenuItem";
            this.addDonutTypeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.addDonutTypeToolStripMenuItem.Text = "Add Donut Type";
            this.addDonutTypeToolStripMenuItem.Click += new System.EventHandler(this.addDonutTypeToolStripMenuItem_Click);
            // 
            // removeDonutTypeToolStripMenuItem
            // 
            this.removeDonutTypeToolStripMenuItem.Name = "removeDonutTypeToolStripMenuItem";
            this.removeDonutTypeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.removeDonutTypeToolStripMenuItem.Text = "Remove Donut Type";
            this.removeDonutTypeToolStripMenuItem.Click += new System.EventHandler(this.removeDonutTypeToolStripMenuItem_Click);
            // 
            // clearAllDonutTypeToolStripMenuItem
            // 
            this.clearAllDonutTypeToolStripMenuItem.Name = "clearAllDonutTypeToolStripMenuItem";
            this.clearAllDonutTypeToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.clearAllDonutTypeToolStripMenuItem.Text = "Clear All Donut Type";
            this.clearAllDonutTypeToolStripMenuItem.Click += new System.EventHandler(this.clearAllDonutTypeToolStripMenuItem_Click);
            // 
            // displayDonutTypeCountToolStripMenuItem
            // 
            this.displayDonutTypeCountToolStripMenuItem.Name = "displayDonutTypeCountToolStripMenuItem";
            this.displayDonutTypeCountToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.displayDonutTypeCountToolStripMenuItem.Text = "Display Donut Type Count";
            this.displayDonutTypeCountToolStripMenuItem.Click += new System.EventHandler(this.displayDonutTypeCountToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Number of Donuts";
            // 
            // numberOfDonutsTextbox
            // 
            this.numberOfDonutsTextbox.Location = new System.Drawing.Point(139, 66);
            this.numberOfDonutsTextbox.Name = "numberOfDonutsTextbox";
            this.numberOfDonutsTextbox.Size = new System.Drawing.Size(65, 22);
            this.numberOfDonutsTextbox.TabIndex = 2;
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(234, 63);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(87, 27);
            this.calculateButton.TabIndex = 3;
            this.calculateButton.Text = "&Calculate";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // selectTypeComboBox
            // 
            this.selectTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.selectTypeComboBox.FormattingEnabled = true;
            this.selectTypeComboBox.Location = new System.Drawing.Point(23, 135);
            this.selectTypeComboBox.MaxDropDownItems = 4;
            this.selectTypeComboBox.Name = "selectTypeComboBox";
            this.selectTypeComboBox.Size = new System.Drawing.Size(140, 113);
            this.selectTypeComboBox.Sorted = true;
            this.selectTypeComboBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Select Type of Donut";
            // 
            // displayDonutListButton
            // 
            this.displayDonutListButton.Location = new System.Drawing.Point(14, 422);
            this.displayDonutListButton.Name = "displayDonutListButton";
            this.displayDonutListButton.Size = new System.Drawing.Size(128, 27);
            this.displayDonutListButton.TabIndex = 6;
            this.displayDonutListButton.Text = "&Display Donut List";
            this.displayDonutListButton.UseVisualStyleBackColor = true;
            this.displayDonutListButton.Click += new System.EventHandler(this.displayDonutListButton_Click);
            // 
            // clearDonutListButton
            // 
            this.clearDonutListButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.clearDonutListButton.Location = new System.Drawing.Point(204, 422);
            this.clearDonutListButton.Name = "clearDonutListButton";
            this.clearDonutListButton.Size = new System.Drawing.Size(128, 27);
            this.clearDonutListButton.TabIndex = 7;
            this.clearDonutListButton.Text = "C&lear Donut List";
            this.clearDonutListButton.UseVisualStyleBackColor = true;
            this.clearDonutListButton.Click += new System.EventHandler(this.clearDonutListButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Total of Donuts Sold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 309);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(122, 15);
            this.label4.TabIndex = 9;
            this.label4.Text = "Average Donuts Sold";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 355);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(116, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Total of Donut Sales";
            // 
            // totalDonutsSoldLabel
            // 
            this.totalDonutsSoldLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDonutsSoldLabel.Location = new System.Drawing.Point(191, 258);
            this.totalDonutsSoldLabel.Name = "totalDonutsSoldLabel";
            this.totalDonutsSoldLabel.Size = new System.Drawing.Size(92, 24);
            this.totalDonutsSoldLabel.TabIndex = 11;
            this.totalDonutsSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // averageDonutsSoldLabel
            // 
            this.averageDonutsSoldLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.averageDonutsSoldLabel.Location = new System.Drawing.Point(191, 305);
            this.averageDonutsSoldLabel.Name = "averageDonutsSoldLabel";
            this.averageDonutsSoldLabel.Size = new System.Drawing.Size(92, 24);
            this.averageDonutsSoldLabel.TabIndex = 12;
            this.averageDonutsSoldLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // totalDonutsSalesLabel
            // 
            this.totalDonutsSalesLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.totalDonutsSalesLabel.Location = new System.Drawing.Point(191, 351);
            this.totalDonutsSalesLabel.Name = "totalDonutsSalesLabel";
            this.totalDonutsSalesLabel.Size = new System.Drawing.Size(92, 24);
            this.totalDonutsSalesLabel.TabIndex = 13;
            this.totalDonutsSalesLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AcceptButton = this.calculateButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.clearDonutListButton;
            this.ClientSize = new System.Drawing.Size(346, 463);
            this.Controls.Add(this.totalDonutsSalesLabel);
            this.Controls.Add(this.averageDonutsSoldLabel);
            this.Controls.Add(this.totalDonutsSoldLabel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.clearDonutListButton);
            this.Controls.Add(this.displayDonutListButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.selectTypeComboBox);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.numberOfDonutsTextbox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.mainMenuStrip);
            this.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.mainMenuStrip;
            this.Name = "Form1";
            this.Text = "Donut Calculator";
            this.mainMenuStrip.ResumeLayout(false);
            this.mainMenuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addDonutTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeDonutTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearAllDonutTypeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem displayDonutTypeCountToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox numberOfDonutsTextbox;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.ComboBox selectTypeComboBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button displayDonutListButton;
        private System.Windows.Forms.Button clearDonutListButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalDonutsSoldLabel;
        private System.Windows.Forms.Label averageDonutsSoldLabel;
        private System.Windows.Forms.Label totalDonutsSalesLabel;
    }
}

