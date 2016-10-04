using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using victorina;

namespace QuestionCreator
{
    public partial class FormQuestionCreator : Form
    {

        List<Generator> Questgeneration = new List<Generator>();
        DataContent Read = new DataContent();
        List<Question> ReadFile = new List<Question>();
        

        List<Answer> Default = new List<Answer>();

        int counter = 0;
        int tempcount = 0;

        int answercount = 0;
        int answertempcount = 0;

        public FormQuestionCreator()
        {
            InitializeComponent();
            QuestionTextBox.Enabled = false;
            AnswerStrip.Enabled = false;
            Del_qu_btn.Enabled = false;
            DelAnswer_btn.Enabled = false;

            ///
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            QuestionTextBox.Enabled = true;
            AnswerStrip.Enabled = true;
            ////
            string nameof = "Вопрос " + (counter+1);

            Questgeneration.Add(new Generator(new Question (Default) , new Button(), nameof));
            Questgeneration[counter].CurrBtn1.Tag = counter;

            QuestionPanel.Controls.Add(Questgeneration[counter].CurrBtn1);
            QuestionPanel.Controls[counter].Click += new EventHandler(button_click);
            QuestionPanel.Controls[counter].Leave += new EventHandler(button_leave);
            QuestionPanel.Controls[counter].GotFocus += new EventHandler(button_click);
            counter++;
            ///
        }

        private void Delquestion_Click(object sender, EventArgs e)
        {
            Questgeneration.Remove(Questgeneration[tempcount]);
            QuestionPanel.Controls.Remove(QuestionPanel.Controls[tempcount]);
            counter = Questgeneration.Count;
            int i = 0;
            string nameof; 

            foreach (Button item in QuestionPanel.Controls)
            {
                item.Tag = i;
                nameof = "Вопрос " + (i + 1);
                item.Text = nameof;
                i++;
            }

            
           if(QuestionPanel.Controls.Count == 0)
            {
                QuestionTextBox.Enabled = false;
                AnswerStrip.Enabled = false;
            }
           else
            {
                QuestionPanel.Controls[QuestionPanel.Controls.Count -1].Focus();
                
            }
        }

        private void button_click(object sender, EventArgs e)
        {
           Del_qu_btn.Enabled = true;
           answercount = 0;
           AnswePanel.Controls.Clear();
           tempcount= (int) ((Button)sender).Tag;
            int i = 0;

          QuestionTextBox.Text =  Questgeneration[tempcount].GEtQuestion.Textquestion1;
            

            foreach (var item in Questgeneration[tempcount].GEtQuestion.TAnswer)
            {
                
                AnswePanel.Controls.Add(new TextBox());
                AnswePanel.Controls[answercount].Tag = answercount;
                AnswePanel.Controls[answercount].TextChanged += new EventHandler(TexttoAnswer);
                AnswePanel.Controls[answercount].GotFocus += new EventHandler(FocusAnswer);
                AnswePanel.Controls[answercount].Leave += new EventHandler(LeaveFocusAnswer);

                AnswePanel.Controls[i].Text = item.Text;
                    i++;
                answercount++;
            }
            
        }

        private void button_leave(object sender, EventArgs e)
        {
            Del_qu_btn.Enabled = false;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            Questgeneration[tempcount].GEtQuestion.Textquestion1 = QuestionTextBox.Text; 
        }

        private void AddAnswer_Click(object sender, EventArgs e)
        {
            Questgeneration[tempcount].GEtQuestion.TAnswer.Add(new Answer());
            AnswePanel.Controls.Add(new TextBox());
            AnswePanel.Controls[answercount].Tag = answercount;
            AnswePanel.Controls[answercount].TextChanged += new EventHandler(TexttoAnswer);
            AnswePanel.Controls[answercount].GotFocus += new EventHandler(FocusAnswer);
            AnswePanel.Controls[answercount].Leave += new EventHandler(LeaveFocusAnswer);

            answercount++;
        }

