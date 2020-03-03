namespace pjConexion2
{
    partial class frmClientes
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
            this.dgClientes = new System.Windows.Forms.DataGridView();
            this.titulo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgClientes
            // 
            this.dgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgClientes.Location = new System.Drawing.Point(78, 148);
            this.dgClientes.Name = "dgClientes";
            this.dgClientes.RowHeadersWidth = 51;
            this.dgClientes.RowTemplate.Height = 24;
            this.dgClientes.Size = new System.Drawing.Size(655, 176);
            this.dgClientes.TabIndex = 0;
            // 
            // titulo
            // 
            this.titulo.AutoSize = true;
            this.titulo.Location = new System.Drawing.Point(323, 98);
            this.titulo.Name = "titulo";
            this.titulo.Size = new System.Drawing.Size(160, 17);
            this.titulo.TabIndex = 1;
            this.titulo.Text = "LISTADO DE CLIENTES";
            this.titulo.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(543, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total de Clientes";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(687, 358);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(0, 17);
            this.lblTotal.TabIndex = 3;
            // 
            // frmClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.titulo);
            this.Controls.Add(this.dgClientes);
            this.Name = "frmClientes";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgClientes;
        private System.Windows.Forms.Label titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotal;
    }
}

