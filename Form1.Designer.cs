namespace proyectoIII
{
    partial class FrmInicio
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicio));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnminimizar = new System.Windows.Forms.PictureBox();
            this.btnclose = new System.Windows.Forms.PictureBox();
            this.btnCuentas = new System.Windows.Forms.Button();
            this.btnCasilleros = new System.Windows.Forms.Button();
            this.btnInsercion = new System.Windows.Forms.Button();
            this.btnBurbuja = new System.Windows.Forms.Button();
            this.btnMezcla = new System.Windows.Forms.Button();
            this.btnArbol = new System.Windows.Forms.Button();
            this.btnRadix = new System.Windows.Forms.Button();
            this.btnLista = new System.Windows.Forms.Button();
            this.btnCircular = new System.Windows.Forms.Button();
            this.btnDobleEnlazada = new System.Windows.Forms.Button();
            this.btnDoblementeCircular = new System.Windows.Forms.Button();
            this.btnColas = new System.Windows.Forms.Button();
            this.btnPilas = new System.Windows.Forms.Button();
            this.btnGrafos = new System.Windows.Forms.Button();
            this.btnArboles = new System.Windows.Forms.Button();
            this.btnSelection = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(375, 33);
            this.label1.TabIndex = 12;
            this.label1.Text = "Metodos de ordenamiento";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.label2.Location = new System.Drawing.Point(461, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(268, 33);
            this.label2.TabIndex = 13;
            this.label2.Text = "Estructura de datos";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Khaki;
            this.panel1.Controls.Add(this.btnminimizar);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnclose);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 91);
            this.panel1.TabIndex = 14;
            // 
            // btnminimizar
            // 
            this.btnminimizar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnminimizar.BackgroundImage")));
            this.btnminimizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnminimizar.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnminimizar.Location = new System.Drawing.Point(726, 3);
            this.btnminimizar.Name = "btnminimizar";
            this.btnminimizar.Size = new System.Drawing.Size(25, 25);
            this.btnminimizar.TabIndex = 31;
            this.btnminimizar.TabStop = false;
            this.btnminimizar.UseWaitCursor = true;
            this.btnminimizar.Click += new System.EventHandler(this.btnminimizar_Click);
            // 
            // btnclose
            // 
            this.btnclose.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnclose.BackgroundImage")));
            this.btnclose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnclose.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.btnclose.Location = new System.Drawing.Point(757, 3);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(25, 25);
            this.btnclose.TabIndex = 30;
            this.btnclose.TabStop = false;
            this.btnclose.UseWaitCursor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCuentas
            // 
            this.btnCuentas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCuentas.FlatAppearance.BorderSize = 0;
            this.btnCuentas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCuentas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCuentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCuentas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCuentas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCuentas.Location = new System.Drawing.Point(12, 235);
            this.btnCuentas.Name = "btnCuentas";
            this.btnCuentas.Size = new System.Drawing.Size(318, 40);
            this.btnCuentas.TabIndex = 15;
            this.btnCuentas.Text = "COUNTING SORT";
            this.btnCuentas.UseVisualStyleBackColor = false;
            this.btnCuentas.Click += new System.EventHandler(this.btnCuentas_Click_1);
            // 
            // btnCasilleros
            // 
            this.btnCasilleros.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCasilleros.FlatAppearance.BorderSize = 0;
            this.btnCasilleros.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCasilleros.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCasilleros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCasilleros.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCasilleros.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCasilleros.Location = new System.Drawing.Point(12, 189);
            this.btnCasilleros.Name = "btnCasilleros";
            this.btnCasilleros.Size = new System.Drawing.Size(318, 40);
            this.btnCasilleros.TabIndex = 16;
            this.btnCasilleros.Text = "BUCKET SORT";
            this.btnCasilleros.UseVisualStyleBackColor = false;
            // 
            // btnInsercion
            // 
            this.btnInsercion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnInsercion.FlatAppearance.BorderSize = 0;
            this.btnInsercion.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnInsercion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnInsercion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsercion.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsercion.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnInsercion.Location = new System.Drawing.Point(12, 143);
            this.btnInsercion.Name = "btnInsercion";
            this.btnInsercion.Size = new System.Drawing.Size(318, 40);
            this.btnInsercion.TabIndex = 17;
            this.btnInsercion.Text = "COCKTAIL SORT";
            this.btnInsercion.UseVisualStyleBackColor = false;
            this.btnInsercion.Click += new System.EventHandler(this.btnInsercion_Click_1);
            // 
            // btnBurbuja
            // 
            this.btnBurbuja.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnBurbuja.FlatAppearance.BorderSize = 0;
            this.btnBurbuja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnBurbuja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnBurbuja.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBurbuja.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBurbuja.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBurbuja.Location = new System.Drawing.Point(12, 97);
            this.btnBurbuja.Name = "btnBurbuja";
            this.btnBurbuja.Size = new System.Drawing.Size(318, 40);
            this.btnBurbuja.TabIndex = 18;
            this.btnBurbuja.Text = "BUBBLESORT";
            this.btnBurbuja.UseVisualStyleBackColor = false;
            this.btnBurbuja.Click += new System.EventHandler(this.btnBurbuja_Click_1);
            // 
            // btnMezcla
            // 
            this.btnMezcla.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnMezcla.FlatAppearance.BorderSize = 0;
            this.btnMezcla.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnMezcla.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnMezcla.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMezcla.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMezcla.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMezcla.Location = new System.Drawing.Point(12, 281);
            this.btnMezcla.Name = "btnMezcla";
            this.btnMezcla.Size = new System.Drawing.Size(318, 40);
            this.btnMezcla.TabIndex = 19;
            this.btnMezcla.Text = "MERGE SORT";
            this.btnMezcla.UseVisualStyleBackColor = false;
            // 
            // btnArbol
            // 
            this.btnArbol.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArbol.FlatAppearance.BorderSize = 0;
            this.btnArbol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnArbol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnArbol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArbol.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArbol.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArbol.Location = new System.Drawing.Point(12, 327);
            this.btnArbol.Name = "btnArbol";
            this.btnArbol.Size = new System.Drawing.Size(318, 40);
            this.btnArbol.TabIndex = 20;
            this.btnArbol.Text = "BINARY TREE SORT";
            this.btnArbol.UseVisualStyleBackColor = false;
            this.btnArbol.Click += new System.EventHandler(this.btnArbol_Click_1);
            // 
            // btnRadix
            // 
            this.btnRadix.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnRadix.FlatAppearance.BorderSize = 0;
            this.btnRadix.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnRadix.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnRadix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRadix.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRadix.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnRadix.Location = new System.Drawing.Point(12, 373);
            this.btnRadix.Name = "btnRadix";
            this.btnRadix.Size = new System.Drawing.Size(318, 40);
            this.btnRadix.TabIndex = 21;
            this.btnRadix.Text = "RADIX SORT";
            this.btnRadix.UseVisualStyleBackColor = false;
            // 
            // btnLista
            // 
            this.btnLista.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnLista.FlatAppearance.BorderSize = 0;
            this.btnLista.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnLista.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLista.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLista.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLista.Location = new System.Drawing.Point(436, 97);
            this.btnLista.Name = "btnLista";
            this.btnLista.Size = new System.Drawing.Size(318, 40);
            this.btnLista.TabIndex = 22;
            this.btnLista.Text = "LISTA SIMPLE";
            this.btnLista.UseVisualStyleBackColor = false;
            this.btnLista.Click += new System.EventHandler(this.btnLista_Click);
            // 
            // btnCircular
            // 
            this.btnCircular.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnCircular.FlatAppearance.BorderSize = 0;
            this.btnCircular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnCircular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnCircular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCircular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCircular.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCircular.Location = new System.Drawing.Point(436, 143);
            this.btnCircular.Name = "btnCircular";
            this.btnCircular.Size = new System.Drawing.Size(318, 40);
            this.btnCircular.TabIndex = 23;
            this.btnCircular.Text = "LISTA CIRCULAR";
            this.btnCircular.UseVisualStyleBackColor = false;
            this.btnCircular.Click += new System.EventHandler(this.btnCircular_Click);
            // 
            // btnDobleEnlazada
            // 
            this.btnDobleEnlazada.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDobleEnlazada.FlatAppearance.BorderSize = 0;
            this.btnDobleEnlazada.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDobleEnlazada.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDobleEnlazada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDobleEnlazada.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDobleEnlazada.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDobleEnlazada.Location = new System.Drawing.Point(436, 189);
            this.btnDobleEnlazada.Name = "btnDobleEnlazada";
            this.btnDobleEnlazada.Size = new System.Drawing.Size(318, 40);
            this.btnDobleEnlazada.TabIndex = 24;
            this.btnDobleEnlazada.Text = "LISTA DOBLEMENTE ENLAZADA";
            this.btnDobleEnlazada.UseVisualStyleBackColor = false;
            this.btnDobleEnlazada.Click += new System.EventHandler(this.btnDobleEnlazada_Click);
            // 
            // btnDoblementeCircular
            // 
            this.btnDoblementeCircular.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnDoblementeCircular.FlatAppearance.BorderSize = 0;
            this.btnDoblementeCircular.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnDoblementeCircular.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnDoblementeCircular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDoblementeCircular.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoblementeCircular.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnDoblementeCircular.Location = new System.Drawing.Point(436, 235);
            this.btnDoblementeCircular.Name = "btnDoblementeCircular";
            this.btnDoblementeCircular.Size = new System.Drawing.Size(318, 40);
            this.btnDoblementeCircular.TabIndex = 25;
            this.btnDoblementeCircular.Text = "LISTA DOBLEMENTE CIRCULAR";
            this.btnDoblementeCircular.UseVisualStyleBackColor = false;
            this.btnDoblementeCircular.Click += new System.EventHandler(this.btnDoblementeCircular_Click);
            // 
            // btnColas
            // 
            this.btnColas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnColas.FlatAppearance.BorderSize = 0;
            this.btnColas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnColas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnColas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnColas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnColas.Location = new System.Drawing.Point(436, 327);
            this.btnColas.Name = "btnColas";
            this.btnColas.Size = new System.Drawing.Size(318, 40);
            this.btnColas.TabIndex = 26;
            this.btnColas.Text = "COLAS";
            this.btnColas.UseVisualStyleBackColor = false;
            this.btnColas.Click += new System.EventHandler(this.btnColas_Click);
            // 
            // btnPilas
            // 
            this.btnPilas.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnPilas.FlatAppearance.BorderSize = 0;
            this.btnPilas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnPilas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnPilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPilas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPilas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPilas.Location = new System.Drawing.Point(436, 281);
            this.btnPilas.Name = "btnPilas";
            this.btnPilas.Size = new System.Drawing.Size(318, 40);
            this.btnPilas.TabIndex = 27;
            this.btnPilas.Text = "PILAS";
            this.btnPilas.UseVisualStyleBackColor = false;
            this.btnPilas.Click += new System.EventHandler(this.btnPilas_Click);
            // 
            // btnGrafos
            // 
            this.btnGrafos.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnGrafos.FlatAppearance.BorderSize = 0;
            this.btnGrafos.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnGrafos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnGrafos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrafos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrafos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnGrafos.Location = new System.Drawing.Point(436, 373);
            this.btnGrafos.Name = "btnGrafos";
            this.btnGrafos.Size = new System.Drawing.Size(318, 40);
            this.btnGrafos.TabIndex = 28;
            this.btnGrafos.Text = "GRAFOS";
            this.btnGrafos.UseVisualStyleBackColor = false;
            this.btnGrafos.Click += new System.EventHandler(this.btnGrafos_Click);
            // 
            // btnArboles
            // 
            this.btnArboles.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnArboles.FlatAppearance.BorderSize = 0;
            this.btnArboles.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnArboles.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnArboles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnArboles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnArboles.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnArboles.Location = new System.Drawing.Point(436, 419);
            this.btnArboles.Name = "btnArboles";
            this.btnArboles.Size = new System.Drawing.Size(318, 40);
            this.btnArboles.TabIndex = 29;
            this.btnArboles.Text = "ARBOLES";
            this.btnArboles.UseVisualStyleBackColor = false;
            this.btnArboles.Click += new System.EventHandler(this.btnArboles_Click);
            // 
            // btnSelection
            // 
            this.btnSelection.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.btnSelection.FlatAppearance.BorderSize = 0;
            this.btnSelection.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DimGray;
            this.btnSelection.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnSelection.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelection.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelection.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSelection.Location = new System.Drawing.Point(12, 419);
            this.btnSelection.Name = "btnSelection";
            this.btnSelection.Size = new System.Drawing.Size(318, 40);
            this.btnSelection.TabIndex = 30;
            this.btnSelection.Text = "SELECTION SORT";
            this.btnSelection.UseVisualStyleBackColor = false;
            this.btnSelection.Click += new System.EventHandler(this.btnSelection_Click);
            // 
            // FrmInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(794, 544);
            this.Controls.Add(this.btnSelection);
            this.Controls.Add(this.btnArboles);
            this.Controls.Add(this.btnGrafos);
            this.Controls.Add(this.btnPilas);
            this.Controls.Add(this.btnColas);
            this.Controls.Add(this.btnDoblementeCircular);
            this.Controls.Add(this.btnDobleEnlazada);
            this.Controls.Add(this.btnCircular);
            this.Controls.Add(this.btnLista);
            this.Controls.Add(this.btnRadix);
            this.Controls.Add(this.btnArbol);
            this.Controls.Add(this.btnMezcla);
            this.Controls.Add(this.btnBurbuja);
            this.Controls.Add(this.btnInsercion);
            this.Controls.Add(this.btnCasilleros);
            this.Controls.Add(this.btnCuentas);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmInicio";
            this.Text = "Inicio";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnminimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnclose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnCuentas;
        private System.Windows.Forms.Button btnCasilleros;
        private System.Windows.Forms.Button btnInsercion;
        private System.Windows.Forms.Button btnBurbuja;
        private System.Windows.Forms.Button btnMezcla;
        private System.Windows.Forms.Button btnArbol;
        private System.Windows.Forms.Button btnRadix;
        private System.Windows.Forms.Button btnLista;
        private System.Windows.Forms.PictureBox btnminimizar;
        private System.Windows.Forms.PictureBox btnclose;
        private System.Windows.Forms.Button btnCircular;
        private System.Windows.Forms.Button btnDobleEnlazada;
        private System.Windows.Forms.Button btnDoblementeCircular;
        private System.Windows.Forms.Button btnColas;
        private System.Windows.Forms.Button btnPilas;
        private System.Windows.Forms.Button btnGrafos;
        private System.Windows.Forms.Button btnArboles;
        private System.Windows.Forms.Button btnSelection;
    }
}

