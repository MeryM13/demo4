using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using demo4.CLASSES;
using demo4.UTILS;

namespace demo4.FORMS
{
    public partial class MainForm : Form
    {
        private string statusFilter = null;
        private string execFilter = null;
        private string role;
        private User User;
        private CLASSES.Task selectedTask = null;
        public MainForm(User user)
        {
            InitializeComponent();
            this.User = user;
            Console.WriteLine(user.ID);
            if (DataWork.IsManager(user))
            {
                role = "Manager";
                label2.Visible = true;
                ExecutorCmb.Visible = true;
                ExecutorCmb.Enabled = true;
                ExecutorCmb.Items.Clear();
                ExecutorCmb.Items.Add("");
                foreach (string execName in DataWork.GetExecList(User.ID))
                {
                    ExecutorCmb.Items.Add(execName);
                }

                TasksDataGrid.DataSource = DataWork.GetManagerTasks(user, this.statusFilter, this.execFilter).Tables[0];
            }
            else if (DataWork.IsExec(user))
            {
                role = "Exec";
                label2.Visible = false;
                ExecutorCmb.Visible = false;
                ExecutorCmb.Enabled = false;
                TasksDataGrid.DataSource = DataWork.GetExecTasks(user, this.statusFilter).Tables[0];
            }
        }

        private void UpdateDataGrid()
        {
            if (role == "Manager")
            {
                TasksDataGrid.DataSource = DataWork.GetManagerTasks(this.User, this.statusFilter, this.execFilter).Tables[0];
            }
            else if (role == "Exec")
            {
                TasksDataGrid.DataSource = DataWork.GetExecTasks(this.User, this.statusFilter).Tables[0];
            }
        }

        private void StatusCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.statusFilter = StatusCmb.SelectedItem.ToString();
            UpdateDataGrid();
        }

        private void ExecutorCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.execFilter = ExecutorCmb.SelectedItem.ToString();
            UpdateDataGrid();
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            Console.WriteLine(User.ID);
            TaskForm task = new TaskForm(role, 1, this.selectedTask, User.ID);
            task.ShowDialog();
            UpdateDataGrid();
        }

        private void RedactBtn_Click(object sender, EventArgs e)
        {
            this.selectedTask = DataWork.GetTask(TasksDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            Console.WriteLine(selectedTask.ID);
            TaskForm task = new TaskForm(role, 2, this.selectedTask, User.ID);
            task.ShowDialog();
            UpdateDataGrid();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            this.selectedTask = DataWork.GetTask(TasksDataGrid.SelectedRows[0].Cells[0].Value.ToString());
            Console.WriteLine(selectedTask.ID);
            DataWork.DeleteTask(selectedTask);
            UpdateDataGrid();
        }
    }
}
