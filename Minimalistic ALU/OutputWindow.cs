using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Minimalistic_ALU
{
    public partial class OutputWindow : Form
    {
        public OutputWindow(int co,int r1,int r0)
        {
            InitializeComponent();
            _cout.Text = $"{co}";
            _rone.Text = $"{r1}";
            _rnot.Text = $"{r0}";
        }
    }
}
