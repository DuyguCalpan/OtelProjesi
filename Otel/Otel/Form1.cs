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
    public partial class Form1 : Form
    {
        BosOdalar bosOda;
        DoluOdalar doluOda;
        MusteriAra ara;

        public Form1()
        {
            InitializeComponent();
        }

        private void boşOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (bosOda == null || bosOda.IsDisposed)
            {
                bosOda = new BosOdalar();
                bosOda.MdiParent = this;
                bosOda.Show();
            }
            else
            {
                bosOda.Focus();
            }

            bosOda.WindowState = FormWindowState.Maximized;
        }

        private void doluOdalarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (doluOda == null || doluOda.IsDisposed)
            {
                doluOda = new DoluOdalar();
                doluOda.MdiParent = this;
                doluOda.Show();
            }
            else
            {
                doluOda.Focus();
            }

            doluOda.WindowState = FormWindowState.Maximized;
        }

        private void müşteriAraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (ara == null || ara.IsDisposed)
            {
                ara = new MusteriAra();
                ara.MdiParent = this;
                ara.Show();
            }
            else
            {
                ara.Focus();
            }

            ara.WindowState = FormWindowState.Maximized;
        }

       
    }
}
