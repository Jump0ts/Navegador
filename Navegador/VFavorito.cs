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
    public partial class VFavorito : Form
    {
        public VFavorito()
        {
            InitializeComponent();
        }

        private void VFavorito_Load(object sender, EventArgs e)
        {
            Singleton.getControl().rellenarFav(listFav);
            if(listFav.Items.Count<0)listFav.SelectedIndex = 0;
        }

        private void btnIrFav_Click(object sender, EventArgs e)
        {
            Singleton.getControl().navegar(listFav.SelectedItem.ToString());
        }

        private void btnEliminarFav_Click(object sender, EventArgs e)
        {
            Singleton.getControl().eliminarFav(listFav.SelectedItem.ToString());
            Singleton.getControl().rellenarFav(listFav);
            listFav.Refresh();
            if (listFav.Items.Count < 0) listFav.SelectedIndex = 0;
            
        }
    }
}
