using System;
using System.Collections.Generic;

namespace victorina
{
    class Question
    {
        private string Textquestion;
        private List<Answer> tAnswer;
        
        private int iCorrectAnswer = 0;


        public string Textquestion1
        {
            get
            {
                return Textquestion;
            }

            set
            {
                Textquestion = value;
            }

        }

        public int CorrectAnswer
        {
            get
            {
                return iCorrectAnswer;
            }


        }

        public List<Answer> TAnswer
        {
            get
            {
                return tAnswer;
            }
            
        }

      /*  public Question(string textquestion, Answer[] answer)
        {
            Textquestion = textquestion;

            int temp = 0;
            Random rand = new Random();
            bool[] checkarry = new bool[answer.Length];
            Answer[] nAnswer = new Answer[answer.Length];

            


            int count = 0;

            while (count < answer.Length)   // алгоритм Фишера-Йетса
            {
                int rsort = rand.Next(0, answer.Length);

                if (!checkarry[rsort])
                {
                    nAnswer[count++] = answer[rsort];
                    checkarry[rsort] = true;
                }
            }



            tAnser1 = nAnswer[0].Text;
            tAnser2 = nAnswer[1].Text;
            tAnser3 = nAnswer[2].Text;

            foreach (var elem in nAnswer)
            {

                if (elem.TrueAnnswer)
                {
                    iCorrectAnswer = temp;
                }
                temp++;

            }


        } */

        public Question(List<Answer> answer,string textquestion = "Тест")
        {
            Textquestion = textquestion;


            //////////////////////////////////////////////         
           Random rand = new Random();
            bool[] checkarry = new bool[answer.Count];
           List<Answer> nAnswer = new List<Answer>();
                        
            int count = 0;

            while (count < answer.Count)   // алгоритм Фишера-Йетса
            {
              int rsort = rand.Next(0, answer.Count);

                if (!checkarry[rsort])
                {
                    nAnswer[count++] = answer[rsort];
                    checkarry[rsort] = true;
                }
            }
            
            //////////////////////////////////////////////

            tAnswer = nAnswer;

            foreach (Answer item in nAnswer)
            {
                if(item.TrueAnnswer)
                {
                    iCorrectAnswer++;
                }
            }

        
        }
        
    }
}
