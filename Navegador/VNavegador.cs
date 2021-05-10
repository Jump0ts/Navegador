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
    public partial class VNavegador : Form
    {
        VFavorito vFavoritos;
        VHistorial vHistorial;
        public VNavegador()
        {
            InitializeComponent();
        }

        private void saveAsTS_Click(object sender, EventArgs e)
        {
            web.ShowSaveAsDialog();
        }

        private void imprimirTS_Click(object sender, EventArgs e)
        {
            web.ShowPrintDialog();
        }

        private void vistaPTS_Click(object sender, EventArgs e)
        {
            web.ShowPrintPreviewDialog();
        }

        private void configurarTS_Click(object sender, EventArgs e)
        {
            web.ShowPageSetupDialog();
        }

        private void favTS_Click(object sender, EventArgs e)
        {
            vFavoritos = new VFavorito();
            vFavoritos.ShowDialog();
        }


        private void VNavegador_Load(object sender, EventArgs e)
        {
            Singleton.getControl().navegar("www.google.es");
            Singleton.getControl().rellenarBuscadores(comboBuscadoresTS);
            
        }

        private void historialTS_Click(object sender, EventArgs e)
        {
            vHistorial = new VHistorial();
            vHistorial.ShowDialog();
        }

        private void busquedaTS_Click(object sender, EventArgs e)
        {
            Singleton.getControl().navegar(txtDireccion.Text);
        }

        private void propiedadesTS_Click(object sender, EventArgs e)
        {
            web.ShowPropertiesDialog();
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            web.GoBack();
        }

        private void btnAdelante_Click(object sender, EventArgs e)
        {
            web.GoForward();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            web.Refresh();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Singleton.getControl().navegar(txtPaginaInicioTS.Text);
        }

        private void btnNewTab_Click(object sender, EventArgs e)
        {
            TabPage pestana = new TabPage();
            controlPestana.Controls.Add(pestana);
            controlPestana.SelectTab(controlPestana.TabCount - 1);
            web = new WebBrowser() { ScriptErrorsSuppressed = true };
            web.Parent = pestana;
            web.Dock = DockStyle.Fill;
            Singleton.getControl().navegar(txtPaginaInicioTS.Text);
            web.DocumentCompleted += web_DocumentCompleted;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Singleton.getControl().navegar(txtDireccion.Text);
        }

        private void txtDireccion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) Singleton.getControl().navegar(txtDireccion.Text);
        }

        private void salirTS_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFav_Click(object sender, EventArgs e)
        {
            Singleton.getControl().anadirFav(txtDireccion.Text);
        }

        private void web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            controlPestana.SelectedTab.Text = web.DocumentTitle;
        }

        private void comboBuscadoresTS_SelectedIndexChanged(object sender, EventArgs e)
        {
            Singleton.getControl().cambiaBuscador(comboBuscadoresTS.SelectedIndex);
        }

        private void btnCerrarPestanaTS_Click(object sender, EventArgs e)
        {
            if(controlPestana.SelectedTab != null)
            {
                controlPestana.TabPages.Remove(controlPestana.SelectedTab);
                if (controlPestana.TabCount != 0)
                {
                    controlPestana.SelectTab(controlPestana.TabCount - 1);
                }
            }
        }
    }
}
