using System.Windows.Forms;

namespace WindowsFormsApp1
{
    partial class VNavegador
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.toolStripContainer1 = new System.Windows.Forms.ToolStripContainer();
            this.controlPestana = new System.Windows.Forms.TabControl();
            this.pestana = new System.Windows.Forms.TabPage();
            this.web = new System.Windows.Forms.WebBrowser();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.imprimirTS = new System.Windows.Forms.ToolStripMenuItem();
            this.vistaPTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.configurarTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.salirTS = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.favTS = new System.Windows.Forms.ToolStripMenuItem();
            this.historialTS = new System.Windows.Forms.ToolStripMenuItem();
            this.paginicioTS = new System.Windows.Forms.ToolStripMenuItem();
            this.txtPaginaInicioTS = new System.Windows.Forms.ToolStripTextBox();
            this.busquedaTS = new System.Windows.Forms.ToolStripMenuItem();
            this.comboBuscadoresTS = new System.Windows.Forms.ToolStripComboBox();
            this.propiedadesTS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnAtras = new System.Windows.Forms.ToolStripButton();
            this.btnAdelante = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.btnHome = new System.Windows.Forms.ToolStripButton();
            this.btnFav = new System.Windows.Forms.ToolStripButton();
            this.btnNewTab = new System.Windows.Forms.ToolStripButton();
            this.btnCerrarPestanaTS = new System.Windows.Forms.ToolStripButton();
            this.lblDireccion = new System.Windows.Forms.ToolStripLabel();
            this.txtDireccion = new System.Windows.Forms.ToolStripTextBox();
            this.btnBuscar = new System.Windows.Forms.ToolStripButton();
            this.toolStripContainer1.ContentPanel.SuspendLayout();
            this.toolStripContainer1.TopToolStripPanel.SuspendLayout();
            this.toolStripContainer1.SuspendLayout();
            this.controlPestana.SuspendLayout();
            this.pestana.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStripContainer1
            // 
            // 
            // toolStripContainer1.ContentPanel
            // 
            this.toolStripContainer1.ContentPanel.Controls.Add(this.controlPestana);
            this.toolStripContainer1.ContentPanel.Controls.Add(this.menuStrip1);
            this.toolStripContainer1.ContentPanel.Size = new System.Drawing.Size(1160, 890);
            this.toolStripContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.toolStripContainer1.Location = new System.Drawing.Point(0, 0);
            this.toolStripContainer1.Name = "toolStripContainer1";
            this.toolStripContainer1.Size = new System.Drawing.Size(1160, 956);
            this.toolStripContainer1.TabIndex = 0;
            this.toolStripContainer1.Text = "toolStripContainer1";
            // 
            // toolStripContainer1.TopToolStripPanel
            // 
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.menuStrip2);
            this.toolStripContainer1.TopToolStripPanel.Controls.Add(this.toolStrip1);
            // 
            // controlPestana
            // 
            this.controlPestana.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlPestana.Controls.Add(this.pestana);
            this.controlPestana.Location = new System.Drawing.Point(0, 3);
            this.controlPestana.Name = "controlPestana";
            this.controlPestana.SelectedIndex = 0;
            this.controlPestana.Size = new System.Drawing.Size(1160, 887);
            this.controlPestana.TabIndex = 1;
            // 
            // pestana
            // 
            this.pestana.Controls.Add(this.web);
            this.pestana.Location = new System.Drawing.Point(4, 29);
            this.pestana.Name = "pestana";
            this.pestana.Padding = new System.Windows.Forms.Padding(3);
            this.pestana.Size = new System.Drawing.Size(1152, 854);
            this.pestana.TabIndex = 1;
            this.pestana.Text = "tabPage2";
            this.pestana.UseVisualStyleBackColor = true;
            // 
            // web
            // 
            this.web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.web.Location = new System.Drawing.Point(3, 3);
            this.web.MinimumSize = new System.Drawing.Size(20, 20);
            this.web.Name = "web";
            this.web.Size = new System.Drawing.Size(1146, 848);
            this.web.TabIndex = 0;
            this.web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.web_DocumentCompleted);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Location = new System.Drawing.Point(0, -32);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(202, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            this.menuStrip2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem1,
            this.ayudaToolStripMenuItem,
            this.propiedadesTS});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1160, 33);
            this.menuStrip2.TabIndex = 0;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // archivoToolStripMenuItem1
            // 
            this.archivoToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveAsTS,
            this.toolStripSeparator,
            this.imprimirTS,
            this.vistaPTS,
            this.toolStripSeparator1,
            this.configurarTS,
            this.toolStripSeparator2,
            this.salirTS});
            this.archivoToolStripMenuItem1.Name = "archivoToolStripMenuItem1";
            this.archivoToolStripMenuItem1.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem1.Text = "&Archivo";
            // 
            // saveAsTS
            // 
            this.saveAsTS.Image = global::WindowsFormsApp1.Properties.Resources.SaveAs_16x;
            this.saveAsTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveAsTS.Name = "saveAsTS";
            this.saveAsTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.saveAsTS.Size = new System.Drawing.Size(294, 34);
            this.saveAsTS.Text = "Guardar Como";
            this.saveAsTS.Click += new System.EventHandler(this.saveAsTS_Click);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(291, 6);
            // 
            // imprimirTS
            // 
            this.imprimirTS.Image = global::WindowsFormsApp1.Properties.Resources.Print_128x;
            this.imprimirTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.imprimirTS.Name = "imprimirTS";
            this.imprimirTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.imprimirTS.Size = new System.Drawing.Size(294, 34);
            this.imprimirTS.Text = "Imprimir";
            this.imprimirTS.Click += new System.EventHandler(this.imprimirTS_Click);
            // 
            // vistaPTS
            // 
            this.vistaPTS.Image = global::WindowsFormsApp1.Properties.Resources.PrintPreviewDialog_16x;
            this.vistaPTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.vistaPTS.Name = "vistaPTS";
            this.vistaPTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.vistaPTS.Size = new System.Drawing.Size(294, 34);
            this.vistaPTS.Text = "Vista Previa";
            this.vistaPTS.Click += new System.EventHandler(this.vistaPTS_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(291, 6);
            // 
            // configurarTS
            // 
            this.configurarTS.Image = global::WindowsFormsApp1.Properties.Resources.ConfigurationEditor_256x;
            this.configurarTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.configurarTS.Name = "configurarTS";
            this.configurarTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.configurarTS.Size = new System.Drawing.Size(294, 34);
            this.configurarTS.Text = "Configurar";
            this.configurarTS.Click += new System.EventHandler(this.configurarTS_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(291, 6);
            // 
            // salirTS
            // 
            this.salirTS.Name = "salirTS";
            this.salirTS.Size = new System.Drawing.Size(294, 34);
            this.salirTS.Text = "Salir";
            this.salirTS.Click += new System.EventHandler(this.salirTS_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.favTS,
            this.historialTS,
            this.paginicioTS,
            this.busquedaTS});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(139, 29);
            this.ayudaToolStripMenuItem.Text = "&Configuracion";
            // 
            // favTS
            // 
            this.favTS.Image = global::WindowsFormsApp1.Properties.Resources.Favorite_24x;
            this.favTS.Name = "favTS";
            this.favTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.favTS.Size = new System.Drawing.Size(246, 34);
            this.favTS.Text = "Favoritos";
            this.favTS.Click += new System.EventHandler(this.favTS_Click);
            // 
            // historialTS
            // 
            this.historialTS.Image = global::WindowsFormsApp1.Properties.Resources.History_16xLG;
            this.historialTS.Name = "historialTS";
            this.historialTS.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.H)));
            this.historialTS.Size = new System.Drawing.Size(246, 34);
            this.historialTS.Text = "Historial";
            this.historialTS.Click += new System.EventHandler(this.historialTS_Click);
            // 
            // paginicioTS
            // 
            this.paginicioTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.txtPaginaInicioTS});
            this.paginicioTS.Name = "paginicioTS";
            this.paginicioTS.Size = new System.Drawing.Size(246, 34);
            this.paginicioTS.Text = "Página de Inicio";
            // 
            // txtPaginaInicioTS
            // 
            this.txtPaginaInicioTS.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtPaginaInicioTS.Name = "txtPaginaInicioTS";
            this.txtPaginaInicioTS.Size = new System.Drawing.Size(150, 31);
            this.txtPaginaInicioTS.Text = "www.google.es";
            // 
            // busquedaTS
            // 
            this.busquedaTS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.comboBuscadoresTS});
            this.busquedaTS.Image = global::WindowsFormsApp1.Properties.Resources.SearchProperty_48x;
            this.busquedaTS.Name = "busquedaTS";
            this.busquedaTS.Size = new System.Drawing.Size(246, 34);
            this.busquedaTS.Text = "Búsqueda";
            this.busquedaTS.Click += new System.EventHandler(this.busquedaTS_Click);
            // 
            // comboBuscadoresTS
            // 
            this.comboBuscadoresTS.Name = "comboBuscadoresTS";
            this.comboBuscadoresTS.Size = new System.Drawing.Size(150, 33);
            this.comboBuscadoresTS.SelectedIndexChanged += new System.EventHandler(this.comboBuscadoresTS_SelectedIndexChanged);
            // 
            // propiedadesTS
            // 
            this.propiedadesTS.Name = "propiedadesTS";
            this.propiedadesTS.Size = new System.Drawing.Size(127, 29);
            this.propiedadesTS.Text = "&Propiedades";
            this.propiedadesTS.Click += new System.EventHandler(this.propiedadesTS_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAtras,
            this.btnAdelante,
            this.btnRefresh,
            this.btnHome,
            this.btnFav,
            this.btnNewTab,
            this.btnCerrarPestanaTS,
            this.lblDireccion,
            this.txtDireccion,
            this.btnBuscar});
            this.toolStrip1.Location = new System.Drawing.Point(4, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(929, 33);
            this.toolStrip1.TabIndex = 1;
            // 
            // btnAtras
            // 
            this.btnAtras.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAtras.Image = global::WindowsFormsApp1.Properties.Resources.Backward_256x;
            this.btnAtras.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(34, 28);
            this.btnAtras.Text = "Atrás";
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnAdelante
            // 
            this.btnAdelante.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnAdelante.Image = global::WindowsFormsApp1.Properties.Resources.Forward_256x;
            this.btnAdelante.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnAdelante.Name = "btnAdelante";
            this.btnAdelante.Size = new System.Drawing.Size(34, 28);
            this.btnAdelante.Text = "Adelante";
            this.btnAdelante.Click += new System.EventHandler(this.btnAdelante_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnRefresh.Image = global::WindowsFormsApp1.Properties.Resources.Refresh_32x;
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(34, 28);
            this.btnRefresh.Text = "Refrescar";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnHome
            // 
            this.btnHome.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnHome.Image = global::WindowsFormsApp1.Properties.Resources.Home_16x;
            this.btnHome.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(34, 28);
            this.btnHome.Text = "Inicio";
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnFav
            // 
            this.btnFav.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnFav.Image = global::WindowsFormsApp1.Properties.Resources.FavoriteOutline_16x;
            this.btnFav.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnFav.Name = "btnFav";
            this.btnFav.Size = new System.Drawing.Size(34, 28);
            this.btnFav.Text = "Añadir a Favoritos";
            this.btnFav.Click += new System.EventHandler(this.btnFav_Click);
            // 
            // btnNewTab
            // 
            this.btnNewTab.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnNewTab.Image = global::WindowsFormsApp1.Properties.Resources.Tab_24x;
            this.btnNewTab.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNewTab.Name = "btnNewTab";
            this.btnNewTab.Size = new System.Drawing.Size(34, 28);
            this.btnNewTab.Text = "Nueva Pestaña";
            this.btnNewTab.Click += new System.EventHandler(this.btnNewTab_Click);
            // 
            // btnCerrarPestanaTS
            // 
            this.btnCerrarPestanaTS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCerrarPestanaTS.Image = global::WindowsFormsApp1.Properties.Resources.F12_CloseErrorBoxGrey;
            this.btnCerrarPestanaTS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCerrarPestanaTS.Name = "btnCerrarPestanaTS";
            this.btnCerrarPestanaTS.Size = new System.Drawing.Size(34, 28);
            this.btnCerrarPestanaTS.Text = "Cerrar Pestaña";
            this.btnCerrarPestanaTS.Click += new System.EventHandler(this.btnCerrarPestanaTS_Click);
            // 
            // lblDireccion
            // 
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(89, 28);
            this.lblDireccion.Text = "Dirección:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(500, 33);
            this.txtDireccion.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtDireccion_KeyDown);
            // 
            // btnBuscar
            // 
            this.btnBuscar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnBuscar.Image = global::WindowsFormsApp1.Properties.Resources.Search_256x;
            this.btnBuscar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(34, 28);
            this.btnBuscar.Text = "Ir";
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // VNavegador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 956);
            this.Controls.Add(this.toolStripContainer1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(1030, 700);
            this.Name = "VNavegador";
            this.Text = "Navegador";
            this.Load += new System.EventHandler(this.VNavegador_Load);
            this.toolStripContainer1.ContentPanel.ResumeLayout(false);
            this.toolStripContainer1.ContentPanel.PerformLayout();
            this.toolStripContainer1.TopToolStripPanel.ResumeLayout(false);
            this.toolStripContainer1.TopToolStripPanel.PerformLayout();
            this.toolStripContainer1.ResumeLayout(false);
            this.toolStripContainer1.PerformLayout();
            this.controlPestana.ResumeLayout(false);
            this.pestana.ResumeLayout(false);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);

        }

        public WebBrowser getWeb()
        {
            return web;
        }

        public ToolStripTextBox getTxtDireccion()
        {
            return txtDireccion;
        }

        #endregion

        private System.Windows.Forms.ToolStripContainer toolStripContainer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnAtras;
        private System.Windows.Forms.ToolStripButton btnAdelante;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.ToolStripButton btnHome;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveAsTS;
        private System.Windows.Forms.ToolStripMenuItem vistaPTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripMenuItem imprimirTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem configurarTS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem salirTS;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem favTS;
        private System.Windows.Forms.ToolStripMenuItem historialTS;
        private System.Windows.Forms.ToolStripMenuItem paginicioTS;
        private System.Windows.Forms.ToolStripMenuItem busquedaTS;
        private System.Windows.Forms.ToolStripMenuItem propiedadesTS;
        private System.Windows.Forms.ToolStripButton btnFav;
        private System.Windows.Forms.ToolStripButton btnNewTab;
        private System.Windows.Forms.ToolStripButton btnBuscar;
        private System.Windows.Forms.ToolStripLabel lblDireccion;
        private System.Windows.Forms.ToolStripTextBox txtDireccion;
        private System.Windows.Forms.TabControl controlPestana;
        private System.Windows.Forms.TabPage pestana;
        private System.Windows.Forms.WebBrowser web;
        private System.Windows.Forms.ToolStripTextBox txtPaginaInicioTS;
        private ToolStripComboBox comboBuscadoresTS;
        private ToolStripButton btnCerrarPestanaTS;
    }
}

