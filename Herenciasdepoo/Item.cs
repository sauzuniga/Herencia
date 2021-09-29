using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciasdepoo
{
    class Item
    {
        private string _title;
        public string playingTime { get; set; }
        private string _comment;
        public string getcomment()
        {
            return _comment;
            
        }
        public virtual void setcomment(string comment)
        {
            _comment = comment;
        }
        public string gettitle()
        {
            return _title;
        }
        public void settitle(string title)
        {
            _title = title;
        }
       public string print()
        {

        }
    }
}
