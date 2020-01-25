using System;
using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;

namespace WindowsFormsApp1
{
    public partial class mainWindow : Form
    {

        public mainWindow()
        {
            InitializeComponent();

        }

        private void dodajZadanieButton_Click(object sender, EventArgs e)
        {

            using (addEditWindow addWindowObj = new addEditWindow("Dodaj zadanie"))
            {
                if (addWindowObj.ShowDialog() == DialogResult.OK)
                {
                    String[] dataFromAddWindow = addWindowObj.commWithMainWindow;
                    ListViewItem newLVItem = new ListViewItem(dataFromAddWindow);
                    listView1.Items.Add(newLVItem);
                    aplication.addTask(int.Parse(dataFromAddWindow[1]), int.Parse(dataFromAddWindow[2]), int.Parse(dataFromAddWindow[3]), int.Parse(dataFromAddWindow[4]), int.Parse(dataFromAddWindow[5]));
                    
                    usunWszystkieZadaniaButton.Visible = true;
                    wyswietlHarmonogramButton.Visible = true;

                }
            }

        }

        private void usunZadanieButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem eachItem in listView1.SelectedItems)
            {
                listView1.Items.Remove(eachItem);
                int id = int.Parse(eachItem.SubItems[1].Text);
                IDlist.Remove(id);
                aplication.removeByID(id);

            }
                
                
            if (listView1.Items.Count == 0) 
            {
                usunWszystkieZadaniaButton.Visible = false;
                wyswietlHarmonogramButton.Visible = false;
            }
                

        }

        private void wyswietlHarmonogramButton_Click(object sender, EventArgs e)
        {

            displayChartWindow harmonogram = new displayChartWindow();
            harmonogram.ShowDialog();
        }


        private void dodajZadaniaZPlikuButton_Click(object sender, EventArgs e)
        {
            importZadan_label.Visible = false;

            List<ListViewItem> listOfLVItems = new List<ListViewItem>();
            List<Task> listOfTasks = new List<Task>();
            bool isDataCorrect = true;

            try
            {
                var filePath = string.Empty;

                using (OpenFileDialog openFileDialog = new OpenFileDialog())
                {
                    openFileDialog.InitialDirectory = "c:\\";
                    openFileDialog.Filter = "txt files (*.txt)|*.txt|csv files (*.csv)|*.csv";
                    openFileDialog.FilterIndex = 2;
                    openFileDialog.RestoreDirectory = true;

                    if (openFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        filePath = openFileDialog.FileName;
                        var fileStream = openFileDialog.OpenFile();

                        using (StreamReader sr = new StreamReader(fileStream))
                        {
                            string line;
                            uint number;
                            int i_number;
                            int nazwa = -1, id = -1, r = -1, d = -1, p1 = -1, p2 = -1;
                            line = sr.ReadLine();
                            string[] label_line = line.Split(new char[] { ' ', '\t', ';' }, StringSplitOptions.RemoveEmptyEntries);
                            for (int i = 0; i < label_line.Length; ++i)
                            {
                                switch (label_line[i])
                                {
                                    case "nazwa":
                                        nazwa = i;
                                        break;
                                    case "id":
                                        id = i;
                                        break;
                                    case "r":
                                        r = i;
                                        break;
                                    case "d":
                                        d = i;
                                        break;
                                    case "p1":
                                        p1 = i;
                                        break;
                                    case "p2":
                                        p2 = i;
                                        break;
                                }
                            }
                            if (nazwa < 0 | id < 0 | r < 0 | d < 0 | p1 < 0 | p2 < 0)
                            {
                                importZadan_label.Visible = true;
                                importZadan_label.Text = "Błędny format danych w pliku - etykiety kolumn.";
                                isDataCorrect = false;
                                return;
                            }
                            int[] numericDataIndexes = { id, r, d, p1, p2 };

                            do
                            {
                                line = sr.ReadLine();
                                if (line == null)
                                    break;

                                string[] line_elems = line.Split(new char[] { ' ', '\t', ';', ',' }, StringSplitOptions.RemoveEmptyEntries);


                                foreach (int i in numericDataIndexes)
                                {
                                    if (!uint.TryParse(line_elems[i], out number))
                                    {
                                        importZadan_label.Visible = true;
                                        importZadan_label.Text = "Błąd importu. Nieznane znaki w danych liczbowych.";
                                        isDataCorrect = false;
                                        break;
                                    }
                                }

                                int.TryParse(line_elems[id], out i_number);
                                if (IDlist.Contains(i_number))
                                {
                                    importZadan_label.Visible = true;
                                    importZadan_label.Text = "Zduplikowane ID.";
                                    isDataCorrect = false;
                                    break;
                                }

                                if (isDataCorrect)
                                {
                                    if (int.Parse(line_elems[d]) > int.Parse(line_elems[p1]))
                                    {
                                        importZadan_label.Visible = true;
                                        importZadan_label.Text = "Błędne wartości danych wejściowych (d>p1).";
                                        isDataCorrect = false;
                                    }
                                    else if (int.Parse(line_elems[p1]) > (int.Parse(line_elems[p2]) + int.Parse(line_elems[d])))
                                    {
                                        importZadan_label.Visible = true;
                                        importZadan_label.Text = "Błędne wartości danych wejściowych (p1 > d+p2).";
                                        isDataCorrect = false;
                                    }
                                    else if (int.Parse(line_elems[p1]) == 0 & int.Parse(line_elems[p2]) == 0)
                                    {
                                        importZadan_label.Visible = true;
                                        importZadan_label.Text = "Błędne wartości danych wejściowych (p1 = p2 = 0).";
                                        isDataCorrect = false;
                                    }

                                }

                                if (isDataCorrect)
                                {
                                    string[] itemAsStringTab = { line_elems[nazwa], line_elems[id], line_elems[r], line_elems[d], line_elems[p1], line_elems[p2] };
                                    listOfLVItems.Add(new ListViewItem(itemAsStringTab));
                                    listOfTasks.Add(new Task(int.Parse(line_elems[id]), int.Parse(line_elems[r]), int.Parse(line_elems[d]), int.Parse(line_elems[p1]), int.Parse(line_elems[p2])));
                                }

                            } while (line != null & isDataCorrect);
                        }
                    }
                }
            }
            catch (IOException exeption)
            {
                importZadan_label.Visible = true;
                importZadan_label.Text = "Błąd przy otwarciu pliku.";
                isDataCorrect = false;
            }

            if(isDataCorrect)
            {
                foreach( ListViewItem item in listOfLVItems)
                    listView1.Items.Add(item);
                foreach(Task item in listOfTasks)
                {
                    aplication.addTask(item);
                    IDlist.Add(item.taskId);
                }
                usunWszystkieZadaniaButton.Visible = true;
                wyswietlHarmonogramButton.Visible = true;
            }


        }

            private void edytujZadanieButton_Click(object sender, EventArgs e)
        {
            ListViewItem wybrane = listView1.SelectedItems[0];
            String[] existingData = { wybrane.SubItems[0].Text, wybrane.SubItems[1].Text, wybrane.SubItems[2].Text, wybrane.SubItems[3].Text, wybrane.SubItems[4].Text, wybrane.SubItems[5].Text };
            using (addEditWindow editWindowObj = new addEditWindow("Edytuj zadanie",existingData))
            {
                if (editWindowObj.ShowDialog() == DialogResult.OK)
                {
                    String[] dataFromEditWindow = editWindowObj.commWithMainWindow;
                    for (int i = 0; i < dataFromEditWindow.Length ; i++)
                    {
                        listView1.SelectedItems[0].SubItems[i].Text = dataFromEditWindow[i];
                    }
                    aplication.addTask(int.Parse(dataFromEditWindow[1]), int.Parse(dataFromEditWindow[2]), int.Parse(dataFromEditWindow[3]), int.Parse(dataFromEditWindow[4]), int.Parse(dataFromEditWindow[5]));

                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                edytujZadanieButton.Visible = true;
                usunZadanieButton.Visible = true;
            }
            else
            {
                edytujZadanieButton.Visible = false;
                usunZadanieButton.Visible = false;
            }
               
        }


        private void usunWszystkieZadaniaButton_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            IDlist.Clear();
            aplication.clearOrderOfTask();
            usunWszystkieZadaniaButton.Visible = false;
            wyswietlHarmonogramButton.Visible = false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            importZadan_label.Visible = false;
        }

        static public List<int> IDlist = new List<int>();
        static public Aplication aplication = new Aplication();

        private void wyswietlPlanPracy_button_Click(object sender, EventArgs e)
        {

        }
    }
}
