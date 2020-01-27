namespace WindowsFormsApp1
{
    partial class addEditWindow
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
            this.dodajZadanie_button.Location = new System.Drawing.Point(192, 409);
            this.dodajZadanie_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dodajZadanie_button.Name = "dodajZadanie_button";
            this.dodajZadanie_button.Size = new System.Drawing.Size(156, 74);
            this.dodajZadanie_button.TabIndex = 0;
            this.dodajZadanie_button.Text = "Dodaj zadanie";
            this.dodajZadanie_button.UseVisualStyleBackColor = true;
            this.dodajZadanie_button.Click += new System.EventHandler(this.dodajZadanie_button_Click);
            // 
            // anuluj_button
            // 
            this.anuluj_button.Location = new System.Drawing.Point(495, 409);
            this.anuluj_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.anuluj_button.Name = "anuluj_button";
            this.anuluj_button.Size = new System.Drawing.Size(156, 74);
            this.anuluj_button.TabIndex = 1;
            this.anuluj_button.Text = "Anuluj";
            this.anuluj_button.UseVisualStyleBackColor = true;
            this.anuluj_button.Click += new System.EventHandler(this.anuluj_button_Click);
            // 
            // label1
            // 
            this.label1.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(81, 140);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Czas przygotowania (r)";
            // 
            // r_textBox
            // 
            this.r_textBox.Location = new System.Drawing.Point(260, 140);
            this.r_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.r_textBox.Name = "r_textBox";
            this.r_textBox.Size = new System.Drawing.Size(178, 26);
            this.r_textBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 200);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Czas buforowania SMD-THT (d)";
            // 
            // label3
            // 
            this.label3.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(183, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Czas montażu SMD (p1)";
            // 
            // label4
            // 
            this.label4.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(69, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(177, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Czas montażu THT (p2)";
            // 
            // d_textBox
            // 
            this.d_textBox.Location = new System.Drawing.Point(260, 194);
            this.d_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.d_textBox.Name = "d_textBox";
            this.d_textBox.Size = new System.Drawing.Size(178, 26);
            this.d_textBox.TabIndex = 7;
            // 
            // p1_textBox
            // 
            this.p1_textBox.Location = new System.Drawing.Point(260, 258);
            this.p1_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p1_textBox.Name = "p1_textBox";
            this.p1_textBox.Size = new System.Drawing.Size(178, 26);
            this.p1_textBox.TabIndex = 8;
            // 
            // p2_textBox
            // 
            this.p2_textBox.Location = new System.Drawing.Point(260, 318);
            this.p2_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.p2_textBox.Name = "p2_textBox";
            this.p2_textBox.Size = new System.Drawing.Size(178, 26);
            this.p2_textBox.TabIndex = 9;
            // 
            // nazwa_textBox
            // 
            this.nazwa_textBox.Location = new System.Drawing.Point(260, 88);
            this.nazwa_textBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nazwa_textBox.Name = "nazwa_textBox";
            this.nazwa_textBox.Size = new System.Drawing.Size(178, 26);
            this.nazwa_textBox.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(188, 92);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nazwa";
            // 
            // nazwa_komunikat_label
            // 
            this.nazwa_komunikat_label.AutoSize = true;
            this.nazwa_komunikat_label.Location = new System.Drawing.Point(476, 92);
            this.nazwa_komunikat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.nazwa_komunikat_label.Name = "nazwa_komunikat_label";
            this.nazwa_komunikat_label.Size = new System.Drawing.Size(0, 20);
            this.nazwa_komunikat_label.TabIndex = 12;
            this.nazwa_komunikat_label.Visible = false;
            // 
            // r_komunikat_label
            // 
            this.r_komunikat_label.AutoSize = true;
            this.r_komunikat_label.Location = new System.Drawing.Point(476, 145);
            this.r_komunikat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.r_komunikat_label.Name = "r_komunikat_label";
            this.r_komunikat_label.Size = new System.Drawing.Size(0, 20);
            this.r_komunikat_label.TabIndex = 13;
            this.r_komunikat_label.Tag = "";
            this.r_komunikat_label.Visible = false;
            // 
            // d_komunikat_label
            // 
            this.d_komunikat_label.AutoSize = true;
            this.d_komunikat_label.Location = new System.Drawing.Point(476, 200);
            this.d_komunikat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.d_komunikat_label.Name = "d_komunikat_label";
            this.d_komunikat_label.Size = new System.Drawing.Size(0, 20);
            this.d_komunikat_label.TabIndex = 14;
            this.d_komunikat_label.Tag = "";
            this.d_komunikat_label.Visible = false;
            // 
            // p1_komunikat_label
            // 
            this.p1_komunikat_label.AutoSize = true;
            this.p1_komunikat_label.Location = new System.Drawing.Point(476, 263);
            this.p1_komunikat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p1_komunikat_label.Name = "p1_komunikat_label";
            this.p1_komunikat_label.Size = new System.Drawing.Size(0, 20);
            this.p1_komunikat_label.TabIndex = 15;
            this.p1_komunikat_label.Visible = false;
            // 
            // p2_komunikat_label
            // 
            this.p2_komunikat_label.AutoSize = true;
            this.p2_komunikat_label.Location = new System.Drawing.Point(476, 323);
            this.p2_komunikat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.p2_komunikat_label.Name = "p2_komunikat_label";
            this.p2_komunikat_label.Size = new System.Drawing.Size(0, 20);
            this.p2_komunikat_label.TabIndex = 16;
            this.p2_komunikat_label.Visible = false;
            // 
            // id_textbox
            // 
            this.id_textbox.Location = new System.Drawing.Point(260, 35);
            this.id_textbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.id_textbox.Name = "id_textbox";
            this.id_textbox.Size = new System.Drawing.Size(178, 26);
            this.id_textbox.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 40);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 17;
            this.label6.Text = "ID";
            // 
            // id_komunikat_label
            // 
            this.id_komunikat_label.AccessibleRole = System.Windows.Forms.AccessibleRole.RowHeader;
            this.id_komunikat_label.AutoSize = true;
            this.id_komunikat_label.Location = new System.Drawing.Point(476, 40);
            this.id_komunikat_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.id_komunikat_label.Name = "id_komunikat_label";
            this.id_komunikat_label.Size = new System.Drawing.Size(0, 20);
            this.id_komunikat_label.TabIndex = 19;
            // 
            // addEditWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 504);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(930, 560);
            this.Name = "addEditWindow";
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