﻿namespace WindowsFormsApp1
{
    partial class mainWindow
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.dodajZadanieButton = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.cHnazwaZadania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHid = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHczasPrzygotowania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHminCzasBuforowania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHczasSMD = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cHczasTHT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.usunZadanieButton = new System.Windows.Forms.Button();
            this.wyswietlHarmonogramButton = new System.Windows.Forms.Button();
            this.dodajZadaniaZPlikuButton = new System.Windows.Forms.Button();
            this.usunWszystkieZadaniaButton = new System.Windows.Forms.Button();
            this.edytujZadanieButton = new System.Windows.Forms.Button();
            this.importZadan_label = new System.Windows.Forms.Label();
            this.wyswietlPlanPracyButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // dodajZadanieButton
            // 
            this.dodajZadanieButton.Location = new System.Drawing.Point(46, 63);
            this.dodajZadanieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dodajZadanieButton.Name = "dodajZadanieButton";
            this.dodajZadanieButton.Size = new System.Drawing.Size(189, 74);
            this.dodajZadanieButton.TabIndex = 0;
            this.dodajZadanieButton.Text = "Dodaj zadanie";
            this.dodajZadanieButton.UseVisualStyleBackColor = true;
            this.dodajZadanieButton.Click += new System.EventHandler(this.dodajZadanieButton_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.cHnazwaZadania,
            this.cHid,
            this.cHczasPrzygotowania,
            this.cHminCzasBuforowania,
            this.cHczasSMD,
            this.cHczasTHT});
            this.listView1.GridLines = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.LabelEdit = true;
            this.listView1.LabelWrap = false;
            this.listView1.Location = new System.Drawing.Point(518, 5);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1166, 615);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cHnazwaZadania
            // 
            this.cHnazwaZadania.Tag = "";
            this.cHnazwaZadania.Text = "Nazwa zadania";
            this.cHnazwaZadania.Width = 150;
            // 
            // cHid
            // 
            this.cHid.Text = "ID";
            // 
            // cHczasPrzygotowania
            // 
            this.cHczasPrzygotowania.Text = "Czas przygotowania";
            this.cHczasPrzygotowania.Width = 109;
            // 
            // cHminCzasBuforowania
            // 
            this.cHminCzasBuforowania.Text = "Minimalny czas buforowania";
            this.cHminCzasBuforowania.Width = 145;
            // 
            // cHczasSMD
            // 
            this.cHczasSMD.Text = "Czas realizacji motażu SMD";
            this.cHczasSMD.Width = 146;
            // 
            // cHczasTHT
            // 
            this.cHczasTHT.Text = "Czas realizacji montażu THT";
            this.cHczasTHT.Width = 160;
            // 
            // usunZadanieButton
            // 
            this.usunZadanieButton.Location = new System.Drawing.Point(262, 174);
            this.usunZadanieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usunZadanieButton.Name = "usunZadanieButton";
            this.usunZadanieButton.Size = new System.Drawing.Size(192, 74);
            this.usunZadanieButton.TabIndex = 2;
            this.usunZadanieButton.Text = "Usuń zadanie";
            this.usunZadanieButton.UseVisualStyleBackColor = true;
            this.usunZadanieButton.Visible = false;
            this.usunZadanieButton.Click += new System.EventHandler(this.usunZadanieButton_Click);
            // 
            // wyswietlHarmonogramButton
            // 
            this.wyswietlHarmonogramButton.Location = new System.Drawing.Point(46, 395);
            this.wyswietlHarmonogramButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wyswietlHarmonogramButton.Name = "wyswietlHarmonogramButton";
            this.wyswietlHarmonogramButton.Size = new System.Drawing.Size(408, 80);
            this.wyswietlHarmonogramButton.TabIndex = 3;
            this.wyswietlHarmonogramButton.Text = "Wyświetl harmonogram";
            this.wyswietlHarmonogramButton.UseVisualStyleBackColor = true;
            this.wyswietlHarmonogramButton.Visible = false;
            this.wyswietlHarmonogramButton.Click += new System.EventHandler(this.wyswietlHarmonogramButton_Click);
            // 
            // dodajZadaniaZPlikuButton
            // 
            this.dodajZadaniaZPlikuButton.Location = new System.Drawing.Point(46, 288);
            this.dodajZadaniaZPlikuButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dodajZadaniaZPlikuButton.Name = "dodajZadaniaZPlikuButton";
            this.dodajZadaniaZPlikuButton.Size = new System.Drawing.Size(189, 74);
            this.dodajZadaniaZPlikuButton.TabIndex = 4;
            this.dodajZadaniaZPlikuButton.Text = "Dodaj zadania z pliku";
            this.dodajZadaniaZPlikuButton.UseVisualStyleBackColor = true;
            this.dodajZadaniaZPlikuButton.Click += new System.EventHandler(this.dodajZadaniaZPlikuButton_Click);
            // 
            // usunWszystkieZadaniaButton
            // 
            this.usunWszystkieZadaniaButton.Location = new System.Drawing.Point(46, 174);
            this.usunWszystkieZadaniaButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.usunWszystkieZadaniaButton.Name = "usunWszystkieZadaniaButton";
            this.usunWszystkieZadaniaButton.Size = new System.Drawing.Size(192, 74);
            this.usunWszystkieZadaniaButton.TabIndex = 5;
            this.usunWszystkieZadaniaButton.Text = "Usuń wszystkie zadania";
            this.usunWszystkieZadaniaButton.UseVisualStyleBackColor = true;
            this.usunWszystkieZadaniaButton.Visible = false;
            this.usunWszystkieZadaniaButton.Click += new System.EventHandler(this.usunWszystkieZadaniaButton_Click);
            // 
            // edytujZadanieButton
            // 
            this.edytujZadanieButton.Location = new System.Drawing.Point(262, 63);
            this.edytujZadanieButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.edytujZadanieButton.Name = "edytujZadanieButton";
            this.edytujZadanieButton.Size = new System.Drawing.Size(192, 74);
            this.edytujZadanieButton.TabIndex = 6;
            this.edytujZadanieButton.Text = "Edytuj zadanie";
            this.edytujZadanieButton.UseVisualStyleBackColor = true;
            this.edytujZadanieButton.Visible = false;
            this.edytujZadanieButton.Click += new System.EventHandler(this.edytujZadanieButton_Click);
            // 
            // importZadan_label
            // 
            this.importZadan_label.AutoSize = true;
            this.importZadan_label.Location = new System.Drawing.Point(262, 312);
            this.importZadan_label.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.importZadan_label.Name = "importZadan_label";
            this.importZadan_label.Size = new System.Drawing.Size(0, 20);
            this.importZadan_label.TabIndex = 7;
            // 
            // wyswietlPlanPracyButton
            // 
            this.wyswietlPlanPracyButton.Location = new System.Drawing.Point(46, 506);
            this.wyswietlPlanPracyButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.wyswietlPlanPracyButton.Name = "wyswietlPlanPracyButton";
            this.wyswietlPlanPracyButton.Size = new System.Drawing.Size(408, 80);
            this.wyswietlPlanPracyButton.TabIndex = 8;
            this.wyswietlPlanPracyButton.Text = "Wyświetl plan pracy";
            this.wyswietlPlanPracyButton.UseVisualStyleBackColor = true;
            this.wyswietlPlanPracyButton.Visible = false;
            this.wyswietlPlanPracyButton.Click += new System.EventHandler(this.wyswietlPlanPracyButton_Click);
            // 
            // mainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 631);
            this.Controls.Add(this.wyswietlPlanPracyButton);
            this.Controls.Add(this.importZadan_label);
            this.Controls.Add(this.edytujZadanieButton);
            this.Controls.Add(this.usunWszystkieZadaniaButton);
            this.Controls.Add(this.dodajZadaniaZPlikuButton);
            this.Controls.Add(this.wyswietlHarmonogramButton);
            this.Controls.Add(this.usunZadanieButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dodajZadanieButton);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "mainWindow";
            this.Text = "Optymalizacja planowania montażu płytek drukowanych";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button dodajZadanieButton;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button usunZadanieButton;
        private System.Windows.Forms.Button wyswietlHarmonogramButton;
        private System.Windows.Forms.Button dodajZadaniaZPlikuButton;
        private System.Windows.Forms.Button usunWszystkieZadaniaButton;
        private System.Windows.Forms.Button edytujZadanieButton;
        private System.Windows.Forms.ColumnHeader cHnazwaZadania;
        private System.Windows.Forms.ColumnHeader cHczasPrzygotowania;
        private System.Windows.Forms.ColumnHeader cHminCzasBuforowania;
        private System.Windows.Forms.ColumnHeader cHczasSMD;
        private System.Windows.Forms.ColumnHeader cHczasTHT;
        private System.Windows.Forms.Label importZadan_label;
        private System.Windows.Forms.ColumnHeader cHid;
        private System.Windows.Forms.Button wyswietlPlanPracyButton;
    }
}

