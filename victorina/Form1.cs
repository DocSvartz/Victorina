using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace victorina
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
            
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Reset_btn.Click += new EventHandler(ResetTable);
            this.пробныеЗаданияToolStripMenuItem.Click += new EventHandler(ResetTable);

            button1.Enabled = false;
            Reset_btn.Enabled = false;

            richTextBox1.Text = startinfo;


           
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
            
            List<CheckBox> CheckB = new List<CheckBox>();
            //////////////////////////////////////////////////////////////////////////

            if (check <= myWonpr.Length && check != 0) // текстовая надпись со счетом
            {
                checkRezult(myWonpr[check - 1]);

                Score_label.Text = score.ToString();
            }

            groupBox2.Controls.Clear();


            if (check < myWonpr.Length)  // Назначение надписей для вопроса и ответов
            {
                QuestionCounter.Text = (check + 1).ToString();
                richTextBox1.Text = myWonpr[check].Textquestion1;

                int countBox = 0;
                int LocateY = 20;
                                                
                    foreach (var elem in myWonpr[check].TAnswer)
                    {

                        CheckB.Add(new CheckBox());
                        CheckB[countBox].Text = elem.Text;
                        countBox++;
                    }


                int i = 0;

                foreach (var item in CheckB)
                {
                    groupBox2.Controls.Add(item);
                    groupBox2.Controls[i].Location = new Point(0, LocateY);
                    LocateY += groupBox2.Controls[i].Size.Height;
                    i++;
                }
                            
            }
            
            check++;

            if ( check == myWonpr.Length+1)
            {
                button1.Enabled = false;
            }

        }

        private void Reset_btn_Click(object sender, EventArgs e)
        {
           
        }

        private void LoadData_mB_Click(object sender, EventArgs e)
        {
            try {
                OpenFileDialog OPF = new OpenFileDialog();
                if (OPF.ShowDialog() == DialogResult.OK)
                {
                    myWonpr = LoadData(OPF.FileName).ToArray();

                    MaxQuestCount.Text = (myWonpr.Length).ToString();

                    Attention_lb.Visible = false;

                    ResetTable(sender, e);

                    button1.Enabled = true;
                    Reset_btn.Enabled = true;

                    OPF.Dispose();
                    OPF = null;
                    GC.Collect();
                   
                }
                else
                {
                    OPF.Dispose();
                    OPF = null;
                    GC.Collect();

                }

               
            }
            catch(Exception )
            {
                
            }

            
        }

        private void пробныеЗаданияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try {
                GlobalData.CreateNew("TEST.xml");
                myWonpr = LoadData("TEST.xml").ToArray();

                MaxQuestCount.Text = (myWonpr.Length).ToString();

                button1.Enabled = true;
                Reset_btn.Enabled = true;

            }

            catch(Exception)
            {
                MessageBox.Show("!!!!");
            }
        }
    }
}
