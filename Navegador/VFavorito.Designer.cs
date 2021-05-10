namespace WindowsFormsApp1
{
    partial class VFavorito
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listFav = new System.Windows.Forms.ListBox();
            this.btnIrFav = new System.Windows.Forms.Button();
            this.btnEliminarFav = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listFav
            // 
            this.listFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listFav.FormattingEnabled = true;
            this.listFav.ItemHeight = 20;
            this.listFav.Location = new System.Drawing.Point(12, 14);
            this.listFav.Name = "listFav";
            this.listFav.Size = new System.Drawing.Size(274, 264);
            this.listFav.TabIndex = 0;
            // 
            // btnIrFav
            // 
            this.btnIrFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrFav.Location = new System.Drawing.Point(310, 43);
            this.btnIrFav.Name = "btnIrFav";
            this.btnIrFav.Size = new System.Drawing.Size(89, 31);
            this.btnIrFav.TabIndex = 1;
            this.btnIrFav.Text = "Ir";
            this.btnIrFav.UseVisualStyleBackColor = true;
            this.btnIrFav.Click += new System.EventHandler(this.btnIrFav_Click);
            // 
            // btnEliminarFav
            // 
            this.btnEliminarFav.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarFav.Location = new System.Drawing.Point(310, 168);
            this.btnEliminarFav.Name = "btnEliminarFav";
            this.btnEliminarFav.Size = new System.Drawing.Size(89, 32);
            this.btnEliminarFav.TabIndex = 2;
            this.btnEliminarFav.Text = "Eliminar";
            this.btnEliminarFav.UseVisualStyleBackColor = true;
            this.btnEliminarFav.Click += new System.EventHandler(this.btnEliminarFav_Click);
            // 
            // VFavorito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 290);
            this.Controls.Add(this.btnEliminarFav);
            this.Controls.Add(this.btnIrFav);
            this.Controls.Add(this.listFav);
            this.Name = "VFavorito";
            this.Text = "Favoritos";
            this.Load += new System.EventHandler(this.VFavorito_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listFav;
        private System.Windows.Forms.Button btnIrFav;
        private System.Windows.Forms.Button btnEliminarFav;
    }
}