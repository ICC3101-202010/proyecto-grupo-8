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
            this.Back = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.FotoDePerfil = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(37, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre del perfil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(37, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 24);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo de perfil";
            // 
            // NombrePerfil
            // 
            this.NombrePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.NombrePerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NombrePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NombrePerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.NombrePerfil.Location = new System.Drawing.Point(218, 123);
            this.NombrePerfil.Name = "NombrePerfil";
            this.NombrePerfil.Size = new System.Drawing.Size(242, 26);
            this.NombrePerfil.TabIndex = 3;
            this.NombrePerfil.TextChanged += new System.EventHandler(this.NombrePerfil_TextChanged);
            // 
            // comboTipoPerfil
            // 
            this.comboTipoPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.comboTipoPerfil.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboTipoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboTipoPerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboTipoPerfil.FormattingEnabled = true;
            this.comboTipoPerfil.Location = new System.Drawing.Point(218, 172);
            this.comboTipoPerfil.Name = "comboTipoPerfil";
            this.comboTipoPerfil.Size = new System.Drawing.Size(242, 28);
            this.comboTipoPerfil.TabIndex = 4;
            this.comboTipoPerfil.SelectedIndexChanged += new System.EventHandler(this.comboTipoPerfil_SelectedIndexChanged);
            // 
            // botonCrearPerfil
            // 
            this.botonCrearPerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.botonCrearPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonCrearPerfil.Location = new System.Drawing.Point(451, 289);
            this.botonCrearPerfil.Name = "botonCrearPerfil";
            this.botonCrearPerfil.Size = new System.Drawing.Size(112, 47);
            this.botonCrearPerfil.TabIndex = 5;
            this.botonCrearPerfil.Text = "Crear";
            this.botonCrearPerfil.UseVisualStyleBackColor = false;
            this.botonCrearPerfil.Click += new System.EventHandler(this.botonCrearPerfil_Click);
            // 
            // Creado
            // 
            this.Creado.AutoSize = true;
            this.Creado.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Creado.ForeColor = System.Drawing.Color.LimeGreen;
            this.Creado.Location = new System.Drawing.Point(250, 321);
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
            this.NoCreado.Location = new System.Drawing.Point(215, 290);
            this.NoCreado.Name = "NoCreado";
            this.NoCreado.Size = new System.Drawing.Size(193, 18);
            this.NoCreado.TabIndex = 7;
            this.NoCreado.Text = "¡Rellene todos los espacios!";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Location = new System.Drawing.Point(41, 290);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(103, 46);
            this.Back.TabIndex = 8;
            this.Back.Text = "Atras";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Menu;
            this.label5.Location = new System.Drawing.Point(37, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "Foto de Perfil";
            // 
            // FotoDePerfil
            // 
            this.FotoDePerfil.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FotoDePerfil.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.FotoDePerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FotoDePerfil.ForeColor = System.Drawing.SystemColors.Menu;
            this.FotoDePerfil.Location = new System.Drawing.Point(218, 219);
            this.FotoDePerfil.Name = "FotoDePerfil";
            this.FotoDePerfil.Size = new System.Drawing.Size(242, 26);
            this.FotoDePerfil.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(466, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 28);
            this.button1.TabIndex = 12;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // NuevoPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.button1);
            this.Controls.Add(this.FotoDePerfil);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.NoCreado);
            this.Controls.Add(this.Creado);
            this.Controls.Add(this.botonCrearPerfil);
            this.Controls.Add(this.comboTipoPerfil);
            this.Controls.Add(this.NombrePerfil);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "NuevoPerfil";
            this.Size = new System.Drawing.Size(624, 382);
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
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox FotoDePerfil;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}
