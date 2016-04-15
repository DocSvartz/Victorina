using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace victorina
{
    class Answer
    {
        private string text;
        private bool trueAnnswer;

        public Answer(string txt, bool bgood = false)
        {
            Text = txt;
            TrueAnnswer = bgood;
        }

        public string Text
        {
            get
            {
                return text;
            }

            set
            {
                text = value;
            }
        }

        public bool TrueAnnswer
        {
            get
            {
                return trueAnnswer;
            }

            set
            {
                trueAnnswer = value;
            }
        }
    }
}
