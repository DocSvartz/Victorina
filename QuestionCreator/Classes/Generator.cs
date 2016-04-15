using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using victorina;

namespace QuestionCreator
{
    class Generator
    {
        Question prQestion;
        Button CurrBtn;
        string ViewQuest;

        public Button CurrBtn1
        {
            get
            {
                return CurrBtn;
            }
                        
        }

        internal Question GEtQuestion
        {
            get
            {
                return prQestion;
            }

            
        }

        public Generator(Question Q, Button Btn, string Name)
        {
            prQestion = Q;
            CurrBtn = Btn;
            ViewQuest = Name;
            CurrBtn.Text = Name;

            
        }

    }
}
