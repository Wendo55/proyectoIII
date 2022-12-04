namespace proyectoIII
{
    partial class frmOrdenamientoABB
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
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtInorden = new System.Windows.Forms.TextBox();
            this.txtSinOrdenar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnInvertidos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(77, 114);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(125, 20);
            this.txtCantidad.TabIndex = 0;
            // 
            // txtInorden
            // 
            this.txtInorden.Location = new System.Drawing.Point(262, 155);
            this.txtInorden.Name = "txtInorden";
            this.txtInorden.Size = new System.Drawing.Size(448, 20);
            this.txtInorden.TabIndex = 1;
            // 
            // txtSinOrdenar
            // 
            this.txtSinOrdenar.Location = new System.Drawing.Point(262, 102);
            this.txtSinOrdenar.Name = "txtSinOrdenar";
            this.txtSinOrdenar.Size = new System.Drawing.Size(448, 20);
            this.txtSinOrdenar.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(74, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese la cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(262, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ordenados";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(259, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Sin ordenar";
            // 
            // btnIngresar
            // 
            this.btnIngresar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnIngresar.Location = new System.Drawing.Point(77, 155);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(125, 37);
            this.btnIngresar.TabIndex = 6;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click_1);
            // 
            // btnInvertidos
            // 
            this.btnInvertidos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnInvertidos.Location = new System.Drawing.Point(262, 200);
            this.btnInvertidos.Name = "btnInvertidos";
            this.btnInvertidos.Size = new System.Drawing.Size(125, 37);
            this.btnInvertidos.TabIndex = 7;
            this.btnInvertidos.Text = "Invertidos";
            this.btnInvertidos.UseVisualStyleBackColor = true;
            this.btnInvertidos.Click += new System.EventHandler(this.btnInvertidos_Click_1);
            // 
            // frmOrdenamientoABB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnInvertidos);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSinOrdenar);
            this.Controls.Add(this.txtInorden);
            this.Controls.Add(this.txtCantidad);
            this.Name = "frmOrdenamientoABB";
            this.Text = "frmGrafos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtInorden;
        private System.Windows.Forms.TextBox txtSinOrdenar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnInvertidos;
    }
}