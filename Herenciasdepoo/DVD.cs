using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Herenciasdepoo
{
    class DVD : Item
    {
        public string _director { get; set; }
        public string getdirector()
        {
            return " el director es: " + _director;
        }
    }
}
