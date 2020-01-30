namespace WindowsFormsApp1
{
    partial class showWorkPlanWindow
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
            this.planZamowienListView = new System.Windows.Forms.ListView();
            this.zamowieniaLV_nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zamowieniaLV_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zamowieniaLV_maxCzasRozpoczecia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.zamowieniaLV_czasTrwaniaZamawiania = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.planPracySMDListView = new System.Windows.Forms.ListView();
            this.smdLV_nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smdLV_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smdLV_terminRozpoczecia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.smdLV_terminZakonczenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.planPracyTHTListView = new System.Windows.Forms.ListView();
            this.thtLV_nazwa = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thtLV_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thtLV_terminRozpoczecia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.thtLV_terminZakonczenia = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // planZamowien_button
            // 
            this.planZamowien_button.Location = new System.Drawing.Point(18, 18);
            this.planZamowien_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planZamowien_button.Name = "planZamowien_button";
            this.planZamowien_button.Size = new System.Drawing.Size(200, 77);
            this.planZamowien_button.TabIndex = 0;
            this.planZamowien_button.Text = "Plan zamówień materiałów";
            this.planZamowien_button.UseVisualStyleBackColor = true;
            this.planZamowien_button.Click += new System.EventHandler(this.planZamowien_button_Click);
            // 
            // planPracySMD_button
            // 
            this.planPracySMD_button.Location = new System.Drawing.Point(18, 128);
            this.planPracySMD_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planPracySMD_button.Name = "planPracySMD_button";
            this.planPracySMD_button.Size = new System.Drawing.Size(200, 77);
            this.planPracySMD_button.TabIndex = 1;
            this.planPracySMD_button.Text = "Plan pracy linii SMD";
            this.planPracySMD_button.UseVisualStyleBackColor = true;
            this.planPracySMD_button.Click += new System.EventHandler(this.planPracySMD_button_Click);
            // 
            // planPracyTHT_button
            // 
            this.planPracyTHT_button.Location = new System.Drawing.Point(18, 234);
            this.planPracyTHT_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planPracyTHT_button.Name = "planPracyTHT_button";
            this.planPracyTHT_button.Size = new System.Drawing.Size(200, 74);
            this.planPracyTHT_button.TabIndex = 2;
            this.planPracyTHT_button.Text = "Plan pracy monterów THT";
            this.planPracyTHT_button.UseVisualStyleBackColor = true;
            this.planPracyTHT_button.Click += new System.EventHandler(this.planPracyTHT_button_Click);
            // 
            // zamknij_button
            // 
            this.zamknij_button.Location = new System.Drawing.Point(18, 448);
            this.zamknij_button.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.zamknij_button.Name = "zamknij_button";
            this.zamknij_button.Size = new System.Drawing.Size(200, 74);
            this.zamknij_button.TabIndex = 3;
            this.zamknij_button.Text = "Zamknij";
            this.zamknij_button.UseVisualStyleBackColor = true;
            this.zamknij_button.Click += new System.EventHandler(this.zamknij_button_Click);
            // 
            // planZamowienListView
            // 
            this.planZamowienListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.zamowieniaLV_nazwa,
            this.zamowieniaLV_ID,
            this.zamowieniaLV_maxCzasRozpoczecia,
            this.zamowieniaLV_czasTrwaniaZamawiania});
            this.planZamowienListView.HideSelection = false;
            this.planZamowienListView.Location = new System.Drawing.Point(254, 20);
            this.planZamowienListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planZamowienListView.Name = "planZamowienListView";
            this.planZamowienListView.Size = new System.Drawing.Size(962, 515);
            this.planZamowienListView.TabIndex = 4;
            this.planZamowienListView.UseCompatibleStateImageBehavior = false;
            this.planZamowienListView.View = System.Windows.Forms.View.Details;
            this.planZamowienListView.Visible = false;
            // 
            // zamowieniaLV_nazwa
            // 
            this.zamowieniaLV_nazwa.Text = "Nazwa zadania";
            this.zamowieniaLV_nazwa.Width = 150;
            // 
            // zamowieniaLV_ID
            // 
            this.zamowieniaLV_ID.Text = "ID";
            // 
            // zamowieniaLV_maxCzasRozpoczecia
            // 
            this.zamowieniaLV_maxCzasRozpoczecia.Text = "Maksymalny termin rozpoczęcia zamówienia";
            this.zamowieniaLV_maxCzasRozpoczecia.Width = 225;
            // 
            // zamowieniaLV_czasTrwaniaZamawiania
            // 
            this.zamowieniaLV_czasTrwaniaZamawiania.Text = "Czas realizacji zamówienia";
            this.zamowieniaLV_czasTrwaniaZamawiania.Width = 200;
            // 
            // planPracySMDListView
            // 
            this.planPracySMDListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.smdLV_nazwa,
            this.smdLV_ID,
            this.smdLV_terminRozpoczecia,
            this.smdLV_terminZakonczenia});
            this.planPracySMDListView.HideSelection = false;
            this.planPracySMDListView.Location = new System.Drawing.Point(254, 18);
            this.planPracySMDListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planPracySMDListView.Name = "planPracySMDListView";
            this.planPracySMDListView.Size = new System.Drawing.Size(962, 515);
            this.planPracySMDListView.TabIndex = 5;
            this.planPracySMDListView.UseCompatibleStateImageBehavior = false;
            this.planPracySMDListView.View = System.Windows.Forms.View.Details;
            this.planPracySMDListView.Visible = false;
            // 
            // smdLV_nazwa
            // 
            this.smdLV_nazwa.Text = "Nazwa zadania";
            this.smdLV_nazwa.Width = 150;
            // 
            // smdLV_ID
            // 
            this.smdLV_ID.Text = "ID";
            // 
            // smdLV_terminRozpoczecia
            // 
            this.smdLV_terminRozpoczecia.Text = "Termin rozpoczęcia realizacji zadania";
            this.smdLV_terminRozpoczecia.Width = 200;
            // 
            // smdLV_terminZakonczenia
            // 
            this.smdLV_terminZakonczenia.Text = "Termin zakończenia realizacji zadania";
            this.smdLV_terminZakonczenia.Width = 200;
            // 
            // planPracyTHTListView
            // 
            this.planPracyTHTListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.thtLV_nazwa,
            this.thtLV_ID,
            this.thtLV_terminRozpoczecia,
            this.thtLV_terminZakonczenia});
            this.planPracyTHTListView.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.planPracyTHTListView.HideSelection = false;
            this.planPracyTHTListView.Location = new System.Drawing.Point(254, 20);
            this.planPracyTHTListView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.planPracyTHTListView.Name = "planPracyTHTListView";
            this.planPracyTHTListView.Size = new System.Drawing.Size(962, 516);
            this.planPracyTHTListView.TabIndex = 6;
            this.planPracyTHTListView.UseCompatibleStateImageBehavior = false;
            this.planPracyTHTListView.View = System.Windows.Forms.View.Details;
            this.planPracyTHTListView.Visible = false;
            // 
            // thtLV_nazwa
            // 
            this.thtLV_nazwa.Text = "Nazwa zadania";
            this.thtLV_nazwa.Width = 150;
            // 
            // thtLV_ID
            // 
            this.thtLV_ID.Text = "ID";
            // 
            // thtLV_terminRozpoczecia
            // 
            this.thtLV_terminRozpoczecia.Text = "Termin rozpoczęcia realizacji zadania";
            this.thtLV_terminRozpoczecia.Width = 200;
            // 
            // thtLV_terminZakonczenia
            // 
            this.thtLV_terminZakonczenia.Text = "Termin zakończenia realizacji zadania";
            this.thtLV_terminZakonczenia.Width = 200;
            // 
            // showWorkPlanWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 529);
            this.Controls.Add(this.planPracyTHTListView);
            this.Controls.Add(this.planPracySMDListView);
            this.Controls.Add(this.planZamowienListView);
            this.Controls.Add(this.zamknij_button);
            this.Controls.Add(this.planPracyTHT_button);
            this.Controls.Add(this.planPracySMD_button);
            this.Controls.Add(this.planZamowien_button);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1250, 585);
            this.Name = "showWorkPlanWindow";
            this.Text = "Plan pracy zespołów";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button planZamowien_button;
        private System.Windows.Forms.Button planPracySMD_button;
        private System.Windows.Forms.Button planPracyTHT_button;
        private System.Windows.Forms.Button zamknij_button;
        private System.Windows.Forms.ListView planZamowienListView;
        private System.Windows.Forms.ListView planPracySMDListView;
        private System.Windows.Forms.ListView planPracyTHTListView;
        private System.Windows.Forms.ColumnHeader zamowieniaLV_nazwa;
        private System.Windows.Forms.ColumnHeader zamowieniaLV_ID;
        private System.Windows.Forms.ColumnHeader zamowieniaLV_maxCzasRozpoczecia;
        private System.Windows.Forms.ColumnHeader zamowieniaLV_czasTrwaniaZamawiania;
        private System.Windows.Forms.ColumnHeader smdLV_nazwa;
        private System.Windows.Forms.ColumnHeader smdLV_ID;
        private System.Windows.Forms.ColumnHeader smdLV_terminRozpoczecia;
        private System.Windows.Forms.ColumnHeader smdLV_terminZakonczenia;
        private System.Windows.Forms.ColumnHeader thtLV_nazwa;
        private System.Windows.Forms.ColumnHeader thtLV_ID;
        private System.Windows.Forms.ColumnHeader thtLV_terminRozpoczecia;
        private System.Windows.Forms.ColumnHeader thtLV_terminZakonczenia;
    }
}