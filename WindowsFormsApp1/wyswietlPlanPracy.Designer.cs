namespace WindowsFormsApp1
{
    partial class wyswietlPlanPracy
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
            this.planZamowien_button = new System.Windows.Forms.Button();
            this.planPracySMD_button = new System.Windows.Forms.Button();
            this.planPracyTHT_button = new System.Windows.Forms.Button();
            this.zamknij_button = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // planZamowien_button
            // 
            this.planZamowien_button.Location = new System.Drawing.Point(12, 12);
            this.planZamowien_button.Name = "planZamowien_button";
            this.planZamowien_button.Size = new System.Drawing.Size(133, 50);
            this.planZamowien_button.TabIndex = 0;
            this.planZamowien_button.Text = "Plan zamówień";
            this.planZamowien_button.UseVisualStyleBackColor = true;
            this.planZamowien_button.Click += new System.EventHandler(this.planZamowien_button_Click);
            // 
            // planPracySMD_button
            // 
            this.planPracySMD_button.Location = new System.Drawing.Point(12, 83);
            this.planPracySMD_button.Name = "planPracySMD_button";
            this.planPracySMD_button.Size = new System.Drawing.Size(133, 50);
            this.planPracySMD_button.TabIndex = 1;
            this.planPracySMD_button.Text = "Plan pracy linii SMD";
            this.planPracySMD_button.UseVisualStyleBackColor = true;
            this.planPracySMD_button.Click += new System.EventHandler(this.planPracySMD_button_Click);
            // 
            // planPracyTHT_button
            // 
            this.planPracyTHT_button.Location = new System.Drawing.Point(12, 152);
            this.planPracyTHT_button.Name = "planPracyTHT_button";
            this.planPracyTHT_button.Size = new System.Drawing.Size(133, 48);
            this.planPracyTHT_button.TabIndex = 2;
            this.planPracyTHT_button.Text = "Plan pracy monterów THT";
            this.planPracyTHT_button.UseVisualStyleBackColor = true;
            this.planPracyTHT_button.Click += new System.EventHandler(this.planPracyTHT_button_Click);
            // 
            // zamknij_button
            // 
            this.zamknij_button.Location = new System.Drawing.Point(12, 279);
            this.zamknij_button.Name = "zamknij_button";
            this.zamknij_button.Size = new System.Drawing.Size(133, 48);
            this.zamknij_button.TabIndex = 3;
            this.zamknij_button.Text = "Zamknij";
            this.zamknij_button.UseVisualStyleBackColor = true;
            this.zamknij_button.Click += new System.EventHandler(this.zamknij_button_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(169, 13);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(610, 314);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // wyswietlPlanPracy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 335);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.zamknij_button);
            this.Controls.Add(this.planPracyTHT_button);
            this.Controls.Add(this.planPracySMD_button);
            this.Controls.Add(this.planZamowien_button);
            this.Name = "wyswietlPlanPracy";
            this.Text = "wyswietlPlanPracy";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button planZamowien_button;
        private System.Windows.Forms.Button planPracySMD_button;
        private System.Windows.Forms.Button planPracyTHT_button;
        private System.Windows.Forms.Button zamknij_button;
        private System.Windows.Forms.ListView listView1;
    }
}