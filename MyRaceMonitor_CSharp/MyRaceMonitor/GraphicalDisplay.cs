using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AppLayer;
using System.Windows.Forms;

namespace MyRaceMonitor
{
    public partial class GraphicalDisplay : SubjectManager
    {
        

        public GraphicalDisplay()
        {
            InitializeComponent();
        }

        public override void UpdateDisplay()
        {
            throw new NotImplementedException();
        }
    }
}
