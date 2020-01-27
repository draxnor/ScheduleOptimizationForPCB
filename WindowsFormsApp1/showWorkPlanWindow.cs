using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class showWorkPlanWindow : Form
    {
        public showWorkPlanWindow()
        {
            InitializeComponent();

            foreach (Task task in mainWindow.aplication.getOrderOfTasks())
            {
                if(task.timeP2 != 0)
                {
                    int startTime = task.timeOfFinishOperationP2 - task.timeP2;
                    string[] newLVitemAsString = { mainWindow.zadaniaDictionary[task.taskId], task.taskId.ToString(), startTime.ToString(), task.timeOfFinishOperationP2.ToString() };
                    ListViewItem newLVItem = new ListViewItem(newLVitemAsString);
                    planPracyTHTListView.Items.Add(newLVItem);
                }
            }

            List<KeyValuePair<int, int>> taskIDListByMaxTime = new List<KeyValuePair<int, int>>();
            Dictionary<int, int> tasksRTimeByID = new Dictionary<int, int>();
            foreach (Task task in mainWindow.aplication.getOrderOfTasks())
            {

                int maxTimeOfStartPreparation = task.timeOfFinishOperationP1 - task.timeP1 - task.timeR;
                taskIDListByMaxTime.Add(new KeyValuePair<int, int> (maxTimeOfStartPreparation, task.taskId));
                tasksRTimeByID.Add(task.taskId, task.timeR);
            }

            // todo
            var taskIDListSortedByMaxTime = taskIDListByMaxTime.OrderBy(item => item.Key);
            foreach (KeyValuePair<int, int> taskIDPair in taskIDListSortedByMaxTime)
            {
                string[] newLVitemAsString = { mainWindow.zadaniaDictionary[taskIDPair.Value].ToString(), taskIDPair.Value.ToString(), taskIDPair.Key.ToString(), tasksRTimeByID[taskIDPair.Value].ToString() };
                ListViewItem newLVItem = new ListViewItem(newLVitemAsString);
                planZamowienListView.Items.Add(newLVItem);
            }

            foreach (Task task in mainWindow.aplication.getOrderOfTasks())
            {
                if(task.timeP1 != 0)
                {
                    int startTime = task.timeOfFinishOperationP1 - task.timeP1;
                    string[] newLVitemAsString = { mainWindow.zadaniaDictionary[task.taskId], task.taskId.ToString(), startTime.ToString(), task.timeOfFinishOperationP1.ToString() };
                    ListViewItem newLVItem = new ListViewItem(newLVitemAsString);
                    planPracySMDListView.Items.Add(newLVItem);
                }
            }
        }


        private void planPracyTHT_button_Click(object sender, EventArgs e)
        {
            planPracySMDListView.Visible = false;
            planPracyTHTListView.Visible = true;
            planZamowienListView.Visible = false;
        }

        private void planZamowien_button_Click(object sender, EventArgs e)
        {
            planPracySMDListView.Visible = false;
            planPracyTHTListView.Visible = false;
            planZamowienListView.Visible = true;
        }


        private void planPracySMD_button_Click(object sender, EventArgs e)
        {
            planPracySMDListView.Visible = true;
            planPracyTHTListView.Visible = false;
            planZamowienListView.Visible = false;
        }

        private void zamknij_button_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }

    }
}
