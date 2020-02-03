﻿// <copyright file="MainForm.Designer.cs" company="PublicDomain.com">
//     CC0 1.0 Universal (CC0 1.0) - Public Domain Dedication
//     https://creativecommons.org/publicdomain/zero/1.0/legalcode
// </copyright>
// <auto-generated />

namespace SingleClickCopy
{
    partial class MainForm
    {
        /// <summary>
        /// Designer variable used to keep track of non-visual components.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Disposes resources used by the form.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                if (components != null)
                {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        /// <summary>
        /// This method is required for Windows Forms designer support.
        /// Do not change the method contents inside the source code editor. The Forms designer might
        /// not be able to load this method if it was changed manually.
        /// </summary>
        private void InitializeComponent()
        {
        	System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
        	this.menuStrip = new System.Windows.Forms.MenuStrip();
        	this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
        	this.saveAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
        	this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.headquartersPatreoncomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.sourceCodeGithubcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.originalThreadRedditcomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
        	this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
        	this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
        	this.statusStrip = new System.Windows.Forms.StatusStrip();
        	this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
        	this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
        	this.addOrEditTextLabel = new System.Windows.Forms.Label();
        	this.itemTextBox = new System.Windows.Forms.TextBox();
        	this.addButton = new System.Windows.Forms.Button();
        	this.editButton = new System.Windows.Forms.Button();
        	this.clipboardCopyListBox = new System.Windows.Forms.ListBox();
        	this.clearAllButton = new System.Windows.Forms.Button();
        	this.deleteButton = new System.Windows.Forms.Button();
        	this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
        	this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
        	this.menuStrip.SuspendLayout();
        	this.statusStrip.SuspendLayout();
        	this.tableLayoutPanel1.SuspendLayout();
        	this.SuspendLayout();
        	// 
        	// menuStrip
        	// 
        	this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.fileToolStripMenuItem,
        	        	        	this.helpToolStripMenuItem});
        	this.menuStrip.Location = new System.Drawing.Point(0, 0);
        	this.menuStrip.Name = "menuStrip";
        	this.menuStrip.Size = new System.Drawing.Size(284, 24);
        	this.menuStrip.TabIndex = 0;
        	// 
        	// fileToolStripMenuItem
        	// 
        	this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.newToolStripMenuItem,
        	        	        	this.openToolStripMenuItem,
        	        	        	this.toolStripSeparator,
        	        	        	this.saveAsToolStripMenuItem,
        	        	        	this.toolStripSeparator2,
        	        	        	this.exitToolStripMenuItem});
        	this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
        	this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
        	this.fileToolStripMenuItem.Text = "&File";
        	// 
        	// newToolStripMenuItem
        	// 
        	this.newToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripMenuItem.Image")));
        	this.newToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.newToolStripMenuItem.Name = "newToolStripMenuItem";
        	this.newToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
        	this.newToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.newToolStripMenuItem.Text = "&New";
        	this.newToolStripMenuItem.Click += new System.EventHandler(this.OnNewToolStripMenuItemClick);
        	// 
        	// openToolStripMenuItem
        	// 
        	this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
        	this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.openToolStripMenuItem.Name = "openToolStripMenuItem";
        	this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
        	this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.openToolStripMenuItem.Text = "&Open";
        	this.openToolStripMenuItem.Click += new System.EventHandler(this.OnOpenToolStripMenuItemClick);
        	// 
        	// toolStripSeparator
        	// 
        	this.toolStripSeparator.Name = "toolStripSeparator";
        	this.toolStripSeparator.Size = new System.Drawing.Size(149, 6);
        	// 
        	// saveAsToolStripMenuItem
        	// 
        	this.saveAsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saveAsToolStripMenuItem.Image")));
        	this.saveAsToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Magenta;
        	this.saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
        	this.saveAsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
        	this.saveAsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.saveAsToolStripMenuItem.Text = "&Save as";
        	this.saveAsToolStripMenuItem.Click += new System.EventHandler(this.OnSaveAsToolStripMenuItemClick);
        	// 
        	// toolStripSeparator2
        	// 
        	this.toolStripSeparator2.Name = "toolStripSeparator2";
        	this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
        	// 
        	// exitToolStripMenuItem
        	// 
        	this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
        	this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
        	this.exitToolStripMenuItem.Text = "E&xit";
        	this.exitToolStripMenuItem.Click += new System.EventHandler(this.OnExitToolStripMenuItemClick);
        	// 
        	// helpToolStripMenuItem
        	// 
        	this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.headquartersPatreoncomToolStripMenuItem,
        	        	        	this.sourceCodeGithubcomToolStripMenuItem,
        	        	        	this.originalThreadRedditcomToolStripMenuItem,
        	        	        	this.toolStripSeparator3,
        	        	        	this.toolStripSeparator5,
        	        	        	this.aboutToolStripMenuItem});
        	this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
        	this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
        	this.helpToolStripMenuItem.Text = "&Help";
        	// 
        	// headquartersPatreoncomToolStripMenuItem
        	// 
        	this.headquartersPatreoncomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("headquartersPatreoncomToolStripMenuItem.Image")));
        	this.headquartersPatreoncomToolStripMenuItem.Name = "headquartersPatreoncomToolStripMenuItem";
        	this.headquartersPatreoncomToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
        	this.headquartersPatreoncomToolStripMenuItem.Text = "Headquarters @ Patreon.com";
        	this.headquartersPatreoncomToolStripMenuItem.Click += new System.EventHandler(this.OnHeadquartersPatreoncomToolStripMenuItemClick);
        	// 
        	// sourceCodeGithubcomToolStripMenuItem
        	// 
        	this.sourceCodeGithubcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("sourceCodeGithubcomToolStripMenuItem.Image")));
        	this.sourceCodeGithubcomToolStripMenuItem.Name = "sourceCodeGithubcomToolStripMenuItem";
        	this.sourceCodeGithubcomToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
        	this.sourceCodeGithubcomToolStripMenuItem.Text = "Source code @ Github.com";
        	this.sourceCodeGithubcomToolStripMenuItem.Click += new System.EventHandler(this.OnSourceCodeGithubcomToolStripMenuItemClick);
        	// 
        	// originalThreadRedditcomToolStripMenuItem
        	// 
        	this.originalThreadRedditcomToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("originalThreadRedditcomToolStripMenuItem.Image")));
        	this.originalThreadRedditcomToolStripMenuItem.Name = "originalThreadRedditcomToolStripMenuItem";
        	this.originalThreadRedditcomToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
        	this.originalThreadRedditcomToolStripMenuItem.Text = "Original thread @ Reddit.com";
        	this.originalThreadRedditcomToolStripMenuItem.Click += new System.EventHandler(this.OnOriginalThreadRedditcomToolStripMenuItemClick);
        	// 
        	// toolStripSeparator3
        	// 
        	this.toolStripSeparator3.Name = "toolStripSeparator3";
        	this.toolStripSeparator3.Size = new System.Drawing.Size(228, 6);
        	// 
        	// toolStripSeparator5
        	// 
        	this.toolStripSeparator5.Name = "toolStripSeparator5";
        	this.toolStripSeparator5.Size = new System.Drawing.Size(228, 6);
        	// 
        	// aboutToolStripMenuItem
        	// 
        	this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
        	this.aboutToolStripMenuItem.Size = new System.Drawing.Size(231, 22);
        	this.aboutToolStripMenuItem.Text = "&About...";
        	this.aboutToolStripMenuItem.Click += new System.EventHandler(this.OnAboutToolStripMenuItemClick);
        	// 
        	// statusStrip
        	// 
        	this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
        	        	        	this.toolStripStatusLabel});
        	this.statusStrip.Location = new System.Drawing.Point(0, 275);
        	this.statusStrip.Name = "statusStrip";
        	this.statusStrip.Size = new System.Drawing.Size(284, 22);
        	this.statusStrip.TabIndex = 1;
        	// 
        	// toolStripStatusLabel
        	// 
        	this.toolStripStatusLabel.Name = "toolStripStatusLabel";
        	this.toolStripStatusLabel.Size = new System.Drawing.Size(79, 17);
        	this.toolStripStatusLabel.Text = "Items in list: 0";
        	// 
        	// tableLayoutPanel1
        	// 
        	this.tableLayoutPanel1.ColumnCount = 2;
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
        	this.tableLayoutPanel1.Controls.Add(this.addOrEditTextLabel, 0, 0);
        	this.tableLayoutPanel1.Controls.Add(this.itemTextBox, 0, 1);
        	this.tableLayoutPanel1.Controls.Add(this.addButton, 0, 2);
        	this.tableLayoutPanel1.Controls.Add(this.editButton, 1, 2);
        	this.tableLayoutPanel1.Controls.Add(this.clipboardCopyListBox, 0, 3);
        	this.tableLayoutPanel1.Controls.Add(this.clearAllButton, 1, 4);
        	this.tableLayoutPanel1.Controls.Add(this.deleteButton, 0, 4);
        	this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 24);
        	this.tableLayoutPanel1.Name = "tableLayoutPanel1";
        	this.tableLayoutPanel1.RowCount = 5;
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
        	this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
        	this.tableLayoutPanel1.Size = new System.Drawing.Size(284, 251);
        	this.tableLayoutPanel1.TabIndex = 2;
        	// 
        	// addOrEditTextLabel
        	// 
        	this.tableLayoutPanel1.SetColumnSpan(this.addOrEditTextLabel, 2);
        	this.addOrEditTextLabel.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.addOrEditTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.addOrEditTextLabel.Location = new System.Drawing.Point(3, 0);
        	this.addOrEditTextLabel.Name = "addOrEditTextLabel";
        	this.addOrEditTextLabel.Size = new System.Drawing.Size(278, 20);
        	this.addOrEditTextLabel.TabIndex = 0;
        	this.addOrEditTextLabel.Text = "Add or edit text:";
        	this.addOrEditTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
        	// 
        	// itemTextBox
        	// 
        	this.tableLayoutPanel1.SetColumnSpan(this.itemTextBox, 2);
        	this.itemTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.itemTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.itemTextBox.Location = new System.Drawing.Point(3, 23);
        	this.itemTextBox.Name = "itemTextBox";
        	this.itemTextBox.Size = new System.Drawing.Size(278, 22);
        	this.itemTextBox.TabIndex = 1;
        	// 
        	// addButton
        	// 
        	this.addButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.addButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.addButton.ForeColor = System.Drawing.Color.Red;
        	this.addButton.Location = new System.Drawing.Point(3, 48);
        	this.addButton.Margin = new System.Windows.Forms.Padding(3, 0, 1, 0);
        	this.addButton.Name = "addButton";
        	this.addButton.Size = new System.Drawing.Size(138, 30);
        	this.addButton.TabIndex = 3;
        	this.addButton.Text = "&Add";
        	this.addButton.UseVisualStyleBackColor = true;
        	this.addButton.Click += new System.EventHandler(this.OnAddButtonClick);
        	// 
        	// editButton
        	// 
        	this.editButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.editButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
        	this.editButton.ForeColor = System.Drawing.Color.DarkBlue;
        	this.editButton.Location = new System.Drawing.Point(143, 48);
        	this.editButton.Margin = new System.Windows.Forms.Padding(1, 0, 3, 0);
        	this.editButton.Name = "editButton";
        	this.editButton.Size = new System.Drawing.Size(138, 30);
        	this.editButton.TabIndex = 4;
        	this.editButton.Text = "&Edit";
        	this.editButton.UseVisualStyleBackColor = true;
        	this.editButton.Click += new System.EventHandler(this.OnEditButtonClick);
        	// 
        	// clipboardCopyListBox
        	// 
        	this.tableLayoutPanel1.SetColumnSpan(this.clipboardCopyListBox, 2);
        	this.clipboardCopyListBox.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.clipboardCopyListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F);
        	this.clipboardCopyListBox.FormattingEnabled = true;
        	this.clipboardCopyListBox.ItemHeight = 16;
        	this.clipboardCopyListBox.Location = new System.Drawing.Point(3, 81);
        	this.clipboardCopyListBox.Name = "clipboardCopyListBox";
        	this.clipboardCopyListBox.Size = new System.Drawing.Size(278, 142);
        	this.clipboardCopyListBox.TabIndex = 5;
        	this.clipboardCopyListBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.OnClipboardCopyListBoxMouseClick);
        	this.clipboardCopyListBox.SelectedIndexChanged += new System.EventHandler(this.OnClipboardCopyListBoxSelectedIndexChanged);
        	// 
        	// clearAllButton
        	// 
        	this.clearAllButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.clearAllButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
        	this.clearAllButton.Location = new System.Drawing.Point(145, 226);
        	this.clearAllButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        	this.clearAllButton.Name = "clearAllButton";
        	this.clearAllButton.Size = new System.Drawing.Size(136, 25);
        	this.clearAllButton.TabIndex = 2;
        	this.clearAllButton.Text = "&Clear all";
        	this.clearAllButton.UseVisualStyleBackColor = true;
        	this.clearAllButton.Click += new System.EventHandler(this.OnClearAllButtonClick);
        	// 
        	// deleteButton
        	// 
        	this.deleteButton.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.deleteButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
        	this.deleteButton.Location = new System.Drawing.Point(3, 226);
        	this.deleteButton.Margin = new System.Windows.Forms.Padding(3, 0, 3, 0);
        	this.deleteButton.Name = "deleteButton";
        	this.deleteButton.Size = new System.Drawing.Size(136, 25);
        	this.deleteButton.TabIndex = 2;
        	this.deleteButton.Text = "&Delete";
        	this.deleteButton.UseVisualStyleBackColor = true;
        	this.deleteButton.Click += new System.EventHandler(this.OnDeleteButtonClick);
        	// 
        	// openFileDialog
        	// 
        	this.openFileDialog.DefaultExt = "txt";
        	this.openFileDialog.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.openFileDialog.Title = "Open list items to add";
        	// 
        	// saveFileDialog
        	// 
        	this.saveFileDialog.DefaultExt = "txt";
        	this.saveFileDialog.Filter = "TXT Files (*.txt)|*.txt|All files (*.*)|*.*";
        	this.saveFileDialog.Title = "Save list items";
        	// 
        	// MainForm
        	// 
        	this.AcceptButton = this.addButton;
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.ClientSize = new System.Drawing.Size(284, 297);
        	this.Controls.Add(this.tableLayoutPanel1);
        	this.Controls.Add(this.statusStrip);
        	this.Controls.Add(this.menuStrip);
        	this.MainMenuStrip = this.menuStrip;
        	this.Name = "MainForm";
        	this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        	this.Text = "Single-click Copy";
        	this.menuStrip.ResumeLayout(false);
        	this.menuStrip.PerformLayout();
        	this.statusStrip.ResumeLayout(false);
        	this.statusStrip.PerformLayout();
        	this.tableLayoutPanel1.ResumeLayout(false);
        	this.tableLayoutPanel1.PerformLayout();
        	this.ResumeLayout(false);
        	this.PerformLayout();
        }
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem originalThreadRedditcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sourceCodeGithubcomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem headquartersPatreoncomToolStripMenuItem;
        private System.Windows.Forms.ListBox clipboardCopyListBox;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button clearAllButton;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Label addOrEditTextLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem saveAsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip;
    }
}
