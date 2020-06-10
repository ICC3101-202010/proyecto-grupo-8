namespace Proyecto_POO
{
    partial class Perfiles
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
            this.botonPerfil1 = new System.Windows.Forms.Button();
            this.botonPerfil2 = new System.Windows.Forms.Button();
            this.botonPerfil3 = new System.Windows.Forms.Button();
            this.botonCrearPerfil = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(233, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quien eres?";
            // 
            // botonPerfil1
            // 
            this.botonPerfil1.Location = new System.Drawing.Point(140, 144);
            this.botonPerfil1.Name = "botonPerfil1";
            this.botonPerfil1.Size = new System.Drawing.Size(103, 86);
            this.botonPerfil1.TabIndex = 1;
            this.botonPerfil1.Text = "Perfil";
            this.botonPerfil1.UseVisualStyleBackColor = true;
            this.botonPerfil1.Visible = false;
            this.botonPerfil1.Click += new System.EventHandler(this.botonPerfil1_Click);
            // 
            // botonPerfil2
            // 
            this.botonPerfil2.Location = new System.Drawing.Point(276, 144);
            this.botonPerfil2.Name = "botonPerfil2";
            this.botonPerfil2.Size = new System.Drawing.Size(103, 86);
            this.botonPerfil2.TabIndex = 2;
            this.botonPerfil2.Text = "Perfil";
            this.botonPerfil2.UseVisualStyleBackColor = true;
            this.botonPerfil2.Visible = false;
            this.botonPerfil2.Click += new System.EventHandler(this.botonPerfil2_Click);
            // 
            // botonPerfil3
            // 
            this.botonPerfil3.Location = new System.Drawing.Point(417, 144);
            this.botonPerfil3.Name = "botonPerfil3";
            this.botonPerfil3.Size = new System.Drawing.Size(103, 86);
            this.botonPerfil3.TabIndex = 3;
            this.botonPerfil3.Text = "Perfil";
            this.botonPerfil3.UseVisualStyleBackColor = true;
            this.botonPerfil3.Visible = false;
            this.botonPerfil3.Click += new System.EventHandler(this.botonPerfil3_Click);
            // 
            // botonCrearPerfil
            // 
            this.botonCrearPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrearPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botonCrearPerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.botonCrearPerfil.Location = new System.Drawing.Point(276, 267);
            this.botonCrearPerfil.Name = "botonCrearPerfil";
            this.botonCrearPerfil.Size = new System.Drawing.Size(103, 86);
            this.botonCrearPerfil.TabIndex = 4;
            this.botonCrearPerfil.Text = "+";
            this.botonCrearPerfil.UseVisualStyleBackColor = true;
            this.botonCrearPerfil.Click += new System.EventHandler(this.botonCrearPerfil_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.Controls.Add(this.botonCrearPerfil);
            this.panel1.Controls.Add(this.botonPerfil3);
            this.panel1.Controls.Add(this.botonPerfil2);
            this.panel1.Controls.Add(this.botonPerfil1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(291, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(627, 427);
            this.panel1.TabIndex = 5;
            // 
            // Perfiles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel1);
            this.Name = "Perfiles";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.Perfiles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button botonPerfil1;
        private System.Windows.Forms.Button botonPerfil2;
        private System.Windows.Forms.Button botonPerfil3;
        private System.Windows.Forms.Button botonCrearPerfil;
        private System.Windows.Forms.Panel panel1;
    }
}
