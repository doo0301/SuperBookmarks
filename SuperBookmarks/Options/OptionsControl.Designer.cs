﻿namespace Konamiman.SuperBookmarks
{
    partial class OptionsControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OptionsControl));
            this.chkDeletingLineDeletesBookmark = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rbInTopLevel = new System.Windows.Forms.RadioButton();
            this.rbInEdit = new System.Windows.Forms.RadioButton();
            this.pnlRequiresRestaring = new System.Windows.Forms.Panel();
            this.lblInfoMessage = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pnlRequiresRestaring.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // chkDeletingLineDeletesBookmark
            // 
            this.chkDeletingLineDeletesBookmark.AutoSize = true;
            this.chkDeletingLineDeletesBookmark.Location = new System.Drawing.Point(25, 29);
            this.chkDeletingLineDeletesBookmark.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.chkDeletingLineDeletesBookmark.Name = "chkDeletingLineDeletesBookmark";
            this.chkDeletingLineDeletesBookmark.Size = new System.Drawing.Size(566, 36);
            this.chkDeletingLineDeletesBookmark.TabIndex = 1;
            this.chkDeletingLineDeletesBookmark.Text = "Deleting a line deletes the line bookmark";
            this.chkDeletingLineDeletesBookmark.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbInEdit);
            this.panel1.Controls.Add(this.rbInTopLevel);
            this.panel1.Location = new System.Drawing.Point(25, 140);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(690, 164);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 32);
            this.label1.TabIndex = 3;
            this.label1.Text = "Show commands in";
            // 
            // rbInTopLevel
            // 
            this.rbInTopLevel.AutoSize = true;
            this.rbInTopLevel.Location = new System.Drawing.Point(3, 45);
            this.rbInTopLevel.Name = "rbInTopLevel";
            this.rbInTopLevel.Size = new System.Drawing.Size(507, 36);
            this.rbInTopLevel.TabIndex = 0;
            this.rbInTopLevel.TabStop = true;
            this.rbInTopLevel.Text = "A \"SuperBookmarks\" top level menu";
            this.rbInTopLevel.UseVisualStyleBackColor = true;
            // 
            // rbInEdit
            // 
            this.rbInEdit.AutoSize = true;
            this.rbInEdit.Location = new System.Drawing.Point(3, 4);
            this.rbInEdit.Name = "rbInEdit";
            this.rbInEdit.Size = new System.Drawing.Size(671, 36);
            this.rbInEdit.TabIndex = 1;
            this.rbInEdit.TabStop = true;
            this.rbInEdit.Text = "A \"SuperBookmarks\" submenu in the \"Edit\" menu";
            this.rbInEdit.UseVisualStyleBackColor = true;
            // 
            // pnlRequiresRestaring
            // 
            this.pnlRequiresRestaring.Controls.Add(this.lblInfoMessage);
            this.pnlRequiresRestaring.Controls.Add(this.pictureBox1);
            this.pnlRequiresRestaring.Location = new System.Drawing.Point(28, 224);
            this.pnlRequiresRestaring.Margin = new System.Windows.Forms.Padding(5);
            this.pnlRequiresRestaring.Name = "pnlRequiresRestaring";
            this.pnlRequiresRestaring.Size = new System.Drawing.Size(682, 59);
            this.pnlRequiresRestaring.TabIndex = 8;
            this.pnlRequiresRestaring.Visible = false;
            // 
            // lblInfoMessage
            // 
            this.lblInfoMessage.AutoSize = true;
            this.lblInfoMessage.Location = new System.Drawing.Point(39, 5);
            this.lblInfoMessage.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblInfoMessage.Name = "lblInfoMessage";
            this.lblInfoMessage.Size = new System.Drawing.Size(599, 32);
            this.lblInfoMessage.TabIndex = 1;
            this.lblInfoMessage.Text = "Requires restarting Visual Studio to take effect";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(7, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(52, 48);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // OptionsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlRequiresRestaring);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.chkDeletingLineDeletesBookmark);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "OptionsControl";
            this.Size = new System.Drawing.Size(726, 405);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlRequiresRestaring.ResumeLayout(false);
            this.pnlRequiresRestaring.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkDeletingLineDeletesBookmark;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbInEdit;
        private System.Windows.Forms.RadioButton rbInTopLevel;
        private System.Windows.Forms.Panel pnlRequiresRestaring;
        private System.Windows.Forms.Label lblInfoMessage;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}