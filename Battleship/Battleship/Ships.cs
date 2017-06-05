using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Battleship
{
     public class Ships
    {
        public  static List<Ships> listship = new List<Ships>();

       public int size;
        public int bang = 0;
        public Ships(int a)
        {
            size = a;
          listship.Add(this);
        }
        
    }
}
