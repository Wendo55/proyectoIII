namespace proyectoIII
{
    partial class frmCounting
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.lstMostrar = new System.Windows.Forms.ListBox();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.txtTiempoOrdenar = new System.Windows.Forms.TextBox();
            this.lstMostrar2 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.txtPasadas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtNumero
            // 
            this.txtNumero.BackColor = System.Drawing.Color.White;
            this.txtNumero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNumero.ForeColor = System.Drawing.Color.Black;
            this.txtNumero.Location = new System.Drawing.Point(29, 89);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(126, 26);
            this.txtNumero.TabIndex = 0;
            this.txtNumero.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNumero.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumero_KeyPress);
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMostrar.FlatAppearance.BorderSize = 0;
            this.btnMostrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMostrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMostrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMostrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMostrar.Location = new System.Drawing.Point(29, 195);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(126, 40);
            this.btnMostrar.TabIndex = 16;
            this.btnMostrar.Text = "Mostrar";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click_1);
            // 
            // lstMostrar
            // 
            this.lstMostrar.BackColor = System.Drawing.Color.White;
            this.lstMostrar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMostrar.ForeColor = System.Drawing.Color.Black;
            this.lstMostrar.FormattingEnabled = true;
            this.lstMostrar.HorizontalScrollbar = true;
            this.lstMostrar.ItemHeight = 18;
            this.lstMostrar.Location = new System.Drawing.Point(227, 85);
            this.lstMostrar.Name = "lstMostrar";
            this.lstMostrar.Size = new System.Drawing.Size(88, 220);
            this.lstMostrar.TabIndex = 3;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLimpiar.FlatAppearance.BorderSize = 0;
            this.btnLimpiar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLimpiar.Location = new System.Drawing.Point(29, 136);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(126, 40);
            this.btnLimpiar.TabIndex = 16;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // txtTiempoOrdenar
            // 
            this.txtTiempoOrdenar.BackColor = System.Drawing.Color.White;
            this.txtTiempoOrdenar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTiempoOrdenar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTiempoOrdenar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtTiempoOrdenar.Location = new System.Drawing.Point(133, 336);
            this.txtTiempoOrdenar.Name = "txtTiempoOrdenar";
            this.txtTiempoOrdenar.Size = new System.Drawing.Size(139, 19);
            this.txtTiempoOrdenar.TabIndex = 11;
            // 
            // lstMostrar2
            // 
            this.lstMostrar2.BackColor = System.Drawing.Color.White;
            this.lstMostrar2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstMostrar2.ForeColor = System.Drawing.Color.Black;
            this.lstMostrar2.FormattingEnabled = true;
            this.lstMostrar2.HorizontalScrollbar = true;
            this.lstMostrar2.ItemHeight = 18;
            this.lstMostrar2.Location = new System.Drawing.Point(350, 85);
            this.lstMostrar2.Name = "lstMostrar2";
            this.lstMostrar2.Size = new System.Drawing.Size(98, 220);
            this.lstMostrar2.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label8.Location = new System.Drawing.Point(47, 179);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 20;
            // 
            // txtComp
            // 
            this.txtComp.BackColor = System.Drawing.Color.White;
            this.txtComp.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtComp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtComp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtComp.Location = new System.Drawing.Point(174, 398);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(25, 19);
            this.txtComp.TabIndex = 23;
            // 
            // txtPasadas
            // 
            this.txtPasadas.BackColor = System.Drawing.Color.White;
            this.txtPasadas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPasadas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPasadas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtPasadas.Location = new System.Drawing.Point(174, 361);
            this.txtPasadas.Name = "txtPasadas";
            this.txtPasadas.Size = new System.Drawing.Size(29, 19);
            this.txtPasadas.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(168, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 33);
            this.label1.TabIndex = 31;
            this.label1.Text = "COUNTING SORT";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(223, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "Ascendente";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(346, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 33;
            this.label2.Text = "Descendente";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(25, 398);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 19);
            this.label5.TabIndex = 34;
            this.label5.Text = "Comparaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(25, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 19);
            this.label6.TabIndex = 35;
            this.label6.Text = "Pasadas";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(25, 336);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 19);
            this.label7.TabIndex = 36;
            this.label7.Text = "Tiempo";
            // 
            // frmCounting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 560);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPasadas);
            this.Controls.Add(this.txtComp);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.lstMostrar2);
            this.Controls.Add(this.txtTiempoOrdenar);
            this.Controls.Add(this.lstMostrar);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmCounting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frmCuentas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ListBox lstMostrar;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.TextBox txtTiempoOrdenar;
        private System.Windows.Forms.ListBox lstMostrar2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.TextBox txtPasadas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}