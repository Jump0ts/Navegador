using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class VHistorial : Form
    {
        public VHistorial()
        {
            InitializeComponent();
        }

        private void VHistorial_Load(object sender, EventArgs e)
        {
            Singleton.getControl().rellenarHist(listHist);
            if (listHist.Items.Count < 0) listHist.SelectedIndex = 0;
        }

        private void btnIrHist_Click(object sender, EventArgs e)
        {
            Singleton.getControl().navegar(listHist.SelectedItem.ToString());
            Singleton.getControl().rellenarHist(listHist);
            listHist.Refresh();
        }

        private void btnEliminarHist_Click(object sender, EventArgs e)
        {
            Singleton.getControl().eliminarHist(listHist.SelectedIndex);
            Singleton.getControl().rellenarHist(listHist);
            listHist.Refresh();
            if (listHist.Items.Count < 0) listHist.SelectedIndex = 0;
        }

        private void btnEliminarTodoHist_Click(object sender, EventArgs e)
        {
            Singleton.getControl().eliminarTodoHist(listHist);
            listHist.Refresh();
        }
    }
}
