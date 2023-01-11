namespace WindowsTPClase3
{
    partial class Form1
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
            this.btnMoverCaballo = new System.Windows.Forms.Button();
            this.btnCrearLeon = new System.Windows.Forms.Button();
            this.btnCrearConejo = new System.Windows.Forms.Button();
            this.btnCrearLoro = new System.Windows.Forms.Button();
            this.btnMoverPeon = new System.Windows.Forms.Button();
            this.btnMoverTorre = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMoverCaballo
            // 
            this.btnMoverCaballo.Location = new System.Drawing.Point(61, 81);
            this.btnMoverCaballo.Name = "btnMoverCaballo";
            this.btnMoverCaballo.Size = new System.Drawing.Size(182, 36);
            this.btnMoverCaballo.TabIndex = 0;
            this.btnMoverCaballo.Text = "Mover Caballo";
            this.btnMoverCaballo.UseVisualStyleBackColor = true;
            this.btnMoverCaballo.Click += new System.EventHandler(this.btnMoverCaballo_Click);
            // 
            // btnCrearLeon
            // 
            this.btnCrearLeon.Location = new System.Drawing.Point(502, 88);
            this.btnCrearLeon.Name = "btnCrearLeon";
            this.btnCrearLeon.Size = new System.Drawing.Size(135, 29);
            this.btnCrearLeon.TabIndex = 1;
            this.btnCrearLeon.Text = "Crear Leon";
            this.btnCrearLeon.UseVisualStyleBackColor = true;
            this.btnCrearLeon.Click += new System.EventHandler(this.btnCrearLeon_Click);
            // 
            // btnCrearConejo
            // 
            this.btnCrearConejo.Location = new System.Drawing.Point(502, 146);
            this.btnCrearConejo.Name = "btnCrearConejo";
            this.btnCrearConejo.Size = new System.Drawing.Size(135, 29);
            this.btnCrearConejo.TabIndex = 2;
            this.btnCrearConejo.Text = "Crear Conejo";
            this.btnCrearConejo.UseVisualStyleBackColor = true;
            this.btnCrearConejo.Click += new System.EventHandler(this.btnCrearConejo_Click);
            // 
            // btnCrearLoro
            // 
            this.btnCrearLoro.Location = new System.Drawing.Point(502, 199);
            this.btnCrearLoro.Name = "btnCrearLoro";
            this.btnCrearLoro.Size = new System.Drawing.Size(135, 29);
            this.btnCrearLoro.TabIndex = 3;
            this.btnCrearLoro.Text = "Crear Loro";
            this.btnCrearLoro.UseVisualStyleBackColor = true;
            this.btnCrearLoro.Click += new System.EventHandler(this.btnCrearLoro_Click);
            // 
            // btnMoverPeon
            // 
            this.btnMoverPeon.Location = new System.Drawing.Point(61, 146);
            this.btnMoverPeon.Name = "btnMoverPeon";
            this.btnMoverPeon.Size = new System.Drawing.Size(182, 36);
            this.btnMoverPeon.TabIndex = 4;
            this.btnMoverPeon.Text = "Mover Peon";
            this.btnMoverPeon.UseVisualStyleBackColor = true;
            this.btnMoverPeon.Click += new System.EventHandler(this.btnMoverPeon_Click);
            // 
            // btnMoverTorre
            // 
            this.btnMoverTorre.Location = new System.Drawing.Point(61, 208);
            this.btnMoverTorre.Name = "btnMoverTorre";
            this.btnMoverTorre.Size = new System.Drawing.Size(182, 36);
            this.btnMoverTorre.TabIndex = 5;
            this.btnMoverTorre.Text = "Mover Torre";
            this.btnMoverTorre.UseVisualStyleBackColor = true;
            this.btnMoverTorre.Click += new System.EventHandler(this.btnMoverTorre_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMoverTorre);
            this.Controls.Add(this.btnMoverPeon);
            this.Controls.Add(this.btnCrearLoro);
            this.Controls.Add(this.btnCrearConejo);
            this.Controls.Add(this.btnCrearLeon);
            this.Controls.Add(this.btnMoverCaballo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnMoverCaballo;
        private System.Windows.Forms.Button btnCrearLeon;
        private System.Windows.Forms.Button btnCrearConejo;
        private System.Windows.Forms.Button btnCrearLoro;
        private System.Windows.Forms.Button btnMoverPeon;
        private System.Windows.Forms.Button btnMoverTorre;
    }
}

