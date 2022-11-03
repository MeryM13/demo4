namespace demo4.FORMS
{
    partial class MainForm
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
            this.TasksDataGrid = new System.Windows.Forms.DataGridView();
            this.StatusCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ExecutorCmb = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AddBtn = new System.Windows.Forms.Button();
            this.RedactBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // TasksDataGrid
            // 
            this.TasksDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.TasksDataGrid.Location = new System.Drawing.Point(12, 62);
            this.TasksDataGrid.MultiSelect = false;
            this.TasksDataGrid.Name = "TasksDataGrid";
            this.TasksDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.TasksDataGrid.Size = new System.Drawing.Size(614, 376);
            this.TasksDataGrid.TabIndex = 0;
            // 
            // StatusCmb
            // 
            this.StatusCmb.FormattingEnabled = true;
            this.StatusCmb.Items.AddRange(new object[] {
            "запланирована",
            "исполняется",
            "выполнена",
            "отменена"});
            this.StatusCmb.Location = new System.Drawing.Point(85, 23);
            this.StatusCmb.Name = "StatusCmb";
            this.StatusCmb.Size = new System.Drawing.Size(121, 21);
            this.StatusCmb.TabIndex = 1;
            this.StatusCmb.SelectedIndexChanged += new System.EventHandler(this.StatusCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Статус";
            // 
            // ExecutorCmb
            // 
            this.ExecutorCmb.FormattingEnabled = true;
            this.ExecutorCmb.Location = new System.Drawing.Point(350, 27);
            this.ExecutorCmb.Name = "ExecutorCmb";
            this.ExecutorCmb.Size = new System.Drawing.Size(323, 21);
            this.ExecutorCmb.TabIndex = 3;
            this.ExecutorCmb.SelectedIndexChanged += new System.EventHandler(this.ExecutorCmb_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(270, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Исполнитель";
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(655, 62);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(122, 23);
            this.AddBtn.TabIndex = 5;
            this.AddBtn.Text = "Добавить";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // RedactBtn
            // 
            this.RedactBtn.Location = new System.Drawing.Point(655, 92);
            this.RedactBtn.Name = "RedactBtn";
            this.RedactBtn.Size = new System.Drawing.Size(122, 23);
            this.RedactBtn.TabIndex = 6;
            this.RedactBtn.Text = "Редактировать";
            this.RedactBtn.UseVisualStyleBackColor = true;
            this.RedactBtn.Click += new System.EventHandler(this.RedactBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(655, 122);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(122, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Удалить";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.RedactBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ExecutorCmb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StatusCmb);
            this.Controls.Add(this.TasksDataGrid);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.TasksDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView TasksDataGrid;
        private System.Windows.Forms.ComboBox StatusCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox ExecutorCmb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button RedactBtn;
        private System.Windows.Forms.Button DeleteBtn;
    }
}