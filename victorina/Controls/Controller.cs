

using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml.Linq;

namespace victorina
{
    public partial class Form1 : Form
    {
        float score;
        int check = 0;
        string startinfo = "Нажми кноппку для начала, Падлец!!!";
        static DataContent GlobalData = new DataContent();
      
        Question[] myWonpr;// = LoadData(localfile).ToArray();

        
        void checkRezult(Question Que)
        {
           int trAnswer = 0;
           int number = 0;
           
            foreach (Answer tempAnsw in Que.TAnswer)
            {
                CheckBox tmp = (CheckBox)groupBox2.Controls[number];

                if (!tempAnsw.TrueAnnswer && tmp.Checked)
                {
                    trAnswer--;
                    
                }

                if (tempAnsw.TrueAnnswer)
                {
                    
                    if (tmp.Checked)
                    {
                        trAnswer++;
                    }
                   
                }

                number++;
            }

            if (Que.CorrectAnswer == trAnswer)
            {
                score++;
            }
            else
            {
                float temp;
                temp = (float)trAnswer / (float)Que.CorrectAnswer;

                if(temp > 0 )
                {
                    score += temp;
                }


            }
           
        }

                     

      void ResetTable (object sender, EventArgs e)
        {
            Attention_lb.Visible = false;
            QuestionCounter.Text = "0";
            check = 0;
            score = 0;
            Score_label.Text = "0";
            button1.Enabled = true;
            richTextBox1.Text = startinfo;
            groupBox2.Controls.Clear();
        }

        

       List<Question> LoadData(string filename)
        {
           
            return   GlobalData.ReadData(filename);
        }



    }
}
