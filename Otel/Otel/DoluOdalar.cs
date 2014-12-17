using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel
{
    public partial class DoluOdalar : Form
    {
        public DoluOdalar()
        {
            InitializeComponent();
        }

        private void DoluOdalar_Load(object sender, EventArgs e)
        {
            this.LayoutMdi(MdiLayout.Cascade);
        }
    }
}
