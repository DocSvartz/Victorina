using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace victorina
{
    class DataContent
    {

        public bool CreateNew(string fileName)
        {
            // string fileName = "base.xml";

            XDocument Data = new XDocument(
                new XElement("Questions",
                    new XElement("Question_1",
                        new XAttribute("TXT", "Доктор Попов: Где живой огурец?X"),
                        new XElement("Answers",
                            new XElement("A0",
                                new XAttribute("txt", "В земле"),
                                new XAttribute("bool", true)),
                            new XElement("A1",
                                new XAttribute("txt", "В воде"),
                                new XAttribute("bool", false)),
                            new XElement("A2",
                                new XAttribute("txt", "У негра"),
                                new XAttribute("bool", false))
                                ))
                                ,
                new XElement("Question_2",
                        new XAttribute("TXT", "Доктор Швартц: Где Карлик ?X"),
                         new XElement("Answers",
                            new XElement("A0",
                                new XAttribute("txt", "В земле"),
                                new XAttribute("bool", false)),
                            new XElement("A1",
                                new XAttribute("txt", "На луне"),
                                new XAttribute("bool", true)),
                            new XElement("A2",
                                new XAttribute("txt", "У негра"),
                                new XAttribute("bool", false))
                                ))
                                ,

                new XElement("Question_3",
                        new XAttribute("TXT", "Коллекционер: Где живой он?X"),
                        new XElement("Answers",
                            new XElement("A0",
                                new XAttribute("txt", "В руке"),
                                new XAttribute("bool", false)),
                            new XElement("A1",
                                new XAttribute("txt", "В банке"),
                                new XAttribute("bool", false)),
                            new XElement("A2",
                                new XAttribute("txt", "У негра"),
                                new XAttribute("bool", true))
                                ))


                ));


            Data.Save(fileName);

            return true;
        }

        public List<Question> ReadData(string fileName)
        {
            try {
                        string QuestTXT = "TXT";
                        string AnswerTXT = "AnsTXT";
                        bool answerTrue = false;

                        List<Question> list = new List<Question>();
                        List<Answer> answer = new List<Answer>();

                        XDocument doc = XDocument.Load(fileName);

                        foreach (XElement elem in doc.Root.Elements())
                        {

                            foreach (XAttribute atr in elem.Attributes())
                            {
                                QuestTXT = atr.Value; // текст вопроса 

                            }

                            foreach (XElement el in elem.Elements())
                            {

                                foreach (XElement queshion in el.Elements())
                                {

                                    foreach (XAttribute eatr in queshion.Attributes()) // тексты ответов
                                    {
                                        if (eatr.Name == "bool")
                                        {
                                            answerTrue = Convert.ToBoolean(eatr.Value);
                                        }

                                        if (eatr.Name == "txt")
                                        {
                                            AnswerTXT = eatr.Value;
                                        }


                                    }

                                    answer.Add(new Answer(AnswerTXT, answerTrue));
                                }
                                list.Add(new Question(answer, QuestTXT));
                                answer.Clear();


                            }

                        }

                        return list;
            }
            catch (Exception )
            {
                MessageBox.Show("Файл Поврежден!!");
                return null;
            }


    }
    }
}
