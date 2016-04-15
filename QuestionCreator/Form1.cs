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
            string nameof = "Вопрос " + (counter+1);

            Questgeneration.Add(new Generator(new Question (Default) , new Button(), nameof));
            Questgeneration[counter].CurrBtn1.Tag = counter;

            QuestionPanel.Controls.Add(Questgeneration[counter].CurrBtn1);
            QuestionPanel.Controls[counter].Click += new EventHandler(button_click);
            QuestionPanel.Controls[counter].Leave += new EventHandler(button_leave);
            QuestionPanel.Controls[counter].GotFocus += new EventHandler(button_click);
            counter++;
        }

        private void Delquestion_Click(object sender, EventArgs e)
        {
            Questgeneration.Remove(Questgeneration[tempcount]);
            QuestionPanel.Controls.Remove(QuestionPanel.Controls[tempcount]);
            counter = Questgeneration.Count;
            int i = 0;

            foreach (Button item in QuestionPanel.Controls)
            {
                item.Tag = i;
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
                AnswePanel.Controls[answercount].MouseClick += new MouseEventHandler(FocusAnswer);
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
            AnswePanel.Controls[answercount].MouseClick += new MouseEventHandler(FocusAnswer);
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
            DelAnswer_btn.Enabled = false;
        }

        private void TexttoAnswer(object sender, EventArgs e)
        {
            TextBox txt = ((TextBox)sender);
            answertempcount = Convert.ToInt32( txt.Tag);
            Questgeneration[tempcount].GEtQuestion.TAnswer[answertempcount].Text = txt.Text;
        }

        private void DelAnswer_btn_Click(object sender, EventArgs e)
        {
            Questgeneration[tempcount].GEtQuestion.TAnswer.Remove(Questgeneration[tempcount].GEtQuestion.TAnswer[answertempcount]);
            AnswePanel.Controls.Remove(AnswePanel.Controls[answertempcount]);

            answercount = Questgeneration[tempcount].GEtQuestion.TAnswer.Count;
            int i = 0;

            foreach (TextBox item in AnswePanel.Controls)
            {
                item.Tag = i;
                i++;
            }

            

        }

        private void FormQuestionCreator_Load(object sender, EventArgs e)
        {

        }
    }
}
