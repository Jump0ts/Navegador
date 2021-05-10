namespace WindowsFormsApp1
{
    partial class VHistorial
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
            this.btnEliminarHist = new System.Windows.Forms.Button();
            this.btnIrHist = new System.Windows.Forms.Button();
            this.listHist = new System.Windows.Forms.ListBox();
            this.btnEliminarTodoHist = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminarHist
            // 
            this.btnEliminarHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarHist.Location = new System.Drawing.Point(310, 113);
            this.btnEliminarHist.Name = "btnEliminarHist";
            this.btnEliminarHist.Size = new System.Drawing.Size(95, 32);
            this.btnEliminarHist.TabIndex = 5;
            this.btnEliminarHist.Text = "Eliminar";
            this.btnEliminarHist.UseVisualStyleBackColor = true;
            this.btnEliminarHist.Click += new System.EventHandler(this.btnEliminarHist_Click);
            // 
            // btnIrHist
            // 
            this.btnIrHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnIrHist.Location = new System.Drawing.Point(310, 41);
            this.btnIrHist.Name = "btnIrHist";
            this.btnIrHist.Size = new System.Drawing.Size(95, 31);
            this.btnIrHist.TabIndex = 4;
            this.btnIrHist.Text = "Ir";
            this.btnIrHist.UseVisualStyleBackColor = true;
            this.btnIrHist.Click += new System.EventHandler(this.btnIrHist_Click);
            // 
            // listHist
            // 
            this.listHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listHist.FormattingEnabled = true;
            this.listHist.ItemHeight = 20;
            this.listHist.Location = new System.Drawing.Point(12, 12);
            this.listHist.Name = "listHist";
            this.listHist.Size = new System.Drawing.Size(280, 264);
            this.listHist.TabIndex = 3;
            // 
            // btnEliminarTodoHist
            // 
            this.btnEliminarTodoHist.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEliminarTodoHist.Location = new System.Drawing.Point(310, 200);
            this.btnEliminarTodoHist.Name = "btnEliminarTodoHist";
            this.btnEliminarTodoHist.Size = new System.Drawing.Size(95, 57);
            this.btnEliminarTodoHist.TabIndex = 6;
            this.btnEliminarTodoHist.Text = "Eliminar Todo";
            this.btnEliminarTodoHist.UseVisualStyleBackColor = true;
            this.btnEliminarTodoHist.Click += new System.EventHandler(this.btnEliminarTodoHist_Click);
            // 
            // VHistorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 286);
            this.Controls.Add(this.btnEliminarTodoHist);
            this.Controls.Add(this.btnEliminarHist);
            this.Controls.Add(this.btnIrHist);
            this.Controls.Add(this.listHist);
            this.Name = "VHistorial";
            this.Text = "VHistorial";
            this.Load += new System.EventHandler(this.VHistorial_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEliminarHist;
        private System.Windows.Forms.Button btnIrHist;
        private System.Windows.Forms.ListBox listHist;
        private System.Windows.Forms.Button btnEliminarTodoHist;
    }
}