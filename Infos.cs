using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WazneKody2
{

    public class Infos
    {
        private string info1;
        private string info2;
        public string info3;


        public Infos(string s1, string s2, string s3)
        {
            info1 = s1;
            info2 = s2;
            info2 = s3;
        }
        public string Info1
        {
            get { return this.info1; }
            set { this.info1 = value; }
        }

        public string Info2
        {
            get { return this.info2; }
            set { this.info2 = value; }
        }
        public string Info3
        {
            get { return this.info3; }
            set { this.info3 = value; }
        }

        public override string ToString()
        {
            return this.info2;
        }
    }
}
