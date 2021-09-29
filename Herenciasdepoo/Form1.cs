using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Herenciasdepoo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            DVD dVd = new DVD();
            dVd._director= "Ryan Gosling";
            dVd.settitle("Maze Runner Free");
            dVd.setcomment("El final de la trilogia, que dara final a toda esta epica historia");
            dVd.playingTime = "120 minutos aproximadamente";
           
        }
    }
}
