namespace WindowsFormsApp1
{
    partial class Form1
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
            this.SuspendLayout();
            // 
            // dodajZadanieButton
            // 
            this.dodajZadanieButton.Location = new System.Drawing.Point(31, 41);
            this.dodajZadanieButton.Name = "dodajZadanieButton";
            this.dodajZadanieButton.Size = new System.Drawing.Size(126, 48);
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
            this.listView1.Location = new System.Drawing.Point(345, 3);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(707, 401);
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // cHnazwaZadania
            // 
            this.cHnazwaZadania.Tag = "";
            this.cHnazwaZadania.Text = "Nazwa zadania";
            this.cHnazwaZadania.Width = 86;
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
            this.cHczasTHT.Width = 150;
            // 
            // usunZadanieButton
            // 
            this.usunZadanieButton.Location = new System.Drawing.Point(175, 113);
            this.usunZadanieButton.Name = "usunZadanieButton";
            this.usunZadanieButton.Size = new System.Drawing.Size(128, 48);
            this.usunZadanieButton.TabIndex = 2;
            this.usunZadanieButton.Text = "Usuń zadanie";
            this.usunZadanieButton.UseVisualStyleBackColor = true;
            this.usunZadanieButton.Visible = false;
            this.usunZadanieButton.Click += new System.EventHandler(this.usunZadanieButton_Click);
            // 
            // wyswietlHarmonogramButton
            // 
            this.wyswietlHarmonogramButton.Location = new System.Drawing.Point(31, 290);
            this.wyswietlHarmonogramButton.Name = "wyswietlHarmonogramButton";
            this.wyswietlHarmonogramButton.Size = new System.Drawing.Size(272, 52);
            this.wyswietlHarmonogramButton.TabIndex = 3;
            this.wyswietlHarmonogramButton.Text = "Wyświetl harmonogram";
            this.wyswietlHarmonogramButton.UseVisualStyleBackColor = true;
            this.wyswietlHarmonogramButton.Visible = false;
            this.wyswietlHarmonogramButton.Click += new System.EventHandler(this.wyswietlHarmonogramButton_Click);
            // 
            // dodajZadaniaZPlikuButton
            // 
            this.dodajZadaniaZPlikuButton.Location = new System.Drawing.Point(31, 187);
            this.dodajZadaniaZPlikuButton.Name = "dodajZadaniaZPlikuButton";
            this.dodajZadaniaZPlikuButton.Size = new System.Drawing.Size(126, 48);
            this.dodajZadaniaZPlikuButton.TabIndex = 4;
            this.dodajZadaniaZPlikuButton.Text = "Dodaj zadania z pliku";
            this.dodajZadaniaZPlikuButton.UseVisualStyleBackColor = true;
            this.dodajZadaniaZPlikuButton.Click += new System.EventHandler(this.dodajZadaniaZPlikuButton_Click);
            // 
            // usunWszystkieZadaniaButton
            // 
            this.usunWszystkieZadaniaButton.Location = new System.Drawing.Point(31, 113);
            this.usunWszystkieZadaniaButton.Name = "usunWszystkieZadaniaButton";
            this.usunWszystkieZadaniaButton.Size = new System.Drawing.Size(128, 48);
            this.usunWszystkieZadaniaButton.TabIndex = 5;
            this.usunWszystkieZadaniaButton.Text = "Usuń wszystkie zadania";
            this.usunWszystkieZadaniaButton.UseVisualStyleBackColor = true;
            this.usunWszystkieZadaniaButton.Visible = false;
            this.usunWszystkieZadaniaButton.Click += new System.EventHandler(this.usunWszystkieZadaniaButton_Click);
            // 
            // edytujZadanieButton
            // 
            this.edytujZadanieButton.Location = new System.Drawing.Point(175, 41);
            this.edytujZadanieButton.Name = "edytujZadanieButton";
            this.edytujZadanieButton.Size = new System.Drawing.Size(128, 48);
            this.edytujZadanieButton.TabIndex = 6;
            this.edytujZadanieButton.Text = "Edytuj zadanie";
            this.edytujZadanieButton.UseVisualStyleBackColor = true;
            this.edytujZadanieButton.Visible = false;
            this.edytujZadanieButton.Click += new System.EventHandler(this.edytujZadanieButton_Click);
            // 
            // importZadan_label
            // 
            this.importZadan_label.AutoSize = true;
            this.importZadan_label.Location = new System.Drawing.Point(175, 203);
            this.importZadan_label.Name = "importZadan_label";
            this.importZadan_label.Size = new System.Drawing.Size(0, 13);
            this.importZadan_label.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 408);
            this.Controls.Add(this.importZadan_label);
            this.Controls.Add(this.edytujZadanieButton);
            this.Controls.Add(this.usunWszystkieZadaniaButton);
            this.Controls.Add(this.dodajZadaniaZPlikuButton);
            this.Controls.Add(this.wyswietlHarmonogramButton);
            this.Controls.Add(this.usunZadanieButton);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dodajZadanieButton);
            this.Name = "Form1";
            this.Text = "Szybki Projekt Na Optymalizacje";
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
    }
}

