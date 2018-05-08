namespace Kurs
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.buttonAddNote = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.buttonAddAlarm = new System.Windows.Forms.Button();
            this.timerTime = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.BackColor = System.Drawing.SystemColors.Control;
            this.monthCalendar1.CalendarDimensions = new System.Drawing.Size(3, 1);
            this.monthCalendar1.Location = new System.Drawing.Point(0, 0);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // buttonAddNote
            // 
            this.buttonAddNote.Location = new System.Drawing.Point(12, 175);
            this.buttonAddNote.Name = "buttonAddNote";
            this.buttonAddNote.Size = new System.Drawing.Size(152, 23);
            this.buttonAddNote.TabIndex = 1;
            this.buttonAddNote.Text = "Напоминание";
            this.buttonAddNote.UseVisualStyleBackColor = true;
            // 
            // buttonReport
            // 
            this.buttonReport.Location = new System.Drawing.Point(175, 175);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(152, 23);
            this.buttonReport.TabIndex = 1;
            this.buttonReport.Text = "Отчёт";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // buttonAddAlarm
            // 
            this.buttonAddAlarm.Location = new System.Drawing.Point(338, 175);
            this.buttonAddAlarm.Name = "buttonAddAlarm";
            this.buttonAddAlarm.Size = new System.Drawing.Size(152, 23);
            this.buttonAddAlarm.TabIndex = 1;
            this.buttonAddAlarm.Text = "Будильник";
            this.buttonAddAlarm.UseVisualStyleBackColor = true;
            this.buttonAddAlarm.Click += new System.EventHandler(this.buttonAddAlarm_Click);
            // 
            // timerTime
            // 
            this.timerTime.Tick += new System.EventHandler(this.timerTime_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(500, 207);
            this.Controls.Add(this.buttonAddAlarm);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonAddNote);
            this.Controls.Add(this.monthCalendar1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.ShowIcon = false;
            this.Text = "Календарь";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button buttonAddNote;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.Timer timerTime;
        public System.Windows.Forms.Button buttonAddAlarm;
    }
}