       private void FocusAnswer(object sender, EventArgs e)
        {
           
             DelAnswer_btn.Enabled = true;
                

         int z = Convert.ToInt32(((TextBox)sender).Tag);

          answertempcount = z;
        }

        private void LeaveFocusAnswer(object sender, EventArgs e)
        {
            // DelAnswer_btn.Enabled = false;
           // int z = Convert.ToInt32(((TextBox)sender).Tag);

            //answertempcount = z;
        }

        private void TexttoAnswer(object sender, EventArgs e)
        {
            TextBox txt = ((TextBox)sender);
            answertempcount = Convert.ToInt32( txt.Tag);
            Questgeneration[tempcount].GEtQuestion.TAnswer[answertempcount].Text = txt.Text;
        }

        private void DelAnswer_btn_Click(object sender, EventArgs e)
        {
            

            AnswePanel.Controls.Remove(AnswePanel.Controls[answertempcount]);
            Questgeneration[tempcount].GEtQuestion.TAnswer.Remove(Questgeneration[tempcount].GEtQuestion.TAnswer[answertempcount]);
            

            answercount = Questgeneration[tempcount].GEtQuestion.TAnswer.Count;
            int i = 0;

            foreach (TextBox item in AnswePanel.Controls)
            {
                item.Tag = i;
                i++;
            }

            

            if (AnswePanel.Controls.Count == 0)
            {
                DelAnswer_btn.Enabled = false;
            }
            else
            {
                AnswePanel.Controls[AnswePanel.Controls.Count-1].Select();

            }

        }

        private void FormQuestionCreator_Load(object sender, EventArgs e)
        {

        }

        private void загрузитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog OPF = new OpenFileDialog();
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    ReadFile = Read.ReadData(OPF.FileName);
                    Questgeneration.Clear();
                    counter = 0;
                    tempcount = 0;
                    answercount = 0;
                    answertempcount = 0;

                    foreach (Question item in ReadFile)
                    {
                        string nameof = "Вопрос " + (counter + 1);

                        Questgeneration.Add(new Generator(item, new Button(), nameof));
                        Questgeneration[counter].CurrBtn1.Tag = counter;

                        QuestionPanel.Controls.Add(Questgeneration[counter].CurrBtn1);
                        QuestionPanel.Controls[counter].Click += new EventHandler(button_click);
                        QuestionPanel.Controls[counter].Leave += new EventHandler(button_leave);
                        QuestionPanel.Controls[counter].GotFocus += new EventHandler(button_click);

                        foreach (Answer ans in item.TAnswer)
                        {
                            //  Questgeneration[counter].GEtQuestion.TAnswer.Add(ans);
                            AnswePanel.Controls.Add(new TextBox());
                            //  AnswePanel.Controls[answercount]
                            AnswePanel.Controls[answercount].Tag = answercount;
                            AnswePanel.Controls[answercount].TextChanged += new EventHandler(TexttoAnswer);
                            AnswePanel.Controls[answercount].GotFocus += new EventHandler(FocusAnswer);
                            AnswePanel.Controls[answercount].Leave += new EventHandler(LeaveFocusAnswer);
                            //AnswePanel.Controls[answercount].

                            answercount++;
                        }
                        answercount = 0;

                        counter++;
                    }

                    QuestionTextBox.Enabled = true;
                    AnswerStrip.Enabled = true;
                    Del_qu_btn.Enabled = true;
                    DelAnswer_btn.Enabled = true;

                    QuestionPanel.Controls[0].Select();

                }
            }
            catch { }
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                SaveFileDialog SaveFile = new SaveFileDialog();
                //SaveFile.Filter = "txt files(*.xml)";

                if (SaveFile.ShowDialog() == DialogResult.OK)
                {
                    
                }

            }

            catch
            {

            }
        }
    }
}
