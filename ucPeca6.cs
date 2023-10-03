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
    public partial class ucPeca6 : ucPecaMae
    {
        public ucPeca6()
        {
            InitializeComponent();

            matrizPecaMae = new int[4, 4]
            {
                { 0, 6, 6, 0 },
                { 0, 6, 0, 0 },
                { 0, 6, 0, 0 },
                { 0, 0, 0, 0 }
            };
        }
    }
}
