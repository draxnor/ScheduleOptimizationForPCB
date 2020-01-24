using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class addEditWindow : Form
    {
        public addEditWindow()
        {
            InitializeComponent();
        }
        public addEditWindow(String nazwaPrzycisku)
        {
            InitializeComponent();
            dodajZadanie_button.Text = nazwaPrzycisku;

        }
        public addEditWindow(String nazwaPrzycisku, String[] daneTextBox)
        {
            InitializeComponent();
            if(daneTextBox.Length == 6)
            {
                dodajZadanie_button.Text = nazwaPrzycisku;

                nazwa_textBox.Text = daneTextBox[0];
                id_textbox.Text = daneTextBox[1];
                r_textBox.Text = daneTextBox[2];
                d_textBox.Text = daneTextBox[3];
                p1_textBox.Text = daneTextBox[4];
                p2_textBox.Text = daneTextBox[5];

                edytowane_id = int.Parse(daneTextBox[1]);
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void dodajZadanie_button_Click(object sender, EventArgs e) //todo
        {
            nazwa_komunikat_label.Visible = false;
            r_komunikat_label.Visible = false;
            d_komunikat_label.Visible = false;
            p1_komunikat_label.Visible = false;
            p2_komunikat_label.Visible = false;
            id_komunikat_label.Visible = false;

            bool isAllDataCorrect = true;
            uint number;



            if (!uint.TryParse(id_textbox.Text, out number))
            {
                id_komunikat_label.Visible = true;
                id_komunikat_label.Text = "Nieprawidłowa wartość. Wprowadź nieujemną liczbę.";
                isAllDataCorrect = false;
            }
            if (String.IsNullOrEmpty(nazwa_textBox.Text))
            {
                nazwa_komunikat_label.Visible = true;
                nazwa_komunikat_label.Text = "Nieprawidłowa wartość. Wprowadź poprawną nazwę.";
                isAllDataCorrect = false;
            }
            if (!uint.TryParse(r_textBox.Text, out number))
            {
                r_komunikat_label.Visible = true;
                r_komunikat_label.Text = "Nieprawidłowa wartość. Wprowadź nieujemną liczbę.";
                isAllDataCorrect = false;
            }
            if (!uint.TryParse(d_textBox.Text, out number))
            {
                d_komunikat_label.Visible = true;
                d_komunikat_label.Text = "Nieprawidłowa wartość. Wprowadź nieujemną liczbę.";
                isAllDataCorrect = false;
            }
            if (!uint.TryParse(p1_textBox.Text, out number))
            {
                p1_komunikat_label.Visible = true;
                p1_komunikat_label.Text = "Nieprawidłowa wartość. Wprowadź nieujemną liczbę.";
                isAllDataCorrect = false;
            }
            if (!uint.TryParse(p2_textBox.Text, out number))
            {
                p2_komunikat_label.Visible = true;
                p2_komunikat_label.Text = "Nieprawidłowa wartość. Wprowadź nieujemną liczbę.";
                isAllDataCorrect = false; 
            }
            if( mainWindow.IDlist.Contains(int.Parse(id_textbox.Text)))
            {
                id_komunikat_label.Visible = true;
                id_komunikat_label.Text = "Zduplikowane ID. Wprowadź unikalne.";
                isAllDataCorrect = false;
            }

            if (isAllDataCorrect)
            {
                if (int.Parse(p1_textBox.Text) < int.Parse(d_textBox.Text))
                {
                    d_komunikat_label.Visible = true;
                    d_komunikat_label.Text = "Nieprawdilowa wartość (d > p1).";
                    isAllDataCorrect = false;
                }
                else if (int.Parse(p1_textBox.Text) > (int.Parse(p2_textBox.Text)+int.Parse(d_textBox.Text)))
                {
                    d_komunikat_label.Visible = true;
                    d_komunikat_label.Text = "Nieprawdilowa wartość (p1 > d+p2).";
                    isAllDataCorrect = false;
                }
                else if (int.Parse(p1_textBox.Text) == 0 & int.Parse(p2_textBox.Text) == 0 )
                {
                    d_komunikat_label.Visible = true;
                    d_komunikat_label.Text = "Nieprawdilowa wartość (p1=p2=0).";
                    isAllDataCorrect = false;
                }
            }

            if (isAllDataCorrect)
            {
                mainWindow.IDlist.Remove(edytowane_id);
                mainWindow.aplication.removeByID(edytowane_id);
                mainWindow.IDlist.Add(int.Parse(id_textbox.Text));
                commWithMainWindow = new string[] {  nazwa_textBox.Text, id_textbox.Text, r_textBox.Text, d_textBox.Text, p1_textBox.Text, p2_textBox.Text };
                DialogResult = DialogResult.OK;
                this.Close();
            }
            
        }

        private void anuluj_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string[] commWithMainWindow { get; set; }

        int edytowane_id = -1;
    }
}
