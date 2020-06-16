namespace Consola_Spotflix
{
    partial class CrearPlaylist
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBoxTipoMulti = new System.Windows.Forms.ComboBox();
            this.textBoxnombre = new System.Windows.Forms.TextBox();
            this.comboBoxPrivacidad = new System.Windows.Forms.ComboBox();
            this.botonCrear = new System.Windows.Forms.Button();
            this.botonAtras = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(320, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Crear Playlist";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(323, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Multimedia";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(323, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Menu;
            this.label4.Location = new System.Drawing.Point(323, 277);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nombre";
            // 
            // comboBoxTipoMulti
            // 
            this.comboBoxTipoMulti.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.comboBoxTipoMulti.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxTipoMulti.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxTipoMulti.FormattingEnabled = true;
            this.comboBoxTipoMulti.Location = new System.Drawing.Point(444, 227);
            this.comboBoxTipoMulti.Name = "comboBoxTipoMulti";
            this.comboBoxTipoMulti.Size = new System.Drawing.Size(283, 21);
            this.comboBoxTipoMulti.TabIndex = 5;
            this.comboBoxTipoMulti.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoMulti_SelectedIndexChanged);
            // 
            // textBoxnombre
            // 
            this.textBoxnombre.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBoxnombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxnombre.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBoxnombre.Location = new System.Drawing.Point(444, 276);
            this.textBoxnombre.Name = "textBoxnombre";
            this.textBoxnombre.Size = new System.Drawing.Size(283, 20);
            this.textBoxnombre.TabIndex = 6;
            // 
            // comboBoxPrivacidad
            // 
            this.comboBoxPrivacidad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.comboBoxPrivacidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxPrivacidad.ForeColor = System.Drawing.SystemColors.Menu;
            this.comboBoxPrivacidad.FormattingEnabled = true;
            this.comboBoxPrivacidad.Location = new System.Drawing.Point(444, 327);
            this.comboBoxPrivacidad.Name = "comboBoxPrivacidad";
            this.comboBoxPrivacidad.Size = new System.Drawing.Size(283, 21);
            this.comboBoxPrivacidad.TabIndex = 7;
            // 
            // botonCrear
            // 
            this.botonCrear.Location = new System.Drawing.Point(838, 461);
            this.botonCrear.Name = "botonCrear";
            this.botonCrear.Size = new System.Drawing.Size(94, 34);
            this.botonCrear.TabIndex = 8;
            this.botonCrear.Text = "Crear";
            this.botonCrear.UseVisualStyleBackColor = true;
            this.botonCrear.Click += new System.EventHandler(this.botonCrear_Click);
            // 
            // botonAtras
            // 
            this.botonAtras.Location = new System.Drawing.Point(838, 117);
            this.botonAtras.Name = "botonAtras";
            this.botonAtras.Size = new System.Drawing.Size(94, 30);
            this.botonAtras.TabIndex = 9;
            this.botonAtras.Text = "Atras";
            this.botonAtras.UseVisualStyleBackColor = true;
            this.botonAtras.Click += new System.EventHandler(this.botonAtras_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Lime;
            this.label5.Location = new System.Drawing.Point(829, 332);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "¡Playlist creada!";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(756, 418);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(239, 16);
            this.label6.TabIndex = 11;
            this.label6.Text = "¡Recuerda rellenar todos los espacios!";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.botonAtras);
            this.panel1.Controls.Add(this.botonCrear);
            this.panel1.Controls.Add(this.comboBoxPrivacidad);
            this.panel1.Controls.Add(this.textBoxnombre);
            this.panel1.Controls.Add(this.comboBoxTipoMulti);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 12;
            // 
            // CrearPlaylist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.Controls.Add(this.panel1);
            this.Name = "CrearPlaylist";
            this.Size = new System.Drawing.Size(1264, 681);
            this.Load += new System.EventHandler(this.CrearPlaylist_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBoxTipoMulti;
        private System.Windows.Forms.TextBox textBoxnombre;
        private System.Windows.Forms.ComboBox comboBoxPrivacidad;
        private System.Windows.Forms.Button botonCrear;
        private System.Windows.Forms.Button botonAtras;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
    }
}
