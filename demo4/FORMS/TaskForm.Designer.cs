namespace demo4.FORMS
{
    partial class TaskForm
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
            this.DescTxt = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.DeadlineDT = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleTxt = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.CompletedDT = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.DifficultyNum = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TimeNum = new System.Windows.Forms.NumericUpDown();
            this.ExecCmb = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.StatusCmb = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.WorkCmb = new System.Windows.Forms.ComboBox();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BackBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyNum)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNum)).BeginInit();
            this.SuspendLayout();
            // 
            // DescTxt
            // 
            this.DescTxt.Location = new System.Drawing.Point(80, 66);
            this.DescTxt.Name = "DescTxt";
            this.DescTxt.Size = new System.Drawing.Size(235, 96);
            this.DescTxt.TabIndex = 1;
            this.DescTxt.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Заголовок";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Описание";
            // 
            // DeadlineDT
            // 
            this.DeadlineDT.Location = new System.Drawing.Point(114, 168);
            this.DeadlineDT.Name = "DeadlineDT";
            this.DeadlineDT.Size = new System.Drawing.Size(200, 20);
            this.DeadlineDT.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 168);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Срок исполнения";
            // 
            // TitleTxt
            // 
            this.TitleTxt.Location = new System.Drawing.Point(80, 12);
            this.TitleTxt.Name = "TitleTxt";
            this.TitleTxt.Size = new System.Drawing.Size(235, 48);
            this.TitleTxt.TabIndex = 6;
            this.TitleTxt.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Дата выполения";
            // 
            // CompletedDT
            // 
            this.CompletedDT.Location = new System.Drawing.Point(115, 194);
            this.CompletedDT.Name = "CompletedDT";
            this.CompletedDT.Size = new System.Drawing.Size(200, 20);
            this.CompletedDT.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 220);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Сложность";
            // 
            // DifficultyNum
            // 
            this.DifficultyNum.Location = new System.Drawing.Point(82, 220);
            this.DifficultyNum.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.DifficultyNum.Name = "DifficultyNum";
            this.DifficultyNum.Size = new System.Drawing.Size(233, 20);
            this.DifficultyNum.TabIndex = 10;
            this.DifficultyNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 246);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(120, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Время на выполнение";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Исполнитель";
            // 
            // TimeNum
            // 
            this.TimeNum.Location = new System.Drawing.Point(139, 246);
            this.TimeNum.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.TimeNum.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.TimeNum.Name = "TimeNum";
            this.TimeNum.Size = new System.Drawing.Size(176, 20);
            this.TimeNum.TabIndex = 13;
            this.TimeNum.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ExecCmb
            // 
            this.ExecCmb.FormattingEnabled = true;
            this.ExecCmb.Location = new System.Drawing.Point(93, 272);
            this.ExecCmb.Name = "ExecCmb";
            this.ExecCmb.Size = new System.Drawing.Size(222, 21);
            this.ExecCmb.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 299);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Статус";
            // 
            // StatusCmb
            // 
            this.StatusCmb.FormattingEnabled = true;
            this.StatusCmb.Items.AddRange(new object[] {
            "запланирована",
            "исполняется",
            "выполнена",
            "отменена"});
            this.StatusCmb.Location = new System.Drawing.Point(60, 299);
            this.StatusCmb.Name = "StatusCmb";
            this.StatusCmb.Size = new System.Drawing.Size(255, 21);
            this.StatusCmb.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 330);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Характер задачи";
            // 
            // WorkCmb
            // 
            this.WorkCmb.FormattingEnabled = true;
            this.WorkCmb.Items.AddRange(new object[] {
            "анализ и проектирование",
            "установка оборудования",
            "техническое обслуживание и сопровождение"});
            this.WorkCmb.Location = new System.Drawing.Point(111, 330);
            this.WorkCmb.Name = "WorkCmb";
            this.WorkCmb.Size = new System.Drawing.Size(204, 21);
            this.WorkCmb.TabIndex = 18;
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(60, 376);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(75, 23);
            this.SaveBtn.TabIndex = 19;
            this.SaveBtn.Text = "Сохранить";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BackBtn
            // 
            this.BackBtn.Location = new System.Drawing.Point(179, 376);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.Size = new System.Drawing.Size(75, 23);
            this.BackBtn.TabIndex = 20;
            this.BackBtn.Text = "Отмена";
            this.BackBtn.UseVisualStyleBackColor = true;
            this.BackBtn.Click += new System.EventHandler(this.BackBtn_Click);
            // 
            // TaskForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 424);
            this.Controls.Add(this.BackBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.WorkCmb);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.StatusCmb);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ExecCmb);
            this.Controls.Add(this.TimeNum);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DifficultyNum);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.CompletedDT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TitleTxt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DeadlineDT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DescTxt);
            this.Name = "TaskForm";
            this.Text = "TaskForm";
            ((System.ComponentModel.ISupportInitialize)(this.DifficultyNum)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TimeNum)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox DescTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker DeadlineDT;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox TitleTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker CompletedDT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown DifficultyNum;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown TimeNum;
        private System.Windows.Forms.ComboBox ExecCmb;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox StatusCmb;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox WorkCmb;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BackBtn;
    }
}