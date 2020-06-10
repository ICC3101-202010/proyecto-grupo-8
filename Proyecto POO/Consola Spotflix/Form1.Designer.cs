namespace Consola_Spotflix
{
    partial class Main_Spotflix
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
            this.label3 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Registrarse = new System.Windows.Forms.Button();
            this.Aceptar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.informacion1 = new Consola_Spotflix.Informacion();
            this.cambiodeCuenta1 = new Consola_Spotflix.CambiodeCuenta();
            this.main_menu1 = new Consola_Spotflix.Main_menu();
            this.nuevoPerfil1 = new Proyecto_POO.NuevoPerfil();
            this.perfiles1 = new Proyecto_POO.Perfiles();
            this.Usuarionoencontrado = new System.Windows.Forms.Label();
            this.crearCuenta1 = new Consola_Spotflix.CrearCuenta();
            this.cambiodeCuenta2 = new Consola_Spotflix.CambiodeCuenta();
            this.crearPlaylist1 = new Consola_Spotflix.CrearPlaylist();
            this.buscador1 = new Consola_Spotflix.Buscador();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Menu;
            this.label3.Location = new System.Drawing.Point(501, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 73);
            this.label3.TabIndex = 13;
            this.label3.Text = "Spotflix";
            // 
            // textBox2
            // 
            this.textBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox2.Location = new System.Drawing.Point(496, 330);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(264, 20);
            this.textBox2.TabIndex = 12;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Menu;
            this.textBox1.Location = new System.Drawing.Point(496, 274);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(264, 20);
            this.textBox1.TabIndex = 11;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.Menu;
            this.label2.Location = new System.Drawing.Point(402, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Contraseña:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.ForeColor = System.Drawing.SystemColors.Menu;
            this.label1.Location = new System.Drawing.Point(431, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Email:";
            // 
            // Registrarse
            // 
            this.Registrarse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Registrarse.Location = new System.Drawing.Point(462, 392);
            this.Registrarse.Name = "Registrarse";
            this.Registrarse.Size = new System.Drawing.Size(343, 44);
            this.Registrarse.TabIndex = 8;
            this.Registrarse.Text = "Registrarse";
            this.Registrarse.UseVisualStyleBackColor = true;
            this.Registrarse.Click += new System.EventHandler(this.Registrarse_Click);
            // 
            // Aceptar
            // 
            this.Aceptar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Aceptar.Location = new System.Drawing.Point(774, 324);
            this.Aceptar.Name = "Aceptar";
            this.Aceptar.Size = new System.Drawing.Size(116, 30);
            this.Aceptar.TabIndex = 7;
            this.Aceptar.Text = "Aceptar";
            this.Aceptar.UseVisualStyleBackColor = true;
            this.Aceptar.Click += new System.EventHandler(this.Aceptar_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buscador1);
            this.panel1.Controls.Add(this.crearPlaylist1);
            this.panel1.Controls.Add(this.cambiodeCuenta2);
            this.panel1.Controls.Add(this.informacion1);
            this.panel1.Controls.Add(this.cambiodeCuenta1);
            this.panel1.Controls.Add(this.main_menu1);
            this.panel1.Controls.Add(this.nuevoPerfil1);
            this.panel1.Controls.Add(this.perfiles1);
            this.panel1.Controls.Add(this.Usuarionoencontrado);
            this.panel1.Controls.Add(this.crearCuenta1);
            this.panel1.Controls.Add(this.Aceptar);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Registrarse);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1264, 681);
            this.panel1.TabIndex = 14;
            // 
            // informacion1
            // 
            this.informacion1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.informacion1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.informacion1.Location = new System.Drawing.Point(0, 0);
            this.informacion1.Name = "informacion1";
            this.informacion1.Size = new System.Drawing.Size(1264, 681);
            this.informacion1.TabIndex = 20;
            this.informacion1.Visible = false;
            // 
            // cambiodeCuenta1
            // 
            this.cambiodeCuenta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cambiodeCuenta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cambiodeCuenta1.Location = new System.Drawing.Point(0, 0);
            this.cambiodeCuenta1.Name = "cambiodeCuenta1";
            this.cambiodeCuenta1.Size = new System.Drawing.Size(1264, 681);
            this.cambiodeCuenta1.TabIndex = 19;
            this.cambiodeCuenta1.Visible = false;
            // 
            // main_menu1
            // 
            this.main_menu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.main_menu1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_menu1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.main_menu1.Location = new System.Drawing.Point(0, 0);
            this.main_menu1.Margin = new System.Windows.Forms.Padding(0);
            this.main_menu1.MinimumSize = new System.Drawing.Size(500, 500);
            this.main_menu1.Name = "main_menu1";
            this.main_menu1.Size = new System.Drawing.Size(1264, 681);
            this.main_menu1.TabIndex = 18;
            this.main_menu1.Visible = false;
            // 
            // nuevoPerfil1
            // 
            this.nuevoPerfil1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.nuevoPerfil1.Location = new System.Drawing.Point(0, 0);
            this.nuevoPerfil1.Name = "nuevoPerfil1";
            this.nuevoPerfil1.Size = new System.Drawing.Size(955, 452);
            this.nuevoPerfil1.TabIndex = 17;
            this.nuevoPerfil1.Visible = false;
            // 
            // perfiles1
            // 
            this.perfiles1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.perfiles1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.perfiles1.Location = new System.Drawing.Point(0, 0);
            this.perfiles1.Name = "perfiles1";
            this.perfiles1.Size = new System.Drawing.Size(1264, 681);
            this.perfiles1.TabIndex = 16;
            this.perfiles1.Visible = false;
            // 
            // Usuarionoencontrado
            // 
            this.Usuarionoencontrado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Usuarionoencontrado.ForeColor = System.Drawing.SystemColors.Menu;
            this.Usuarionoencontrado.Location = new System.Drawing.Point(782, 277);
            this.Usuarionoencontrado.Name = "Usuarionoencontrado";
            this.Usuarionoencontrado.Size = new System.Drawing.Size(108, 28);
            this.Usuarionoencontrado.TabIndex = 15;
            this.Usuarionoencontrado.Text = "Usuario no encontrado";
            this.Usuarionoencontrado.Visible = false;
            // 
            // crearCuenta1
            // 
            this.crearCuenta1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.crearCuenta1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crearCuenta1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.crearCuenta1.Location = new System.Drawing.Point(0, 0);
            this.crearCuenta1.Name = "crearCuenta1";
            this.crearCuenta1.Size = new System.Drawing.Size(1264, 681);
            this.crearCuenta1.TabIndex = 14;
            this.crearCuenta1.Visible = false;
            // 
            // cambiodeCuenta2
            // 
            this.cambiodeCuenta2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.cambiodeCuenta2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cambiodeCuenta2.Location = new System.Drawing.Point(0, 0);
            this.cambiodeCuenta2.Name = "cambiodeCuenta2";
            this.cambiodeCuenta2.Size = new System.Drawing.Size(1264, 681);
            this.cambiodeCuenta2.TabIndex = 21;
            this.cambiodeCuenta2.Visible = false;
            // 
            // crearPlaylist1
            // 
            this.crearPlaylist1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.crearPlaylist1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.crearPlaylist1.Location = new System.Drawing.Point(0, 0);
            this.crearPlaylist1.Name = "crearPlaylist1";
            this.crearPlaylist1.Size = new System.Drawing.Size(1264, 681);
            this.crearPlaylist1.TabIndex = 22;
            this.crearPlaylist1.Visible = false;
            // 
            // buscador1
            // 
            this.buscador1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.buscador1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buscador1.ForeColor = System.Drawing.SystemColors.Menu;
            this.buscador1.Location = new System.Drawing.Point(0, 0);
            this.buscador1.Name = "buscador1";
            this.buscador1.Size = new System.Drawing.Size(1264, 681);
            this.buscador1.TabIndex = 23;
            this.buscador1.Visible = false;
            // 
            // Main_Spotflix
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "Main_Spotflix";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consola Spotflix";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Registrarse;
        private System.Windows.Forms.Button Aceptar;
        private System.Windows.Forms.Panel panel1;
        private CrearCuenta crearCuenta1;
        private System.Windows.Forms.Label Usuarionoencontrado;
        private Proyecto_POO.Perfiles perfiles1;
        private Proyecto_POO.NuevoPerfil nuevoPerfil1;
        private Main_menu main_menu1;
        private Informacion informacion1;
        private CambiodeCuenta cambiodeCuenta1;
        private CambiodeCuenta cambiodeCuenta2;
        private CrearPlaylist crearPlaylist1;
        private Buscador buscador1;
    }
}

