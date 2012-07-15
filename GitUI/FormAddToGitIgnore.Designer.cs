﻿namespace GitUI
{
    partial class FormAddToGitIgnore
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this._NO_TRANSLATE_filesWillBeIgnored = new System.Windows.Forms.Label();
            this.noMatchPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this._NO_TRANSLATE_Preview = new System.Windows.Forms.ListBox();
            this.AddToIngore = new System.Windows.Forms.Button();
            this.FilePattern = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupFilePattern = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1.SuspendLayout();
            this.noMatchPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupFilePattern.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.noMatchPanel);
            this.groupBox1.Controls.Add(this._NO_TRANSLATE_Preview);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(0, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(12, 8, 12, 0);
            this.groupBox1.Size = new System.Drawing.Size(599, 204);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Preview";
            // 
            // _NO_TRANSLATE_filesWillBeIgnored
            // 
            this._NO_TRANSLATE_filesWillBeIgnored.AutoSize = true;
            this._NO_TRANSLATE_filesWillBeIgnored.Dock = System.Windows.Forms.DockStyle.Right;
            this._NO_TRANSLATE_filesWillBeIgnored.Location = new System.Drawing.Point(455, 0);
            this._NO_TRANSLATE_filesWillBeIgnored.Name = "_NO_TRANSLATE_filesWillBeIgnored";
            this._NO_TRANSLATE_filesWillBeIgnored.Size = new System.Drawing.Size(120, 15);
            this._NO_TRANSLATE_filesWillBeIgnored.TabIndex = 11;
            this._NO_TRANSLATE_filesWillBeIgnored.Text = "(matched files count)";
            // 
            // noMatchPanel
            // 
            this.noMatchPanel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.noMatchPanel.BackColor = System.Drawing.Color.White;
            this.noMatchPanel.Controls.Add(this.label2);
            this.noMatchPanel.Controls.Add(this.pictureBox1);
            this.noMatchPanel.Location = new System.Drawing.Point(161, 89);
            this.noMatchPanel.Name = "noMatchPanel";
            this.noMatchPanel.Size = new System.Drawing.Size(233, 26);
            this.noMatchPanel.TabIndex = 2;
            this.noMatchPanel.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(25, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(195, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "No existing files match that pattern.";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GitUI.Properties.Resources.Conflict;
            this.pictureBox1.Location = new System.Drawing.Point(10, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // _NO_TRANSLATE_Preview
            // 
            this._NO_TRANSLATE_Preview.Dock = System.Windows.Forms.DockStyle.Fill;
            this._NO_TRANSLATE_Preview.FormattingEnabled = true;
            this._NO_TRANSLATE_Preview.ItemHeight = 15;
            this._NO_TRANSLATE_Preview.Location = new System.Drawing.Point(12, 24);
            this._NO_TRANSLATE_Preview.Name = "_NO_TRANSLATE_Preview";
            this._NO_TRANSLATE_Preview.Size = new System.Drawing.Size(575, 180);
            this._NO_TRANSLATE_Preview.TabIndex = 1;
            // 
            // AddToIngore
            // 
            this.AddToIngore.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.AddToIngore.Location = new System.Drawing.Point(335, 7);
            this.AddToIngore.Name = "AddToIngore";
            this.AddToIngore.Size = new System.Drawing.Size(110, 25);
            this.AddToIngore.TabIndex = 7;
            this.AddToIngore.Text = "Ignore";
            this.AddToIngore.UseVisualStyleBackColor = true;
            this.AddToIngore.Click += new System.EventHandler(this.AddToIngoreClick);
            // 
            // FilePattern
            // 
            this.FilePattern.AcceptsReturn = true;
            this.FilePattern.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FilePattern.Location = new System.Drawing.Point(12, 19);
            this.FilePattern.Multiline = true;
            this.FilePattern.Name = "FilePattern";
            this.FilePattern.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.FilePattern.Size = new System.Drawing.Size(575, 71);
            this.FilePattern.TabIndex = 6;
            this.FilePattern.WordWrap = false;
            this.FilePattern.TextChanged += new System.EventHandler(this.FilePattern_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCancel);
            this.panel1.Controls.Add(this.AddToIngore);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(599, 44);
            this.panel1.TabIndex = 10;
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(467, 7);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(110, 25);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupFilePattern
            // 
            this.groupFilePattern.Controls.Add(this.FilePattern);
            this.groupFilePattern.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupFilePattern.Location = new System.Drawing.Point(0, 0);
            this.groupFilePattern.Name = "groupFilePattern";
            this.groupFilePattern.Padding = new System.Windows.Forms.Padding(12, 3, 12, 3);
            this.groupFilePattern.Size = new System.Drawing.Size(599, 93);
            this.groupFilePattern.TabIndex = 11;
            this.groupFilePattern.TabStop = false;
            this.groupFilePattern.Text = "Enter a file pattern to ignore:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._NO_TRANSLATE_filesWillBeIgnored);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(12, 181);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(575, 23);
            this.panel2.TabIndex = 12;
            // 
            // FormAddToGitIgnore
            // 
            this.AcceptButton = this.AddToIngore;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(599, 341);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupFilePattern);
            this.Controls.Add(this.panel1);
            this.MinimizeBox = false;
            this.Name = "FormAddToGitIgnore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Add files(s) to .gitIgnore";
            this.groupBox1.ResumeLayout(false);
            this.noMatchPanel.ResumeLayout(false);
            this.noMatchPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupFilePattern.ResumeLayout(false);
            this.groupFilePattern.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox _NO_TRANSLATE_Preview;
        private System.Windows.Forms.Button AddToIngore;
        private System.Windows.Forms.TextBox FilePattern;
        private System.Windows.Forms.Panel noMatchPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label _NO_TRANSLATE_filesWillBeIgnored;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupFilePattern;
        private System.Windows.Forms.Panel panel2;

    }
}