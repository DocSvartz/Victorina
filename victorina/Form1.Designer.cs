namespace victorina
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Score_label = new System.Windows.Forms.Label();
            this.Reset_btn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LoadData_mB = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.тестToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.пробныеЗаданияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Attention_lb = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuestionCounter = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.MaxQuestCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(239, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 26);
            this.button1.TabIndex = 1;
            this.button1.Text = "Next";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(52, 77);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(135, 112);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "Вода, Сила Земли, Акватория ";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(-1, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(197, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Количество верных ответов:";
            // 
            // Score_label
            // 
            this.Score_label.AutoSize = true;
            this.Score_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Score_label.Location = new System.Drawing.Point(194, 8);
            this.Score_label.Name = "Score_label";
            this.Score_label.Size = new System.Drawing.Size(16, 17);
            this.Score_label.TabIndex = 6;
            this.Score_label.Text = "0";
            // 
            // Reset_btn
            // 
            this.Reset_btn.Location = new System.Drawing.Point(239, 355);
            this.Reset_btn.Name = "Reset_btn";
            this.Reset_btn.Size = new System.Drawing.Size(92, 24);
            this.Reset_btn.TabIndex = 7;
            this.Reset_btn.Text = "Reset";
            this.Reset_btn.UseVisualStyleBackColor = true;
            this.Reset_btn.Click += new System.EventHandler(this.Reset_btn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.тестToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(583, 25);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.LoadData_mB});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(50, 21);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // LoadData_mB
            // 
            this.LoadData_mB.Name = "LoadData_mB";
            this.LoadData_mB.Size = new System.Drawing.Size(134, 22);
            this.LoadData_mB.Text = "Загрузить";
            this.LoadData_mB.Click += new System.EventHandler(this.LoadData_mB_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(47, 21);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // тестToolStripMenuItem
            // 
            this.тестToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.пробныеЗаданияToolStripMenuItem});
            this.тестToolStripMenuItem.Name = "тестToolStripMenuItem";
            this.тестToolStripMenuItem.Size = new System.Drawing.Size(45, 21);
            this.тестToolStripMenuItem.Text = "Тест";
            // 
            // пробныеЗаданияToolStripMenuItem
            // 
            this.пробныеЗаданияToolStripMenuItem.Name = "пробныеЗаданияToolStripMenuItem";
            this.пробныеЗаданияToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.пробныеЗаданияToolStripMenuItem.Text = "Пробные задания";
            this.пробныеЗаданияToolStripMenuItem.Click += new System.EventHandler(this.пробныеЗаданияToolStripMenuItem_Click);
            // 
            // Attention_lb
            // 
            this.Attention_lb.AutoSize = true;
            this.Attention_lb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Attention_lb.ForeColor = System.Drawing.Color.DarkRed;
            this.Attention_lb.Location = new System.Drawing.Point(127, 36);
            this.Attention_lb.Name = "Attention_lb";
            this.Attention_lb.Size = new System.Drawing.Size(262, 24);
            this.Attention_lb.TabIndex = 9;
            this.Attention_lb.Text = "Загрузите файл с заданием";
            // 
            // groupBox2
            // 
            this.groupBox2.AutoSize = true;
            this.groupBox2.Location = new System.Drawing.Point(405, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(136, 112);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ответы";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Score_label);
            this.groupBox1.Location = new System.Drawing.Point(173, 256);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(216, 29);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            // 
            // QuestionCounter
            // 
            this.QuestionCounter.AutoSize = true;
            this.QuestionCounter.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionCounter.Location = new System.Drawing.Point(74, 7);
            this.QuestionCounter.Name = "QuestionCounter";
            this.QuestionCounter.Size = new System.Drawing.Size(0, 15);
            this.QuestionCounter.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.MaxQuestCount);
            this.groupBox3.Controls.Add(this.QuestionCounter);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Location = new System.Drawing.Point(52, 195);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(138, 25);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label3.Location = new System.Drawing.Point(6, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 15;
            this.label3.Text = "Вопрос:";
            // 
            // MaxQuestCount
            // 
            this.MaxQuestCount.AutoSize = true;
            this.MaxQuestCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MaxQuestCount.Location = new System.Drawing.Point(117, 7);
            this.MaxQuestCount.Name = "MaxQuestCount";
            this.MaxQuestCount.Size = new System.Drawing.Size(0, 15);
            this.MaxQuestCount.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(101, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(10, 15);
            this.label2.TabIndex = 13;
            this.label2.Text = "/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 418);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.Attention_lb);
            this.Controls.Add(this.Reset_btn);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(599, 457);
            this.Name = "Form1";
            this.Text = "Victorina";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Score_label;
        private System.Windows.Forms.Button Reset_btn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem LoadData_mB;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem тестToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem пробныеЗаданияToolStripMenuItem;
        private System.Windows.Forms.Label Attention_lb;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label QuestionCounter;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label MaxQuestCount;
        private System.Windows.Forms.Label label2;
    }
}

