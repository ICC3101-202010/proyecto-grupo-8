namespace Proyecto_POO
{
    partial class NuevoPerfil
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NombrePerfil = new System.Windows.Forms.TextBox();
            this.comboTipoPerfil = new System.Windows.Forms.ComboBox();
            this.botonCrearPerfil = new System.Windows.Forms.Button();
            this.Creado = new System.Windows.Forms.Label();
            this.NoCreado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(191, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Perfil";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(68, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(68, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de perfil";
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.NombrePerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.NombrePerfil.Location = new System.Drawing.Point(216, 148);
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.Size = new System.Drawing.Size(242, 20);
            this.NombrePerfil.TabIndex = 3;
            this.NombrePerfil.TextChanged += new System.EventHandler(this.NombrePerfil_TextChanged);
            // 
            // comboTipoPerfil
            // 
            this.comboTipoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.comboTipoPerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboTipoPerfil.FormattingEnabled = true;
            this.comboTipoPerfil.Location = new System.Drawing.Point(216, 212);
            this.comboTipoPerfil.Name = "comboTipoPerfil";
            this.comboTipoPerfil.Size = new System.Drawing.Size(242, 21);
            this.comboTipoPerfil.TabIndex = 4;
            this.comboTipoPerfil.SelectedIndexChanged += new System.EventHandler(this.comboTipoPerfil_SelectedIndexChanged);
            // 
            // botonCrearPerfil
            // 
            this.botonCrearPerfil.Location = new System.Drawing.Point(464, 301);
            this.botonCrearPerfil.Name = "botonCrearPerfil";
            this.botonCrearPerfil.Size = new System.Drawing.Size(75, 23);
            this.botonCrearPerfil.TabIndex = 5;
            this.botonCrearPerfil.Text = "Crear";
            this.botonCrearPerfil.UseVisualStyleBackColor = true;
            this.botonCrearPerfil.Click += new System.EventHandler(this.botonCrearPerfil_Click);
            // 
            // Creado
            // 
            this.Creado.AutoSize = true;
            this.Creado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creado.ForeColor = System.Drawing.Color.LimeGreen;
            this.Creado.Location = new System.Drawing.Point(496, 184);
            this.Creado.Name = "Creado";
            this.Creado.Size = new System.Drawing.Size(97, 18);
            this.Creado.TabIndex = 6;
            this.Creado.Text = "¡Perfil creado!";
            // 
            // NoCreado
            // 
            this.NoCreado.AutoSize = true;
            this.NoCreado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NoCreado.ForeColor = System.Drawing.Color.Red;
            this.NoCreado.Location = new System.Drawing.Point(400, 267);
            this.NoCreado.Name = "NoCreado";
            this.NoCreado.Size = new System.Drawing.Size(193, 18);
            this.NoCreado.TabIndex = 7;
            this.NoCreado.Text = "¡Rellene todos los espacios!";
            // 
            // NuevoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.NoCreado);
            this.Controls.Add(this.Creado);
            this.Controls.Add(this.botonCrearPerfil);
            this.Controls.Add(this.comboTipoPerfil);
            this.Controls.Add(this.NombrePerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoPerfil";
            this.Size = new System.Drawing.Size(614, 383);
            this.Load += new System.EventHandler(this.NuevoPerfil_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox NombrePerfil;
        private System.Windows.Forms.ComboBox comboTipoPerfil;
        private System.Windows.Forms.Button botonCrearPerfil;
        private System.Windows.Forms.Label Creado;
        private System.Windows.Forms.Label NoCreado;
    }
}
