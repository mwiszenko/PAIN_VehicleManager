using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehicles
{
    public partial class MainForm : Form
    {
        readonly Document document = new Document();
        public MainForm()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void AddViewToolStripButton_Click(object sender, EventArgs e)
        {
            VehiclesForm vehiclesForm = new VehiclesForm(document)
            {
                MdiParent = this
            };
            vehiclesForm.FormClosing += MainForm_FormClosing;
            vehiclesForm.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MdiChildren.Length <= 1 && e.CloseReason != CloseReason.MdiFormClosing)
            {
                e.Cancel = true;
                MessageBox.Show("Cannot close the last remaining view.");
            }
        }
    }
}
