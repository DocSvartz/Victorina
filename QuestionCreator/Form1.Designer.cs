namespace QuestionCreator
{
    partial class FormQuestionCreator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormQuestionCreator));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.QuestionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.Del_qu_btn = new System.Windows.Forms.ToolStripButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.QuestionTextBox = new System.Windows.Forms.RichTextBox();
            this.label_Question = new System.Windows.Forms.Label();
            this.label_Answer = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AnswerStrip = new System.Windows.Forms.ToolStrip();
            this.AddAnswer = new System.Windows.Forms.ToolStripButton();
            this.DelAnswer_btn = new System.Windows.Forms.ToolStripButton();
            this.AnswePanel = new System.Windows.Forms.FlowLayoutPanel();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.загрузитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.сохранитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.flowLayoutPanel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.AnswerStrip.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.groupBox1);
            this.flowLayoutPanel1.Controls.Add(this.tableLayoutPanel1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 28);
            this.flowLayoutPanel1.MaximumSize = new System.Drawing.Size(884, 457);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(884, 457);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.QuestionPanel);
            this.groupBox1.Controls.Add(this.toolStrip1);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(202, 445);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // QuestionPanel
            // 
            this.QuestionPanel.AutoScroll = true;
            this.QuestionPanel.AutoScrollMinSize = new System.Drawing.Size(0, 900);
            this.QuestionPanel.AutoSize = true;
            this.QuestionPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.QuestionPanel.Location = new System.Drawing.Point(6, 70);
            this.QuestionPanel.MaximumSize = new System.Drawing.Size(193, 375);
            this.QuestionPanel.Name = "QuestionPanel";
            this.QuestionPanel.Size = new System.Drawing.Size(193, 375);
            this.QuestionPanel.TabIndex = 1;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.Del_qu_btn});
            this.toolStrip1.Location = new System.Drawing.Point(3, 16);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(196, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Image = global::QuestionCreator.Properties.Resources.Plus;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(23, 22);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // Del_qu_btn
            // 
            this.Del_qu_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Del_qu_btn.Image = global::QuestionCreator.Properties.Resources.Minus;
            this.Del_qu_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Del_qu_btn.Name = "Del_qu_btn";
            this.Del_qu_btn.Size = new System.Drawing.Size(23, 22);
            this.Del_qu_btn.Text = "toolStripButton2";
            this.Del_qu_btn.Click += new System.EventHandler(this.Delquestion_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.QuestionTextBox, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label_Question, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label_Answer, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.groupBox2, 0, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(211, 3);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(657, 445);
            this.tableLayoutPanel1.TabIndex = 1;
            // 
            // QuestionTextBox
            // 
            this.QuestionTextBox.Location = new System.Drawing.Point(3, 23);
            this.QuestionTextBox.Name = "QuestionTextBox";
            this.QuestionTextBox.Size = new System.Drawing.Size(651, 196);
            this.QuestionTextBox.TabIndex = 1;
            this.QuestionTextBox.Text = "";
            this.QuestionTextBox.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // label_Question
            // 
            this.label_Question.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label_Question.AutoSize = true;
            this.label_Question.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Question.Location = new System.Drawing.Point(3, 2);
            this.label_Question.Name = "label_Question";
            this.label_Question.Size = new System.Drawing.Size(114, 16);
            this.label_Question.TabIndex = 2;
            this.label_Question.Text = "Введите вопрос";
            // 
            // label_Answer
            // 
            this.label_Answer.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label_Answer.AutoSize = true;
            this.label_Answer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label_Answer.Location = new System.Drawing.Point(3, 226);
            this.label_Answer.Name = "label_Answer";
            this.label_Answer.Size = new System.Drawing.Size(114, 16);
            this.label_Answer.TabIndex = 3;
            this.label_Answer.Text = "Введите ответы";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.AnswerStrip);
            this.groupBox2.Controls.Add(this.AnswePanel);
            this.groupBox2.Location = new System.Drawing.Point(3, 245);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(651, 197);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // AnswerStrip
            // 
            this.AnswerStrip.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AnswerStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.AnswerStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddAnswer,
            this.DelAnswer_btn});
            this.AnswerStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.AnswerStrip.Location = new System.Drawing.Point(602, 16);
            this.AnswerStrip.Name = "AnswerStrip";
            this.AnswerStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AnswerStrip.Size = new System.Drawing.Size(24, 46);
            this.AnswerStrip.TabIndex = 1;
            this.AnswerStrip.Text = "toolStrip3";
            this.AnswerStrip.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // AddAnswer
            // 
            this.AddAnswer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddAnswer.Image = global::QuestionCreator.Properties.Resources.Plus;
            this.AddAnswer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddAnswer.Name = "AddAnswer";
            this.AddAnswer.Size = new System.Drawing.Size(23, 20);
            this.AddAnswer.Text = "toolStripButton4";
            this.AddAnswer.Click += new System.EventHandler(this.AddAnswer_Click);
            // 
            // DelAnswer_btn
            // 
            this.DelAnswer_btn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DelAnswer_btn.Image = global::QuestionCreator.Properties.Resources.Minus;
            this.DelAnswer_btn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DelAnswer_btn.Name = "DelAnswer_btn";
            this.DelAnswer_btn.Size = new System.Drawing.Size(23, 20);
            this.DelAnswer_btn.Text = "toolStripButton5";
            this.DelAnswer_btn.Click += new System.EventHandler(this.DelAnswer_btn_Click);
            // 
            // AnswePanel
            // 
            this.AnswePanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.AnswePanel.Location = new System.Drawing.Point(6, 0);
            this.AnswePanel.Name = "AnswePanel";
            this.AnswePanel.Size = new System.Drawing.Size(577, 191);
            this.AnswePanel.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1,
            this.toolStripButton3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(908, 25);
            this.toolStrip2.TabIndex = 2;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.загрузитьToolStripMenuItem,
            this.сохранитьToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(51, 22);
            this.toolStripDropDownButton1.Text = "Файл";
            // 
            // загрузитьToolStripMenuItem
            // 
            this.загрузитьToolStripMenuItem.Name = "загрузитьToolStripMenuItem";
            this.загрузитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.загрузитьToolStripMenuItem.Text = "Загрузить";
            // 
            // сохранитьToolStripMenuItem
            // 
            this.сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            this.сохранитьToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(64, 22);
            this.toolStripButton3.Text = "Помощь";
            // 
            // FormQuestionCreator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 497);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(924, 536);
            this.MinimumSize = new System.Drawing.Size(924, 536);
            this.Name = "FormQuestionCreator";
            this.Text = "QuestionCreator";
            this.Load += new System.EventHandler(this.FormQuestionCreator_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.AnswerStrip.ResumeLayout(false);
            this.AnswerStrip.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RichTextBox QuestionTextBox;
        private System.Windows.Forms.Label label_Question;
        private System.Windows.Forms.Label label_Answer;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton Del_qu_btn;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripMenuItem сохранитьToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem загрузитьToolStripMenuItem;
        private System.Windows.Forms.FlowLayoutPanel QuestionPanel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ToolStrip AnswerStrip;
        private System.Windows.Forms.ToolStripButton AddAnswer;
        private System.Windows.Forms.ToolStripButton DelAnswer_btn;
        private System.Windows.Forms.FlowLayoutPanel AnswePanel;
    }
}

