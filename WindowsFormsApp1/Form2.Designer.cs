namespace WindowsFormsApp1
{
    partial class Form2
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
            this.dodajZadanie_button = new System.Windows.Forms.Button();
            this.anuluj_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.r_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.d_textBox = new System.Windows.Forms.TextBox();
            this.p1_textBox = new System.Windows.Forms.TextBox();
            this.p2_textBox = new System.Windows.Forms.TextBox();
            this.nazwa_textBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.nazwa_komunikat_label = new System.Windows.Forms.Label();
            this.r_komunikat_label = new System.Windows.Forms.Label();
            this.d_komunikat_label = new System.Windows.Forms.Label();
            this.p1_komunikat_label = new System.Windows.Forms.Label();
            this.p2_komunikat_label = new System.Windows.Forms.Label();
            this.id_textbox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.id_komunikat_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dodajZadanie_button
            // 
            this.dodajZadanie_button.Location = new System.Drawing.Point(99, 266);
            this.dodajZadanie_button.Name = "dodajZadanie_button";
            this.dodajZadanie_button.Size = new System.Drawing.Size(104, 48);
            this.dodajZadanie_button.TabIndex = 0;
            this.dodajZadanie_button.Text = "Dodaj zadanie";
            this.dodajZadanie_button.UseVisualStyleBackColor = true;
            this.dodajZadanie_button.Click += new System.EventHandler(this.dodajZadanie_button_Click);
            // 
            // anuluj_button
            // 
            this.anuluj_button.Location = new System.Drawing.Point(304, 266);
            this.anuluj_button.Name = "anuluj_button";
            this.anuluj_button.Size = new System.Drawing.Size(104, 48);
            this.anuluj_button.TabIndex = 1;
            this.anuluj_button.Text = "Anuluj";
            this.anuluj_button.UseVisualStyleBackColor = true;
            this.anuluj_button.Click += new System.EventHandler(this.anuluj_button_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "r";
            // 
            // r_textBox
            // 
            this.r_textBox.Location = new System.Drawing.Point(55, 89);
            this.r_textBox.Name = "r_textBox";
            this.r_textBox.Size = new System.Drawing.Size(120, 20);
            this.r_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "d";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(30, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "p1";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(30, 213);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "p2";
            // 
            // d_textBox
            // 
            this.d_textBox.Location = new System.Drawing.Point(55, 130);
            this.d_textBox.Name = "d_textBox";
            this.d_textBox.Size = new System.Drawing.Size(120, 20);
            this.d_textBox.TabIndex = 7;
            // 
            // p1_textBox
            // 
            this.p1_textBox.Location = new System.Drawing.Point(55, 171);
            this.p1_textBox.Name = "p1_textBox";
            this.p1_textBox.Size = new System.Drawing.Size(120, 20);
            this.p1_textBox.TabIndex = 8;
            // 
            // p2_textBox
            // 
            this.p2_textBox.Location = new System.Drawing.Point(55, 210);
            this.p2_textBox.Name = "p2_textBox";
            this.p2_textBox.Size = new System.Drawing.Size(120, 20);
            this.p2_textBox.TabIndex = 9;
            // 
            // nazwa_textBox
            // 
            this.nazwa_textBox.Location = new System.Drawing.Point(55, 53);
            this.nazwa_textBox.Name = "nazwa_textBox";
            this.nazwa_textBox.Size = new System.Drawing.Size(120, 20);
            this.nazwa_textBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 56);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nazwa";
            // 
            // nazwa_komunikat_label
            // 
            this.nazwa_komunikat_label.AutoSize = true;
            this.nazwa_komunikat_label.Location = new System.Drawing.Point(203, 56);
            this.nazwa_komunikat_label.Name = "nazwa_komunikat_label";
            this.nazwa_komunikat_label.Size = new System.Drawing.Size(0, 13);
            this.nazwa_komunikat_label.TabIndex = 12;
            this.nazwa_komunikat_label.Visible = false;
            // 
            // r_komunikat_label
            // 
            this.r_komunikat_label.AutoSize = true;
            this.r_komunikat_label.Location = new System.Drawing.Point(206, 91);
            this.r_komunikat_label.Name = "r_komunikat_label";
            this.r_komunikat_label.Size = new System.Drawing.Size(0, 13);
            this.r_komunikat_label.TabIndex = 13;
            this.r_komunikat_label.Tag = "";
            this.r_komunikat_label.Visible = false;
            // 
            // d_komunikat_label
            // 
            this.d_komunikat_label.AutoSize = true;
            this.d_komunikat_label.Location = new System.Drawing.Point(203, 133);
            this.d_komunikat_label.Name = "d_komunikat_label";
            this.d_komunikat_label.Size = new System.Drawing.Size(0, 13);
            this.d_komunikat_label.TabIndex = 14;
            this.d_komunikat_label.Tag = "";
            this.d_komunikat_label.Visible = false;
            // 
            // p1_komunikat_label
            // 
            this.p1_komunikat_label.AutoSize = true;
            this.p1_komunikat_label.Location = new System.Drawing.Point(203, 171);
            this.p1_komunikat_label.Name = "p1_komunikat_label";
            this.p1_komunikat_label.Size = new System.Drawing.Size(0, 13);
            this.p1_komunikat_label.TabIndex = 15;
            this.p1_komunikat_label.Visible = false;
            // 
            // p2_komunikat_label
            // 
            this.p2_komunikat_label.AutoSize = true;
            this.p2_komunikat_label.Location = new System.Drawing.Point(203, 210);
            this.p2_komunikat_label.Name = "p2_komunikat_label";
            this.p2_komunikat_label.Size = new System.Drawing.Size(0, 13);
            this.p2_komunikat_label.TabIndex = 16;
            this.p2_komunikat_label.Visible = false;
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(54, 16);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(120, 20);
            this.id_textbox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(30, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // id_komunikat_label
            // 
            this.id_komunikat_label.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.id_komunikat_label.AutoSize = true;
            this.id_komunikat_label.Location = new System.Drawing.Point(203, 19);
            this.id_komunikat_label.Name = "id_komunikat_label";
            this.id_komunikat_label.Size = new System.Drawing.Size(0, 13);
            this.id_komunikat_label.TabIndex = 19;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 340);
            this.Controls.Add(this.id_komunikat_label);
            this.Controls.Add(this.id_textbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.p2_komunikat_label);
            this.Controls.Add(this.p1_komunikat_label);
            this.Controls.Add(this.d_komunikat_label);
            this.Controls.Add(this.r_komunikat_label);
            this.Controls.Add(this.nazwa_komunikat_label);
            this.Controls.Add(this.nazwa_textBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.p2_textBox);
            this.Controls.Add(this.p1_textBox);
            this.Controls.Add(this.d_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.r_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.anuluj_button);
            this.Controls.Add(this.dodajZadanie_button);
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZadanie_button;
        private System.Windows.Forms.Button anuluj_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox r_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox d_textBox;
        private System.Windows.Forms.TextBox p1_textBox;
        private System.Windows.Forms.TextBox p2_textBox;
        private System.Windows.Forms.TextBox nazwa_textBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label nazwa_komunikat_label;
        private System.Windows.Forms.Label r_komunikat_label;
        private System.Windows.Forms.Label d_komunikat_label;
        private System.Windows.Forms.Label p1_komunikat_label;
        private System.Windows.Forms.Label p2_komunikat_label;
        private System.Windows.Forms.TextBox id_textbox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label id_komunikat_label;
    }
}