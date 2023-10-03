using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tetris
{
    public partial class ucPeca7 : ucPecaMae
    {
        public ucPeca7()
        {
            InitializeComponent();
            matrizPecaMae = new int[4, 4]
            {
                { 0, 0, 7, 7 },
                { 0, 7, 7, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }
}
