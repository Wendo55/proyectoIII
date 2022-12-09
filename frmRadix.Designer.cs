namespace proyectoIII
{
    partial class frmRadix
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
            this.TxtTamaño = new System.Windows.Forms.TextBox();
            this.BtnIniciar = new System.Windows.Forms.Button();
            this.LtbArregloAleatorio = new System.Windows.Forms.ListBox();
            this.LtbArregloOrdenado = new System.Windows.Forms.ListBox();
            this.LtbArregloOrdenadoMN = new System.Windows.Forms.ListBox();
            this.BtnBorrar = new System.Windows.Forms.Button();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.LblTiempo = new System.Windows.Forms.Label();
            this.TxtTiempo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtTamaño
            // 
            this.TxtTamaño.Location = new System.Drawing.Point(28, 52);
            this.TxtTamaño.Name = "TxtTamaño";
            this.TxtTamaño.Size = new System.Drawing.Size(100, 20);
            this.TxtTamaño.TabIndex = 0;
            // 
            // BtnIniciar
            // 
            this.BtnIniciar.Location = new System.Drawing.Point(134, 52);
            this.BtnIniciar.Name = "BtnIniciar";
            this.BtnIniciar.Size = new System.Drawing.Size(75, 23);
            this.BtnIniciar.TabIndex = 1;
            this.BtnIniciar.Text = "Iniciar";
            this.BtnIniciar.UseVisualStyleBackColor = true;
            this.BtnIniciar.Click += new System.EventHandler(this.BtnIniciar_Click);
            // 
            // LtbArregloAleatorio
            // 
            this.LtbArregloAleatorio.FormattingEnabled = true;
            this.LtbArregloAleatorio.Location = new System.Drawing.Point(28, 78);
            this.LtbArregloAleatorio.Name = "LtbArregloAleatorio";
            this.LtbArregloAleatorio.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloAleatorio.TabIndex = 2;
            // 
            // LtbArregloOrdenado
            // 
            this.LtbArregloOrdenado.FormattingEnabled = true;
            this.LtbArregloOrdenado.Location = new System.Drawing.Point(156, 78);
            this.LtbArregloOrdenado.Name = "LtbArregloOrdenado";
            this.LtbArregloOrdenado.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloOrdenado.TabIndex = 3;
            // 
            // LtbArregloOrdenadoMN
            // 
            this.LtbArregloOrdenadoMN.FormattingEnabled = true;
            this.LtbArregloOrdenadoMN.Location = new System.Drawing.Point(276, 78);
            this.LtbArregloOrdenadoMN.Name = "LtbArregloOrdenadoMN";
            this.LtbArregloOrdenadoMN.Size = new System.Drawing.Size(100, 134);
            this.LtbArregloOrdenadoMN.TabIndex = 4;
            // 
            // BtnBorrar
            // 
            this.BtnBorrar.Location = new System.Drawing.Point(215, 50);
            this.BtnBorrar.Name = "BtnBorrar";
            this.BtnBorrar.Size = new System.Drawing.Size(75, 23);
            this.BtnBorrar.TabIndex = 9;
            this.BtnBorrar.Text = "Borrar";
            this.BtnBorrar.UseVisualStyleBackColor = true;
            this.BtnBorrar.Click += new System.EventHandler(this.BtnBorrar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Location = new System.Drawing.Point(296, 49);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(75, 23);
            this.BtnCerrar.TabIndex = 10;
            this.BtnCerrar.Text = "Cerrar";
            this.BtnCerrar.UseVisualStyleBackColor = true;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // LblTiempo
            // 
            this.LblTiempo.AutoSize = true;
            this.LblTiempo.Location = new System.Drawing.Point(260, 19);
            this.LblTiempo.Name = "LblTiempo";
            this.LblTiempo.Size = new System.Drawing.Size(45, 13);
            this.LblTiempo.TabIndex = 11;
            this.LblTiempo.Text = "Tiempo:";
            // 
            // TxtTiempo
            // 
            this.TxtTiempo.Location = new System.Drawing.Point(311, 16);
            this.TxtTiempo.Name = "TxtTiempo";
            this.TxtTiempo.Size = new System.Drawing.Size(100, 20);
            this.TxtTiempo.TabIndex = 12;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 231);
            this.Controls.Add(this.TxtTiempo);
            this.Controls.Add(this.LblTiempo);
            this.Controls.Add(this.BtnCerrar);
            this.Controls.Add(this.BtnBorrar);
            this.Controls.Add(this.LtbArregloOrdenadoMN);
            this.Controls.Add(this.LtbArregloOrdenado);
            this.Controls.Add(this.LtbArregloAleatorio);
            this.Controls.Add(this.BtnIniciar);
            this.Controls.Add(this.TxtTamaño);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtTamaño;
        private System.Windows.Forms.Button BtnIniciar;
        private System.Windows.Forms.ListBox LtbArregloAleatorio;
        private System.Windows.Forms.ListBox LtbArregloOrdenado;
        private System.Windows.Forms.ListBox LtbArregloOrdenadoMN;
        private System.Windows.Forms.Button BtnBorrar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.Label LblTiempo;
        private System.Windows.Forms.TextBox TxtTiempo;
    }
}
