﻿namespace WindowsFormsApp1
{
    partial class Form3
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
            this.zamknij_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cmax_label = new System.Windows.Forms.Label();
            this.cmax_textbox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // zamknij_button
            // 
            this.zamknij_button.Location = new System.Drawing.Point(639, 169);
            this.zamknij_button.Name = "zamknij_button";
            this.zamknij_button.Size = new System.Drawing.Size(124, 43);
            this.zamknij_button.TabIndex = 0;
            this.zamknij_button.Text = "Zamknij";
            this.zamknij_button.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.zamknij_button.UseVisualStyleBackColor = true;
            this.zamknij_button.UseWaitCursor = true;
            this.zamknij_button.Click += new System.EventHandler(this.zamknij_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(775, 112);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBox1_Paint);
            // 
            // Cmax_label
            // 
            this.Cmax_label.AutoSize = true;
            this.Cmax_label.Location = new System.Drawing.Point(9, 169);
            this.Cmax_label.Name = "Cmax_label";
            this.Cmax_label.Size = new System.Drawing.Size(33, 13);
            this.Cmax_label.TabIndex = 2;
            this.Cmax_label.Text = "Cmax";
            // 
            // cmax_textbox
            // 
            this.cmax_textbox.Enabled = false;
            this.cmax_textbox.Location = new System.Drawing.Point(52, 166);
            this.cmax_textbox.Name = "cmax_textbox";
            this.cmax_textbox.Size = new System.Drawing.Size(100, 20);
            this.cmax_textbox.TabIndex = 3;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 232);
            this.Controls.Add(this.cmax_textbox);
            this.Controls.Add(this.Cmax_label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.zamknij_button);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button zamknij_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Cmax_label;
        private System.Windows.Forms.TextBox cmax_textbox;
    }
}