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
    public partial class TaskForm : Form
    {
        private CLASSES.Task task;
        private int Mode;

        public TaskForm(string role, int mode, CLASSES.Task Task, int id)
        {
            InitializeComponent();
            this.Mode = mode;
            switch (mode)
            {
                case 1:
                {
                    task = new CLASSES.Task();
                    ExecCmb.Items.Clear();
                    if (role == "Exec")
                    {
                        ExecCmb.Items.Add(DataWork.GetExec(id));
                        ExecCmb.SelectedIndex = 0;
                        ExecCmb.Enabled = false;
                    }
                    else if (role == "Manager")
                    {
                        foreach (string execName in DataWork.GetExecList(id))
                        {
                            ExecCmb.Items.Add(execName);
                        }
                    }

                    break;
                }
                case 2:
                {
                    this.task = Task;
                    TitleTxt.Text = task.Title;
                    DescTxt.Text = task.Description;
                    DeadlineDT.Value = task.Deadline;
                    try
                    {
                        CompletedDT.Value = task.CompletedDateTime;
                    }
                    catch (Exception ex)
                    {
                        CompletedDT.Value = CompletedDT.MinDate;
                        Console.WriteLine(ex.Message);
                    }

                    DifficultyNum.Value = task.Difficulty;
                    TimeNum.Value = task.Time;
                    StatusCmb.SelectedItem = task.Status;
                    WorkCmb.SelectedItem = task.WorkType;
                    ExecCmb.Items.Clear();
                    if (role == "Exec")
                    {
                        ExecCmb.Items.Add(DataWork.GetExec(id));
                        ExecCmb.SelectedIndex = 0;
                        ExecCmb.Enabled = false;
                    }
                    else if (role == "Manager")
                    {
                        foreach (string execName in DataWork.GetExecList(id))
                        {
                            ExecCmb.Items.Add(execName);
                        }

                        ExecCmb.SelectedItem = DataWork.GetExec(task.ExecutorID);
                    }

                    break;
                }
                default:
                {
                    this.Close();
                    break;
                }
            }
        }


        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            task.Title = TitleTxt.Text;
            task.Description = DescTxt.Text;
            task.Deadline = DeadlineDT.Value;
            task.CompletedDateTime = CompletedDT.Value;
            task.Difficulty = (int)DifficultyNum.Value;
            task.Time = (int)TimeNum.Value;
            task.Status = StatusCmb.SelectedItem.ToString();
            task.ExecutorID = DataWork.GetExecID(ExecCmb.SelectedItem.ToString());
            task.WorkType = WorkCmb.SelectedItem.ToString();
            switch (Mode)
            {
                case 1:
                {
                    task.CreateDateTime = DateTime.Now;
                    DataWork.AddTask(task);
                    this.Close();
                    break;
                }
                case 2:
                {
                    DataWork.UpdateTask(task);
                    this.Close();
                    break;
                }
                default:
                {
                    break;
                }
            }

        }
    }
}
